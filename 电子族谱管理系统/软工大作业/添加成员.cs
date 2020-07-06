using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 添加成员
{
    public partial class 添加成员 : Form
    {
        public 添加成员()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否取消操作？", "提示");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("添加成功","提示");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void 添加成员_Load(object sender, EventArgs e)
        {

        }
        //string connString = @"Server = SQLOLEDB;
        // Data Source = LAPTOP-DAG67M6B;
        //Initial Catalog = 电子族谱;
        // User ID = sa;
        // Password = woaiwo525";
        //构造SQL命令
        //StringBuilder sb = new StringBuilder();
        // sb.Append(@"INSERT INTO Member (M_ID,M_name,M_sex,M_birthday,M_death,M_seniority,TBL_ID,FatherID,spouseID)VALUES(");
        // sb.Append("'" + textBox1.Text + "',");
        // sb.Append("'" + textBox2.Text + "',");
        // sb.Append("'" + textBox3.Text + "',");
        // sb.Append("'" + textBox7.Text + "',");
        // sb.Append("'" + textBox9.Text + "',");
        // sb.Append("'" + textBox8.Text + "',");
        // sb.Append("'" + textBox5.Text + "',");
        // sb.Append("'" + textBox4.Text + "',");
        // sb.Append("'" + textBox6.Text + "',");
        //string sql=sb.ToString;
        //SqlConnection conn=new SqlConnection(connString);
        //conn.Open;
        //下达命令
        //SqlCommand cmd = new SqlCommand(sql, conn);
    }
}
