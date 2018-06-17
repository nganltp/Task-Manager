namespace Task_Manager
{
    partial class TheJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toMinute = new System.Windows.Forms.TextBox();
            this.toHour = new System.Windows.Forms.TextBox();
            this.fromMinute = new System.Windows.Forms.TextBox();
            this.fromHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.TheDay = new System.Windows.Forms.TextBox();
            this.theMonth = new System.Windows.Forms.TextBox();
            this.theYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxJob);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 37);
            this.panel1.TabIndex = 6;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Location = new System.Drawing.Point(3, 2);
            this.textBoxJob.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(447, 22);
            this.textBoxJob.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toMinute);
            this.panel2.Controls.Add(this.toHour);
            this.panel2.Controls.Add(this.fromMinute);
            this.panel2.Controls.Add(this.fromHour);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(461, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 39);
            this.panel2.TabIndex = 7;
            // 
            // toMinute
            // 
            this.toMinute.Location = new System.Drawing.Point(194, 5);
            this.toMinute.Name = "toMinute";
            this.toMinute.Size = new System.Drawing.Size(46, 22);
            this.toMinute.TabIndex = 12;
            // 
            // toHour
            // 
            this.toHour.Location = new System.Drawing.Point(142, 5);
            this.toHour.Name = "toHour";
            this.toHour.Size = new System.Drawing.Size(46, 22);
            this.toHour.TabIndex = 11;
            // 
            // fromMinute
            // 
            this.fromMinute.Location = new System.Drawing.Point(64, 5);
            this.fromMinute.Name = "fromMinute";
            this.fromMinute.Size = new System.Drawing.Size(46, 22);
            this.fromMinute.TabIndex = 10;
            // 
            // fromHour
            // 
            this.fromHour.Location = new System.Drawing.Point(12, 5);
            this.fromHour.Name = "fromHour";
            this.fromHour.Size = new System.Drawing.Size(46, 22);
            this.fromHour.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(915, 4);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(143, 24);
            this.cbStatus.TabIndex = 8;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // TheDay
            // 
            this.TheDay.Location = new System.Drawing.Point(740, 5);
            this.TheDay.Name = "TheDay";
            this.TheDay.Size = new System.Drawing.Size(46, 22);
            this.TheDay.TabIndex = 13;
            // 
            // theMonth
            // 
            this.theMonth.Location = new System.Drawing.Point(795, 5);
            this.theMonth.Name = "theMonth";
            this.theMonth.Size = new System.Drawing.Size(46, 22);
            this.theMonth.TabIndex = 14;
            // 
            // theYear
            // 
            this.theYear.Location = new System.Drawing.Point(851, 4);
            this.theYear.Name = "theYear";
            this.theYear.Size = new System.Drawing.Size(56, 22);
            this.theYear.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "at";
            // 
            // TheJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.theYear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.theMonth);
            this.Controls.Add(this.TheDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbStatus);
            this.Name = "TheJob";
            this.Size = new System.Drawing.Size(1073, 37);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox toMinute;
        private System.Windows.Forms.TextBox toHour;
        private System.Windows.Forms.TextBox fromMinute;
        private System.Windows.Forms.TextBox fromHour;
        private System.Windows.Forms.TextBox TheDay;
        private System.Windows.Forms.TextBox theMonth;
        private System.Windows.Forms.TextBox theYear;
        private System.Windows.Forms.Label label2;
    }
}
