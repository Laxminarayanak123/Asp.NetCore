using System;
using System.Collections.Generic;

namespace Lms_Db.Model
{
    public partial class LmsSuppliersDetails
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
    }
}
