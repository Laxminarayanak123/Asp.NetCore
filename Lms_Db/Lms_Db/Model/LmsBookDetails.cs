using System;
using System.Collections.Generic;

namespace Lms_Db.Model
{
    public partial class LmsBookDetails
    {
        public string BookCode { get; set; }
        public string BookTitle { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public DateTime? PublishDate { get; set; }
        public int? BookEdition { get; set; }
        public decimal? Price { get; set; }
        public string RackNum { get; set; }
        public DateTime DateArrival { get; set; }
        public string SupplierId { get; set; }
    }
}
