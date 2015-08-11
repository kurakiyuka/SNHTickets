using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using SNHT_1.Flow;

namespace SNHT_1
{
    public partial class Main : Form
    {
        public List<Account> accountsList;
        //任务状态
        public Boolean status { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //读取帐号列表，这块暂时写死在XML文件里，以后再做可设置
            accountsList = new List<Account>();
            XmlDocument accountsXMLDoc = new XmlDocument();
            accountsXMLDoc.Load(@"..\..\Properties\Accounts.xml");
            foreach (XmlNode node in accountsXMLDoc.GetElementsByTagName("account"))
            {
                Account account = new Account(node);             
                accountsList.Add(account);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Account account in accountsList)
            {
                if (account.importance == 99)
                {
                    if (account.Login())
                    {
                        richTextBox1.AppendText(account.username + " 登录成功\n");
                    }
                    else
                    {
                        richTextBox1.AppendText(account.username + " 登录失败\n");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            status = true;
            foreach (Account account in accountsList)
            {
                if (account.isLogin == true && status)
                {
                    Int32 errorCode = 0;
                    //如果帐号购买数量已经到了上限（888错误），那么更换帐号，否则就反复买
                    while (errorCode != 888 && status)
                    {
                        errorCode = account.Buy(textBox1.Text, 1, "-1", account.cookieCon);
                        delay(200);

                        if (errorCode == 1001)
                        {
                            richTextBox1.AppendText(account.username + " 网络问题\n");
                        }

                        if (errorCode == 0)
                        {
                            richTextBox1.AppendText(account.username + " 购买成功\n");
                        }
                    }
                    continue;
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            status = false;
        }
    }
}
