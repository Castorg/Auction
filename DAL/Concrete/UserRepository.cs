using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.DTO;
using DAL.Interface.Repository;


namespace DAL.Concrete
{
    public class UserRepository  : IUserRepository
    {
        private readonly DbContext context;

        public UserRepository(IUnitOfWork uow)
        {
            this.context = uow.Context;
            Debug.WriteLine("repository create!");
        }
        public IEnumerable<DalUser> GetAll()
        {
            return context.Set<User>().Select(user => new DalUser()
            {
                Id = user.Id,
                Name = user.Name
            });
        }
        public DalUser GetById(int key)
        {
            var ormuser = context.Set<User>().FirstOrDefault(user => user.Id == key);
            return new DalUser()
            {
                Id = ormuser.Id,
                Name = ormuser.Name

            };
        }
        public DalUser GetByPredicate(System.Linq.Expressions.Expression<Func<DalUser, bool>> f)
        {
            throw new NotImplementedException();
        }
        public void Create(DalUser e)
        {
            var user = new User()
            {
                Name = e.Name,
                RoleId = e.RoleId
            };
            context.Set<User>().Add(user);
        }
        public void Delete(DalUser e)
        {
            throw new NotImplementedException();
        }
        public void Update(DalUser entity)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetById(int key)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetByPredicate(System.Linq.Expressions.Expression<Func<User, bool>> f = null)
        {
            throw new NotImplementedException();
        }

        public void Create(User e)
        {
            throw new NotImplementedException();
        }

        public void Delete(User e)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public User Login(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
