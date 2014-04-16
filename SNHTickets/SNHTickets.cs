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
        List<Account> accountsList;

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
                Account account = new Account();
                account.username = node.SelectSingleNode("username").InnerText.ToString();
                account.password = node.SelectSingleNode("password").InnerText.ToString();
                account.level = node.SelectSingleNode("level").InnerText.ToString();
                account.importance = Int32.Parse(node.SelectSingleNode("importance").InnerText);
                accountsList.Add(account);
            }
        }

        private void login(object sender, EventArgs e)
        {

        }

        private void buy_loop(object sender, EventArgs e)
        {
            TaskHandler th = new TaskHandler("123", 1, accountsList);
            th.OrderResultEvent += LogToRight;
            th.Start();
        }

        private void LogToRight(Object sender, TaskHandler.OrderResultEventArgs e)
        {
            rtb_success.AppendText(DateTime.Now.ToString() + ' ' + e.resultStr + '\n');
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
            btsForm.StartPosition = FormStartPosition.CenterParent;
            btsForm.ShowDialog();
        }
    }
}
