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
        private StateManager stateManager = StateManager.getInstance();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            stateManager.start();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            stateManager.pause();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            stateManager.reset();
        }
    }
}
