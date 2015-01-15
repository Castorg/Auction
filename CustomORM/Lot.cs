using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomORM
{
    public class Lot
    {
        public int LotId { get; set; }
        public int CurrentCost { get; set; }
        public string Description { get; set; }


        public virtual Store Store { get; set; } 
    }
}
