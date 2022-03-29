
namespace SalaryMeterForWindows
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitCtrlQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.labelSalaryPerHour = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelAmountOfSalary = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitCtrlQToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(84, 34);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // quitCtrlQToolStripMenuItem
            // 
            this.quitCtrlQToolStripMenuItem.Name = "quitCtrlQToolStripMenuItem";
            this.quitCtrlQToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitCtrlQToolStripMenuItem.Size = new System.Drawing.Size(320, 40);
            this.quitCtrlQToolStripMenuItem.Text = "Quit(Ctrl+Q)";
            this.quitCtrlQToolStripMenuItem.Click += new System.EventHandler(this.quitCtrlQToolStripMenuItem_Click);
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSalaryToolStripMenuItem});
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(89, 34);
            this.editEToolStripMenuItem.Text = "Edit(&E)";
            // 
            // setSalaryToolStripMenuItem
            // 
            this.setSalaryToolStripMenuItem.Name = "setSalaryToolStripMenuItem";
            this.setSalaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.setSalaryToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.setSalaryToolStripMenuItem.Text = "Set Salary(Ctrl+&E)";
            this.setSalaryToolStripMenuItem.Click += new System.EventHandler(this.setSalaryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.helpToolStripMenuItem.Text = "Help(&H)";
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(281, 40);
            this.aboutAToolStripMenuItem.Text = "About(&A)";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.aboutAToolStripMenuItem_Click);
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.AutoSize = true;
            this.labelElapsedTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelElapsedTime.Location = new System.Drawing.Point(586, 245);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(280, 28);
            this.labelElapsedTime.TabIndex = 14;
            this.labelElapsedTime.Text = "Elapsed Time: 00:00:00";
            // 
            // labelSalaryPerHour
            // 
            this.labelSalaryPerHour.AutoSize = true;
            this.labelSalaryPerHour.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSalaryPerHour.Location = new System.Drawing.Point(586, 217);
            this.labelSalaryPerHour.Name = "labelSalaryPerHour";
            this.labelSalaryPerHour.Size = new System.Drawing.Size(191, 28);
            this.labelSalaryPerHour.TabIndex = 15;
            this.labelSalaryPerHour.Text = "Salary: 0 yen/h";
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStart.Location = new System.Drawing.Point(29, 221);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 52);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.AutoSize = true;
            this.buttonPause.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPause.Location = new System.Drawing.Point(209, 221);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(157, 52);
            this.buttonPause.TabIndex = 17;
            this.buttonPause.Text = "PAUSE";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReset.Location = new System.Drawing.Point(391, 221);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(152, 52);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelAmountOfSalary
            // 
            this.labelAmountOfSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmountOfSalary.Font = new System.Drawing.Font("MS UI Gothic", 65.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAmountOfSalary.Location = new System.Drawing.Point(12, 55);
            this.labelAmountOfSalary.Name = "labelAmountOfSalary";
            this.labelAmountOfSalary.Size = new System.Drawing.Size(916, 141);
            this.labelAmountOfSalary.TabIndex = 19;
            this.labelAmountOfSalary.Text = "\\999,999,999";
            this.labelAmountOfSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 295);
            this.Controls.Add(this.labelAmountOfSalary);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelSalaryPerHour);
            this.Controls.Add(this.labelElapsedTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Salary Meter VerX.X.X.X";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label labelSalaryPerHour;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem quitCtrlQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.Label labelAmountOfSalary;
    }
}

