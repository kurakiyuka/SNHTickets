using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SNHTickets.Flow
{
    public class Task
    {
        //商品ID
        public String id { get; set; }
        //商品名称
        public String goodsName { get; set; }
        //商品类型
        public String type { get; set; }
        //抢票模式代号
        public Int32 mode { get; set; }
        //抢票模式全名
        public String modeName { get; set; }
        //抢票的帐号
        public String accountUserName { get; set; }
        //抢票需要的帐号数量
        public Int32 accountsNum { get; set; }
        //总共要抢的数量
        public Int32 totalNum { get; set; }
        //单词抢的数量
        public Int32 onetimeNum { get; set; }
        //延时时长
        public Int32 delayTime { get; set; }
        //帐号列表
        public List<Account> accountsList { get; set; }
        //任务状态
        public Boolean status { get; set; }

        //错误代码列表
        Dictionary<Int32, String> errorCodeList = new Dictionary<int, string>()
        {
            { 999995, "帐号被禁" },
            { 1003, "登录失败" },
            { 1002, "未知错误" },
            { 1001, "网络错误" },
            { 1000, "购买失败" },
            { 999, "未登录"},
            { 888, "购买达到上限" },
            { 3, "商品下架" },
            { 2, "库存不足" },
            { 0, "成功" }
        };

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

        protected virtual void DispatchOrderCompleteEvent(OrderResultEventArgs e)
        {
            if (OrderResultEvent != null)
            {
                OrderResultEvent(this, e);
            }
        }

        public void Start()
        {
            status = true;
            switch (mode)
            {
                case 0:
                    //随机小号模式，只有小号按照Accounts.xml中的排列顺序参与抢票
                    foreach (Account account in accountsList)
                    {
                        if (account.importance == 1 && status)
                        {
                            if (account.Login())
                            {
                                Int32 errorCode = 0;
                                //如果帐号购买数量已经到了上限（888错误），那么更换帐号，否则就反复买
                                while (errorCode != 888 && status)
                                {
                                    errorCode = account.Buy(id, this.onetimeNum, type);

                                    OrderResultEventArgs ev = new OrderResultEventArgs(account.username, errorCode, errorCodeList[errorCode]);
                                    DispatchOrderCompleteEvent(ev);
                                    delay(this.delayTime);

                                    //errorCode为0说明购买成功，在需要购买的总量上减单次购买的量
                                    if (errorCode == 0)
                                    {
                                        totalNum -= this.onetimeNum;
                                        if (totalNum <= 0)
                                        {
                                            return;
                                        }
                                    }
                                }
                                continue;
                            }
                            //登录失败，返回1003错误
                            else
                            {
                                OrderResultEventArgs ev = new OrderResultEventArgs(account.username, 1003, errorCodeList[1003]);
                                DispatchOrderCompleteEvent(ev);
                            }
                        }
                    }
                    break;

                case 1:
                    //指定帐号模式
                    foreach (Account account in accountsList)
                    {
                        if (account.username == this.accountUserName && status)
                        {
                            if (account.Login())
                            {
                                Int32 errorCode = 0;
                                //如果帐号购买数量已经到了上限（888错误），那么更换帐号，否则就反复买
                                while (errorCode != 888 && status)
                                {
                                    errorCode = account.Buy(id, this.onetimeNum, type);

                                    OrderResultEventArgs ev = new OrderResultEventArgs(account.username, errorCode, errorCodeList[errorCode]);
                                    DispatchOrderCompleteEvent(ev);
                                    delay(this.delayTime);

                                    //errorCode为0说明购买成功，在需要购买的总量上减单次购买的量
                                    if (errorCode == 0)
                                    {
                                        totalNum -= this.onetimeNum;
                                        if (totalNum <= 0)
                                        {
                                            return;
                                        }
                                    }
                                }
                                continue;
                            }
                            else
                            {
                                OrderResultEventArgs ev = new OrderResultEventArgs(account.username, 1003, errorCodeList[1003]);
                                DispatchOrderCompleteEvent(ev);
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void delay(Int32 millisecends)
        {
            DateTime tempTime = DateTime.Now;
            while (tempTime.AddMilliseconds(millisecends).CompareTo(DateTime.Now) > 0)
            {
                Application.DoEvents();
            }
        }
    }
}
