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
    public partial class ChengPin : Form
    {
        YhBLL yhbll = new YhBLL();
        ChanPbmBLL cpbll = new ChanPbmBLL();
        //Login frmOne;
        string gh = Login.name;
        public ChengPin()
        {
            //frmOne = log;
            InitializeComponent();
        }

       
        private void ChengPin_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            DataSet ds = cpbll.GetChanPTable();
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtCPBM_MouseLeave(object sender, EventArgs e)
        {
            var cpbm = this.txtCPBM.Text;
            if (cpbm=="")
            {
                cpbm = null;
            }
            bool result = cpbll.Exist(cpbm);
            if (result==true)
            {
                MessageBox.Show("成品编码已经存在","提示");
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
                 var gt = yhbll.GetModel(Convert.ToInt32(gh));
                 tsuhan_gt_cpbm cpbm = new tsuhan_gt_cpbm();
                 cpbm.成品编码 = this.txtCPBM.Text;
                 cpbm.时间 =Convert.ToDateTime(this.dtpTime.Text);
                 cpbm.录入员 =Convert.ToString(gt.工号);
                 bool result = cpbll.Add(cpbm);
                 if (result == true)
                 {
                     MessageBox.Show("添加成功", "提示");
                     this.dataGridView1.AutoGenerateColumns = false;
                     DataSet ds = cpbll.GetChanPTable();
                     this.dataGridView1.DataSource = ds.Tables[0];
                 }
                 else
                 {
                     MessageBox.Show("添加失败", "提示");
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
                 var cp = this.txtCPBM.Text;
                 bool delete = cpbll.Delete(cp);
                 if (delete==true)
                 {
                     MessageBox.Show("删除成功","提示");
                     this.dataGridView1.AutoGenerateColumns = false;
                     DataSet ds = cpbll.GetChanPTable();
                     this.dataGridView1.DataSource = ds.Tables[0];
                 }
                 else
                 {
                     MessageBox.Show("删除失败", "提示");
                 }
             }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCPBM.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.dtpTime.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
