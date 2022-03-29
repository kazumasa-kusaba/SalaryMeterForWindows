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

        private State state = WaitSetting.getInstance();
        private Timer timer = new Timer();

        private Action<uint> salaryPerHourCallback = null;

        private StateManager()
        {
            // singleton
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

        public void setSalaryPerHourCallback(Action<uint> callback)
        {
            salaryPerHourCallback = callback;
            timer.setSalaryPerHourCallback(callback);
        }

        public void setSalaryPerHour(uint salaryPerHour)
        {
            timer.setSalaryPerHour(salaryPerHour);
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

        public void setSalary()
        {
            state.setSalary(this);
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

        public void updateSalaryPerHour(uint salaryPerHour)
        {
            // notify the salary per hour
            if (salaryPerHourCallback != null)
            {
                salaryPerHourCallback(salaryPerHour);
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
        void setSalary(StateManager stateManager);
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
                stateManager.setSalaryPerHour(settingForm.salaryPerHour);
                stateManager.startTimer();
                stateManager.updateSalaryPerHour(settingForm.salaryPerHour);
                stateManager.changeState(RunState.getInstance());
            }
        }
        public void pause(StateManager stateManager)
        {
            // nothing to do
        }

        public void reset(StateManager stateManager)
        {
            stateManager.resetTimer();
        }

        public void setSalary(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setSalaryPerHour(settingForm.salaryPerHour);
                stateManager.updateSalaryPerHour(settingForm.salaryPerHour);
            }
        }
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
        public void setSalary(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setSalaryPerHour(settingForm.salaryPerHour);
                stateManager.updateSalaryPerHour(settingForm.salaryPerHour);
            }
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
        public void setSalary(StateManager stateManager)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (settingForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stateManager.setSalaryPerHour(settingForm.salaryPerHour);
                stateManager.updateSalaryPerHour(settingForm.salaryPerHour);
            }
        }
    }
}
