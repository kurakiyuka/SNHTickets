using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using SNHTickets.Flow;
using SNHTickets.Util;

namespace SNHTickets.Panels
{
    public partial class BuyTaskSetting : Form
    {
        List<ArrayList> taskList;
        public List<Account> accountsList { get; set; }

        public BuyTaskSetting()
        {
            InitializeComponent();
            cb_mode.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;           
            taskList = new List<ArrayList>();
        }

        private void BuyTaskSetting_Load(object sender, EventArgs e)
        {
            //在帐号列表中只展示各个大号，所有小号合并显示为“小号们”，因为抢票的时候用哪个大号去抢是有要求的，而哪个小号去抢是无所谓的
            foreach (Account ac in accountsList)
            {
                if (ac.importance > 1)
                {
                    cb_accounts.Items.Add(ac.username);
                }              
            }
            cb_accounts.Items.Add("小号们");
        }

        //点击“添加”后，先根据id去取商品的标题，过程是异步的，故此时禁止再次添加
        private void btn_addTask_Click(object sender, EventArgs e)
        {
            btn_addTask.Enabled = false;
            WebInteraction wi = new WebInteraction();
            wi.GetTitleFinEvent += showTaskInWindow;
            wi.GetTitle(tb_id.Text);
        }

        //得到商品标题后再拼装数据，并且把内容显示在窗口里面
        private void showTaskInWindow(object sender, WebInteraction.GetTitleEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            //如果商品标题里含有星梦剧院，说明是门票，否则是实物，据此自动修改类型下拉框，防止输入错误会导致后面购买失败
            if (e.title.IndexOf("星梦剧院") < 0)
            {
                cb_type.SelectedIndex = 1;
            }
            else
            {
                cb_type.SelectedIndex = 0;
            }
            arrayList.Add(tb_id.Text);
            //选择门票，则type为-1，选择实物，则type为5，这个type在购物时影响所选择的运送方式，-1表示无需物流，5表示快递
            if (cb_type.SelectedIndex == 0)
            {
                arrayList.Add(-1);
            }
            else
            {
                arrayList.Add(5);
            }
            arrayList.Add(cb_mode.SelectedIndex);
            arrayList.Add(Int32.Parse(tb_accountsNum.Text));
            arrayList.Add(e.title);
            arrayList.Add(cb_mode.SelectedItem.ToString());
            //arrayList的内容顺序是：商品id，商品类型（门票、实物），模式编号，帐号个数，商品标题，模式全名
            taskList.Add(arrayList);
            rtb_taskList.AppendText(e.title + ' ' + cb_mode.SelectedItem.ToString() + ' ' + tb_accountsNum.Text + "个帐号抢" + '\n');
            btn_addTask.Enabled = true;
        }

        private void btn_fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //窗口关闭时把任务列表传回给主窗口
        private void BuyTaskSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            SNHTickets form = (SNHTickets)this.Owner;
            form.taskList = taskList;
        }    
    }
}
