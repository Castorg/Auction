using System;
using System.Collections.Generic;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        public IUnitOfWork UnitOfWork { get; set; }

        public IUserRepository Repository { get; set; }


        public UserService(IUserRepository repository, IUnitOfWork ouw)
        {
            UnitOfWork = ouw;
            Repository = repository;
        }

        public List<UserEntity> GetAll()
        {
            var list = new List<UserEntity>();
            foreach (var e in Repository.GetByPredicate())
            {
                list.Add(e.ToUserEntity());
            }
            return list;
        }

        public void Insert(UserEntity entity)
        {
            Repository.Create(entity.ToUser()); 
        }

        public void Update(UserEntity entity)
        {
            Repository.Update(entity.ToUser());
        }

        public void Delete(UserEntity entity)
        {
            Repository.Delete(entity.ToUser());
        }

        public UserEntity GetById(int id)
        {
            return Repository.GetById(id).ToUserEntity();
        }
    }
}
