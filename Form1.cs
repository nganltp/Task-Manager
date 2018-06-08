using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task_Manager
{
    public partial class Form1 : Form
    {
        private string filePath = "data.xml";
        public Form1()
        {
            InitializeComponent();
            try //when form open, get data!
            {
                DeserializeFromXML(filePath); //if success!
            }
            catch {
                setDefaultJob();
            }//if fail!

        }

        void setDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<Plan>();
            job.Job.Add(new Plan()
            {
                Date = DateTime.Now,
                FromTime = new Point(4,0),
                ToTime = new Point(5,0),
                Job = "test demo",
                Status = Plan.listStatus[(int) EPlanItem.COMING]
            });
        }
        private PlanData job;
        private object fileStream;

        public PlanData Job { get => job; set => job = value; }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNotify_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit3_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit4_Click(object sender, EventArgs e)
        {

        }
        private void SerializeToXML(object data, string filePath) //save data to xml
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs,data);
            fs.Close();
        }

        private object DeserializeFromXML(string filePath) //get data from xml
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch(Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }
            
        }

        private void form1_formClosing(object sender, FormClosedEventArgs e) //when form close, data saved!
        {
            SerializeToXML(Job,filePath);
        }
    }
}
