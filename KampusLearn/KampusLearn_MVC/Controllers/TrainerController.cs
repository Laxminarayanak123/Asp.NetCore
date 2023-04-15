using Microsoft.AspNetCore.Mvc;
using KampusLearn_MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace KampusLearn_MVC.Controllers
{
    public class TrainerController : Controller
    {
        private readonly KampusLearnDbContext context;

        public TrainerController(KampusLearnDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Trainer> l1 = context.Trainers.ToList();

            return View(l1);
        }
    }
}
