using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Uranus.Domain.Entities;

namespace Uranus.Models
{
    public class UserSession
    {
        private const string SessionName = "Uranus.Session";

        public UserSession(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }
        public int UserId { get; set; }
        public string UserName { get; set; }

        public static void SetSession(UserSession session)
        {
            HttpContext.Current.Session[SessionName] = session;
        }

        public static UserSession GetSession()
        {
            if (HttpContext.Current.Session[SessionName] != null)
            {
                return (UserSession)HttpContext.Current.Session[SessionName];
            }
            else
            {
                return null;
            }
        }

    }
}