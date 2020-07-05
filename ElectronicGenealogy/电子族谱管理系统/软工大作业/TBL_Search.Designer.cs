namespace 软工大作业
{
    partial class TBL_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBL_Search));
            this.ttbSch = new System.Windows.Forms.TextBox();
            this.btnSch = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // ttbSch
            // 
            this.ttbSch.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ttbSch.Location = new System.Drawing.Point(193, 74);
            this.ttbSch.Margin = new System.Windows.Forms.Padding(4);
            this.ttbSch.Name = "ttbSch";
            this.ttbSch.Size = new System.Drawing.Size(227, 34);
            this.ttbSch.TabIndex = 1;
            // 
            // btnSch
            // 
            this.btnSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.btnSch.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSch.Location = new System.Drawing.Point(428, 71);
            this.btnSch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSch.Name = "btnSch";
            this.btnSch.Size = new System.Drawing.Size(85, 40);
            this.btnSch.TabIndex = 7;
            this.btnSch.Text = "搜索";
            this.btnSch.UseVisualStyleBackColor = false;
            this.btnSch.Click += new System.EventHandler(this.btnSch_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox.Location = new System.Drawing.Point(166, 145);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(400, 248);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            // 
            // TBL_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::软工大作业.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnSch);
            this.Controls.Add(this.ttbSch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBL_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "族谱查询";
            this.Load += new System.EventHandler(this.TBL_Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox ttbSch;
        private System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.Button btnSch;
    }
}