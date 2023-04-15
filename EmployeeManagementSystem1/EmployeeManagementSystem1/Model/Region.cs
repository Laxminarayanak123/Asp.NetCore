using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem1.Model
{
    public partial class Region
    {
        public Region()
        {
            Countries = new HashSet<Countries>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}
