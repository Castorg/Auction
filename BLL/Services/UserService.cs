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

        public User Login(string userName, string password)
        {
            return Repository.GetByPredicate(f => (f.Name == userName && f.Password == password)).FirstOrDefault();
        }

        public User GetByName(string name)
        {
            return Repository.GetByPredicate(f => f.Name == name).FirstOrDefault();
        }

        public void SaveChanges()
        {
            Repository.SaveChages();
        }

        public List<User> GetLotEntityBySubMask(string temp)
        {
            return Repository.GetByPredicate(f => f.Name.Contains(temp)).ToList();
        }
    }
}
