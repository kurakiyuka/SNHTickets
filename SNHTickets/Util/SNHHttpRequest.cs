using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace SNHTickets.Util
{
    class SNHHttpRequest
    {
        //编码器
        ASCIIEncoding encoding;

        CookieContainer cookieCon;
        String resultString;

        public SNHHttpRequest()
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
    }
}
