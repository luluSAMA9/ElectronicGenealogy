﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 软工大作业
{
    
    public partial class Login : Form
    {
        public string id;
        public Login()
        {
            InitializeComponent();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void lblPwd_Click(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (ttbID.Text.Trim() == "")
            {
                MessageBox.Show("ID不能为空！请重新输入！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (ttbPwd.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！请重新输入！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string connString = @"Server = .;
                                Data Source = 127.0.0.1;
                                Initial Catalog = 族谱数据库; 
                                Persist Security Info = True; 
                                User ID = sa; 
                                Password = 123456";
                String sql = @"SELECT ID,User_password
                           FROM [Users]
                           WHERE ID = @ID";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.VarChar, 10));
                cmd.Parameters["@ID"].Value = ttbID.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("用户不存在！请重新输入", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ttbID.Text = "";
                    ttbPwd.Text = "";
                }
                else if (reader["User_password"].ToString().Trim() == ttbPwd.Text.Trim())
                {
                    id = ttbID.Text;
                    首页.UserId = ttbID.Text;
                    MessageBox.Show("登录成功！", "提示");
                    this.DialogResult = DialogResult.OK;
                    首页 f1 = new 首页();
                    首页.TBLId = this.id;
                    f1.Show();
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误！请重新输入", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ttbID.Text = "";
                    ttbPwd.Text = "";
                }
            }
        }

        private void btnRsr_Click(object sender, EventArgs e)
        {
            Register r = new Register();
           // this.Close();
            r.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ttbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
