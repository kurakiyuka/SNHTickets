namespace SNHTickets.Panels
{
    partial class ChangeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_accounts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.ll_getOrder = new System.Windows.Forms.LinkLabel();
            this.ll_getOrderList = new System.Windows.Forms.LinkLabel();
            this.cb_orderList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "帐号";
            // 
            // cb_accounts
            // 
            this.cb_accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_accounts.FormattingEnabled = true;
            this.cb_accounts.Location = new System.Drawing.Point(80, 13);
            this.cb_accounts.Name = "cb_accounts";
            this.cb_accounts.Size = new System.Drawing.Size(121, 27);
            this.cb_accounts.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "订单号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "电话";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(80, 103);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 25);
            this.tb_name.TabIndex = 5;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(272, 103);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(100, 25);
            this.tb_tel.TabIndex = 6;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(155, 193);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 34);
            this.btn_change.TabIndex = 7;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // ll_getOrder
            // 
            this.ll_getOrder.AutoSize = true;
            this.ll_getOrder.Location = new System.Drawing.Point(250, 61);
            this.ll_getOrder.Name = "ll_getOrder";
            this.ll_getOrder.Size = new System.Drawing.Size(87, 19);
            this.ll_getOrder.TabIndex = 4;
            this.ll_getOrder.TabStop = true;
            this.ll_getOrder.Text = "获取订单信息";
            this.ll_getOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_getOrder_LinkClicked);
            // 
            // ll_getOrderList
            // 
            this.ll_getOrderList.AutoSize = true;
            this.ll_getOrderList.Location = new System.Drawing.Point(250, 16);
            this.ll_getOrderList.Name = "ll_getOrderList";
            this.ll_getOrderList.Size = new System.Drawing.Size(87, 19);
            this.ll_getOrderList.TabIndex = 2;
            this.ll_getOrderList.TabStop = true;
            this.ll_getOrderList.Text = "获取帐号订单";
            this.ll_getOrderList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_getOrderList_LinkClicked);
            // 
            // cb_orderList
            // 
            this.cb_orderList.FormattingEnabled = true;
            this.cb_orderList.Location = new System.Drawing.Point(80, 58);
            this.cb_orderList.Name = "cb_orderList";
            this.cb_orderList.Size = new System.Drawing.Size(148, 27);
            this.cb_orderList.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "地址";
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(80, 148);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(292, 25);
            this.tb_addr.TabIndex = 10;
            // 
            // ChangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(395, 250);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_orderList);
            this.Controls.Add(this.ll_getOrderList);
            this.Controls.Add(this.ll_getOrder);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_accounts);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChangeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改订单信息";
            this.Load += new System.EventHandler(this.ChangeOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_accounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.LinkLabel ll_getOrder;
        private System.Windows.Forms.LinkLabel ll_getOrderList;
        private System.Windows.Forms.ComboBox cb_orderList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_addr;
    }
}