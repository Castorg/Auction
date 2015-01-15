﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class DalLot : IEntity
    {
        public int Id{get; set; }
        public int CurrentCost { get; set; }
        public string Description { get; set; }

        public int StoreId { get; set; }

    }
}
