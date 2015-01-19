using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace BLL.Interface.Services
{
    public interface IUserService
    {
        IUnitOfWork UnitOfWork { get; }
        IUserRepository Repository { get; }

        List<UserEntity> GetAll();
        void Insert(UserEntity entity);
        void Update(UserEntity entity);
        void Delete(UserEntity entity);

        UserEntity GetById(int id);
    }
}
