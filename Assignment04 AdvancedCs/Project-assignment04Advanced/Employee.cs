using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AdvancedCs.Project_assignment04Advanced
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            int dayes = (To- From).Days;
            if (dayes <= VacationStock) {
                VacationStock -= dayes;
                return true;
            }
            return false;
        }
        public void EndOfYearOperation()
        {
            if (VacationStock <= 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause=LayOffCause.VacationStockBelowZero});
            }
            else if (DateTime.Now.Year-BirthDate.Year>60) {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.AgeOverSixty });
            }
        }
        public void Subscribe(EventHandler<EmployeeLayOffEventArgs> action)
        {
            EmployeeLayOff += action;
        }

        public void UnSubscribe(EventHandler<EmployeeLayOffEventArgs> action)
        {
            EmployeeLayOff -= action;
        }
    }
}
