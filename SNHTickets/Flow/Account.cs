using System;
using System.Net;
using SNHTickets.Util;

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

        public Int32 Buy(String id, Int32 amount, String type, CookieContainer cookieCon = null)
        {
            if (cookieCon == null)
            {
                cookieCon = this.cookieCon;
            }
            BuyManager buyManager = new BuyManager(cookieCon);
            return buyManager.Buy(id, amount, type);
        }

        public Array getOrderInfo(String orderNo, CookieContainer cookieCon = null)
        {
            if (cookieCon == null)
            {
                cookieCon = this.cookieCon;
            }
            WebInteractionn wi = new WebInteractionn(cookieCon);
            return wi.getOrderInfo(orderNo);
        }

        public void ChangeOrderInfo(String orderName, String orderTel, String orderID, CookieContainer cookieCon = null)
        {
            if (cookieCon == null)
            {
                cookieCon = this.cookieCon;
            }
            WebInteractionn wi = new WebInteractionn(cookieCon);
            wi.ChangeOrderInfo(orderName, orderTel, orderID);
        }
    }
}
