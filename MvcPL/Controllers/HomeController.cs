using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interface.Services;

namespace MvcPL.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserService _userService;
        private readonly ILotService _lotService;
        private readonly IStoreService _storeService;
        private readonly IRoleService _roleService;


        public HomeController()
        {
            int v = 0;
        }
        public HomeController(IUserService userService, ILotService lotService ,IStoreService storeService ,IRoleService roleService)
        {
            this._userService = userService;
            this._lotService = lotService;
            this._roleService = roleService;
            this._storeService = storeService;
            int a = 0;
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
