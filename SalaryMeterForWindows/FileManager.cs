using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryMeterForWindows
{
    class FileManager
    {
    }

    class FileManagerForCoutUpSetting
    {
        private static FileManagerForCoutUpSetting fileManagerForCoutUpSetting = new FileManagerForCoutUpSetting();

        private FileManagerForCoutUpSetting()
        {
            // singleton pattern
            // nothing to do
        }

        public FileManagerForCoutUpSetting getInstance()
        {
            return fileManagerForCoutUpSetting;
        }
    }

    class FileManagerForState
    {
        private static FileManagerForState fileManagerForState = new FileManagerForState();

        private FileManagerForState()
        {
            // singleton pattern
            // nothing to do
        }

        public FileManagerForState getInstance()
        {
            return fileManagerForState;
        }
    }
}
