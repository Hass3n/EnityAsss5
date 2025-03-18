using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFwAsss4.Entities
{
    public class Employee
    {

        public int EmployeeId { get; set; }

        public String? EmployeeName { get; set; }


        public float Salary { get; set; }


        // one to one Departments

        [InverseProperty("Manger")]
        
        public virtual Department? Department { get; set; }

        // one to many

        public int workDeparmentsId { set; get; }

        [InverseProperty("employees")]

        public virtual Department? workDeparments { get; set; }

    }
}
