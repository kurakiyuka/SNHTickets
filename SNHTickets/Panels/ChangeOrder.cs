using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SNHTickets.Flow;

namespace SNHTickets.Panels
{
    public partial class ChangeOrder : Form
    {
        public List<Account> accountsList { get; set; }

        public ChangeOrder()
        {
            InitializeComponent();
        }

        private void ChangeOrder_Load(object sender, EventArgs e)
        {
            //在帐号列表中只展示各个大号，只有大号的订单才有修改订单信息的需求
            foreach (Account ac in accountsList)
            {
                if (ac.importance > 1)
                {
                    cb_accounts.Items.Add(ac.username);
                }
            }
        }

        private void cb_accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //只要帐号下拉框里选中了东西，就要登录这个帐号去拉订单列表
            if (cb_accounts.SelectedIndex > -1)
            {

            }
        }
    }
}
