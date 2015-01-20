using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPL.Models
{
    public class LotModel
    {
        [Display(Name = "Введите цену")]
        [RegularExpression(@"[0-9.]+@[0-9]", ErrorMessage = "Некорректная цена(только числа и точка)")]
        public int CurencCost { get; set; }

        [RegularExpression(@"[A-Za-z0-9.]{1,100}", ErrorMessage = "Некорректные символы (удалите)")]
        public string Description { get; set; }


        public string Address { get; set; }
    }
}