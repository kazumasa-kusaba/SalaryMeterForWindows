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
        private CountUp countUp = null;
        private Action<uint> counterCallback = null;
        System.Timers.Timer timer = null;

        // DEBUG:
        private uint temp = 0;

        public Timer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += onTimedEvent;
            timer.AutoReset = true;
        }

        public void setCounterCallback(Action<uint> callback)
        {
            this.counterCallback = callback;
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
            temp = 0;
            counterCallback(0);
        }

        public void reset()
        {
            timer.Enabled = false;
            temp = 0;
            counterCallback(0);
        }

        public void changeALgorithm()
        {

        }

        private void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            Debug.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss"));

            counterCallback(temp);
            temp += 1;
        }
    }

    interface CountUp
    {

    }

    /* ------------------------------------------------------
     *  Write the count up algorithms below if you wan to add.
     * ------------------------------------------------------*/ 
    class CountUpAlgorithm1 : CountUp
    {

    }

    class CountUpAlgorithm2 : CountUp
    {

    }
}
