using System.Data.Entity;
using BLL.Interface;
using BLL.Interface.Services;
using BLL.Services;
using DAL.Concrete;
using DAL.Interface.Repository;
using Ninject.Modules;
using ORM;
namespace DependencyResolver
{
    public class ResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<EntityModel>().InSingletonScope();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IUserService>().To<UserService>();
        }
    }
}
