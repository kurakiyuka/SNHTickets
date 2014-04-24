using System;
using System.Net;

namespace SNHTickets.Flow
{
    public class Account
    {
        public String username { get; set; }
        public String password { get; set; }
        //丝瓜等级
        public String level { get; set; }
        //重要程度，也即大号还是小号
        public Int32 importance { get; set; }
        public CookieContainer cookieCon { get; set; }

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
