﻿using System;
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
    public partial class 族谱 : Form
    {
       
        public string TBL_ID="";
        TBL_ID=首页.TBLID;
        

        public 族谱()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string connString = @"Server = SQLOLEDB;
                                Data Source = LAPTOP-DAG67M6B;
                                Initial Catalog = 电子族谱;
                                User ID = sa;
                                Password = woaiwo525";
            //连接数据库
            StringBuilder sb = new StringBuilder();
            string sql = "SELECT TBL_ID ,ID,name,surname,instrouction,date FROM TBL_family_tree WHERE TBL_ID=" +首页.TBLID + "'";//查询数据库语言 ，选择的SQL语句
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.EndExecuteReader;
            int i=0;
            if (dr.Read())
            {
                textBox4.Text= dr["TBL_ID"].ToString().Trim();    //将族谱ID显示出来
            }
            textBox1.Text = dr["ID"].ToString().Trim();   //将创建人ID显示出来
            textBox3.Text = dr["name"].ToString().Trim();   //将族谱名显示出来
            textBox2.Text = dr["surname"].ToString().Trim();   //将族谱姓氏显示
            richTextBox1.Text = dr["instrouction"].ToString().Trim();  //将简介显示
            dateTimePicker1.Text = dr["date"].ToString().Trim();   //将创建日期显示
            dr.Close();
            dr.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            修改族谱 f2 = new 修改族谱();   //打开修改族谱页面
            f2.TBL_ID1 = this.TBL_ID;
            f2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connString = @"Server = SQLOLEDB;
                                Data Source = LAPTOP-DAG67M6B;
                                Initial Catalog = 电子族谱;
                                User ID = sa;
                                Password = woaiwo525";

            StringBuilder sb = new StringBuilder();
            sb.Append(@"DELETE FROM TBL_family_tree WHERE TBL_ID='" + TBL_ID+"'");  //删除族谱
            string sql = sb.ToString();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("该族谱删除成功！");
            }
            catch (Exception msg)
            {
                MessageBox.Show("出问题了！\n 出错原因：" + msg.Message);
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            memmodi f4 = new memmodi();
            f4.stationID = this.TBL_ID;
            f4.Show();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}

