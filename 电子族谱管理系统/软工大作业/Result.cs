using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using 电子族谱管理系统;

namespace 软工大作业
{
    public partial class Result : UserControl
    {
        public string TBLid1;
        public Result()
        {
            InitializeComponent();
        }

        private void btnBTL_Click(object sender, EventArgs e)
        {
            if (ttbTBLPwd.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string connString = @"Server = .;
                                Data Source = 127.0.0.1;
                                Initial Catalog = 族谱数据库; 
                                Persist Security Info = True; 
                                User ID = sa; 
                                Password = 123456";
                String sql = @"SELECT TBL_ID,TBL_Pwd
                           FROM [TBL_family_tree]
                           WHERE TBL_ID = @TBL_ID";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@TBL_ID", SqlDbType.VarChar, 10));
                cmd.Parameters["@TBL_ID"].Value = lbl_Schid.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("用户不存在！请重新输入", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ttbTBLPwd.Text = "";
                }
                else if (reader["TBL_Pwd"].ToString().Trim() == ttbTBLPwd.Text.Trim())
                {
                    MessageBox.Show("密码正确！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TBLid1 = lbl_Schid.Text;
                    首页.TBLId = lbl_Schid.Text;
                    族谱信息 x = new 族谱信息();
                    x.TBL_ID = this.TBLid1;
                    x.ShowDialog();
                }
                else
                {
                    MessageBox.Show("密码错误！请重新输入", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ttbTBLPwd.Text = "";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
