﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }

        public RoleEntity Role { get; set; }

        public string Password { get; set; }

        public DateTime Time{ get; set; }
    }
}
