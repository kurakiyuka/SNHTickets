using System;
using System.Collections.Generic;
using System.Threading;

namespace SNHTickets.Flow
{
    class TaskHandler
    {
        //商品ID
        String id;
        //抢票模式
        Int32 mode;
        //帐号列表
        List<Account> accountsList;

        public TaskHandler(String id, Int32 mode, List<Account> accountsList)
        {
            this.id = id;
            this.mode = mode;
            this.accountsList = accountsList;
        }

        public delegate void OrderResultEventHandler(Object sender, OrderResultEventArgs e);
        public event OrderResultEventHandler OrderResultEvent;

        public class OrderResultEventArgs : EventArgs
        {
            public readonly String resultStr;
            public OrderResultEventArgs(String resultStr)
            {
                this.resultStr = resultStr;
            }
        }

        protected virtual void OrderComplete(OrderResultEventArgs e)
        {
            if (OrderResultEvent != null)
            {
                OrderResultEvent(this, e);
            }
        }

        public void Start()
        {
            if (mode == 1)
            {
                foreach (Account account in accountsList)
                {
                    if (account.importance == 1)
                    {
                        account.Login();
                        account.Buy();
                        OrderResultEventArgs e = new OrderResultEventArgs(account.username);
                        OrderComplete(e);
                        Thread.Sleep(1000);
                    }
                }
            }
            else
            {
            }
        }
    }
}
