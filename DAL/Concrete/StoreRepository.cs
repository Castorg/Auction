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
    public class StoreRepository : IStoreRepository
    {
                private readonly DbContext _dbContext;
        internal DbSet<Store> DbSet;

        public StoreRepository(IUnitOfWork uow)
        {
            if (uow == null) throw new ArgumentException("UnitOfWork");
            this._dbContext = uow.Context;
            this.DbSet = _dbContext.Set<Store>();
        }


        public IEnumerable<Store> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public Store GetById(int key)
        {
            return DbSet.Find(key);
        }

        public IQueryable<Store> GetByPredicate(System.Linq.Expressions.Expression<Func<Store, bool>> f = null)
        {
            return f == null ? DbSet : DbSet.Where(f);
        }

        public void Create(Store e)
        {
            DbSet.Add(e);
        }

        public void Delete(Store e)
        {
            DbSet.Remove(e);
        }

        public void Update(Store entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
