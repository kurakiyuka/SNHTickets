using System;
using System.Net;
using System.IO;
using System.Text;
using SNHTickets.Util;

namespace SNHTickets.Flow
{
    public class OrderManager
    {
        //把商品加入购物车使用的URL
        static String snh_add_to_cart_url = "http://shop.snh48.com/flow.php?step=add_to_cart";
        //最后提交订单的URL
        static String snh_commit_url = "http://shop.snh48.com/flow.php?step=done";
        //整个购物流程的URL，用的可能是单页模式
        //String snh_flow_url = "http://shop.snh48.com/flow.php";
        //更新购物车功能没有step=xxx，直接向flow.php提交数据
        //String snh_update_cart_url = "http://shop.snh48.com/flow.php";

        public delegate void OrderResultEventHandler(Object sender, OrderResultEventArgs e);
        public event OrderResultEventHandler OrderResultEvent;

        public class OrderResultEventArgs : EventArgs
        {
            public readonly String resultStr;
            public OrderResultEventArgs(String resultStr)
            {
                this.resultStr = resultStr;
            }
        }

        protected virtual void OrderComplete(OrderResultEventArgs e)
        {
            if (OrderResultEvent != null)
            {
                OrderResultEvent(this, e);
            }
        }
        
        public void Commit(int goods_id, CookieContainer cookieCon)
        {
            for (int i = 0; i < 1; i++ )
            {               
                HttpWebRequest req_buy = (HttpWebRequest)WebRequest.Create(snh_add_to_cart_url);
                String postData = "goods={\"quick\":1,\"spec\":[],\"goods_id\":" + goods_id + ",\"number\":\"100\",\"parent\":0}";
                ASCIIEncoding encoder = new ASCIIEncoding();
                Byte[] postBytes = encoder.GetBytes(postData);

                HWRMaker.makeHeader(req_buy, cookieCon, postBytes.Length);

                Stream stream_buy = req_buy.GetRequestStream();
                stream_buy.Write(postBytes, 0, postBytes.Length);
                stream_buy.Close();

                HttpWebResponse resp_buy = (HttpWebResponse)req_buy.GetResponse();
                StreamReader sr = new StreamReader(resp_buy.GetResponseStream());
                String resultHTML = sr.ReadToEnd();

                req_buy = (HttpWebRequest)WebRequest.Create(snh_commit_url);
                postData = "shipping=5&payment=23&postscript=&how_oos=0&step=done&x=79&y=27";
                postBytes = encoder.GetBytes(postData);

                HWRMaker.makeHeader(req_buy, cookieCon, postBytes.Length);

                stream_buy = req_buy.GetRequestStream();
                stream_buy.Write(postBytes, 0, postBytes.Length);
                stream_buy.Close();

                resp_buy = (HttpWebResponse)req_buy.GetResponse();
                sr = new StreamReader(resp_buy.GetResponseStream());
                resultHTML = sr.ReadToEnd();
               
                OrderResultEventArgs e = new OrderResultEventArgs(goods_id.ToString());
                OrderComplete(e);
                goods_id++;
            }
        }
    }
}
