using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CustomORM;

namespace DAL.Interface.ConcreteInterfaceRepository
{
    public interface ILotRepository
    {
        Lot GetById(int key);
        IQueryable<Lot> GetByPredicate(Expression<Func<Lot, bool>> f = null);
        void Create(Lot e);
        void Delete(Lot e);
        void Update(Lot entity);
    }
}
