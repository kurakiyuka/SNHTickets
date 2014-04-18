using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SNHTickets.Flow
{
    public class Task
    {
        //商品ID
        private String id;
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

        public Task(String id, Int32 mode, Int32 accouts_num, List<Account> accountsList, Boolean status = false)
        {
            this.id = id;
            this.mode = mode;
            this.accountsNum = accouts_num;
            this.accountsList = accountsList;
            this.status = status;
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
            if (mode == 0)
            {
                String mode0Username;
                String mode0Password;
                foreach (Account account in accountsList)
                {
                    if (account.importance == 1)
                    {
                        mode0Username = account.username;
                        mode0Password = account.password;
                        LoginManager lm = new LoginManager();
                        if (lm.Login(mode0Username, mode0Password))
                        {
                            BuyManager bm = new BuyManager();
                            Int32 errorCode = bm.Buy(id, 1, 5, lm.cookieCon);
                            while (errorCode != 888)
                            {
                                errorCode = bm.Buy(id, 1, 5, lm.cookieCon);
                                OrderResultEventArgs e = new OrderResultEventArgs(mode0Username, errorCode, errorCodeList[errorCode]);
                                OrderComplete(e);
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
