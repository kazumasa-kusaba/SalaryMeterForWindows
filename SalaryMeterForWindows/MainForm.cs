using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            labelAmountOfSalary.Text = (0).ToString("C");

            stateManager.setTotalSalaryCallback(updateNumbersCallback);
            stateManager.setElapsedTimeSecCallback(updateElapsedTime);
            stateManager.setSalaryPerHourCallback(updateSalaryPerHour);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the title of this window
            String productName = Application.ProductName;
            String versionName = Assembly.GetEntryAssembly().GetName().Version.ToString();
            this.Text = productName + " Ver" + versionName;
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
                if (totalSalary >= 999999999)
                {
                    labelAmountOfSalary.Text = (999999999).ToString("C");
                    return;
                }

                labelAmountOfSalary.Text = totalSalary.ToString("C");
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

        private void setSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stateManager.setSalary();
        }

        private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm versionForm = new VersionForm();
            versionForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            versionForm.ShowDialog();
        }
    }
}
