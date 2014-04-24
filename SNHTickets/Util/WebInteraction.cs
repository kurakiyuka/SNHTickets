using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SNHTickets.Util
{
    class WebInteraction
    {
        //商品URL前缀，加上id就是商品完整的URL
        String snh_goods_url_prefix = "http://shop.snh48.com/goods.php?id=";
        //编码器
        ASCIIEncoding encoding;
        //cookies容器
        public CookieContainer cookieCon { get; set; }
        //最终返回值
        String resultString;

        public WebInteraction()
        {
            encoding = new ASCIIEncoding();
        }

        public String postData(String url, String data, CookieContainer cookieCon = null)
        {
            this.cookieCon = cookieCon;
            //计算数据长度
            byte[] postBytes = encoding.GetBytes(data);

            //创建HttpWebRequest对象，设置Header
            HttpWebRequest hwq = (HttpWebRequest)WebRequest.Create(url);
            HWRMaker.makeHeader(hwq, cookieCon, postBytes.Length);

            //POST数据
            try
            {
                Stream stream = hwq.GetRequestStream();
                stream.Write(postBytes, 0, postBytes.Length);
                stream.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //读取返回数据
            HttpWebResponse hwr;
            try
            {
                hwr = (HttpWebResponse)hwq.GetResponse();
                StreamReader sr = new StreamReader(hwr.GetResponseStream());
                resultString = sr.ReadToEnd();
            }
            catch (WebException ex)
            {
                hwr = (HttpWebResponse)ex.Response;
            }

            return resultString;
        }

        public delegate void GetTitleEventHandler(Object sender, GetTitleEventArgs e);
        public event GetTitleEventHandler GetTitleFinEvent;
        public class GetTitleEventArgs : EventArgs
        {
            public readonly String title;
            public GetTitleEventArgs(String title)
            {
                this.title = title;
            }
        }
        protected virtual void DispatchGetTitleEvent(GetTitleEventArgs e)
        {
            if (GetTitleFinEvent != null)
            {
                GetTitleFinEvent(this, e);
            }
        }

        //根据商品id来获取商品的名字
        public void GetTitle(String id)
        {
            String url = snh_goods_url_prefix + id;
            WebBrowser web = new WebBrowser();
            web.Navigate(url);
            //异步获取网页内容
            web.DocumentCompleted += web_DocumentCompleted;
        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser web = (WebBrowser)sender;
            HtmlElementCollection ElementCollection = web.Document.GetElementsByTagName("title");
            String title;
            //网页title包含多个_字符，如果没有_字符，说明商品有误
            if (ElementCollection[0].InnerText.IndexOf("_") > 0)
            {
                title = ElementCollection[0].InnerText.Substring(0, ElementCollection[0].InnerText.IndexOf("_"));
            }
            else
            {
                title = "商品有误";
            }
            GetTitleEventArgs ev = new GetTitleEventArgs(title);
            DispatchGetTitleEvent(ev);
        }
    }
}
