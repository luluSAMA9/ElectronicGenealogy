using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 软工大作业
{
    public partial class memchange : Form
    {
        public string memberid;
        public memchange()
        {
            InitializeComponent2();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string memid = this.IDreceive.Text;
            memberid = memid;
            if (memid.Equals(""))
            {
                MessageBox.Show("ID不能为空");
            }
            else
            {
                string connString = @"Server = .;
                                Data Source = 127.0.0.1;
                                Initial Catalog = 族谱数据库; 
                                Persist Security Info = True; 
                                User ID = sa; 
                                Password = 123456"; 
                SqlConnection SqlCon = new SqlConnection(connString); //数据库连接
                SqlCon.Open(); //打开数据库
                string sql = "Select * from 成员表 where M_ID=" + memid;//查找用户sql语句
                SqlCommand cmd = new SqlCommand(sql, SqlCon);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (sdr.Read())         //从结果中找到
                {
                    MessageBox.Show("成功定位成员", "提示");
                    memchange2 memchange2 = new memchange2();
                    memchange2.memberid2 = this.memberid;
                    memchange2.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("ID错误", "提示");
                    return;
                }
            }
          }

        private void InitializeComponent2()
        {
            this.SuspendLayout();
            // 
            // memchange
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "memchange";
            this.Load += new System.EventHandler(this.memchange_Load);
            this.ResumeLayout(false);

        }

        private void memchange_Load(object sender, EventArgs e)
        {

        }
    }
}
