using System;
using System.Diagnostics;
using System.Timers;

namespace SalaryMeterForWindows
{
    class Timer
    {
        private Action<uint> amountOfSalaryCallback = null;
        private Action<uint> elapsedTimeSecCallback = null;
        private Action<uint> wagePerHourCallback = null;
        
        System.Timers.Timer timer = null;

        private struct WageInfo
        {
            public uint elapsedTimeSec;
            public uint wagePerHour;
        }
        private WageInfo wageInfo = new WageInfo();

        public Timer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += onTimedEvent;
            timer.AutoReset = true;

            wageInfo.elapsedTimeSec = 0;
            wageInfo.wagePerHour = 0;
        }

        public void setAmountOfSalaryCallback(Action<uint> callback)
        {
            this.amountOfSalaryCallback = callback;
        }

        public void setElapsedTimeSecCallback(Action<uint> callback)
        {
            this.elapsedTimeSecCallback = callback;
        }

        public void setWagePerHourCallback(Action<uint> callback)
        {
            this.wagePerHourCallback = callback;
        }

        public void setWagePerHour(uint wagePerHour)
        {
            wageInfo.wagePerHour = wagePerHour;
        }

        public uint getWagePerHour()
        {
            return wageInfo.wagePerHour;
        }

        public void start()
        {
            timer.Enabled = true;
        }

        public void pause()
        {
            timer.Enabled = false;
        }

        public void stop()
        {
            timer.Enabled = false;
            wageInfo.elapsedTimeSec = 0;
            amountOfSalaryCallback(0);
            elapsedTimeSecCallback(0);
        }

        public void reset()
        {
            timer.Enabled = false;
            wageInfo.elapsedTimeSec = 0;
            amountOfSalaryCallback(0);
            elapsedTimeSecCallback(0);
        }

        private void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            // Debug
            DateTime dt = DateTime.Now;
            Debug.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss"));

            wageInfo.elapsedTimeSec += 1;

            uint amountOfSalary = (uint)(wageInfo.wagePerHour / 3600.0 * wageInfo.elapsedTimeSec);

            // Notify the amount of salary
            if (amountOfSalaryCallback != null)
            {
                amountOfSalaryCallback(amountOfSalary);
            }

            // notify the elapsed time
            if (elapsedTimeSecCallback != null)
            {
                elapsedTimeSecCallback(wageInfo.elapsedTimeSec);
            }

            // notify the salary per hour
            if (wagePerHourCallback != null)
            {
                wagePerHourCallback(wageInfo.wagePerHour);
            }
        }
    }
}
