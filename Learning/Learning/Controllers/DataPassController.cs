using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    public class DataPassController : Controller
    {
        // GET: DataPass
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string FormDataUsingParameter(string firstName, string secondName)
        {
            return "Name : " + firstName + " " + secondName;
        }
        
        [HttpPost]
        public string FormDataUsingRequest()
        {
            string firstName = Request["firstName"];
            string secondName = Request["secondName"];
            return "Name : " + firstName + " " + secondName;
        }
    }
}