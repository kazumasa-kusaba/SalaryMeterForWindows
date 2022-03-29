using System;
using System.Diagnostics;

namespace SalaryMeterForWindows
{
    class StateManager
    {
        private static StateManager stateManager = new StateManager();
        private State state = WaitSetting.getInstance();
        private Timer timer = new Timer();
        private Action<uint> wegePerHourCallback = null;

        private StateManager()
        {
            // Singleton
        }

        public static StateManager getInstance()
        {
            return stateManager;
        }

        public void setAmountOfSalaryCallback(Action<uint> callback)
        {
            timer.setAmountOfSalaryCallback(callback);
        }

        public void setElapsedTimeSecCallback(Action<uint> callback)
        {
            timer.setElapsedTimeSecCallback(callback);
        }

        public void setWegePerHourCallback(Action<uint> callback)
        {
            wegePerHourCallback = callback;
            timer.setWegePerHourCallback(callback);
        }

        public void setWegePerHour(uint wegePerHour)
        {
            timer.setWegePerHour(wegePerHour);
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

        public void setWege()
        {
            state.setWege(this);
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

        public void updateWegePerHour(uint wegePerHour)
        {
            // Notify the wege per hour
            if (wegePerHourCallback != null)
            {
                wegePerHourCallback(wegePerHour);
            }
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
        void setWege(StateManager stateManager);
    }

    class WaitSetting : State
    {
        private static WaitSetting waitSetting = new WaitSetting();
        private const string _stateName = "WaitSetting";

        public static WaitSetting getInstance()
        {
            return waitSetting;
        }

        public string stateName
        {
            get => _stateName;
        }

        public void start(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setWegePerHour(settingForm.wegePerHour);
                stateManager.startTimer();
                stateManager.updateWegePerHour(settingForm.wegePerHour);
                stateManager.changeState(RunState.getInstance());
            }
        }
        public void pause(StateManager stateManager)
        {
            // Nothing to do
        }

        public void reset(StateManager stateManager)
        {
            stateManager.resetTimer();
        }

        public void setWege(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setWegePerHour(settingForm.wegePerHour);
                stateManager.updateWegePerHour(settingForm.wegePerHour);
            }
        }
    }

    class PauseState : State
    {
        private static PauseState pauseState = new PauseState();
        private const string _stateName = "Pause";

        private PauseState()
        {
            // Singleton
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
            // Nothing to do
        }

        public void reset(StateManager stateManager)
        {
            stateManager.resetTimer();
        }
        public void setWege(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setWegePerHour(settingForm.wegePerHour);
                stateManager.updateWegePerHour(settingForm.wegePerHour);
            }
        }
    }

    class RunState : State
    {
        private static RunState runState = new RunState();
        private const string _stateName = "Run";

        private RunState()
        {
            // Singleton
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
            // Nothing to do
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
        public void setWege(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setWegePerHour(settingForm.wegePerHour);
                stateManager.updateWegePerHour(settingForm.wegePerHour);
            }
        }
    }
}
