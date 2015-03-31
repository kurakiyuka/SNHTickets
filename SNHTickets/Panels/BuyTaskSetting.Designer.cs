namespace SNHTickets.Panels
{
    partial class BuyTaskSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTaskSetting));
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_mode = new System.Windows.Forms.Label();
            this.cb_mode = new System.Windows.Forms.ComboBox();
            this.lb_accountsNum = new System.Windows.Forms.Label();
            this.tb_accountsNum = new System.Windows.Forms.TextBox();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.rtb_taskList = new System.Windows.Forms.RichTextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.btn_fin = new System.Windows.Forms.Button();
            this.lb_account = new System.Windows.Forms.Label();
            this.cb_accounts = new System.Windows.Forms.ComboBox();
            this.lb_delay = new System.Windows.Forms.Label();
            this.cb_delay = new System.Windows.Forms.ComboBox();
            this.lb_totalNum = new System.Windows.Forms.Label();
            this.tb_totalNum = new System.Windows.Forms.TextBox();
            this.lb_onetime = new System.Windows.Forms.Label();
            this.cb_onetime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(15, 15);
            this.lb_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(49, 19);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "商品ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(95, 15);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 25);
            this.tb_id.TabIndex = 1;
            // 
            // lb_mode
            // 
            this.lb_mode.AutoSize = true;
            this.lb_mode.Location = new System.Drawing.Point(15, 60);
            this.lb_mode.Name = "lb_mode";
            this.lb_mode.Size = new System.Drawing.Size(61, 19);
            this.lb_mode.TabIndex = 4;
            this.lb_mode.Text = "购买模式";
            // 
            // cb_mode
            // 
            this.cb_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mode.FormattingEnabled = true;
            this.cb_mode.Items.AddRange(new object[] {
            "实名帐号",
            "指定帐号",
            "随机大号",
            "随机小号"});
            this.cb_mode.Location = new System.Drawing.Point(95, 58);
            this.cb_mode.Name = "cb_mode";
            this.cb_mode.Size = new System.Drawing.Size(121, 27);
            this.cb_mode.TabIndex = 5;
            // 
            // lb_accountsNum
            // 
            this.lb_accountsNum.AutoSize = true;
            this.lb_accountsNum.Location = new System.Drawing.Point(15, 105);
            this.lb_accountsNum.Name = "lb_accountsNum";
            this.lb_accountsNum.Size = new System.Drawing.Size(48, 19);
            this.lb_accountsNum.TabIndex = 8;
            this.lb_accountsNum.Text = "帐号数";
            // 
            // tb_accountsNum
            // 
            this.tb_accountsNum.Location = new System.Drawing.Point(95, 105);
            this.tb_accountsNum.Name = "tb_accountsNum";
            this.tb_accountsNum.Size = new System.Drawing.Size(100, 25);
            this.tb_accountsNum.TabIndex = 9;
            // 
            // btn_addTask
            // 
            this.btn_addTask.Location = new System.Drawing.Point(141, 194);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(75, 34);
            this.btn_addTask.TabIndex = 16;
            this.btn_addTask.Text = "添加";
            this.btn_addTask.UseVisualStyleBackColor = true;
            this.btn_addTask.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // rtb_taskList
            // 
            this.rtb_taskList.BackColor = System.Drawing.SystemColors.Info;
            this.rtb_taskList.Location = new System.Drawing.Point(19, 246);
            this.rtb_taskList.Name = "rtb_taskList";
            this.rtb_taskList.ReadOnly = true;
            this.rtb_taskList.Size = new System.Drawing.Size(446, 108);
            this.rtb_taskList.TabIndex = 18;
            this.rtb_taskList.Text = "";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "门票",
            "实物"});
            this.cb_type.Location = new System.Drawing.Point(320, 13);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 27);
            this.cb_type.TabIndex = 3;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(240, 15);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(61, 19);
            this.lb_type.TabIndex = 2;
            this.lb_type.Text = "商品类型";
            // 
            // btn_fin
            // 
            this.btn_fin.Location = new System.Drawing.Point(244, 194);
            this.btn_fin.Name = "btn_fin";
            this.btn_fin.Size = new System.Drawing.Size(75, 34);
            this.btn_fin.TabIndex = 17;
            this.btn_fin.Text = "完成";
            this.btn_fin.UseVisualStyleBackColor = true;
            this.btn_fin.Click += new System.EventHandler(this.btn_fin_Click);
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Location = new System.Drawing.Point(240, 60);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(61, 19);
            this.lb_account.TabIndex = 6;
            this.lb_account.Text = "购买帐号";
            // 
            // cb_accounts
            // 
            this.cb_accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_accounts.FormattingEnabled = true;
            this.cb_accounts.Location = new System.Drawing.Point(320, 58);
            this.cb_accounts.Name = "cb_accounts";
            this.cb_accounts.Size = new System.Drawing.Size(121, 27);
            this.cb_accounts.TabIndex = 7;
            // 
            // lb_delay
            // 
            this.lb_delay.AutoSize = true;
            this.lb_delay.Location = new System.Drawing.Point(240, 150);
            this.lb_delay.Name = "lb_delay";
            this.lb_delay.Size = new System.Drawing.Size(79, 19);
            this.lb_delay.TabIndex = 14;
            this.lb_delay.Text = "延迟（ms）";
            // 
            // cb_delay
            // 
            this.cb_delay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_delay.FormattingEnabled = true;
            this.cb_delay.Items.AddRange(new object[] {
            "0",
            "100",
            "300",
            "1000",
            "3000",
            "8000"});
            this.cb_delay.Location = new System.Drawing.Point(320, 148);
            this.cb_delay.Name = "cb_delay";
            this.cb_delay.Size = new System.Drawing.Size(121, 27);
            this.cb_delay.TabIndex = 15;
            // 
            // lb_totalNum
            // 
            this.lb_totalNum.AutoSize = true;
            this.lb_totalNum.Location = new System.Drawing.Point(240, 105);
            this.lb_totalNum.Name = "lb_totalNum";
            this.lb_totalNum.Size = new System.Drawing.Size(61, 19);
            this.lb_totalNum.TabIndex = 10;
            this.lb_totalNum.Text = "购买总数";
            // 
            // tb_totalNum
            // 
            this.tb_totalNum.Location = new System.Drawing.Point(320, 105);
            this.tb_totalNum.Name = "tb_totalNum";
            this.tb_totalNum.Size = new System.Drawing.Size(100, 25);
            this.tb_totalNum.TabIndex = 11;
            // 
            // lb_onetime
            // 
            this.lb_onetime.AutoSize = true;
            this.lb_onetime.Location = new System.Drawing.Point(15, 150);
            this.lb_onetime.Name = "lb_onetime";
            this.lb_onetime.Size = new System.Drawing.Size(61, 19);
            this.lb_onetime.TabIndex = 12;
            this.lb_onetime.Text = "单次购买";
            // 
            // cb_onetime
            // 
            this.cb_onetime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_onetime.FormattingEnabled = true;
            this.cb_onetime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "14",
            "20",
            "21",
            "42"});
            this.cb_onetime.Location = new System.Drawing.Point(95, 148);
            this.cb_onetime.Name = "cb_onetime";
            this.cb_onetime.Size = new System.Drawing.Size(121, 27);
            this.cb_onetime.TabIndex = 13;
            // 
            // BuyTaskSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(483, 370);
            this.Controls.Add(this.cb_onetime);
            this.Controls.Add(this.lb_onetime);
            this.Controls.Add(this.tb_totalNum);
            this.Controls.Add(this.lb_totalNum);
            this.Controls.Add(this.cb_delay);
            this.Controls.Add(this.lb_delay);
            this.Controls.Add(this.cb_accounts);
            this.Controls.Add(this.lb_account);
            this.Controls.Add(this.btn_fin);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.rtb_taskList);
            this.Controls.Add(this.btn_addTask);
            this.Controls.Add(this.tb_accountsNum);
            this.Controls.Add(this.lb_accountsNum);
            this.Controls.Add(this.cb_mode);
            this.Controls.Add(this.lb_mode);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BuyTaskSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置购买任务";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyTaskSetting_FormClosing);
            this.Load += new System.EventHandler(this.BuyTaskSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_mode;
        private System.Windows.Forms.ComboBox cb_mode;
        private System.Windows.Forms.Label lb_accountsNum;
        private System.Windows.Forms.TextBox tb_accountsNum;
        private System.Windows.Forms.Button btn_addTask;
        private System.Windows.Forms.RichTextBox rtb_taskList;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Button btn_fin;
        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.ComboBox cb_accounts;
        private System.Windows.Forms.Label lb_delay;
        private System.Windows.Forms.ComboBox cb_delay;
        private System.Windows.Forms.Label lb_totalNum;
        private System.Windows.Forms.TextBox tb_totalNum;
        private System.Windows.Forms.Label lb_onetime;
        private System.Windows.Forms.ComboBox cb_onetime;
    }
}