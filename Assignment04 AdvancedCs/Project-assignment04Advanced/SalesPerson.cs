using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AdvancedCs.Project_assignment04Advanced
{
    class SalesPerson:Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (Quota < AchievedTarget)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.FailedSalesTarget });
                return false;
            }
            return true;
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.FailedSalesTarget || e.Cause == LayOffCause.AgeOverSixty)
            {
                base.OnEmployeeLayOff(e);
            }
        }
    }
}
