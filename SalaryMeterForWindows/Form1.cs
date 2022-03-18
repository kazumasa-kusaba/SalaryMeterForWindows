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
        private Label[] labelNumbers;

        public MainForm()
        {
            InitializeComponent();

            labelNumbers = new Label[] { 
                labelNumber1, labelNumber2, labelNumber3, 
                labelNumber4, labelNumber5, labelNumber6, 
                labelNumber7, labelNumber8, labelNumber9 };

            stateManager.setCounterCallback(updateNumbersCallback);
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

        private void updateNumbersCallback(uint val)
        {
            Action action = delegate
            {
                uint[] numberVals = new uint[labelNumbers.Length];

                if (val >= 999999999)
                {
                    for (int i = 0; i < numberVals.Length; i++)
                    {
                        labelNumbers[i].Text = "9";
                    }
                    return;
                }

                for (int i = 0; i < numberVals.Length; i++)
                {
                    labelNumbers[i].Text = (val % 10).ToString();
                    val /= 10;
                }
            };

            Invoke(action);
        }
    }
}
