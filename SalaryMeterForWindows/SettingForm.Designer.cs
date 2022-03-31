
namespace SalaryMeterForWindows
{
    partial class SettingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelWagePerHour = new System.Windows.Forms.Label();
            this.numericUpDownWagePerHour = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelYen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWagePerHour)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelWagePerHour
            // 
            this.labelWagePerHour.AutoSize = true;
            this.labelWagePerHour.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWagePerHour.Location = new System.Drawing.Point(28, 33);
            this.labelWagePerHour.MaximumSize = new System.Drawing.Size(170, 21);
            this.labelWagePerHour.MinimumSize = new System.Drawing.Size(170, 21);
            this.labelWagePerHour.Name = "labelWagePerHour";
            this.labelWagePerHour.Size = new System.Drawing.Size(170, 21);
            this.labelWagePerHour.TabIndex = 1;
            this.labelWagePerHour.Text = "Wage Per Hour :";
            // 
            // numericUpDownWagePerHour
            // 
            this.numericUpDownWagePerHour.Location = new System.Drawing.Point(202, 30);
            this.numericUpDownWagePerHour.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownWagePerHour.MaximumSize = new System.Drawing.Size(300, 0);
            this.numericUpDownWagePerHour.Name = "numericUpDownWagePerHour";
            this.numericUpDownWagePerHour.Size = new System.Drawing.Size(164, 28);
            this.numericUpDownWagePerHour.TabIndex = 2;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(32, 86);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(187, 40);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(238, 86);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(187, 40);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelYen
            // 
            this.labelYen.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelYen.Location = new System.Drawing.Point(372, 37);
            this.labelYen.MaximumSize = new System.Drawing.Size(200, 21);
            this.labelYen.Name = "labelYen";
            this.labelYen.Size = new System.Drawing.Size(44, 21);
            this.labelYen.TabIndex = 5;
            this.labelYen.Text = "yen";
            // 
            // SettingForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 138);
            this.Controls.Add(this.labelYen);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownWagePerHour);
            this.Controls.Add(this.labelWagePerHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWagePerHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelWagePerHour;
        private System.Windows.Forms.NumericUpDown numericUpDownWagePerHour;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelYen;
    }
}