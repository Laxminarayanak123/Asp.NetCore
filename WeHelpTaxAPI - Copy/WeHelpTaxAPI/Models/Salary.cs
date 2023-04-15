using System;
using System.Collections.Generic;

namespace WeHelpTaxAPI.Models
{
    public partial class Salary
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public decimal Salary1 { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
