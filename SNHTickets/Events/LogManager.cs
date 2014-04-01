using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNHTickets.Events
{
    public delegate void LogDelegate(String str);

    class LogManager
    {
        private event LogDelegate Log_Success;

        public void log(String str)
        {
            Log_Success(str);
        }
    }
}
