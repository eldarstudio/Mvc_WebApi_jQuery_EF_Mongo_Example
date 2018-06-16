using Site.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
       // IDAL DataBase = new Site.DB.MongoDB();
         IDAL DataBase = new Site.DB.EFDB();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View(DataBase.GetUsers());
        }

        public ActionResult AddUser()
        {
            return View();
        }
    }
}