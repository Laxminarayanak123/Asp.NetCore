using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception handling");
            try
            {
                throw new UserDef("random ");
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class UserDef : Exception
    {
        public UserDef(string msg):base(msg) 
        { 
        
        }
    }

}
