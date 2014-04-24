using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using SNHTickets.Flow;

namespace SNHTickets.Panels
{
    public partial class ChangeOrder : Form
    {
        public List<Account> accountsList { get; set; }
        CookieContainer cookieCon;
        Account account;
        String orderID;

        public ChangeOrder()
        {
            InitializeComponent();
        }

        private void ChangeOrder_Load(object sender, EventArgs e)
        {
            //在帐号列表中只展示各个大号，只有大号的订单才有修改订单信息的需求
            foreach (Account account in accountsList)
            {
                if (account.importance > 1)
                {
                    cb_accounts.Items.Add(account.username);
                }
            }
        }

        private void ll_getOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //登录选中的帐号，获取相应的订单信息显示在输入框内
            foreach (Account account in accountsList)
            {
                if (account.username == cb_accounts.SelectedItem.ToString())
                {
                    this.account = account;
                    if (account.Login())
                    {
                        this.cookieCon = account.cookieCon;
                        Array arr = account.getOrderInfo(tb_order.Text);
                        tb_name.Text = arr.GetValue(0).ToString();
                        tb_tel.Text = arr.GetValue(1).ToString();
                        orderID = arr.GetValue(2).ToString();
                    }
                }
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            account.ChangeOrderInfo(tb_name.Text, tb_tel.Text, orderID, cookieCon);
        }       
    }
}
