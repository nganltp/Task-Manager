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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.realTimer = new System.Windows.Forms.Timer(this.components);
            this.content = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelImportantJob = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.panelEmergencyJob = new System.Windows.Forms.Panel();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.panelNormalJob = new System.Windows.Forms.Panel();
            this.vScrollBar6 = new System.Windows.Forms.VScrollBar();
            this.panelMissedJob = new System.Windows.Forms.Panel();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.panelAllJob = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.title = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.theMinute = new System.Windows.Forms.Label();
            this.theHour = new System.Windows.Forms.Label();
            this.theSecond = new System.Windows.Forms.Label();
            this.theColon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.btnAllWork = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.viewListToday = new System.Windows.Forms.Label();
            this.btnTodayWork = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutÚToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.content.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelImportantJob.SuspendLayout();
            this.panelEmergencyJob.SuspendLayout();
            this.panelNormalJob.SuspendLayout();
            this.panelMissedJob.SuspendLayout();
            this.panelAllJob.SuspendLayout();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmNotify
            // 
            this.tmNotify.Interval = 10000;
            this.tmNotify.Tick += new System.EventHandler(this.tmNotify_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            // 
            // realTimer
            // 
            this.realTimer.Interval = 1000;
            this.realTimer.Tick += new System.EventHandler(this.realTimer_Tick);
            // 
            // content
            // 
            this.content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("content.BackgroundImage")));
            this.content.Controls.Add(this.panel5);
            this.content.Controls.Add(this.panel3);
            this.content.Controls.Add(this.panel6);
            this.content.Controls.Add(this.panel2);
            this.content.Controls.Add(this.panel4);
            this.content.Controls.Add(this.panelImportantJob);
            this.content.Controls.Add(this.panelEmergencyJob);
            this.content.Controls.Add(this.panelNormalJob);
            this.content.Controls.Add(this.panelMissedJob);
            this.content.Controls.Add(this.panelAllJob);
            this.content.Controls.Add(this.title);
            this.content.Controls.Add(this.menuStrip1);
            this.content.Location = new System.Drawing.Point(-1, 0);
            this.content.Margin = new System.Windows.Forms.Padding(4);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1206, 598);
            this.content.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(808, 391);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 46);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Missed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(808, 202);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 46);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emergency";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(35, 204);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 46);
            this.panel6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(96, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 43);
            this.label5.TabIndex = 2;
            this.label5.Text = "To Do List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(434, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 46);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 43);
            this.label4.TabIndex = 1;
            this.label4.Text = "Important";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(434, 392);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 46);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 43);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nomal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelImportantJob
            // 
            this.panelImportantJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelImportantJob.BackColor = System.Drawing.Color.Goldenrod;
            this.panelImportantJob.Controls.Add(this.vScrollBar2);
            this.panelImportantJob.Location = new System.Drawing.Point(434, 245);
            this.panelImportantJob.Margin = new System.Windows.Forms.Padding(4);
            this.panelImportantJob.Name = "panelImportantJob";
            this.panelImportantJob.Size = new System.Drawing.Size(341, 140);
            this.panelImportantJob.TabIndex = 12;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(317, 6);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(21, 129);
            this.vScrollBar2.TabIndex = 6;
            // 
            // panelEmergencyJob
            // 
            this.panelEmergencyJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEmergencyJob.BackColor = System.Drawing.Color.Firebrick;
            this.panelEmergencyJob.Controls.Add(this.vScrollBar4);
            this.panelEmergencyJob.Location = new System.Drawing.Point(808, 245);
            this.panelEmergencyJob.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmergencyJob.Name = "panelEmergencyJob";
            this.panelEmergencyJob.Size = new System.Drawing.Size(341, 140);
            this.panelEmergencyJob.TabIndex = 13;
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(316, 9);
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(21, 129);
            this.vScrollBar4.TabIndex = 6;
            // 
            // panelNormalJob
            // 
            this.panelNormalJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNormalJob.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelNormalJob.Controls.Add(this.vScrollBar6);
            this.panelNormalJob.Location = new System.Drawing.Point(434, 437);
            this.panelNormalJob.Margin = new System.Windows.Forms.Padding(4);
            this.panelNormalJob.Name = "panelNormalJob";
            this.panelNormalJob.Size = new System.Drawing.Size(341, 140);
            this.panelNormalJob.TabIndex = 14;
            // 
            // vScrollBar6
            // 
            this.vScrollBar6.Location = new System.Drawing.Point(317, 0);
            this.vScrollBar6.Name = "vScrollBar6";
            this.vScrollBar6.Size = new System.Drawing.Size(21, 137);
            this.vScrollBar6.TabIndex = 5;
            // 
            // panelMissedJob
            // 
            this.panelMissedJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMissedJob.BackColor = System.Drawing.Color.Purple;
            this.panelMissedJob.Controls.Add(this.vScrollBar3);
            this.panelMissedJob.Location = new System.Drawing.Point(808, 436);
            this.panelMissedJob.Margin = new System.Windows.Forms.Padding(4);
            this.panelMissedJob.Name = "panelMissedJob";
            this.panelMissedJob.Size = new System.Drawing.Size(341, 141);
            this.panelMissedJob.TabIndex = 11;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(316, 6);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(21, 129);
            this.vScrollBar3.TabIndex = 6;
            // 
            // panelAllJob
            // 
            this.panelAllJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAllJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelAllJob.Controls.Add(this.vScrollBar1);
            this.panelAllJob.Location = new System.Drawing.Point(36, 249);
            this.panelAllJob.Margin = new System.Windows.Forms.Padding(4);
            this.panelAllJob.Name = "panelAllJob";
            this.panelAllJob.Size = new System.Drawing.Size(341, 330);
            this.panelAllJob.TabIndex = 15;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(316, 1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 327);
            this.vScrollBar1.TabIndex = 0;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Gray;
            this.title.Controls.Add(this.label9);
            this.title.Controls.Add(this.theMinute);
            this.title.Controls.Add(this.theHour);
            this.title.Controls.Add(this.theSecond);
            this.title.Controls.Add(this.theColon);
            this.title.Controls.Add(this.label8);
            this.title.Controls.Add(this.dtpkDate);
            this.title.Controls.Add(this.btnAllWork);
            this.title.Controls.Add(this.label7);
            this.title.Controls.Add(this.viewListToday);
            this.title.Controls.Add(this.btnTodayWork);
            this.title.Controls.Add(this.label6);
            this.title.Controls.Add(this.nmNotify);
            this.title.Controls.Add(this.checkBoxNotify);
            this.title.Location = new System.Drawing.Point(35, 50);
            this.title.Margin = new System.Windows.Forms.Padding(4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1114, 138);
            this.title.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Niagara Engraved", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(619, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 51);
            this.label9.TabIndex = 16;
            this.label9.Text = ":";
            // 
            // theMinute
            // 
            this.theMinute.AutoSize = true;
            this.theMinute.Font = new System.Drawing.Font("Niagara Engraved", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theMinute.Location = new System.Drawing.Point(572, 97);
            this.theMinute.Name = "theMinute";
            this.theMinute.Size = new System.Drawing.Size(37, 35);
            this.theMinute.TabIndex = 15;
            this.theMinute.Text = "00";
            // 
            // theHour
            // 
            this.theHour.AutoSize = true;
            this.theHour.Font = new System.Drawing.Font("Niagara Engraved", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theHour.Location = new System.Drawing.Point(481, 97);
            this.theHour.Name = "theHour";
            this.theHour.Size = new System.Drawing.Size(37, 35);
            this.theHour.TabIndex = 14;
            this.theHour.Text = "00";
            // 
            // theSecond
            // 
            this.theSecond.AutoSize = true;
            this.theSecond.Font = new System.Drawing.Font("Niagara Engraved", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theSecond.Location = new System.Drawing.Point(653, 97);
            this.theSecond.Name = "theSecond";
            this.theSecond.Size = new System.Drawing.Size(37, 35);
            this.theSecond.TabIndex = 13;
            this.theSecond.Text = "00";
            // 
            // theColon
            // 
            this.theColon.AutoSize = true;
            this.theColon.Font = new System.Drawing.Font("Niagara Engraved", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theColon.Location = new System.Drawing.Point(532, 85);
            this.theColon.Name = "theColon";
            this.theColon.Size = new System.Drawing.Size(28, 51);
            this.theColon.TabIndex = 10;
            this.theColon.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(230, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "(seconds)";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpkDate.Font = new System.Drawing.Font("VNI-Disney", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(713, 97);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(349, 36);
            this.dtpkDate.TabIndex = 7;
            // 
            // btnAllWork
            // 
            this.btnAllWork.BackColor = System.Drawing.Color.Black;
            this.btnAllWork.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllWork.ForeColor = System.Drawing.Color.White;
            this.btnAllWork.Location = new System.Drawing.Point(183, 49);
            this.btnAllWork.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllWork.Name = "btnAllWork";
            this.btnAllWork.Size = new System.Drawing.Size(83, 34);
            this.btnAllWork.TabIndex = 6;
            this.btnAllWork.Text = "View";
            this.btnAllWork.UseVisualStyleBackColor = false;
            this.btnAllWork.Click += new System.EventHandler(this.btnAllWork_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 35);
            this.label7.TabIndex = 5;
            this.label7.Text = "All work:";
            // 
            // viewListToday
            // 
            this.viewListToday.AutoSize = true;
            this.viewListToday.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewListToday.ForeColor = System.Drawing.Color.White;
            this.viewListToday.Location = new System.Drawing.Point(24, 91);
            this.viewListToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewListToday.Name = "viewListToday";
            this.viewListToday.Size = new System.Drawing.Size(133, 35);
            this.viewListToday.TabIndex = 4;
            this.viewListToday.Text = "Only today:";
            // 
            // btnTodayWork
            // 
            this.btnTodayWork.BackColor = System.Drawing.Color.Black;
            this.btnTodayWork.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodayWork.ForeColor = System.Drawing.Color.White;
            this.btnTodayWork.Location = new System.Drawing.Point(183, 91);
            this.btnTodayWork.Margin = new System.Windows.Forms.Padding(4);
            this.btnTodayWork.Name = "btnTodayWork";
            this.btnTodayWork.Size = new System.Drawing.Size(83, 34);
            this.btnTodayWork.TabIndex = 3;
            this.btnTodayWork.Text = "View";
            this.btnTodayWork.UseVisualStyleBackColor = false;
            this.btnTodayWork.Click += new System.EventHandler(this.btnTodayWork_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(562, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(487, 94);
            this.label6.TabIndex = 2;
            this.label6.Text = "Task Manager";
            // 
            // nmNotify
            // 
            this.nmNotify.Enabled = false;
            this.nmNotify.Location = new System.Drawing.Point(137, 11);
            this.nmNotify.Margin = new System.Windows.Forms.Padding(4);
            this.nmNotify.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(91, 22);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmNotify.ValueChanged += new System.EventHandler(this.nmNotify_ValueChanged);
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNotify.ForeColor = System.Drawing.Color.White;
            this.checkBoxNotify.Location = new System.Drawing.Point(30, 5);
            this.checkBoxNotify.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(88, 34);
            this.checkBoxNotify.TabIndex = 0;
            this.checkBoxNotify.Text = "Notify";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            this.checkBoxNotify.CheckedChanged += new System.EventHandler(this.checkBoxNotify_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addJobToolStripMenuItem,
            this.aboutÚToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addJobToolStripMenuItem
            // 
            this.addJobToolStripMenuItem.Name = "addJobToolStripMenuItem";
            this.addJobToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.addJobToolStripMenuItem.Text = "Add Job";
            this.addJobToolStripMenuItem.Click += new System.EventHandler(this.addJobToolStripMenuItem_Click);
            // 
            // aboutÚToolStripMenuItem
            // 
            this.aboutÚToolStripMenuItem.Name = "aboutÚToolStripMenuItem";
            this.aboutÚToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.aboutÚToolStripMenuItem.Text = "About us";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 598);
            this.Controls.Add(this.content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelImportantJob.ResumeLayout(false);
            this.panelEmergencyJob.ResumeLayout(false);
            this.panelNormalJob.ResumeLayout(false);
            this.panelMissedJob.ResumeLayout(false);
            this.panelAllJob.ResumeLayout(false);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer realTimer;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelImportantJob;
        private System.Windows.Forms.Panel panelEmergencyJob;
        private System.Windows.Forms.Panel panelNormalJob;
        private System.Windows.Forms.VScrollBar vScrollBar6;
        private System.Windows.Forms.Panel panelMissedJob;
        private System.Windows.Forms.Panel panelAllJob;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label theMinute;
        private System.Windows.Forms.Label theHour;
        private System.Windows.Forms.Label theSecond;
        private System.Windows.Forms.Label theColon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnAllWork;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label viewListToday;
        private System.Windows.Forms.Button btnTodayWork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox checkBoxNotify;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutÚToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

