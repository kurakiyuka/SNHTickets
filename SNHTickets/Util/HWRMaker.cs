using System;
using System.Net;

namespace SNHTickets.Util
{
    class HWRMaker
    {
        //为一个Http请求构建Header和其他准备性的数据
        public static void makePostHeader(HttpWebRequest hwReq, CookieContainer cookieCon, Int32 length)
        {
            hwReq.CookieContainer = cookieCon;
            hwReq.Method = "POST";
            hwReq.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0;)";
            hwReq.ContentType = "application/x-www-form-urlencoded";
            hwReq.ContentLength = length;
        }

        public static void makeGetHeader(HttpWebRequest hwReq, CookieContainer cookieCon)
        {
            hwReq.CookieContainer = cookieCon;
            hwReq.Method = "GET";
            hwReq.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0;)";
        }
    }
}
