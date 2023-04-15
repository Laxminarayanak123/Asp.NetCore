using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class TaxPayer
    {

        private double salary;
        private string dept;

        public TaxPayer()
        {

        }

        public double Salary { get { return salary; } set { salary = value; } }
        public string Dept { get { return dept; } set { dept = value; } }


        public double calculateTax(double Salary , string dept) {

            return Salary;
        }


    }
}
