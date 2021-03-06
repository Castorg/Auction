﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomORM;
using DAL.Interface.Repository;

namespace DAL.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public EntityContext Context { get; private set; }

        public UnitOfWork(EntityContext context)
        {
            Context = context;
            Debug.WriteLine("unit of work create!");
        }
        public void Commit()
        {
            if (Context != null)
            {
                Context.SaveChanges();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            Debug.WriteLine("Context dispose!");
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}
