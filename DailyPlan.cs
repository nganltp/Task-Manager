using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }

        private PlanData job;
        public PlanData Job { get => job; set => job = value; }

        private UserControlJob createjob;
        public UserControlJob Createjob { get => createjob; set => createjob = value; }

        FlowLayoutPanel panel = new FlowLayoutPanel();


        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();

            this.Date = date;
            this.Job = job;

            panel.Height = jobPanel.Height;
            panel.Width = jobPanel.Width;
            jobPanel.Controls.Add(panel);
            panel.AutoScroll = true;

            dateTimePicker1.Value = date;

        }

        List<PlanItem> JobByDay(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        List<PlanItem> JobEmergency(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.EMERGENCY).ToList();
        }
        List<PlanItem> JobImportant(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.IMPORTANT).ToList();
        }

        List<PlanItem> JobMissed(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.MISSED).ToList();
        }
        List<PlanItem> JobNormal(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.NORMAL).ToList();
        }
        List<PlanItem> JobDone(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.DONE).ToList();
        }
        void showJobByDate(DateTime date)
        {
            panel.Controls.Clear();

            if (job != null && Job.ListJob != null)
            {
                List<PlanItem> todayJob = JobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                }
            }
        }
        void AddJob(PlanItem job)
        {
            UserControlJob ajob = new UserControlJob(job);
            ajob.Edited += Ajob_Edited;
            ajob.Deleted += Ajob_Deleted;
            panel.Controls.Add(ajob);

        }
        void DeleteJob(PlanItem job)
        {
            UserControlJob ajob = new UserControlJob(job);
            ajob.Edited += Ajob_Edited;
            ajob.Deleted += Ajob_Deleted;

            panel.Controls.Remove(ajob);

        }

        void DeleteAllJob(PlanItem job)
        {
            UserControlJob dayJob = new UserControlJob(job);
            dayJob.Edited += Ajob_Edited;
            dayJob.Deleted += Ajob_Deleted;

            panel.Controls.Remove(dayJob);

        }
        private void Ajob_Deleted(object sender, EventArgs e)
        {
            UserControlJob uc = sender as UserControlJob;
            PlanItem job = uc.Job;
            panel.Controls.Remove(uc);
            Job.ListJob.Remove(job);
        }

        private void Ajob_Edited(object sender, EventArgs e)
        {

            //toolStripStatusLabel1.Text = "Tổng: " + JobByDay(dtpkDate.Value).Count + " việc || Doing: "
            // + JobDoing(dtpkDate.Value).Count + "|| Done: " + JobDone(dtpkDate.Value).Count
            // + "|| Missed: " + JobMissed(dtpkDate.Value).Count + "|| Coming: " + JobComing(dtpkDate.Value).Count;
        }


        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            showJobByDate((sender as DateTimePicker).Value);

            //toolStripStatusLabel1.Text = "Tổng: " + JobByDay(dtpkDate.Value).Count + " việc || Doing: "
            //+ JobDoing(dtpkDate.Value).Count + "|| Done: " + JobDone(dtpkDate.Value).Count
            //+ "|| Missed: " + JobMissed(dtpkDate.Value).Count + "|| Coming: " + JobComing(dtpkDate.Value).Count;
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
