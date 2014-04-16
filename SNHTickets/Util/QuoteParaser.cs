using System;
using System.Collections.Generic;
using System.Web;

namespace SNHTickets.Util
{
    class QuoteParaser
    {
        public static string quoteParas(Dictionary<String, String> paras)
        {
            String quotedParas = "";
            Boolean isFirst = true;
            String val = "";
            foreach (String para in paras.Keys)
            {
                if (paras.TryGetValue(para, out val))
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        quotedParas += para + "=" + HttpUtility.UrlPathEncode(val);
                    }
                    else
                    {
                        quotedParas += "&" + para + "=" + HttpUtility.UrlPathEncode(val);
                    }
                }
                else
                {
                    break;
                }
            }

            return quotedParas;
        }
    }
}
