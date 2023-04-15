using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WeHelpTaxAPI.Models;
using System;
using log4net;


namespace WeHelpTaxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(EmployeeController));

        private readonly taxPayerApplicationContext taxContext;

        public EmployeeController(taxPayerApplicationContext tax)
        {
            taxContext = tax;
        }
        [HttpGet]
        public IActionResult Index()
        {
       
            List<Employee> employee = taxContext.Employee.ToList();

            List<Employee> l2 = new List<Employee>();
            foreach(Employee e in employee)
            {
                if(e.IsAlive == true)
                {
                    l2.Add(e);
                }
            }
            
            if(employee.Count<1)
            {
                return StatusCode(204);
            }
            else
            {
                return StatusCode(200, l2);
            }
           
        }

        [HttpGet("GetEmpDetails/{EmployeeId}")]
        public IActionResult GetEmployeeDetail(int EmployeeId)
        {
            Employee employee = taxContext.Employee.Find(EmployeeId);
            if (employee == null)
            {
                return StatusCode(404, "Employee not available");
            }
            else
            {
                return StatusCode(200, employee);
            }

        }

        [HttpDelete("DeleteEmp/{EmployeeId}")]
        public IActionResult DeleteEmployee(int EmployeeId)
        {
            Console.WriteLine(EmployeeId);
            Employee employee = taxContext.Employee.Find(EmployeeId);
            if (employee == null)
            {
                return StatusCode(404, "Course Id not available");
            }
            else
            {
                //taxContext.Employee.Remove(employee);
                employee.IsAlive= false;
                taxContext.SaveChanges();
                return Ok();
            }

        }


        [HttpPost("AddEmp")]
        public IActionResult AddNewEmployee([FromBody]Employee employee)
        {
                taxContext.Employee.Add(employee);
                taxContext.SaveChanges();
                return Ok();
          
            

        }

        [HttpPut("Update/{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody]Employee employee)
        {

            //employee.HireDate = (DateTime)employee.HireDate;
            //employee.DateOfBirth= (DateTime)employee.DateOfBirth;

            //employee.IsAlive= true;

            Console.WriteLine(employee);

            Employee original = taxContext.Employee.Find(id);

            if (employee.FirstName != null)
            {
                Console.WriteLine(employee.FirstName);
                original.FirstName = employee.FirstName;
            }
            if(employee.LastName != null)
            {
                Console.WriteLine(employee.LastName);
                original.LastName = employee.LastName;
            }
            if(employee.Email!= null)
            { 
                Console.WriteLine(employee.Email);
                original.Email = employee.Email;
            }
            if(employee.DepartmentId != null)
            {
                Console.WriteLine(employee.DepartmentId);
                original.DepartmentId = employee.DepartmentId;
            }
            if(employee.PhoneNumber!= null)
            {
                Console.WriteLine(employee.PhoneNumber);
                original.PhoneNumber = employee.PhoneNumber;
            }
            if(employee.DateOfBirth!= null)
            {
                Console.WriteLine(employee.DateOfBirth);

                original.DateOfBirth = employee.DateOfBirth;
            }
            if(employee.HireDate!= null)
            {
                Console.WriteLine(employee.HireDate);
                original.HireDate = employee.HireDate;
            }



            //taxContext.Employee.Update(employee);
            taxContext.SaveChanges();

            return Ok();
        }
    }
}
