using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace BLL.Interface.Services
{
    public interface IStoreService
    {
        IUnitOfWork UnitOfWork { get; }
        IStoreRepository Repository { get; }

        List<StoreEntity> GetAll();
        void Insert(StoreEntity entity);
        void Update(StoreEntity entity);
        void Delete(StoreEntity entity);

        StoreEntity GetById(int id);
    }
}
