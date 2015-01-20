using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomORM;

namespace MvcPL.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string RoleDesc { get; set; }

        public string Password { get; set; }

        public DateTime Time { get; set; }

        public virtual Role Role { get; set; }
    }
}