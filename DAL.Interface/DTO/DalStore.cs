﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class DalStore : IEntity
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public string Addres { get; set; }
    }
}
