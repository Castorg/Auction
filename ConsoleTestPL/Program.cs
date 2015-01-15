using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using CustomORM;
using Ninject;

namespace ConsoleTestPL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code
            //string path;/*= ConfigurationManager.AppSettings["repository"];*/
            //path = "C:\\Users\\Castorg\\Documents\\Visual Studio 2013\\Projects\\EPAM_proj\\DependencyResolver\\bin\\Debug\\DependencyResolver.dll";
            //Assembly assembly = null;
            //try
            //{
            //    assembly = Assembly.LoadFrom(path);
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //IKernel kernel = new StandardKernel();
            //kernel.Load(assembly);
            //var service = kernel.Get<IUserService>();


            ////var list = service.GetAllUserEntities().ToList();
            ///*list = service.GetUsersByRole(RoleEntity.User).ToList();
            //foreach (var user in list)
            //{
            //    Console.WriteLine(user.UserName);
            //}*/

            //var entity = new UserEntity();
            //entity.Id = 1;
            //entity.RoleId = 1;
            //entity.UserName = "ololo";
            //service.CreateUser(entity);

            //var list = service.GetAllUserEntities().ToList();
            //foreach (var user in list)
            //{
            //    Console.WriteLine(user.UserName);
            //}
            #endregion
            var lll = new Lot { CurrentCost = 100500 , Description = "Gravicapa"};

            using (var db = new EntityContext())
            {
                db.Lots.Add(lll);
                db.SaveChanges();


                var a = from b in db.Stores
                        select b;
                foreach (var VARIABLE in a)
                {
                    Console.WriteLine(VARIABLE.Name);
                }
                int aasd = 0;
            }
        }
    }
}
