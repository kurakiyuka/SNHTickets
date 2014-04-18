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
            this.rtb_statics = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_tasklist = new System.Windows.Forms.RichTextBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_process
            // 
            this.rtb_process.BackColor = System.Drawing.SystemColors.Info;
            this.rtb_process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_process.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_process.Location = new System.Drawing.Point(12, 206);
            this.rtb_process.Name = "rtb_process";
            this.rtb_process.ReadOnly = true;
            this.rtb_process.Size = new System.Drawing.Size(378, 344);
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
            this.rtb_success.Size = new System.Drawing.Size(376, 217);
            this.rtb_success.TabIndex = 6;
            this.rtb_success.Text = "";
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(462, 101);
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
            // rtb_statics
            // 
            this.rtb_statics.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_statics.Location = new System.Drawing.Point(396, 449);
            this.rtb_statics.Name = "rtb_statics";
            this.rtb_statics.ReadOnly = true;
            this.rtb_statics.Size = new System.Drawing.Size(376, 101);
            this.rtb_statics.TabIndex = 11;
            this.rtb_statics.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "错误信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "成功信息：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "统计信息：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "任务信息：";
            // 
            // rtb_tasklist
            // 
            this.rtb_tasklist.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_tasklist.Location = new System.Drawing.Point(13, 63);
            this.rtb_tasklist.Name = "rtb_tasklist";
            this.rtb_tasklist.ReadOnly = true;
            this.rtb_tasklist.Size = new System.Drawing.Size(377, 110);
            this.rtb_tasklist.TabIndex = 16;
            this.rtb_tasklist.Text = "";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(613, 101);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 33);
            this.btn_stop.TabIndex = 17;
            this.btn_stop.Text = "中止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // SNHTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.rtb_tasklist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_statics);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.rtb_success);
            this.Controls.Add(this.rtb_process);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SNHTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNH48抢票器";
            this.Load += new System.EventHandler(this.SNHTickets_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.RichTextBox rtb_statics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_tasklist;
        private System.Windows.Forms.Button btn_stop;
    }
}

