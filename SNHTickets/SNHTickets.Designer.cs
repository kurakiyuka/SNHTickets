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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAccoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAccoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuyTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(20, 45);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(48, 19);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "用户名";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(20, 90);
            this.lb_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(35, 19);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "密码";
            // 
            // snh_username
            // 
            this.snh_username.Location = new System.Drawing.Point(100, 45);
            this.snh_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.snh_username.Name = "snh_username";
            this.snh_username.Size = new System.Drawing.Size(245, 25);
            this.snh_username.TabIndex = 2;
            // 
            // snh_pw
            // 
            this.snh_pw.Location = new System.Drawing.Point(100, 90);
            this.snh_pw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.snh_pw.Name = "snh_pw";
            this.snh_pw.Size = new System.Drawing.Size(245, 25);
            this.snh_pw.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(66, 140);
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
            this.btn_buy.Location = new System.Drawing.Point(217, 140);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(100, 33);
            this.btn_buy.TabIndex = 7;
            this.btn_buy.Text = "抢票";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.buy_loop);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountsToolStripMenuItem,
            this.TaskToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccountsToolStripMenuItem
            // 
            this.AccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAccoutToolStripMenuItem,
            this.ClearAccoutToolStripMenuItem});
            this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
            this.AccountsToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.AccountsToolStripMenuItem.Text = "帐号";
            // 
            // AddAccoutToolStripMenuItem
            // 
            this.AddAccoutToolStripMenuItem.Name = "AddAccoutToolStripMenuItem";
            this.AddAccoutToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.AddAccoutToolStripMenuItem.Text = "添加帐号";
            this.AddAccoutToolStripMenuItem.Click += new System.EventHandler(this.AddAccoutToolStripMenuItem_Click);
            // 
            // ClearAccoutToolStripMenuItem
            // 
            this.ClearAccoutToolStripMenuItem.Name = "ClearAccoutToolStripMenuItem";
            this.ClearAccoutToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.ClearAccoutToolStripMenuItem.Text = "清空帐号";
            // 
            // TaskToolStripMenuItem
            // 
            this.TaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuyTaskToolStripMenuItem});
            this.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
            this.TaskToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.TaskToolStripMenuItem.Text = "任务";
            // 
            // BuyTaskToolStripMenuItem
            // 
            this.BuyTaskToolStripMenuItem.Name = "BuyTaskToolStripMenuItem";
            this.BuyTaskToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.BuyTaskToolStripMenuItem.Text = "抢票任务";
            this.BuyTaskToolStripMenuItem.Click += new System.EventHandler(this.BuyTaskToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.SettingsToolStripMenuItem.Text = "设置";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SNHTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNH48刷票器";
            this.Load += new System.EventHandler(this.SNHTickets_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAccoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearAccoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuyTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
    }
}

