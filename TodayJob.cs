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
    public partial class TodayJob : Form
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }

        PlanData job;
        public PlanData Job { get => job; set => job = value; }

        FlowLayoutPanel panel = new FlowLayoutPanel();
        public FlowLayoutPanel Panel { get => panel; set => panel = value; }
        public TodayJob(DateTime date, PlanData planData)
        {
            InitializeComponent();
            
            this.Date = date;
            this.Job = job;
            Panel.Height = jobPanel.Height;
            Panel.Width = jobPanel.Width;
            jobPanel.Controls.Add(Panel);
            Panel.AutoScroll = true;

            dtpkDate.Value = this.Date;

            for (int i = 0; i < planData.ListJob.Count; i++)
            {
                TheJob ajob = new TheJob(planData.ListJob[i], dtpkDate.Value);
                if (planData.ListJob[i].Date == dtpkDate.Value)
                    Panel.Controls.Add(ajob);
            }
        }
    }
}
