using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 族谱页面
{
     
    public partial class 创建族谱 : Form
    {
        //"Login" f=null;
        public 创建族谱()
        {
            
            InitializeComponent();
           // this.f = f;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认取消新建族谱吗？", "提示");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          //  if(textBox1.Text=" "||)
            {
               MessageBox.Show("添加成功!","提示");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //连接数据库
       /* string connString = @"Server = SQLOLEDB;
                                Data Source = LAPTOP-DAG67M6B;
                                Initial Catalog = 电子族谱;
                                User ID = sa;
                                Password = woaiwo525";*/
        //构造SQL命令
        //StringBuilder sb = new StringBuilder();
        // sb.Append(@"INSERT INTO TBL_family_tree (TBL_ID,ID,TBL_name,sumame,introduction,TBL_date,TBL_Pwd)VALUES(");
        // sb.Append("'" + textBox1.Text + "',");
        //sb.Append("'" + textBox3.Text + "',");
        //sb.Append("'" + textBox2.Text + "',");
        //sb.Append("'" + textBox4.Text + "',");
        //sb.Append("'" + richTextBox1 + "',");
        //sb.Append("'" + textBox5.Text + "',");
        //sb.Append("'" + textBox6.Text + "',");
        //string sql=sb.ToString;
        //SqlConnection conn=new SqlConnection(connString);
        //conn.Open;
        //下达命令
        //SqlCommand cmd = new SqlCommand(sql, conn);
        //
    }
}
