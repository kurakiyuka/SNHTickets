using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using SNHTickets.Util;

namespace SNHTickets.Flow
{
    public class LoginManager
    {
        //登录使用的URL
        String snh_login_url = "http://shop.snh48.com/user.php";
        //登录时需要提交的返回URL
        String snh_login_back_act_url = "http://shop.snh48.com/index.php&submit=";

        //用于提交的数据字典
        Dictionary<String, String> dirPostData;
        //用于提交的数据字符串
        String strPostData;
        //cookie容器
        public CookieContainer cookieCon { get; set; }
        //编码器
        ASCIIEncoding encoding;
        //登录是否成功
        Boolean loginSuccess;

        public LoginManager()
        {
            dirPostData = new Dictionary<String, String>();
            cookieCon = new CookieContainer();
            encoding = new ASCIIEncoding();
        }

        public Boolean Login(String username, String password)
        {
            dirPostData.Clear();
            //构建登录要使用的POST数据
            dirPostData.Add("username", username);
            dirPostData.Add("password", password);
            dirPostData.Add("act", "act_login");
            dirPostData.Add("back_act", snh_login_back_act_url);

            //把Dictionary转化形如username=xxx&password=xxx的形式
            strPostData = QuoteParaser.quoteParas(dirPostData);
            //计算长度
            byte[] postBytes = encoding.GetBytes(strPostData);

            //创建HttpWebRequest对象，设置Header
            HttpWebRequest req_login = (HttpWebRequest)WebRequest.Create(snh_login_url);
            HWRMaker.makeHeader(req_login, cookieCon, postBytes.Length);

            //POST数据
            try
            {
                Stream stream_login = req_login.GetRequestStream();
                stream_login.Write(postBytes, 0, postBytes.Length);
                stream_login.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //读取返回数据
            HttpWebResponse resp_login;
            try
            {
                resp_login = (HttpWebResponse)req_login.GetResponse();
                StreamReader sr = new StreamReader(resp_login.GetResponseStream());
                String resultHTML = sr.ReadToEnd();
            }
            catch (WebException ex)
            {
                resp_login = (HttpWebResponse)ex.Response;
            }

            //检查返回的数据内是否包含相应的cookies，如果是，说明登录成功
            Dictionary<String, Boolean> cookieCheckDict = new Dictionary<String, Boolean>();
            String[] cookiesNameList = { "ECS[username]", "ECS[user_id]", "ECS[password]" };
            foreach (String cookieToCheck in cookiesNameList)
            {
                cookieCheckDict.Add(cookieToCheck, false);
            }

            foreach (Cookie singleCookie in resp_login.Cookies)
            {
                if (cookieCheckDict.ContainsKey(singleCookie.Name))
                {
                    cookieCheckDict[singleCookie.Name] = true;
                }
            }

            Boolean allCookiesFound = true;
            foreach (Boolean foundCurCookie in cookieCheckDict.Values)
            {
                allCookiesFound = allCookiesFound && foundCurCookie;
            }

            loginSuccess = allCookiesFound;
            return loginSuccess;
        }
    }
}
