using System;
using System.Diagnostics;

namespace SalaryMeterForWindows
{
    class StateManager
    {
        private static StateManager stateManager = new StateManager();
        private State state = WaitSetting.getInstance();
        private Timer timer = new Timer();
        private Action<uint> wagePerHourCallback = null;

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

        public void setWagePerHourCallback(Action<uint> callback)
        {
            wagePerHourCallback = callback;
            timer.setWagePerHourCallback(callback);
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

        public void setWage()
        {
            state.setWage(this);
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

        public void setWagePerHour(uint wagePerHour)
        {
            timer.setWagePerHour(wagePerHour);
        }

        public uint getWagePerHour()
        {
            return timer.getWagePerHour();
        }

        public void updateWagePerHour(uint wagePerHour)
        {
            // Notify the wage per hour
            if (wagePerHourCallback != null)
            {
                wagePerHourCallback(wagePerHour);
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
        void setWage(StateManager stateManager);
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
            SettingForm settingForm = new SettingForm(stateManager.getWagePerHour());
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setWagePerHour(settingForm.wagePerHour);
                stateManager.startTimer();
                stateManager.updateWagePerHour(settingForm.wagePerHour);
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

        public void setWage(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm(stateManager.getWagePerHour());
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setWagePerHour(settingForm.wagePerHour);
                stateManager.updateWagePerHour(settingForm.wagePerHour);
                stateManager.changeState(PauseState.getInstance());
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
        public void setWage(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm(stateManager.getWagePerHour());
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setWagePerHour(settingForm.wagePerHour);
                stateManager.updateWagePerHour(settingForm.wagePerHour);
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
        public void setWage(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm(stateManager.getWagePerHour());
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setWagePerHour(settingForm.wagePerHour);
                stateManager.updateWagePerHour(settingForm.wagePerHour);
            }
        }
    }
}
