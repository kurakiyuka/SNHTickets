using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using SNHTickets.Util.WebInteraction;

namespace SNHTickets.Util
{
    class SNHWebInteraction
    {
        //官店地址
        String snh_shop_url = "http://shop.snh48.com/";              
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

        public SNHWebInteraction(CookieContainer cookieCon = null)
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

        public List<String> getOrderList(Byte pageNum = 1)
        {
            //如果是第1页，URL后面可以不加“&page=x”的参数
            if (pageNum != 1)
            {
                snh_order_list_url = snh_order_list_url + "&page=" + pageNum.ToString();
            }

            //获取页面完整的HTML内容
            GetUrlHtml getUrl = new GetUrlHtml(cookieCon);
            String resultHTML = getUrl.getUrlHtml(snh_order_list_url);

            //一页最多10个订单，使用一个长度为10的数组可以保证够用，只需要下单没付款的订单
            List<String> orderList = new List<String>();
            Int32 position = resultHTML.IndexOf("未确认,未付款,未发货");
            while (position > 0)
            {
                resultHTML = resultHTML.Substring(position - 230);
                String orderNum = resultHTML.Substring(resultHTML.IndexOf("f6") + 4, 13);
                orderList.Add(orderNum);
                resultHTML = resultHTML.Substring(resultHTML.IndexOf("未确认,未付款,未发货") + 50);
                position = resultHTML.IndexOf("未确认,未付款,未发货");
            }
                
            return orderList;
        }

        public Array getOrderInfo(String orderNo)
        {
            GetUrlHtml getUrl = new GetUrlHtml(cookieCon);
            String resultHTML = getUrl.getUrlHtml(snh_order_list_url);
            Int32 position = resultHTML.IndexOf(orderNo);
            String tempString = resultHTML.Substring(position - 60, 60);
            String orderURL = snh_shop_url + tempString.Substring(tempString.IndexOf("u"), tempString.LastIndexOf("c") - tempString.IndexOf("u") - 2);
            String orderID = orderURL.Substring(orderURL.IndexOf("id=") + 3);
            resultHTML = getUrl.getUrlHtml(orderURL);
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
