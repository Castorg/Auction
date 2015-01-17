using System;
using System.Collections.Generic;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
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
            UnitOfWork = ouw;
            Repository = repository;
        }

        public List<RoleEntity> GetAll()
        {
            var list = new List<RoleEntity>();
            foreach (var e in Repository.GetByPredicate())
            {
                list.Add(e.ToRoleEntity());
            }
            return list;
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
