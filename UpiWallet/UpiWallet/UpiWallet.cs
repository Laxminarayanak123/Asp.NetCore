using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UpiWallet.Model;

namespace UpiWallet
{
    internal class UpiWallet
    {
        public string FavouriteUpi()
        {
            UpidbContext upi = new UpidbContext();
            List<TransactionModel> l1 = upi.tbl_Transaaction.ToList();
            double max = l1[0].Amount;
            TransactionModel temp = new TransactionModel();
            string name = "";
            double amount = 0;
            foreach(TransactionModel item in l1)
            {
                if (item.Amount > max)
                {
                    name = item.UPI.Name;
                    amount = item.Amount;
                }
            }
            Console.WriteLine(name +" "+amount);
            string result =name +" "+ amount.ToString();
            return result;
        }

        public Dictionary<DateTime,int> GetPerDateTransactions()
        {
            int count;
            UpidbContext context = new UpidbContext();
            List<TransactionModel> l1 = context.tbl_Transaaction.ToList();
            HashSet<TransactionModel> h1 = new HashSet<TransactionModel>(l1);
            //HashSet<TransactionModel> h1 = context.tbl_Transaaction.ToHashSet();



            Dictionary<DateTime, int> d1 = new Dictionary<DateTime, int>();
            foreach(TransactionModel item1 in h1) 
            {
                count = 0;
                foreach(TransactionModel item2 in l1) 
                {
                    if(item1.TransactionDate == item2.TransactionDate)
                    {
                        count++;
                    }
                }
                d1.Add(item1.TransactionDate, count);

            }


            return d1;
            
        }




    }
}
