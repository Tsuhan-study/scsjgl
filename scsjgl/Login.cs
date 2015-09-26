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
            name = this.txtUserName.Text;
            Form1 fr = new Form1();
            fr.ShowDialog();
            this.Close();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUserName.Text =name;
            this.txtUserName.Focus();

        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            var name = Convert.ToInt32(this.txtUserName.Text);
            bool result = yhbll.Exist(name);
            if (result==true)
            {
                this.btnDeng.Enabled = true;
                tsuhan_scgl_yh yh = yhbll.GetModel(name);
                this.txtUserName.Text =Convert.ToString(yh.工号);
                this.txtUserPwd.Text = Convert.ToString(yh.密码);
            }
            else
            {
                MessageBox.Show("用户名未输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnDeng.Enabled = false;
                return;
            }
            

        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
