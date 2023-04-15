using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UpiWallet.Model;

namespace UpiWallet
{
    internal class UpiRepository
    {
        public int AddUpi(UpiModel upi)
        {
            UpidbContext context= new UpidbContext();
            //List<UpiModel> l1 = context.tbl_Upi.ToList();

             context.tbl_Upi.Add(upi);

            int rowsAftfected = context.SaveChanges();
            if(rowsAftfected> 0 )
            {
                return 1;
            }
            return 0;

        }


        public List<UpiModel> GetUpis() 
        {
            UpidbContext context = new UpidbContext();
            
            List<UpiModel> l1 = context.tbl_Upi.ToList();

            return l1;
        }




        public int AddTransactions(TransactionModel transaction)
        {


            UpidbContext context = new UpidbContext();
            List<UpiModel> l1 = context.tbl_Upi.ToList();
            transaction.UPI = l1[0];
            List<string> l2 = new List<string>();
            foreach(UpiModel i in l1)
            {
                l2.Add(i.Name);
            }
            Console.WriteLine(transaction.Amount);
            Console.WriteLine(transaction.Type);
            Console.WriteLine(transaction.UPI);
            Console.WriteLine(transaction.TransactionDate);

            if (l2.Contains(transaction.UPI.Name))
            {
                Console.WriteLine("testing add transaction");
                context.tbl_Transaaction.Add(transaction);
                context.SaveChanges();
                return 1;
            }
            return -2;
        }

    }
}
