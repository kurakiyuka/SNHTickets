using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace SNHTickets.Util
{
    class WebInteractionn
    {
        //官店地址
        String snh_shop_url = "http://shop.snh48.com/";       
        //商品URL前缀，加上id就是商品完整的URL
        String snh_goods_url_prefix = "http://shop.snh48.com/goods.php?id=";
        //订单列表RUL
        String snh_order_list_url = "http://shop.snh48.com/user.php?act=order_list";
        //更新订单
        String snh_order_update = "http://shop.snh48.com/user.php";
        //编码器
        ASCIIEncoding encoding;
        //cookies容器
        public CookieContainer cookieCon { get; set; }
        //最终返回值
        String resultString;

        public WebInteractionn(CookieContainer cookieCon = null)
        {
            this.cookieCon = cookieCon;
            encoding = new ASCIIEncoding();
        }

        public String postData(String url, String data)
        {
            //计算数据长度
            byte[] postBytes = encoding.GetBytes(data);

            //创建HttpWebRequest对象，设置Header
            HttpWebRequest hwq = (HttpWebRequest)WebRequest.Create(url);
            HWRMaker.makePostHeader(hwq, cookieCon, postBytes.Length);

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
        public void getTitle(String id)
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

        public Array getOrderInfo(String orderNo)
        {
            HttpWebRequest hwReq = (HttpWebRequest)WebRequest.Create(snh_order_list_url);
            HWRMaker.makeGetHeader(hwReq, cookieCon);
            HttpWebResponse hwResp = (HttpWebResponse)hwReq.GetResponse();
            StreamReader sr = new StreamReader(hwResp.GetResponseStream());
            String resultHTML = sr.ReadToEnd();
            Int32 position = resultHTML.IndexOf(orderNo);
            String tempString = resultHTML.Substring(position - 60, 60);
            String orderURL = snh_shop_url + tempString.Substring(tempString.IndexOf("u"), tempString.LastIndexOf("c") - tempString.IndexOf("u") - 2);
            String orderID = orderURL.Substring(orderURL.IndexOf("id=") + 3);
            hwReq = (HttpWebRequest)WebRequest.Create(orderURL);
            HWRMaker.makeGetHeader(hwReq, cookieCon);
            hwResp = (HttpWebResponse)hwReq.GetResponse();
            sr = new StreamReader(hwResp.GetResponseStream());
            resultHTML = sr.ReadToEnd();
            tempString = resultHTML.Substring(resultHTML.IndexOf("name=\"consignee\""));
            tempString = tempString.Substring(0, 70);
            int i = tempString.LastIndexOf("ue=");
            int j = tempString.LastIndexOf("si");
            String orderName = tempString.Substring(tempString.LastIndexOf("ue=") + 4, tempString.LastIndexOf("si") - tempString.LastIndexOf("ue=") - 6);
            tempString = resultHTML.Substring(resultHTML.IndexOf("name=\"tel\""));
            tempString = tempString.Substring(0, 60);
            String orderTel = tempString.Substring(tempString.LastIndexOf("e=") + 3, 11);
            return new String[] { orderName, orderTel, orderID };
        }

        public void ChangeOrderInfo(String orderName, String orderTel, String orderID)
        {
            HttpWebRequest hwReq = (HttpWebRequest)WebRequest.Create(snh_order_update);
            String strPostData = "address=1&consignee=" + HttpUtility.UrlPathEncode(orderName) + "&email=1907361882%40qq.com&tel=" + orderTel + "&act=save_order_address&order_id=" + orderID;
            byte[] postBytes = encoding.GetBytes(strPostData);
            HWRMaker.makePostHeader(hwReq, cookieCon, postBytes.Length);
            Stream stream_login = hwReq.GetRequestStream();
            stream_login.Write(postBytes, 0, postBytes.Length);
            stream_login.Close();
            HttpWebResponse hwResp = (HttpWebResponse)hwReq.GetResponse();
            StreamReader sr = new StreamReader(hwResp.GetResponseStream());
            String resultHTML = sr.ReadToEnd();
        }
    }
}
