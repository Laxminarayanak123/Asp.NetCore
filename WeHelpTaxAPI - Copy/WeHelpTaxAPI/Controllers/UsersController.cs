using JWTWebAuthentication.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WeHelpTaxAPI.Models;
using WeHelpTaxAPI.Repository;

namespace WeHelpTaxAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {


        private readonly taxPayerApplicationContext taxContext;
        private readonly IJWTManagerRepository _jWTManager;


        public UsersController(taxPayerApplicationContext tax, IJWTManagerRepository jWTManager)
        {
            _jWTManager = jWTManager;

            taxContext = tax;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody] Users users)
        {
            //checking if employee email exists in employee db
            List<Employee> l1 = taxContext.Employee.ToList();
            bool flag1 = false;
            foreach(Employee i in l1)
            {
                if(i.Email == users.Email)
                {
                    flag1 = true;
                    break;
                }
            }

            //checking if already the email exists in user table
            bool flag2 = false;
            List<Users> l2 = taxContext.Users.ToList();

            foreach(Users u in l2)
            {
                if(u.Email == users.Email)
                {
                    flag2= true;
                    break;
                }
            }


            if (flag1 && !flag2)
            {

                taxContext.Users.Add(users);
                taxContext.SaveChanges();
                return StatusCode(200, "user registered");
            }
            else
            {
                return StatusCode(409, "Email doesn't exists in the employee table or you already registered");
            }

        }



        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] Users user)
        {
            System.Console.WriteLine("testing login"+user.Email);

            List<Users> ul = taxContext.Users.ToList();
            bool temp = false;
            string admin = "";
            foreach (Users u in ul)
            {
                if (u.Email == user.Email && u.Password == user.Password)
                {
                    temp = true;
                    if (u.IsAdmin == true)
                    {
                        admin = "admin";
                    }
                }
                
            }


            Tokens token = null;

            if (temp)
            {
                System.Console.WriteLine("bye");
                 token = _jWTManager.Authenticate(user);

                if (token == null)
                {
                    return Unauthorized("token not generated");
                }

                //return Ok(token);
                var obj = new
                {
                    admin = admin,
                    token = token
                };  
                return StatusCode(200,obj);

            }
            else
            {
                var obj = new
                {
                    admin = admin,
                    token = token
                };
                return StatusCode(200, obj);
            }

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Users> l1 = taxContext.Users.ToList();
            return StatusCode(200, l1);
        }

        [HttpDelete("delete/{id}")]

        public IActionResult Delete(int id)
        {
            List<Users> l1 = taxContext.Users.ToList();
            bool flag = false;
            foreach(Users u in l1)
            {
                if(u.UserId== id)
                {
                    taxContext.Users.Remove(u);
                    taxContext.SaveChanges();
                    flag = true;
                }
            }

            if (flag)
            {
                return StatusCode(200, "deletion success");
            }
            return StatusCode(404,"id for deletion not found");
        }

    }
}
