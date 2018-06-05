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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labJob = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.labDaily = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Location = new System.Drawing.Point(11, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(826, 468);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labDaily);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.labJob);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnAddJob);
            this.panel2.Location = new System.Drawing.Point(3, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 365);
            this.panel1.TabIndex = 0;
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(3, 3);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(92, 42);
            this.btnAddJob.TabIndex = 0;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labJob
            // 
            this.labJob.AutoSize = true;
            this.labJob.BackColor = System.Drawing.SystemColors.Control;
            this.labJob.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJob.ForeColor = System.Drawing.Color.Black;
            this.labJob.Location = new System.Drawing.Point(414, 15);
            this.labJob.Name = "labJob";
            this.labJob.Size = new System.Drawing.Size(111, 20);
            this.labJob.TabIndex = 2;
            this.labJob.Text = "Job of day:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(737, 8);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 32);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // labDaily
            // 
            this.labDaily.AutoSize = true;
            this.labDaily.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDaily.Location = new System.Drawing.Point(178, 3);
            this.labDaily.Name = "labDaily";
            this.labDaily.Size = new System.Drawing.Size(174, 44);
            this.labDaily.TabIndex = 4;
            this.labDaily.Text = "Daily Plan";
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.panelMenu);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label labDaily;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label labJob;
    }
}