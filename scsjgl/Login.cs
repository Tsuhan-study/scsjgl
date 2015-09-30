using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Maticsoft.Model;
using System.Threading;

namespace scsjgl
{
    public partial class Login : Form
    {

        YhBLL yhbll = new YhBLL();
        //Login froTwo;
        public Login()
        {
            InitializeComponent();
        }

        public static string name;
        public int pwd;
        private void btnDeng_Click(object sender, EventArgs e)
        {

            tsuhan_scgl_yh yh = yhbll.GetModel(this.txtUserName.Text);
            var pwd =this.txtUserPwd.Text;
            var pd = yh.密码;
            if (this.txtUserName.Text=="")
            {
                MessageBox.Show("用户名未输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.txtUserPwd.Text == "")
            {
                MessageBox.Show("密码未输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (pwd!=pd)
            {
                MessageBox.Show("密码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                name = this.txtUserName.Text;
                Form1 fr = new Form1();
                fr.ShowDialog();
                this.Close();
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUserName.Text =name;
            this.txtUserName.Focus();

        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {

            this.btnOKUpdate.Enabled = false;
            this.txtNewPwd.Enabled = false;
            this.txtQRNewPwd.Enabled = false;
            if (this.txtUserName.Text=="")
            {
                MessageBox.Show("用户名未输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var gh = this.txtUserName.Text;
                var gh1 = gh.ToString().PadLeft(5, '0');
                bool result = yhbll.Exist(gh1);
                if (result == true)
                {
                    this.btnDeng.Enabled = true;
                    tsuhan_scgl_yh yh = yhbll.GetModel(gh1);
                    //this.txtUserName.Text = Convert.ToString(yh.工号);
                    this.txtUserPwd.Text = Convert.ToString(yh.密码);
                }
                else
                {
                    MessageBox.Show("用户名不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.btnDeng.Enabled = false;
                    this.txtUserPwd.Text = "";
                    return;
                }
            }
            

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text=="")
            {
                MessageBox.Show("工号未输入！！！", "提示");
                this.btnOKUpdate.Enabled = false;
                this.txtNewPwd.Enabled = false;
                this.txtQRNewPwd.Enabled = false;
                return;
            }
            else if(this.txtUserPwd.Text=="")
            {
                MessageBox.Show("密码未输入！！！", "提示");
                this.btnOKUpdate.Enabled = false;
                this.txtNewPwd.Enabled = false;
                this.txtQRNewPwd.Enabled = false;
                return;
            }
            else
            {
                this.btnOKUpdate.Enabled = true;
                this.txtNewPwd.Enabled = true;
                this.txtQRNewPwd.Enabled = true;
            }
        }

        private void btnOKUpdate_Click(object sender, EventArgs e)
        {
            var newPwd = this.txtNewPwd.Text.Trim();
            var newTowPwd = this.txtQRNewPwd.Text.Trim();
            if (newTowPwd!=newPwd)
            {
                MessageBox.Show("两次密码输入不一致！！！","提示");
                return;
            }
            else
            {
                tsuhan_scgl_yh yh = new tsuhan_scgl_yh();
                var gh = this.txtUserName.Text;
                tsuhan_scgl_yh yh1 = yhbll.GetModel(gh);
                yh.密码 =this.txtNewPwd.Text.Trim();
                yh.工号 = yh1.工号;
                yh.姓名 = yh1.姓名;
                yh.性别 = yh1.性别;
                yh.机构 = yh1.机构;
                yh.电话 = yh1.电话;
                yh.职务 = yh1.职务;
                yh.AB班 = yh1.AB班;
                yh.备注 = yh1.备注;
                yh.部门 = yh1.部门;
                yh.购买社保时间 = yh1.购买社保时间;
                yh.合同年限 = yh1.合同年限;
                yh.合同状态 = yh1.合同状态;
                yh.合同状态备注 = yh1.合同状态备注;
                yh.户籍 = yh1.户籍;
                yh.婚姻状况 = yh1.婚姻状况;
                yh.机构 = yh1.机构;
                yh.籍贯 = yh1.籍贯;
                yh.介绍人 = yh1.介绍人;
                yh.紧急联系人 = yh1.紧急联系人;
                yh.紧急联系人电话 = yh1.紧急联系人电话;
                yh.离职日期 = yh1.离职日期;
                yh.离职原因 = yh1.离职原因;
                yh.民族 = yh1.民族;
                yh.内部小号 = yh1.内部小号;
                yh.批注 = yh1.批注;
                yh.起始日期 = yh1.起始日期;
                yh.人事资料情况 = yh1.人事资料情况;
                yh.入职日期 = yh1.入职日期;
                yh.身份证地址 = yh1.身份证地址;
                yh.身份证号 = yh1.身份证号;
                yh.是否工资卡 = yh1.是否工资卡;
                yh.是否购买商保 = yh1.是否购买商保;
                yh.是否购买社保 = yh1.是否购买社保;
                yh.是否签订合同 = yh1.是否签订合同;
                yh.是否转正 = yh1.是否转正;
                yh.现住址 = yh1.现住址;
                yh.鞋柜1 = yh1.鞋柜1;
                yh.鞋柜2 = yh1.鞋柜2;
                yh.新鞋柜 = yh1.新鞋柜;
                yh.新衣柜 = yh1.新衣柜;
                yh.学历 = yh1.学历;
                yh.衣柜 = yh1.衣柜;
                yh.邮箱 = yh1.邮箱;
                yh.在职状态 = yh1.在职状态;
                yh.指纹登记号码 = yh1.指纹登记号码;
                yh.终止日期 = yh1.终止日期;
                yh.专业 = yh1.专业;
                yh.转正时间 = yh1.转正时间;
                bool result = false;
                result = yhbll.Update(yh);
                if (result == true)
                {
                    MessageBox.Show("修改成功", "提示");
                    this.txtUserName.Text = "";
                    this.txtUserPwd.Text = "";
                    this.txtNewPwd.Text = "";
                    this.txtQRNewPwd.Text = "";
                }
                else
                {
                    MessageBox.Show("修改失败", "提示");
                }
            }
        }
    }
}
