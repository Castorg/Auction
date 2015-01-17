﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using BLL.Interface.Services;
using BLL.Mappers;
using CustomORM;
using DAL.Interface.Repository;

namespace BLL.Services
{
    public class StoreService : IStoreService
    {
        public IUnitOfWork UnitOfWork{ get; private set; }

        public IRepository<Store> Repository { get; private set; }


        public StoreService(IRepository<Store> repository, IUnitOfWork ouw)
        {
            UnitOfWork = ouw;
            Repository = repository;
        }

        public List<StoreEntity> GetAll()
        {
            var list = new List<StoreEntity>();
            foreach (var e in Repository.GetByPredicate())
            {
                list.Add(e.ToStoreEntity());
            }
            return list;
        }

        public void Insert(StoreEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(StoreEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(StoreEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
