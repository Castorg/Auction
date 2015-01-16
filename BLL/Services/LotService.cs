using System;
using System.Collections.Generic;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class LotService : ILotService
    {
        public IUnitOfWork UnitOfWork { get; private set; }

        public IRepository<LotEntity> Repository { get; private set; }

        public LotService(IRepository<LotEntity> repository , IUnitOfWork ouw)
        {
            UnitOfWork = ouw;
            Repository = repository;
        }

        public List<LotEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(LotEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LotEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LotEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
