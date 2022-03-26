
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNumber8 = new System.Windows.Forms.Label();
            this.labelNumber7 = new System.Windows.Forms.Label();
            this.labelNumber6 = new System.Windows.Forms.Label();
            this.labelNumber5 = new System.Windows.Forms.Label();
            this.labelNumber4 = new System.Windows.Forms.Label();
            this.labelNumber3 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelComma1 = new System.Windows.Forms.Label();
            this.labelComma2 = new System.Windows.Forms.Label();
            this.labelYen = new System.Windows.Forms.Label();
            this.labelNumber9 = new System.Windows.Forms.Label();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.labelSalaryPerHour = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.quitCtrlQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitCtrlQToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(84, 34);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.helpToolStripMenuItem.Text = "Help(&H)";
            // 
            // labelNumber8
            // 
            this.labelNumber8.AutoSize = true;
            this.labelNumber8.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber8.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber8.Location = new System.Drawing.Point(112, 55);
            this.labelNumber8.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber8.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber8.Name = "labelNumber8";
            this.labelNumber8.Size = new System.Drawing.Size(80, 130);
            this.labelNumber8.TabIndex = 1;
            this.labelNumber8.Text = "0";
            this.labelNumber8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber7
            // 
            this.labelNumber7.AutoSize = true;
            this.labelNumber7.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber7.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber7.Location = new System.Drawing.Point(199, 55);
            this.labelNumber7.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber7.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber7.Name = "labelNumber7";
            this.labelNumber7.Size = new System.Drawing.Size(80, 130);
            this.labelNumber7.TabIndex = 2;
            this.labelNumber7.Text = "0";
            this.labelNumber7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber6
            // 
            this.labelNumber6.AutoSize = true;
            this.labelNumber6.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber6.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber6.Location = new System.Drawing.Point(335, 55);
            this.labelNumber6.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber6.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber6.Name = "labelNumber6";
            this.labelNumber6.Size = new System.Drawing.Size(80, 130);
            this.labelNumber6.TabIndex = 3;
            this.labelNumber6.Text = "0";
            this.labelNumber6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber5
            // 
            this.labelNumber5.AutoSize = true;
            this.labelNumber5.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber5.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber5.Location = new System.Drawing.Point(422, 55);
            this.labelNumber5.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber5.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber5.Name = "labelNumber5";
            this.labelNumber5.Size = new System.Drawing.Size(80, 130);
            this.labelNumber5.TabIndex = 4;
            this.labelNumber5.Text = "0";
            this.labelNumber5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber4
            // 
            this.labelNumber4.AutoSize = true;
            this.labelNumber4.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber4.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber4.Location = new System.Drawing.Point(509, 55);
            this.labelNumber4.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber4.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber4.Name = "labelNumber4";
            this.labelNumber4.Size = new System.Drawing.Size(80, 130);
            this.labelNumber4.TabIndex = 5;
            this.labelNumber4.Text = "0";
            this.labelNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber3
            // 
            this.labelNumber3.AutoSize = true;
            this.labelNumber3.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber3.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber3.Location = new System.Drawing.Point(645, 55);
            this.labelNumber3.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber3.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber3.Name = "labelNumber3";
            this.labelNumber3.Size = new System.Drawing.Size(80, 130);
            this.labelNumber3.TabIndex = 6;
            this.labelNumber3.Text = "0";
            this.labelNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber2.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber2.Location = new System.Drawing.Point(732, 55);
            this.labelNumber2.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber2.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(80, 130);
            this.labelNumber2.TabIndex = 7;
            this.labelNumber2.Text = "0";
            this.labelNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber1.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber1.Location = new System.Drawing.Point(819, 55);
            this.labelNumber1.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber1.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(80, 130);
            this.labelNumber1.TabIndex = 8;
            this.labelNumber1.Text = "0";
            this.labelNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComma1
            // 
            this.labelComma1.AutoSize = true;
            this.labelComma1.BackColor = System.Drawing.Color.Transparent;
            this.labelComma1.Font = new System.Drawing.Font("MS UI Gothic", 27.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelComma1.Location = new System.Drawing.Point(596, 119);
            this.labelComma1.Name = "labelComma1";
            this.labelComma1.Size = new System.Drawing.Size(42, 65);
            this.labelComma1.TabIndex = 9;
            this.labelComma1.Text = ",";
            this.labelComma1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComma2
            // 
            this.labelComma2.AutoSize = true;
            this.labelComma2.BackColor = System.Drawing.Color.Transparent;
            this.labelComma2.Font = new System.Drawing.Font("MS UI Gothic", 27.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelComma2.Location = new System.Drawing.Point(286, 119);
            this.labelComma2.Name = "labelComma2";
            this.labelComma2.Size = new System.Drawing.Size(42, 65);
            this.labelComma2.TabIndex = 10;
            this.labelComma2.Text = ",";
            this.labelComma2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYen
            // 
            this.labelYen.AutoSize = true;
            this.labelYen.BackColor = System.Drawing.Color.Transparent;
            this.labelYen.Font = new System.Drawing.Font("MS UI Gothic", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelYen.Location = new System.Drawing.Point(906, 135);
            this.labelYen.Name = "labelYen";
            this.labelYen.Size = new System.Drawing.Size(94, 48);
            this.labelYen.TabIndex = 11;
            this.labelYen.Text = "yen";
            // 
            // labelNumber9
            // 
            this.labelNumber9.AutoSize = true;
            this.labelNumber9.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber9.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNumber9.Location = new System.Drawing.Point(25, 55);
            this.labelNumber9.MaximumSize = new System.Drawing.Size(80, 130);
            this.labelNumber9.MinimumSize = new System.Drawing.Size(80, 130);
            this.labelNumber9.Name = "labelNumber9";
            this.labelNumber9.Size = new System.Drawing.Size(80, 130);
            this.labelNumber9.TabIndex = 13;
            this.labelNumber9.Text = "0";
            this.labelNumber9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.AutoSize = true;
            this.labelElapsedTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelElapsedTime.Location = new System.Drawing.Point(28, 201);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(280, 28);
            this.labelElapsedTime.TabIndex = 14;
            this.labelElapsedTime.Text = "Elapsed Time: 00:00:00";
            // 
            // labelSalaryPerHour
            // 
            this.labelSalaryPerHour.AutoSize = true;
            this.labelSalaryPerHour.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSalaryPerHour.Location = new System.Drawing.Point(354, 201);
            this.labelSalaryPerHour.Name = "labelSalaryPerHour";
            this.labelSalaryPerHour.Size = new System.Drawing.Size(191, 28);
            this.labelSalaryPerHour.TabIndex = 15;
            this.labelSalaryPerHour.Text = "Salary: 0 yen/h";
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStart.Location = new System.Drawing.Point(33, 264);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(163, 52);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.AutoSize = true;
            this.buttonPause.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPause.Location = new System.Drawing.Point(223, 264);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(163, 52);
            this.buttonPause.TabIndex = 17;
            this.buttonPause.Text = "PAUSE";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReset.Location = new System.Drawing.Point(412, 264);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(163, 52);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // quitCtrlQToolStripMenuItem
            // 
            this.quitCtrlQToolStripMenuItem.Name = "quitCtrlQToolStripMenuItem";
            this.quitCtrlQToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitCtrlQToolStripMenuItem.Size = new System.Drawing.Size(320, 40);
            this.quitCtrlQToolStripMenuItem.Text = "Quit(Ctrl+Q)";
            this.quitCtrlQToolStripMenuItem.Click += new System.EventHandler(this.quitCtrlQToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 339);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelSalaryPerHour);
            this.Controls.Add(this.labelElapsedTime);
            this.Controls.Add(this.labelNumber9);
            this.Controls.Add(this.labelNumber3);
            this.Controls.Add(this.labelYen);
            this.Controls.Add(this.labelComma2);
            this.Controls.Add(this.labelComma1);
            this.Controls.Add(this.labelNumber1);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelNumber4);
            this.Controls.Add(this.labelNumber5);
            this.Controls.Add(this.labelNumber6);
            this.Controls.Add(this.labelNumber7);
            this.Controls.Add(this.labelNumber8);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Salary Meter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label labelNumber8;
        private System.Windows.Forms.Label labelNumber7;
        private System.Windows.Forms.Label labelNumber6;
        private System.Windows.Forms.Label labelNumber5;
        private System.Windows.Forms.Label labelNumber4;
        private System.Windows.Forms.Label labelNumber3;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelComma1;
        private System.Windows.Forms.Label labelComma2;
        private System.Windows.Forms.Label labelYen;
        private System.Windows.Forms.Label labelNumber9;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label labelSalaryPerHour;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem quitCtrlQToolStripMenuItem;
    }
}

