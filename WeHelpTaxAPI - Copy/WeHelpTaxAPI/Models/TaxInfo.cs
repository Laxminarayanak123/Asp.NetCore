using System;
using System.Collections.Generic;

namespace WeHelpTaxAPI.Models
{
    public partial class TaxInfo
    {
        public int Id { get; set; }
        public double SalaryFrom { get; set; }
        public double SalaryTo { get; set; }
        public double TaxRate { get; set; }
    }
}
