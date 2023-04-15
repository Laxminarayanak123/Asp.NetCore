using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem1.Model
{
    public partial class Countries
    {
        public Countries()
        {
            Location = new HashSet<Location>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int? RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
