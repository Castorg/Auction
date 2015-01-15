using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Repository;

namespace DAL.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : IEntity 
    {

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int key)
        {
            throw new NotImplementedException();
        }

        public T GetByPredicate(System.Linq.Expressions.Expression<Func<T, bool>> f)
        {
            throw new NotImplementedException();
        }

        public void Create(T e)
        {
            throw new NotImplementedException();
        }

        public void Delete(T e)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
