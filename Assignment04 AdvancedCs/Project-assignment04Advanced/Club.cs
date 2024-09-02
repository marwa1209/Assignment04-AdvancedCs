using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AdvancedCs.Project_assignment04Advanced
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;
        public void AddMember(Employee E)
        {
            throw new NotImplementedException();
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember

        (object sender, EmployeeLayOffEventArgs e)

        {
            throw new NotImplementedException();
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
    }
}
