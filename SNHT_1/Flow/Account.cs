using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using SNHT_1.Util;

namespace SNHT_1.Flow
{
    public class Account
    {
        public String username { get; set; }
        public String password { get; set; }
        //丝瓜等级
        public String level { get; set; }
        //实名认证
        public String realname { get; set; }
        //手机号
        public String tel { get; set; }
        //重要程度，也即大号还是小号
        public Int32 importance { get; set; }
        public CookieContainer cookieCon { get; set; }

        public Boolean Login()
        {
            LoginManager loginManager = new LoginManager();

            //登录失败则重试10次，登录成功则取回cookies
            for (Byte i = 1; i < 10; i++)
            {
                if (loginManager.Login(username, password))
                {
                    cookieCon = loginManager.cookieCon;
                    break;
                }
                else
                {
                    //每次登录失败都延迟一段时间
                    delay(100 * i);
                    continue;
                }
            }
            //cookies不为空则说明登录成功，否则说明登录10次失败
            if (cookieCon != null)
            {
                return true;
            }
            else
                return false;
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

        public List<String> getOrderList()
        {
            SNHWebInteraction wi = new SNHWebInteraction(cookieCon);
            return wi.getOrderList();
        }

        public Array getOrderInfo(String orderNo, CookieContainer cookieCon = null)
        {
            if (cookieCon == null)
            {
                cookieCon = this.cookieCon;
            }
            SNHWebInteraction wi = new SNHWebInteraction(cookieCon);
            return wi.getOrderInfo(orderNo);
        }

        public void ChangeOrderInfo(String orderName, String orderTel, String orderAddr, String orderID, CookieContainer cookieCon = null)
        {
            if (cookieCon == null)
            {
                cookieCon = this.cookieCon;
            }
            SNHWebInteraction wi = new SNHWebInteraction(cookieCon);
            wi.ChangeOrderInfo(orderName, orderTel, orderAddr, orderID);
        }

        private void delay(Int32 millisecends)
        {
            DateTime tempTime = DateTime.Now;
            while (tempTime.AddMilliseconds(millisecends).CompareTo(DateTime.Now) > 0)
            {
                Application.DoEvents();
            }
        }
    }
}
