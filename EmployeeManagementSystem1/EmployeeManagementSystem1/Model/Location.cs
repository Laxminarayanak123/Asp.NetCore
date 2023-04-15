using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem1.Model
{
    public partial class Location
    {
        public Location()
        {
            Department = new HashSet<Department>();
        }

        public string Id { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryId { get; set; }

        public virtual Countries Country { get; set; }
        public virtual ICollection<Department> Department { get; set; }
    }
}
