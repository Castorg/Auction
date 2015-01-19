using System.Data.Entity;
using BLL.Interface;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Services;
using CustomORM;
using DAL.Concrete;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;
using Ninject.Modules;
namespace DependencyResolver
{
    public class ResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<EntityContext>().InSingletonScope();

            Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();

            Bind<IUserRepository>().To<UserRepository>();
            Bind<IStoreRepository>().To<StoreRepository>();
            Bind<IRoleRepository>().To<RoleRepository>();
            Bind<ILotRepository>().To<LotRepository>();

            

            Bind<IUserService>().To<UserService>();
            Bind<IStoreService>().To<StoreService>();
            Bind<IRoleService>().To<RoleService>();
            Bind<ILotService>().To<LotService>();
        }
    }
}
