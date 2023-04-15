using JWTWebAuthentication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WeHelpTaxAPI.Models;
using System;

namespace WeHelpTaxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxCalculatorController : ControllerBase
    {

        private readonly taxPayerApplicationContext taxContext;

        public TaxCalculatorController(taxPayerApplicationContext tax)
        {
            taxContext = tax;
        }


        [HttpGet("{empid}")]
        public IActionResult Calculate( int empid)
        {
            Console.WriteLine("testing");
            Salary s = taxContext.Salary.FirstOrDefault(x => x.EmpId == empid);
            if (s == null)
            {
                return NotFound();
            }
            double salary = (double)s.Salary1 * 12;

            //using tax_info here

            List<TaxInfo> t1 = taxContext.TaxInfo.ToList();

            int taxId = 0;
            for(int i=0;i<t1.Count;i++)
            {
                if (salary < t1[i].SalaryFrom)
                {
                    if (i == 0)
                    {
                        taxId = 1;
                        break;
                    }
                    taxId = i;
                    Console.WriteLine(taxId);
                    break;
                }
            }
            if (taxId == 0)
            {
                taxId = t1[(t1.Count)-1].Id;
                Console.WriteLine(taxId);
            }


            //calculating tax and outputting it
            TaxInfo item = t1.Find(x => x.Id == taxId);

            double taxAmount = salary * item.TaxRate;



            //employee data
            Employee emp = taxContext.Employee.Find(empid);


            var taxData = new
            {
                amount = taxAmount,
                name = emp.FirstName + " " + emp.LastName,
                email = emp.Email

            };
            return StatusCode(200,taxData);



        }
    }
}
