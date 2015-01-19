using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class LotService : ILotService
    {
        public IUnitOfWork UnitOfWork { get; private set; }
        public ILotRepository Repository { get; private set; }

        public LotService(ILotRepository repository, IUnitOfWork ouw)
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

        public LotEntity GetById(int id)
        {
            return Repository.GetById(id).ToLotEntity();
        }

        public List<LotEntity> GetLotEntityBySubMask(string mask)
        {
            if(mask == null) throw new ArgumentNullException();
            var temp = new List<LotEntity>();
            foreach (LotEntity lotEntity in GetAll())
            {
                if (lotEntity.Description.Contains(mask))
                {
                    temp.Add(lotEntity);
                }
            }
            return temp;
        }
    }
}
