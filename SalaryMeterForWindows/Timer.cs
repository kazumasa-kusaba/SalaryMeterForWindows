using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace SalaryMeterForWindows
{
    class Timer
    {
        private CountUp countUp = null;
        private Thread thread = null;

        public Timer()
        {
            thread = new Thread(new ThreadStart(threadEntry));
        }

        ~Timer()
        {

        }

        private void threadEntry()
        {
            while (true)
            {
                DateTime dt = DateTime.Now;
                Debug.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss"));

                Thread.Sleep(1000);
            }
        }

        public void changeALgorithm()
        {

        }

        public void start()
        {
            thread.Start();
        }

        public void pause()
        {

        }

        public void stop()
        {

        }

        public void reset()
        {

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
