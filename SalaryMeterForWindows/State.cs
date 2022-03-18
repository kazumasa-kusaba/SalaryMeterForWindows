using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryMeterForWindows
{
    class StateManager
    {
        private static StateManager stateManager = new StateManager();

        private State state = PauseState.getInstance();
        private Timer timer = new Timer();

        private StateManager()
        {
            // singleton
        }

        public static StateManager getInstance()
        {
            return stateManager;
        }

        public void setCounterCallback(Action<uint> callback)
        {
            timer.setCounterCallback(callback);
        }

        public void start()
        {
            state.start(this);
            Debug.WriteLine("state: " + this.state.stateName);
        }

        public void pause()
        {
            state.pause(this);
            Debug.WriteLine("state: " + this.state.stateName);
        }

        public void reset()
        {
            state.reset(this);
            Debug.WriteLine("state: " + this.state.stateName);
        }

        public void changeState(State state)
        {
            this.state = state;
        }

        public void startTimer()
        {
            timer.start();
        }

        public void pauseTimer()
        {
            timer.pause();
        }

        public void stopTimer()
        {
            timer.stop();
        }

        public void resetTimer()
        {
            timer.reset();
        }
    }

    interface State
    {
        string stateName
        {
            get;
        }

        void start(StateManager stateManager);
        void pause(StateManager stateManager);
        void reset(StateManager stateManager);
    }

    class PauseState : State
    {
        private static PauseState pauseState = new PauseState();
        private const string _stateName = "Pause";

        private PauseState()
        {
            // singleton pattern
        }

        public static PauseState getInstance()
        {
            return pauseState;
        }

        public string stateName
        {
            get => _stateName;
        }

        public void start(StateManager stateManager)
        {
            stateManager.startTimer();
            stateManager.changeState(RunState.getInstance());
        }
        public void pause(StateManager stateManager)
        {
            // nothing to do
        }

        public void reset(StateManager stateManager)
        {
            stateManager.resetTimer();
        }
    }

    class RunState : State
    {
        private static RunState runState = new RunState();
        private const string _stateName = "Run";

        private RunState()
        {
            // singleton pattern
            // nothing to do
        }

        public static RunState getInstance()
        {
            return runState;
        }

        public string stateName
        {
            get => _stateName;
        }

        public void start(StateManager stateManager)
        {
            // nothing to do
        }
        public void pause(StateManager stateManager)
        {
            stateManager.pauseTimer();
            stateManager.changeState(PauseState.getInstance());
        }

        public void reset(StateManager stateManager)
        {
            stateManager.resetTimer();
            stateManager.changeState(PauseState.getInstance());
        }
    }
}
