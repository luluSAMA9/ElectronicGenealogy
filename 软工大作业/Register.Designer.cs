namespace 软工大作业
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbID = new System.Windows.Forms.TextBox();
            this.ttbPwd = new System.Windows.Forms.TextBox();
            this.ttbPwd_r = new System.Windows.Forms.TextBox();
            this.btnRsr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblID.Location = new System.Drawing.Point(170, 51);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(73, 32);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "I D";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(163, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "密码";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(116, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "确认密码";
            // 
            // ttbID
            // 
            this.ttbID.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ttbID.Location = new System.Drawing.Point(264, 49);
            this.ttbID.Margin = new System.Windows.Forms.Padding(4);
            this.ttbID.Name = "ttbID";
            this.ttbID.Size = new System.Drawing.Size(227, 34);
            this.ttbID.TabIndex = 7;
            // 
            // ttbPwd
            // 
            this.ttbPwd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ttbPwd.Location = new System.Drawing.Point(264, 124);
            this.ttbPwd.Margin = new System.Windows.Forms.Padding(4);
            this.ttbPwd.Name = "ttbPwd";
            this.ttbPwd.Size = new System.Drawing.Size(227, 34);
            this.ttbPwd.TabIndex = 8;
            this.ttbPwd.UseSystemPasswordChar = true;
            // 
            // ttbPwd_r
            // 
            this.ttbPwd_r.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ttbPwd_r.Location = new System.Drawing.Point(264, 200);
            this.ttbPwd_r.Margin = new System.Windows.Forms.Padding(4);
            this.ttbPwd_r.Name = "ttbPwd_r";
            this.ttbPwd_r.Size = new System.Drawing.Size(227, 34);
            this.ttbPwd_r.TabIndex = 9;
            this.ttbPwd_r.UseSystemPasswordChar = true;
            // 
            // btnRsr
            // 
            this.btnRsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.btnRsr.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRsr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRsr.Location = new System.Drawing.Point(263, 263);
            this.btnRsr.Margin = new System.Windows.Forms.Padding(4);
            this.btnRsr.Name = "btnRsr";
            this.btnRsr.Size = new System.Drawing.Size(228, 42);
            this.btnRsr.TabIndex = 10;
            this.btnRsr.Text = "注册";
            this.btnRsr.UseVisualStyleBackColor = false;
            this.btnRsr.Click += new System.EventHandler(this.btnRsr_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(270, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "* 不超过10位数字";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(270, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "* 不超过15位数字";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::软工大作业.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRsr);
            this.Controls.Add(this.ttbPwd_r);
            this.Controls.Add(this.ttbPwd);
            this.Controls.Add(this.ttbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbID;
        private System.Windows.Forms.TextBox ttbPwd;
        private System.Windows.Forms.TextBox ttbPwd_r;
        private System.Windows.Forms.Button btnRsr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}