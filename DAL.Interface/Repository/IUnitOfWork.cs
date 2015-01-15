using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomORM;

namespace DAL.Interface.Repository
{
     public interface IUnitOfWork
    {
        EntityContext Context { get; }
        void Commit();
        
         //bool RollBack();
    }
}
