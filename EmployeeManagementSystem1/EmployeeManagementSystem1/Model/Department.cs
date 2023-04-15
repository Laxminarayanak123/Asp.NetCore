using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem1.Model
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
            Manager = new HashSet<Manager>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Manager> Manager { get; set; }
    }
}
