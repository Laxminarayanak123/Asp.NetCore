using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComplaintRegister.Models
{
    public class Complaint
    {
        private int id;
        private string name;
        private string address;
        private string complaint;
        private DateTime date;
        private bool status;
        public Complaint() { }
        


        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }   

        public DateTime Date { get { return date; }
            set
            {
                date = value;
            } }
        public bool Status { get { return status; }
            set
            {
                status = value;
            } }
        public string Address { get { return address; }
            set
            {
                address = value;
            } }
        public string Complaint1 { get { return complaint; } set { complaint = value; } }

    }
}