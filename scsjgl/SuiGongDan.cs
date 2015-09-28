using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using Maticsoft.Model;
using BLL;

namespace scsjgl
{
    public partial class SuiGongDanGX : Form
    {
        SpecBLL specbll = new SpecBLL();
        GtBLL gtbll = new GtBLL();
        ChanPxhBLL chanpxhbll = new ChanPxhBLL();
        KeHdmBLL kehdmbll = new KeHdmBLL();
        YhBLL yhbll = new YhBLL();
        ChanPbmBLL chanpbmbll = new ChanPbmBLL();
        //Login fr;
        string gh = Login.name;
        public SuiGongDanGX()
        {
            //fr = loge;
            InitializeComponent();
        }
        //public void settext(string str)
        //{
        //    this.tsslLRY.Text = str;
        //}
        private void SuiGongDanGX_Load(object sender, EventArgs e)
        {
            //this.cbGGSBH.ReadOnly = true;
            var gt = yhbll.GetModel(gh);
            this.tsslLRYtxt.Text =gt.姓名;
            dTPjh.Text = DateTime.Now.ToString();
            dTPxd.Text = DateTime.Now.ToString();
            this.textBox1.Text = DateTime.Now.ToString();
            this.tsslLRTIMEtxt.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            btnUPDATA.Enabled = false;
            btnUPDATA.BackColor = Color.DimGray;
            btnCHANGE.Enabled = false;
            btnCHANGE.BackColor = Color.DimGray;
            tbsgdxh1.Focus();
            //绑定规格书与下拉框
            cbGGSBH.DisplayMember = "规格书";
            cbGGSBH.ValueMember = "规格书";
            cbGGSBH.DataSource = specbll.GetSpecsTable();
            ////绑定产品型号
            //cbCPXH.DisplayMember = "产品类型";
            //cbCPXH.ValueMember = "id";
            //cbCPXH.DataSource = chanpxhbll.GetChanPTable();
            ////绑定成品编码
            //cbCPBM.DisplayMember = "成品编码";
            //cbCPBM.ValueMember = "id";
            //cbCPBM.DataSource = chanpbmbll.GetChanPTable();
            //绑定产品名称
            cbCPMC.DisplayMember = "产品名称";
            cbCPMC.ValueMember = "id";
            cbCPMC.DataSource = chanpbmbll.GetChanMTable();

        }
      
        //private void tbsgdxh1_MouseLeave(object sender, EventArgs e)
        //{

        //    SelectDan();
        //}

        /// <summary>
        /// 根据备货单号查询
        /// </summary>
        private void SelectDan()
        {
            if (tbsgdxh1.Text == string.Empty || tbsgdxh1.Text=="00000")
            {
                MessageBox.Show("请填写备货单号", "警告");
                this.btnOK.Enabled = false;
                return;
            }
            else
            {
                
                var tbs = this.tbsgdxh1.Text.Trim();
                bool result;
                //根据备货单号查询信息
                result = gtbll.Exists(tbs);
                if (result != true)
                {
                    MessageBox.Show("此单号还没有录入数据", "提示");
                    var gt = yhbll.GetModel(gh);
                    this.tsslLRYtxt.Text = gt.姓名;
                    this.tsslLRTIMEtxt.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    this.tbFHBHDH.Text = this.tbsgdxh1.Text;
                    this.tbHTH.Text = this.tbHTBH.Text;
                    btnUPDATA.Enabled = true;
                    btnCHANGE.BackColor = Color.SlateBlue;
                    btnCHANGE.Enabled = false;
                    btnCHANGE.BackColor = Color.Gray;
                    btnOK.Enabled = true;
                    btnOK.BackColor = Color.SlateBlue;
                    this.tbBHDH.Text = this.tbsgdxh1.Text;
                    SelectSpec2();
                    return;
                }
                else
                {
                    btnUPDATA.Enabled = false;
                    btnUPDATA.BackColor = Color.Gray;
                    btnCHANGE.Enabled = true;
                    btnCHANGE.BackColor = Color.SlateBlue;
                    btnOK.Enabled = false;
                    btnOK.BackColor = Color.Gray;
                    Maticsoft.Model.tsuhan_sg_gt modelgt = gtbll.GetModel(tbs);
                    this.tbHTBH.Text = modelgt.合同编号;
                    
                    var ghs=this.cbGGSBH.Text = modelgt.规格书编号;
                    SelectSpec(modelgt, ghs);
                    #region tsuhan_sg_gt

                    this.cbQJBQ.Text = modelgt.BZ_QJbq;
                    this.dTPjh.Text = Convert.ToString(modelgt.交货日期);
                    this.dTPxd.Text = Convert.ToString(modelgt.下单日期);
                    string tb = modelgt.表格编号;
                    string[] tbbgbh = tb.Split(new char[1]{'-'});
                    this.tbBGBH1.Text =tbbgbh[0];
                    this.tbBGBH2.Text = tbbgbh[1];
                    this.cbCPMC.Text = modelgt.产品名称;
                    this.tbBHDH.Text = modelgt.备货单号;
                    this.tbBHDSL.Text =Convert.ToString(modelgt.备货单数量);
                    this.cbCPTH.Text = modelgt.产品图号;
                    this.txtCPXH.Text=modelgt.产品类型;
                    this.txtCPBM.Text = modelgt.成品编码;
                    this.tbKHDM.Text = modelgt.客户代码;
                    this.tbSGKSL.Text = Convert.ToString(modelgt.随工卡数量);
                    this.tbAM.Text = modelgt.BK_A;
                    this.tbBM.Text = modelgt.BK_B;

                    string tbcm = modelgt.BK_C;
                    string[] tbCM = tbcm.Split(new char[1] {'-'});
                    this.tbCM1.Text = tbCM[0];
                    this.tbCM2.Text = tbCM[1];
                    this.tbJJ.Text = Convert.ToString(modelgt.LD_LDjj);
                    this.tbHJFS.Text = modelgt.GX_hjfs;
                    this.tbDMZL.Text = modelgt.DM_dmzl;
                    this.tbXHCS.Text = Convert.ToString(modelgt.GDW_xhcs);
                    this.tbHQGLmin.Text = Convert.ToString(modelgt.OH_hqPomin);
                    this.tbHQGLmax.Text = Convert.ToString(modelgt.OH_hqPomax);
                    this.tbHHGLmin.Text = Convert.ToString(modelgt.OH_hhPomin);
                    this.tbHHGLmax.Text = Convert.ToString(modelgt.OH_hhPomax);
                    this.tbRXGL.Text = Convert.ToString(modelgt.PT_rqgl); ;
                    this.tbGDLmin.Text = Convert.ToString(modelgt.PT_gdlmin);
                    this.tbGDLmax.Text = Convert.ToString(modelgt.PT_gdlmax);

                    this.tbCSWDmin.Text = Convert.ToString(modelgt.JX_wdMin);
                    this.tbCSWDmax.Text = Convert.ToString(modelgt.JX_wdMax);
                    this.tbZZFX.Text = modelgt.JX_zz;
                    this.tbPTGD.Text = modelgt.JX_pthigh;
                    this.tbPTWWJ.Text = modelgt.JX_ptwwj;
                    this.tbLDtype.Text = modelgt.JX_ldgj;
                    this.tbPTtype.Text = modelgt.JX_ptgj;
                    this.tbHQPo.Text = Convert.ToString(modelgt.OH_hqBFB);
                    this.tbHHPo.Text = Convert.ToString(modelgt.OH_hhBFB);
                    this.tbCSPo.Text = Convert.ToString(modelgt.LD_CSBFB);
                    this.tbCSmin.Text = Convert.ToString(modelgt.LD_CSPomin);
                    this.tbCSmax.Text = Convert.ToString(modelgt.LD_CSPomax);
                    this.rtbCPMC.Text = modelgt.fh产品名称;
                    this.tbDESCEIP.Text=modelgt.Description;
                    this.cbWLDM.Text=modelgt.物料代码;
                    this.cbXHSX.Text=modelgt.型号属性;
                    this.cbSPEC.Text = modelgt.Specification;
                    this.cbKHXH.Text=modelgt.客户型号;
                    this.cbLDCHIPXH.Text=modelgt.LD芯片型号;
                    this.cbPTCHIPXH.Text=modelgt.PT芯片型号;
                    this.textBox1.Text =Convert.ToString(modelgt.生产日期);
                    this.tbQUA_PO.Text=modelgt.Quantity1;
                    this.tbQUA_SEN.Text=modelgt.Quantity2;
                    this.tbSL.Text=modelgt.数量;
                    this.tbFHBHDH.Text = modelgt.备货单号;
                    this.tbHTH.Text = modelgt.合同编号;

                    this.tbJHBZ.Text = modelgt.计划编制;
                    this.tbJSSH.Text = modelgt.技术审核;
                    this.tbSCSH.Text = modelgt.生产审核;
                    this.tsslLRTIMEtxt.Text =Convert.ToString(modelgt.录入时间);
                    this.tsslLRYtxt.Text = modelgt.录入员;
                    #endregion
                         
                    
                  
                    //审核人
                    //修改按钮不可用
                }

            }
        }

        /// <summary>
        /// 根据规格书编号查询相关信息
        /// </summary>
        /// <param name="modelgt"></param>
        /// <param name="ghs"></param>
        private void SelectSpec(Maticsoft.Model.tsuhan_sg_gt modelgt, string ghs)
        {
            //Maticsoft.Model.tsuhan_spec spec1 = sp.GetModel(ghs);
            Maticsoft.Model.tsuhan_spec spec = specbll.GetModel(ghs);
            if (modelgt.规格书编号 == spec.规格书)
            {

                this.txtCPBM.Text = spec.成品编码;
                this.txtCPXH.Text = spec.产品型号;
                this.tbKHDM.Text = spec.客户代码;
                this.tbLDKINK.Text = Convert.ToString(spec.Pkinkmin);
                this.tbPTKINK.Text = Convert.ToString(spec.Kimomin);


                this.tbCSTJ.Text = spec.码型;
                this.tbCSPL.Text = Convert.ToString(spec.速率);
                this.tbLMDtype.Text = spec.PT方法;
                this.tbLMDvalue.Text = Convert.ToString(spec.Sen);

                this.tbICCmin.Text = Convert.ToString(spec.Iccmin);
                this.tbICCmax.Text = Convert.ToString(spec.Iccmax);
                this.tbIf.Text = Convert.ToString(spec.LD方法);
                this.tbCCGLmin.Text = Convert.ToString(spec.Pomin);
                this.tbCCGLmax.Text = Convert.ToString(spec.Pomax);
                this.tbIMOmin.Text = Convert.ToString(spec.Imomin);
                this.tbIMOmax.Text = Convert.ToString(spec.Imomax);
                this.tbITHmin.Text = Convert.ToString(spec.Ithmin);
                this.tbITHmax.Text = Convert.ToString(spec.Ithmax);
                this.tbVFmin.Text = Convert.ToString(spec.Vfmin);
                this.tbVFmax.Text = Convert.ToString(spec.Vfmax);
                this.tbPTSL.Text = Convert.ToString(spec.速率);
                this.tbVBRmin.Text = Convert.ToString(spec.Vbrmin);
                this.tbVBRmax.Text = Convert.ToString(spec.Vbrmax);
            }
        }

        #region 新增、修改
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUPDATA_Click(object sender, EventArgs e)
        {
            
            Maticsoft.Model.tsuhan_sg_gt mogt = new Maticsoft.Model.tsuhan_sg_gt();
            mogt.合同编号 = this.tbHTBH.Text;
            mogt.备货单号 = this.tbBHDH.Text;
            if (this.tbBHDSL.Text == "")
            {
                this.tbBHDSL.Text = "0";
            }
            mogt.备货单数量 = Convert.ToInt32(this.tbBHDSL.Text);
            mogt.表格编号 = this.tbBGBH1.Text + "-" + this.tbBGBH2.Text;
            mogt.产品类型 = this.txtCPXH.Text;
            mogt.产品名称 = this.cbCPMC.Text;
            mogt.成品编码 = this.txtCPBM.Text;
            mogt.产品图号 = this.cbCPTH.Text;
            mogt.规格书编号 = this.cbGGSBH.Text;
            mogt.客户代码 = this.tbKHDM.Text;
            mogt.计划编制 = this.tbJHBZ.Text;
            mogt.技术审核 = this.tbJSSH.Text;
            mogt.生产审核 = this.tbSCSH.Text;
            mogt.交货日期 = Convert.ToDateTime(this.dTPjh.Text);
            mogt.下单日期 = Convert.ToDateTime(this.dTPxd.Text);
            mogt.录入时间 = Convert.ToDateTime(this.tsslLRTIMEtxt.Text);
            mogt.录入员 = this.tsslLRYtxt.Text;
            mogt.BK_A = this.tbAM.Text;
            mogt.BK_B = this.tbBM.Text;
            #region
            if (this.tbCM2.Text == "")
            {
                this.tbCM2.Text = "0000";
            }
            mogt.BK_C = this.tbCM1.Text + "-" + this.tbCM2.Text;
            mogt.录入时间 = DateTime.Now;
            if (this.tbSGKSL.Text == "")
            {
                mogt.随工卡数量 = null;
            }
            else
            {
                mogt.随工卡数量 = Convert.ToInt32(this.tbSGKSL.Text);
            }

            if (this.tbJJ.Text == "")
            {
                mogt.LD_LDjj = null;
            }
            else
            {
                mogt.LD_LDjj = Convert.ToDecimal(this.tbJJ.Text);
            }
            if (this.tbHQGLmin.Text == "")
            {
                mogt.GDW_xhcs = null;
            }
            else
            {
                mogt.GDW_xhcs = Convert.ToInt32(this.tbXHCS.Text);
            }
            if (this.tbHQGLmin.Text == "")
            {
                mogt.OH_hqPomin = null;
            }
            else
            {
                mogt.OH_hqPomin = Convert.ToDecimal(this.tbHQGLmin.Text);
            }
            if (this.tbHQGLmax.Text == "")
            {
                mogt.OH_hqPomax = null;
            }
            else
            {
                mogt.OH_hqPomax = Convert.ToDecimal(this.tbHQGLmax.Text);
            }

            if (this.tbHHGLmin.Text == "")
            {
                mogt.OH_hhPomin = null;
            }
            else
            {
                mogt.OH_hhPomin = Convert.ToDecimal(this.tbHHGLmin.Text);
            }

            if (this.tbHHGLmax.Text == "")
            {
                mogt.OH_hhPomax = null;
            }
            else
            {
                mogt.OH_hhPomax = Convert.ToDecimal(this.tbHHGLmax.Text);
            }

            if (this.tbRXGL.Text == "")
            {
                mogt.PT_rqgl = null;
            }
            else
            {
                mogt.PT_rqgl = Convert.ToInt32(this.tbRXGL.Text);
            }

            if (this.tbGDLmin.Text == "")
            {
                mogt.PT_gdlmin = null;
            }
            else
            {
                mogt.PT_gdlmin = this.tbGDLmin.Text;
            }

            if (this.tbGDLmax.Text == "")
            {
                mogt.PT_gdlmax = null;
            }
            else
            {
                mogt.PT_gdlmax =this.tbGDLmax.Text;
            }

            if (this.tbHQPo.Text == "")
            {
                mogt.OH_hqBFB = 0;
            }
            else if (Convert.ToInt32(this.tbHQPo.Text.Trim()) > 100)
            {
                MessageBox.Show("输入的" + lblHQ.Text + "不能大于100", "提示");
                return;
            }
            else if (Convert.ToInt32(this.tbHQPo.Text.Trim()) < 0)
            {
                MessageBox.Show("输入的" + lblHQ.Text + "不能小于0", "提示");
                return;
            }
            else
            {
                mogt.OH_hqBFB = Convert.ToInt32(this.tbHQPo.Text);
            }

            if (this.tbHHPo.Text == "")
            {
                mogt.OH_hhBFB = 0;
            }
            else if (Convert.ToInt32(this.tbHHPo.Text.Trim()) > 100)
            {
                MessageBox.Show("输入的" + lblHH.Text + "不能大于100", "提示");
                return;
            }
            else if (Convert.ToInt32(this.tbHHPo.Text.Trim()) < 0)
            {
                MessageBox.Show("输入的" + lblHH.Text + "不能小于0", "提示");
                return;
            }
            else
            {
                mogt.OH_hhBFB = Convert.ToInt32(this.tbHHPo.Text);
            }

            if (this.tbCSPo.Text == "")
            {
                mogt.LD_CSBFB = 0;
            }
            else if (Convert.ToInt32(this.tbCSPo.Text.Trim()) > 100)
            {
                MessageBox.Show("输入的" + lblCS.Text + "不能大于100", "提示");
                return;
            }
            else if (Convert.ToInt32(this.tbCSPo.Text.Trim()) < 0)
            {
                MessageBox.Show("输入的" + lblCS.Text + "不能小于0", "提示");
                return;
            }
            else
            {
                mogt.LD_CSBFB = Convert.ToInt32(this.tbCSPo.Text);
            }
            if (this.tbCSWDmin.Text == "")
            {
                mogt.JX_wdMin = null;
            }
            else
            {
                mogt.JX_wdMin = Convert.ToInt32(this.tbCSWDmin.Text);
            }
            if (this.tbCSWDmax.Text == "")
            {
                mogt.JX_wdMax = null;
            }
            else
            {
                mogt.JX_wdMax = Convert.ToInt32(this.tbCSWDmax.Text);
            }
            #endregion
            mogt.GX_hjfs = this.tbHJFS.Text;
            mogt.DM_dmzl = this.tbDMZL.Text;

            mogt.JX_ptwwj = this.tbPTWWJ.Text;
            mogt.JX_zz = this.tbZZFX.Text;
            mogt.JX_pthigh = this.tbPTGD.Text;
            mogt.JX_ptgj = this.tbPTtype.Text;
            mogt.JX_ldgj = this.tbLDtype.Text;
            mogt.BZ_QJbq = this.cbQJBQ.Text;
            if (this.tbLDKINK.Text == "")
            {
                this.tbLDKINK.Text = "0";
            }
            if (this.tbPTKINK.Text == "")
            {
                this.tbPTKINK.Text = "0";
            }
            if (this.tbICCmin.Text == "")
            {
                this.tbICCmin.Text = "0";
            }
            if (this.tbICCmax.Text == "")
            {
                this.tbICCmax.Text = "0";
            }
            if (this.tbIMOmin.Text == "")
            {
                this.tbIMOmin.Text = "0";
            }
            if (this.tbIMOmax.Text == "")
            {
                this.tbIMOmax.Text = "0";
            }
            if (this.tbCCGLmin.Text == "")
            {
                this.tbCCGLmin.Text = "0";
            }
            if (this.tbCCGLmax.Text == "")
            {
                this.tbCCGLmax.Text = "0";
            }
            if (this.tbITHmin.Text == "")
            {
                this.tbITHmin.Text = "0";
            }
            if (this.tbITHmax.Text == "")
            {
                this.tbITHmax.Text = "0";
            }
            if (this.tbVFmin.Text == "")
            {
                this.tbVFmin.Text = "0";
            }
            if (this.tbVFmax.Text == "")
            {
                this.tbVFmax.Text = "0";
            }
            if (this.tbVBRmin.Text == "")
            {
                this.tbVBRmin.Text = "0";
            }
            if (this.tbVBRmax.Text == "")
            {
                this.tbVBRmax.Text = "0";
            }

            if (this.tbCSmin.Text == "")
            {
                this.tbCSmin.Text = "0";
            }
            if (this.tbCSmax.Text == "")
            {
                this.tbCSmax.Text = "0";
            }
            mogt.LD_CSPomin = Convert.ToDecimal(this.tbCSmin.Text);
            mogt.LD_CSPomax = Convert.ToDecimal(this.tbCSmax.Text);
            mogt.LD_LDKINK = Convert.ToInt32(this.tbLDKINK.Text);
            mogt.LD_PDKINK = Convert.ToInt32(this.tbPTKINK.Text);
            mogt.GD_if = this.tbIf.Text;
            mogt.PT_ICCmin = Convert.ToInt32(this.tbICCmin.Text);
            mogt.PT_ICCmax = Convert.ToInt32(this.tbICCmax.Text);
            mogt.GD_imoMin = Convert.ToInt32(this.tbIMOmin.Text);
            mogt.GD_imoMax = Convert.ToInt32(this.tbIMOmax.Text);
            mogt.GD_ccglMin = Convert.ToDecimal(this.tbCCGLmin.Text);
            mogt.GD_ccglMax = Convert.ToDecimal(this.tbCCGLmax.Text);
            mogt.GD_ithMin = Convert.ToInt32(this.tbITHmin.Text);
            mogt.GD_ithMax = Convert.ToInt32(this.tbITHmax.Text);
            mogt.GD_vfMin = Convert.ToDecimal(this.tbVFmin.Text);
            mogt.GD_vfMax = Convert.ToDecimal(this.tbVFmax.Text);
            mogt.GD_ptsl = this.tbPTSL.Text;
            mogt.GD_vbrMin = Convert.ToInt32(this.tbVBRmin.Text);
            mogt.GD_vbrMax = Convert.ToInt32(this.tbVBRmax.Text);

            mogt.fh产品名称 = this.rtbCPMC.Text;
            mogt.Description = this.tbDESCEIP.Text;
            mogt.物料代码 = this.cbWLDM.Text;
            mogt.型号属性 = this.cbXHSX.Text;
            mogt.Specification = this.cbSPEC.Text;
            mogt.客户型号 = this.cbKHXH.Text;
            mogt.LD芯片型号 = this.cbLDCHIPXH.Text;
            mogt.PT芯片型号 = this.cbPTCHIPXH.Text;
            mogt.生产日期 = Convert.ToDateTime(this.textBox1.Text);
            mogt.Quantity1 = this.tbQUA_PO.Text;
            mogt.Quantity2 = this.tbQUA_SEN.Text;
            mogt.数量 = this.tbSL.Text;
            bool result = false;

            try
            {
                //result = gt.Add(mogt);
                result = gtbll.Add(mogt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            if (result == true)
            {
                MessageBox.Show("添加成功", "提示");
                btnCHANGE.Enabled = true;
                btnCHANGE.BackColor = Color.MediumSlateBlue;
            }
            else
            {
                MessageBox.Show("添加失败", "提示");
            }
            
           
        }

        /// <summary>
        /// 当combobox中的值改变时查询信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbGGSBH_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectSpec2();
        }

        private void SelectSpec2()
        {
            var name =cbGGSBH.SelectedValue.ToString();
            Maticsoft.Model.tsuhan_spec spec = specbll.GetModel(name);
             if (name!="")
             {
                
                 this.txtCPBM.Text = spec.成品编码;
                 this.txtCPXH.Text = spec.产品型号;
                 this.tbKHDM.Text = spec.客户代码;
                 this.tbLDKINK.Text = Convert.ToString(spec.Pkinkmax);
                 this.tbPTKINK.Text = Convert.ToString(spec.Kimomin);

                 this.tbCSTJ.Text = spec.码型;
                 this.tbCSPL.Text = Convert.ToString(spec.速率);
                 this.tbLMDtype.Text = spec.PT方法;
                 this.tbLMDvalue.Text = Convert.ToString(spec.Sen);

                 this.tbICCmin.Text = Convert.ToString(spec.Iccmin);
                 this.tbICCmax.Text = Convert.ToString(spec.Iccmax);
                 this.tbIf.Text = Convert.ToString(spec.LD方法);
                 this.tbCCGLmin.Text = Convert.ToString(spec.Pomin);
                 this.tbCCGLmax.Text = Convert.ToString(spec.Pomax);
                 this.tbIMOmin.Text = Convert.ToString(spec.Imomin);
                 this.tbIMOmax.Text = Convert.ToString(spec.Imomax);
                 this.tbITHmin.Text = Convert.ToString(spec.Ithmin);
                 this.tbITHmax.Text = Convert.ToString(spec.Ithmax);
                 this.tbVFmin.Text = Convert.ToString(spec.Vfmin);
                 this.tbVFmax.Text = Convert.ToString(spec.Vfmax);
                 this.tbPTSL.Text = Convert.ToString(spec.速率);
                 this.tbVBRmin.Text = Convert.ToString(spec.Vbrmin);
                 this.tbVBRmax.Text = Convert.ToString(spec.Vbrmax);
             }
           
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCHANGE_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要修改吗？？？","提示",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (tbsgdxh1.Text.Trim() != "")
                {


                    Maticsoft.Model.tsuhan_sg_gt mogt = new Maticsoft.Model.tsuhan_sg_gt();
                    var bhd = this.tbBHDH.Text;
                    var gt = gtbll.GetModel(bhd);
                    mogt.id = gt.id;
                    mogt.合同编号 = this.tbHTBH.Text;
                    mogt.备货单号 = this.tbBHDH.Text;
                    if (this.tbBHDSL.Text=="")
                    {
                        this.tbBHDSL.Text = "0";
                    }
                    mogt.备货单数量 = Convert.ToInt32(this.tbBHDSL.Text);
                    mogt.表格编号 = this.tbBGBH1.Text + "-" + this.tbBGBH2.Text;
                    mogt.产品名称 = this.cbCPMC.Text;
                    mogt.产品类型 = this.txtCPXH.Text;
                    mogt.成品编码 = this.txtCPBM.Text;
                    mogt.产品图号 = this.cbCPTH.Text;
                    mogt.客户代码 = this.tbKHDM.Text;
                    mogt.规格书编号 = this.cbGGSBH.Text;
                    mogt.计划编制 = this.tbJHBZ.Text;
                    mogt.技术审核 = this.tbJSSH.Text;
                    mogt.生产审核 = this.tbSCSH.Text;
                    mogt.交货日期 = Convert.ToDateTime(this.dTPjh.Text);
                    mogt.下单日期 = Convert.ToDateTime(this.dTPxd.Text);
                    mogt.录入时间 = Convert.ToDateTime(this.tsslLRTIMEtxt.Text);
                    mogt.录入员 = this.tsslLRYtxt.Text;
                    mogt.BK_A = this.tbAM.Text;
                    mogt.BK_B = this.tbBM.Text;
                    #region
                    if (this.tbCM2.Text == "")
                    {
                        this.tbCM2.Text = "0000";
                    }
                    mogt.BK_C = this.tbCM1.Text + "-" + this.tbCM2.Text;
                    if (this.tbSGKSL.Text == "")
                    {
                        mogt.随工卡数量 = null;
                    }
                    else
                    {
                        mogt.随工卡数量 = Convert.ToInt32(this.tbSGKSL.Text);
                    }

                    if (this.tbJJ.Text == "")
                    {
                        mogt.LD_LDjj = null;
                    }
                    else
                    {
                        mogt.LD_LDjj = Convert.ToDecimal(this.tbJJ.Text);
                    }
                    if (this.tbHQGLmin.Text == "")
                    {
                        mogt.GDW_xhcs = null;
                    }
                    else
                    {
                        mogt.GDW_xhcs = Convert.ToInt32(this.tbXHCS.Text);
                    }
                    if (this.tbHQGLmin.Text == "")
                    {
                        mogt.OH_hqPomin = null;
                    }
                    else
                    {
                        mogt.OH_hqPomin = Convert.ToDecimal(this.tbHQGLmin.Text);
                    }
                    if (this.tbHQGLmax.Text == "")
                    {
                        mogt.OH_hqPomax = null;
                    }
                    else
                    {
                        mogt.OH_hqPomax = Convert.ToDecimal(this.tbHQGLmax.Text);
                    }

                    if (this.tbHHGLmin.Text == "")
                    {
                        mogt.OH_hhPomin = null;
                    }
                    else
                    {
                        mogt.OH_hhPomin = Convert.ToDecimal(this.tbHHGLmin.Text);
                    }

                    if (this.tbHHGLmax.Text == "")
                    {
                        mogt.OH_hhPomax = null;
                    }
                    else
                    {
                        mogt.OH_hhPomax = Convert.ToDecimal(this.tbHHGLmax.Text);
                    }

                    if (this.tbRXGL.Text == "")
                    {
                        mogt.PT_rqgl = null;
                    }
                    else
                    {
                        mogt.PT_rqgl = Convert.ToInt32(this.tbRXGL.Text);
                    }

                    if (this.tbGDLmin.Text == "")
                    {
                        mogt.PT_gdlmin = null;
                    }
                    else
                    {
                        mogt.PT_gdlmin =this.tbGDLmin.Text;
                    }

                    if (this.tbGDLmax.Text == "")
                    {
                        mogt.PT_gdlmax = null;
                    }
                    else
                    {
                        mogt.PT_gdlmax = this.tbGDLmax.Text;
                    }


                    if (this.tbHQPo.Text == "")
                    {
                        mogt.OH_hqBFB = null;
                    }
                    else if (Convert.ToInt32(this.tbHQPo.Text.Trim()) > 100)
                    {
                        MessageBox.Show("输入的" + lblHQ.Text + "不能大于100", "提示");
                        return;
                    }
                    else if (Convert.ToInt32(this.tbHQPo.Text.Trim()) < 0)
                    {
                        MessageBox.Show("输入的" + lblHQ.Text + "不能小于0", "提示");
                        return;
                    }
                    else
                    {
                        mogt.OH_hqBFB = Convert.ToInt32(this.tbHQPo.Text);
                    }

                    if (this.tbHHPo.Text == "")
                    {
                        mogt.OH_hhBFB = null;
                    }
                    else if (Convert.ToInt32(this.tbHHPo.Text.Trim()) > 100)
                    {
                        MessageBox.Show("输入的" + lblHH.Text + "不能大于100", "提示");
                        return;
                    }
                    else if (Convert.ToInt32(this.tbHHPo.Text.Trim()) < 0)
                    {
                        MessageBox.Show("输入的" + lblHH.Text + "不能小于0", "提示");
                        return;
                    }
                    else
                    {
                        mogt.OH_hhBFB = Convert.ToInt32(this.tbHHPo.Text);
                    }


                    if (this.tbCSPo.Text == "")
                    {
                        mogt.LD_CSBFB = null;
                    }
                    else if (Convert.ToInt32(this.tbCSPo.Text.Trim()) > 100)
                    {
                        MessageBox.Show("输入的" + lblCS.Text + "不能大于100", "提示");
                        return;
                    }
                    else if (Convert.ToInt32(this.tbCSPo.Text.Trim()) < 0)
                    {
                        MessageBox.Show("输入的" + lblCS.Text + "不能小于0", "提示");
                        return;
                    }
                    else
                    {
                        mogt.LD_CSBFB = Convert.ToInt32(this.tbCSPo.Text);
                    }

                    if (this.tbCSWDmin.Text == "")
                    {
                        mogt.JX_wdMin = null;
                    }
                    else
                    {
                        mogt.JX_wdMin = Convert.ToInt32(this.tbCSWDmin.Text);
                    }
                    if (this.tbCSWDmax.Text == "")
                    {
                        mogt.JX_wdMax = null;
                    }
                    else
                    {
                        mogt.JX_wdMax = Convert.ToInt32(this.tbCSWDmax.Text);
                    }
                    #endregion
                    mogt.GX_hjfs = this.tbHJFS.Text;
                    mogt.DM_dmzl = this.tbDMZL.Text;

                    mogt.JX_ptwwj = this.tbPTWWJ.Text;
                    mogt.JX_zz = this.tbZZFX.Text;
                    mogt.JX_pthigh = this.tbPTGD.Text;
                    mogt.JX_ptgj = this.tbPTtype.Text;
                    mogt.JX_ldgj = this.tbLDtype.Text;
                    mogt.BZ_QJbq = this.cbQJBQ.Text;
                    if (this.tbLDKINK.Text == "")
                    {
                        this.tbLDKINK.Text = "0";
                    }
                    if (this.tbPTKINK.Text == "")
                    {
                        this.tbPTKINK.Text = "0";
                    }
                    if (this.tbICCmin.Text == "")
                    {
                        this.tbICCmin.Text = "0";
                    }
                    if (this.tbICCmax.Text == "")
                    {
                        this.tbICCmax.Text = "0";
                    }
                    if (this.tbIMOmin.Text == "")
                    {
                        this.tbIMOmin.Text = "0";
                    }
                    if (this.tbIMOmax.Text == "")
                    {
                        this.tbIMOmax.Text = "0";
                    }
                    if (this.tbCCGLmin.Text == "")
                    {
                        this.tbCCGLmin.Text = "0";
                    }
                    if (this.tbCCGLmax.Text == "")
                    {
                        this.tbCCGLmax.Text = "0";
                    }
                    if (this.tbITHmin.Text == "")
                    {
                        this.tbITHmin.Text = "0";
                    }
                    if (this.tbITHmax.Text == "")
                    {
                        this.tbITHmax.Text = "0";
                    }
                    if (this.tbVFmin.Text == "")
                    {
                        this.tbVFmin.Text = "0";
                    }
                    if (this.tbVFmax.Text == "")
                    {
                        this.tbVFmax.Text = "0";
                    }
                    if (this.tbVBRmin.Text == "")
                    {
                        this.tbVBRmin.Text = "0";
                    }
                    if (this.tbVBRmax.Text == "")
                    {
                        this.tbVBRmax.Text = "0";
                    }
                    if (this.tbCSmin.Text == "")
                    {
                        this.tbCSmin.Text = "0";
                    }
                    if (this.tbCSmax.Text == "")
                    {
                        this.tbCSmax.Text = "0";
                    }
                    mogt.LD_CSPomin = Convert.ToDecimal(this.tbCSmin.Text);
                    mogt.LD_CSPomax = Convert.ToDecimal(this.tbCSmax.Text);
                    mogt.LD_LDKINK = Convert.ToInt32(this.tbLDKINK.Text);
                    mogt.LD_PDKINK = Convert.ToInt32(this.tbPTKINK.Text);
                    mogt.GD_if = this.tbIf.Text;
                    mogt.PT_ICCmin = Convert.ToInt32(this.tbICCmin.Text);
                    mogt.PT_ICCmax = Convert.ToInt32(this.tbICCmax.Text);
                    mogt.GD_imoMin = Convert.ToInt32(this.tbIMOmin.Text);
                    mogt.GD_imoMax = Convert.ToInt32(this.tbIMOmax.Text);
                    mogt.GD_ccglMin = Convert.ToDecimal(this.tbCCGLmin.Text);
                    mogt.GD_ccglMax = Convert.ToDecimal(this.tbCCGLmax.Text);
                    mogt.GD_ithMin = Convert.ToInt32(this.tbITHmin.Text);
                    mogt.GD_ithMax = Convert.ToInt32(this.tbITHmax.Text);
                    mogt.GD_vfMin = Convert.ToDecimal(this.tbVFmin.Text);
                    mogt.GD_vfMax = Convert.ToDecimal(this.tbVFmax.Text);
                    mogt.GD_ptsl = this.tbPTSL.Text;
                    mogt.GD_vbrMin = Convert.ToInt32(this.tbVBRmin.Text);
                    mogt.GD_vbrMax = Convert.ToInt32(this.tbVBRmax.Text);
                    mogt.fh产品名称 = this.rtbCPMC.Text;
                    mogt.Description = this.tbDESCEIP.Text;
                    mogt.物料代码 = this.cbWLDM.Text;
                    mogt.型号属性 = this.cbXHSX.Text;
                    mogt.Specification = this.cbSPEC.Text;
                    mogt.客户型号 = this.cbKHXH.Text;
                    mogt.LD芯片型号 = this.cbLDCHIPXH.Text;
                    mogt.PT芯片型号 = this.cbPTCHIPXH.Text;
                    mogt.生产日期 = Convert.ToDateTime(this.textBox1.Text);
                    mogt.Quantity1 = this.tbQUA_PO.Text;
                    mogt.Quantity2 = this.tbQUA_SEN.Text;
                    mogt.数量 = this.tbSL.Text;

                    bool result = false;

                    try
                    {
                        result = gtbll.Update(mogt);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        return;
                    }
                    if (result == true)
                    {
                        MessageBox.Show("修改成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示");
                    }

                }
            }
            else if (dr==DialogResult.No)
            {
                return;
            }
        }
        #endregion

        #region 百分比

        /// <summary>
        /// 焊前功率百分比鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbHQPo_MouseLeave(object sender, EventArgs e)
        {
            if (tbHQPo.Text != "")
            {
                
                decimal hqPo = Convert.ToDecimal(this.tbHQPo.Text.ToString().Trim());
                decimal tbccGLmin = Convert.ToDecimal(this.tbCCGLmin.Text.ToString().Trim());
                decimal tbccGLmax = Convert.ToDecimal(this.tbCCGLmax.Text.ToString().Trim());
                this.tbHQGLmin.Text = (tbccGLmin * (hqPo / 100)).ToString();
                this.tbHQGLmax.Text = (tbccGLmax * (1 - hqPo / 100)).ToString();
            }
           
           
        }
        /// <summary>
        /// 焊后功率百分比鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbHHPo_MouseLeave(object sender, EventArgs e)
        {
            if (tbHHPo.Text != "")
            {
                decimal hhPo = Convert.ToDecimal(this.tbHHPo.Text.ToString().Trim());
                decimal tbccGLmin = Convert.ToDecimal(this.tbCCGLmin.Text.ToString().Trim());
                decimal tbccGLmax = Convert.ToDecimal(this.tbCCGLmax.Text.ToString().Trim());
                this.tbHHGLmin.Text = (tbccGLmin * (hhPo / 100)).ToString();
                this.tbHHGLmax.Text = (tbccGLmax * (1 - hhPo / 100)).ToString();
            }
        }

        /// <summary>
        /// 测试功率百分比鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCSPo_MouseLeave(object sender, EventArgs e)
        {
            if (tbCSPo.Text != "")
            {
                decimal csPo = Convert.ToDecimal(this.tbCSPo.Text.ToString().Trim());
                decimal tbccGLmin = Convert.ToDecimal(this.tbCCGLmin.Text.ToString().Trim());
                decimal tbccGLmax = Convert.ToDecimal(this.tbCCGLmax.Text.ToString().Trim());
                this.tbCSmin.Text = (tbccGLmin * (csPo / 100)).ToString();
                this.tbCSmax.Text = (tbccGLmax * (1 - csPo / 100)).ToString();
            }
        }
        #endregion

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
            else if (key==Keys.Right)
            {
                SendKeys.Send("{Tab}"); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// 确定键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void btnOK_Click(object sender, EventArgs e)
         {
             if (this.tbsgdxh1.Text == "")
             {
                 MessageBox.Show("随工单号不能为空", "提示");
             }
             else
             {

                 DialogResult dr = MessageBox.Show("确定要添加吗？？？", "提示", MessageBoxButtons.OKCancel);
                 if (dr == DialogResult.OK)
                 {
                     btnUPDATA.Enabled = true;
                     btnUPDATA.BackColor = Color.SlateBlue;
                 }
                 else
                 {
                     btnUPDATA.Enabled = false;
                     btnUPDATA.BackColor = Color.Gray;
                 }
             }
         }

         private void tbKHDM_MouseLeave(object sender, EventArgs e)
         {
             var dm = this.tbKHDM.Text;
             bool result = kehdmbll.Exist(dm);
             if (result!=true)
             {
                 MessageBox.Show("你输入的客户代码不存在","提示");
                 return;
             }
         }

         private void btnCANCEL_Click(object sender, EventArgs e)
         {
             this.Close();
         }

        /// <summary>
        /// 判断是否输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void tbBHDSL_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 45 && e.KeyChar != 46)
             {
                 e.Handled = true;
             }

             //输入为负号时，只能输入一次且只能输入一次 

             if (e.KeyChar == 45 && (((TextBox)sender).SelectionStart != 0 || ((TextBox)sender).Text.IndexOf("-") >= 0))
             {
                 e.Handled = true;
             }

             //输入为小数点时，只能输入一次且只能输入一次 

             if (e.KeyChar == 46 && ((TextBox)sender).Text.IndexOf(".") >= 0)
             {
                 e.Handled = true;
             }
         }

         private void tbsgdxh1_Leave(object sender, EventArgs e)
         {
             SelectDan();
         }
    }

}
