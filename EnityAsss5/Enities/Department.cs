using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFwAsss4.Entities
{
    public class Department
    {

        public int DepartmentId { get; set; }


        public String? DeptName { get; set; }


        // one to one  (Employee  must from one side)

        // Foreign key


        public int MangerId { set; get; }

        [InverseProperty("Department")]
        public virtual Employee? Manger { get; set; }



        // one to many Employee


        [InverseProperty("workDeparments")]

        public virtual ICollection<Employee> employees { get; set; } = new HashSet<Employee>();
    }
}
