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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labsearchNum = new System.Windows.Forms.Label();
            this.txtSearchNum = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增合同ToolStripMenuItem,
            this.图表统计ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增合同ToolStripMenuItem
            // 
            this.新增合同ToolStripMenuItem.Name = "新增合同ToolStripMenuItem";
            this.新增合同ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.新增合同ToolStripMenuItem.Text = "新增合同";
            this.新增合同ToolStripMenuItem.Click += new System.EventHandler(this.新增合同ToolStripMenuItem_Click);
            // 
            // 图表统计ToolStripMenuItem
            // 
            this.图表统计ToolStripMenuItem.Name = "图表统计ToolStripMenuItem";
            this.图表统计ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.图表统计ToolStripMenuItem.Text = "图表统计";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(990, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "连接数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 431);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchNum);
            this.groupBox1.Controls.Add(this.labsearchNum);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // labsearchNum
            // 
            this.labsearchNum.AutoSize = true;
            this.labsearchNum.Location = new System.Drawing.Point(7, 21);
            this.labsearchNum.Name = "labsearchNum";
            this.labsearchNum.Size = new System.Drawing.Size(59, 12);
            this.labsearchNum.TabIndex = 0;
            this.labsearchNum.Text = "合同编号:";
            // 
            // txtSearchNum
            // 
            this.txtSearchNum.Location = new System.Drawing.Point(66, 18);
            this.txtSearchNum.Name = "txtSearchNum";
            this.txtSearchNum.Size = new System.Drawing.Size(100, 21);
            this.txtSearchNum.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "合同管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增合同ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图表统计ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labsearchNum;
        private System.Windows.Forms.TextBox txtSearchNum;
    }
}

