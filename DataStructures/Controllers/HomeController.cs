using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // If clicked, method will return the user to www.espn.com
        public ActionResult Exit()
        {
            return Redirect("http://www.espn.com");
        }
    }
}