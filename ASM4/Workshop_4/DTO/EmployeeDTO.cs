using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_4.DTO
{
    public class EmployeeDTO
    {
        private string empID;
        private string empPassword;
        private bool empRole;
        public EmployeeDTO()
        {

        }

        public EmployeeDTO(string empID, string empPassword, bool empRole)
        {
            this.empID = empID;
            this.empPassword = empPassword;
            this.empRole = empRole;
        }

        public string EmpID { get => empID; set => empID = value; }
        public string EmpPassword { get => empPassword; set => empPassword = value; }
        public bool EmpRole { get => empRole; set => empRole = value; }
    }
}
