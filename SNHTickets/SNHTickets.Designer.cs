namespace SNHTickets
{
    partial class SNHTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNHTickets));
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.snh_username = new System.Windows.Forms.TextBox();
            this.snh_pw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.rtb_process = new System.Windows.Forms.RichTextBox();
            this.rtb_success = new System.Windows.Forms.RichTextBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(20, 20);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(48, 19);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "用户名";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(20, 80);
            this.lb_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(35, 19);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "密码";
            // 
            // snh_username
            // 
            this.snh_username.Location = new System.Drawing.Point(100, 20);
            this.snh_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.snh_username.Name = "snh_username";
            this.snh_username.Size = new System.Drawing.Size(245, 25);
            this.snh_username.TabIndex = 2;
            // 
            // snh_pw
            // 
            this.snh_pw.Location = new System.Drawing.Point(100, 80);
            this.snh_pw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.snh_pw.Name = "snh_pw";
            this.snh_pw.Size = new System.Drawing.Size(245, 25);
            this.snh_pw.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(100, 140);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 33);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.login);
            // 
            // rtb_process
            // 
            this.rtb_process.BackColor = System.Drawing.SystemColors.Info;
            this.rtb_process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_process.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_process.Location = new System.Drawing.Point(24, 206);
            this.rtb_process.Name = "rtb_process";
            this.rtb_process.ReadOnly = true;
            this.rtb_process.Size = new System.Drawing.Size(350, 320);
            this.rtb_process.TabIndex = 5;
            this.rtb_process.Text = "";
            // 
            // rtb_success
            // 
            this.rtb_success.BackColor = System.Drawing.SystemColors.Info;
            this.rtb_success.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_success.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_success.Location = new System.Drawing.Point(396, 206);
            this.rtb_success.Name = "rtb_success";
            this.rtb_success.ReadOnly = true;
            this.rtb_success.Size = new System.Drawing.Size(350, 320);
            this.rtb_success.TabIndex = 6;
            this.rtb_success.Text = "";
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(520, 140);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(100, 33);
            this.btn_buy.TabIndex = 7;
            this.btn_buy.Text = "抢票";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.buy_loop);
            // 
            // SNHTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.rtb_success);
            this.Controls.Add(this.rtb_process);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.snh_pw);
            this.Controls.Add(this.snh_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SNHTickets";
            this.Text = "SNH48刷票器";
            this.Load += new System.EventHandler(this.SNHTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox snh_username;
        private System.Windows.Forms.TextBox snh_pw;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.RichTextBox rtb_process;
        private System.Windows.Forms.RichTextBox rtb_success;
        private System.Windows.Forms.Button btn_buy;
    }
}

