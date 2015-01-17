using System;
using System.Collections.Generic;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        public IUnitOfWork UnitOfWork { get; set; }

        public IRepository<User> Repository { get; set; }

        public UserService(IRepository<User> repository, IUnitOfWork ouw)
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
            throw new NotImplementedException();
        }

        public void Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
