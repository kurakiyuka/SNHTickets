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
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_model = new System.Windows.Forms.Label();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.lb_accounts_num = new System.Windows.Forms.Label();
            this.tb_accouts_num = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.rtb_task = new System.Windows.Forms.RichTextBox();
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
            // lb_model
            // 
            this.lb_model.AutoSize = true;
            this.lb_model.Location = new System.Drawing.Point(15, 60);
            this.lb_model.Name = "lb_model";
            this.lb_model.Size = new System.Drawing.Size(61, 19);
            this.lb_model.TabIndex = 2;
            this.lb_model.Text = "购买模式";
            // 
            // cb_model
            // 
            this.cb_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Items.AddRange(new object[] {
            "捡漏模式",
            "定量模式",
            "狂买模式"});
            this.cb_model.Location = new System.Drawing.Point(95, 60);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(121, 27);
            this.cb_model.TabIndex = 3;
            this.cb_model.SelectedIndex = 0;
            // 
            // lb_accounts_num
            // 
            this.lb_accounts_num.AutoSize = true;
            this.lb_accounts_num.Location = new System.Drawing.Point(15, 105);
            this.lb_accounts_num.Name = "lb_accounts_num";
            this.lb_accounts_num.Size = new System.Drawing.Size(48, 19);
            this.lb_accounts_num.TabIndex = 4;
            this.lb_accounts_num.Text = "帐号数";
            // 
            // tb_accouts_num
            // 
            this.tb_accouts_num.Location = new System.Drawing.Point(95, 105);
            this.tb_accouts_num.Name = "tb_accouts_num";
            this.tb_accouts_num.Size = new System.Drawing.Size(100, 25);
            this.tb_accouts_num.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(69, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 34);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // rtb_task
            // 
            this.rtb_task.BackColor = System.Drawing.SystemColors.Info;
            this.rtb_task.Location = new System.Drawing.Point(260, 15);
            this.rtb_task.Name = "rtb_task";
            this.rtb_task.ReadOnly = true;
            this.rtb_task.Size = new System.Drawing.Size(312, 186);
            this.rtb_task.TabIndex = 7;
            this.rtb_task.Text = "";
            // 
            // BuyTaskSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 213);
            this.Controls.Add(this.rtb_task);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_accouts_num);
            this.Controls.Add(this.lb_accounts_num);
            this.Controls.Add(this.cb_model);
            this.Controls.Add(this.lb_model);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "BuyTaskSetting";
            this.Text = "设置购买任务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_model;
        private System.Windows.Forms.ComboBox cb_model;
        private System.Windows.Forms.Label lb_accounts_num;
        private System.Windows.Forms.TextBox tb_accouts_num;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RichTextBox rtb_task;
    }
}