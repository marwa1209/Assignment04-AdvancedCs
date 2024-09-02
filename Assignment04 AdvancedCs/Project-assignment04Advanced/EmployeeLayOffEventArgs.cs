using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AdvancedCs.Project_assignment04Advanced
{
     class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
        public EmployeeLayOffEventArgs(LayOffCause cause)
        {
            Cause = cause;
        }
    }
}
