using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPL.Models;

namespace MvcPL.Controllers
{
    public class AccoutController : Controller
    {
        //
        // GET: /Accout/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Reg()
        {
            return View();
        }
        [HttpPost]
        public void Reg(RegisterViewModel viewModel)
        {
            int a = 0;

            RedirectToAction("Index", "Home");
        }

    }
}
