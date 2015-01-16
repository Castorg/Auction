using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.Repository;

namespace BLL.Interface.Services
{
    public interface IService
    {
        IUnitOfWork UnitOfWork { get; }
    }

    public interface IService<T> : IService where T : class
    {
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
