using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AdvancedCs.Project_assignment04Advanced
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;
        public void AddStaff(Employee E)
        {
            throw new NotImplementedException();
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,

        EmployeeLayOffEventArgs e)

        {
            throw new NotImplementedException();
        }
    }
}
