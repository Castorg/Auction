using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using CustomORM;
using DAL.Interface.ConcreteInterfaceRepository;
using DAL.Interface.Repository;

namespace MvcPL.Authentication
{
    public class CustomAuthentication : IAuthentication
    {

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public HttpContext HttpContext { get; set; }

        public IRepository<User> UserRepository;
        public IUserRepository Repository;


        private const string cookieName = "__AUTH_COOKIE";
        private IPrincipal _currentUser;


        public CustomAuthentication(IRepository<User> user)
        {
            UserRepository = user;
        }

        public User Login(string userName, string password, bool isPersistent)
        {
            User retUser = Repository.Login(userName, password);
            if (retUser != null)
            {
                CreateCookie(userName, isPersistent);
            }
            return retUser;
        }

        private void CreateCookie(string userName, bool isPersistent = false)
        {
            var ticket = new FormsAuthenticationTicket(
                1,
                userName,
                DateTime.Now,
                DateTime.Now.Add(FormsAuthentication.Timeout),
                isPersistent,
                string.Empty,
                FormsAuthentication.FormsCookiePath);

            // Encrypt the ticket.
            var encTicket = FormsAuthentication.Encrypt(ticket);

            // Create the cookie.
            var AuthCookie = new HttpCookie(cookieName)
            {
                Value = encTicket,
                Expires = DateTime.Now.Add(FormsAuthentication.Timeout)
            };
            HttpContext.Response.Cookies.Set(AuthCookie);
        }

        public User Login(string userName)
        {
           /* User retUser = Repository.Users.FirstOrDefault(p => string.Compare(p.Email, userName, true) == 0);
            if (retUser != null)
            {
                CreateCookie(userName);
            }
            return retUser;*/
            throw new NotImplementedException();
        }

        public void LogOut()
        {
            var httpCookie = HttpContext.Response.Cookies[cookieName];
            if (httpCookie != null)
            {
                httpCookie.Value = string.Empty;
            }
        }

        public IPrincipal CurrentUser
        {
            get
            {/*
                if (_currentUser == null)
                {
                    try
                    {
                        HttpCookie authCookie = HttpContext.Request.Cookies.Get(cookieName);
                        if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                        {
                            var ticket = FormsAuthentication.Decrypt(authCookie.Value);
                            _currentUser = new UserProvider(ticket.Name, Repository);
                        }
                        else
                        {
                            _currentUser = new UserProvider(null, null);
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Error("Failed authentication: " + ex.Message);
                        _currentUser = new UserProvider(null, null);
                    }
                }
                return _currentUser;*/
            throw new NotImplementedException();
            }
        }
    }
}