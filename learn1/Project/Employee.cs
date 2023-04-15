
using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Employee
    {
        private string fname;
        private string lname;
        private string email;
        private int pno;
        private DateTime hire_date;
        private DateTime dob;
        private int depId;
        public Employee()
        {
            

        }

        public string Fname { get { return fname; }
            set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public string Email { get { return email; } set { email = value; } }    
        public int Pno { get { return pno; } set { pno = value; } }     
        public DateTime Hire_date { get { return hire_date; }set{ hire_date = value;} }

        public DateTime Dob { get { return dob; }set{ dob = value;} }

        public int DeptId { get { return depId; } set { depId = value; } }





        public bool addEmployee(Employee employee)
        {
            return true;
        }


    }
}
