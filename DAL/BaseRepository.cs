using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Repository;

namespace DAL
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int key)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByPredicate(System.Linq.Expressions.Expression<Func<TEntity, bool>> f)
        {
            throw new NotImplementedException();
        }

        public void Create(TEntity e)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity e)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
