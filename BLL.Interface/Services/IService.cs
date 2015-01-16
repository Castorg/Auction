using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.Repository;

namespace BLL.Interface.Services
{

    public interface IService<T> where T : class
    {

        IUnitOfWork UnitOfWork { get; }
        IRepository<T> Repository { get; }

        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
