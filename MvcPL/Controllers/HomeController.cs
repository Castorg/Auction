using System;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
using MvcPL.AlternativeAuth;
using MvcPL.Models;


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

        public HomeController(IUserService userService, ILotService lotService, IStoreService storeService,
            IRoleService roleService)
        {
            this._userService = userService;
            this._lotService = lotService;
            this._roleService = roleService;
            this._storeService = storeService;
        }

        public ActionResult Index()
        {
            #region Store

            /*
            var st = new Store {Name = "ДАРОМ.БАЙ", Addres = "ТРЦ \"На ночлежке у ежа\"", StoreId = 3};
            //_storeService.Repository.Create(new Store{Name = "PROstore" ,Addres = "tyt" ,StoreId = 1});

            _lotService.Repository.Create(new Lot { CurrentCost = 121 , Description = "Копилка для монет" , LotId = 9 , Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 144, Description = "Солдатик оловянный (моряк)обмен на монеты", LotId = 10, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 169, Description = "Маслобойка старинная торг обмен на монеты", LotId = 11, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 196, Description = "Колокольчик старинный торг обмен на монеты", LotId = 12, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 225, Description = "Старые счеты времен СССР", LotId = 13, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 256, Description = "Радиола Кантата-206 стерео рабочая ", LotId = 14, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 289, Description = "Старинная керосиновая лампа TORPEDO Poland стекло", LotId = 15, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 324, Description = "Старинный тяжеленный утюг нечищен", LotId = 16, Store = st });
            _lotService.UnitOfWork.Commit();*/


            #endregion

            #region Cookie
            /*
            var user = System.Web.HttpContext.Current.Request.Cookies["user"];
            if (user == null)
            {
                //var a = base.PostAuthenticateRequest;
            }
            else
            {
                var ticket = FormsAuthentication.Decrypt(user.Value);
                if (ticket != null)
                {
                    var ui = UserInfo.FromString(ticket.UserData);
                    if (ui != null)
                    {
                        Response.SetCookie(new HttpCookie("test")
                        {
                            Value = ui.Name
                        });
                    }
                }
            }*/


            #endregion

            var temp = _lotService.GetAll().Select(lot => new LotModel
            {
                CurencCost = lot.CurrentCost,
                Description = lot.Description,
                Address = _storeService.GetById(lot.StoreId).Addres
            });
            return View(temp);
        }

        public ActionResult Find(string term)
        {
            ViewBag.template = term;
            var temp = _lotService.GetLotEntityBySubMask(term).Select(lot => new LotModel
            {
                CurencCost = lot.CurrentCost,
                Description = lot.Description,
                Address = _storeService.GetById(lot.StoreId).Addres
            });
            return View(temp);
        }
    }
}
