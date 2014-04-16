using System;
using System.Net;

namespace SNHTickets.Flow
{
    class Account
    {
        public String username { get; set; }
        public String password { get; set; }
        public String level { get; set; }
        public Int32 importance { get; set; }
        public CookieContainer cookieCon { get; set; }

        public void Login()
        {
            LoginManager loginManager = new LoginManager();
            if (loginManager.Login(username, password))
            {
                cookieCon = loginManager.cookieCon;
            }
        }

        public void Buy()
        {

        }
    }
}
