using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UpiWallet.Model
{
    internal class UpiModel
    {
        [Key,Required]
        public string UPI { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public long Mobile { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime JoinedOn { get; set; }

        public  ICollection<TransactionModel> TransactionModel { get; set; }


    }
}
