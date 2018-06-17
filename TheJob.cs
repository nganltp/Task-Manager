using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class TheJob : UserControl
    {
        private PlanItem job;

        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
        }

        public TheJob(PlanItem job, DateTime date)
        {
            InitializeComponent();
            this.Job = job;
            cbStatus.DataSource = PlanItem.ListStatus;

            ShowInfo(date);
        }
        void ShowInfo(DateTime date)
        {
            textBoxJob.Text = Job.Job;
            fromHour.Text = Job.FromTime.X.ToString();
            fromMinute.Text = Job.FromTime.Y.ToString();
            toHour.Text = Job.ToTime.X.ToString();
            toMinute.Text = Job.ToTime.Y.ToString();

            TheDay.Text = date.Day.ToString();
            theMonth.Text = date.Month.ToString();
            theYear.Text = date.Year.ToString();

            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStatus.Enabled = true;
            if (cbStatus.SelectedIndex == (int)EPlanItem.IMPORTANT)
                this.BackColor = Color.Yellow;
            else if (cbStatus.SelectedIndex == (int)EPlanItem.DONE)
                this.BackColor = Color.ForestGreen;
            else if (cbStatus.SelectedIndex == (int)EPlanItem.MISSED)
                this.BackColor = Color.DarkGray;
            else if (cbStatus.SelectedIndex == (int)EPlanItem.EMERGENCY)
                this.BackColor = Color.IndianRed;
            else if (cbStatus.SelectedIndex == (int)EPlanItem.NORMAL)
                this.BackColor = Color.Blue;
        }
    }
}