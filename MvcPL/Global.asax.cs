using System;
using System.Net.Http;
using System.Security.Principal;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using MvcPL.AlternativeAuth;
using MvcPL.Infrastructura;

namespace MvcPL
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            System.Web.Mvc.DependencyResolver.SetResolver(new NinjectDependencyResolver());

        }

        protected void Application_PostAuthenticateRequest(object source, EventArgs e)
        {
            var user = HttpContext.Current.Request.Cookies["user"];
            if (user == null)
            {
                //var a = base.PostAuthenticateRequest;
            }
            else
            {
                var ticket = FormsAuthentication.Decrypt(user.Value);
                if(ticket != null)
                {
                    var ui = UserInfo.FromString(ticket.UserData);
                    if (ui != null)
                    {
                        var identity = new UserIdentity(ui.UserId, ui.Name);
                        HttpContext.Current.User = new GenericPrincipal(identity, new[] { ui.UserRole });
                    }
                }
            }
        }
    }
}