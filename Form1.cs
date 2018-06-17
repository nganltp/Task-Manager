using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Task_Manager
{
    public partial class Form1 : Form
    {
        #region Properties
        private PlanData job;
        public PlanData Job { get => job; set => job = value; }

        private PlanItem ajob;
        public PlanItem Ajob { get => ajob; set => ajob = value; }

        private int time;
        public int Time { get => time; set => time = value; }

        private string filepath = "data.xml";

        FlowLayoutPanel allJobPanel = new FlowLayoutPanel();
        FlowLayoutPanel emergencyJobPanel = new FlowLayoutPanel();
        FlowLayoutPanel importancyJobPanel = new FlowLayoutPanel();
        FlowLayoutPanel normalJobPanel = new FlowLayoutPanel();
        FlowLayoutPanel missedJobPanel = new FlowLayoutPanel();

        #endregion

        public Form1()
        {
            InitializeComponent();
            tmNotify.Start();
            realTimer.Start();
            Time = 0;
            try
            {
                Job = DeserializeFromXML(filepath) as PlanData;
            }
            catch
            {
                //SetDefaultData();
            }

            #region Dat panel cho moi loai cong viec
            allJobPanel.Height = panelAllJob.Height;
            allJobPanel.Width = panelAllJob.Width;
            panelAllJob.Controls.Add(allJobPanel);
            allJobPanel.AutoScroll = true;

            emergencyJobPanel.Height = panelEmergencyJob.Height;
            emergencyJobPanel.Width = panelEmergencyJob.Width;
            panelEmergencyJob.Controls.Add(emergencyJobPanel);
            emergencyJobPanel.AutoScroll = true;

            importancyJobPanel.Height = panelImportantJob.Height;
            importancyJobPanel.Width = panelImportantJob.Width;
            panelImportantJob.Controls.Add(importancyJobPanel);
            importancyJobPanel.AutoScroll = true;

            normalJobPanel.Height = panelNormalJob.Height;
            normalJobPanel.Width = panelNormalJob.Width;
            panelNormalJob.Controls.Add(normalJobPanel);
            normalJobPanel.AutoScroll = true;

            missedJobPanel.Height = panelMissedJob.Height;
            missedJobPanel.Width = panelMissedJob.Width;
            panelMissedJob.Controls.Add(missedJobPanel);
            missedJobPanel.AutoScroll = true;
            #endregion


        }

        #region Liet ke danh sach cac cong viec theo loai
        List<PlanItem> JobByDay(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }

        List<PlanItem> DoingJob(DateTime date)
        {
            return Job.ListJob.Where(p => PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.IMPORTANT
            || PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.NORMAL
            || PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.EMERGENCY).ToList();
        }
        
        List<PlanItem> ImportantJob(DateTime date)
        {
            return Job.ListJob.Where(p => PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.IMPORTANT).ToList();
        }

        List<PlanItem> EmergencyJob(DateTime date)
        {
            return Job.ListJob.Where(p => PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.EMERGENCY).ToList();
        }

        List<PlanItem> NormalJob(DateTime date)
        {
            return Job.ListJob.Where(p => PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.NORMAL).ToList();
        }

        List<PlanItem> MissedJob(DateTime date)
        {
            return Job.ListJob.Where(p => PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.MISSED).ToList();
        }
#endregion

        //Doc va ghi du lieu tu file xml
        private void SerializeToXML(object data, string filepath)
        {
            FileStream file = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(PlanData));

            xml.Serialize(file, data);

            file.Close();
        }

        private object DeserializeFromXML(string filepath)
        {
            FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(PlanData));

                object result = xml.Deserialize(file);
                file.Close();
                return result;
            }
            catch
            {
                file.Close();
                throw new NotImplementedException();
            }
        }

        //Dong form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filepath);
        }

        //Timer cho thong bao
        private void tmNotify_Tick(object sender, EventArgs e)
        {
            AddImportantJob();
            AddEmergencyJob();
            AddNormalJob();
            AddMissedJob();
            AddTodoJob();
            if (!checkBoxNotify.Checked)
                return;
            Time++;
            if (time < Cons.notifyTime)
                return;
            if (Job == null || Job.ListJob == null || Job.ListJob.Count == 0)
                return;

            DateTime current = DateTime.Now;

            if (dtpkDate.Value.Year != current.Year || dtpkDate.Value.Month != current.Month || dtpkDate.Value.Day != current.Day)
                return;
            for (int i = 0; i < Job.ListJob.Count; i++)
            {
                if ((Job.ListJob[i].ToTime.X * 3600 + Job.ListJob[i].ToTime.Y * 60) < (current.Hour * 3600 + current.Minute * 60)
                    && Job.ListJob[i].Status != "DONE" && Job.ListJob[i].Date.Year == current.Year
                    && Job.ListJob[i].Date.Month == current.Month && Job.ListJob[i].Date.Day == current.Day
                    && Job.ListJob[i].Job != null)
                {
                    Job.ListJob[i].Status = "MISSED";
                }
            }

            List<PlanItem> listTodayDoing = Job.ListJob.Where
            (p => p.Date.Year == current.Year && p.Date.Month == current.Month
            && p.Date.Day == current.Day && (PlanItem.ListStatus.IndexOf(p.Status) == ((int)EPlanItem.NORMAL) || PlanItem.ListStatus.IndexOf(p.Status) == ((int)EPlanItem.IMPORTANT)
            || PlanItem.ListStatus.IndexOf(p.Status) == ((int)EPlanItem.EMERGENCY))
            && p.FromTime.X * 3600 + p.FromTime.Y * 60 <= current.Hour * 3600 + current.Minute * 60
            && p.ToTime.X * 3600 + p.ToTime.Y * 60 >= current.Hour * 3600 + current.Minute * 60).ToList();

            string tam = "";
            for (int i = 0; i < listTodayDoing.Count; i++)
            {
                tam += " - " + listTodayDoing[i].Job + "\n";
            }

            notifyIcon.ShowBalloonTip(Cons.TimeOut, "Lịch công việc",
            string.Format("Bạn đang có {0} công việc cần làm: \n", listTodayDoing.Count) + tam, ToolTipIcon.Info);
        }

        //Tick chon thong bao
        private void checkBoxNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNotify.Checked != null)
            {
                nmNotify.Enabled = checkBoxNotify.Checked;
            }
        }

        //Thay doi so phut thong bao
        private void nmNotify_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)nmNotify.Value;
            tmNotify.Interval = (int)nmNotify.Value * tmNotify.Interval;
        }

        //Dong form
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Tao thong bao window
        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            DailyPlan plan = new DailyPlan(dtpkDate.Value, Job);
            plan.Show();
        }

        //Xem cac cong viec trong ngay
        private void btnTodayWork_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
            TodayJob daily = new TodayJob(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, dtpkDate.Value.Day), Job);
            daily.ShowDialog();
        }

        #region Them cong viec vao tung panel tuong ung
        void AddImportantJob()
        {
            importancyJobPanel.Controls.Clear();
            List<PlanItem> importantJob = ImportantJob(dtpkDate.Value);
            for (int i = 0; i < importantJob.Count; i++)
            {
                AddJob(importantJob[i], importancyJobPanel);
            }
        }

        void AddEmergencyJob()
        {
            emergencyJobPanel.Controls.Clear();
            List<PlanItem> emergencyJob = EmergencyJob(dtpkDate.Value);
            for (int i = 0; i < emergencyJob.Count; i++)
            {
                AddJob(emergencyJob[i], emergencyJobPanel);
            }
        }

        void AddNormalJob()
        {
            normalJobPanel.Controls.Clear();
            List<PlanItem> normalJob = NormalJob(dtpkDate.Value);
            for (int i = 0; i < normalJob.Count; i++)
            {
                AddJob(normalJob[i], normalJobPanel);
            }
        }

        void AddMissedJob()
        {
            missedJobPanel.Controls.Clear();
            List<PlanItem> missedJob = MissedJob(dtpkDate.Value);
            for (int i = 0; i < missedJob.Count; i++)
            {
                AddJob(missedJob[i], missedJobPanel);
            }
        }

        void AddTodoJob()
        {
            allJobPanel.Controls.Clear();
            List<PlanItem> TodoJob = DoingJob(dtpkDate.Value);
            for (int i = 0; i < TodoJob.Count; i++)
            {
                AddJob(TodoJob[i], allJobPanel);
            }
        }

        void AddJob(PlanItem job, Panel panel)
        {
            if (job != null && Job.ListJob != null)
            {
                SingleJob ajob = new SingleJob(job);

                panel.Controls.Add(ajob);
            }
            else return;
        }
#endregion

        //Dong ho chay thoi gian thuc
        private void realTimer_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            theHour.Text = Convert.ToString(hour);
            theMinute.Text = Convert.ToString(minute);
            theSecond.Text = Convert.ToString(second);
        }

        //Chon tat ca cong viec hien co
        private void btnAllWork_Click(object sender, EventArgs e)
        {
            AllJob allJob = new AllJob(Job);
            allJob.ShowDialog();
        }

        private void addJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyPlan dailyPlan = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, dtpkDate.Value.Day), Job);
            dailyPlan.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
