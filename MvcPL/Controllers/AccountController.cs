using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
using MvcPL.AlternativeAuth;
using MvcPL.Models;
using WebGrease.Css;

namespace MvcPL.Controllers
{
    public class AccountController : Controller
    {
        private readonly string defaultRole = "Пользователь";
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        public AccountController(IUserService userService, IRoleService roleService)
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
            if (a.All(f => f.UserName != viewModel.Login))
            {
                _userService.Insert(new UserEntity
                {
                    UserName = viewModel.Login,
                    Password = viewModel.Password,
                    Time = DateTime.Now ,
                    Role = _roleService.GetByName(defaultRole).ToRoleEntity()
                });
                return RedirectToAction("Index", "Home");
            }
            _userService.SaveChanges();
            return RedirectToAction("Reg", "Account");
        }



        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LogInModel model)
        {
            var pocan = _userService.GetByName(model.Login);
            if (pocan != null)
            {
                if (pocan.Password == model.Password)
                {
                    var info = new UserInfo(pocan.Id, pocan.Role.Name, pocan.Name);
                    var ticket = new FormsAuthenticationTicket(1, pocan.Name, DateTime.Now,
                        DateTime.Now.Add(new TimeSpan(5, 0, 0)), true,
                        info.ToString());
                    var toCookie = FormsAuthentication.Encrypt(ticket);
                    Response.Cookies.Add(new HttpCookie("user", toCookie));
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.InvalidPass = "true";
                return View();
            }
            return View();
        }


        [HttpGet]
        [Authorize(Roles = "Админ,Пользователь")]
        public ActionResult AddLot()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddLot(Models.LotModel lot)
        {

            return View();
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            var cookie = new HttpCookie("user", string.Empty) {Expires = DateTime.Now.AddYears(-1)};
            Response.Cookies.Add(cookie);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult FindLot()
        {
            throw new NotImplementedException();
        }

        public ActionResult FindUser()
        {
            throw new NotImplementedException();
        }
    }
}
