using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;
using JetBrains.Annotations;

namespace MvcPL.Authentication
{
    public class UserProvider : IPrincipal
    {
        public UserProvider( IIdentity identity, string[] roles)
        {

        }

        private IIdentity UserIdentity { get; set; }
        public IIdentity Identity
        {
            get { return UserIdentity; }
        }

        
        public bool IsInRole(string role)
        {
            if (Identity.User == null)
            {
                return false;
            }
            return Identity.User.InRoles(role);
            throw new NotImplementedException();
        }
        public UserProvider(string name, IUserRepository repository)
        {

            UserIdentity = new UserIndentity();
            UserIdentity.Init(name, repository);
        }
        public bool InRoles(string roles)
        {
            if (string.IsNullOrWhiteSpace(roles))
            {
                return false;
            }

            var rolesArray = roles.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var role in rolesArray)
            {
                var hasRole = UserRoles.Any(p => string.Compare(p.Role.Code, role, true) == 0);
                if (hasRole)
                {
                    return true;
                }
            }
            return false;
        }

    }
}