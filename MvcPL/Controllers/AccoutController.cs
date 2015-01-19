using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using MvcPL.Models;

namespace MvcPL.Controllers
{
    public class AccoutController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        public AccoutController(IUserService userService, IRoleService roleService)
        {
            this._userService = userService;
            this._roleService = roleService;
        }

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
        public ActionResult Reg(RegisterViewModel viewModel)
        {
            var a = _userService.GetAll();
            if (a.Select(f => f.UserName == viewModel.Login).Count() == 0)
            {
                _userService.Insert(new UserEntity
                {
                    UserName = viewModel.Login,
                });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Reg", "Accout");
            }
        }

    }
}
