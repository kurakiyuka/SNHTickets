namespace SNHT_1
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccontsToolStripMenuItem,
            this.TaskToolStripMenuItem,
            this.UsageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TaskToolStripMenuItem
            // 
            this.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
            this.TaskToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.TaskToolStripMenuItem.Text = "任务";
            // 
            // UsageToolStripMenuItem
            // 
            this.UsageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeOrderToolStripMenuItem});
            this.UsageToolStripMenuItem.Name = "UsageToolStripMenuItem";
            this.UsageToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.UsageToolStripMenuItem.Text = "工具";
            // 
            // ChangeOrderToolStripMenuItem
            // 
            this.ChangeOrderToolStripMenuItem.Name = "ChangeOrderToolStripMenuItem";
            this.ChangeOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ChangeOrderToolStripMenuItem.Text = "修改订单信息";
            // 
            // AccontsToolStripMenuItem
            // 
            this.AccontsToolStripMenuItem.Name = "AccontsToolStripMenuItem";
            this.AccontsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.AccontsToolStripMenuItem.Text = "帐号";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNH48";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccontsToolStripMenuItem;
    }
}

