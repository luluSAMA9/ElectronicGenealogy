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

namespace 电子族谱管理系统
{
    public partial class 修改族谱 : Form
    {
        public string TBL_ID1;
        public 修改族谱()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connString = @"Server = .;
                                Data Source = 127.0.0.1;
                                Initial Catalog = 族谱数据库; 
                                Persist Security Info = True; 
                                User ID = sa; 
                                Password = 123456";

            StringBuilder sb = new StringBuilder();
            sb.Append(@"UPDATE TBL_family_tree SET ");
           // sb.Append("'" + textBox4.Text + "',");
            sb.Append("TBL_name='" + textBox3.Text + "',");
            sb.Append("ID='" + textBox1.Text + "',");
            sb.Append("surname='" + textBox2.Text + "',");
            sb.Append("instrouction='" + richTextBox1.Text + "',");
            sb.Append("TBL_Pwd='" + textBox5.Text + "',");
            sb.Append("TBL_date='" + dateTimePicker1.Text+"'");
            sb.Append(" WHERE TBL_ID= '" + TBL_ID1+"'");
            string sql = sb.ToString();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("族谱信息修改完成！");
            }
            catch(Exception msg)
            {
                MessageBox.Show("出问题了！\n 出错原因：" + msg.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void 修改族谱_Load(object sender, EventArgs e)
        {

        }
    }
}
