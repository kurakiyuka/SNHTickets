using System;
using System.Windows.Forms;

namespace SNHTickets.Util.WebInteraction
{
    class GetUrlWithoutLogin
    {
        public delegate void GetURLEventHandler(Object sender, GetURLEventArgs e);
        public event GetURLEventHandler GetURLFinEvent;
        public class GetURLEventArgs : EventArgs
        {
            public readonly String title;
            public GetURLEventArgs(String title)
            {
                this.title = title;
            }
        }
        protected virtual void DispatchGetTitleEvent(GetURLEventArgs e)
        {
            if (GetURLFinEvent != null)
            {
                GetURLFinEvent(this, e);
            }
        }

        public void getURL(String url)
        {
            WebBrowser web = new WebBrowser();
            web.Navigate(url);
        }
    }
}
