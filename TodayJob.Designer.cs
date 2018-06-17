namespace Task_Manager
{
    partial class TodayJob
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.labDaily = new System.Windows.Forms.Label();
            this.jobPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.jobPanel);
            this.panelMenu.Location = new System.Drawing.Point(15, 7);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1101, 563);
            this.panelMenu.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Controls.Add(this.labDaily);
            this.panel2.Location = new System.Drawing.Point(4, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 59);
            this.panel2.TabIndex = 1;
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(758, 17);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(309, 22);
            this.dtpkDate.TabIndex = 5;
            this.dtpkDate.Visible = false;
            // 
            // labDaily
            // 
            this.labDaily.AutoSize = true;
            this.labDaily.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDaily.Location = new System.Drawing.Point(423, 2);
            this.labDaily.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDaily.Name = "labDaily";
            this.labDaily.Size = new System.Drawing.Size(229, 55);
            this.labDaily.TabIndex = 4;
            this.labDaily.Text = "Today Plan";
            // 
            // jobPanel
            // 
            this.jobPanel.Location = new System.Drawing.Point(4, 81);
            this.jobPanel.Margin = new System.Windows.Forms.Padding(4);
            this.jobPanel.Name = "jobPanel";
            this.jobPanel.Size = new System.Drawing.Size(1093, 478);
            this.jobPanel.TabIndex = 0;
            // 
            // TodayJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 629);
            this.Controls.Add(this.panelMenu);
            this.Name = "TodayJob";
            this.Text = "TodayJob";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labDaily;
        private System.Windows.Forms.Panel jobPanel;
        private System.Windows.Forms.DateTimePicker dtpkDate;
    }
}