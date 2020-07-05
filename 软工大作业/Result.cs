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

namespace 软工大作业
{
    public partial class Result : UserControl
    {
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
                string connString = @"Server = SQLOLEDB;
                                Data Source = .;
                                Initial Catalog = 电子族谱;
                                User ID = sa;
                                Password = woaiwo525";
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
                    首页.TBLId = lbl_Schid.Text;
                //    族谱信息 x = new 族谱信息();
                //    x.ShowDialog();
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
    }
}
