using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class LotEntity
    {
        public int Id { get; set; }
        public int CurrentCost { get; set; }
        public string Description { get; set; }

        public int StoreId { get; set; }
    }
}
