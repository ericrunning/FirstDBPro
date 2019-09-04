namespace UItoDB
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新增合同ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图表统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增合同ToolStripMenuItem,
            this.图表统计ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1632, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增合同ToolStripMenuItem
            // 
            this.新增合同ToolStripMenuItem.Name = "新增合同ToolStripMenuItem";
            this.新增合同ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.新增合同ToolStripMenuItem.Text = "合同管理";
            this.新增合同ToolStripMenuItem.Click += new System.EventHandler(this.新增合同ToolStripMenuItem_Click);
            // 
            // 图表统计ToolStripMenuItem
            // 
            this.图表统计ToolStripMenuItem.Name = "图表统计ToolStripMenuItem";
            this.图表统计ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.图表统计ToolStripMenuItem.Text = "图表统计";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "连接数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 815);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "合同管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增合同ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图表统计ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

