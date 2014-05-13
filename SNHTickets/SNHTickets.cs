using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using SNHTickets.Flow;
using SNHTickets.Panels;
using SNHTickets.Panels.Accounts;

namespace SNHTickets
{
    public partial class SNHTickets : Form
    {
        public List<Account> accountsList;
        public List<Task> taskList;
        Task th;

        public SNHTickets()
        {
            InitializeComponent();
        }

        private void SNHTickets_Load(object sender, EventArgs e)
        {
            //读取帐号列表，这块暂时写死在XML文件里，以后再做可设置
            accountsList = new List<Account>();
            XmlDocument accountsXMLDoc = new XmlDocument();
            accountsXMLDoc.Load(@"..\..\Properties\Accounts.xml");
            foreach (XmlNode node in accountsXMLDoc.GetElementsByTagName("account"))
            {
                Account account = new Account();
                account.username = node.SelectSingleNode("username").InnerText.ToString();
                account.password = node.SelectSingleNode("password").InnerText.ToString();
                account.level = node.SelectSingleNode("level").InnerText.ToString();
                account.importance = Int32.Parse(node.SelectSingleNode("importance").InnerText);
                accountsList.Add(account);
            }
        }

        private void buy_loop(object sender, EventArgs e)
        {
            if (taskList == null || taskList.Count == 0)
            {
                MessageBox.Show("请先设置任务", "提示");
                return;
            }

            foreach (Task task in taskList)
            {
                th = task;
                th.OrderResultEvent += onOrderResultEvent;
                th.Start();
            }
        }

        private void onOrderResultEvent(Object sender, Task.OrderResultEventArgs e)
        {
            if (e.errorCode != 0)
            {
                logToProcess(DateTime.Now.ToString() + ' ' + e.account + ' ' + e.errorMessage.ToString());
            }
            else
            {
                logToSuccess(DateTime.Now.ToString() + ' ' + e.account + ' ' + e.errorMessage.ToString());
            }
        }


        private void btn_stop_Click(object sender, EventArgs e)
        {
            th.status = false;
        }

        private void logToProcess(String msg)
        {
            rtb_process.AppendText(msg + '\n');
            rtb_process.ScrollToCaret();
        }

        private void logToSuccess(String msg)
        {
            rtb_success.AppendText(msg + '\n');
            rtb_success.ScrollToCaret();
        }

        //注册帐号对话框
        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register rgForm = new Register();
            rgForm.ShowDialog();
        }

        //添加帐户对话框
        private void AddAccoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsInfo aiForm = new AccountsInfo();
            aiForm.ShowDialog();
        }

        //参数设置对话框
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalSetting gsForm = new GlobalSetting();
            gsForm.ShowDialog();
        }

        //购买任务对话框
        private void BuyTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyTaskSetting btsForm = new BuyTaskSetting();
            btsForm.accountsList = accountsList;
            btsForm.Owner = this;
            btsForm.ShowDialog();          
            foreach (Task task in taskList)
            {
                rtb_tasklist.Text += task.goodsName + '，' + task.modeName + '，' + task.accountUserName + '，' + task.accountsNum.ToString() + "个帐号抢" + '\n';
            }
        }

        //修改订单信息对话框
        private void ChangeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeOrder coForm = new ChangeOrder();
            coForm.accountsList = accountsList;
            coForm.ShowDialog();
        }
    }
}
