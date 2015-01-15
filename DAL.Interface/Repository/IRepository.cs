using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL.Interface.DTO;


namespace DAL.Interface.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int key);
        IQueryable<TEntity> GetByPredicate(Expression<Func<TEntity, bool>> f = null);
        void Create(TEntity e);
        void Delete(TEntity e);
        void Update(TEntity entity);
   
    }
}
