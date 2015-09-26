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
    public partial class ChanPin : Form
    {
        YhBLL yhbll = new YhBLL();
        ChanPbmBLL cpbll = new ChanPbmBLL();
        //Login frmOne;
        string gh = Login.name;
        public ChanPin()
        {
            //frmOne = log;
            InitializeComponent();
        }

        private void ChanPin_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            DataSet ds = cpbll.GetChanMAll();
            this.dataGridView1.DataSource = ds.Tables[0];
            
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
                tsuhan_gt_cpmc cpmc = new tsuhan_gt_cpmc();
                cpmc.产品名称 = this.txtCPName.Text;
                cpmc.录入员 =Convert.ToString(gh);
                cpmc.时间 = DateTime.Now;
                bool result = cpbll.Add(cpmc);
                if (result == true)
                {
                    MessageBox.Show("添加成功", "提示");
                    this.dataGridView1.AutoGenerateColumns = false;
                    DataSet ds = cpbll.GetChanMAll();
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("添加失败", "提示");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除吗？？？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var cp = this.txtCPName.Text;
                bool result = cpbll.DeleteP(cp);
                if (result == true)
                {
                    MessageBox.Show("删除成功", "提示");
                    this.dataGridView1.AutoGenerateColumns = false;
                    DataSet ds = cpbll.GetChanMAll();
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
    }
}
