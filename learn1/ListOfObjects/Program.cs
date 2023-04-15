using System;
using System.Collections.Generic;
using System.Linq;
namespace ListOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----listOfObjects----");
            Employee venom = new Employee();
            venom.Name = "venom";
            venom.Dept = "eSport";
            venom.Age= 20;


            List<Employee> l1 = new List<Employee>();
            l1.Add(venom);
            l1.Add(new Employee() { Name = "victor", Dept = "noob", Age= 20 });
            l1.Add(new Employee() { Name = "carlo", Dept = "bot", Age = 20 });

            foreach (Employee item in l1)
            {
                Console.WriteLine(item.Name+"   "+item.Dept+"  "+item.Age);
            }

            var query = from temp in l1 where temp.Dept == "eSport" select temp.Name;
            //Console.WriteLine(query.GetType());
            //Console.WriteLine(l1.GetType());
            //Console.WriteLine(query.Count());
            foreach(var i in query)
            {
                Console.WriteLine("name: "+i);
            }

        }
    }
}
