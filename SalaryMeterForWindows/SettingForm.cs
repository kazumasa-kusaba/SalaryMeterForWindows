using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryMeterForWindows
{
    public partial class SettingForm : Form
    {
        private uint _salaryPerHour = 0;

        public SettingForm()
        {
            InitializeComponent();
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
