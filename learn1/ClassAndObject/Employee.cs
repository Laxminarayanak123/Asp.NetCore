using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    internal class Employee
    {
        private int empId;
        private string empName;
        private string email;

        public Employee()
        {

        }
        public Employee(int empid, string empname, string email)
        {
            this.empId = empid;
            this.empName = empname;
            this.email = email;
        }

        public int EmpId
        {
            get {
                return empId;
            }
            set { 
            empId = value;}
        }

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public string Email
        {
            get { return email; }

            set { email = value; }
        }
        public void printDetails()
        {
            Console.WriteLine("empId : " + EmpId);
            Console.WriteLine("empName : " + EmpName);
            Console.WriteLine("Email : " + Email);

        }
    }
}
