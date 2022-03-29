using System;
using System.Windows.Forms;

namespace SalaryMeterForWindows
{
    public partial class SettingForm : Form
    {
        private uint _wegePerHour = 0;

        public SettingForm()
        {
            InitializeComponent();

            // Set the cursor to the most right
            numericUpDownWegePerHour.Select(numericUpDownWegePerHour.Value.ToString().Length, 0);
        }

        public uint wegePerHour
        {
            get
            {
                return _wegePerHour;
            }
            set
            {
                _wegePerHour = value;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _wegePerHour = (uint)numericUpDownWegePerHour.Value;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Nothing to do
        }
    }
}
