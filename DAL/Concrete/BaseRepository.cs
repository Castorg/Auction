using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Repository;

namespace DAL.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T: class 
    {
        private readonly DbContext _dbContext;
        internal DbSet<T> DbSet;

        public BaseRepository(IUnitOfWork uow)
        {
            if (uow == null) throw new ArgumentException("UnitOfWork");
            this._dbContext = uow.Context;
            this.DbSet = _dbContext.Set<T>();
        }


        public IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public T GetById(int key)
        {
            return DbSet.Find(key);
        }

        public IQueryable<T> GetByPredicate(System.Linq.Expressions.Expression<Func<T, bool>> f = null)
        {
            return f == null ? DbSet : DbSet.Where(f);
        }

        public void Create(T e)
        {
            DbSet.Add(e);
        }

        public void Delete(T e)
        {
            DbSet.Remove(e);
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
