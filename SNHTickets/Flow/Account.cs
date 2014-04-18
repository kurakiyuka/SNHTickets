using System;
using System.Net;

namespace SNHTickets.Flow
{
    public class Account
    {
        public String username { get; set; }
        public String password { get; set; }
        public String level { get; set; }
        public Int32 importance { get; set; }
        public CookieContainer cookieCon { get; set; }

        //一个帐号包含用户名，密码，丝瓜等级，重要程度，也即大号还是小号
        public Account(String username, String password, String level, Int32 importance)
        {
            this.username = username;
            this.password = password;
            this.level = level;
            this.importance = importance;
        }

        public Boolean Login()
        {
            LoginManager loginManager = new LoginManager();

            //登录成功则取回cookies
            if (loginManager.Login(username, password))
            {
                cookieCon = loginManager.cookieCon;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Int32 Buy(String id, Int32 amount, String type, CookieContainer cookieCon)
        {
            BuyManager buyManager = new BuyManager();
            return buyManager.Buy(id, amount, type, cookieCon);       
        }
    }
}
