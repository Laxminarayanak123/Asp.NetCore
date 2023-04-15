using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagementSystem1.Model;
namespace EmployeeManagementSystem1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee_DBContext empContext = new Employee_DBContext();
            List<Employee> l1 = empContext.Employee.ToList();


            foreach(Employee item in l1)
            {
                Console.WriteLine(item.FirstName +"    "+ item.PhoneNumber);
            }



            //find and show

            Console.WriteLine("enter id to find");
            Employee emp = empContext.Employee.Find(int.Parse(Console.ReadLine()));

            Console.WriteLine("The full name of the given id is : " + emp.FirstName + "  " + emp.LastName);


            //Employee emp2 = new Employee();
            //Console.WriteLine("enter details");
            //Console.WriteLine("enter first name");
            //emp2.FirstName = Console.ReadLine();

            //Console.WriteLine("enter last name");
            //emp2.LastName = Console.ReadLine();

            //Console.WriteLine("enter email");
            //emp2.Email = Console.ReadLine();

            //Console.WriteLine("enter phone number");
            //emp2.PhoneNumber = Console.ReadLine();

            //Console.WriteLine("enter hire date");
            //emp2.HireDatet = DateTime.Parse( Console.ReadLine());

            //Console.WriteLine("enter salary");
            //emp2.Salary = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter DOB");
            //emp2.DateOfBirth = DateTime.Parse( Console.ReadLine());

            //Console.WriteLine("enter DepId");
            //emp2.DepartmentId = int.Parse(Console.ReadLine());



            //empContext.Employee.Add(emp2);


            //int rowsAffected = empContext.SaveChanges();

            //if(rowsAffected > 0 )
            //{
            //    Console.WriteLine("successfully executed");
            //}
            //else
            //{
            //    Console.WriteLine("task failed");
            //}


            //remove command
            Console.WriteLine("enter id to remove");


            Employee emp1 =  empContext.Employee.Find(int.Parse(Console.ReadLine()));
            //empContext.Employee.Remove(emp1);

            int rowsAffected = empContext.SaveChanges();
            if(rowsAffected > 0 )
            {
                Console.WriteLine("success");
            }
            else
            {
                Console.WriteLine("failed");
            }

            //update 
            Console.WriteLine("enter id to update phone number ");
            Employee emp2 = empContext.Employee.Find(int.Parse(Console.ReadLine()));
            emp2.PhoneNumber = "9849946356";

            rowsAffected = empContext.SaveChanges();
            if (rowsAffected > 0)
            {
                Console.WriteLine("success");
            }
            else
            {
                Console.WriteLine("failed");
            }


        }
    }
}
