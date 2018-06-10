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
    public partial class SingleJob : UserControl
    {
        private PlanItem job;

        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
        }

        public SingleJob(PlanItem job)
        {
            InitializeComponent();
            this.Job = job;

            ShowInfo();
        }

        void ShowInfo()
        {
            jobContent.Text = job.Job;
            jobType.Text = Job.Status;
        }

    }
}
