using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using SNHTickets.Util;

namespace SNHTickets.Flow
{
    class BuyManager
    {
        //把商品加入购物车使用的URL
        String snh_add_to_cart_url = "http://shop.snh48.com/flow.php?step=add_to_cart";
        //最后提交订单的URL
        String snh_commit_url = "http://shop.snh48.com/flow.php?step=done";

        Int32 errorCode;
        String resultHTML = null;

        /*
         * id：商品id
         * amount：一次性购买的商品数量
         * type：区分是实物商品还是门票，这影响到后面提交订单时，shipping参数的值，-1表示门票，5表示实物
         * cookieCon：登录成功返回的cookie
         */
        public Int32 Buy(String id, Int32 amount, String type, CookieContainer cookieCon)
        {
            //加入购物车
            HttpWebRequest req_buy = (HttpWebRequest)WebRequest.Create(snh_add_to_cart_url);
            String postData = "goods={\"quick\":1,\"spec\":[],\"goods_id\":" + id + ",\"number\":\"" + amount.ToString() + "\",\"parent\":0}";
            ASCIIEncoding encoder = new ASCIIEncoding();
            Byte[] postBytes = encoder.GetBytes(postData);

            HWRMaker.makeHeader(req_buy, cookieCon, postBytes.Length);

            try
            {
                Stream stream_buy = req_buy.GetRequestStream();
                stream_buy.Write(postBytes, 0, postBytes.Length);
                stream_buy.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
                //自定义的一个errorCode，表示网络错误
                return 1001;
            }

            try
            {
                HttpWebResponse resp_buy = (HttpWebResponse)req_buy.GetResponse();
                StreamReader sr = new StreamReader(resp_buy.GetResponseStream());
                //把商品加入购物车的返回值中有形如"error":xxx的内容
                resultHTML = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                ex.ToString();
                return 1001;
            }

            //获取错误代码
            errorCode = Int32.Parse(resultHTML.Substring(resultHTML.IndexOf(":") + 1, resultHTML.IndexOf(",") - resultHTML.IndexOf(":") - 1));
            
            /* 
             * 错误代码类型
             * 999：未登录
             * 888：已经购买达到上限
             * 3：商品已经下架
             * 2：库存不足
             * 0：加入购物车成功
             */
            if (errorCode > 0)
            {
                return errorCode;
            }
            else
            {
                req_buy = (HttpWebRequest)WebRequest.Create(snh_commit_url);
                //shipping表示商品运送方式，type为-1是门票，表示无需运送，type为5是实物，用顺丰快递；payment表示支付方式，22是支付宝，23是网银，默认用网银即可
                postData = "shipping=" + type + "&payment=23&postscript=&how_oos=0&step=done&x=79&y=27";
                postBytes = encoder.GetBytes(postData);

                HWRMaker.makeHeader(req_buy, cookieCon, postBytes.Length);

                try
                {
                    Stream stream_buy = req_buy.GetRequestStream();
                    stream_buy.Write(postBytes, 0, postBytes.Length);
                    stream_buy.Close();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    return 1001;
                }

                try
                {
                    HttpWebResponse resp_buy = (HttpWebResponse)req_buy.GetResponse();
                    StreamReader sr = new StreamReader(resp_buy.GetResponseStream());
                    //提交订单后的返回值是一个网页
                    resultHTML = sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    return 1001;
                }
                
                //如果网页里面有“您的订单已提交成功，请记住您的订单号”文字，说明订单提交成功
                if (resultHTML.IndexOf("您的订单已提交成功") > 0)
                {
                    return errorCode;
                }
                else
                {
                    //自定义的一个errorCode，表示因为其他原因而加入购物车成功，但是提交订单不成功的
                    errorCode = 1000;
                    return errorCode;
                }
            }
        }
    }
}
