using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPL.Models;

namespace MvcPL.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

         [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
         public ActionResult Edit(LotModel lot ,UserModel user)
         {
             return View();
         }
    }
}
