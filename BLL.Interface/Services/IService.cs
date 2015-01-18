using System.Collections.Generic;
using DAL.Interface.Repository;

namespace BLL.Interface.Services
{
    public interface IService<TSrc, TDst>
        where TSrc : class 
        where TDst : class
    {
        IUnitOfWork UnitOfWork { get; }
        IRepository<TSrc> Repository { get; }

        List<TDst> GetAll();
        void Insert(TDst entity);
        void Update(TDst entity);
        void Delete(TDst entity);

        TDst GetById(int id);
    }
}
