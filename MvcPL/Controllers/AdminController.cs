using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
using MvcPL.Models;

namespace MvcPL.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILotService _lotService;
        private readonly IStoreService _storeService;
        private readonly IRoleService _roleService;

        public AdminController(IUserService userService, ILotService lotService, IStoreService storeService,
            IRoleService roleService)
        {
            this._userService = userService;
            this._lotService = lotService;
            this._roleService = roleService;
            this._storeService = storeService;
        }
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

        public ActionResult FindLot(string term)
        {
            var a = _lotService.GetLotEntityBySubMask(term);
            return View();
        }

        public ActionResult FindUser(string term )
        {
            var a = _userService.GetLotEntityBySubMask(term);
            var temp = a.Select(f => new UserModel()
            {
                Name = f.Name,
                RoleDesc = f.Role.Description,
                Password = f.Password,
                Time = f.Time
            });
           return View(temp);
        }

        public ActionResult EditUser()
        {
            throw new NotImplementedException();
        }
    }
}
