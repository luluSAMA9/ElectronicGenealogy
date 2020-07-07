using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 软工大作业;

namespace 电子族谱管理系统
{
    public partial class 族谱信息 : Form
    {
        public string TBL_ID;

        public 族谱信息()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memmodi f5 = new memmodi();
            f5.stationID = this.TBL_ID;
            f5.Show();
        }

        private void 族谱信息_Load(object sender, EventArgs e)
        {
            string connString = @"Server = .;
                                Data Source = 127.0.0.1;
                                Initial Catalog = 族谱数据库; 
                                Persist Security Info = True; 
                                User ID = sa; 
                                Password = 123456";
            //连接数据库
            StringBuilder sb = new StringBuilder();
            string sql = "SELECT TBL_ID ,ID,TBL_name,surname,introduction,TBL_date from TBL_family_tree where TBL_ID = '" + TBL_ID + "'";//查询数据库语言 ，选择的SQL语句
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox4.Text = dr["TBL_ID"].ToString().Trim();    //将族谱ID显示出来
            }
            textBox1.Text = dr["ID"].ToString().Trim();   //将创建人ID显示出来
            textBox3.Text = dr["TBL_name"].ToString().Trim();   //将族谱名显示出来
            textBox2.Text = dr["surname"].ToString().Trim();   //将族谱姓氏显示
            richTextBox1.Text = dr["introduction"].ToString().Trim();  //将简介显示
            dateTimePicker1.Text = dr["TBL_date"].ToString().Trim();   //将创建日期显示
            dr.Close();
            dr.Dispose();
            conn.Close();
        }
    }
}
