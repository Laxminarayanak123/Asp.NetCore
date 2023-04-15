using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
    public class ProductMaster
    {

        private int productId;
        private string productName;
        private int availableQty;


        public ProductMaster()
        {

        }


        public int ProductId { get { return productId; } set { productId = value; } }
        public string ProductName { get { return productName; } set { productName= value; } }

        public int AvailableQty { get { return availableQty; } set { availableQty = value; } }

    }
}