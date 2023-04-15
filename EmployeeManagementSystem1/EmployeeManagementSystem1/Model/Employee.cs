using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem1.Model
{
    public partial class Employee
    {
        public Employee()
        {
            Manager = new HashSet<Manager>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? HireDatet { get; set; }
        public int? Salary { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Manager> Manager { get; set; }
    }
}
