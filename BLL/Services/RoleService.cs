using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class RoleService : IRoleService
    {
        public IUnitOfWork UnitOfWork { get; private set; }

        public IRoleRepository Repository { get; private set; }

        public RoleService(IRoleRepository repository, IUnitOfWork ouw)
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
            Repository.Create(entity.ToRole()); 
        }

        public void Update(RoleEntity entity)
        {
            Repository.Update(entity.ToRole());
        }

        public void Delete(RoleEntity entity)
        {
            Repository.Delete(entity.ToRole());
        }



        public RoleEntity GetById(int id)
        {
            return Repository.GetById(id).ToRoleEntity();
        }

        public Role GetByName(string mask)
        {
            return Repository.GetByPredicate(f => f.Name == mask).FirstOrDefault();
        }
    }
}
