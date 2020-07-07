namespace find
{
    partial class find1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(find1));
            this.label1 = new System.Windows.Forms.Label();
            this.ID_value = new System.Windows.Forms.TextBox();
            this.find_branch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.find_clan = new System.Windows.Forms.Button();
            this.find_member = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(129, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID";
            // 
            // ID_value
            // 
            this.ID_value.Location = new System.Drawing.Point(507, 73);
            this.ID_value.Margin = new System.Windows.Forms.Padding(2);
            this.ID_value.Name = "ID_value";
            this.ID_value.Size = new System.Drawing.Size(197, 25);
            this.ID_value.TabIndex = 1;
            this.ID_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // find_branch
            // 
            this.find_branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.find_branch.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.find_branch.Location = new System.Drawing.Point(193, 330);
            this.find_branch.Margin = new System.Windows.Forms.Padding(2);
            this.find_branch.Name = "find_branch";
            this.find_branch.Size = new System.Drawing.Size(151, 51);
            this.find_branch.TabIndex = 2;
            this.find_branch.Text = "查询分支";
            this.find_branch.UseVisualStyleBackColor = false;
            this.find_branch.Click += new System.EventHandler(this.find_branch_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(495, 424);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // find_clan
            // 
            this.find_clan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.find_clan.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.find_clan.Location = new System.Drawing.Point(193, 424);
            this.find_clan.Margin = new System.Windows.Forms.Padding(2);
            this.find_clan.Name = "find_clan";
            this.find_clan.Size = new System.Drawing.Size(151, 51);
            this.find_clan.TabIndex = 4;
            this.find_clan.Text = "查询近亲";
            this.find_clan.UseVisualStyleBackColor = false;
            this.find_clan.Click += new System.EventHandler(this.find_clan_Click);
            // 
            // find_member
            // 
            this.find_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.find_member.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.find_member.Location = new System.Drawing.Point(495, 330);
            this.find_member.Margin = new System.Windows.Forms.Padding(2);
            this.find_member.Name = "find_member";
            this.find_member.Size = new System.Drawing.Size(148, 51);
            this.find_member.TabIndex = 5;
            this.find_member.Text = "查询成员";
            this.find_member.UseVisualStyleBackColor = false;
            this.find_member.Click += new System.EventHandler(this.find_member_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.Size = new System.Drawing.Size(570, 193);
            this.dataGridView1.TabIndex = 6;
            // 
            // find1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(852, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.find_member);
            this.Controls.Add(this.find_clan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.find_branch);
            this.Controls.Add(this.ID_value);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "find1";
            this.Text = "查询成员";
            this.Load += new System.EventHandler(this.find_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_value;
        private System.Windows.Forms.Button find_branch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button find_clan;
        private System.Windows.Forms.Button find_member;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

