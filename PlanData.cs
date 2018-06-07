using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    [Serializable]
    public class PlanData
    {
        private List<PlanItem> listjob;

        internal List<PlanItem> ListJob { get => listjob; set => listjob = value; }
    }
}
