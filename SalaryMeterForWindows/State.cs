using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryMeterForWindows
{
    abstract class State
    {
        private FileManager fileManager = null;

        public State()
        {
            fileManager = FileManager.getInstance();
        }

        public void start()
        {
            // nothing to do
        }
        
        public void pause()
        {
            // nothing to do
        }

        public void reset()
        {
            // nothing to do
        }
    }

    class PauseState : State
    {
        private static PauseState pauseState = new PauseState();

        private PauseState()
        {
            // singleton pattern
            // nothing to do
        }

        public static PauseState getInstance()
        {
            return pauseState;
        }
    }

    class RunState : State
    {
        private static RunState runState = new RunState();

        private RunState()
        {
            // singleton pattern
            // nothing to do
        }

        public static RunState getInstance()
        {
            return runState;
        }
    }

    class ResetState : State
    {
        private static ResetState resetState = new ResetState();

        private ResetState()
        {
            // singleton pattern
            // nothing to do
        }

        public static ResetState getInstance()
        {
            return resetState;
        }
    }
}
