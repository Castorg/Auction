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
    public interface IRoleService
    {
        IUnitOfWork UnitOfWork { get; }
        IRoleRepository Repository { get; }

        List<RoleEntity> GetAll();
        void Insert(RoleEntity entity);
        void Update(RoleEntity entity);
        void Delete(RoleEntity entity);

        RoleEntity GetById(int id);

        Role GetByName(string mask);
    }
}
