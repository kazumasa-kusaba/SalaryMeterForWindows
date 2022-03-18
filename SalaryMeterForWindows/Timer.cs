using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Timers;

namespace SalaryMeterForWindows
{
    class Timer
    {
        private Action<uint> totalSalaryCallback = null;
        private Action<uint> elapsedTimeSecCallback = null;
        private Action<uint> salaryPerHourCallback = null;
        System.Timers.Timer timer = null;
        private struct SalaryInformation
        {
            public uint elapsedTimeSec;
            public uint salaryPerHour;
        }
        private SalaryInformation salaryInformation = new SalaryInformation();

        public Timer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += onTimedEvent;
            timer.AutoReset = true;

            /*
            salaryInformation.elapsedTimeSec = 0;
            salaryInformation.salaryPerHour = 0;
            */
            // DEBUG:
            salaryInformation.elapsedTimeSec = 60 * 60;
            salaryInformation.salaryPerHour = 2343;
        }

        public void setTotalSalaryCallback(Action<uint> callback)
        {
            this.totalSalaryCallback = callback;
        }

        public void setElapsedTimeSecCallback(Action<uint> callback)
        {
            this.elapsedTimeSecCallback = callback;
        }

        public void setSalaryPerHourCallback(Action<uint> callback)
        {
            this.salaryPerHourCallback = callback;
        }

        public void setElapsedTimeSec(uint timeSec)
        {
            salaryInformation.elapsedTimeSec = timeSec;
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
            salaryInformation.elapsedTimeSec = 0;
            totalSalaryCallback(0);
            elapsedTimeSecCallback(0);
        }

        public void reset()
        {
            timer.Enabled = false;
            salaryInformation.elapsedTimeSec = 0;
            totalSalaryCallback(0);
            elapsedTimeSecCallback(0);
        }

        private void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            // DEBUG:
            DateTime dt = DateTime.Now;
            Debug.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss"));

            salaryInformation.elapsedTimeSec += 1;

            uint totalSalary = (uint)(salaryInformation.salaryPerHour / 3600.0 * salaryInformation.elapsedTimeSec);

            // notify the total salary
            if (totalSalaryCallback != null)
            {
                totalSalaryCallback(totalSalary);
            }

            // notify the elapsed time
            if (elapsedTimeSecCallback != null)
            {
                elapsedTimeSecCallback(salaryInformation.elapsedTimeSec);
            }

            // notify the salary per hour
            if (salaryPerHourCallback != null)
            {
                salaryPerHourCallback(salaryInformation.salaryPerHour);
            }
        }
    }
}
