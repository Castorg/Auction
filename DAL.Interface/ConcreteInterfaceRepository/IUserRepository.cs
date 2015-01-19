using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CustomORM;
using DAL.Interface.Repository;

namespace DAL.Interface.ConcreteInterfaceRepository
{
    public interface IUserRepository
    {
        User GetById(int key);
        IQueryable<User> GetByPredicate(Expression<Func<User, bool>> f = null);
        void Create(User e);
        void Delete(User e);
        void Update(User entity);

        User Login(string userName , string password );
        void SaveChages();
    }
}
