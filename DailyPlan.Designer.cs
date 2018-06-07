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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labDaily = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.labJob = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.jobPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.dateTimePicker1);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(708, 17);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2018, 6, 7, 9, 33, 13, 0);
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
            this.jobPanel.Location = new System.Drawing.Point(4, 84);
            this.jobPanel.Margin = new System.Windows.Forms.Padding(4);
            this.jobPanel.Name = "jobPanel";
            this.jobPanel.Size = new System.Drawing.Size(1093, 449);
            this.jobPanel.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 629);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DailyPlan";
            this.Text = "DailyPlan";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel jobPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label labDaily;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label labJob;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}