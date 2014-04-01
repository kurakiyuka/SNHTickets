using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SNHTickets.Flow;
using SNHTickets.Util;
using SNHTickets.Events;

namespace SNHTickets
{
    public partial class SNHTickets : Form
    {
        //登录使用的URL
        String snh_login_url = "http://shop.snh48.com/user.php";
        //登录时需要提交的返回URL
        String snh_login_back_act_url = "http://shop.snh48.com/index.php&submit=";
        //整个购物流程的URL，用的可能是单页模式
        //String snh_flow_url = "http://shop.snh48.com/flow.php";
        //更新购物车功能没有step=xxx，直接向flow.php提交数据
        //String snh_update_cart_url = "http://shop.snh48.com/flow.php";

        //用于提交的数据字典
        Dictionary<String, String> dirPostData;
        //用于提交的数据字符串
        String strPostData;
        //cookie容器
        CookieContainer cookies;
        //编码器
        ASCIIEncoding encoding;

        Order order;

        public SNHTickets()
        {
            InitializeComponent();            
        }

        private void SNHTickets_Load(object sender, EventArgs e)
        {
            dirPostData = new Dictionary<String, String>();
            cookies = new CookieContainer();
            encoding = new ASCIIEncoding();
            order = new Order();
            order.OrderResultEvent += LogToRight2;
        }

        private void MakeHttpWebRequsetHeader(HttpWebRequest req)
        {
            req.CookieContainer = cookies;
            req.Method = "POST";
            req.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0;)";
            req.ContentType = "application/x-www-form-urlencoded";
        }

        private void login(object sender, EventArgs e)
        {
            
           
            dirPostData.Clear();
            //构建登录要使用的POST数据
            dirPostData.Add("username", snh_username.Text);
            dirPostData.Add("password", snh_pw.Text);
            dirPostData.Add("act", "act_login");
            dirPostData.Add("back_act", snh_login_back_act_url);

            //创建HttpWebRequest对象，设置Header
            HttpWebRequest req_login = (HttpWebRequest)WebRequest.Create(snh_login_url);
            MakeHttpWebRequsetHeader(req_login);

            //把Dictionary转化形如username=xxx&password=xxx的形式
            strPostData = QuoteParaser.quoteParas(dirPostData);
            byte[] postBytes = encoding.GetBytes(strPostData);
            req_login.ContentLength = postBytes.Length;

            //POST数据
            try
            {
                Stream stream_login = req_login.GetRequestStream();
                stream_login.Write(postBytes, 0, postBytes.Length);
                stream_login.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

            Boolean loginOK = allCookiesFound;
            if (loginOK)
            {
                LogToRight("帐号：" + snh_username.Text + "登录成功");
            }
            else
            {
                LogToLeft("帐号：" + snh_username.Text + "登录失败");
            }
        }

        private void buy_loop(object sender, EventArgs e)
        {
            order.Commit(368, cookies);
        }

        private void LogToLeft(String str)
        {
            rtb_process.AppendText(DateTime.Now.ToString() + ' ' + str + '\n');
            rtb_process.ScrollToCaret();
        }
        private void LogToRight(String str)
        {
            rtb_success.AppendText(DateTime.Now.ToString() + ' ' + str + '\n');
            rtb_success.ScrollToCaret();
        }
        private void LogToRight2(Object sender, Order.OrderResultEventArgs e)
        {
            rtb_success.AppendText(DateTime.Now.ToString() + ' ' + e.resultStr + '\n');
            rtb_success.ScrollToCaret();
        }
    }
}
