using System.Data.Entity;
using BLL.Interface;
using BLL.Interface.Services;
using BLL.Services;
using CustomORM;
using DAL.Concrete;
using DAL.Interface.Repository;
using Ninject.Modules;
namespace DependencyResolver
{
    public class ResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<EntityContext>().InSingletonScope();

            Bind<IRepository<Lot>>().To<BaseRepository<Lot>>();
            Bind<IRepository<Store>>().To<BaseRepository<Store>>();
            Bind<IRepository<User>>().To<BaseRepository<User>>();
            Bind<IRepository<Role>>().To<BaseRepository<Role>>();

            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IUserService>().To<UserService>();
            Bind<IStoreService>().To<StoreService>();
            Bind<IRoleService>().To<RoleService>();
            Bind<ILotService>().To<LotService>();
        }
    }
}
