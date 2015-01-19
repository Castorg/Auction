using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using BLL.Interface.Services;
using CustomORM;
using DAL.Interface.Repository;

namespace MvcPL.Authentication
{
    public class UserIndentity : IIdentity
    {
        public User User { get; set; }

        public string AuthenticationType{get{return typeof(User).ToString();}}

        public bool IsAuthenticated
        {
            get
            {
                return User != null;
            }
        }

        public string Name
        {
            get
            {
                if (User != null)
                {
                    return User.Name;
                }
                //иначе аноним
                return "anonym";
            }
        }

        public void Init(string name, IUserService repository)
        {
            if (!string.IsNullOrEmpty(name))
            {
                User = repository.GetByName(name);
            }
        }
    }
  
}