using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SNHTickets.Flow;
using SNHTickets.Util.WebInteraction;

namespace SNHTickets.Panels
{
    public partial class BuyTaskSetting : Form
    {
        //商品URL前缀，加上id就是商品完整的URL
        String snh_goods_url_prefix = "http://shop.snh48.com/goods.php?id=";

        List<Task> taskList;
        public List<Account> accountsList { get; set; }

        public BuyTaskSetting()
        {
            InitializeComponent();
            cb_mode.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;           
            taskList = new List<Task>();
        }

        private void BuyTaskSetting_Load(object sender, EventArgs e)
        {
            //在帐号列表中只展示各个大号，所有小号合并显示为“小号”，因为抢票的时候用哪个大号去抢是有要求的，而哪个小号去抢是无所谓的，按照顺序抢即可
            foreach (Account ac in accountsList)
            {
                if (ac.importance > 1)
                {
                    cb_accounts.Items.Add(ac.username);
                }              
            }
            cb_accounts.Items.Add("小号");
            cb_accounts.SelectedIndex = 0;
        }

        //点击“添加”后，先根据id去取商品的标题，过程是异步的，此时禁止再次点添加
        private void btn_addTask_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "")
            {
                btn_addTask.Enabled = false;
                String url = snh_goods_url_prefix + tb_id.Text;
                GetUrlTitle getURLTitle = new GetUrlTitle();
                getURLTitle.GetURLTitleFinEvent += showTaskInWindow;
                //这里取回的是某个URL的完整Title
                getURLTitle.getUrlTitle(url);
            }
            else
            {
                MessageBox.Show("请输入商品ID", "提示");
            }
        }

        //得到商品标题后再拼装数据，并且把内容显示在窗口里面
        private void showTaskInWindow(object sender, GetUrlTitle.GetUrlTitleEventArgs e)
        {
            //Task类所需要的参数：id，goodsName，type，mode，modeName，accountUserName，accountsNum，accountsList，status
            Task task = new Task();
            task.id = tb_id.Text;
            //返回的完整Title是“星梦剧院5月11日N队公演普通站票_剧场公演票务_SNH48官方周边商品商城”这样的，组成结构是“商品名字_二级分类_一级分类_”，只取商品名字即可
            task.goodsName = e.title.Substring(0, e.title.IndexOf("_"));
            //如果商品标题里含有星梦剧院，说明是门票，type是-1，否则是实物，type为5，据此自动修改类型下拉框，防止输入错误会导致后面购买失败，type在购物时影响所选择的运送方式，-1表示无需物流，5表示快递
            if (e.title.IndexOf("星梦剧院") < 0)
            {
                cb_type.SelectedIndex = 1;
                task.type = "5";
            }
            else
            {
                cb_type.SelectedIndex = 0;
                task.type = "-1";
            }           

            task.mode = cb_mode.SelectedIndex;
            task.modeName = cb_mode.SelectedItem.ToString();
            task.accountUserName = cb_accounts.SelectedItem.ToString();
            //帐号数量保证是一个非0的数字
            try
            {
                task.accountsNum = Int32.Parse(tb_accountsNum.Text);
            }
            catch (FormatException ex)
            {
                ex.ToString();
                MessageBox.Show("请输入正确的帐号数量", "提示");
                btn_addTask.Enabled = true;
                return;
            }
            task.accountsList = accountsList;
            task.status = false;
           
            rtb_taskList.AppendText(task.goodsName + '，' + task.modeName + '，' + task.accountUserName + '，' + task.accountsNum.ToString() + "个帐号抢" + '\n');
            taskList.Add(task);
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
