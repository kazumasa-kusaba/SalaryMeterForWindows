using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryMeterForWindows
{
    class FileManager
    {
        private static FileManager fileManager = new FileManager();

        private FileManager()
        {
            // singleton pattern
            // nothing to do
        }

        public static FileManager getInstance()
        {
            return fileManager;
        }
    }

    class FileManagerForCoutUpSetting
    {
        private static FileManagerForCoutUpSetting fileManagerForCoutUpSetting = new FileManagerForCoutUpSetting();

        private FileManagerForCoutUpSetting()
        {
            // singleton pattern
            // nothing to do
        }

        public static FileManagerForCoutUpSetting getInstance()
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

        public static FileManagerForState getInstance()
        {
            return fileManagerForState;
        }
    }
}
