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
    public class UserRepository : IUserRepository
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly DbContext context;
        internal DbSet<User> DbSet;

        public UserRepository(IUnitOfWork uow)
        {
            this.unitOfWork = uow;
            this.context = uow.Context;
            this.DbSet = context.Set<User>();
            Debug.WriteLine("repository create!");
        }

        User IUserRepository.GetById(int key)
        {
            var ormuser = context.Set<User>().FirstOrDefault(user => user.Id == key);
            return ormuser != null
                ? new User()
                {
                    Id = ormuser.Id,
                    Name = ormuser.Name
                }
                : null;
        }

        public IQueryable<User> GetByPredicate(System.Linq.Expressions.Expression<Func<User, bool>> f = null)
        {
            return f == null ? DbSet : DbSet.Where(f);
        }

        public void Create(User e)
        {
            DbSet.Add(e);
        }

        public void Delete(User e)
        {
            DbSet.Remove(e);
        }

        public void Update(User entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public User Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void SaveChages()
        {
           unitOfWork.Commit();
        }
    }
}
