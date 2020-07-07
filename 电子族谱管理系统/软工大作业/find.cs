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
using 电子族谱管理系统;

namespace find
{
    public partial class find1 : Form
    {

        public find1()
        {
            InitializeComponent();
        }

        private void find_branch_Click(object sender, EventArgs e)
        {
            String str1 = ID_value.Text;
            String str2 = "SELECT * FROM Member WHERE M_ID='" + str1 + "'";
            String str3 = "SELECT * FROM Member WHERE FatherID='" + str1 + "'";//检索其子女
            String str4 = "SELECT * FROM Member WHERE spousename='" + str1 + "'";//检索其配偶
            String str5 = "SELECT FatherID FROM Member WHERE M_ID='" + str1 + "'";//检索其父亲的ID

            Connect r1 = new Connect();   //我写的那个用来连接数据库的类是Connect，所以用其创建对象；
            DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。     
            DataTable d2 = new DataTable();   //承接其子女结果
            DataTable d3 = new DataTable();   //承接其配偶结果
            DataTable d4 = new DataTable();   //承接其夫亲ID结果


            d1 = r1.ExecuteQuery(str2); //使用ExecuteQuery（）执行sql语句；检索本人
            d2 = r1.ExecuteQuery(str3); //使用ExecuteQuery（）执行sql语句；检索其子女
            d3 = r1.ExecuteQuery(str4); //使用ExecuteQuery（）执行sql语句；检索其配偶
            d4 = r1.ExecuteQuery(str5); //使用ExecuteQuery（）执行sql语句；检索其父ID

            String str6 = "SELECT * FROM Member WHERE M_ID='" + d4 + "'";//检索其父
            String str7 = "SELECT spousename FROM Member WHERE M_ID='" + d4 + "'";//检索其父亲配偶的ID（其母ID）
            String str8 = "SELECT * FROM Member WHERE FatherID='" + d4 + "'";//检索其父亲的孩子（其姐妹兄弟）

            DataTable d5 = new DataTable();   //承接其夫结果
            DataTable d6 = new DataTable();   //承接其母结果
            DataTable d7 = new DataTable();   //承接其兄弟姐妹结果

            d5 = r1.ExecuteQuery(str6); //使用ExecuteQuery（）执行sql语句；检索其父
            d6 = r1.ExecuteQuery(str7); //使用ExecuteQuery（）执行sql语句；检索其父
            d7 = r1.ExecuteQuery(str8); //使用ExecuteQuery（）执行sql语句；检索其父


            if (d1 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d1;   //将查询结果放入到dataGridView；
            }
            if (d2 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d2;   //将查询结果放入到dataGridView；
            }

            if (d3 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d3;   //将查询结果放入到dataGridView；
            }
            if (d4 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d4;   //将查询结果放入到dataGridView；
            }
            if (d5 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d5;   //将查询结果放入到dataGridView；
            }
            if (d6 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d6;   //将查询结果放入到dataGridView；
            }
            if (d7 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d7;   //将查询结果放入到dataGridView；
            }
        }

        private void find_member_Click(object sender, EventArgs e)
        {
            //查询成员的代码
            String str1 = ID_value.Text;
            String str2 = "SELECT M_name FROM Member WHERE M_ID='" + str1 + "'";
         
            Connect r1 = new Connect();   //我写的那个用来连接数据库的类是Connect，所以用其创建对象；
            DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。     
           

            d1 = r1.ExecuteQuery(str2); //使用ExecuteQuery（）执行sql语句；检索本人
           
  
            if (d1 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d1;   //将查询结果放入到dataGridView；
            }


        }

        private void find_clan_Click(object sender, EventArgs e)
        {
            String str1 = ID_value.Text;
            String str2 = "SELECT M_name FROM Member WHERE M_ID='" + str1 + "'";
            String str3 = "SELECT M_name FROM Member WHERE FatherID='" + str1 + "'";//检索其子女
            String str4 = "SELECT M_name FROM Member WHERE spousename='" + str1 + "'";//检索其配偶
            String str5 = "SELECT FatherID FROM Member WHERE M_ID='" + str1 + "'";//检索其父亲的ID

            Connect r1 = new Connect();   //我写的那个用来连接数据库的类是Connect，所以用其创建对象；
            DataTable d1 = new DataTable();   //因为查询是会有结果返回的，所以需要用DataTable的对象来承接返回的结果。     
            DataTable d2 = new DataTable();   //承接其子女结果
            DataTable d3 = new DataTable();   //承接其配偶结果
            DataTable d4 = new DataTable();   //承接其夫亲ID结果


            d1 = r1.ExecuteQuery(str2); //使用ExecuteQuery（）执行sql语句；检索本人
            d2 = r1.ExecuteQuery(str3); //使用ExecuteQuery（）执行sql语句；检索其子女
            d3 = r1.ExecuteQuery(str4); //使用ExecuteQuery（）执行sql语句；检索其配偶
            d4 = r1.ExecuteQuery(str5); //使用ExecuteQuery（）执行sql语句；检索其父ID

            String str6 = "SELECT M_name FROM Member WHERE M_ID='" + d4 + "'";//检索其父
            String str7 = "SELECT spousename FROM Member WHERE M_ID='" + d4 + "'";//检索其父亲配偶的ID（其母ID）
            String str8 = "SELECT M_name FROM Member WHERE FatherID='" + d4 + "'";//检索其父亲的孩子（其姐妹兄弟）

            DataTable d5 = new DataTable();   //承接其夫结果
            DataTable d6 = new DataTable();   //承接其母结果
            DataTable d7 = new DataTable();   //承接其兄弟姐妹结果

            d5 = r1.ExecuteQuery(str6); //使用ExecuteQuery（）执行sql语句；检索其父
            d6 = r1.ExecuteQuery(str7); //使用ExecuteQuery（）执行sql语句；检索其父
            d7 = r1.ExecuteQuery(str8); //使用ExecuteQuery（）执行sql语句；检索其父


            if (d1 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d1;   //将查询结果放入到dataGridView；
            }
            if (d2 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d2;   //将查询结果放入到dataGridView；
            }

            if (d3 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d3;   //将查询结果放入到dataGridView；
            }
            if (d4 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d4;   //将查询结果放入到dataGridView；
            }
            if (d5 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d5;   //将查询结果放入到dataGridView；
            }
            if (d6 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d6;   //将查询结果放入到dataGridView；
            }
            if (d7 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d7;   //将查询结果放入到dataGridView；
            }


        }

        private void find_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
