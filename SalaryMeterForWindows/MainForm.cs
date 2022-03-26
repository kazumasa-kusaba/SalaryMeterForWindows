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

            stateManager.setTotalSalaryCallback(updateNumbersCallback);
            stateManager.setElapsedTimeSecCallback(updateElapsedTime);
            stateManager.setSalaryPerHourCallback(updateSalaryPerHour);
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

        private void updateNumbersCallback(uint totalSalary)
        {
            Action action = delegate
            {
                uint[] numberVals = new uint[labelNumbers.Length];

                if (totalSalary >= 999999999)
                {
                    for (int i = 0; i < numberVals.Length; i++)
                    {
                        labelNumbers[i].Text = "9";
                    }
                    return;
                }

                for (int i = 0; i < numberVals.Length; i++)
                {
                    labelNumbers[i].Text = (totalSalary % 10).ToString();
                    totalSalary /= 10;
                }
            };

            Invoke(action);
        }
        private void updateElapsedTime(uint elapsedTimeSec)
        {
            Action action = delegate
            {
                String title = "Elapsed Time: ";
                TimeSpan timeSpan = new TimeSpan(0, 0, (int)elapsedTimeSec);

                //labelElapsedTime.Text = title + timeSpan.Hours.ToString("00")
                //    + ":" + timeSpan.Minutes.ToString("00") 
                //    + ":" + timeSpan.Seconds.ToString("00");
                labelElapsedTime.Text = title + timeSpan.ToString();
            };

            Invoke(action);
        }

        private void updateSalaryPerHour(uint salaryPerHour)
        {
            Action action = delegate
            {
                String title = "Salary: ";
                String unit = "yen/h";

                labelSalaryPerHour.Text = title + salaryPerHour.ToString() + " " + unit;
            };

            Invoke(action);
        }

        private void quitCtrlQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
