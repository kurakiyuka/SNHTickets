using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace SNHTickets.Util.WebInteraction
{
    class GetUrlHtml
    {
        String resultHtml;
        CookieContainer cookieCon;

        public GetUrlHtml(CookieContainer cookieCon = null)
        {
            this.cookieCon = cookieCon;
        }

        public String getUrlHtml(String url)
        {
            HttpWebRequest hwReq = (HttpWebRequest)WebRequest.Create(url);
            HWRMaker.makeGetHeader(hwReq, cookieCon);
            HttpWebResponse hwResp = (HttpWebResponse)hwReq.GetResponse();
            StreamReader sr = new StreamReader(hwResp.GetResponseStream());
            resultHtml = sr.ReadToEnd();
            return resultHtml;
        }
    }
}
