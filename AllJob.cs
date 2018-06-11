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
    public partial class AllJob : Form
    {
        PlanData job;
        public PlanData Job { get => job; set => job = value; }

        FlowLayoutPanel panel = new FlowLayoutPanel();
        public FlowLayoutPanel Panel { get => panel; set => panel = value; }

        public AllJob(PlanData planData)
        {
            InitializeComponent();

            this.job = planData;
            Panel.Height = jobPanel.Height;
            Panel.Width = jobPanel.Width;
            jobPanel.Controls.Add(Panel);
            Panel.AutoScroll = true;
            for (int i = 0; i < planData.ListJob.Count; i++)
            {
                UserControlJob ajob = new UserControlJob(planData.ListJob[i]);
                if(planData.ListJob[i].Status != "MISSED" || planData.ListJob[i].Status != "DONE")
                Panel.Controls.Add(ajob);
            }

        }
    }
}
