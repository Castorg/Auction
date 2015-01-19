using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CustomORM;

namespace DAL.Interface.ConcreteInterfaceRepository
{
    public interface IRoleRepository
    {
        Role GetById(int key);
        IQueryable<Role> GetByPredicate(Expression<Func<Role, bool>> f = null);
        void Create(Role e);
        void Delete(Role e);
        void Update(Role entity);
    }
}
