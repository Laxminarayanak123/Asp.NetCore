using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeHelpTaxAPI.Models;
using System.Linq;

namespace WeHelpTaxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly taxPayerApplicationContext deptcontext;
        public DepartmentController(taxPayerApplicationContext tax)
        {
            deptcontext = tax;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Department> department = deptcontext.Department.ToList();

            if (department.Count < 1)
            {
                return StatusCode(204);
            }
            else
            {
                return StatusCode(200, department);
            }

        }

        [HttpGet("GetDept/{DeptId}")]
        public IActionResult GetEmployeeDepartment(int DepartmentId)
        {
            Department department = deptcontext.Department.Find(DepartmentId);            
            return StatusCode(200, department);           
        }

        [HttpGet("DeleteDept/{DeptId}")]
        public IActionResult DeleteDepartment(int DepartmentId)
        {
            Department department = deptcontext.Department.Find(DepartmentId);
            if (department == null)
            {
                return StatusCode(404, "Course Id not available");
            }
            else
            {
                deptcontext.Department.Remove(department);
                deptcontext.SaveChanges();
                return Ok();
            }

        }


        [HttpPost("AddDept")]
        public IActionResult AddNewDepartment([FromBody] Department department)
        {
            if (department == null)
            {
                deptcontext.Department.Add(department);
                deptcontext.SaveChanges();
                return Ok();
            }
            else
            {
                return StatusCode(403);
            }

        }
    }
}
