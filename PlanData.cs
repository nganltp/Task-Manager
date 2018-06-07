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
        private List<Plan> job;

        public List<Plan> Job { get => job; set => job = value; }
    }

}
