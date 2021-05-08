using StudentManagerC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagerC.Controllers
{
    public class NotifycationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowListStudent()
        {
            return View("ShowListTeachers");
        }


        [HttpPost]
        public ActionResult Save(StudentModel model)
        {
            ViewBag.IsSaved = true;
            return View("Index", model);
        }
    }
}
