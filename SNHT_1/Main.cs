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

        public Main()
        {
            InitializeComponent();
        }

        private void Load(object sender, EventArgs e)
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
                    account.realname = node.SelectSingleNode("realname").InnerText.ToString();
                }
                if (node.SelectSingleNode("tel") != null)
                {
                    account.tel = node.SelectSingleNode("tel").InnerText.ToString();
                }
                account.importance = Int32.Parse(node.SelectSingleNode("importance").InnerText);
                accountsList.Add(account);
            }
        }
    }
}
