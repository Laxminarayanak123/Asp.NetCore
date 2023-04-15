using System;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            char temp;

            do {
                obj = new Employee();
                Console.WriteLine("enter employee details");
                Console.WriteLine("enter EmpId :");
                obj.EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine("enter EmpName : ");
                obj.EmpName = Console.ReadLine();
                Console.WriteLine("enter Email : ");
                obj.Email = Console.ReadLine();
                obj.printDetails();
                Console.WriteLine("enter y to continue");
                temp = char.Parse(Console.ReadLine());
            } while (temp == 'Y' || temp == 'y');
            
            
        }
    }
}
