using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace WeddingPlanner
{
    internal class Conto
    {

        public Conto()
        {
            Console.WriteLine("welcome to convo wedding dreams");
        }
        public ArrayList pack()
        {
            ArrayList pack = new ArrayList();
            pack.Add("FSW");
            pack.Add("DW");
            pack.Add("D");
            pack.Add("fsw");
            pack.Add("dw");
            pack.Add("d");

            return pack;
        }

        public ArrayList FSW()
        {
            ArrayList fsw = new ArrayList();
            fsw.Add("wedding venues");
            fsw.Add("vendor management");
            fsw.Add("wedding invites");
            fsw.Add("photography");
            fsw.Add("videography");
            fsw.Add("bridal styling");

            return fsw;
        }
        public ArrayList DW()
        {
            ArrayList dw = new ArrayList();
            dw.Add("wedding venues");
            dw.Add("transportation");
            dw.Add("bridal styling");
            return dw;
        }
        public ArrayList D()
        {
            ArrayList d = new ArrayList();
            d.Add("floor design");
            d.Add("lighting design");
            d.Add("furniture linen");
            return d;
        }

        public string reference = "";
        public bool ValidatePackage(string packageType)
        {
            ArrayList pack1 = pack();
            foreach (string item in pack1)
            {
                if (item == packageType)
                {
                    reference = item;
                    Console.WriteLine("ref:" + reference);
                    return true;
                }
            }
            return false;
        }
        //public bool ValidateEventList(string packageType)
        //{
        //    String[] str1 = packageType.Split(',');
        //    Console.WriteLine(str1+"testing");
        //    if (reference == "FSW")
        //    {
        //        ArrayList temp = FSW();
        //        for(int i = 0; i < str1.Length; i++)
        //        {
        //            int ref1 = 0;
        //            for(int j = 0; j < temp.Count; j++)
        //            {
        //                if (str1[i] == temp[j])
        //                {
        //                    ref1 = 1;
        //                    break;
        //                }
        //            }
        //            if (ref1 != 1)
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //    else if(reference == "DW")
        //    {
        //        ArrayList temp = DW();
        //        for (int i = 0; i < str1.Length; i++)
        //        {
        //            int ref1 = 0;
        //            for (int j = 0; j < temp.Count; j++)
        //            {
        //                if (str1[i] == temp[j])
        //                {
        //                    ref1 = 1;
        //                    break;
        //                }
        //            }
        //            if (ref1 != 1)
        //            {
        //                return false;
        //            }
        //        }
        //        return true;

        //    }
        //    else if(reference == "D")
        //    {
        //        ArrayList temp = D();
        //        for (int i = 0; i < str1.Length; i++)
        //        {
        //            int ref1 = 0;
        //            for (int j = 0; j < temp.Count; j++)
        //            {
        //                if (str1[i] == temp[j])
        //                {
        //                    ref1 = 1;
        //                    break;
        //                }
        //            }
        //            if (ref1 != 1)
        //            {
        //                return false;
        //            }
        //        }
        //        return true;

        //    }
        //    return false;
        //}


        public bool ValidateEventList(string packageType,ArrayList events)
        {
            if (packageType == "FSW" || packageType == "fsw")
            {
                ArrayList temp = FSW();
                foreach (string item in events)
                {
                    if (!temp.Contains(item))
                    {
                        return false;
                    }
                }
                return true;

            }
            else if(packageType == "DW" || packageType == "dw")
            {
                ArrayList temp = DW();
                foreach (string item in events)
                {
                    if (!temp.Contains(item))
                    {
                        return false;
                    }
                }
                return true;

            }
            else if(packageType == "D" || packageType=="d")
            {
                ArrayList temp = D();
                foreach (string item in events)
                {
                    if (!temp.Contains(item))
                    {
                        return false;
                    }
                }
                return true;

            }
            return false;


        }

        public bool ValidateEventCost(double eventCost)
        {
            if (eventCost >= 5000)
            {
                return true;
            }
            return false;
        }

        public Dictionary<string, double> CreateWedding(string packageType, ArrayList eventsCost)
        {
            ArrayList events = new ArrayList();
            ArrayList costs = new ArrayList();
            foreach(string item in eventsCost)
            {
                String[] s1 =item.Split(',');
                events.Add(s1[0]);
                costs.Add(s1[1]);

            }
            Console.WriteLine(events[0]);
            Console.WriteLine(costs[0]);


            bool x = ValidateEventList(packageType, events);
            Console.WriteLine("x: "+x);
            bool y = true;
            foreach(string item in costs) 
            {
                 double cost = double.Parse(item);
                if (!ValidateEventCost(cost))
                {
                    y = false;
                    break;
                }
            }
            Console.WriteLine("y: " + y);

            Dictionary<string, double> dict1 = new Dictionary<string, double>();
            if(x && y)
            {
                for(int i=0;i<events.Count;i++)
                {
                    string s1= events[i].ToString();
                    string s2 = costs[i].ToString();
                    double d1 = double.Parse(s2);
                    dict1.Add(s1,d1);
                }
                return dict1;
            }
            return dict1;


        }
        public double GetTotalCost(Dictionary<string, double> wedding)
        {
            double d1 = 0;
            Dictionary<string, double>.ValueCollection value = wedding.Values;
            foreach(int val in value)
            {
                d1 = d1 + val;
            }
            return d1;
        }



    }
}
