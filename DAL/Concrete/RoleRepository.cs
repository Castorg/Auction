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
    public class RoleRepository : IRoleRepository
    {
                private readonly DbContext _dbContext;
        internal DbSet<Role> DbSet;

        public RoleRepository(IUnitOfWork uow)
        {
            if (uow == null) throw new ArgumentException("UnitOfWork");
            this._dbContext = uow.Context;
            this.DbSet = _dbContext.Set<Role>();
        }


        public IEnumerable<Role> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public Role GetById(int key)
        {
            return DbSet.Find(key);
        }

        public IQueryable<Role> GetByPredicate(System.Linq.Expressions.Expression<Func<Role, bool>> f = null)
        {
            return f == null ? DbSet : DbSet.Where(f);
        }

        public void Create(Role e)
        {
            DbSet.Add(e);
        }

        public void Delete(Role e)
        {
            DbSet.Remove(e);
        }

        public void Update(Role entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
