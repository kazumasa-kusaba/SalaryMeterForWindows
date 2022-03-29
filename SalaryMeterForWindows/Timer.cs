using System;
using System.Diagnostics;
using System.Timers;

namespace SalaryMeterForWindows
{
    class Timer
    {
        private Action<uint> amountOfSalaryCallback = null;
        private Action<uint> elapsedTimeSecCallback = null;
        private Action<uint> wegePerHourCallback = null;
        
        System.Timers.Timer timer = null;

        private struct WegeInformation
        {
            public uint elapsedTimeSec;
            public uint wegePerHour;
        }
        private WegeInformation wegeInformation = new WegeInformation();

        public Timer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += onTimedEvent;
            timer.AutoReset = true;

            wegeInformation.elapsedTimeSec = 0;
            wegeInformation.wegePerHour = 0;
        }

        public void setAmountOfSalaryCallback(Action<uint> callback)
        {
            this.amountOfSalaryCallback = callback;
        }

        public void setElapsedTimeSecCallback(Action<uint> callback)
        {
            this.elapsedTimeSecCallback = callback;
        }

        public void setWegePerHourCallback(Action<uint> callback)
        {
            this.wegePerHourCallback = callback;
        }

        public void setWegePerHour(uint wegePerHour)
        {
            wegeInformation.wegePerHour = wegePerHour;
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
            wegeInformation.elapsedTimeSec = 0;
            amountOfSalaryCallback(0);
            elapsedTimeSecCallback(0);
        }

        public void reset()
        {
            timer.Enabled = false;
            wegeInformation.elapsedTimeSec = 0;
            amountOfSalaryCallback(0);
            elapsedTimeSecCallback(0);
        }

        private void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            // Debug
            DateTime dt = DateTime.Now;
            Debug.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss"));

            wegeInformation.elapsedTimeSec += 1;

            uint amountOfSalary = (uint)(wegeInformation.wegePerHour / 3600.0 * wegeInformation.elapsedTimeSec);

            // Notify the amount of salary
            if (amountOfSalaryCallback != null)
            {
                amountOfSalaryCallback(amountOfSalary);
            }

            // notify the elapsed time
            if (elapsedTimeSecCallback != null)
            {
                elapsedTimeSecCallback(wegeInformation.elapsedTimeSec);
            }

            // notify the salary per hour
            if (wegePerHourCallback != null)
            {
                wegePerHourCallback(wegeInformation.wegePerHour);
            }
        }
    }
}
