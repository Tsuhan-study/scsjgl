using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Maticsoft.Model;
using BLL;

namespace scsjgl
{
    public partial class KeHuXX : Form
    {
        KeHdmBLL khdm = new KeHdmBLL();
        YhBLL yhbll = new YhBLL();
        //Login frmOne;
        string gh = Login.name;
        public KeHuXX()
        {
            //frmOne = loge;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体已加载绑定所有客户代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeHuXX_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            DataSet ds = khdm.GetKeHTable();
            this.dataGridView1.DataSource = ds.Tables[0];
            this.txtKHDM.Focus();
        }

        /// <summary>
        /// 判断客户代码是否存在
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKHDM_MouseLeave(object sender, EventArgs e)
        {
            var dm = this.txtKHDM.Text;
            bool result = false;
            result = khdm.Exist(dm);
            if (result == true)
            {
                MessageBox.Show("客户代码已经存在,你可以执行删除操作", "提示");
                this.btnAdd.Enabled = false;
                this.btnAdd.BackColor = Color.LightGray;
                this.btnDelete.Enabled = true;
                this.btnDelete.BackColor = Color.Gainsboro;

            }
            else
            {
                this.btnAdd.Enabled = true;
                this.btnAdd.BackColor = Color.Gainsboro;
                this.btnDelete.Enabled = false;
                this.btnDelete.BackColor = Color.LightGray;
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("确定要添加吗？？？","提示",MessageBoxButtons.YesNo);
             if (dr == DialogResult.Yes)
             {
                 tsuhan_scgl_khdm khdms = new tsuhan_scgl_khdm();
                 var gt = yhbll.GetModel(gh);
                 khdms.客户代码 = this.txtKHDM.Text;
                 khdms.客户信息 = this.txtKHXX.Text;
                 khdms.录入时间 = DateTime.Now.ToString();
                 khdms.录入员 =Convert.ToString(gt.工号);
                 bool result = khdm.Add(khdms);
                 if (result == true)
                 {
                     MessageBox.Show("添加成功", "提示");
                     this.btnAdd.Enabled = false;
                     this.btnAdd.BackColor = Color.LightGray;
                     this.btnDelete.Enabled = true;
                     this.btnDelete.BackColor = Color.Gainsboro;
                     this.dataGridView1.AutoGenerateColumns = false;
                     DataSet ds = khdm.GetKeHTable();
                     this.dataGridView1.DataSource = ds.Tables[0];
                 }
                 else
                 {
                     MessageBox.Show("添加失败", "提示");
                     this.btnDelete.Enabled = false;
                     this.btnDelete.BackColor = Color.LightGray;
                     this.btnAdd.Enabled = true;
                     this.btnAdd.BackColor = Color.Gainsboro;
                 }
             }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除吗？？？","提示",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var kh = this.txtKHDM.Text;
                bool result = khdm.Delete(kh);
                if (result == true)
                {
                    MessageBox.Show("删除成功", "提示");
                    this.dataGridView1.AutoGenerateColumns = false;
                    DataSet ds = khdm.GetKeHTable();
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("删除失败", "提示");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtKHDM.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtKHXX.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 键盘事件重载
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys key = (keyData & Keys.KeyCode);
            if (key == Keys.Down)
            {
                SendKeys.Send("{Tab}");
                return true;
            }
            else if (key == Keys.Up)
            {
                SendKeys.Send("+{Tab}");
                return true;
            }
            else if (key == Keys.Right)
            {
                SendKeys.Send("{Tab}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
