using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WeHelpTaxAPI.Models;

namespace WeHelpTaxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly taxPayerApplicationContext salContext;

        public SalaryController(taxPayerApplicationContext tax)
        {
            salContext = tax;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Salary> salary = salContext.Salary.ToList();

            if (salary.Count < 1)
            {
                return StatusCode(204);
            }
            else
            {
                return StatusCode(200, salary);
            }

        }

        [HttpGet("GetSal/{EmployeeId}")]
        public IActionResult GetEmployeeDetail(int EmployeeId)
        {
            //Employee employee = salContext.Employee.Find(EmployeeId);
            System.Console.WriteLine("hello");
            List<Salary> l1 = salContext.Salary.ToList();
            foreach(Salary s in l1)
            {
                if (EmployeeId == s.EmpId)
                {
                    return StatusCode(200,s);
                }
            }

                return StatusCode(404, "Emp id not available");


        }

        [HttpGet("DeleteEmp/{EmployeeId}")]
        public IActionResult DeleteEmployee(int EmployeeId)
        {
            Employee employee = salContext.Employee.Find(EmployeeId);
            if (employee == null)
            {
                return StatusCode(404, "Course Id not available");
            }
            else
            {
                salContext.Employee.Remove(employee);
                salContext.SaveChanges();
                return Ok();
            }

        }


        [HttpPost("AddSal/{id}")]
        public IActionResult AddNewEmployee(int id, [FromBody]string sal)
        {
            decimal sal1 = decimal.Parse(sal);


            //checking if the employee exists in the employee table
            bool ref1 = false;
            List<Employee> l1 = salContext.Employee.ToList();
            foreach(Employee emp in l1)
            {
                if(emp.Id== id)
                {
                    ref1 = true;
                }
            }

            //checking if the employee exists in the salary table
            bool ref2 = true;
            List<Salary>l2 = salContext.Salary.ToList();
            foreach(Salary salary in l2)
            {
                if(salary.EmpId== id)
                {
                    ref2 = false;
                }
            }

            if (ref1 && ref2)
            {
                Salary s1 = new Salary() { EmpId=id, Salary1=sal1};
                salContext.Salary.Add(s1);
                salContext.SaveChanges();
                return Ok();
            }
            else
            {
                return StatusCode(403,"no employee found with the given id  or salary of the employee already exists");
            }
        }


        [HttpPut("UpdateSal/{id2}")]
        public IActionResult UpdateSalary(int id2 , [FromBody]decimal salary1) 
        {
            System.Console.WriteLine("byee");
            //decimal sal1 = decimal.Parse(salary1);

            Salary s = salContext.Salary.Find(id2);
            System.Console.WriteLine(s.Salary1);

            s.Salary1 = salary1;

            salContext.SaveChanges();


            return Ok();
        }
    }
}
