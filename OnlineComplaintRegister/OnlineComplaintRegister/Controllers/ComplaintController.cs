using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineComplaintRegister.Controllers
{
    public class ComplaintController : Controller
    {
        // GET: Complaint
        public ActionResult Index()
        {
            return Content("hai");
        }

        public ActionResult CreateComplaint()
        {
            return View();
        }


        public ActionResult List()
        {
            return View();
        }


        public ActionResult CloseComplaint() 
        {
            return View();
        }


    }
}