namespace Task_Manager
{
    partial class Form1
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
            this.content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAllList = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.task3 = new System.Windows.Forms.Panel();
            this.btnEdit3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.task2 = new System.Windows.Forms.Panel();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.task1 = new System.Windows.Forms.Panel();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.task4 = new System.Windows.Forms.Panel();
            this.btnEdit4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.viewListToday = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNotify = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.task3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.task2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.task1.SuspendLayout();
            this.task4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.content.Controls.Add(this.panel1);
            this.content.Controls.Add(this.title);
            this.content.Location = new System.Drawing.Point(12, 12);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(880, 440);
            this.content.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panelAllList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.task3);
            this.panel1.Controls.Add(this.task2);
            this.panel1.Controls.Add(this.task1);
            this.panel1.Controls.Add(this.task4);
            this.panel1.Location = new System.Drawing.Point(24, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 297);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(23, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 25);
            this.panel6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "To Do List";
            // 
            // panelAllList
            // 
            this.panelAllList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAllList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelAllList.Location = new System.Drawing.Point(23, 8);
            this.panelAllList.Name = "panelAllList";
            this.panelAllList.Size = new System.Drawing.Size(261, 260);
            this.panelAllList.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(566, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 25);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Important and Emergency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // task3
            // 
            this.task3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.task3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.task3.Controls.Add(this.btnEdit3);
            this.task3.Controls.Add(this.panel4);
            this.task3.Location = new System.Drawing.Point(301, 143);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(256, 126);
            this.task3.TabIndex = 4;
            // 
            // btnEdit3
            // 
            this.btnEdit3.Location = new System.Drawing.Point(92, 102);
            this.btnEdit3.Name = "btnEdit3";
            this.btnEdit3.Size = new System.Drawing.Size(68, 21);
            this.btnEdit3.TabIndex = 6;
            this.btnEdit3.Text = "Edit";
            this.btnEdit3.UseVisualStyleBackColor = true;
            this.btnEdit3.Click += new System.EventHandler(this.btnEdit3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 25);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nomal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // task2
            // 
            this.task2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.task2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.task2.Controls.Add(this.btnEdit2);
            this.task2.Controls.Add(this.panel2);
            this.task2.Location = new System.Drawing.Point(301, 8);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(256, 126);
            this.task2.TabIndex = 4;
            // 
            // btnEdit2
            // 
            this.btnEdit2.Location = new System.Drawing.Point(92, 102);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(68, 21);
            this.btnEdit2.TabIndex = 3;
            this.btnEdit2.Text = "Edit";
            this.btnEdit2.UseVisualStyleBackColor = true;
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 25);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Important";
            // 
            // task1
            // 
            this.task1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.task1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.task1.Controls.Add(this.btnEdit1);
            this.task1.Location = new System.Drawing.Point(566, 8);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(256, 126);
            this.task1.TabIndex = 4;
            // 
            // btnEdit1
            // 
            this.btnEdit1.Location = new System.Drawing.Point(100, 102);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(68, 21);
            this.btnEdit1.TabIndex = 4;
            this.btnEdit1.Text = "Edit";
            this.btnEdit1.UseVisualStyleBackColor = true;
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit1_Click);
            // 
            // task4
            // 
            this.task4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.task4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.task4.Controls.Add(this.btnEdit4);
            this.task4.Controls.Add(this.panel5);
            this.task4.Location = new System.Drawing.Point(566, 143);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(256, 126);
            this.task4.TabIndex = 3;
            // 
            // btnEdit4
            // 
            this.btnEdit4.Location = new System.Drawing.Point(100, 102);
            this.btnEdit4.Name = "btnEdit4";
            this.btnEdit4.Size = new System.Drawing.Size(68, 21);
            this.btnEdit4.TabIndex = 5;
            this.btnEdit4.Text = "Edit";
            this.btnEdit4.UseVisualStyleBackColor = true;
            this.btnEdit4.Click += new System.EventHandler(this.btnEdit4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 25);
            this.panel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emergency";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Gray;
            this.title.Controls.Add(this.button1);
            this.title.Controls.Add(this.label7);
            this.title.Controls.Add(this.viewListToday);
            this.title.Controls.Add(this.btnView);
            this.title.Controls.Add(this.label6);
            this.title.Controls.Add(this.numericUpDownNotify);
            this.title.Controls.Add(this.checkBoxNotify);
            this.title.Location = new System.Drawing.Point(47, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(799, 112);
            this.title.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(172, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "To do list all day: ";
            // 
            // viewListToday
            // 
            this.viewListToday.AutoSize = true;
            this.viewListToday.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewListToday.ForeColor = System.Drawing.Color.White;
            this.viewListToday.Location = new System.Drawing.Point(18, 79);
            this.viewListToday.Name = "viewListToday";
            this.viewListToday.Size = new System.Drawing.Size(155, 19);
            this.viewListToday.TabIndex = 4;
            this.viewListToday.Text = "To do list today: ";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Black;
            this.btnView.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(172, 74);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(62, 28);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(361, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 73);
            this.label6.TabIndex = 2;
            this.label6.Text = "Task Manager";
            // 
            // numericUpDownNotify
            // 
            this.numericUpDownNotify.Location = new System.Drawing.Point(111, 8);
            this.numericUpDownNotify.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNotify.Name = "numericUpDownNotify";
            this.numericUpDownNotify.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownNotify.TabIndex = 1;
            this.numericUpDownNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNotify.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNotify.ForeColor = System.Drawing.Color.White;
            this.checkBoxNotify.Location = new System.Drawing.Point(22, 9);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(72, 20);
            this.checkBoxNotify.TabIndex = 0;
            this.checkBoxNotify.Text = "Notify";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            this.checkBoxNotify.CheckedChanged += new System.EventHandler(this.checkBoxNotify_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 464);
            this.Controls.Add(this.content);
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.task3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.task2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.task1.ResumeLayout(false);
            this.task4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel task3;
        private System.Windows.Forms.Panel task2;
        private System.Windows.Forms.Panel task1;
        private System.Windows.Forms.Panel task4;
        private System.Windows.Forms.Panel panelAllList;
        private System.Windows.Forms.NumericUpDown numericUpDownNotify;
        private System.Windows.Forms.CheckBox checkBoxNotify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label viewListToday;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEdit3;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnEdit4;
    }
}

