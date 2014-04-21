using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SNHTickets.Flow
{
    public class Task
    {
        //商品ID
        private String id;
        //商品类型
        private String type;
        //抢票模式
        private Int32 mode;
        //抢票需要的帐号数量
        private Int32 accountsNum;
        //帐号列表
        private List<Account> accountsList;
        //任务状态
        public Boolean status { get; set; }

        //错误代码列表
        Dictionary<Int32, String> errorCodeList = new Dictionary<int, string>()
        {
            { 1000, "购买失败" },
            { 888, "购买达到上限" },
            { 3, "商品下架" },
            { 2, "库存不足" },
            { 0, "成功" }
        };

        public Task(String id, String type, Int32 mode, Int32 accountsNum, List<Account> accountsList, Boolean status = false)
        {
            this.id = id;
            this.type = type;
            this.mode = mode;
            this.accountsNum = accountsNum;
            this.accountsList = accountsList;
        }

        public delegate void OrderResultEventHandler(Object sender, OrderResultEventArgs e);
        public event OrderResultEventHandler OrderResultEvent;

        public class OrderResultEventArgs : EventArgs
        {
            public readonly String account;
            public readonly Int32 errorCode;
            public readonly String errorMessage;
            public OrderResultEventArgs(String account, Int32 errorCode, String errorMessage)
            {
                this.account = account;
                this.errorCode = errorCode;
                this.errorMessage = errorMessage;
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
            status = true;
            //捡漏模式，只有小号参与捡漏，而且每次固定只使用一个号，一张一张抢
            if (mode == 0)
            {
                foreach (Account account in accountsList)
                {
                    if (account.importance == 1 && status)
                    {
                        if (account.Login())
                        {
                            Int32 errorCode = 0;
                            //只要不是帐号已经买满了数量，就循环不断的买
                            while (errorCode != 888 && status)
                            {
                                errorCode = account.Buy(id, 1, type, account.cookieCon);
                                OrderResultEventArgs ev = new OrderResultEventArgs(account.username, errorCode, errorCodeList[errorCode]);
                                OrderComplete(ev);
                                delayTime(2);
                            }
                            continue;
                        }
                    }
                }
            }
            //定量模式，一般用在开票的时候，指定一定数量的小号参与购买，限购多少就买多少
            else if (mode == 1)
            {
                foreach (Account account in accountsList)
                {
                    if (account.importance == 1 && status)
                    {
                        if (account.Login())
                        {
                            Int32 errorCode = 0;
                            //一次性抢限购数量上限的数量
                            while (errorCode != 888 && status)
                            {
                                errorCode = account.Buy(id, 5, type, account.cookieCon);
                                OrderResultEventArgs ev = new OrderResultEventArgs(account.username, errorCode, errorCodeList[errorCode]);
                                OrderComplete(ev);
                            }
                            //这里有BUG
                            accountsNum--;
                            if (accountsNum > 0)
                            {
                                continue;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
            //买满模式，一般用在开票的时候，指定一定数量的大号参与购买，一张一张买，买到上限为止
            else if (mode == 2)
            {
                foreach (Account account in accountsList)
                {
                    if (account.importance > 100 && status)
                    {
                        if (account.Login())
                        {
                            Int32 errorCode = 0;
                            //一次性抢限购数量上限的数量
                            while (errorCode != 888 && status)
                            {
                                errorCode = account.Buy(id, 1, type, account.cookieCon);
                                OrderResultEventArgs ev = new OrderResultEventArgs(account.username, errorCode, errorCodeList[errorCode]);
                                OrderComplete(ev);
                            }
                            return;
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void delayTime(Int32 secend)
        {
            DateTime tempTime = DateTime.Now;
            while (tempTime.AddSeconds(secend).CompareTo(DateTime.Now) > 0)
            {
                Application.DoEvents();
            }
        }
    }
}
