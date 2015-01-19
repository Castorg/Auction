using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Services;
using CustomORM;
using DAL.Concrete;
using Ninject;
using AutoMapper;

namespace ConsoleTestPL
{

    internal class Foo
    {
        public int VAlue{get; set; } 
    }

    class Boo
    {
        public int temp { get; set; } 
    }

    class Program
    {
        private static void Main(string[] args)
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


            //var lll = new User { Id = 1234, Name = "kolya" , Role = new Role{Name = "DOLDO" ,RoleId = 3 ,Description = "shit"}};
            var ttt = new Lot {CurrentCost = 499, Description = "Motor", LotId = 12, Store = new Store{StoreId = 1}};
            var yyy = new LotEntity {CurrentCost = 299, Description = "mouse", Id = 134, StoreId = 2};

            using (var uow = new UnitOfWork(new EntityContext())) 
            {
               


                uow.Commit();
                /*var a = from b in db.Stores
                        select b;
                foreach (var VARIABLE in a)
                {
                    Console.WriteLine(VARIABLE.Name);
                }*/
                int aasd = 0;
            }
        }
    }
}
