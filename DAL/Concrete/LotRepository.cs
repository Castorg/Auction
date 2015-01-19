using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace DAL.Concrete
{
    public class LotRepository : ILotRepository
    {
        private readonly DbContext _dbContext;
        internal DbSet<Lot> DbSet;

        public LotRepository(IUnitOfWork uow)
        {
            if (uow == null) throw new ArgumentException("UnitOfWork");
            this._dbContext = uow.Context;
            this.DbSet = _dbContext.Set<Lot>();
        }


        public IEnumerable<Lot> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public Lot GetById(int key)
        {
            return DbSet.Find(key);
        }

        public IQueryable<Lot> GetByPredicate(System.Linq.Expressions.Expression<Func<Lot, bool>> f = null)
        {
            return f == null ? DbSet : DbSet.Where(f);
        }

        public void Create(Lot e)
        {
            DbSet.Add(e);
        }

        public void Delete(Lot e)
        {
            DbSet.Remove(e);
        }

        public void Update(Lot entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
