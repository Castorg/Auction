using System.Linq;
using System.Web.Mvc;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
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
        public HomeController(IUserService userService, ILotService lotService ,IStoreService storeService ,IRoleService roleService)
        {
            this._userService = userService;
            this._lotService = lotService;
            this._roleService = roleService;
            this._storeService = storeService;
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            #region Store
            /*
            var st = new Store {Name = "Kupi-Prodau", Addres = "tam", StoreId = 2};
            //_storeService.Repository.Create(new Store{Name = "PROstore" ,Addres = "tyt" ,StoreId = 1});

            _lotService.Repository.Create(new Lot { CurrentCost = 121 , Description = "Патефон \"дружба\"" , LotId = 1 , Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 144, Description = "Браслет \"Дары смерти\"", LotId = 2, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 169, Description = "Гримерное зеркало", LotId = 3, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 196, Description = "Штык нож \"Жаба\"", LotId = 4, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 225, Description = "3 копейки 1915 г", LotId = 5, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 256, Description = "2 копейки 1905 г", LotId = 6, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 289, Description = "10 копеек 1914 г СПБ ВС", LotId = 7, Store = st });
            _lotService.Repository.Create(new Lot { CurrentCost = 324, Description = "Автокресло Maxi-cosi Pebble", LotId = 8, Store = st });
            _lotService.UnitOfWork.Commit();*/


            #endregion
            var lots = _lotService.Repository.GetByPredicate();
            var temp = new LotModel[lots.Count()];
            int i = 0;
            foreach (var model in lots)
            {
                temp[i] = new LotModel();
                temp[i].CurencCost = model.CurrentCost;
                temp[i].Description = model.Description;
                temp[i].Address = _storeService.Repository.GetById(model.Store.StoreId).Addres;
                i++;
            }
            return View(temp);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult Find(string term)
        {
            return View();
        }

        public ActionResult AddLot()
        {
            return View();
        }
    }
}
