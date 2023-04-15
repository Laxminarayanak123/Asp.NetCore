using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
    public class Users
    {

        private int userId;
        private string username;
        private string password;
        private string fullname;
        private bool isActive;
        private string category;

        public Users() { 
        }

        public int UserId {  get{ return userId; } set { userId = value; } }
        public string UserName { get { return username ;} set { username = value; } }

        public string Password { get { return password } set { password = value; } }
        public string FullName { get { return fullname; } set { fullname = value; } }
        public bool IsActive { get { return isActive; } set { isActive = value; } }

        public string Category { get { return category; } set { category = value; } }
    
    
    }
}