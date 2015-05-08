using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Account account = new Account();
                account.username = node.SelectSingleNode("username").InnerText.ToString();
                account.password = node.SelectSingleNode("password").InnerText.ToString();
                if (node.SelectSingleNode("level") != null)
                {
                    account.level = node.SelectSingleNode("level").InnerText.ToString();
                }
                if (node.SelectSingleNode("realname") != null)
                {
                    if (node.SelectSingleNode("realname").InnerText.ToString() == "yes")
                    {
                        account.isRealname = true;
                    }
                    else
                        account.isRealname = false;
                }
                if (node.SelectSingleNode("tel") != null)
                {
                    account.tel = node.SelectSingleNode("tel").InnerText.ToString();
                }
                account.importance = Int32.Parse(node.SelectSingleNode("importance").InnerText);
                accountsList.Add(account);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Account account in accountsList)
            {
                if (account.importance > 10000)
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
                if (account.importance > 10000 && status)
                {
                    Int32 errorCode = 0;
                    //如果帐号购买数量已经到了上限（888错误），那么更换帐号，否则就反复买
                    while (errorCode != 888 && status)
                    {
                        errorCode = account.Buy(textBox1.Text, 6, "5", account.cookieCon);
                        delay(100);

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
