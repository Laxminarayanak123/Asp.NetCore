using System;
using System.Collections.Generic;
using System.Linq;
using Lms_Db.Model;

namespace Lms_Db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lms_dbContext lms_db = new lms_dbContext();
            List<LmsBookDetails> books = lms_db.LmsBookDetails.ToList();



            foreach (LmsBookDetails item in books)
            {
                Console.WriteLine(item.BookTitle + "  " + item.Author);
            }



            // Linq query 




        }
    }
}
