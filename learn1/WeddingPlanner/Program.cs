using System;
using System.Collections;
using System.Collections.Generic;

namespace WeddingPlanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList pack = new ArrayList();
            pack.Add("FSW");
            pack.Add("DW");
            pack.Add("D");
            Conto c = new Conto();
            Console.WriteLine("enter the wedding package as you wish");
            String k1 = Console.ReadLine();
            ArrayList eventscosts = new ArrayList();

            if (c.ValidatePackage(k1))
            {

                Console.WriteLine("enter 3 event names and cost seperated by ',' for the selected package");
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("event details " + (i + 1));
                    string s1 = Console.ReadLine();
                    eventscosts.Add(s1);
                }
                //eventscosts.Add("floor design,5500");
                //eventscosts.Add("furniture linen,5500");
                //eventscosts.Add("lighting design,5500");


            }
            else
            {
                Console.WriteLine("invalid package");
            }
            Dictionary<string,double> dict1 = new Dictionary<string,double>();
            dict1= c.CreateWedding(k1, eventscosts);
            if (dict1.Count == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                double totalCost = c.GetTotalCost(dict1);
                Console.WriteLine("totalcost "+ totalCost);
            }
        }
    }
}
