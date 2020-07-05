using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using 电子族谱管理系统;

namespace 软工大作业
{
    public partial class 首页 : Form
    {
        public static string UserId = "";
        public static string TBLId = "";
        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);
        public 首页()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tslSign_Click(object sender, EventArgs e)
        {
            if(首页.UserId == "")
            {
                Login lg = new Login();
                lg.ShowDialog();
            }
            else
            {
                MessageBox.Show(首页.UserId + "您好！您已登录", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void tslRsr_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TBL_Search s = new TBL_Search();
            s.ShowDialog();
        }

        private void 首页_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(首页.UserId == "")
            {
                MessageBox.Show("请先登录", "确定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                   添加族谱 t = new 添加族谱();
                   t.ShowDialog();
            }
        }

        private void tslMyTBL_Click(object sender, EventArgs e)
        {
            族谱 z = new 族谱();
            z.TBL_ID = 首页.TBLId;
            z.ShowDialog();
        }
    }
}
