namespace 软工大作业
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ttbID = new System.Windows.Forms.TextBox();
            this.ttbPwd = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnRsr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttbID
            // 
            this.ttbID.BackColor = System.Drawing.SystemColors.Window;
            this.ttbID.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ttbID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ttbID.Location = new System.Drawing.Point(222, 87);
            this.ttbID.Margin = new System.Windows.Forms.Padding(4);
            this.ttbID.Name = "ttbID";
            this.ttbID.Size = new System.Drawing.Size(227, 34);
            this.ttbID.TabIndex = 0;
            this.ttbID.TextChanged += new System.EventHandler(this.ttbID_TextChanged);
            // 
            // ttbPwd
            // 
            this.ttbPwd.BackColor = System.Drawing.SystemColors.Window;
            this.ttbPwd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ttbPwd.Location = new System.Drawing.Point(222, 174);
            this.ttbPwd.Margin = new System.Windows.Forms.Padding(4);
            this.ttbPwd.Name = "ttbPwd";
            this.ttbPwd.Size = new System.Drawing.Size(227, 34);
            this.ttbPwd.TabIndex = 1;
            this.ttbPwd.UseSystemPasswordChar = true;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblID.Location = new System.Drawing.Point(141, 89);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(73, 32);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "I D";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(135, 176);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(73, 32);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "密码";
            this.lblPwd.Click += new System.EventHandler(this.lblPwd_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.btnSign.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSign.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSign.Location = new System.Drawing.Point(221, 267);
            this.btnSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(228, 42);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "登录";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnRsr
            // 
            this.btnRsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.btnRsr.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRsr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRsr.Location = new System.Drawing.Point(513, 267);
            this.btnRsr.Margin = new System.Windows.Forms.Padding(4);
            this.btnRsr.Name = "btnRsr";
            this.btnRsr.Size = new System.Drawing.Size(85, 42);
            this.btnRsr.TabIndex = 6;
            this.btnRsr.Text = "注册";
            this.btnRsr.UseVisualStyleBackColor = false;
            this.btnRsr.Click += new System.EventHandler(this.btnRsr_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(132)))), ((int)(((byte)(82)))));
            this.BackgroundImage = global::软工大作业.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.btnRsr);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.ttbPwd);
            this.Controls.Add(this.ttbID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ttbID;
        private System.Windows.Forms.TextBox ttbPwd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnRsr;
    }
}