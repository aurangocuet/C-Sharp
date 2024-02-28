using Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    //return View();
        //}

        public string Index(string name)
        {
            return name;

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            User user = new User()
            {
                id = 3,
                name = "sabbir"
            };
            return View(user);
        }

        [HttpPost]
        public ActionResult About(User user)
        {
            user.id = 10;
            user.name = "sab";
            return View(user);
        }


        public ActionResult CustomHelper()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}