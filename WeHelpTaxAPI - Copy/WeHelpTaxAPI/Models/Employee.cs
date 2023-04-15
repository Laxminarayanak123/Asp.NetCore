using System;
using System.Collections.Generic;

namespace WeHelpTaxAPI.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Salary = new HashSet<Salary>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? DepartmentId { get; set; }
        public bool? IsAlive { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Salary> Salary { get; set; }
    }
}
