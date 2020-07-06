namespace 软工大作业
{
    partial class Result
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Schname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Schid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbTBLPwd = new System.Windows.Forms.TextBox();
            this.btnBTL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_Schname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Schid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Schname
            // 
            this.lbl_Schname.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Schname.Location = new System.Drawing.Point(168, 52);
            this.lbl_Schname.Name = "lbl_Schname";
            this.lbl_Schname.Size = new System.Drawing.Size(64, 23);
            this.lbl_Schname.TabIndex = 4;
            this.lbl_Schname.Text = "哈哈哈";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(73, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "族 谱 ID：";
            // 
            // lbl_Schid
            // 
            this.lbl_Schid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Schid.Location = new System.Drawing.Point(168, 15);
            this.lbl_Schid.Name = "lbl_Schid";
            this.lbl_Schid.Size = new System.Drawing.Size(64, 23);
            this.lbl_Schid.TabIndex = 3;
            this.lbl_Schid.Text = "哈哈哈";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(73, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "族 谱 名：";
            // 
            // ttbTBLPwd
            // 
            this.ttbTBLPwd.Location = new System.Drawing.Point(79, 146);
            this.ttbTBLPwd.Name = "ttbTBLPwd";
            this.ttbTBLPwd.Size = new System.Drawing.Size(119, 25);
            this.ttbTBLPwd.TabIndex = 7;
            this.ttbTBLPwd.UseSystemPasswordChar = true;
            // 
            // btnBTL
            // 
            this.btnBTL.BackColor = System.Drawing.Color.White;
            this.btnBTL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBTL.Location = new System.Drawing.Point(205, 146);
            this.btnBTL.Margin = new System.Windows.Forms.Padding(4);
            this.btnBTL.Name = "btnBTL";
            this.btnBTL.Size = new System.Drawing.Size(69, 26);
            this.btnBTL.TabIndex = 8;
            this.btnBTL.Text = "进入";
            this.btnBTL.UseVisualStyleBackColor = false;
            this.btnBTL.Click += new System.EventHandler(this.btnBTL_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "密码:";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBTL);
            this.Controls.Add(this.ttbTBLPwd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Result";
            this.Size = new System.Drawing.Size(300, 200);
            this.Load += new System.EventHandler(this.Result_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbTBLPwd;
        private System.Windows.Forms.Button btnBTL;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_Schname;
        public System.Windows.Forms.Label lbl_Schid;
    }
}
