using System;
using System.Windows.Forms;

namespace SalaryMeterForWindows
{
    public partial class SettingForm : Form
    {
        private uint _wagePerHour = 0;

        public SettingForm(uint wagePerHour)
        {
            InitializeComponent();

            // Set the default wage per hour
            numericUpDownWagePerHour.Value = wagePerHour;

            // Set the cursor to the most right
            numericUpDownWagePerHour.Select(numericUpDownWagePerHour.Value.ToString().Length, 0);
        }

        public uint wagePerHour
        {
            get { return _wagePerHour; }
            set { _wagePerHour = value; }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _wagePerHour = (uint)numericUpDownWagePerHour.Value;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Nothing to do
        }
    }
}
