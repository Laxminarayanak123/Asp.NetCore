using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(1);

            arr1.Add("venom");

            Hashtable dict1 = new Hashtable();
            dict1.Add("venom", 1);
            dict1.Add("likith", 2);



            //specific type
            List<int> list1 = new List<int>();
            list1.Add(1);




            Dictionary<int,string> dict2 = new Dictionary<int,string>();
            dict2.Add(1, "venom");
            dict2.Add(2, "venom");

            SortedSet<int> sSet = new SortedSet<int>();
            sSet.Add(10);
        }
    }
}
