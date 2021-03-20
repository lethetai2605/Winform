using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCalendar
{
    [Serializable]
    public class PlanData
    {
        private List<PlanItem> job;

        internal List<PlanItem> Job { get => job; set => job = value; }
    }
}
