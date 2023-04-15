using System;
using System.Collections.Generic;
using System.Linq;
using UpiWallet.Model;

namespace UpiWallet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome");


            //UpiModel upi = new UpiModel();

            //Console.WriteLine("enter upi details to add");

            //Console.WriteLine("Enter upi string");
            //upi.UPI = Console.ReadLine();
            //Console.WriteLine("Enter upi name");
            //upi.Name = Console.ReadLine();
            //Console.WriteLine("Enter upi mobile no");
            //upi.Mobile = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter email");
            //upi.Email = Console.ReadLine();
            //upi.JoinedOn = DateTime.Now;


            UpiRepository ur   = new UpiRepository();
            //ur.AddUpi(upi);


            Console.WriteLine("press y to get all upis");
            string x = Console.ReadLine();
            if (x == "y")
            {
                List<UpiModel> l1 =  ur.GetUpis();
                foreach (UpiModel l in l1)
                {
                    Console.WriteLine(l.Name);
                }
            }



            //adding transactions
            UpidbContext context = new UpidbContext();

            //List<UpiModel> l2 = context.tbl_Upi.ToList();


          
            Console.WriteLine("adding transaction, enter details");

            TransactionModel transaction= new TransactionModel();
            Console.WriteLine("enter type");
            //transaction.Type = Console.ReadLine();
            //Console.WriteLine("enter Amount");
            //transaction.Amount =double.Parse( Console.ReadLine()); 
            //transaction.TransactionDate= DateTime.Now;
            //transaction.UPI = l2[0];

            //int response = ur.AddTransactions(transaction);
            //if(response == 1)
            //{
             //   Console.WriteLine("transaction success");
            //}



            Console.WriteLine("the transaction with highest amount ");

            Console.WriteLine("  ");

            UpiWallet uw = new UpiWallet();
            Console.WriteLine(uw.FavouriteUpi());

        }
    }
}
