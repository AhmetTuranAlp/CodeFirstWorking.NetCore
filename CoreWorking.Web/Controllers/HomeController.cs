using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreWorking.Entity.Model;
using CoreWorking.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreWorking.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly CoreWorkingContext _db;

        public HomeController(CoreWorkingContext db)
        {
            _db = db;
        }
        [HttpPost]
        public ActionResult Save(User model)
        {
            _db.User.Add(model);
            _db.SaveChanges();
            return View("Index");
        }

        public ActionResult List()
        {
            return View(_db.User.ToList());
        }
        
    }
}
