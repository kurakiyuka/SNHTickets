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
            this.cb_orders = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
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
            this.cb_accounts.Location = new System.Drawing.Point(80, 15);
            this.cb_accounts.Name = "cb_accounts";
            this.cb_accounts.Size = new System.Drawing.Size(121, 27);
            this.cb_accounts.TabIndex = 1;
            this.cb_accounts.SelectedIndexChanged += new System.EventHandler(this.cb_accounts_SelectedIndexChanged);
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
            // cb_orders
            // 
            this.cb_orders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_orders.FormattingEnabled = true;
            this.cb_orders.Location = new System.Drawing.Point(80, 60);
            this.cb_orders.Name = "cb_orders";
            this.cb_orders.Size = new System.Drawing.Size(121, 27);
            this.cb_orders.TabIndex = 3;
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
            this.tb_name.Location = new System.Drawing.Point(80, 105);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 25);
            this.tb_name.TabIndex = 6;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(272, 105);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(100, 25);
            this.tb_tel.TabIndex = 7;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(155, 151);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 34);
            this.btn_change.TabIndex = 8;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            // 
            // ChangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(395, 206);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_orders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_accounts);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox cb_orders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Button btn_change;
    }
}