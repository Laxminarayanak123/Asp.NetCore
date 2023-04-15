using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagementSystem.

namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee_DBContext emp = new Employee_DBContext();
            List<Employee> l1 = emp.Employee.ToList();

            
        }
    }
}
