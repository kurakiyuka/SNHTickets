using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SNHTickets.Panels
{
    public partial class BuyTaskSetting : Form
    {
        List<ArrayList> taskList;

        public BuyTaskSetting()
        {
            InitializeComponent();
            taskList = new List<ArrayList>();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(tb_id.Text);
            arrayList.Add(cb_model.SelectedIndex);
            arrayList.Add(Int32.Parse(tb_accouts_num.Text));
            taskList.Add(arrayList);
            rtb_task.AppendText(tb_id.Text + ' ' + cb_model.SelectedItem.ToString() + ' ' + tb_accouts_num.Text + '\n');
        }

        private void BuyTaskSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            SNHTickets form = (SNHTickets)this.Owner;
            form.taskList = taskList;
        }
    }
}
