using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using ORM;


namespace DAL.Concrete
{
    public class UserRepository
    {
        private readonly DbContext context;

        public UserRepository(IUnitOfWork uow)
        {
            this.context = uow.Context;
            //Debug.WriteLine("repository create!");
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
    }
}
