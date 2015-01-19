using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPL.Models
{

    public class RegisterViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Введите логин")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        /*[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный email")]*/
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = "Некорректный логин(только символы)")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(100, ErrorMessage = "Пароль должен содержать по крайней мере {2} символов.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Введите пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароли должны совпадать.")]
        public string ConfirmPassword { get; set; }

        /*
        [Required]
        public string Captcha { get; set; }

        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }

        public string AvatarPath { get; set; }*/
    }
}
