using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
    public class Transaction
    {
        private int transactionId;
        private DateTime transactionDate;
        private int productId;
        private string transactionType;
        private int qty;
        private int updatedBy;

        public Transaction() 
        {

        }

        public int TransactionId { get { return transactionId; } set { transactionId = value; } }
        public DateTime TransactionDate { get { return transactionDate; } set { transactionDate = value; } }
        public int ProductId { get { return productId; } set { productId = value; } }
        public string TransactionType { get { return transactionType; } set { transactionType = value; } }

        public int Qty { get { return qty; } set { qty = value; } }

        public int UpdatedBy { get { return updatedBy; } set { updatedBy = value; } }




    }
}