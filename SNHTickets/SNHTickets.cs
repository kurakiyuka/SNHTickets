using System;
using System.Windows.Forms;
using SNHTickets.Flow;
using SNHTickets.Panels;

namespace SNHTickets
{
    public partial class SNHTickets : Form
    {
        OrderManager orderManager;
        LoginManager loginManager;

        public SNHTickets()
        {
            InitializeComponent();            
        }

        private void SNHTickets_Load(object sender, EventArgs e)
        {                       
            orderManager = new OrderManager();
            orderManager.OrderResultEvent += LogToRight;

            loginManager = new LoginManager();
            loginManager.LoginResultEvent += LogLoginResult;
        }

        private void login(object sender, EventArgs e)
        {
            loginManager.Login(snh_username.Text, snh_pw.Text);
        }

        private void buy_loop(object sender, EventArgs e)
        {
            
        }

        private void LogLoginResult(Object sender, LoginManager.LoginResultEventArgs e)
        {
            rtb_process.AppendText(DateTime.Now.ToString() + ' ' + e.resultStr + '\n');
            rtb_process.ScrollToCaret();
        }
        
        private void LogToRight(Object sender, OrderManager.OrderResultEventArgs e)
        {
            rtb_success.AppendText(DateTime.Now.ToString() + ' ' + e.resultStr + '\n');
            rtb_success.ScrollToCaret();
        }

        private void lb_setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GlobalSetting gsForm = new GlobalSetting();
            gsForm.StartPosition = FormStartPosition.CenterParent;
            gsForm.ShowDialog();
        }

        private void lb_acconts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccontsInfo aiForm = new AccontsInfo();
            aiForm.StartPosition = FormStartPosition.CenterParent;
            aiForm.ShowDialog();
        }
    }
}
