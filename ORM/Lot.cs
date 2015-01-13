using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    [Table("Lot")]
    public class Lot
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int CountReview { get; set; }

        public int CountCost { get; set; }


    }
}
