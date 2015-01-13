using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
using DAL.Interface.DTO;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork uow;
        private readonly IUserRepository userRepository;
        public UserService(IUnitOfWork uow, IUserRepository repository)
        {
            this.uow = uow;
            this.userRepository = repository;
            //Debug.WriteLine("service create!");
        }
        public IEnumerable<UserEntity> GetAllUserEntities()
        {
            //using (uow)
            {
                return userRepository.GetAll().Select(user => user.ToBllUser());
            }
        }
        public void CreateUser(UserEntity user)
        {
            userRepository.Create(user.ToDalUser());
            uow.Commit();
        }
    }
}
