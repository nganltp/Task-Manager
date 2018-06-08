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
#endregion

        public Form1()
        {
            InitializeComponent();
            tmNotify.Start();
            Time = 0;
            try
            {
                Job = DeserializeFromXML(filepath) as PlanData;
            }
            catch
            {
                
            }
        }

        void DefautDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        List<PlanItem> JobByDay(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }

        private void btnAllWork_Click(object sender, EventArgs e)
        {
            DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, dtpkDate.Value.Day), Job);
            daily.ShowDialog();
        }
        
        private void btnTodayWork_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
            DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, dtpkDate.Value.Day), Job);
            daily.ShowDialog();
        }

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filepath);
        }

        private void tmNotify_Tick(object sender, EventArgs e)
        {
            if (!checkBoxNotify.Checked)
                return;
            Time++;
            if (time < Cons.notifyTime)
                return;
            if (Job == null || Job.ListJob == null || Job.ListJob.Count == 0)
                return;
            DateTime current = DateTime.Now;
            DateTime tomorrow = DateTime.Now.AddDays(1);

            if (dtpkDate.Value.Year != current.Year || dtpkDate.Value.Month != current.Month || dtpkDate.Value.Day != current.Day)
                return;
            for (int i = 0; i < Job.ListJob.Count; i++)
            {
                if (Job.ListJob[i].ToTime.X * 3600 + Job.ListJob[i].ToTime.Y * 60 < current.Hour * 3600 + current.Minute * 60
                    && Job.ListJob[i].Status != "DONE" && Job.ListJob[i].Date.Year == current.Year
                    && Job.ListJob[i].Date.Month == current.Month && Job.ListJob[i].Date.Day == current.Day
                    && Job.ListJob[i].Job != null)
                {
                    Job.ListJob[i].Status = "MISSED";
                }
            }

            int dem = 0;
            for (int i = 0; i < Job.ListJob.Count; i++)
            {
                if (Job.ListJob[i].Status == "EMERGENCY" || Job.ListJob[i].Status == "IMPORTANT"
                    || Job.ListJob[i].Status == "NORMAL")
                {
                    dem++;
                }
            }

            if (dem == 0)
            {
                return;
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

            notifyIcon1.ShowBalloonTip(Cons.TimeOut, "Lịch công việc",
            string.Format("Bạn đang có {0} công việc cần làm: \n", listTodayDoing.Count) + tam, ToolTipIcon.Info);
        }

        private void checkBoxNotify_CheckedChanged(object sender, EventArgs e)
        {
            nmNotify.Enabled = checkBoxNotify.Checked;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        List<PlanItem> JobByMonth(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month).ToList();
        }
        List<PlanItem> JobByMonthDone(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.DONE).ToList();
        }
        List<PlanItem> JobByMonthMissed(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && PlanItem.ListStatus.IndexOf(p.Status) == (int)EPlanItem.MISSED).ToList();
        }
    }
}
