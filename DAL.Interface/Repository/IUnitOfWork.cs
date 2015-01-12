﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Repository
{
    interface IUnitOfWork
    {
        DbContext Context { get; }
        void Commit();
    }
}
