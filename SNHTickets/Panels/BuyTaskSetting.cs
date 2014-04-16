using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SNHTickets.Panels
{
    public partial class BuyTaskSetting : Form
    {
        public List<Object> taskList;

        public BuyTaskSetting()
        {
            InitializeComponent();
            taskList = new List<Object>();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            taskList.Add(new Task(tb_id.Text, cb_model.SelectedItem.ToString(), Int32.Parse(tb_accouts_num.Text)));
            rtb_task.AppendText(tb_id.Text + ' ' + cb_model.SelectedItem.ToString() + ' ' + tb_accouts_num.Text + '\n');
        }

        private void BuyTaskSetting_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }

    public class Task
    {
        public String ID { get; set; }
        public String Model { get; set; }
        public Int32 Accounts_num { get; set; }
        public Task(String id, String model, Int32 accouts_num)
        {
            ID = id;
            Model = model;
            Accounts_num = accouts_num;
        }
    }
}
