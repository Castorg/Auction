using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomORM
{
    public class Store
    {
        public int StoreId { get; set; }

        public string Name { get; set; }

        public string Addres { get; set; }

        public virtual List<Lot> Lots { get; set; } 
    }
}
