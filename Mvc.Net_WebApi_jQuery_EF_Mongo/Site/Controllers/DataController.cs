
using Site.DB;
using Site.Interfaces;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Site.Controllers
{
    public class DataController : ApiController
    {

       // IDAL DataBase = new Site.DB.MongoDB();
        IDAL DataBase = new Site.DB.EFDB();

        [HttpPost]
        public IHttpActionResult AddUser(User u)
        {
            if (ModelState.IsValid)
            {
                u.InsertDate = DateTime.Now;
                DataBase.AddUser(u);
                return Json(new { rc=0});
            }
            return Json(new { rc = -1 });
        }

    }


  
}
