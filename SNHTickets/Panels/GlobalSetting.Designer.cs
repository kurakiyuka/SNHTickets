namespace SNHTickets.Panels
{
    partial class GlobalSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_stand_ticket_limit = new System.Windows.Forms.TextBox();
            this.tb_max_limit = new System.Windows.Forms.TextBox();
            this.tb_photo_limit = new System.Windows.Forms.TextBox();
            this.tb_vip_ticket_limit = new System.Windows.Forms.TextBox();
            this.tb_vip_ticket_d1_limit = new System.Windows.Forms.TextBox();
            this.tb_sit_ticket_limit = new System.Windows.Forms.TextBox();
            this.btn_Save_Setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "站票限购";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "座票限购";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "VIP首日限购";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "VIP次日限购";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "生写限购";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "最大限购";
            // 
            // tb_stand_ticket_limit
            // 
            this.tb_stand_ticket_limit.Location = new System.Drawing.Point(140, 15);
            this.tb_stand_ticket_limit.Name = "tb_stand_ticket_limit";
            this.tb_stand_ticket_limit.Size = new System.Drawing.Size(100, 25);
            this.tb_stand_ticket_limit.TabIndex = 6;
            // 
            // tb_max_limit
            // 
            this.tb_max_limit.Location = new System.Drawing.Point(140, 190);
            this.tb_max_limit.Name = "tb_max_limit";
            this.tb_max_limit.Size = new System.Drawing.Size(100, 25);
            this.tb_max_limit.TabIndex = 7;
            // 
            // tb_photo_limit
            // 
            this.tb_photo_limit.Location = new System.Drawing.Point(140, 155);
            this.tb_photo_limit.Name = "tb_photo_limit";
            this.tb_photo_limit.Size = new System.Drawing.Size(100, 25);
            this.tb_photo_limit.TabIndex = 8;
            // 
            // tb_vip_ticket_limit
            // 
            this.tb_vip_ticket_limit.Location = new System.Drawing.Point(140, 120);
            this.tb_vip_ticket_limit.Name = "tb_vip_ticket_limit";
            this.tb_vip_ticket_limit.Size = new System.Drawing.Size(100, 25);
            this.tb_vip_ticket_limit.TabIndex = 9;
            // 
            // tb_vip_ticket_d1_limit
            // 
            this.tb_vip_ticket_d1_limit.Location = new System.Drawing.Point(140, 85);
            this.tb_vip_ticket_d1_limit.Name = "tb_vip_ticket_d1_limit";
            this.tb_vip_ticket_d1_limit.Size = new System.Drawing.Size(100, 25);
            this.tb_vip_ticket_d1_limit.TabIndex = 10;
            // 
            // tb_sit_ticket_limit
            // 
            this.tb_sit_ticket_limit.Location = new System.Drawing.Point(140, 50);
            this.tb_sit_ticket_limit.Name = "tb_sit_ticket_limit";
            this.tb_sit_ticket_limit.Size = new System.Drawing.Size(100, 25);
            this.tb_sit_ticket_limit.TabIndex = 11;
            // 
            // btn_Save_Setting
            // 
            this.btn_Save_Setting.Location = new System.Drawing.Point(154, 244);
            this.btn_Save_Setting.Name = "btn_Save_Setting";
            this.btn_Save_Setting.Size = new System.Drawing.Size(75, 30);
            this.btn_Save_Setting.TabIndex = 12;
            this.btn_Save_Setting.Text = "保存";
            this.btn_Save_Setting.UseVisualStyleBackColor = true;
            this.btn_Save_Setting.Click += new System.EventHandler(this.btn_Save_Setting_Click);
            // 
            // GlobalSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 298);
            this.Controls.Add(this.btn_Save_Setting);
            this.Controls.Add(this.tb_sit_ticket_limit);
            this.Controls.Add(this.tb_vip_ticket_d1_limit);
            this.Controls.Add(this.tb_vip_ticket_limit);
            this.Controls.Add(this.tb_photo_limit);
            this.Controls.Add(this.tb_max_limit);
            this.Controls.Add(this.tb_stand_ticket_limit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GlobalSetting";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.GlobalSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_stand_ticket_limit;
        private System.Windows.Forms.TextBox tb_max_limit;
        private System.Windows.Forms.TextBox tb_photo_limit;
        private System.Windows.Forms.TextBox tb_vip_ticket_limit;
        private System.Windows.Forms.TextBox tb_vip_ticket_d1_limit;
        private System.Windows.Forms.TextBox tb_sit_ticket_limit;
        private System.Windows.Forms.Button btn_Save_Setting;
    }
}