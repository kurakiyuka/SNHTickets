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
    public partial class BuyTaskSetting : Form
    {
        public List<Task> taskList;

        public BuyTaskSetting()
        {
            InitializeComponent();
            taskList = new List<Task>();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            taskList.Add(new Task(tb_id.Text, cb_model.SelectedItem.ToString(), int.Parse(tb_accouts_num.Text)));
            rtb_task.AppendText(tb_id.Text + ' ' + cb_model.SelectedItem.ToString() + ' ' + tb_accouts_num.Text + '\n');
        }
    }

    public class Task
    {
        public string ID { get; set; }
        public string Model { get; set; }
        public int Accounts_num { get; set; }
        public Task(string id, string model, int accouts_num)
        {
            ID = id;
            Model = model;
            Accounts_num = accouts_num;
        }
    }
}
