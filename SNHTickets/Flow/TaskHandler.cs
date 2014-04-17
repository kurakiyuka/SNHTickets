using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SNHTickets.Flow
{
    class TaskHandler
    {
        //商品ID
        String id;
        //抢票模式
        Int32 mode;
        //抢票需要的帐号数量
        Int32 accounts_num;
        //帐号列表
        List<Account> accountsList;

        public TaskHandler(String id, Int32 mode, Int32 accounts_num, List<Account> accountsList)
        {
            this.id = id;
            this.mode = mode;
            this.accounts_num = accounts_num;
            this.accountsList = accountsList;
        }

        public delegate void OrderResultEventHandler(Object sender, OrderResultEventArgs e);
        public event OrderResultEventHandler OrderResultEvent;

        public class OrderResultEventArgs : EventArgs
        {
            public readonly String account;
            public readonly Boolean buyResult;
            public OrderResultEventArgs(String account, Boolean buyResult)
            {
                this.account = account;
                this.buyResult = buyResult;
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
            if (mode == 0)
            {
                String mode0Username;
                String mode0Password;
                foreach (Account account in accountsList)
                {
                    if (account.importance == 1)
                    {
                        mode0Username = account.username;
                    }
                }
            }
            else
            {
            }
        }

        private void delayTime(Int32 secend)
        {
            DateTime tempTime = DateTime.Now;
            while (tempTime.AddSeconds(secend).CompareTo(DateTime.Now) > 0)
            Application.DoEvents();
        }
    }
}
