using System;
using System.Collections;
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
        public List<ArrayList> taskList;
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
                Account account = new Account(node.SelectSingleNode("username").InnerText.ToString(), node.SelectSingleNode("password").InnerText.ToString(), node.SelectSingleNode("level").InnerText.ToString(), Int32.Parse(node.SelectSingleNode("importance").InnerText));
                accountsList.Add(account);
            }
        }

        private void buy_loop(object sender, EventArgs e)
        {
            if (taskList == null)
            {
                MessageBox.Show("请先设置任务", "提示");
                return;
            }

            foreach (ArrayList task in taskList)
            {
                //arrayList的内容顺序是：商品id，商品类型（门票、实物），模式编号，帐号个数，商品标题，模式全名
                th = new Task(task[0].ToString(), task[1].ToString(), Int32.Parse(task[2].ToString()), Int32.Parse(task[3].ToString()), accountsList);
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

        //添加帐户菜单
        private void AddAccoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsInfo aiForm = new AccountsInfo();
            aiForm.ShowDialog();
        }

        //参数设置菜单
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalSetting gsForm = new GlobalSetting();
            gsForm.ShowDialog();
        }

        //购买任务菜单
        private void BuyTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyTaskSetting btsForm = new BuyTaskSetting();
            btsForm.Owner = this;
            btsForm.ShowDialog();
            foreach (ArrayList task in taskList)
            {
                //arrayList的内容顺序是：商品id，商品类型（门票、实物），模式编号，帐号个数，商品标题，模式全名
                rtb_tasklist.Text += task[4].ToString() + ' ' + task[5].ToString() + ' ' + task[3].ToString() + "个帐号抢" + '\n';
            }
        }
    }
}
