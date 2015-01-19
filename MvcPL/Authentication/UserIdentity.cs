using System;
using System.Security.Principal;
using System.Web.Providers.Entities;

namespace MvcPL.Authentication
{
    public class UserIdentity : IUserProvider, IIdentity
    {

        public User User{ get; set; }

        public string AuthenticationType
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsAuthenticated
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    }
}