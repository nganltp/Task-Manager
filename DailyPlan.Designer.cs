namespace Task_Manager
{
    partial class DailyPlan
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
            this.labDaily = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.labJob = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.jobPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.jobPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.jobPanel);
            this.panelMenu.Location = new System.Drawing.Point(15, 15);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1101, 576);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labDaily);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.labJob);
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Controls.Add(this.btnAddJob);
            this.panel2.Location = new System.Drawing.Point(4, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 59);
            this.panel2.TabIndex = 1;
            // 
            // labDaily
            // 
            this.labDaily.AutoSize = true;
            this.labDaily.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDaily.Location = new System.Drawing.Point(237, 2);
            this.labDaily.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDaily.Name = "labDaily";
            this.labDaily.Size = new System.Drawing.Size(215, 55);
            this.labDaily.TabIndex = 4;
            this.labDaily.Text = "Daily Plan";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(983, 10);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(93, 39);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // labJob
            // 
            this.labJob.AutoSize = true;
            this.labJob.BackColor = System.Drawing.SystemColors.Control;
            this.labJob.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJob.ForeColor = System.Drawing.Color.Black;
            this.labJob.Location = new System.Drawing.Point(552, 13);
            this.labJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labJob.Name = "labJob";
            this.labJob.Size = new System.Drawing.Size(134, 26);
            this.labJob.TabIndex = 2;
            this.labJob.Text = "Job of day:";
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(708, 17);
            this.dtpkDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(265, 22);
            this.dtpkDate.TabIndex = 1;
            this.dtpkDate.Value = new System.DateTime(2018, 6, 7, 9, 33, 13, 0);
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(4, 4);
            this.btnAddJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(123, 52);
            this.btnAddJob.TabIndex = 0;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // jobPanel
            // 
            this.jobPanel.Controls.Add(this.menuStrip1);
            this.jobPanel.Location = new System.Drawing.Point(4, 84);
            this.jobPanel.Margin = new System.Windows.Forms.Padding(4);
            this.jobPanel.Name = "jobPanel";
            this.jobPanel.Size = new System.Drawing.Size(1093, 449);
            this.jobPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1132, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 629);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DailyPlan";
            this.Text = "DailyPlan";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.jobPanel.ResumeLayout(false);
            this.jobPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel jobPanel;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label labDaily;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label labJob;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}