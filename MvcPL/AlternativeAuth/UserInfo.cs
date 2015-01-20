using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace MvcPL.AlternativeAuth
{
    [Serializable]
    public class UserInfo
    {
        public UserInfo(int  userId, string userRole, string name)
        {
            Name = name;
            UserRole = userRole;
            UserId = userId;
        }

        public UserInfo()
        {
        }

        public string Name { get; private set; }

        public int  UserId { get; private set; }

        public string UserRole { get; private set; }

        public override string ToString()
        {
            return new XElement("UserInfo", new XAttribute("Name", Name), new XAttribute("Id", UserId),
                                new XAttribute("Role", UserRole)).ToString();
        }

        public static UserInfo FromString(string str)
        {
            try
            {
                var element = XElement.Parse(str);
                return new UserInfo(int.Parse(element.Attribute("Id").Value), element.Attribute("Role").Value,
                                    element.Attribute("Name").Value);
            }
            catch (XmlException)
            {
                return null;
            }
        }
    }
}