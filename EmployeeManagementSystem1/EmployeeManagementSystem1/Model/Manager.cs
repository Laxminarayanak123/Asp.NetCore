using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem1.Model
{
    public partial class Manager
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
