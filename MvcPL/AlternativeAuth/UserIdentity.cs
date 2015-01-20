using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace MvcPL.AlternativeAuth
{
    public class UserIdentity : ClaimsIdentity
    {
        public override string AuthenticationType { get { return "ProjectManhattan"; } }

        public int UserId { get; private set; }

        private readonly string _name;

        public override string Name{ get{return _name;} }

        public override bool IsAuthenticated{ get{return true;} }

        public UserIdentity(int userId, string name)
        {
            UserId = userId;
            _name = name;
        }
    }
}