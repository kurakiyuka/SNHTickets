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
            { 2, "库存不足" },
            { 0, "成功" }
        };

        public Task(String id, String type, Int32 mode, Int32 accouts_num, List<Account> accountsList, Boolean status = false)
        {
            this.id = id;
            this.type = type;
            this.mode = mode;
            this.accountsNum = accouts_num;
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
            if (mode == 0)
            {
                foreach (Account account in accountsList)
                {
                    if (account.importance == 1 && status)
                    {
                        if (account.Login())
                        {
                            Int32 errorCode = 0;
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
