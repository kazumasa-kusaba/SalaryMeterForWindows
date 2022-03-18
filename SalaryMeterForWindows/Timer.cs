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
        System.Timers.Timer timer = null;
        private struct SalaryInformation
        {
            public uint totalSalary;
            public uint elapsedTimeSec;
            public uint salaryPerHour;
        }
        private SalaryInformation salaryInformation = new SalaryInformation();

        public Timer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += onTimedEvent;
            timer.AutoReset = true;

            salaryInformation.totalSalary = 0;
            salaryInformation.elapsedTimeSec = 0;
            salaryInformation.salaryPerHour = 0;
        }

        public void setTotalSalaryCallback(Action<uint> callback)
        {
            this.totalSalaryCallback = callback;
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
            salaryInformation.totalSalary = 0;
            salaryInformation.elapsedTimeSec = 0;
            totalSalaryCallback(0);
        }

        public void reset()
        {
            timer.Enabled = false;
            salaryInformation.totalSalary = 0;
            salaryInformation.elapsedTimeSec = 0;
            totalSalaryCallback(0);
        }

        private void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            // DEBUG:
            DateTime dt = DateTime.Now;
            Debug.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss"));

            // CAUTION: the accuracy is not considered at all...
            salaryInformation.totalSalary += salaryInformation.salaryPerHour / 60;

            salaryInformation.elapsedTimeSec += 1;

            // notify the total salary
            if (totalSalaryCallback != null)
            {
                totalSalaryCallback(salaryInformation.totalSalary);
            }
        }
    }
}
