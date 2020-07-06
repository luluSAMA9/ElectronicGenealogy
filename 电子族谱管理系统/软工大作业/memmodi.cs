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
    public partial class memmodi : Form
    {
        public string stationID;

        public memmodi()
        {
            InitializeComponent2();
        }

        private void 成员展示_Click(object sender, EventArgs e)
        {
                string connString = @"Server = .;
                                Data Source = 127.0.0.1;
                                Initial Catalog = 族谱数据库; 
                                Persist Security Info = True; 
                                User ID = sa; 
                                Password = 123456";
                SqlConnection SqlCon = new SqlConnection(connString); //数据库连接
                SqlCon.Open(); //打开数据库
                string sql = "Select * from 成员表 where TBL_ID=" +stationID;//查找用户sql语句
                SqlCommand cmd = new SqlCommand(sql, SqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                DataTable dt = new DataTable();
                SqlDataAdapter msda;
                msda = new SqlDataAdapter(cmd);
                msda.Fill(dt);
                SqlCon.Close();   
                DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。
                d1 = dt;
                if (d1 != null && d1.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = d1;   //将查询结果放入到dataGridView；

                    }
        }

        private void 成员修改_Click(object sender, EventArgs e)
        {
            memchange memchange1 = new memchange();
            memchange1.Show();
        }

        private void InitializeComponent2()
        {
            this.SuspendLayout();
            // 
            // memmodi
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "memmodi";
            this.Load += new System.EventHandler(this.memmodi_Load);
            this.ResumeLayout(false);

        }

        private void memmodi_Load(object sender, EventArgs e)
        {

        }
    }
}
