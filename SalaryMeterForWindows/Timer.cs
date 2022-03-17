using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryMeterForWindows
{
    class Timer
    {
        private static Timer timer = new Timer();

        private CountUp countUp = null;

        private Timer()
        {
            // singleton pattern
            // nothing to do
        }

        public static Timer getInstance()
        {
            return timer;
        }

        public void changeALgorithm()
        {

        }

        public void start()
        {

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
