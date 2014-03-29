using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using System.Text;

namespace SNHTickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string quoteParas(Dictionary<string, string> paras)
        {
            string quotedParas = "";
            bool isFirst = true;
            string val = "";
            foreach (string para in paras.Keys)
            {
                if (paras.TryGetValue(para, out val))
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        quotedParas += para + "=" + HttpUtility.UrlPathEncode(val);
                    }
                    else
                    {
                        quotedParas += "&" + para + "=" + HttpUtility.UrlPathEncode(val);
                    }
                }
                else
                {
                    break;
                }
            }

            return quotedParas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> postDict = new Dictionary<string, string>();
            postDict.Add("username", snh_username.Text);
            postDict.Add("password", snh_pw.Text);
            postDict.Add("act", "act_login");
            postDict.Add("back_act", "http://shop.snh48.com/index.php&submit=");

            String snh_shop_url = "http://shop.snh48.com/user.php";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(snh_shop_url);

            CookieContainer cookieCon = new CookieContainer();
            req.CookieContainer = cookieCon;

            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            string postDataStr = quoteParas(postDict);
            ASCIIEncoding encoding = new ASCIIEncoding ();
            byte[] postBytes = encoding.GetBytes(postDataStr);
            req.ContentLength = postBytes.Length;

            Stream postDataStream = req.GetRequestStream();
            postDataStream.Write(postBytes, 0, postBytes.Length);
            postDataStream.Close();

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string loginSNHRespHtml = sr.ReadToEnd();

            //check whether got all expected cookies
            Dictionary<string, bool> cookieCheckDict = new Dictionary<string, bool>();
            string[] cookiesNameList = { "ECS[username]", "ECS[user_id]", "ECS[password]" };
            foreach (String cookieToCheck in cookiesNameList)
            {
                cookieCheckDict.Add(cookieToCheck, false);
            }

            foreach (Cookie singleCookie in resp.Cookies)
            {
                if (cookieCheckDict.ContainsKey(singleCookie.Name))
                {
                    cookieCheckDict[singleCookie.Name] = true;
                }
            }

            bool allCookiesFound = true;
            foreach (bool foundCurCookie in cookieCheckDict.Values)
            {
                allCookiesFound = allCookiesFound && foundCurCookie;
            }


            Boolean loginOK = allCookiesFound;
            if (loginOK)
            {
                MessageBox.Show("成功登陆！");
            }
            else
            {
                MessageBox.Show("我日");
            }
        }
    }
}
