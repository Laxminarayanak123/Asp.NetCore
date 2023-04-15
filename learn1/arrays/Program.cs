using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,2,3,4,5};
            //Console.WriteLine(arr1[0]);
            int[] arr2 = new int[5];
            for(int i=0;i<arr2.Length;i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("arr2");
            //for(int i = 0; i < arr2.Length; i++)
            //{
            //    console.writeline(arr2[i]);
            //}

            foreach(int i in arr2) {
                Console.WriteLine(i);
            }

            Array.Sort(arr2);
            Console.WriteLine("after sorting : ");
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }

            //reverse
            Console.WriteLine("descending : ");
            foreach(int i in arr2.Reverse())
            {
                Console.WriteLine(i);
            }

            //find index
            Console.WriteLine("enter to match");
            int to_match = int.Parse(Console.ReadLine());
            Console.WriteLine("index is :"+Array.FindIndex(arr2, (t) => t == to_match));



            //find even values
            Console.WriteLine("finding even numbers");
            
            foreach(int i in Array.FindAll(arr2, (t) => t % 2 == 0))
            {
                Console.WriteLine(i);
            }

            //find odd values
            Console.WriteLine("finding odd numbers");

            foreach (int i in Array.FindAll(arr2, (t) => t % 2 != 0))
            {
                Console.WriteLine(i);
            }

            //average
            int sum = 0;
            foreach(int i in arr2)
            {
                sum = sum + i;
            }
            int avg = sum / arr2.Length;
            Console.WriteLine("average:"+avg);

            //values greater than average
            Console.WriteLine("greater than average");
            foreach( int i in Array.FindAll(arr2,(t)=>t>avg))
            {
                Console.WriteLine(i);
            }
        }
    }
}
