using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class AppUsers
    {
        private string username;
        private string password;

        public AppUsers() 
        {

        }


        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }


        public bool createUser(string username, string password)
        {
            return true;
        }

        public bool deleteUser(string username, string password)
        {
            return true;
        }

        public bool modifyUser(string username, string password)
        {
            return true;
        }

    }
}
