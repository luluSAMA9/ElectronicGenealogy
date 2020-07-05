namespace 软工大作业
{
    partial class 首页
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(首页));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslMyTBL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSign = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslRsr = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.btnCreate.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreate.Location = new System.Drawing.Point(24, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(166, 119);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "创建族谱";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.btnSearch.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Location = new System.Drawing.Point(24, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 119);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "查找族谱";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl,
            this.toolStripSeparator1,
            this.tslMyTBL,
            this.toolStripSeparator2,
            this.tslSign,
            this.toolStripSeparator3,
            this.tslRsr});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 49);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsl
            // 
            this.tsl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsl.Image = ((System.Drawing.Image)(resources.GetObject("tsl.Image")));
            this.tsl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tsl.Name = "tsl";
            this.tsl.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsl.Size = new System.Drawing.Size(169, 46);
            this.tsl.Text = "电子族谱管理系统";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // tslMyTBL
            // 
            this.tslMyTBL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslMyTBL.Image = ((System.Drawing.Image)(resources.GetObject("tslMyTBL.Image")));
            this.tslMyTBL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslMyTBL.Name = "tslMyTBL";
            this.tslMyTBL.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.tslMyTBL.Size = new System.Drawing.Size(133, 46);
            this.tslMyTBL.Text = "我的族谱";
            this.tslMyTBL.Click += new System.EventHandler(this.tslMyTBL_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // tslSign
            // 
            this.tslSign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslSign.Image = ((System.Drawing.Image)(resources.GetObject("tslSign.Image")));
            this.tslSign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslSign.Name = "tslSign";
            this.tslSign.Padding = new System.Windows.Forms.Padding(42, 0, 42, 0);
            this.tslSign.Size = new System.Drawing.Size(127, 46);
            this.tslSign.Text = "登录";
            this.tslSign.Click += new System.EventHandler(this.tslSign_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // tslRsr
            // 
            this.tslRsr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslRsr.Image = ((System.Drawing.Image)(resources.GetObject("tslRsr.Image")));
            this.tslRsr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslRsr.Name = "tslRsr";
            this.tslRsr.Padding = new System.Windows.Forms.Padding(42, 0, 42, 0);
            this.tslRsr.Size = new System.Drawing.Size(127, 46);
            this.tslRsr.Text = "注册";
            this.tslRsr.Click += new System.EventHandler(this.tslRsr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(95, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 159);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(412, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 159);
            this.panel2.TabIndex = 4;
            // 
            // 首页
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::软工大作业.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "首页";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "首页";
            this.Load += new System.EventHandler(this.首页_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsl;
        private System.Windows.Forms.ToolStripButton tslMyTBL;
        private System.Windows.Forms.ToolStripButton tslRsr;
        public System.Windows.Forms.ToolStripButton tslSign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

