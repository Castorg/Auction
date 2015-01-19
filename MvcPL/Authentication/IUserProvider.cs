using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Providers.Entities;

namespace MvcPL.Authentication
{
    public interface IUserProvider
    {
        User User { get; set; }
    }

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