using System;
using System.Collections.Generic;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using CustomORM;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class RoleService : IRoleService
    {
        public IUnitOfWork UnitOfWork { get; private set; }

        public IRepository<Role> Repository { get; private set; }

        public RoleService(IRepository<Role> repository, IUnitOfWork ouw)
        {
            
        }

        public List<RoleEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(RoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(RoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(RoleEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
