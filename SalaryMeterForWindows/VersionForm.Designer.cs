
namespace SalaryMeterForWindows
{
    partial class VersionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVersionName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVersionName
            // 
            this.labelVersionName.AutoSize = true;
            this.labelVersionName.Location = new System.Drawing.Point(135, 79);
            this.labelVersionName.Name = "labelVersionName";
            this.labelVersionName.Size = new System.Drawing.Size(147, 21);
            this.labelVersionName.TabIndex = 0;
            this.labelVersionName.Text = "Version X.X.X.X";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(135, 30);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(140, 21);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "XXXXXXXXXX";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(135, 129);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(335, 21);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright ©  2022 Kazumasa Kusaba";
            // 
            // VersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 181);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelVersionName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.VersionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVersionName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCopyright;
    }
}