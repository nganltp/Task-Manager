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
    public partial class UserControlJob : UserControl
    {
        private PlanItem job;

        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        public UserControlJob(PlanItem job)
        {
            InitializeComponent();
            this.Job = job;
            cbStatus.DataSource = PlanItem.ListStatus;

            ShowInfo();
        }
        void ShowInfo()
        {
            textBoxJob.Text = Job.Job;
            nmFromHour.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHour.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            ckbDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Job.Job = textBoxJob.Text;
            Job.FromTime = new Point((int)nmFromHour.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHour.Value, (int)nmToMinute.Value);
            if (cbStatus.SelectedItem == null)
            {
                return;
            }
            else
                Job.Status = cbStatus.SelectedItem.ToString();
            if (edited != null)
                edited(this, new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted!=null)
            {
                deleted(this, new EventArgs());
            }
        }

        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.MISSED;
            btnSave.PerformClick();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;
            if (cbStatus.Text != "")
            {
                cbStatus.Enabled = false;
            }
            else
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
