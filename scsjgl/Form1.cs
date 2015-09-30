using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maticsoft.Model;
using BLL;



namespace scsjgl
{
    public partial class Form1 : Form
    {
        YhBLL yhbll = new YhBLL();
        string ft =Login.name;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var gt = yhbll.GetModel(ft);
            if (gt.职务 == "系统管理员")
            {
                this.toolStripMenuItem1.Enabled = true;
                this.toolStripMenuItem6.Enabled = true;
                this.toolStripMenuItem2.Enabled = true;
                this.toolStripMenuItem7.Enabled = true;
            }
            else if (gt.职务 == "班长" || gt.职务 == "组长")
            {
                this.toolStripMenuItem1.Enabled = false;
                this.toolStripMenuItem6.Enabled = true;
                this.toolStripMenuItem2.Enabled = true;
                this.注销ToolStripMenuItem.Enabled = true;
                this.人员管理ToolStripMenuItem.Enabled = true;
            }
            else if (gt.职务 == "前台" || gt.职务 == "人事")
            {
                this.toolStripMenuItem1.Enabled = false;
                this.toolStripMenuItem6.Enabled = false;
                this.toolStripMenuItem2.Enabled = false;
                this.toolStripMenuItem11.Enabled = false;
            }
            else if (gt.职务 == "员工")
            {
                this.toolStripMenuItem1.Enabled = false;
                this.toolStripMenuItem6.Enabled = true;
                this.toolStripMenuItem2.Enabled = false;
                this.toolStripMenuItem7.Enabled = true;
                this.注销ToolStripMenuItem.Enabled = true;
                this.人员管理ToolStripMenuItem.Enabled = false;
                this.toolStripMenuItem8.Enabled = false;
                this.toolStripMenuItem9.Enabled = true;
                this.规格书录入ToolStripMenuItem.Enabled = false;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChanPin cp = new ChanPin();
            cp.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            SuiGongDanGX sgdgx = new SuiGongDanGX();///随工单公信
            sgdgx.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SuiGongDanJTXX sdj = new SuiGongDanJTXX();
            sdj.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            GuiGeShu ggs = new GuiGeShu();///规格书
            ggs.ShowDialog();
        }

        private void 人员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gt = yhbll.GetModel(ft);
            if (gt.职务 == "前台" || gt.职务 == "人事")
            {
                Register reg = new Register();//人员管理
                reg.ShowDialog();
            }
            else
            {
                MessageBox.Show("您没有该操作权限！", "警告");
                return;
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            KeHuXX khxx = new KeHuXX();//客户信息
            khxx.ShowDialog();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //点击注销按钮事件里面写： 

            if (MessageBox.Show("您确定要注销登录,更换其他账户吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.ShowDialog();
            } 
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            ChengPin cp = new ChengPin();
            cp.ShowDialog();
        }


        private void 出货查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rk rk = new Rk();
            rk.ShowDialog();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select st = new Select();
            st.ShowDialog();
        }

        private void 规格书录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiGeShu ggs = new GuiGeShu();///规格书
            ggs.ShowDialog();
        }

        private void 返修数据记录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FanXiu fx = new FanXiu();
            fx.ShowDialog();
        }

        private void 返修数据记录出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FanXiuC fxc = new FanXiuC();
            fxc.ShowDialog();
        }

        private void 关联码导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaoGLM d = new DaoGLM();
            d.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            IQC iqc1 = new IQC();
            iqc1.Show();
        }
    }
}
