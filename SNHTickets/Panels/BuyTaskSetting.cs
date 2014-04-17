using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SNHTickets.Flow;

namespace SNHTickets.Panels
{
    public partial class BuyTaskSetting : Form
    {
        List<Task> taskList;

        public BuyTaskSetting()
        {
            InitializeComponent();
            taskList = new List<Task>();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            taskList.Add(new Task(tb_id.Text, cb_model.SelectedIndex, Int32.Parse(tb_accouts_num.Text)));
            rtb_task.AppendText(tb_id.Text + ' ' + cb_model.SelectedItem.ToString() + ' ' + tb_accouts_num.Text + '\n');
        }

        private void BuyTaskSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            SNHTickets form = (SNHTickets)this.Owner;
            form.taskList = taskList;
        }
    }
}
