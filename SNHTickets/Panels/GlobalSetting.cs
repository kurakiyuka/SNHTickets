using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SNHTickets.Panels
{
    public partial class GlobalSetting : Form
    {
        public GlobalSetting()
        {
            InitializeComponent();
        }

        private void GlobalSetting_Load(object sender, EventArgs e)
        {
            tb_stand_ticket_limit.Text = Properties.Settings.Default.Stand_Ticket_Limit.ToString();
            tb_sit_ticket_limit.Text = Properties.Settings.Default.Sit_Ticket_Limit.ToString();
            tb_vip_ticket_d1_limit.Text = Properties.Settings.Default.VIP_Ticket_D1_Limit.ToString();
            tb_vip_ticket_limit.Text = Properties.Settings.Default.VIP_Ticket_Limit.ToString();
            tb_photo_limit.Text = Properties.Settings.Default.Photo_Limit.ToString();
            tb_max_limit.Text = Properties.Settings.Default.Max_Limit.ToString();
        }

        private void btn_Save_Setting_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Stand_Ticket_Limit = Int32.Parse(tb_stand_ticket_limit.Text);
            Properties.Settings.Default.Sit_Ticket_Limit = Int32.Parse(tb_sit_ticket_limit.Text);
            Properties.Settings.Default.VIP_Ticket_D1_Limit = Int32.Parse(tb_vip_ticket_d1_limit.Text);
            Properties.Settings.Default.VIP_Ticket_Limit = Int32.Parse(tb_vip_ticket_limit.Text);
            Properties.Settings.Default.Photo_Limit = Int32.Parse(tb_photo_limit.Text);
            Properties.Settings.Default.Max_Limit = Int32.Parse(tb_max_limit.Text);
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
