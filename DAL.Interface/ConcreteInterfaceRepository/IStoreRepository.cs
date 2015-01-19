using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CustomORM;

namespace DAL.Interface.ConcreteInterfaceRepository
{
    public interface IStoreRepository
    {
        Store GetById(int key);
        IQueryable<Store> GetByPredicate(Expression<Func<Store, bool>> f = null);
        void Create(Store e);
        void Delete(Store e);
        void Update(Store entity);
    }
}
