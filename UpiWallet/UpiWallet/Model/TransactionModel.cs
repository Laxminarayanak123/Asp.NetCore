using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UpiWallet.Model
{
    internal class TransactionModel
    {
        [Key,Required]
        public int TransactionId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public virtual UpiModel  UPI  { get; set; }


    }
}
