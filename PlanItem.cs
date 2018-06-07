using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_Manager
{
    public class PlanItem
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }

        private string job;

        public string Job { get => job; set => job = value; }

        private Point toTime;
        public Point ToTime { get => toTime; set => toTime = value; }

        private Point fromTime;

        public Point FromTime { get => fromTime; set => fromTime = value; }

        private string status;

        public string Status { get => status; set => status = value; }

        public static List<string> ListStatus = new List<string> { "EMERGENCY","IMPORTANT","NORMAL", "DONE","MISSED" };

    }
    
    public enum EPlanItem
    {
        EMERGENCY,
        IMPORTANT,
        NORMAL,
        DONE,
        MISSED,
    }
}
