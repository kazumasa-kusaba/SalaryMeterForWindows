using System;
using System.Windows.Forms;

namespace SalaryMeterForWindows
{
    public partial class SettingForm : Form
    {
        private uint _salaryPerHour = 0;

        public SettingForm()
        {
            InitializeComponent();

            // Set the cursor to the most right
            numericUpDownSalaryPerHour.Select(numericUpDownSalaryPerHour.Value.ToString().Length, 0);
        }

        public uint salaryPerHour
        {
            get
            {
                return _salaryPerHour;
            }
            set
            {
                _salaryPerHour = value;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _salaryPerHour = (uint)numericUpDownSalaryPerHour.Value;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // nothing to do
        }
    }
}
