using System.Net;

namespace SNHTickets.Util
{
    class HWRMaker
    {
        //为一个Http请求构件Header和其他准备性的数据
        public static void makeHeader(HttpWebRequest hwRequest, CookieContainer cookieCon, int length)
        {
            hwRequest.CookieContainer = cookieCon;
            hwRequest.Method = "POST";
            hwRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0;)";
            hwRequest.ContentType = "application/x-www-form-urlencoded";
            hwRequest.ContentLength = length;
        }
    }
}
