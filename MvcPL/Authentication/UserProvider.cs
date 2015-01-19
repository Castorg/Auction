using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace MvcPL.Authentication
{
    public class UserProvider : IPrincipal
    {
        private IIdentity userIdentity { get; set; }
        public IIdentity Identity
        {
            get { return userIdentity; }
        }

        
        public bool IsInRole(string role)
        {
            /*if (userIdentity.User == null)
            {
                return false;
            }
            return userIdentity.User.InRoles(role);*/
            throw new NotImplementedException();
        }
        public UserProvider(string name, IUserRepository repository)
        {
            /*
            userIdentity = new UserIndentity();
            userIdentity.Init(name, repository);*/
        }
    }
}