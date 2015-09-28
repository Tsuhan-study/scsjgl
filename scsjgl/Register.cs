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


namespace scsjgl
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        YhBLL yhbll = new YhBLL();
        private void Register_Load(object sender, EventArgs e)
        {
            //判断在职状态
            if (this.cbZaiZhi.Text == "在职")
            {
                this.label33.Visible = false;
                this.txtLZDate.Visible = false;
                this.label47.Visible = false;
                this.txtZTBZ.Visible = false;
                this.label46.Visible = false;
                this.cbGZK.Visible = false;
                this.label5.Visible = false;
                this.txtReason.Visible = false;
            }
            else if (this.cbZaiZhi.Text == "离职")
            {
                this.label33.Visible = true;
                this.txtLZDate.Visible = true;
                this.label47.Visible = true;
                this.txtZTBZ.Visible = true;
                this.label46.Visible = true;
                this.cbGZK.Visible = true;
                this.label5.Visible = true;
                this.txtReason.Visible = true;
            }
            //判断是否购买社保
            if (this.cbSheBao.Text == "是")
            {
                this.label32.Visible = true;
                this.txtSheBTime.Visible = true;
            }
            else if (this.cbSheBao.Text == "否")
            {
                this.label32.Visible = false;
                this.txtSheBTime.Visible = false;
            }
            //绑定所有用户信息
            DataSet ds = yhbll.getAll();
            this.dataGridView1.DataSource = ds.Tables[0];
            this.txtCountNum.Text = Convert.ToString(dataGridView1.Rows.Count);
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("确定要新增吗？？？","提示",MessageBoxButtons.YesNo);
             if (dr == DialogResult.Yes)
             {
                 tsuhan_scgl_yh yh = new tsuhan_scgl_yh();
                 ModAdd(yh);
                

                 bool result = false;
                 result = yhbll.Add(yh);
                 if (result == true)
                 {
                     MessageBox.Show("添加成功", "提示");
                     //刷新用户信息
                     DataSet ds = yhbll.getAll();
                     this.dataGridView1.DataSource = ds.Tables[0];
                 }
                 else
                 {
                     MessageBox.Show("添加失败", "提示");
                 }
             }

        }

        /// <summary>
        /// 员工添加代码
        /// </summary>
        /// <param name="yh"></param>
        private void ModAdd(tsuhan_scgl_yh yh)
        {
            var gh = this.txtGH.Text.Trim();
            string gh1 = gh.ToString().PadLeft(5,'0');
            //string aastr = aa.ToString().PadLeft(7, '0');
            yh.工号 = gh1;
            yh.密码 = "111111";
            yh.姓名 = this.txtName.Text;
            yh.性别 = this.cbSex.Text;
            yh.机构 = this.cbJG.Text;
            yh.电话 = Convert.ToDecimal(this.txtPhone.Text);
            yh.职务 = this.txtZW.Text;
            yh.AB班 = this.cbAB.Text;
            yh.备注 = this.txtRemark.Text;
            yh.部门 = this.txtBM.Text;
            yh.购买社保时间 = this.txtSheBTime.Text;
            yh.合同年限 = this.txtHTYear.Text;
            yh.合同状态 = this.txtHTZT.Text;
            yh.合同状态备注 = this.txtZTBZ.Text;
            yh.户籍 = this.txtHJ.Text;
            yh.婚姻状况 = this.cbHYZK.Text;
            yh.机构 = this.cbJG.Text;
            yh.籍贯 = this.txtJIGuan.Text;
            yh.介绍人 = this.txtJSR.Text;
            yh.紧急联系人 = this.txtJinJILXR.Text;
            if (this.txtJinJILXPhone.Text!="")
            {
               yh.紧急联系人电话 = Convert.ToDecimal(this.txtJinJILXPhone.Text);
            }
            else
            {
                yh.紧急联系人电话 = null;
            }
            if (this.txtLZDate.Text != "")
            {
                yh.离职日期 = Convert.ToDateTime(this.txtLZDate.Text);
            }
            else
            {
                yh.离职日期 = null;
            }
            yh.离职原因 = this.txtReason.Text;
            yh.民族 = this.txtMZ.Text;
            yh.内部小号 = this.txtMInNum.Text;
            yh.批注 = this.txtPZ.Text;
            if (this.txtStarTime.Text!="")
            {
               yh.起始日期 = Convert.ToDateTime(this.txtStarTime.Text);
            }
            else
            {
                yh.起始日期 = null;
            }
            yh.人事资料情况 = this.txtRSZL.Text;
            if (this.txtRZDate.Text != "")
            {
                yh.入职日期 = Convert.ToDateTime(this.txtRZDate.Text);
            }
            else
            {
                yh.入职日期 = null;
            }
            yh.身份证地址 = this.txtSFZAdress.Text;
            yh.身份证号 = this.txtSFZH.Text;
            yh.是否工资卡 = this.cbGZK.Text;
            yh.是否购买商保 = this.cbShangBao.Text;
            yh.是否购买社保 = this.cbSheBao.Text;
            yh.是否签订合同 = this.cbHTong.Text;
            yh.是否转正 = this.cbSFZZ.Text;
            yh.现住址 = this.txtNewAdress.Text;
            yh.鞋柜1 = this.txtXieG1.Text;
            yh.鞋柜2 = this.txtXieG2.Text;
            yh.新鞋柜 = this.txtXXieG.Text;
            yh.新衣柜 = this.txtXYG.Text;
            yh.学历 = this.txtXL.Text;
            yh.衣柜 = this.txtYG.Text;
            yh.邮箱 = this.txtEmail.Text;
            yh.在职状态 = this.cbZaiZhi.Text;
            yh.指纹登记号码 = this.txtZWH.Text;
            yh.终止日期 = this.txtStopTime.Text;
            yh.专业 = this.txtZY.Text;
            if (this.txtZZhengTime.Text != "")
            {
                yh.转正时间 = Convert.ToDateTime(this.txtZZhengTime.Text);
            }
            else
            {
                yh.转正时间 = null;
            }
        }


        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要修改吗？？？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                tsuhan_scgl_yh yh = new tsuhan_scgl_yh();
                //var yy = yhbll.GetModel(Convert.ToInt32(this.txtGH.Text));
                ModAdd(yh);

                bool result = false;
                result = yhbll.Update(yh);
                if (result == true)
                {
                    MessageBox.Show("修改成功", "提示");
                    //刷新用户信息
                    DataSet ds = yhbll.getAll();
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("修改失败", "提示");
                }
            }
        }


        private void btnCanles_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 双击dataGridView将对应值显示到文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.btnAdd.Enabled = false;
            //this.txtGH.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //this.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //this.cbZW.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //this.cbJG.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //this.cbSex.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //this.txtPhone.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //this.cbAB.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }


        /// <summary>
        /// 判断工号是否存在
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGH_Leave(object sender, EventArgs e)
        {

            if (this.txtGH.Text=="")
            {
                return;
            }
            else
            { 
                var gh =this.txtGH.Text;
                //gh = gh.TrimStart('0');
                var gh1 = gh.ToString().PadLeft(5, '0');
                bool result = false;
                result = yhbll.Exist(gh1);
                if (result == true)
                {
                    tsuhan_scgl_yh yh = yhbll.GetModel(gh1);

                    //this.txtGH.Text = Convert.ToString(yh.工号);
                    this.txtName.Text = yh.姓名;
                    this.cbSex.Text = yh.性别;
                    this.cbJG.Text = yh.机构;
                    this.txtPhone.Text = Convert.ToString(yh.电话);
                    this.txtZW.Text = yh.职务;
                    this.cbAB.Text = yh.AB班;
                    this.txtRemark.Text = yh.备注;
                    this.txtBM.Text = yh.部门;
                    this.txtSheBTime.Text = yh.购买社保时间;
                    this.txtHTYear.Text = yh.合同年限;
                    this.txtHTZT.Text = yh.合同状态;
                    this.txtZTBZ.Text = yh.合同状态备注;
                    this.txtHJ.Text = yh.户籍;
                    this.cbHYZK.Text = yh.婚姻状况;
                    this.cbJG.Text = yh.机构;
                    this.txtJIGuan.Text = yh.籍贯;
                    this.txtJSR.Text = yh.介绍人;
                    this.txtJinJILXR.Text = yh.紧急联系人;
                    this.txtJinJILXPhone.Text = Convert.ToString(yh.紧急联系人电话);
                    if (yh.离职日期==null)
                    {
                        this.txtLZDate.Text = "";
                    }
                    else
                    {
                        this.txtLZDate.Text = Convert.ToDateTime(yh.离职日期).ToString("yyyy-MM-dd");
                    }
                    this.txtReason.Text = yh.离职原因;
                    this.txtMZ.Text = yh.民族;
                    this.txtMInNum.Text = yh.内部小号;
                    this.txtPZ.Text = yh.批注;
                    if (yh.起始日期 == null)
                    {
                        this.txtStarTime.Text = "";
                    }
                    else
                    {
                        this.txtStarTime.Text = Convert.ToDateTime(yh.起始日期).ToString("yyyy-MM-dd");
                    }
                    this.txtRSZL.Text = yh.人事资料情况;
                    if (yh.入职日期 == null)
                    {
                        this.txtRZDate.Text = "";
                    }
                    else
                    {
                        this.txtRZDate.Text = Convert.ToDateTime(yh.入职日期).ToString("yyyy-MM-dd");
                    }
                    this.txtSFZAdress.Text = yh.身份证地址;
                    this.txtSFZH.Text = yh.身份证号;
                    this.cbGZK.Text = yh.是否工资卡;
                    this.cbShangBao.Text = yh.是否购买商保;
                    this.cbSheBao.Text = yh.是否购买社保;
                    this.cbHTong.Text = yh.是否签订合同;
                    this.cbSFZZ.Text = yh.是否转正;
                    this.txtNewAdress.Text = yh.现住址;
                    this.txtXieG1.Text = yh.鞋柜1;
                    this.txtXieG2.Text = yh.鞋柜2;
                    this.txtXXieG.Text = yh.新鞋柜;
                    this.txtXYG.Text = yh.新衣柜;
                    this.txtXL.Text = yh.学历;
                    this.txtYG.Text = yh.衣柜;
                    this.txtEmail.Text = yh.邮箱;
                    this.cbZaiZhi.Text = yh.在职状态;
                    this.txtZWH.Text = yh.指纹登记号码;
                    this.txtStopTime.Text = yh.终止日期;
                    this.txtZY.Text = yh.专业;
                    if (yh.转正时间 == null)
                    {
                        this.txtZZhengTime.Text = "";
                    }
                    else
                    {
                        this.txtZZhengTime.Text = Convert.ToDateTime(yh.转正时间).ToString("yyyy-MM-dd");
                    }

                    this.btnAdd.Enabled = false;
                    this.btnAdd.BackColor = Color.LightGray;
                    this.btnUpdate.Enabled = true;
                    this.btnUpdate.BackColor = Color.Gainsboro;
                    return;
                }
                else
                {
                    this.btnUpdate.Enabled = false;
                    this.btnUpdate.BackColor = Color.LightGray;
                    this.btnAdd.Enabled = true;
                    this.btnAdd.BackColor = Color.Gainsboro;
                }
            }
        }


        /// <summary>
        /// 判断在职状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbZaiZhi_TextChanged(object sender, EventArgs e)
        {
            if (this.cbZaiZhi.Text=="在职")
            {
                this.label33.Visible = false;
                this.txtLZDate.Visible = false;
                this.label47.Visible = false;
                this.txtZTBZ.Visible = false;
                this.label46.Visible = false;
                this.cbGZK.Visible = false;
                this.label5.Visible = false;
                this.txtReason.Visible = false;
            }
            else if (this.cbZaiZhi.Text=="离职")
            {
                this.label33.Visible = true;
                this.txtLZDate.Visible = true;
                this.label47.Visible = true;
                this.txtZTBZ.Visible = true;
                this.label46.Visible = true;
                this.cbGZK.Visible = true;
                this.label5.Visible = true;
                this.txtReason.Visible = true;
            }
        }

        /// <summary>
        /// 判断是否购买社保
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSheBao_TextChanged(object sender, EventArgs e)
        {
            if (this.cbSheBao.Text == "是")
            {
                this.label32.Visible = true;
                this.txtSheBTime.Visible = true;
            }
            else if (this.cbSheBao.Text == "否")
            {
                this.label32.Visible = false;
                this.txtSheBTime.Visible = false;
            }
        }

        /// <summary>
        /// 判断是否签定合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHTong_TextChanged(object sender, EventArgs e)
        {
            if (this.cbHTong.Text == "是")
            {
                this.groupBox1.Visible = true;
            }
            else if (this.cbHTong.Text == "否")
            {
                this.groupBox1.Visible = false;
            }
        }

        /// <summary>
        /// 查询在职员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                //绑定所有用户信息
                DataSet ds = yhbll.getAll1();
                this.dataGridView1.DataSource = ds.Tables[0];
                this.txtCountNum.Text = Convert.ToString(dataGridView1.Rows.Count);
            }
        }

        /// <summary>
        /// 查询离职员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                //绑定所有用户信息
                DataSet ds = yhbll.getAll2();
                this.dataGridView1.DataSource = ds.Tables[0];
                this.txtCountNum.Text = Convert.ToString(dataGridView1.Rows.Count);
            }
        }

        /// <summary>
        /// 判断是否输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

    }
}
