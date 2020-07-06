using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRsr_Click(object sender, EventArgs e)
        {
            if (ttbPwd.Text != ttbPwd_r.Text)
            {
                MessageBox.Show("前后密码不一致！请重新输入", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ttbPwd_r.Text = "";
            }
            else if (ttbID.Text.Trim() == "" || ttbPwd.Text.Trim() == "" || ttbPwd_r.Text.Trim() == "")
            {
                MessageBox.Show("请完善信息！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //连接数据库
            string connString = @"Server = SQLOLEDB;
                                Data Source = .;
                                Initial Catalog = 电子族谱;
                                User ID = sa;
                                Password = woaiwo525";
            //构造SQL命令
            StringBuilder sb = new StringBuilder();
            sb.Append(@"INSERT INTO [Users](ID,User_password)VALUES(");
            sb.Append("'" + ttbID.Text + "',");
            sb.Append("'" + ttbPwd.Text + "')");
            string sql = sb.ToString();
            //连接数据库
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //下达命令
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("注册成功！", "提示");
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show("ERROR!\n出错原因：" + msg.Message);
            }
            conn.Close();
        }
    }
}
