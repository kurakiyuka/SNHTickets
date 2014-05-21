using System;
using System.Windows.Forms;

namespace SNHTickets.Util.WebInteraction
{
    class GetUrlTitle
    {
        String title;
        Timer webTimeOut;

        public delegate void GetUrlTitleEventHandler(Object sender, GetUrlTitleEventArgs e);
        public event GetUrlTitleEventHandler GetURLTitleFinEvent;
        public class GetUrlTitleEventArgs : EventArgs
        {
            public readonly String title;
            public GetUrlTitleEventArgs(String title)
            {
                this.title = title;
            }
        }
        protected virtual void DispatchGetUrlTitleEvent(GetUrlTitleEventArgs e)
        {
            if (GetURLTitleFinEvent != null)
            {
                GetURLTitleFinEvent(this, e);
            }
        }

        public GetUrlTitle()
        {
            webTimeOut = new Timer();
            webTimeOut.Tick += new EventHandler(WebTimeOutEventHandler);
            webTimeOut.Interval = 5000;        
        }

        private void WebTimeOutEventHandler(object sender, EventArgs e)
        {
            webTimeOut.Stop();
            title = "error";
            GetUrlTitleEventArgs ev = new GetUrlTitleEventArgs(title);
            DispatchGetUrlTitleEvent(ev);
        }

        public void getUrlTitle(String url)
        {
            webTimeOut.Start();
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Navigate("http://www.youtube.com");
            //异步获取网页内容
            webBrowser.DocumentCompleted += web_DocumentCompleted;
        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webTimeOut.Stop();
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection ElementCollection = webBrowser.Document.GetElementsByTagName("title");
            //如果获取不到Title，说明URL地址有误
            if (ElementCollection != null)
            {
                title = ElementCollection[0].InnerText;
            }
            else
            {
                title = "error";
            }
            GetUrlTitleEventArgs ev = new GetUrlTitleEventArgs(title);
            DispatchGetUrlTitleEvent(ev);
        }
    }
}
