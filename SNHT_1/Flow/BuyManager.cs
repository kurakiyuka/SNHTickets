using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SNHT_1.Util;

namespace SNHT_1.Flow
{
    class BuyManager
    {
        //获取验证码URL
        String snh_captcha_url = "http://101.226.6.78/captcha.php?is_login=1&t=1";
        //把商品加入购物车使用的URL
        String snh_add_to_cart_url = "http://101.226.6.78/flow.php?step=add_to_cart";
        //最后提交订单的URL
        String snh_commit_url = "http://101.226.6.78/flow.php?step=done";
        //清空购物车的URL
        String snh_clear_url = "http://101.226.6.78/flow.php?step=clear";

        CookieContainer cookieCon;
        Int32 errorCode;
        String resultHTML = null;

        public BuyManager(CookieContainer cookieCon)
        {
            this.cookieCon = cookieCon;          
        }

        /*
         * id：商品id
         * amount：一次性购买的商品数量
         * type：区分是实物商品还是门票，这影响到后面提交订单时，shipping参数的值，-1表示门票，5表示实物
         * cookieCon：登录成功返回的cookie
         */
        public Int32 Buy(String id, Int32 amount, String type)
        {
            //获取验证码
            HttpWebRequest req_captcha = (HttpWebRequest)WebRequest.Create(snh_captcha_url);
            HWRMaker.makeGetHeader(req_captcha, cookieCon);
            WebResponse resp_captcha = req_captcha.GetResponse();
            if (((HttpWebResponse)resp_captcha).StatusCode != HttpStatusCode.OK)
            {
                return 1001;
            }

            Stream dataStream = resp_captcha.GetResponseStream();
            Image captchaImg = Image.FromStream(dataStream);
            Bitmap captchaBitmap = new Bitmap(captchaImg);
            
            Captcha captcha = new Captcha();
            captcha.InitCaptchaDict();
            String captchaText = captcha.CaptchaToText(captchaBitmap);

            //加入购物车
            HttpWebRequest req_buy = (HttpWebRequest)WebRequest.Create(snh_add_to_cart_url);
            String postData = "goods={\"quick\":1,\"spec\":[],\"goods_id\":" + id + ",\"captcha\":\"" + captchaText + "\",\"is_donation\":\"0\",\"is_real\":1,\"priceid\":0,\"number\":\"" + amount.ToString() + "\",\"donation_number\":\"0\",\"parent\":0}";
            ASCIIEncoding encoder = new ASCIIEncoding();
            Byte[] postBytes = encoder.GetBytes(postData);

            HWRMaker.makePostHeader(req_buy, cookieCon, postBytes.Length);

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
            try
            {
                errorCode = Int32.Parse(resultHTML.Substring(resultHTML.IndexOf(":") + 1, resultHTML.IndexOf(",") - resultHTML.IndexOf(":") - 1));
            }
            catch (Exception ex)
            {
                ex.ToString();
                clearCart();
                //自定义的一个errorCode，表示未知错误
                return 1002;
            }

            /* 
             * 错误代码类型
             * 999：未登录
             * 888：购买达到上限
             * 301：验证码错误
             * 3：商品下架
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

                HWRMaker.makePostHeader(req_buy, cookieCon, postBytes.Length);

                try
                {
                    Stream stream_buy = req_buy.GetRequestStream();
                    stream_buy.Write(postBytes, 0, postBytes.Length);
                    stream_buy.Close();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    clearCart();
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
                    clearCart();
                    return 1001;
                }
                
                //如果网页里面有“您的订单已提交成功，请记住您的订单号”文字，说明订单提交成功
                if (resultHTML.IndexOf("您的订单已提交成功") > 0)
                {
                    return errorCode;
                }
                else
                {
                    clearCart();
                    //自定义的一个errorCode，表示因为其他原因而加入购物车成功，但是提交订单不成功的                    
                    return 1000;
                }
            }
        }

        private void clearCart()
        {
            HttpWebRequest hwReq = (HttpWebRequest)WebRequest.Create(snh_clear_url);
            HWRMaker.makeGetHeader(hwReq, cookieCon);
            HttpWebResponse hwResp = (HttpWebResponse)hwReq.GetResponse();
            StreamReader sr = new StreamReader(hwResp.GetResponseStream());
            String resultHtml = sr.ReadToEnd();
        }
    }
}
