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
    
    public partial class TBL_Search : Form
    {
        public Result r;
        public TBL_Search()
        {
            InitializeComponent();
        }

        private void btnSch_Click(object sender, EventArgs e)
        {
            if (ttbSch.Text.Trim() == "")
            {
                MessageBox.Show("请先输入族谱ID！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            string connString = @"Server = SQLOLEDB;
                                Data Source = .;
                                Initial Catalog = 电子族谱;
                                User ID = sa;
                                Password = woaiwo525";
            String sql = @"SELECT *
                           FROM TBL_family_tree
                           WHERE TBL_ID = " + ttbSch.Text + "";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("查询成功！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                r.lbl_Schid.Text = reader["TBL_ID"].ToString().Trim();
                r.lbl_Schname.Text= reader["TBL_name"].ToString().Trim();
                r.Show();
                groupBox.Controls.Add(r);
            }
            else
            {
                MessageBox.Show("该族谱ID不存在！", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void TBL_Search_Load(object sender, EventArgs e)
        {
            r = new Result();
        }
    }
}
