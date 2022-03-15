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
    public partial class MainForm : Form
    {
        private State state = null;

        public MainForm()
        {
            InitializeComponent();

            state = PauseState.getInstance();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonPause_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
