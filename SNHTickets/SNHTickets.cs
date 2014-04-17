using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using SNHTickets.Flow;
using SNHTickets.Panels;

namespace SNHTickets
{
    public partial class SNHTickets : Form
    {
        public List<Account> accountsList;
        public List<Task> taskList;

        public SNHTickets()
        {
            InitializeComponent();
        }

        private void SNHTickets_Load(object sender, EventArgs e)
        {
            accountsList = new List<Account>();
            XmlDocument accountsXMLDoc = new XmlDocument();
            accountsXMLDoc.Load(@"..\..\Properties\Accounts.xml");
            foreach (XmlNode node in accountsXMLDoc.GetElementsByTagName("account"))
            {
                Account account = new Account(node.SelectSingleNode("username").InnerText.ToString(), node.SelectSingleNode("password").InnerText.ToString(), node.SelectSingleNode("level").InnerText.ToString(), Int32.Parse(node.SelectSingleNode("importance").InnerText));
                accountsList.Add(account);
            }
        }

        private void buy_loop(object sender, EventArgs e)
        {
            foreach (Task task in taskList)
            {
                TaskHandler th = new TaskHandler(task.id, task.model, task.accounts_num, accountsList);
                th.OrderResultEvent += LogToRight;
                th.Start();
            }
        }

        private void LogToRight(Object sender, TaskHandler.OrderResultEventArgs e)
        {
            rtb_success.AppendText(DateTime.Now.ToString() + ' ' + e.account + ' ' + e.buyResult.ToString() + '\n');
            rtb_success.ScrollToCaret();
        }

        //添加帐户菜单
        private void AddAccoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsInfo aiForm = new AccountsInfo();
            aiForm.StartPosition = FormStartPosition.CenterParent;
            aiForm.ShowDialog();
        }

        //参数设置菜单
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalSetting gsForm = new GlobalSetting();
            gsForm.StartPosition = FormStartPosition.CenterParent;
            gsForm.ShowDialog();
        }

        //购买任务菜单
        private void BuyTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyTaskSetting btsForm = new BuyTaskSetting();
            btsForm.Owner = this;
            btsForm.StartPosition = FormStartPosition.CenterParent;
            btsForm.ShowDialog();
            foreach (Task task in taskList)
            {
                rtb_tasklist.Text += task.id + ' ' + task.model.ToString() + ' ' + task.accounts_num.ToString() + '\n';
            }
        }
    }
}
