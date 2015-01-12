﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DAL.Interface.DTO;


namespace DAL.Interface.Repository
{
    interface IRepository
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int key);
        TEntity GetByPredicate(Expression<Func<TEntity, bool>> f);
        void Create(TEntity e);
        void Delete(TEntity e);
        void Update(TEntity entity);
   
    }
}
