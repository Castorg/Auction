using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class LotService : ILotService
    {
        public IUnitOfWork UnitOfWork { get; private set; }
        public IRepository<Lot> Repository { get; private set; }

        public LotService(IRepository<Lot> repository , IUnitOfWork ouw)
        {
            UnitOfWork = ouw;
            Repository = repository;
        }
        
        public List<LotEntity> GetAll()
        {
            var list = new List<LotEntity>();
            foreach (var e in Repository.GetByPredicate())
            {
                list.Add(e.ToLotEntity());
            }
            return list;
        }

        public void Insert(LotEntity entity)
        {
            Repository.Create(entity.ToLot());           
        }

        public void Update(LotEntity entity)
        {
            Repository.Update(entity.ToLot());
        }

        public void Delete(LotEntity entity)
        {
            Repository.Delete(entity.ToLot());
        }
    }
}
