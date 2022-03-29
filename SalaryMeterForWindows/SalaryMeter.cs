using System;

namespace SalaryMeterForWindows
{
    class SalaryMeter
    {
        private StateManager stateManager = StateManager.getInstance();

        public void setAmountOfSalaryCallback(Action<uint> callback)
        {
            stateManager.setAmountOfSalaryCallback(callback);
        }

        public void setElapsedTimeSecCallback(Action<uint> callback)
        {
            stateManager.setElapsedTimeSecCallback(callback);
        }

        public void setSalaryPerHourCallback(Action<uint> callback)
        {
            stateManager.setSalaryPerHourCallback(callback);
        }

        public void setSalaryPerHour(uint salaryPerHour)
        {
            stateManager.setSalaryPerHour(salaryPerHour);
        }

        public void start()
        {
            stateManager.start();
        }

        public void pause()
        {
            stateManager.pause();
        }

        public void reset()
        {
            stateManager.reset();
        }

        public void setSalary()
        {
            stateManager.setSalary();
        }
    }
}
