using System;
using System.Reflection;
using System.Windows.Forms;

namespace SalaryMeterForWindows
{
    public partial class MainForm : Form
    {
        private SalaryMeter salaryMeter = SalaryMeter.getInstance();

        public MainForm()
        {
            InitializeComponent();

            labelAmountOfSalary.Text = (0).ToString("C");

            salaryMeter.setAmountOfSalaryCallback(updateNumbersCallback);
            salaryMeter.setElapsedTimeSecCallback(updateElapsedTime);
            salaryMeter.setWagePerHourCallback(updateSalaryPerHour);
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
            salaryMeter.start();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            salaryMeter.pause();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            salaryMeter.reset();
        }

        private void updateNumbersCallback(uint amountOfSalary)
        {
            Action action = delegate
            {
                if (amountOfSalary >= 999999999)
                {
                    labelAmountOfSalary.Text = (999999999).ToString("C");
                    return;
                }

                labelAmountOfSalary.Text = amountOfSalary.ToString("C");
            };

            Invoke(action);
        }
        private void updateElapsedTime(uint elapsedTimeSec)
        {
            Action action = delegate
            {
                String title = "Elapsed Time: ";
                TimeSpan timeSpan = new TimeSpan(0, 0, (int)elapsedTimeSec);

                labelElapsedTime.Text = title + timeSpan.ToString();
            };

            Invoke(action);
        }

        private void updateSalaryPerHour(uint salaryPerHour)
        {
            Action action = delegate
            {
                String title = "Wage Per Hour: ";

                labelWagePerHour.Text = title + salaryPerHour.ToString("C");
            };

            Invoke(action);
        }

        private void quitCtrlQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setWageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salaryMeter.setWage();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm versionForm = new VersionForm();
            versionForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            versionForm.ShowDialog();
        }
    }
}
