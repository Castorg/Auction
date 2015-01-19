using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;

namespace MvcPL.Authentication
{
    public interface IUserProvider
    {
        User User { get; set; }
    }
}