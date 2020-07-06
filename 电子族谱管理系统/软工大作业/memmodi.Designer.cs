namespace 软工大作业
{
    partial class memmodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memmodi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.成员展示 = new System.Windows.Forms.Button();
            this.成员修改 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(597, 453);
            this.dataGridView1.TabIndex = 1;
            // 
            // 成员展示
            // 
            this.成员展示.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.成员展示.Location = new System.Drawing.Point(627, 226);
            this.成员展示.Name = "成员展示";
            this.成员展示.Size = new System.Drawing.Size(93, 36);
            this.成员展示.TabIndex = 0;
            this.成员展示.Text = "成员展示";
            this.成员展示.UseVisualStyleBackColor = false;
            this.成员展示.Click += new System.EventHandler(this.成员展示_Click);
            // 
            // 成员修改
            // 
            this.成员修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.成员修改.Location = new System.Drawing.Point(627, 323);
            this.成员修改.Name = "成员修改";
            this.成员修改.Size = new System.Drawing.Size(93, 36);
            this.成员修改.TabIndex = 2;
            this.成员修改.Text = "成员修改";
            this.成员修改.UseVisualStyleBackColor = false;
            this.成员修改.Click += new System.EventHandler(this.成员修改_Click);
            // 
            // memmodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.成员修改);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.成员展示);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "memmodi";
            this.Text = "电子族谱管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 成员展示;
        private System.Windows.Forms.Button 成员修改;
    }
}