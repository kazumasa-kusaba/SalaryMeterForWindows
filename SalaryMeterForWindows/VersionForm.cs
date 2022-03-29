using System;
using System.Reflection;
using System.Windows.Forms;

namespace SalaryMeterForWindows
{
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();
        }

        private void VersionForm_Load(object sender, EventArgs e)
        {
            // Set the title of this window
            labelProductName.Text = Application.ProductName;
            labelVersionName.Text = "Version " + Assembly.GetEntryAssembly().GetName().Version.ToString();
            object[] copyrightarray = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            string copyright = ((AssemblyCopyrightAttribute)copyrightarray[0]).Copyright;
            labelCopyright.Text = copyright;
        }
    }
}
