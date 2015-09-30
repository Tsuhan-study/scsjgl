using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Maticsoft.Model;
using System.Text.RegularExpressions;

namespace scsjgl
{
    public partial class SuiGongDanJTXX : Form
    {
       
        SpecBLL specbll = new SpecBLL();
        GtBLL gtbll = new GtBLL();
        YhBLL yhbll = new YhBLL();
        BhdBLL bhdbll = new BhdBLL();
        TxBLL txbll = new TxBLL();
        //Login frmOne;
        string gh =Login.name;

        Register rg = new Register();
        public SuiGongDanJTXX()
        {
            //frmOne = form1;
            InitializeComponent();
        }
       
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuiGongDanJTXX_Load(object sender, EventArgs e)
        {
            this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.dtpxctime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.dtpxctime4.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");

            this.tbDXH1.Enabled = false;
            this.tbDXH1.BackColor = Color.LightGray;
            this.btnSend.Enabled = false;
            this.btnSend.BackColor = Color.LightGray;
            //var name = Convert.ToInt32(gh);
           // this.btnUpdate.Enabled = false;
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);
            this.btnOk.Enabled = false;
            this.btnSend.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.BackColor = Color.LightGray;
            this.btnCancel.Enabled = false;
            this.dtpqcTime1.Enabled = false;
           
        }

        /// <summary>
        /// 根据备货单号查询
        /// </summary>
        private void BeiHuoBind()
        {
           
            var beiHuo = tbSGDXH.Text;
            bool result;
            result = gtbll.Exists(beiHuo);
            tsuhan_sg_bhd bhd = bhdbll.QueryByBei(beiHuo);
            if (result == true)
            {
                this.tbDXH1.Enabled = true;
                this.tbDXH1.BackColor = Color.White;
                //根据备货单号查询相关信息
                tsuhan_sg_gt gt = gtbll.GetModel(beiHuo);
                this.tbBGBH1.Text = gt.表格编号;
                this.tbHTBH.Text = gt.合同编号;
                this.tbGGS.Text = gt.规格书编号;
                this.tbJHDate.Text = Convert.ToString(gt.交货日期);
                this.tbXDDate.Text = Convert.ToString(gt.下单日期);
                bool relst;
                relst = bhdbll.Exists(beiHuo);
                if (relst == true)
                {
                    //LD芯管
                    this.textBox34.Text = bhd.LD_xh;
                    this.textBox35.Text = bhd.LD_name;
                    this.textBox36.Text = bhd.LD_sjdh;
                    //PT芯管
                    this.textBox39.Text = bhd.PT_xh;
                    this.textBox38.Text = bhd.PT_name;
                    this.textBox37.Text = bhd.PT_sjdh;
                    //壳体
                    this.textBox42.Text = bhd.KT_xh;
                    this.textBox41.Text = bhd.KT_name;
                    this.textBox40.Text = bhd.KT_sjdh;
                    //0度滤波片
                    this.textBox45.Text = bhd.NBP_xh0;
                    this.textBox44.Text = bhd.NBP_name0;
                    this.textBox43.Text = bhd.NBP_sjdh0;
                    //45度滤波片
                    this.textBox51.Text = bhd.NBP_xh45;
                    this.textBox50.Text = bhd.NBP_name45;
                    this.textBox49.Text = bhd.NBP_sjdh45;
                    //接口组件
                    this.textBox48.Text = bhd.JK_xh;
                    this.textBox47.Text = bhd.JK_name;
                    this.textBox46.Text = bhd.JK_sjdh;

                    //this.tabControl1.Enabled = true;
                }
                else
                {
                    //MessageBox.Show("原材料数据还未入库！", "提示");
                    this.btnUpdate.Enabled = false;
                    this.btnUpdate.BackColor = Color.LightGray;
                    this.btnOk.Enabled = true;
                    this.btnOk.BackColor = Color.Teal;
                    //this.tabControl1.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("该备货单还没有记录", "提示");
                this.tbDXH1.Enabled = false;
                this.tbDXH1.BackColor = Color.LightGray;
                this.btnUpdate.Enabled = false;
                this.btnUpdate.BackColor = Color.LightGray;
                this.btnOk.Enabled = true;
                this.btnOk.BackColor = Color.Teal;
                return;
            }
           
            
        }

        /// <summary>
        /// 鼠标移开备货单号文本框事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSGDXH_MouseLeave(object sender, EventArgs e)
        {
            BeiHuoBind();
        }

        /// <summary>
        /// 鼠标移开备货单号序号文本框事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDXH1_MouseLeave(object sender, EventArgs e)
        {
            //var name = Convert.ToInt32(gh);
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);
            var dxuhao = this.tbSGDXH.Text + this.tbDXH1.Text;
            var str = dxuhao.Substring(dxuhao.Length - 1, 1);

            
            if (str == "R")
            {

                bool result = false;
                result = txbll.Exists(dxuhao);
                if (result == true)
                {
                    this.btnUpdate.Enabled = true;
                    this.btnUpdate.BackColor = Color.Teal;
                    this.btnOk.Enabled = false;
                    this.btnOk.BackColor = Color.LightGray;
                    this.btnSend.Enabled = false;
                    this.btnSend.BackColor = Color.LightGray;
                    if (this.tbDXH1.Text != "")
                    {

                        var beiHuo = tbSGDXH.Text;
                        tsuhan_sg_tx tx = txbll.QueryByXuhao(dxuhao);


                        #region 过程数据记录
                        //流水号
                        this.tbLSH1.Text = tx.lsh1;
                        this.tbLSH2.Text = tx.lsh2;
                        this.tbLSH3.Text = tx.lsh3;
                        //CASE
                        this.tbCASE1.Text = tx.case1;
                        this.tbCASE2.Text = tx.case2;
                        this.tbCASE3.Text = tx.case3;
                        //LD+
                        this.tbLDP1.Text = tx.ld1;
                        this.tbLDP2.Text = tx.ld2;
                        this.tbLDP3.Text = tx.ld3;
                        //PD+
                        this.tbPDP1.Text = tx.pd1;
                        this.tbPDP2.Text = tx.pd2;
                        this.tbPDP3.Text = tx.pd3;
                        //LD-
                        this.tbLDN1.Text = tx.ldj1;
                        this.tbLDN2.Text = tx.ldj2;
                        this.tbLDN3.Text = tx.ldj3;
                        //极差
                        this.tbJC1.Text = Convert.ToString(tx.jc1);
                        this.tbJC2.Text = Convert.ToString(tx.jc2);
                        this.tbJC3.Text = Convert.ToString(tx.jc3);
                        //凹陷量
                        this.tbAXL1.Text = tx.oxl1;
                        this.tbAXL2.Text = tx.oxl2;
                        this.tbAXL3.Text = tx.oxl3;
                        this.tbjj.Text = tx.ldxp_xinpianjj;
                        this.tbjyry.Text = tx.ldxp_jianyanry;
                        this.tbjysb.Text = tx.ldxp_jianyansb;
                        this.rtbremark.Text = tx.备注;
                        this.textBox34.Text = tx.LD_xh;
                        this.textBox35.Text = tx.LD_name;
                        this.textBox36.Text = tx.LD_sjdh;
                        this.textBox39.Text = tx.PT_xh;
                        this.textBox38.Text = tx.PT_name;
                        this.textBox37.Text = tx.PT_sjdh;
                        this.textBox42.Text = tx.KT_xh;
                        this.textBox41.Text = tx.KT_name;
                        this.textBox40.Text = tx.KT_sjdh;
                        this.textBox45.Text = tx.NBP_xh0;
                        this.textBox44.Text = tx.NBP_name0;
                        this.textBox43.Text = tx.NBP_sjdh0;
                        this.textBox51.Text = tx.NBP_xh45;
                        this.textBox50.Text = tx.NBP_name45;
                        this.textBox49.Text = tx.NBP_sjdh45;
                        this.textBox48.Text = tx.JK_xh;
                        this.textBox47.Text = tx.JK_name;
                        this.textBox46.Text = tx.JK_sjdh;

                        #endregion

                        #region 全部
                        if (yh.机构 == "全部")
                        {
                            this.btnUpdate.Enabled = true;
                            this.btnUpdate.BackColor = Color.Teal;
                            this.btnCancel.Enabled = false;
                            this.btnCancel.BackColor = Color.LightGray;
                            this.btnOk.Enabled = false;
                            this.btnOk.BackColor = Color.LightGray;
                            this.dtpfrtime1.Enabled = true;
                            this.dtpqcTime1.Enabled = true;
                            #region 全部
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            var lry1 = this.tblry.Text = tx.bl_lry;
                            if (lry1 == null || lry1 == "0")
                            {
                                this.tblry.Text = gh;
                                this.tblrName.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                            }
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            this.tabControl1.Enabled = true;
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            var lry2 = this.tblr1.Text = tx.LD_lry;
                            if (lry2 == "" || lry2 == "0")
                            {
                                this.tblr1.Text = gh;
                                this.tblrname1.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                            }
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion

                            #region PT耦合固化
                            this.tb5.Text = tx.PT_sbbh1;
                            this.tb6.Text = tx.PT_sbbh2;
                            this.tb7.Text = tx.PT_sbbh3;
                            this.tb8.Text = tx.PT_sbbh4;
                            this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                            this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                            if (tx.PT_xctime == null)
                            {
                                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz5.Text = tx.PT_czy1;
                            this.tbcz6.Text = tx.PT_czy2;
                            this.tbcz7.Text = tx.PT_czy3;
                            this.tbcz8.Text = tx.PT_czy4;
                            this.tbname5.Text = tx.PT_czyname1;
                            this.tbname6.Text = tx.PT_czyname2;
                            this.tbname7.Text = tx.PT_czyname3;
                            this.tbname8.Text = tx.PT_czyname4;
                            var lry3 = this.tblr2.Text = tx.PT_lry;
                            if (lry3 == "" || lry3 == "0")
                            {
                                this.tblr2.Text = gh;
                                this.tblrname2.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr2.Text = tx.PT_lry;
                                this.tblrname2.Text = tx.PT_lryname;
                            }
                            this.tbyy21.Text = Convert.ToString(tx.ptng1);
                            this.tbyy22.Text = Convert.ToString(tx.ptng2);
                            this.tbyy23.Text = Convert.ToString(tx.ptng3);
                            this.tbyy24.Text = Convert.ToString(tx.ptng4);
                            this.tbyy25.Text = Convert.ToString(tx.ptng5);
                            this.tbyy26.Text = Convert.ToString(tx.ptng6);
                            this.tbyy27.Text = Convert.ToString(tx.ptng7);
                            this.tbyy28.Text = Convert.ToString(tx.ptng8);
                            this.tbyy29.Text = Convert.ToString(tx.ptng9);
                            this.tbyy30.Text = tx.ptngoth;
                            this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                            this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                            #endregion

                            #region 温循前
                            this.tb9.Text = tx.WXQ_sbbh;
                            this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                            this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                            if (tx.WXQ_xctime == null)
                            {
                                this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbcz9.Text = tx.WXQ_czy;
                            this.tbname9.Text = tx.WXQ_czyname;
                            var lry4 = this.tblr3.Text = tx.WXQ_lry;
                            if (lry4 == "" || lry4 == "0")
                            {
                                this.tblr3.Text = gh;
                                this.tblrname3.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr3.Text = tx.WXQ_lry;
                                this.tblrname3.Text = tx.WXQ_lryname;
                            }
                            this.rtbremark2.Text = tx.WXQ_remark;
                            #endregion

                            #region 温循后
                            this.tb10.Text = tx.WXH_sbbh;
                            this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                            this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                            if (tx.WXH_xctime == null)
                            {
                                this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbwxsc.Text = tx.WXH_wxsc;
                            this.tbcz10.Text = tx.WXH_czy;
                            this.tbname10.Text = tx.WXH_czyname;
                            var lry5 = this.tblr4.Text = tx.WX_Hlry;
                            if (lry5 == "" || lry5 == "0")
                            {
                                this.tblr4.Text = gh;
                                this.tblrname4.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr4.Text = tx.WX_Hlry;
                                this.tblrname4.Text = tx.WXH_lryname;
                            }
                            this.rtbremark3.Text = tx.WXH_remark;
                            #endregion

                            #region 测试
                            this.tb11.Text = tx.CS_sbbh1;
                            this.tb12.Text = tx.CS_sbbh2;
                            this.tb13.Text = tx.CS_sbbh3;
                            this.tb14.Text = tx.CS_sbbh4;
                            this.tbsjsl4.Text = Convert.ToString(tx.CS_sjsl);
                            this.tbxcsl4.Text = Convert.ToString(tx.CS_xcsl);
                            if (tx.CS_xctime == null)
                            {
                                this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxtime3.Text = Convert.ToDateTime(tx.CS_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz11.Text = tx.CS_czy1;
                            this.tbcz12.Text = tx.CS_czy2;
                            this.tbcz13.Text = tx.CS_czy3;
                            this.tbcz14.Text = tx.CS_czy4;
                            this.tbname11.Text = tx.CS_czyname1;
                            this.tbname12.Text = tx.CS_czyname2;
                            this.tbname13.Text = tx.CS_czyname3;
                            this.tbname14.Text = tx.CS_czyname4;
                            var lry6 = this.tblr5.Text = tx.CS_lry;
                            if (lry6 == "" || lry6 == "0")
                            {
                                this.tblr5.Text = gh;
                                this.tblrname5.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr5.Text = tx.CS_lry;
                                this.tblrname5.Text = tx.CS_lryname;
                            }
                            this.tbyy31.Text = Convert.ToString(tx.csng1);
                            this.tbyy32.Text = Convert.ToString(tx.csng2);
                            this.tbyy33.Text = Convert.ToString(tx.csng3);
                            this.tbyy34.Text = Convert.ToString(tx.csng4);
                            this.tbyy35.Text = Convert.ToString(tx.csng5);
                            this.tbyy36.Text = Convert.ToString(tx.csng6);
                            this.tbyy37.Text = Convert.ToString(tx.csng7);
                            this.tbyy38.Text = Convert.ToString(tx.csng8);
                            this.rtbyy39.Text = tx.csngoth;
                            this.tbyy39sl.Text = Convert.ToString(tx.csngothnum);
                            this.tbbhgsl2.Text = Convert.ToString(tx.CS_bhgallsl);
                            #endregion

                            #region 清洗
                            this.tb15.Text = tx.QX_sbbh1;
                            this.tb16.Text = tx.QX_sbbh2;
                            this.tb17.Text = tx.QX_sbbh3;
                            this.tb18.Text = tx.QX_sbbh4;
                            this.tbsjsl5.Text = Convert.ToString(tx.QX_sjsl);
                            this.tbxcsl5.Text = Convert.ToString(tx.QX_xcsl);
                            if (tx.QX_xctime == null)
                            {
                                this.dtpxctime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxctime3.Text = Convert.ToDateTime(tx.QX_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz15.Text = tx.QX_czy1;
                            this.tbcz16.Text = tx.QX_czy2;
                            this.tbcz17.Text = tx.QX_czy3;
                            this.tbcz18.Text = tx.QX_czy4;
                            this.tbname15.Text = tx.QX_czyname1;
                            this.tbname16.Text = tx.QX_czyname2;
                            this.tbname17.Text = tx.QX_czyname3;
                            this.tbname18.Text = tx.QX_czyname4;
                            var lry7 = this.tblr6.Text = tx.QX_lry;
                            if (lry7 == "" || lry7 == "0")
                            {
                                this.tblr6.Text = gh;
                                this.tblrname6.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr6.Text = tx.QX_lry;
                                this.tblrname6.Text = tx.QX_lryname;
                            }
                            this.tbyy40.Text = Convert.ToString(tx.qxng1);
                            this.rtbyy41.Text = tx.qxngoth;
                            this.tbyy41sl.Text = Convert.ToString(tx.qxngothnum);
                            this.tbbhgsl3.Text = Convert.ToString(tx.QX_bhgallsl);
                            #endregion

                            #region 包装
                            this.tb19.Text = tx.BZ_sbbh1;
                            this.tb20.Text = tx.BZ_sbbh2;
                            this.tb21.Text = tx.BZ_sbbh3;
                            this.tb22.Text = tx.BZ_sbbh4;
                            this.tbsjsl6.Text = Convert.ToString(tx.BZ_sjsl);
                            this.tbxcsl6.Text = Convert.ToString(tx.BZ_xcsl);
                            if (tx.BZ_xctime == null)
                            {
                                this.dtpxctime4.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxctime4.Text = Convert.ToDateTime(tx.BZ_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz19.Text = tx.BZ_czy1;
                            this.tbcz20.Text = tx.BZ_czy2;
                            this.tbcz21.Text = tx.BZ_czy3;
                            this.tbcz22.Text = tx.BZ_czy4;
                            this.tbname19.Text = tx.BZ_czyname1;
                            this.tbname20.Text = tx.BZ_czyname2;
                            this.tbname21.Text = tx.BZ_czyname3;
                            this.tbname22.Text = tx.BZ_czyname4;
                            var lry8 = this.tblr7.Text = tx.BZ_lry;
                            if (lry8 == "" || lry8 == "0")
                            {
                                this.tblr7.Text = gh;
                                this.tblrname7.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr7.Text = tx.BZ_lry;
                                this.tblrname7.Text = tx.BZ_lryname;
                            }
                            this.tbyy42.Text = Convert.ToString(tx.bzng1);
                            this.rtbyy43.Text = tx.bzngoth;
                            this.tbyy43sl.Text = Convert.ToString(tx.bzngothnum);
                            this.tbbhgsl4.Text = Convert.ToString(tx.BZ_bhgallsl);
                            #endregion
                            #endregion
                        }

                        #endregion

                        #region 备料
                        if (yh.机构 == "备料")
                        {
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            var lry = this.tblry.Text = tx.bl_lry;
                            if (lry == null || lry == "0")
                            {
                                this.tblry.Text = gh;
                                this.tblrName.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                            }
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            this.tabControl1.Enabled = true;
                            #endregion
                        }
                        #endregion

                        #region LD耦合焊接
                        if (yh.机构 == "LD耦合焊接")
                        {
                            //var xiacsl = tx.bl_xcsl;
                            //if (xiacsl == null)
                            //{
                            //    MessageBox.Show("备料工序还没做完,无法进行下一步", "提示");
                            //    this.tabControl1.Enabled = false;
                            //    this.btnUpdate.Enabled = false;
                            //    this.btnUpdate.BackColor = Color.LightGray;
                            //    return;
                            //}
                            //else
                            //{
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            this.tblry.Text = tx.bl_lry;
                            this.tblrName.Text = tx.bl_lryname;
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            if (tx.LD_sjsl == null)
                            {
                                this.tbsjsl1.Text = Convert.ToString(tx.bl_xcsl);
                            }
                            else
                            {
                                this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            }
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            var lry = this.tblr1.Text = tx.LD_lry;
                            if (lry == "" || lry == "0")
                            {
                                this.tblr1.Text = gh;
                                this.tblrname1.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                            }
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion
                            //}
                        }
                        #endregion

                        #region PT耦合固化
                        if (yh.机构 == "PT耦合固化")
                        {
                            //var xiacsl = tx.LD_xcsl;
                            //if (xiacsl == null)
                            //{
                            //    MessageBox.Show(" LD耦合焊接工序还没做完,无法进行下一步", "提示");
                            //    this.tabControl1.Enabled = false;
                            //    this.btnUpdate.Enabled = false;
                            //    this.btnUpdate.BackColor = Color.LightGray;
                            //    return;
                            //}
                            //else
                            //{
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            this.tblry.Text = tx.bl_lry;
                            this.tblrName.Text = tx.bl_lryname;
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            this.tblr1.Text = tx.LD_lry;
                            this.tblrname1.Text = tx.LD_lryname;
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion

                            #region PT耦合固化
                            this.tb5.Text = tx.PT_sbbh1;
                            this.tb6.Text = tx.PT_sbbh2;
                            this.tb7.Text = tx.PT_sbbh3;
                            this.tb8.Text = tx.PT_sbbh4;
                            if (tx.PT_xcsl == null)
                            {
                                this.tbxcsl2.Text = Convert.ToString(tx.LD_xcsl);
                            }
                            else
                            {
                                this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                            }
                            this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);

                            if (tx.PT_xctime == null)
                            {
                                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz5.Text = tx.PT_czy1;
                            this.tbcz6.Text = tx.PT_czy2;
                            this.tbcz7.Text = tx.PT_czy3;
                            this.tbcz8.Text = tx.PT_czy4;
                            this.tbname5.Text = tx.PT_czyname1;
                            this.tbname6.Text = tx.PT_czyname2;
                            this.tbname7.Text = tx.PT_czyname3;
                            this.tbname8.Text = tx.PT_czyname4;
                            var lry = this.tblr2.Text = tx.PT_lry;
                            if (lry == "" || lry == "0")
                            {
                                this.tblr2.Text = gh;
                                this.tblrname2.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr2.Text = tx.PT_lry;
                                this.tblrname2.Text = tx.PT_lryname;
                            }
                            this.tbyy21.Text = Convert.ToString(tx.ptng1);
                            this.tbyy22.Text = Convert.ToString(tx.ptng2);
                            this.tbyy23.Text = Convert.ToString(tx.ptng3);
                            this.tbyy24.Text = Convert.ToString(tx.ptng4);
                            this.tbyy25.Text = Convert.ToString(tx.ptng5);
                            this.tbyy26.Text = Convert.ToString(tx.ptng6);
                            this.tbyy27.Text = Convert.ToString(tx.ptng7);
                            this.tbyy28.Text = Convert.ToString(tx.ptng8);
                            this.tbyy29.Text = Convert.ToString(tx.ptng9);
                            this.tbyy30.Text = tx.ptngoth;
                            this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                            this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                            #endregion
                            //}
                        }
                        #endregion

                        #region 温循前
                        if (yh.机构 == "温循前")
                        {
                            //var xiacsl = tx.PT_xcsl;
                            //if (xiacsl == null)
                            //{
                            //    MessageBox.Show(" 温循后工序还没做完,无法进行下一步", "提示");
                            //    this.tabControl1.Enabled = false;
                            //    this.btnUpdate.Enabled = false;
                            //    this.btnUpdate.BackColor = Color.LightGray;
                            //    return;
                            //}
                            //else
                            //{
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            this.tblry.Text = tx.bl_lry;
                            this.tblrName.Text = tx.bl_lryname;
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            this.tblr1.Text = tx.LD_lry;
                            this.tblrname1.Text = tx.LD_lryname;
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion

                            #region PT耦合固化
                            this.tb5.Text = tx.PT_sbbh1;
                            this.tb6.Text = tx.PT_sbbh2;
                            this.tb7.Text = tx.PT_sbbh3;
                            this.tb8.Text = tx.PT_sbbh4;
                            this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                            this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                            if (tx.PT_xctime == null)
                            {
                                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz5.Text = tx.PT_czy1;
                            this.tbcz6.Text = tx.PT_czy2;
                            this.tbcz7.Text = tx.PT_czy3;
                            this.tbcz8.Text = tx.PT_czy4;
                            this.tbname5.Text = tx.PT_czyname1;
                            this.tbname6.Text = tx.PT_czyname2;
                            this.tbname7.Text = tx.PT_czyname3;
                            this.tbname8.Text = tx.PT_czyname4;
                            this.tblr2.Text = tx.PT_lry;
                            this.tblrname2.Text = tx.PT_lryname;
                            this.tbyy21.Text = Convert.ToString(tx.ptng1);
                            this.tbyy22.Text = Convert.ToString(tx.ptng2);
                            this.tbyy23.Text = Convert.ToString(tx.ptng3);
                            this.tbyy24.Text = Convert.ToString(tx.ptng4);
                            this.tbyy25.Text = Convert.ToString(tx.ptng5);
                            this.tbyy26.Text = Convert.ToString(tx.ptng6);
                            this.tbyy27.Text = Convert.ToString(tx.ptng7);
                            this.tbyy28.Text = Convert.ToString(tx.ptng8);
                            this.tbyy29.Text = Convert.ToString(tx.ptng9);
                            this.tbyy30.Text = tx.ptngoth;
                            this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                            this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                            #endregion

                            #region 温循前
                            this.tb9.Text = tx.WXQ_sbbh;
                            if (tx.WXQ_sjsl == null)
                            {
                                this.tbsjsl3.Text = Convert.ToString(tx.PT_xcsl);
                            }
                            else
                            {
                                this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                            }
                            this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                            if (tx.WXQ_xctime == null)
                            {
                                this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbcz9.Text = tx.WXQ_czy;
                            this.tbname9.Text = tx.WXQ_czyname;
                            var lry = this.tblr3.Text = tx.WXQ_lry;
                            if (lry == "" || lry == "0")
                            {
                                this.tblr3.Text = gh;
                                this.tblrname3.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr3.Text = tx.WXQ_lry;
                                this.tblrname3.Text = tx.WXQ_lryname;
                            }
                            this.rtbremark2.Text = tx.WXQ_remark;
                            #endregion
                            //}
                        }
                        #endregion

                        #region 温循后
                        if (yh.机构 == "温循后")
                        {
                            //var xiacsl = tx.WXQ_frsl;
                            //if (xiacsl == null)
                            //{
                            //    MessageBox.Show(" 温循前工序还没做完,无法进行下一步", "提示");
                            //    this.tabControl1.Enabled = false;
                            //    this.btnUpdate.Enabled = false;
                            //    this.btnUpdate.BackColor = Color.LightGray;
                            //    return;
                            //}
                            //else
                            //{
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            this.tblry.Text = tx.bl_lry;
                            this.tblrName.Text = tx.bl_lryname;
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            this.tblr1.Text = tx.LD_lry;
                            this.tblrname1.Text = tx.LD_lryname;
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion

                            #region PT耦合固化
                            this.tb5.Text = tx.PT_sbbh1;
                            this.tb6.Text = tx.PT_sbbh2;
                            this.tb7.Text = tx.PT_sbbh3;
                            this.tb8.Text = tx.PT_sbbh4;
                            this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                            this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                            if (tx.PT_xctime == null)
                            {
                                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz5.Text = tx.PT_czy1;
                            this.tbcz6.Text = tx.PT_czy2;
                            this.tbcz7.Text = tx.PT_czy3;
                            this.tbcz8.Text = tx.PT_czy4;
                            this.tbname5.Text = tx.PT_czyname1;
                            this.tbname6.Text = tx.PT_czyname2;
                            this.tbname7.Text = tx.PT_czyname3;
                            this.tbname8.Text = tx.PT_czyname4;
                            this.tblr2.Text = tx.PT_lry;
                            this.tblrname2.Text = tx.PT_lryname;
                            this.tbyy21.Text = Convert.ToString(tx.ptng1);
                            this.tbyy22.Text = Convert.ToString(tx.ptng2);
                            this.tbyy23.Text = Convert.ToString(tx.ptng3);
                            this.tbyy24.Text = Convert.ToString(tx.ptng4);
                            this.tbyy25.Text = Convert.ToString(tx.ptng5);
                            this.tbyy26.Text = Convert.ToString(tx.ptng6);
                            this.tbyy27.Text = Convert.ToString(tx.ptng7);
                            this.tbyy28.Text = Convert.ToString(tx.ptng8);
                            this.tbyy29.Text = Convert.ToString(tx.ptng9);
                            this.tbyy30.Text = tx.ptngoth;
                            this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                            this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                            #endregion

                            #region 温循前
                            this.tb9.Text = tx.WXQ_sbbh;
                            this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                            this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                            if (tx.WXQ_xctime == null)
                            {
                                this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbcz9.Text = tx.WXQ_czy;
                            this.tbname9.Text = tx.WXQ_czyname;
                            this.tblr3.Text = tx.WXQ_lry;
                            this.tblrname3.Text = tx.WXQ_lryname;
                            this.rtbremark2.Text = tx.WXQ_remark;
                            #endregion

                            #region 温循后
                            this.tb10.Text = tx.WXH_sbbh;
                            if (tx.WXH_qcsl == null)
                            {
                                this.tbqcsl1.Text = Convert.ToString(tx.WXQ_frsl);
                            }
                            else
                            {
                                this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                            }
                            this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                            if (tx.WXH_xctime == null)
                            {
                                this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbwxsc.Text = tx.WXH_wxsc;
                            this.tbcz10.Text = tx.WXH_czy;
                            this.tbname10.Text = tx.WXH_czyname;
                            var lry = this.tblr4.Text = tx.WX_Hlry;
                            if (lry == "" || lry == "0")
                            {
                                this.tblr4.Text = gh;
                                this.tblrname4.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr4.Text = tx.WX_Hlry;
                                this.tblrname4.Text = tx.WXH_lryname;
                            }
                            this.rtbremark3.Text = tx.WXH_remark;
                            #endregion
                            //}
                        }
                        #endregion

                        #region 测试
                        if (yh.机构 == "测试")
                        {
                            //var xiacsl = tx.WXH_xcsl;
                            //if (xiacsl == null)
                            //{
                            //    MessageBox.Show(" 温循后工序还没做完,无法进行下一步", "提示");
                            //    this.tabControl1.Enabled = false;
                            //    this.btnUpdate.Enabled = false;
                            //    this.btnUpdate.BackColor = Color.LightGray;
                            //    return;
                            //}
                            //else
                            //{
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            this.tblry.Text = tx.bl_lry;
                            this.tblrName.Text = tx.bl_lryname;
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            this.tblr1.Text = tx.LD_lry;
                            this.tblrname1.Text = tx.LD_lryname;
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion

                            #region PT耦合固化
                            this.tb5.Text = tx.PT_sbbh1;
                            this.tb6.Text = tx.PT_sbbh2;
                            this.tb7.Text = tx.PT_sbbh3;
                            this.tb8.Text = tx.PT_sbbh4;
                            this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                            this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                            if (tx.PT_xctime == null)
                            {
                                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz5.Text = tx.PT_czy1;
                            this.tbcz6.Text = tx.PT_czy2;
                            this.tbcz7.Text = tx.PT_czy3;
                            this.tbcz8.Text = tx.PT_czy4;
                            this.tbname5.Text = tx.PT_czyname1;
                            this.tbname6.Text = tx.PT_czyname2;
                            this.tbname7.Text = tx.PT_czyname3;
                            this.tbname8.Text = tx.PT_czyname4;
                            this.tblr2.Text = tx.PT_lry;
                            this.tblrname2.Text = tx.PT_lryname;
                            this.tbyy21.Text = Convert.ToString(tx.ptng1);
                            this.tbyy22.Text = Convert.ToString(tx.ptng2);
                            this.tbyy23.Text = Convert.ToString(tx.ptng3);
                            this.tbyy24.Text = Convert.ToString(tx.ptng4);
                            this.tbyy25.Text = Convert.ToString(tx.ptng5);
                            this.tbyy26.Text = Convert.ToString(tx.ptng6);
                            this.tbyy27.Text = Convert.ToString(tx.ptng7);
                            this.tbyy28.Text = Convert.ToString(tx.ptng8);
                            this.tbyy29.Text = Convert.ToString(tx.ptng9);
                            this.tbyy30.Text = tx.ptngoth;
                            this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                            this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                            #endregion

                            #region 温循前
                            this.tb9.Text = tx.WXQ_sbbh;
                            this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                            this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                            if (tx.WXQ_xctime == null)
                            {
                                this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbcz9.Text = tx.WXQ_czy;
                            this.tbname9.Text = tx.WXQ_czyname;
                            this.tblr3.Text = tx.WXQ_lry;
                            this.tblrname3.Text = tx.WXQ_lryname;
                            this.rtbremark2.Text = tx.WXQ_remark;
                            #endregion

                            #region 温循后
                            this.tb10.Text = tx.WXH_sbbh;
                            this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                            this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                            if (tx.WXH_xctime == null)
                            {
                                this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbwxsc.Text = tx.WXH_wxsc;
                            this.tbcz10.Text = tx.WXH_czy;
                            this.tbname10.Text = tx.WXH_czyname;
                            this.tblr4.Text = tx.WX_Hlry;
                            this.tblrname4.Text = tx.WXH_lryname;
                            this.rtbremark3.Text = tx.WXH_remark;
                            #endregion

                            #region 测试
                            this.tb11.Text = tx.CS_sbbh1;
                            this.tb12.Text = tx.CS_sbbh2;
                            this.tb13.Text = tx.CS_sbbh3;
                            this.tb14.Text = tx.CS_sbbh4;
                            if (tx.CS_sjsl == null)
                            {
                                this.tbsjsl4.Text = Convert.ToString(tx.WXH_xcsl);
                            }
                            else
                            {
                                this.tbsjsl4.Text = Convert.ToString(tx.CS_sjsl);
                            }
                            this.tbxcsl4.Text = Convert.ToString(tx.CS_xcsl);
                            if (tx.CS_xctime == null)
                            {
                                this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxtime3.Text = Convert.ToDateTime(tx.CS_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz11.Text = tx.CS_czy1;
                            this.tbcz12.Text = tx.CS_czy2;
                            this.tbcz13.Text = tx.CS_czy3;
                            this.tbcz14.Text = tx.CS_czy4;
                            this.tbname11.Text = tx.CS_czyname1;
                            this.tbname12.Text = tx.CS_czyname2;
                            this.tbname13.Text = tx.CS_czyname3;
                            this.tbname14.Text = tx.CS_czyname4;
                            var lry = this.tblr5.Text = tx.CS_lry;
                            if (lry == "" || lry == "0")
                            {
                                this.tblr5.Text = gh;
                                this.tblrname5.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr5.Text = tx.CS_lry;
                                this.tblrname5.Text = tx.CS_lryname;
                            }
                            this.tbyy31.Text = Convert.ToString(tx.csng1);
                            this.tbyy32.Text = Convert.ToString(tx.csng2);
                            this.tbyy33.Text = Convert.ToString(tx.csng3);
                            this.tbyy34.Text = Convert.ToString(tx.csng4);
                            this.tbyy35.Text = Convert.ToString(tx.csng5);
                            this.tbyy36.Text = Convert.ToString(tx.csng6);
                            this.tbyy37.Text = Convert.ToString(tx.csng7);
                            this.tbyy38.Text = Convert.ToString(tx.csng8);
                            this.rtbyy39.Text = tx.csngoth;
                            this.tbyy39sl.Text = Convert.ToString(tx.csngothnum);
                            this.tbbhgsl2.Text = Convert.ToString(tx.CS_bhgallsl);
                            #endregion
                            //}
                        }
                        #endregion

                        #region 清洗
                        if (yh.机构 == "清洗")
                        {
                            //var xiacsl = tx.CS_xcsl;
                            //if (xiacsl == null)
                            //{
                            //    MessageBox.Show("测试工序还没做完,无法进行下一步", "提示");
                            //    this.tabControl1.Enabled = false;
                            //    this.btnUpdate.Enabled = false;
                            //    this.btnUpdate.BackColor = Color.LightGray;
                            //    return;
                            //}
                            //else
                            //{
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            this.tblry.Text = tx.bl_lry;
                            this.tblrName.Text = tx.bl_lryname;
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            this.tblr1.Text = tx.LD_lry;
                            this.tblrname1.Text = tx.LD_lryname;
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion

                            #region PT耦合固化
                            this.tb5.Text = tx.PT_sbbh1;
                            this.tb6.Text = tx.PT_sbbh2;
                            this.tb7.Text = tx.PT_sbbh3;
                            this.tb8.Text = tx.PT_sbbh4;
                            this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                            this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                            if (tx.PT_xctime == null)
                            {
                                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz5.Text = tx.PT_czy1;
                            this.tbcz6.Text = tx.PT_czy2;
                            this.tbcz7.Text = tx.PT_czy3;
                            this.tbcz8.Text = tx.PT_czy4;
                            this.tbname5.Text = tx.PT_czyname1;
                            this.tbname6.Text = tx.PT_czyname2;
                            this.tbname7.Text = tx.PT_czyname3;
                            this.tbname8.Text = tx.PT_czyname4;
                            this.tblr2.Text = tx.PT_lry;
                            this.tblrname2.Text = tx.PT_lryname;
                            this.tbyy21.Text = Convert.ToString(tx.ptng1);
                            this.tbyy22.Text = Convert.ToString(tx.ptng2);
                            this.tbyy23.Text = Convert.ToString(tx.ptng3);
                            this.tbyy24.Text = Convert.ToString(tx.ptng4);
                            this.tbyy25.Text = Convert.ToString(tx.ptng5);
                            this.tbyy26.Text = Convert.ToString(tx.ptng6);
                            this.tbyy27.Text = Convert.ToString(tx.ptng7);
                            this.tbyy28.Text = Convert.ToString(tx.ptng8);
                            this.tbyy29.Text = Convert.ToString(tx.ptng9);
                            this.tbyy30.Text = tx.ptngoth;
                            this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                            this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                            #endregion

                            #region 温循前
                            this.tb9.Text = tx.WXQ_sbbh;
                            this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                            this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                            if (tx.WXQ_xctime == null)
                            {
                                this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbcz9.Text = tx.WXQ_czy;
                            this.tbname9.Text = tx.WXQ_czyname;
                            this.tblr3.Text = tx.WXQ_lry;
                            this.tblrname3.Text = tx.WXQ_lryname;
                            this.rtbremark2.Text = tx.WXQ_remark;
                            #endregion

                            #region 温循后
                            this.tb10.Text = tx.WXH_sbbh;
                            this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                            this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                            if (tx.WXH_xctime == null)
                            {
                                this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbwxsc.Text = tx.WXH_wxsc;
                            this.tbcz10.Text = tx.WXH_czy;
                            this.tbname10.Text = tx.WXH_czyname;
                            this.tblr4.Text = tx.WX_Hlry;
                            this.tblrname4.Text = tx.WXH_lryname;
                            this.rtbremark3.Text = tx.WXH_remark;
                            #endregion

                            #region 测试
                            this.tb11.Text = tx.CS_sbbh1;
                            this.tb12.Text = tx.CS_sbbh2;
                            this.tb13.Text = tx.CS_sbbh3;
                            this.tb14.Text = tx.CS_sbbh4;
                            this.tbsjsl4.Text = Convert.ToString(tx.CS_sjsl);
                            this.tbxcsl4.Text = Convert.ToString(tx.CS_xcsl);
                            if (tx.CS_xctime == null)
                            {
                                this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxtime3.Text = Convert.ToDateTime(tx.CS_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz11.Text = tx.CS_czy1;
                            this.tbcz12.Text = tx.CS_czy2;
                            this.tbcz13.Text = tx.CS_czy3;
                            this.tbcz14.Text = tx.CS_czy4;
                            this.tbname11.Text = tx.CS_czyname1;
                            this.tbname12.Text = tx.CS_czyname2;
                            this.tbname13.Text = tx.CS_czyname3;
                            this.tbname14.Text = tx.CS_czyname4;
                            this.tbyy31.Text = Convert.ToString(tx.csng1);
                            this.tbyy32.Text = Convert.ToString(tx.csng2);
                            this.tbyy33.Text = Convert.ToString(tx.csng3);
                            this.tbyy34.Text = Convert.ToString(tx.csng4);
                            this.tbyy35.Text = Convert.ToString(tx.csng5);
                            this.tbyy36.Text = Convert.ToString(tx.csng6);
                            this.tbyy37.Text = Convert.ToString(tx.csng7);
                            this.tbyy38.Text = Convert.ToString(tx.csng8);
                            this.rtbyy39.Text = tx.csngoth;
                            this.tbyy39sl.Text = Convert.ToString(tx.csngothnum);
                            this.tbbhgsl2.Text = Convert.ToString(tx.CS_bhgallsl);
                            #endregion

                            #region 清洗
                            this.tb15.Text = tx.QX_sbbh1;
                            this.tb16.Text = tx.QX_sbbh2;
                            this.tb17.Text = tx.QX_sbbh3;
                            this.tb18.Text = tx.QX_sbbh4;
                            if (tx.QX_sjsl == null)
                            {
                                this.tbsjsl5.Text = Convert.ToString(tx.CS_xcsl);
                            }
                            else
                            {
                                this.tbsjsl5.Text = Convert.ToString(tx.QX_sjsl);
                            }
                            this.tbxcsl5.Text = Convert.ToString(tx.QX_xcsl);
                            if (tx.QX_xctime == null)
                            {
                                this.dtpxctime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxctime3.Text = Convert.ToDateTime(tx.QX_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz15.Text = tx.QX_czy1;
                            this.tbcz16.Text = tx.QX_czy2;
                            this.tbcz17.Text = tx.QX_czy3;
                            this.tbcz18.Text = tx.QX_czy4;
                            this.tbname15.Text = tx.QX_czyname1;
                            this.tbname16.Text = tx.QX_czyname2;
                            this.tbname17.Text = tx.QX_czyname3;
                            this.tbname18.Text = tx.QX_czyname4;
                            var lry = this.tblr6.Text = tx.QX_lry;
                            if (lry == "" || lry == "0")
                            {
                                this.tblr6.Text = gh;
                                this.tblrname6.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr6.Text = tx.QX_lry;
                                this.tblrname6.Text = tx.QX_lryname;
                            }
                            this.tbyy40.Text = Convert.ToString(tx.qxng1);
                            this.rtbyy41.Text = tx.qxngoth;
                            this.tbyy41sl.Text = Convert.ToString(tx.qxngothnum);
                            this.tbbhgsl3.Text = Convert.ToString(tx.QX_bhgallsl);
                            #endregion
                            //}
                        }
                        #endregion

                        #region 包装
                        if (yh.机构 == "包装")
                        {
                            //var xiacsl = tx.QX_xcsl;
                            //if (xiacsl == null)
                            //{
                            //    MessageBox.Show("清洗工序还没做完,无法进行下一步", "提示");
                            //    this.tabControl1.Enabled = false;
                            //    this.btnUpdate.Enabled = false;
                            //    this.btnUpdate.BackColor = Color.LightGray;
                            //    return;
                            //}
                            //else
                            //{
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            this.tblry.Text = tx.bl_lry;
                            this.tblrName.Text = tx.bl_lryname;
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            this.tblr1.Text = tx.LD_lry;
                            this.tblrname1.Text = tx.LD_lryname;
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion

                            #region PT耦合固化
                            this.tb5.Text = tx.PT_sbbh1;
                            this.tb6.Text = tx.PT_sbbh2;
                            this.tb7.Text = tx.PT_sbbh3;
                            this.tb8.Text = tx.PT_sbbh4;
                            this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                            this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                            if (tx.PT_xctime == null)
                            {
                                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz5.Text = tx.PT_czy1;
                            this.tbcz6.Text = tx.PT_czy2;
                            this.tbcz7.Text = tx.PT_czy3;
                            this.tbcz8.Text = tx.PT_czy4;
                            this.tbname5.Text = tx.PT_czyname1;
                            this.tbname6.Text = tx.PT_czyname2;
                            this.tbname7.Text = tx.PT_czyname3;
                            this.tbname8.Text = tx.PT_czyname4;
                            this.tblr2.Text = tx.PT_lry;
                            this.tblrname2.Text = tx.PT_lryname;
                            this.tbyy21.Text = Convert.ToString(tx.ptng1);
                            this.tbyy22.Text = Convert.ToString(tx.ptng2);
                            this.tbyy23.Text = Convert.ToString(tx.ptng3);
                            this.tbyy24.Text = Convert.ToString(tx.ptng4);
                            this.tbyy25.Text = Convert.ToString(tx.ptng5);
                            this.tbyy26.Text = Convert.ToString(tx.ptng6);
                            this.tbyy27.Text = Convert.ToString(tx.ptng7);
                            this.tbyy28.Text = Convert.ToString(tx.ptng8);
                            this.tbyy29.Text = Convert.ToString(tx.ptng9);
                            this.tbyy30.Text = tx.ptngoth;
                            this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                            this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                            #endregion

                            #region 温循前
                            this.tb9.Text = tx.WXQ_sbbh;
                            this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                            this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                            if (tx.WXQ_xctime == null)
                            {
                                this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbcz9.Text = tx.WXQ_czy;
                            this.tbname9.Text = tx.WXQ_czyname;
                            this.tblr3.Text = tx.WXQ_lry;
                            this.tblrname3.Text = tx.WXQ_lryname;
                            this.rtbremark2.Text = tx.WXQ_remark;
                            #endregion

                            #region 温循后
                            this.tb10.Text = tx.WXH_sbbh;
                            this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                            this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                            if (tx.WXH_xctime == null)
                            {
                                this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbwxsc.Text = tx.WXH_wxsc;
                            this.tbcz10.Text = tx.WXH_czy;
                            this.tbname10.Text = tx.WXH_czyname;
                            this.tblr4.Text = tx.WX_Hlry;
                            this.tblrname4.Text = tx.WXH_lryname;
                            this.rtbremark3.Text = tx.WXH_remark;
                            #endregion

                            #region 测试
                            this.tb11.Text = tx.CS_sbbh1;
                            this.tb12.Text = tx.CS_sbbh2;
                            this.tb13.Text = tx.CS_sbbh3;
                            this.tb14.Text = tx.CS_sbbh4;
                            this.tbsjsl4.Text = Convert.ToString(tx.CS_sjsl);
                            this.tbxcsl4.Text = Convert.ToString(tx.CS_xcsl);
                            if (tx.CS_xctime == null)
                            {
                                this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxtime3.Text = Convert.ToDateTime(tx.CS_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz11.Text = tx.CS_czy1;
                            this.tbcz12.Text = tx.CS_czy2;
                            this.tbcz13.Text = tx.CS_czy3;
                            this.tbcz14.Text = tx.CS_czy4;
                            this.tbname11.Text = tx.CS_czyname1;
                            this.tbname12.Text = tx.CS_czyname2;
                            this.tbname13.Text = tx.CS_czyname3;
                            this.tbname14.Text = tx.CS_czyname4;
                            this.tbyy31.Text = Convert.ToString(tx.csng1);
                            this.tbyy32.Text = Convert.ToString(tx.csng2);
                            this.tbyy33.Text = Convert.ToString(tx.csng3);
                            this.tbyy34.Text = Convert.ToString(tx.csng4);
                            this.tbyy35.Text = Convert.ToString(tx.csng5);
                            this.tbyy36.Text = Convert.ToString(tx.csng6);
                            this.tbyy37.Text = Convert.ToString(tx.csng7);
                            this.tbyy38.Text = Convert.ToString(tx.csng8);
                            this.rtbyy39.Text = tx.csngoth;
                            this.tbyy39sl.Text = Convert.ToString(tx.csngothnum);
                            this.tbbhgsl2.Text = Convert.ToString(tx.CS_bhgallsl);
                            #endregion

                            #region 清洗
                            this.tb15.Text = tx.QX_sbbh1;
                            this.tb16.Text = tx.QX_sbbh2;
                            this.tb17.Text = tx.QX_sbbh3;
                            this.tb18.Text = tx.QX_sbbh4;
                            this.tbsjsl5.Text = Convert.ToString(tx.QX_sjsl);
                            this.tbxcsl5.Text = Convert.ToString(tx.QX_xcsl);
                            if (tx.QX_xctime == null)
                            {
                                this.dtpxctime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxctime3.Text = Convert.ToDateTime(tx.QX_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz15.Text = tx.QX_czy1;
                            this.tbcz16.Text = tx.QX_czy2;
                            this.tbcz17.Text = tx.QX_czy3;
                            this.tbcz18.Text = tx.QX_czy4;
                            this.tbname15.Text = tx.QX_czyname1;
                            this.tbname16.Text = tx.QX_czyname2;
                            this.tbname17.Text = tx.QX_czyname3;
                            this.tbname18.Text = tx.QX_czyname4;
                            this.tbyy40.Text = Convert.ToString(tx.qxng1);
                            this.rtbyy41.Text = tx.qxngoth;
                            this.tbyy41sl.Text = Convert.ToString(tx.qxngothnum);
                            this.tbbhgsl3.Text = Convert.ToString(tx.QX_bhgallsl);
                            #endregion

                            #region 包装
                            this.tb19.Text = tx.BZ_sbbh1;
                            this.tb20.Text = tx.BZ_sbbh2;
                            this.tb21.Text = tx.BZ_sbbh3;
                            this.tb22.Text = tx.BZ_sbbh4;
                            if (tx.BZ_sjsl == null)
                            {
                                this.tbsjsl6.Text = Convert.ToString(tx.QX_xcsl);
                            }
                            else
                            {
                                this.tbsjsl6.Text = Convert.ToString(tx.BZ_sjsl);
                            }
                            this.tbxcsl6.Text = Convert.ToString(tx.BZ_xcsl);
                            if (tx.BZ_xctime == null)
                            {
                                this.dtpxctime4.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxctime4.Text = Convert.ToDateTime(tx.BZ_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz19.Text = tx.BZ_czy1;
                            this.tbcz20.Text = tx.BZ_czy2;
                            this.tbcz21.Text = tx.BZ_czy3;
                            this.tbcz22.Text = tx.BZ_czy4;
                            this.tbname19.Text = tx.BZ_czyname1;
                            this.tbname20.Text = tx.BZ_czyname2;
                            this.tbname21.Text = tx.BZ_czyname3;
                            this.tbname22.Text = tx.BZ_czyname4;
                            var lry = this.tblr7.Text = tx.BZ_lry;
                            if (lry == "" || lry == "0")
                            {
                                this.tblr7.Text = gh;
                                this.tblrname7.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr7.Text = tx.BZ_lry;
                                this.tblrname7.Text = tx.BZ_lryname;
                            }
                            this.tbyy42.Text = Convert.ToString(tx.bzng1);
                            this.rtbyy43.Text = tx.bzngoth;
                            this.tbyy43sl.Text = Convert.ToString(tx.bzngothnum);
                            this.tbbhgsl4.Text = Convert.ToString(tx.BZ_bhgallsl);
                            #endregion
                            //}
                        }
                        #endregion
                        this.tabControl1.Enabled = true;

                    }
                }
                else
                {
                    MessageBox.Show("备料工序还没开始", "提示");
                    //if (yh.机构 == "全部")
                    //{
                    //    this.tabControl1.Enabled = true;
                    //    this.btnCancel.Enabled = false;
                    //    this.btnCancel.BackColor = Color.LightGray;
                    //    this.btnOk.Enabled = true;
                    //    this.btnOk.BackColor = Color.Teal;
                    //}
                    //else if (yh.机构 == "备料")
                    //{
                    //    this.tabControl1.Enabled = true;
                    //    this.btnOk.Enabled = true;
                    //    this.btnOk.BackColor = Color.Teal;
                    //    this.btnCancel.Enabled = true;
                    //    this.btnCancel.BackColor = Color.Teal;
                    //}
                    //else
                    //{
                    //    this.tabControl1.Enabled = false;
                    //    this.btnOk.Enabled = false;
                    //    this.btnOk.BackColor = Color.LightGray;
                    //    this.btnCancel.Enabled = true;
                    //    this.btnCancel.BackColor = Color.Teal;
                    //}
                    this.btnOk.Enabled = true;
                    this.btnOk.BackColor = Color.Teal;
                    this.btnUpdate.Enabled = false;
                    this.btnUpdate.BackColor = Color.LightGray;
                    return;
                }
            }
            else
            {

                bool result = false;
                result = txbll.Exists(dxuhao);
                if (result == true)
                {
                    this.btnUpdate.Enabled = true;
                    this.btnUpdate.BackColor = Color.Teal;
                    this.btnOk.Enabled = false;
                    this.btnOk.BackColor = Color.LightGray;
                    this.btnSend.Enabled = false;
                    this.btnSend.BackColor = Color.LightGray;
                    if (this.tbDXH1.Text != "")
                    {

                        var beiHuo = tbSGDXH.Text;
                        tsuhan_sg_tx tx = txbll.QueryByXuhao(dxuhao);

                        #region 过程数据记录
                        //流水号
                        this.tbLSH1.Text = tx.lsh1;
                        this.tbLSH2.Text = tx.lsh2;
                        this.tbLSH3.Text = tx.lsh3;
                        //CASE
                        this.tbCASE1.Text = tx.case1;
                        this.tbCASE2.Text = tx.case2;
                        this.tbCASE3.Text = tx.case3;
                        //LD+
                        this.tbLDP1.Text = tx.ld1;
                        this.tbLDP2.Text = tx.ld2;
                        this.tbLDP3.Text = tx.ld3;
                        //PD+
                        this.tbPDP1.Text = tx.pd1;
                        this.tbPDP2.Text = tx.pd2;
                        this.tbPDP3.Text = tx.pd3;
                        //LD-
                        this.tbLDN1.Text = tx.ldj1;
                        this.tbLDN2.Text = tx.ldj2;
                        this.tbLDN3.Text = tx.ldj3;
                        //极差
                        this.tbJC1.Text = Convert.ToString(tx.jc1);
                        this.tbJC2.Text = Convert.ToString(tx.jc2);
                        this.tbJC3.Text = Convert.ToString(tx.jc3);
                        //凹陷量
                        this.tbAXL1.Text = tx.oxl1;
                        this.tbAXL2.Text = tx.oxl2;
                        this.tbAXL3.Text = tx.oxl3;
                        this.tbjj.Text = tx.ldxp_xinpianjj;
                        this.tbjyry.Text = tx.ldxp_jianyanry;
                        this.tbjysb.Text = tx.ldxp_jianyansb;
                        this.rtbremark.Text = tx.备注;
                        this.textBox34.Text = tx.LD_xh;
                        this.textBox35.Text = tx.LD_name;
                        this.textBox36.Text = tx.LD_sjdh;
                        this.textBox39.Text = tx.PT_xh;
                        this.textBox38.Text = tx.PT_name;
                        this.textBox37.Text = tx.PT_sjdh;
                        this.textBox42.Text = tx.KT_xh;
                        this.textBox41.Text = tx.KT_name;
                        this.textBox40.Text = tx.KT_sjdh;
                        this.textBox45.Text = tx.NBP_xh0;
                        this.textBox44.Text = tx.NBP_name0;
                        this.textBox43.Text = tx.NBP_sjdh0;
                        this.textBox51.Text = tx.NBP_xh45;
                        this.textBox50.Text = tx.NBP_name45;
                        this.textBox49.Text = tx.NBP_sjdh45;
                        this.textBox48.Text = tx.JK_xh;
                        this.textBox47.Text = tx.JK_name;
                        this.textBox46.Text = tx.JK_sjdh;

                        #endregion

                        #region 全部
                        if (yh.机构 == "全部")
                        {
                            this.btnUpdate.Enabled = true;
                            this.btnUpdate.BackColor = Color.Teal;
                            this.btnCancel.Enabled = false;
                            this.btnCancel.BackColor = Color.LightGray;
                            this.btnOk.Enabled = false;
                            this.btnOk.BackColor = Color.LightGray;
                            this.dtpfrtime1.Enabled = true;
                            this.dtpqcTime1.Enabled = true;
                            #region 全部
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            var lry1 = this.tblry.Text = tx.bl_lry;
                            if (lry1 == null || lry1 == "0")
                            {
                                this.tblry.Text = gh;
                                this.tblrName.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                            }
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            this.tabControl1.Enabled = true;
                            #endregion

                            #region LD耦合焊接
                            this.tb1.Text = tx.LD_sbbh1;
                            this.tb2.Text = tx.LD_sbbh2;
                            this.tb3.Text = tx.LD_sbbh3;
                            this.tb4.Text = tx.LD_sbbh4;
                            this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                            this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                            if (tx.LD_xctime == null)
                            {
                                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz1.Text = tx.LD_czy1;
                            this.tbcz2.Text = tx.LD_czy2;
                            this.tbcz3.Text = tx.LD_czy3;
                            this.tbcz4.Text = tx.LD_czy4;
                            this.tbname1.Text = tx.LD_czyname1;
                            this.tbname2.Text = tx.LD_czyname2;
                            this.tbname3.Text = tx.LD_czyname3;
                            this.tbname4.Text = tx.LD_czyname4;
                            var lry2 = this.tblr1.Text = tx.LD_lry;
                            if (lry2 == "" || lry2 == "0")
                            {
                                this.tblr1.Text = gh;
                                this.tblrname1.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                            }
                            this.tbyy11.Text = Convert.ToString(tx.ldng1);
                            this.tbyy12.Text = Convert.ToString(tx.ldng2);
                            this.tbyy13.Text = Convert.ToString(tx.ldng3);
                            this.tbyy14.Text = Convert.ToString(tx.ldng4);
                            this.tbyy15.Text = Convert.ToString(tx.ldng5);
                            this.tbyy16.Text = Convert.ToString(tx.ldng6);
                            this.tbyy17.Text = Convert.ToString(tx.ldng7);
                            this.tbyy18.Text = Convert.ToString(tx.ldng8);
                            this.tbyy19.Text = Convert.ToString(tx.ldng9);
                            this.tbyy20.Text = tx.ldngoth;
                            this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                            this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                            this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                            #endregion

                            #region PT耦合固化
                            this.tb5.Text = tx.PT_sbbh1;
                            this.tb6.Text = tx.PT_sbbh2;
                            this.tb7.Text = tx.PT_sbbh3;
                            this.tb8.Text = tx.PT_sbbh4;
                            this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                            this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                            if (tx.PT_xctime == null)
                            {
                                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz5.Text = tx.PT_czy1;
                            this.tbcz6.Text = tx.PT_czy2;
                            this.tbcz7.Text = tx.PT_czy3;
                            this.tbcz8.Text = tx.PT_czy4;
                            this.tbname5.Text = tx.PT_czyname1;
                            this.tbname6.Text = tx.PT_czyname2;
                            this.tbname7.Text = tx.PT_czyname3;
                            this.tbname8.Text = tx.PT_czyname4;
                            var lry3 = this.tblr2.Text = tx.PT_lry;
                            if (lry3 == "" || lry3 == "0")
                            {
                                this.tblr2.Text = gh;
                                this.tblrname2.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr2.Text = tx.PT_lry;
                                this.tblrname2.Text = tx.PT_lryname;
                            }
                            this.tbyy21.Text = Convert.ToString(tx.ptng1);
                            this.tbyy22.Text = Convert.ToString(tx.ptng2);
                            this.tbyy23.Text = Convert.ToString(tx.ptng3);
                            this.tbyy24.Text = Convert.ToString(tx.ptng4);
                            this.tbyy25.Text = Convert.ToString(tx.ptng5);
                            this.tbyy26.Text = Convert.ToString(tx.ptng6);
                            this.tbyy27.Text = Convert.ToString(tx.ptng7);
                            this.tbyy28.Text = Convert.ToString(tx.ptng8);
                            this.tbyy29.Text = Convert.ToString(tx.ptng9);
                            this.tbyy30.Text = tx.ptngoth;
                            this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                            this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                            #endregion

                            #region 温循前
                            this.tb9.Text = tx.WXQ_sbbh;
                            this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                            this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                            if (tx.WXQ_xctime == null)
                            {
                                this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbcz9.Text = tx.WXQ_czy;
                            this.tbname9.Text = tx.WXQ_czyname;
                            var lry4 = this.tblr3.Text = tx.WXQ_lry;
                            if (lry4 == "" || lry4 == "0")
                            {
                                this.tblr3.Text = gh;
                                this.tblrname3.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr3.Text = tx.WXQ_lry;
                                this.tblrname3.Text = tx.WXQ_lryname;
                            }
                            this.rtbremark2.Text = tx.WXQ_remark;
                            #endregion

                            #region 温循后
                            this.tb10.Text = tx.WXH_sbbh;
                            this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                            this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                            if (tx.WXH_xctime == null)
                            {
                                this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            else
                            {
                                this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                            }
                            this.tbwxsc.Text = tx.WXH_wxsc;
                            this.tbcz10.Text = tx.WXH_czy;
                            this.tbname10.Text = tx.WXH_czyname;
                            var lry5 = this.tblr4.Text = tx.WX_Hlry;
                            if (lry5 == "" || lry5 == "0")
                            {
                                this.tblr4.Text = gh;
                                this.tblrname4.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr4.Text = tx.WX_Hlry;
                                this.tblrname4.Text = tx.WXH_lryname;
                            }
                            this.rtbremark3.Text = tx.WXH_remark;
                            #endregion

                            #region 测试
                            this.tb11.Text = tx.CS_sbbh1;
                            this.tb12.Text = tx.CS_sbbh2;
                            this.tb13.Text = tx.CS_sbbh3;
                            this.tb14.Text = tx.CS_sbbh4;
                            this.tbsjsl4.Text = Convert.ToString(tx.CS_sjsl);
                            this.tbxcsl4.Text = Convert.ToString(tx.CS_xcsl);
                            if (tx.CS_xctime == null)
                            {
                                this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxtime3.Text = Convert.ToDateTime(tx.CS_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz11.Text = tx.CS_czy1;
                            this.tbcz12.Text = tx.CS_czy2;
                            this.tbcz13.Text = tx.CS_czy3;
                            this.tbcz14.Text = tx.CS_czy4;
                            this.tbname11.Text = tx.CS_czyname1;
                            this.tbname12.Text = tx.CS_czyname2;
                            this.tbname13.Text = tx.CS_czyname3;
                            this.tbname14.Text = tx.CS_czyname4;
                            var lry6 = this.tblr5.Text = tx.CS_lry;
                            if (lry6 == "" || lry6 == "0")
                            {
                                this.tblr5.Text = gh;
                                this.tblrname5.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr5.Text = tx.CS_lry;
                                this.tblrname5.Text = tx.CS_lryname;
                            }
                            this.tbyy31.Text = Convert.ToString(tx.csng1);
                            this.tbyy32.Text = Convert.ToString(tx.csng2);
                            this.tbyy33.Text = Convert.ToString(tx.csng3);
                            this.tbyy34.Text = Convert.ToString(tx.csng4);
                            this.tbyy35.Text = Convert.ToString(tx.csng5);
                            this.tbyy36.Text = Convert.ToString(tx.csng6);
                            this.tbyy37.Text = Convert.ToString(tx.csng7);
                            this.tbyy38.Text = Convert.ToString(tx.csng8);
                            this.rtbyy39.Text = tx.csngoth;
                            this.tbyy39sl.Text = Convert.ToString(tx.csngothnum);
                            this.tbbhgsl2.Text = Convert.ToString(tx.CS_bhgallsl);
                            #endregion

                            #region 清洗
                            this.tb15.Text = tx.QX_sbbh1;
                            this.tb16.Text = tx.QX_sbbh2;
                            this.tb17.Text = tx.QX_sbbh3;
                            this.tb18.Text = tx.QX_sbbh4;
                            this.tbsjsl5.Text = Convert.ToString(tx.QX_sjsl);
                            this.tbxcsl5.Text = Convert.ToString(tx.QX_xcsl);
                            if (tx.QX_xctime == null)
                            {
                                this.dtpxctime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxctime3.Text = Convert.ToDateTime(tx.QX_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz15.Text = tx.QX_czy1;
                            this.tbcz16.Text = tx.QX_czy2;
                            this.tbcz17.Text = tx.QX_czy3;
                            this.tbcz18.Text = tx.QX_czy4;
                            this.tbname15.Text = tx.QX_czyname1;
                            this.tbname16.Text = tx.QX_czyname2;
                            this.tbname17.Text = tx.QX_czyname3;
                            this.tbname18.Text = tx.QX_czyname4;
                            var lry7 = this.tblr6.Text = tx.QX_lry;
                            if (lry7 == "" || lry7 == "0")
                            {
                                this.tblr6.Text = gh;
                                this.tblrname6.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr6.Text = tx.QX_lry;
                                this.tblrname6.Text = tx.QX_lryname;
                            }
                            this.tbyy40.Text = Convert.ToString(tx.qxng1);
                            this.rtbyy41.Text = tx.qxngoth;
                            this.tbyy41sl.Text = Convert.ToString(tx.qxngothnum);
                            this.tbbhgsl3.Text = Convert.ToString(tx.QX_bhgallsl);
                            #endregion

                            #region 包装
                            this.tb19.Text = tx.BZ_sbbh1;
                            this.tb20.Text = tx.BZ_sbbh2;
                            this.tb21.Text = tx.BZ_sbbh3;
                            this.tb22.Text = tx.BZ_sbbh4;
                            this.tbsjsl6.Text = Convert.ToString(tx.BZ_sjsl);
                            this.tbxcsl6.Text = Convert.ToString(tx.BZ_xcsl);
                            if (tx.BZ_xctime == null)
                            {
                                this.dtpxctime4.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxctime4.Text = Convert.ToDateTime(tx.BZ_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbcz19.Text = tx.BZ_czy1;
                            this.tbcz20.Text = tx.BZ_czy2;
                            this.tbcz21.Text = tx.BZ_czy3;
                            this.tbcz22.Text = tx.BZ_czy4;
                            this.tbname19.Text = tx.BZ_czyname1;
                            this.tbname20.Text = tx.BZ_czyname2;
                            this.tbname21.Text = tx.BZ_czyname3;
                            this.tbname22.Text = tx.BZ_czyname4;
                            var lry8 = this.tblr7.Text = tx.BZ_lry;
                            if (lry8 == "" || lry8 == "0")
                            {
                                this.tblr7.Text = gh;
                                this.tblrname7.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblr7.Text = tx.BZ_lry;
                                this.tblrname7.Text = tx.BZ_lryname;
                            }
                            this.tbyy42.Text = Convert.ToString(tx.bzng1);
                            this.rtbyy43.Text = tx.bzngoth;
                            this.tbyy43sl.Text = Convert.ToString(tx.bzngothnum);
                            this.tbbhgsl4.Text = Convert.ToString(tx.BZ_bhgallsl);
                            #endregion
                            #endregion
                        }

                        #endregion

                        #region 备料
                        if (yh.机构 == "备料")
                        {
                            #region 备料
                            this.tbsbbh1.Text = tx.bl_sbbh1;
                            this.tbsbbh2.Text = tx.bl_sbbh2;
                            this.tbsbbh3.Text = tx.bl_sbbh3;
                            this.tbsbbh4.Text = tx.bl_sbbh4;
                            this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                            if (tx.bl_xctime == null)
                            {
                                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                            }
                            this.tbczy1.Text = tx.bl_czy1;
                            this.tbczy2.Text = tx.bl_czy2;
                            this.tbczy3.Text = tx.bl_czy3;
                            this.tbczy4.Text = tx.bl_czy4;
                            this.tbczName1.Text = tx.bl_czyname1;
                            this.tbczName2.Text = tx.bl_czyname2;
                            this.tbczName3.Text = tx.bl_czyname3;
                            this.tbczName4.Text = tx.bl_czyname4;
                            var lry = this.tblry.Text = tx.bl_lry;
                            if (lry == null || lry == "0")
                            {
                                this.tblry.Text = gh;
                                this.tblrName.Text = yh.姓名;
                            }
                            else
                            {
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                            }
                            this.tbyy1.Text = Convert.ToString(tx.blng1);
                            this.tbyy2.Text = Convert.ToString(tx.blng2);
                            this.tbyy3.Text = Convert.ToString(tx.blng3);
                            this.tbyy4.Text = Convert.ToString(tx.blng4);
                            this.tbyy5.Text = Convert.ToString(tx.blng5);
                            this.tbyy6.Text = Convert.ToString(tx.blng6);
                            this.tbyy7.Text = Convert.ToString(tx.blng7);
                            this.tbyy8.Text = Convert.ToString(tx.blng8);
                            this.tbyy9.Text = Convert.ToString(tx.blng9);
                            this.tbyy10.Text = tx.blngoth;
                            this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                            this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                            this.tabControl1.Enabled = true;
                            #endregion
                        }
                        #endregion

                        #region LD耦合焊接
                        if (yh.机构 == "LD耦合焊接")
                        {
                            var xiacsl = tx.bl_xcsl;
                            if (xiacsl == null)
                            {
                                MessageBox.Show("备料工序还没做完,无法进行下一步", "提示");
                                this.tabControl1.Enabled = false;
                                this.btnUpdate.Enabled = false;
                                this.btnUpdate.BackColor = Color.LightGray;
                                return;
                            }
                            else
                            {
                                #region 备料
                                this.tbsbbh1.Text = tx.bl_sbbh1;
                                this.tbsbbh2.Text = tx.bl_sbbh2;
                                this.tbsbbh3.Text = tx.bl_sbbh3;
                                this.tbsbbh4.Text = tx.bl_sbbh4;
                                this.tbxcsl.Text = Convert.ToString(tx.LD_xcsl);
                                if (tx.bl_xctime == null)
                                {
                                    this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbczy1.Text = tx.bl_czy1;
                                this.tbczy2.Text = tx.bl_czy2;
                                this.tbczy3.Text = tx.bl_czy3;
                                this.tbczy4.Text = tx.bl_czy4;
                                this.tbczName1.Text = tx.bl_czyname1;
                                this.tbczName2.Text = tx.bl_czyname2;
                                this.tbczName3.Text = tx.bl_czyname3;
                                this.tbczName4.Text = tx.bl_czyname4;
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                                this.tbyy1.Text = Convert.ToString(tx.blng1);
                                this.tbyy2.Text = Convert.ToString(tx.blng2);
                                this.tbyy3.Text = Convert.ToString(tx.blng3);
                                this.tbyy4.Text = Convert.ToString(tx.blng4);
                                this.tbyy5.Text = Convert.ToString(tx.blng5);
                                this.tbyy6.Text = Convert.ToString(tx.blng6);
                                this.tbyy7.Text = Convert.ToString(tx.blng7);
                                this.tbyy8.Text = Convert.ToString(tx.blng8);
                                this.tbyy9.Text = Convert.ToString(tx.blng9);
                                this.tbyy10.Text = tx.blngoth;
                                this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                                this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                                #endregion

                                #region LD耦合焊接
                                this.tb1.Text = tx.LD_sbbh1;
                                this.tb2.Text = tx.LD_sbbh2;
                                this.tb3.Text = tx.LD_sbbh3;
                                this.tb4.Text = tx.LD_sbbh4;
                                if (tx.LD_sjsl == null)
                                {
                                    this.tbsjsl1.Text = Convert.ToString(tx.bl_xcsl);
                                }
                                else
                                {
                                    this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                                }
                                this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                                if (tx.LD_xctime == null)
                                {
                                    this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz1.Text = tx.LD_czy1;
                                this.tbcz2.Text = tx.LD_czy2;
                                this.tbcz3.Text = tx.LD_czy3;
                                this.tbcz4.Text = tx.LD_czy4;
                                this.tbname1.Text = tx.LD_czyname1;
                                this.tbname2.Text = tx.LD_czyname2;
                                this.tbname3.Text = tx.LD_czyname3;
                                this.tbname4.Text = tx.LD_czyname4;
                                var lry = this.tblr1.Text = tx.LD_lry;
                                if (lry == "" || lry == "0")
                                {
                                    this.tblr1.Text = gh;
                                    this.tblrname1.Text = yh.姓名;
                                }
                                else
                                {
                                    this.tblr1.Text = tx.LD_lry;
                                    this.tblrname1.Text = tx.LD_lryname;
                                }
                                this.tbyy11.Text = Convert.ToString(tx.ldng1);
                                this.tbyy12.Text = Convert.ToString(tx.ldng2);
                                this.tbyy13.Text = Convert.ToString(tx.ldng3);
                                this.tbyy14.Text = Convert.ToString(tx.ldng4);
                                this.tbyy15.Text = Convert.ToString(tx.ldng5);
                                this.tbyy16.Text = Convert.ToString(tx.ldng6);
                                this.tbyy17.Text = Convert.ToString(tx.ldng7);
                                this.tbyy18.Text = Convert.ToString(tx.ldng8);
                                this.tbyy19.Text = Convert.ToString(tx.ldng9);
                                this.tbyy20.Text = tx.ldngoth;
                                this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                                this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                                this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                                #endregion
                            }
                        }
                        #endregion

                        #region PT耦合固化
                        if (yh.机构 == "PT耦合固化")
                        {
                            var xiacsl = tx.LD_xcsl;
                            if (xiacsl == null)
                            {
                                MessageBox.Show(" LD耦合焊接工序还没做完,无法进行下一步", "提示");
                                this.tabControl1.Enabled = false;
                                this.btnUpdate.Enabled = false;
                                this.btnUpdate.BackColor = Color.LightGray;
                                return;
                            }
                            else
                            {
                                #region 备料
                                this.tbsbbh1.Text = tx.bl_sbbh1;
                                this.tbsbbh2.Text = tx.bl_sbbh2;
                                this.tbsbbh3.Text = tx.bl_sbbh3;
                                this.tbsbbh4.Text = tx.bl_sbbh4;
                                this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                                if (tx.bl_xctime == null)
                                {
                                    this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbczy1.Text = tx.bl_czy1;
                                this.tbczy2.Text = tx.bl_czy2;
                                this.tbczy3.Text = tx.bl_czy3;
                                this.tbczy4.Text = tx.bl_czy4;
                                this.tbczName1.Text = tx.bl_czyname1;
                                this.tbczName2.Text = tx.bl_czyname2;
                                this.tbczName3.Text = tx.bl_czyname3;
                                this.tbczName4.Text = tx.bl_czyname4;
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                                this.tbyy1.Text = Convert.ToString(tx.blng1);
                                this.tbyy2.Text = Convert.ToString(tx.blng2);
                                this.tbyy3.Text = Convert.ToString(tx.blng3);
                                this.tbyy4.Text = Convert.ToString(tx.blng4);
                                this.tbyy5.Text = Convert.ToString(tx.blng5);
                                this.tbyy6.Text = Convert.ToString(tx.blng6);
                                this.tbyy7.Text = Convert.ToString(tx.blng7);
                                this.tbyy8.Text = Convert.ToString(tx.blng8);
                                this.tbyy9.Text = Convert.ToString(tx.blng9);
                                this.tbyy10.Text = tx.blngoth;
                                this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                                this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                                #endregion

                                #region LD耦合焊接
                                this.tb1.Text = tx.LD_sbbh1;
                                this.tb2.Text = tx.LD_sbbh2;
                                this.tb3.Text = tx.LD_sbbh3;
                                this.tb4.Text = tx.LD_sbbh4;
                                this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                                this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                                if (tx.LD_xctime == null)
                                {
                                    this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz1.Text = tx.LD_czy1;
                                this.tbcz2.Text = tx.LD_czy2;
                                this.tbcz3.Text = tx.LD_czy3;
                                this.tbcz4.Text = tx.LD_czy4;
                                this.tbname1.Text = tx.LD_czyname1;
                                this.tbname2.Text = tx.LD_czyname2;
                                this.tbname3.Text = tx.LD_czyname3;
                                this.tbname4.Text = tx.LD_czyname4;
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                                this.tbyy11.Text = Convert.ToString(tx.ldng1);
                                this.tbyy12.Text = Convert.ToString(tx.ldng2);
                                this.tbyy13.Text = Convert.ToString(tx.ldng3);
                                this.tbyy14.Text = Convert.ToString(tx.ldng4);
                                this.tbyy15.Text = Convert.ToString(tx.ldng5);
                                this.tbyy16.Text = Convert.ToString(tx.ldng6);
                                this.tbyy17.Text = Convert.ToString(tx.ldng7);
                                this.tbyy18.Text = Convert.ToString(tx.ldng8);
                                this.tbyy19.Text = Convert.ToString(tx.ldng9);
                                this.tbyy20.Text = tx.ldngoth;
                                this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                                this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                                this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                                #endregion

                                #region PT耦合固化
                                this.tb5.Text = tx.PT_sbbh1;
                                this.tb6.Text = tx.PT_sbbh2;
                                this.tb7.Text = tx.PT_sbbh3;
                                this.tb8.Text = tx.PT_sbbh4;
                                if (tx.PT_xcsl == null)
                                {
                                    this.tbxcsl2.Text = Convert.ToString(tx.LD_xcsl);
                                }
                                else
                                {
                                    this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                                }
                                this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);

                                if (tx.PT_xctime == null)
                                {
                                    this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz5.Text = tx.PT_czy1;
                                this.tbcz6.Text = tx.PT_czy2;
                                this.tbcz7.Text = tx.PT_czy3;
                                this.tbcz8.Text = tx.PT_czy4;
                                this.tbname5.Text = tx.PT_czyname1;
                                this.tbname6.Text = tx.PT_czyname2;
                                this.tbname7.Text = tx.PT_czyname3;
                                this.tbname8.Text = tx.PT_czyname4;
                                var lry = this.tblr2.Text = tx.PT_lry;
                                if (lry == "" || lry == "0")
                                {
                                    this.tblr2.Text = gh;
                                    this.tblrname2.Text = yh.姓名;
                                }
                                else
                                {
                                    this.tblr2.Text = tx.PT_lry;
                                    this.tblrname2.Text = tx.PT_lryname;
                                }
                                this.tbyy21.Text = Convert.ToString(tx.ptng1);
                                this.tbyy22.Text = Convert.ToString(tx.ptng2);
                                this.tbyy23.Text = Convert.ToString(tx.ptng3);
                                this.tbyy24.Text = Convert.ToString(tx.ptng4);
                                this.tbyy25.Text = Convert.ToString(tx.ptng5);
                                this.tbyy26.Text = Convert.ToString(tx.ptng6);
                                this.tbyy27.Text = Convert.ToString(tx.ptng7);
                                this.tbyy28.Text = Convert.ToString(tx.ptng8);
                                this.tbyy29.Text = Convert.ToString(tx.ptng9);
                                this.tbyy30.Text = tx.ptngoth;
                                this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                                this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                                #endregion
                            }
                        }
                        #endregion

                        #region 温循前
                        if (yh.机构 == "温循前")
                        {
                            var xiacsl = tx.PT_xcsl;
                            if (xiacsl == null)
                            {
                                MessageBox.Show(" 温循后工序还没做完,无法进行下一步", "提示");
                                this.tabControl1.Enabled = false;
                                this.btnUpdate.Enabled = false;
                                this.btnUpdate.BackColor = Color.LightGray;
                                return;
                            }
                            else
                            {
                                #region 备料
                                this.tbsbbh1.Text = tx.bl_sbbh1;
                                this.tbsbbh2.Text = tx.bl_sbbh2;
                                this.tbsbbh3.Text = tx.bl_sbbh3;
                                this.tbsbbh4.Text = tx.bl_sbbh4;
                                this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                                if (tx.bl_xctime == null)
                                {
                                    this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbczy1.Text = tx.bl_czy1;
                                this.tbczy2.Text = tx.bl_czy2;
                                this.tbczy3.Text = tx.bl_czy3;
                                this.tbczy4.Text = tx.bl_czy4;
                                this.tbczName1.Text = tx.bl_czyname1;
                                this.tbczName2.Text = tx.bl_czyname2;
                                this.tbczName3.Text = tx.bl_czyname3;
                                this.tbczName4.Text = tx.bl_czyname4;
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                                this.tbyy1.Text = Convert.ToString(tx.blng1);
                                this.tbyy2.Text = Convert.ToString(tx.blng2);
                                this.tbyy3.Text = Convert.ToString(tx.blng3);
                                this.tbyy4.Text = Convert.ToString(tx.blng4);
                                this.tbyy5.Text = Convert.ToString(tx.blng5);
                                this.tbyy6.Text = Convert.ToString(tx.blng6);
                                this.tbyy7.Text = Convert.ToString(tx.blng7);
                                this.tbyy8.Text = Convert.ToString(tx.blng8);
                                this.tbyy9.Text = Convert.ToString(tx.blng9);
                                this.tbyy10.Text = tx.blngoth;
                                this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                                this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                                #endregion

                                #region LD耦合焊接
                                this.tb1.Text = tx.LD_sbbh1;
                                this.tb2.Text = tx.LD_sbbh2;
                                this.tb3.Text = tx.LD_sbbh3;
                                this.tb4.Text = tx.LD_sbbh4;
                                this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                                this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                                if (tx.LD_xctime == null)
                                {
                                    this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz1.Text = tx.LD_czy1;
                                this.tbcz2.Text = tx.LD_czy2;
                                this.tbcz3.Text = tx.LD_czy3;
                                this.tbcz4.Text = tx.LD_czy4;
                                this.tbname1.Text = tx.LD_czyname1;
                                this.tbname2.Text = tx.LD_czyname2;
                                this.tbname3.Text = tx.LD_czyname3;
                                this.tbname4.Text = tx.LD_czyname4;
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                                this.tbyy11.Text = Convert.ToString(tx.ldng1);
                                this.tbyy12.Text = Convert.ToString(tx.ldng2);
                                this.tbyy13.Text = Convert.ToString(tx.ldng3);
                                this.tbyy14.Text = Convert.ToString(tx.ldng4);
                                this.tbyy15.Text = Convert.ToString(tx.ldng5);
                                this.tbyy16.Text = Convert.ToString(tx.ldng6);
                                this.tbyy17.Text = Convert.ToString(tx.ldng7);
                                this.tbyy18.Text = Convert.ToString(tx.ldng8);
                                this.tbyy19.Text = Convert.ToString(tx.ldng9);
                                this.tbyy20.Text = tx.ldngoth;
                                this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                                this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                                this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                                #endregion

                                #region PT耦合固化
                                this.tb5.Text = tx.PT_sbbh1;
                                this.tb6.Text = tx.PT_sbbh2;
                                this.tb7.Text = tx.PT_sbbh3;
                                this.tb8.Text = tx.PT_sbbh4;
                                this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                                this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                                if (tx.PT_xctime == null)
                                {
                                    this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz5.Text = tx.PT_czy1;
                                this.tbcz6.Text = tx.PT_czy2;
                                this.tbcz7.Text = tx.PT_czy3;
                                this.tbcz8.Text = tx.PT_czy4;
                                this.tbname5.Text = tx.PT_czyname1;
                                this.tbname6.Text = tx.PT_czyname2;
                                this.tbname7.Text = tx.PT_czyname3;
                                this.tbname8.Text = tx.PT_czyname4;
                                this.tblr2.Text = tx.PT_lry;
                                this.tblrname2.Text = tx.PT_lryname;
                                this.tbyy21.Text = Convert.ToString(tx.ptng1);
                                this.tbyy22.Text = Convert.ToString(tx.ptng2);
                                this.tbyy23.Text = Convert.ToString(tx.ptng3);
                                this.tbyy24.Text = Convert.ToString(tx.ptng4);
                                this.tbyy25.Text = Convert.ToString(tx.ptng5);
                                this.tbyy26.Text = Convert.ToString(tx.ptng6);
                                this.tbyy27.Text = Convert.ToString(tx.ptng7);
                                this.tbyy28.Text = Convert.ToString(tx.ptng8);
                                this.tbyy29.Text = Convert.ToString(tx.ptng9);
                                this.tbyy30.Text = tx.ptngoth;
                                this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                                this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                                #endregion

                                #region 温循前
                                this.tb9.Text = tx.WXQ_sbbh;
                                if (tx.WXQ_sjsl == null)
                                {
                                    this.tbsjsl3.Text = Convert.ToString(tx.PT_xcsl);
                                }
                                else
                                {
                                    this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                                }
                                this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                                if (tx.WXQ_xctime == null)
                                {
                                    this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbcz9.Text = tx.WXQ_czy;
                                this.tbname9.Text = tx.WXQ_czyname;
                                var lry = this.tblr3.Text = tx.WXQ_lry;
                                if (lry == "" || lry == "0")
                                {
                                    this.tblr3.Text = gh;
                                    this.tblrname3.Text = yh.姓名;
                                }
                                else
                                {
                                    this.tblr3.Text = tx.WXQ_lry;
                                    this.tblrname3.Text = tx.WXQ_lryname;
                                }
                                this.rtbremark2.Text = tx.WXQ_remark;
                                #endregion
                            }
                        }
                        #endregion

                        #region 温循后
                        if (yh.机构 == "温循后")
                        {
                            var xiacsl = tx.WXQ_frsl;
                            if (xiacsl == null)
                            {
                                MessageBox.Show(" 温循前工序还没做完,无法进行下一步", "提示");
                                this.tabControl1.Enabled = false;
                                this.btnUpdate.Enabled = false;
                                this.btnUpdate.BackColor = Color.LightGray;
                                return;
                            }
                            else
                            {
                                #region 备料
                                this.tbsbbh1.Text = tx.bl_sbbh1;
                                this.tbsbbh2.Text = tx.bl_sbbh2;
                                this.tbsbbh3.Text = tx.bl_sbbh3;
                                this.tbsbbh4.Text = tx.bl_sbbh4;
                                this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                                if (tx.bl_xctime == null)
                                {
                                    this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbczy1.Text = tx.bl_czy1;
                                this.tbczy2.Text = tx.bl_czy2;
                                this.tbczy3.Text = tx.bl_czy3;
                                this.tbczy4.Text = tx.bl_czy4;
                                this.tbczName1.Text = tx.bl_czyname1;
                                this.tbczName2.Text = tx.bl_czyname2;
                                this.tbczName3.Text = tx.bl_czyname3;
                                this.tbczName4.Text = tx.bl_czyname4;
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                                this.tbyy1.Text = Convert.ToString(tx.blng1);
                                this.tbyy2.Text = Convert.ToString(tx.blng2);
                                this.tbyy3.Text = Convert.ToString(tx.blng3);
                                this.tbyy4.Text = Convert.ToString(tx.blng4);
                                this.tbyy5.Text = Convert.ToString(tx.blng5);
                                this.tbyy6.Text = Convert.ToString(tx.blng6);
                                this.tbyy7.Text = Convert.ToString(tx.blng7);
                                this.tbyy8.Text = Convert.ToString(tx.blng8);
                                this.tbyy9.Text = Convert.ToString(tx.blng9);
                                this.tbyy10.Text = tx.blngoth;
                                this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                                this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                                #endregion

                                #region LD耦合焊接
                                this.tb1.Text = tx.LD_sbbh1;
                                this.tb2.Text = tx.LD_sbbh2;
                                this.tb3.Text = tx.LD_sbbh3;
                                this.tb4.Text = tx.LD_sbbh4;
                                this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                                this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                                if (tx.LD_xctime == null)
                                {
                                    this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz1.Text = tx.LD_czy1;
                                this.tbcz2.Text = tx.LD_czy2;
                                this.tbcz3.Text = tx.LD_czy3;
                                this.tbcz4.Text = tx.LD_czy4;
                                this.tbname1.Text = tx.LD_czyname1;
                                this.tbname2.Text = tx.LD_czyname2;
                                this.tbname3.Text = tx.LD_czyname3;
                                this.tbname4.Text = tx.LD_czyname4;
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                                this.tbyy11.Text = Convert.ToString(tx.ldng1);
                                this.tbyy12.Text = Convert.ToString(tx.ldng2);
                                this.tbyy13.Text = Convert.ToString(tx.ldng3);
                                this.tbyy14.Text = Convert.ToString(tx.ldng4);
                                this.tbyy15.Text = Convert.ToString(tx.ldng5);
                                this.tbyy16.Text = Convert.ToString(tx.ldng6);
                                this.tbyy17.Text = Convert.ToString(tx.ldng7);
                                this.tbyy18.Text = Convert.ToString(tx.ldng8);
                                this.tbyy19.Text = Convert.ToString(tx.ldng9);
                                this.tbyy20.Text = tx.ldngoth;
                                this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                                this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                                this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                                #endregion

                                #region PT耦合固化
                                this.tb5.Text = tx.PT_sbbh1;
                                this.tb6.Text = tx.PT_sbbh2;
                                this.tb7.Text = tx.PT_sbbh3;
                                this.tb8.Text = tx.PT_sbbh4;
                                this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                                this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                                if (tx.PT_xctime == null)
                                {
                                    this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz5.Text = tx.PT_czy1;
                                this.tbcz6.Text = tx.PT_czy2;
                                this.tbcz7.Text = tx.PT_czy3;
                                this.tbcz8.Text = tx.PT_czy4;
                                this.tbname5.Text = tx.PT_czyname1;
                                this.tbname6.Text = tx.PT_czyname2;
                                this.tbname7.Text = tx.PT_czyname3;
                                this.tbname8.Text = tx.PT_czyname4;
                                this.tblr2.Text = tx.PT_lry;
                                this.tblrname2.Text = tx.PT_lryname;
                                this.tbyy21.Text = Convert.ToString(tx.ptng1);
                                this.tbyy22.Text = Convert.ToString(tx.ptng2);
                                this.tbyy23.Text = Convert.ToString(tx.ptng3);
                                this.tbyy24.Text = Convert.ToString(tx.ptng4);
                                this.tbyy25.Text = Convert.ToString(tx.ptng5);
                                this.tbyy26.Text = Convert.ToString(tx.ptng6);
                                this.tbyy27.Text = Convert.ToString(tx.ptng7);
                                this.tbyy28.Text = Convert.ToString(tx.ptng8);
                                this.tbyy29.Text = Convert.ToString(tx.ptng9);
                                this.tbyy30.Text = tx.ptngoth;
                                this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                                this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                                #endregion

                                #region 温循前
                                this.tb9.Text = tx.WXQ_sbbh;
                                this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                                this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                                if (tx.WXQ_xctime == null)
                                {
                                    this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbcz9.Text = tx.WXQ_czy;
                                this.tbname9.Text = tx.WXQ_czyname;
                                this.tblr3.Text = tx.WXQ_lry;
                                this.tblrname3.Text = tx.WXQ_lryname;
                                this.rtbremark2.Text = tx.WXQ_remark;
                                #endregion

                                #region 温循后
                                this.tb10.Text = tx.WXH_sbbh;
                                if (tx.WXH_qcsl == null)
                                {
                                    this.tbqcsl1.Text = Convert.ToString(tx.WXQ_frsl);
                                }
                                else
                                {
                                    this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                                }
                                this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                                if (tx.WXH_xctime == null)
                                {
                                    this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbwxsc.Text = tx.WXH_wxsc;
                                this.tbcz10.Text = tx.WXH_czy;
                                this.tbname10.Text = tx.WXH_czyname;
                                var lry = this.tblr4.Text = tx.WX_Hlry;
                                if (lry == "" || lry == "0")
                                {
                                    this.tblr4.Text = gh;
                                    this.tblrname4.Text = yh.姓名;
                                }
                                else
                                {
                                    this.tblr4.Text = tx.WX_Hlry;
                                    this.tblrname4.Text = tx.WXH_lryname;
                                }
                                this.rtbremark3.Text = tx.WXH_remark;
                                #endregion
                            }
                        }
                        #endregion

                        #region 测试
                        if (yh.机构 == "测试")
                        {
                            var xiacsl = tx.WXH_xcsl;
                            if (xiacsl == null)
                            {
                                MessageBox.Show(" 温循后工序还没做完,无法进行下一步", "提示");
                                this.tabControl1.Enabled = false;
                                this.btnUpdate.Enabled = false;
                                this.btnUpdate.BackColor = Color.LightGray;
                                return;
                            }
                            else
                            {
                                #region 备料
                                this.tbsbbh1.Text = tx.bl_sbbh1;
                                this.tbsbbh2.Text = tx.bl_sbbh2;
                                this.tbsbbh3.Text = tx.bl_sbbh3;
                                this.tbsbbh4.Text = tx.bl_sbbh4;
                                this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                                if (tx.bl_xctime == null)
                                {
                                    this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbczy1.Text = tx.bl_czy1;
                                this.tbczy2.Text = tx.bl_czy2;
                                this.tbczy3.Text = tx.bl_czy3;
                                this.tbczy4.Text = tx.bl_czy4;
                                this.tbczName1.Text = tx.bl_czyname1;
                                this.tbczName2.Text = tx.bl_czyname2;
                                this.tbczName3.Text = tx.bl_czyname3;
                                this.tbczName4.Text = tx.bl_czyname4;
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                                this.tbyy1.Text = Convert.ToString(tx.blng1);
                                this.tbyy2.Text = Convert.ToString(tx.blng2);
                                this.tbyy3.Text = Convert.ToString(tx.blng3);
                                this.tbyy4.Text = Convert.ToString(tx.blng4);
                                this.tbyy5.Text = Convert.ToString(tx.blng5);
                                this.tbyy6.Text = Convert.ToString(tx.blng6);
                                this.tbyy7.Text = Convert.ToString(tx.blng7);
                                this.tbyy8.Text = Convert.ToString(tx.blng8);
                                this.tbyy9.Text = Convert.ToString(tx.blng9);
                                this.tbyy10.Text = tx.blngoth;
                                this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                                this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                                #endregion

                                #region LD耦合焊接
                                this.tb1.Text = tx.LD_sbbh1;
                                this.tb2.Text = tx.LD_sbbh2;
                                this.tb3.Text = tx.LD_sbbh3;
                                this.tb4.Text = tx.LD_sbbh4;
                                this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                                this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                                if (tx.LD_xctime == null)
                                {
                                    this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz1.Text = tx.LD_czy1;
                                this.tbcz2.Text = tx.LD_czy2;
                                this.tbcz3.Text = tx.LD_czy3;
                                this.tbcz4.Text = tx.LD_czy4;
                                this.tbname1.Text = tx.LD_czyname1;
                                this.tbname2.Text = tx.LD_czyname2;
                                this.tbname3.Text = tx.LD_czyname3;
                                this.tbname4.Text = tx.LD_czyname4;
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                                this.tbyy11.Text = Convert.ToString(tx.ldng1);
                                this.tbyy12.Text = Convert.ToString(tx.ldng2);
                                this.tbyy13.Text = Convert.ToString(tx.ldng3);
                                this.tbyy14.Text = Convert.ToString(tx.ldng4);
                                this.tbyy15.Text = Convert.ToString(tx.ldng5);
                                this.tbyy16.Text = Convert.ToString(tx.ldng6);
                                this.tbyy17.Text = Convert.ToString(tx.ldng7);
                                this.tbyy18.Text = Convert.ToString(tx.ldng8);
                                this.tbyy19.Text = Convert.ToString(tx.ldng9);
                                this.tbyy20.Text = tx.ldngoth;
                                this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                                this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                                this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                                #endregion

                                #region PT耦合固化
                                this.tb5.Text = tx.PT_sbbh1;
                                this.tb6.Text = tx.PT_sbbh2;
                                this.tb7.Text = tx.PT_sbbh3;
                                this.tb8.Text = tx.PT_sbbh4;
                                this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                                this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                                if (tx.PT_xctime == null)
                                {
                                    this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz5.Text = tx.PT_czy1;
                                this.tbcz6.Text = tx.PT_czy2;
                                this.tbcz7.Text = tx.PT_czy3;
                                this.tbcz8.Text = tx.PT_czy4;
                                this.tbname5.Text = tx.PT_czyname1;
                                this.tbname6.Text = tx.PT_czyname2;
                                this.tbname7.Text = tx.PT_czyname3;
                                this.tbname8.Text = tx.PT_czyname4;
                                this.tblr2.Text = tx.PT_lry;
                                this.tblrname2.Text = tx.PT_lryname;
                                this.tbyy21.Text = Convert.ToString(tx.ptng1);
                                this.tbyy22.Text = Convert.ToString(tx.ptng2);
                                this.tbyy23.Text = Convert.ToString(tx.ptng3);
                                this.tbyy24.Text = Convert.ToString(tx.ptng4);
                                this.tbyy25.Text = Convert.ToString(tx.ptng5);
                                this.tbyy26.Text = Convert.ToString(tx.ptng6);
                                this.tbyy27.Text = Convert.ToString(tx.ptng7);
                                this.tbyy28.Text = Convert.ToString(tx.ptng8);
                                this.tbyy29.Text = Convert.ToString(tx.ptng9);
                                this.tbyy30.Text = tx.ptngoth;
                                this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                                this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                                #endregion

                                #region 温循前
                                this.tb9.Text = tx.WXQ_sbbh;
                                this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                                this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                                if (tx.WXQ_xctime == null)
                                {
                                    this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbcz9.Text = tx.WXQ_czy;
                                this.tbname9.Text = tx.WXQ_czyname;
                                this.tblr3.Text = tx.WXQ_lry;
                                this.tblrname3.Text = tx.WXQ_lryname;
                                this.rtbremark2.Text = tx.WXQ_remark;
                                #endregion

                                #region 温循后
                                this.tb10.Text = tx.WXH_sbbh;
                                this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                                this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                                if (tx.WXH_xctime == null)
                                {
                                    this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbwxsc.Text = tx.WXH_wxsc;
                                this.tbcz10.Text = tx.WXH_czy;
                                this.tbname10.Text = tx.WXH_czyname;
                                this.tblr4.Text = tx.WX_Hlry;
                                this.tblrname4.Text = tx.WXH_lryname;
                                this.rtbremark3.Text = tx.WXH_remark;
                                #endregion

                                #region 测试
                                this.tb11.Text = tx.CS_sbbh1;
                                this.tb12.Text = tx.CS_sbbh2;
                                this.tb13.Text = tx.CS_sbbh3;
                                this.tb14.Text = tx.CS_sbbh4;
                                if (tx.CS_sjsl == null)
                                {
                                    this.tbsjsl4.Text = Convert.ToString(tx.WXH_xcsl);
                                }
                                else
                                {
                                    this.tbsjsl4.Text = Convert.ToString(tx.CS_sjsl);
                                }
                                this.tbxcsl4.Text = Convert.ToString(tx.CS_xcsl);
                                if (tx.CS_xctime == null)
                                {
                                    this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxtime3.Text = Convert.ToDateTime(tx.CS_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz11.Text = tx.CS_czy1;
                                this.tbcz12.Text = tx.CS_czy2;
                                this.tbcz13.Text = tx.CS_czy3;
                                this.tbcz14.Text = tx.CS_czy4;
                                this.tbname11.Text = tx.CS_czyname1;
                                this.tbname12.Text = tx.CS_czyname2;
                                this.tbname13.Text = tx.CS_czyname3;
                                this.tbname14.Text = tx.CS_czyname4;
                                var lry = this.tblr5.Text = tx.CS_lry;
                                if (lry == "" || lry == "0")
                                {
                                    this.tblr5.Text = gh;
                                    this.tblrname5.Text = yh.姓名;
                                }
                                else
                                {
                                    this.tblr5.Text = tx.CS_lry;
                                    this.tblrname5.Text = tx.CS_lryname;
                                }
                                this.tbyy31.Text = Convert.ToString(tx.csng1);
                                this.tbyy32.Text = Convert.ToString(tx.csng2);
                                this.tbyy33.Text = Convert.ToString(tx.csng3);
                                this.tbyy34.Text = Convert.ToString(tx.csng4);
                                this.tbyy35.Text = Convert.ToString(tx.csng5);
                                this.tbyy36.Text = Convert.ToString(tx.csng6);
                                this.tbyy37.Text = Convert.ToString(tx.csng7);
                                this.tbyy38.Text = Convert.ToString(tx.csng8);
                                this.rtbyy39.Text = tx.csngoth;
                                this.tbyy39sl.Text = Convert.ToString(tx.csngothnum);
                                this.tbbhgsl2.Text = Convert.ToString(tx.CS_bhgallsl);
                                #endregion
                            }
                        }
                        #endregion

                        #region 清洗
                        if (yh.机构 == "清洗")
                        {
                            var xiacsl = tx.CS_xcsl;
                            if (xiacsl == null)
                            {
                                MessageBox.Show("测试工序还没做完,无法进行下一步", "提示");
                                this.tabControl1.Enabled = false;
                                this.btnUpdate.Enabled = false;
                                this.btnUpdate.BackColor = Color.LightGray;
                                return;
                            }
                            else
                            {
                                #region 备料
                                this.tbsbbh1.Text = tx.bl_sbbh1;
                                this.tbsbbh2.Text = tx.bl_sbbh2;
                                this.tbsbbh3.Text = tx.bl_sbbh3;
                                this.tbsbbh4.Text = tx.bl_sbbh4;
                                this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                                if (tx.bl_xctime == null)
                                {
                                    this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbczy1.Text = tx.bl_czy1;
                                this.tbczy2.Text = tx.bl_czy2;
                                this.tbczy3.Text = tx.bl_czy3;
                                this.tbczy4.Text = tx.bl_czy4;
                                this.tbczName1.Text = tx.bl_czyname1;
                                this.tbczName2.Text = tx.bl_czyname2;
                                this.tbczName3.Text = tx.bl_czyname3;
                                this.tbczName4.Text = tx.bl_czyname4;
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                                this.tbyy1.Text = Convert.ToString(tx.blng1);
                                this.tbyy2.Text = Convert.ToString(tx.blng2);
                                this.tbyy3.Text = Convert.ToString(tx.blng3);
                                this.tbyy4.Text = Convert.ToString(tx.blng4);
                                this.tbyy5.Text = Convert.ToString(tx.blng5);
                                this.tbyy6.Text = Convert.ToString(tx.blng6);
                                this.tbyy7.Text = Convert.ToString(tx.blng7);
                                this.tbyy8.Text = Convert.ToString(tx.blng8);
                                this.tbyy9.Text = Convert.ToString(tx.blng9);
                                this.tbyy10.Text = tx.blngoth;
                                this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                                this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                                #endregion

                                #region LD耦合焊接
                                this.tb1.Text = tx.LD_sbbh1;
                                this.tb2.Text = tx.LD_sbbh2;
                                this.tb3.Text = tx.LD_sbbh3;
                                this.tb4.Text = tx.LD_sbbh4;
                                this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                                this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                                if (tx.LD_xctime == null)
                                {
                                    this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz1.Text = tx.LD_czy1;
                                this.tbcz2.Text = tx.LD_czy2;
                                this.tbcz3.Text = tx.LD_czy3;
                                this.tbcz4.Text = tx.LD_czy4;
                                this.tbname1.Text = tx.LD_czyname1;
                                this.tbname2.Text = tx.LD_czyname2;
                                this.tbname3.Text = tx.LD_czyname3;
                                this.tbname4.Text = tx.LD_czyname4;
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                                this.tbyy11.Text = Convert.ToString(tx.ldng1);
                                this.tbyy12.Text = Convert.ToString(tx.ldng2);
                                this.tbyy13.Text = Convert.ToString(tx.ldng3);
                                this.tbyy14.Text = Convert.ToString(tx.ldng4);
                                this.tbyy15.Text = Convert.ToString(tx.ldng5);
                                this.tbyy16.Text = Convert.ToString(tx.ldng6);
                                this.tbyy17.Text = Convert.ToString(tx.ldng7);
                                this.tbyy18.Text = Convert.ToString(tx.ldng8);
                                this.tbyy19.Text = Convert.ToString(tx.ldng9);
                                this.tbyy20.Text = tx.ldngoth;
                                this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                                this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                                this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                                #endregion

                                #region PT耦合固化
                                this.tb5.Text = tx.PT_sbbh1;
                                this.tb6.Text = tx.PT_sbbh2;
                                this.tb7.Text = tx.PT_sbbh3;
                                this.tb8.Text = tx.PT_sbbh4;
                                this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                                this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                                if (tx.PT_xctime == null)
                                {
                                    this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz5.Text = tx.PT_czy1;
                                this.tbcz6.Text = tx.PT_czy2;
                                this.tbcz7.Text = tx.PT_czy3;
                                this.tbcz8.Text = tx.PT_czy4;
                                this.tbname5.Text = tx.PT_czyname1;
                                this.tbname6.Text = tx.PT_czyname2;
                                this.tbname7.Text = tx.PT_czyname3;
                                this.tbname8.Text = tx.PT_czyname4;
                                this.tblr2.Text = tx.PT_lry;
                                this.tblrname2.Text = tx.PT_lryname;
                                this.tbyy21.Text = Convert.ToString(tx.ptng1);
                                this.tbyy22.Text = Convert.ToString(tx.ptng2);
                                this.tbyy23.Text = Convert.ToString(tx.ptng3);
                                this.tbyy24.Text = Convert.ToString(tx.ptng4);
                                this.tbyy25.Text = Convert.ToString(tx.ptng5);
                                this.tbyy26.Text = Convert.ToString(tx.ptng6);
                                this.tbyy27.Text = Convert.ToString(tx.ptng7);
                                this.tbyy28.Text = Convert.ToString(tx.ptng8);
                                this.tbyy29.Text = Convert.ToString(tx.ptng9);
                                this.tbyy30.Text = tx.ptngoth;
                                this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                                this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                                #endregion

                                #region 温循前
                                this.tb9.Text = tx.WXQ_sbbh;
                                this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                                this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                                if (tx.WXQ_xctime == null)
                                {
                                    this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbcz9.Text = tx.WXQ_czy;
                                this.tbname9.Text = tx.WXQ_czyname;
                                this.tblr3.Text = tx.WXQ_lry;
                                this.tblrname3.Text = tx.WXQ_lryname;
                                this.rtbremark2.Text = tx.WXQ_remark;
                                #endregion

                                #region 温循后
                                this.tb10.Text = tx.WXH_sbbh;
                                this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                                this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                                if (tx.WXH_xctime == null)
                                {
                                    this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbwxsc.Text = tx.WXH_wxsc;
                                this.tbcz10.Text = tx.WXH_czy;
                                this.tbname10.Text = tx.WXH_czyname;
                                this.tblr4.Text = tx.WX_Hlry;
                                this.tblrname4.Text = tx.WXH_lryname;
                                this.rtbremark3.Text = tx.WXH_remark;
                                #endregion

                                #region 测试
                                this.tb11.Text = tx.CS_sbbh1;
                                this.tb12.Text = tx.CS_sbbh2;
                                this.tb13.Text = tx.CS_sbbh3;
                                this.tb14.Text = tx.CS_sbbh4;
                                this.tbsjsl4.Text = Convert.ToString(tx.CS_sjsl);
                                this.tbxcsl4.Text = Convert.ToString(tx.CS_xcsl);
                                if (tx.CS_xctime == null)
                                {
                                    this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxtime3.Text = Convert.ToDateTime(tx.CS_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz11.Text = tx.CS_czy1;
                                this.tbcz12.Text = tx.CS_czy2;
                                this.tbcz13.Text = tx.CS_czy3;
                                this.tbcz14.Text = tx.CS_czy4;
                                this.tbname11.Text = tx.CS_czyname1;
                                this.tbname12.Text = tx.CS_czyname2;
                                this.tbname13.Text = tx.CS_czyname3;
                                this.tbname14.Text = tx.CS_czyname4;
                                this.tbyy31.Text = Convert.ToString(tx.csng1);
                                this.tbyy32.Text = Convert.ToString(tx.csng2);
                                this.tbyy33.Text = Convert.ToString(tx.csng3);
                                this.tbyy34.Text = Convert.ToString(tx.csng4);
                                this.tbyy35.Text = Convert.ToString(tx.csng5);
                                this.tbyy36.Text = Convert.ToString(tx.csng6);
                                this.tbyy37.Text = Convert.ToString(tx.csng7);
                                this.tbyy38.Text = Convert.ToString(tx.csng8);
                                this.rtbyy39.Text = tx.csngoth;
                                this.tbyy39sl.Text = Convert.ToString(tx.csngothnum);
                                this.tbbhgsl2.Text = Convert.ToString(tx.CS_bhgallsl);
                                #endregion

                                #region 清洗
                                this.tb15.Text = tx.QX_sbbh1;
                                this.tb16.Text = tx.QX_sbbh2;
                                this.tb17.Text = tx.QX_sbbh3;
                                this.tb18.Text = tx.QX_sbbh4;
                                if (tx.QX_sjsl == null)
                                {
                                    this.tbsjsl5.Text = Convert.ToString(tx.CS_xcsl);
                                }
                                else
                                {
                                    this.tbsjsl5.Text = Convert.ToString(tx.QX_sjsl);
                                }
                                this.tbxcsl5.Text = Convert.ToString(tx.QX_xcsl);
                                if (tx.QX_xctime == null)
                                {
                                    this.dtpxctime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxctime3.Text = Convert.ToDateTime(tx.QX_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz15.Text = tx.QX_czy1;
                                this.tbcz16.Text = tx.QX_czy2;
                                this.tbcz17.Text = tx.QX_czy3;
                                this.tbcz18.Text = tx.QX_czy4;
                                this.tbname15.Text = tx.QX_czyname1;
                                this.tbname16.Text = tx.QX_czyname2;
                                this.tbname17.Text = tx.QX_czyname3;
                                this.tbname18.Text = tx.QX_czyname4;
                                var lry = this.tblr6.Text = tx.QX_lry;
                                if (lry == "" || lry == "0")
                                {
                                    this.tblr6.Text = gh;
                                    this.tblrname6.Text = yh.姓名;
                                }
                                else
                                {
                                    this.tblr6.Text = tx.QX_lry;
                                    this.tblrname6.Text = tx.QX_lryname;
                                }
                                this.tbyy40.Text = Convert.ToString(tx.qxng1);
                                this.rtbyy41.Text = tx.qxngoth;
                                this.tbyy41sl.Text = Convert.ToString(tx.qxngothnum);
                                this.tbbhgsl3.Text = Convert.ToString(tx.QX_bhgallsl);
                                #endregion
                            }
                        }
                        #endregion

                        #region 包装
                        if (yh.机构 == "包装")
                        {
                            var xiacsl = tx.QX_xcsl;
                            if (xiacsl == null)
                            {
                                MessageBox.Show("清洗工序还没做完,无法进行下一步", "提示");
                                this.tabControl1.Enabled = false;
                                this.btnUpdate.Enabled = false;
                                this.btnUpdate.BackColor = Color.LightGray;
                                return;
                            }
                            else
                            {
                                #region 备料
                                this.tbsbbh1.Text = tx.bl_sbbh1;
                                this.tbsbbh2.Text = tx.bl_sbbh2;
                                this.tbsbbh3.Text = tx.bl_sbbh3;
                                this.tbsbbh4.Text = tx.bl_sbbh4;
                                this.tbxcsl.Text = Convert.ToString(tx.bl_xcsl);
                                if (tx.bl_xctime == null)
                                {
                                    this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxcTime.Text = Convert.ToDateTime(tx.bl_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbczy1.Text = tx.bl_czy1;
                                this.tbczy2.Text = tx.bl_czy2;
                                this.tbczy3.Text = tx.bl_czy3;
                                this.tbczy4.Text = tx.bl_czy4;
                                this.tbczName1.Text = tx.bl_czyname1;
                                this.tbczName2.Text = tx.bl_czyname2;
                                this.tbczName3.Text = tx.bl_czyname3;
                                this.tbczName4.Text = tx.bl_czyname4;
                                this.tblry.Text = tx.bl_lry;
                                this.tblrName.Text = tx.bl_lryname;
                                this.tbyy1.Text = Convert.ToString(tx.blng1);
                                this.tbyy2.Text = Convert.ToString(tx.blng2);
                                this.tbyy3.Text = Convert.ToString(tx.blng3);
                                this.tbyy4.Text = Convert.ToString(tx.blng4);
                                this.tbyy5.Text = Convert.ToString(tx.blng5);
                                this.tbyy6.Text = Convert.ToString(tx.blng6);
                                this.tbyy7.Text = Convert.ToString(tx.blng7);
                                this.tbyy8.Text = Convert.ToString(tx.blng8);
                                this.tbyy9.Text = Convert.ToString(tx.blng9);
                                this.tbyy10.Text = tx.blngoth;
                                this.tbyy10Sl.Text = Convert.ToString(tx.blngothnum);
                                this.tbbhgsl.Text = Convert.ToString(tx.bl_bhgallsl);
                                #endregion

                                #region LD耦合焊接
                                this.tb1.Text = tx.LD_sbbh1;
                                this.tb2.Text = tx.LD_sbbh2;
                                this.tb3.Text = tx.LD_sbbh3;
                                this.tb4.Text = tx.LD_sbbh4;
                                this.tbsjsl1.Text = Convert.ToString(tx.LD_sjsl);
                                this.tbxcsl1.Text = Convert.ToString(tx.LD_xcsl);
                                if (tx.LD_xctime == null)
                                {
                                    this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtp1.Text = Convert.ToDateTime(tx.LD_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz1.Text = tx.LD_czy1;
                                this.tbcz2.Text = tx.LD_czy2;
                                this.tbcz3.Text = tx.LD_czy3;
                                this.tbcz4.Text = tx.LD_czy4;
                                this.tbname1.Text = tx.LD_czyname1;
                                this.tbname2.Text = tx.LD_czyname2;
                                this.tbname3.Text = tx.LD_czyname3;
                                this.tbname4.Text = tx.LD_czyname4;
                                this.tblr1.Text = tx.LD_lry;
                                this.tblrname1.Text = tx.LD_lryname;
                                this.tbyy11.Text = Convert.ToString(tx.ldng1);
                                this.tbyy12.Text = Convert.ToString(tx.ldng2);
                                this.tbyy13.Text = Convert.ToString(tx.ldng3);
                                this.tbyy14.Text = Convert.ToString(tx.ldng4);
                                this.tbyy15.Text = Convert.ToString(tx.ldng5);
                                this.tbyy16.Text = Convert.ToString(tx.ldng6);
                                this.tbyy17.Text = Convert.ToString(tx.ldng7);
                                this.tbyy18.Text = Convert.ToString(tx.ldng8);
                                this.tbyy19.Text = Convert.ToString(tx.ldng9);
                                this.tbyy20.Text = tx.ldngoth;
                                this.tbyy20sl.Text = Convert.ToString(tx.ldngothnum);
                                this.tbbhksl1.Text = Convert.ToString(tx.LD_bhgallsl);
                                this.tbjzsl1.Text = Convert.ToString(tx.LD_jzsl);
                                #endregion

                                #region PT耦合固化
                                this.tb5.Text = tx.PT_sbbh1;
                                this.tb6.Text = tx.PT_sbbh2;
                                this.tb7.Text = tx.PT_sbbh3;
                                this.tb8.Text = tx.PT_sbbh4;
                                this.tbsjsl2.Text = Convert.ToString(tx.PT_sjsl);
                                this.tbxcsl2.Text = Convert.ToString(tx.PT_xcsl);
                                if (tx.PT_xctime == null)
                                {
                                    this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtptime2.Text = Convert.ToDateTime(tx.PT_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz5.Text = tx.PT_czy1;
                                this.tbcz6.Text = tx.PT_czy2;
                                this.tbcz7.Text = tx.PT_czy3;
                                this.tbcz8.Text = tx.PT_czy4;
                                this.tbname5.Text = tx.PT_czyname1;
                                this.tbname6.Text = tx.PT_czyname2;
                                this.tbname7.Text = tx.PT_czyname3;
                                this.tbname8.Text = tx.PT_czyname4;
                                this.tblr2.Text = tx.PT_lry;
                                this.tblrname2.Text = tx.PT_lryname;
                                this.tbyy21.Text = Convert.ToString(tx.ptng1);
                                this.tbyy22.Text = Convert.ToString(tx.ptng2);
                                this.tbyy23.Text = Convert.ToString(tx.ptng3);
                                this.tbyy24.Text = Convert.ToString(tx.ptng4);
                                this.tbyy25.Text = Convert.ToString(tx.ptng5);
                                this.tbyy26.Text = Convert.ToString(tx.ptng6);
                                this.tbyy27.Text = Convert.ToString(tx.ptng7);
                                this.tbyy28.Text = Convert.ToString(tx.ptng8);
                                this.tbyy29.Text = Convert.ToString(tx.ptng9);
                                this.tbyy30.Text = tx.ptngoth;
                                this.tbyy30sl.Text = Convert.ToString(tx.ptngothnum);
                                this.textBox100.Text = Convert.ToString(tx.PT_bhgallsl);
                                #endregion

                                #region 温循前
                                this.tb9.Text = tx.WXQ_sbbh;
                                this.tbsjsl3.Text = Convert.ToString(tx.WXQ_sjsl);
                                this.tbfrsl1.Text = Convert.ToString(tx.WXQ_frsl);
                                if (tx.WXQ_xctime == null)
                                {
                                    this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpfrtime1.Text = Convert.ToDateTime(tx.WXQ_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbcz9.Text = tx.WXQ_czy;
                                this.tbname9.Text = tx.WXQ_czyname;
                                this.tblr3.Text = tx.WXQ_lry;
                                this.tblrname3.Text = tx.WXQ_lryname;
                                this.rtbremark2.Text = tx.WXQ_remark;
                                #endregion

                                #region 温循后
                                this.tb10.Text = tx.WXH_sbbh;
                                this.tbqcsl1.Text = Convert.ToString(tx.WXH_qcsl);
                                this.tbxcsl3.Text = Convert.ToString(tx.WXH_xcsl);
                                if (tx.WXH_xctime == null)
                                {
                                    this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    this.dtpqcTime1.Text = Convert.ToDateTime(tx.WXH_xctime).ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                this.tbwxsc.Text = tx.WXH_wxsc;
                                this.tbcz10.Text = tx.WXH_czy;
                                this.tbname10.Text = tx.WXH_czyname;
                                this.tblr4.Text = tx.WX_Hlry;
                                this.tblrname4.Text = tx.WXH_lryname;
                                this.rtbremark3.Text = tx.WXH_remark;
                                #endregion

                                #region 测试
                                this.tb11.Text = tx.CS_sbbh1;
                                this.tb12.Text = tx.CS_sbbh2;
                                this.tb13.Text = tx.CS_sbbh3;
                                this.tb14.Text = tx.CS_sbbh4;
                                this.tbsjsl4.Text = Convert.ToString(tx.CS_sjsl);
                                this.tbxcsl4.Text = Convert.ToString(tx.CS_xcsl);
                                if (tx.CS_xctime == null)
                                {
                                    this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxtime3.Text = Convert.ToDateTime(tx.CS_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz11.Text = tx.CS_czy1;
                                this.tbcz12.Text = tx.CS_czy2;
                                this.tbcz13.Text = tx.CS_czy3;
                                this.tbcz14.Text = tx.CS_czy4;
                                this.tbname11.Text = tx.CS_czyname1;
                                this.tbname12.Text = tx.CS_czyname2;
                                this.tbname13.Text = tx.CS_czyname3;
                                this.tbname14.Text = tx.CS_czyname4;
                                this.tbyy31.Text = Convert.ToString(tx.csng1);
                                this.tbyy32.Text = Convert.ToString(tx.csng2);
                                this.tbyy33.Text = Convert.ToString(tx.csng3);
                                this.tbyy34.Text = Convert.ToString(tx.csng4);
                                this.tbyy35.Text = Convert.ToString(tx.csng5);
                                this.tbyy36.Text = Convert.ToString(tx.csng6);
                                this.tbyy37.Text = Convert.ToString(tx.csng7);
                                this.tbyy38.Text = Convert.ToString(tx.csng8);
                                this.rtbyy39.Text = tx.csngoth;
                                this.tbyy39sl.Text = Convert.ToString(tx.csngothnum);
                                this.tbbhgsl2.Text = Convert.ToString(tx.CS_bhgallsl);
                                #endregion

                                #region 清洗
                                this.tb15.Text = tx.QX_sbbh1;
                                this.tb16.Text = tx.QX_sbbh2;
                                this.tb17.Text = tx.QX_sbbh3;
                                this.tb18.Text = tx.QX_sbbh4;
                                this.tbsjsl5.Text = Convert.ToString(tx.QX_sjsl);
                                this.tbxcsl5.Text = Convert.ToString(tx.QX_xcsl);
                                if (tx.QX_xctime == null)
                                {
                                    this.dtpxctime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxctime3.Text = Convert.ToDateTime(tx.QX_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz15.Text = tx.QX_czy1;
                                this.tbcz16.Text = tx.QX_czy2;
                                this.tbcz17.Text = tx.QX_czy3;
                                this.tbcz18.Text = tx.QX_czy4;
                                this.tbname15.Text = tx.QX_czyname1;
                                this.tbname16.Text = tx.QX_czyname2;
                                this.tbname17.Text = tx.QX_czyname3;
                                this.tbname18.Text = tx.QX_czyname4;
                                this.tbyy40.Text = Convert.ToString(tx.qxng1);
                                this.rtbyy41.Text = tx.qxngoth;
                                this.tbyy41sl.Text = Convert.ToString(tx.qxngothnum);
                                this.tbbhgsl3.Text = Convert.ToString(tx.QX_bhgallsl);
                                #endregion

                                #region 包装
                                this.tb19.Text = tx.BZ_sbbh1;
                                this.tb20.Text = tx.BZ_sbbh2;
                                this.tb21.Text = tx.BZ_sbbh3;
                                this.tb22.Text = tx.BZ_sbbh4;
                                if (tx.BZ_sjsl == null)
                                {
                                    this.tbsjsl6.Text = Convert.ToString(tx.QX_xcsl);
                                }
                                else
                                {
                                    this.tbsjsl6.Text = Convert.ToString(tx.BZ_sjsl);
                                }
                                this.tbxcsl6.Text = Convert.ToString(tx.BZ_xcsl);
                                if (tx.BZ_xctime == null)
                                {
                                    this.dtpxctime4.Text = DateTime.Now.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    this.dtpxctime4.Text = Convert.ToDateTime(tx.BZ_xctime).ToString("yyyy-MM-dd");
                                }
                                this.tbcz19.Text = tx.BZ_czy1;
                                this.tbcz20.Text = tx.BZ_czy2;
                                this.tbcz21.Text = tx.BZ_czy3;
                                this.tbcz22.Text = tx.BZ_czy4;
                                this.tbname19.Text = tx.BZ_czyname1;
                                this.tbname20.Text = tx.BZ_czyname2;
                                this.tbname21.Text = tx.BZ_czyname3;
                                this.tbname22.Text = tx.BZ_czyname4;
                                var lry = this.tblr7.Text = tx.BZ_lry;
                                if (lry == "" || lry == "0")
                                {
                                    this.tblr7.Text = gh;
                                    this.tblrname7.Text = yh.姓名;
                                }
                                else
                                {
                                    this.tblr7.Text = tx.BZ_lry;
                                    this.tblrname7.Text = tx.BZ_lryname;
                                }
                                this.tbyy42.Text = Convert.ToString(tx.bzng1);
                                this.rtbyy43.Text = tx.bzngoth;
                                this.tbyy43sl.Text = Convert.ToString(tx.bzngothnum);
                                this.tbbhgsl4.Text = Convert.ToString(tx.BZ_bhgallsl);
                                #endregion
                            }
                        }
                        #endregion
                        this.tabControl1.Enabled = true;

                    }
                }
                else
                {
                    MessageBox.Show("备料工序还没开始", "提示");
                    if (yh.机构 == "全部")
                    {
                        this.tabControl1.Enabled = true;
                        this.btnCancel.Enabled = false;
                        this.btnCancel.BackColor = Color.LightGray;
                        this.btnOk.Enabled = true;
                        this.btnOk.BackColor = Color.Teal;
                    }
                    else if (yh.机构 == "备料")
                    {
                        this.tabControl1.Enabled = true;
                        this.btnOk.Enabled = true;
                        this.btnOk.BackColor = Color.Teal;
                        this.btnCancel.Enabled = true;
                        this.btnCancel.BackColor = Color.Teal;
                    }
                    else
                    {
                        this.tabControl1.Enabled = false;
                        this.btnOk.Enabled = false;
                        this.btnOk.BackColor = Color.LightGray;
                        this.btnCancel.Enabled = true;
                        this.btnCancel.BackColor = Color.Teal;
                    }
                    this.btnUpdate.Enabled = false;
                    this.btnUpdate.BackColor = Color.LightGray;
                    return;
                }
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //时间正则表达式
            string reg = @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$";
            string regs = @"^(((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d)$";
            
            var name =Convert.ToInt32(gh);
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);
            tsuhan_sg_tx bhd = new tsuhan_sg_tx();
            var sgdxh = this.tbSGDXH.Text + this.tbDXH1.Text;
            bhd.随工单号 = sgdxh;

            #region 判断不合格数量是否正确
            //if (yh.机构 == "备料")
            //{

                if (this.tbyy10Sl.Text == "")
                {
                    this.tbyy10Sl.Text = "0";
                }
                if (this.tbyy9.Text == "")
                {
                    this.tbyy9.Text = "0";
                }
                if (this.tbyy8.Text == "")
                {
                    this.tbyy8.Text = "0";
                }
                if (this.tbyy7.Text == "")
                {
                    this.tbyy7.Text = "0";
                }
                if (this.tbyy6.Text == "")
                {
                    this.tbyy6.Text = "0";
                }
                if (this.tbyy5.Text == "")
                {
                    this.tbyy5.Text = "0";
                }
                if (this.tbyy4.Text == "")
                {
                    this.tbyy4.Text = "0";
                }
                if (this.tbyy3.Text == "")
                {
                    this.tbyy3.Text = "0";
                }
                if (this.tbyy2.Text == "")
                {
                    this.tbyy2.Text = "0";
                }
                if (this.tbyy1.Text == "")
                {
                    this.tbyy1.Text = "0";
                }
                if (this.tbbhgsl.Text == "")
                {
                    this.tbbhgsl.Text = "0";
                }
                var allnum = int.Parse(this.tbyy1.Text) + int.Parse(this.tbyy2.Text) + int.Parse(this.tbyy3.Text) + int.Parse(this.tbyy4.Text) + int.Parse(this.tbyy5.Text) + int.Parse(this.tbyy6.Text) + int.Parse(this.tbyy7.Text) + int.Parse(this.tbyy8.Text) + int.Parse(this.tbyy9.Text) + int.Parse(this.tbyy10Sl.Text);
                if (this.tbbhgsl.Text != Convert.ToString(allnum))
                {
                    MessageBox.Show("不合格总数错误", "提示");
                    return;
                }

            //}
            //else if (yh.机构 == "LD耦合焊接")
            //{
                if (this.tbyy20sl.Text == "")
                {
                    this.tbyy20sl.Text = "0";
                }
                if (this.tbyy19.Text == "")
                {
                    this.tbyy19.Text = "0";
                }
                if (this.tbyy18.Text == "")
                {
                    this.tbyy18.Text = "0";
                }
                if (this.tbyy17.Text == "")
                {
                    this.tbyy17.Text = "0";
                }
                if (this.tbyy16.Text == "")
                {
                    this.tbyy16.Text = "0";
                }
                if (this.tbyy15.Text == "")
                {
                    this.tbyy15.Text = "0";
                }
                if (this.tbyy14.Text == "")
                {
                    this.tbyy14.Text = "0";
                }
                if (this.tbyy13.Text == "")
                {
                    this.tbyy13.Text = "0";
                }
                if (this.tbyy12.Text == "")
                {
                    this.tbyy12.Text = "0";
                }
                if (this.tbyy11.Text == "")
                {
                    this.tbyy11.Text = "0";
                }
                if (this.tbjzsl1.Text == "")
                {
                    this.tbjzsl1.Text = "0";
                }
                if (this.tbbhksl1.Text == "")
                {
                    this.tbbhksl1.Text = "0";
                }

                var allnum1 = int.Parse(this.tbyy11.Text) + int.Parse(this.tbyy12.Text) + int.Parse(this.tbyy13.Text) + int.Parse(this.tbyy14.Text) + int.Parse(this.tbyy15.Text) + int.Parse(this.tbyy16.Text) + int.Parse(this.tbyy17.Text) + int.Parse(this.tbyy18.Text) + int.Parse(this.tbyy19.Text) + int.Parse(this.tbyy20sl.Text);
                var num = int.Parse(this.tbbhksl1.Text) + int.Parse(this.tbjzsl1.Text);
                var all = num + int.Parse(this.tbxcsl1.Text);
                if (Convert.ToString(num) != Convert.ToString(allnum1))
                {
                    MessageBox.Show("不合格总数错误", "提示");
                    return;
                }
                else if (Convert.ToString(all) != this.tbsjsl1.Text)
                {
                    MessageBox.Show("数量与上接数量不符", "提示");
                    return;
                }
            //}
            //else if (yh.机构 == "PT耦合固化")
            //{
                if (this.tbyy30sl.Text == "")
                {
                    this.tbyy30sl.Text = "0";
                }
                if (this.tbyy29.Text == "")
                {
                    this.tbyy29.Text = "0";
                }
                if (this.tbyy28.Text == "")
                {
                    this.tbyy28.Text = "0";
                }
                if (this.tbyy27.Text == "")
                {
                    this.tbyy27.Text = "0";
                }
                if (this.tbyy26.Text == "")
                {
                    this.tbyy26.Text = "0";
                }
                if (this.tbyy25.Text == "")
                {
                    this.tbyy25.Text = "0";
                }
                if (this.tbyy24.Text == "")
                {
                    this.tbyy24.Text = "0";
                }
                if (this.tbyy23.Text == "")
                {
                    this.tbyy23.Text = "0";
                }
                if (this.tbyy22.Text == "")
                {
                    this.tbyy22.Text = "0";
                }
                if (this.tbyy21.Text == "")
                {
                    this.tbyy21.Text = "0";
                }
                if (this.textBox100.Text == "")
                {
                    this.textBox100.Text = "0";
                }
                var allnum2 = int.Parse(this.tbyy21.Text) + int.Parse(this.tbyy22.Text) + int.Parse(this.tbyy23.Text) + int.Parse(this.tbyy24.Text) + int.Parse(this.tbyy25.Text) + int.Parse(this.tbyy26.Text) + int.Parse(this.tbyy27.Text) + int.Parse(this.tbyy28.Text) + int.Parse(this.tbyy29.Text) + int.Parse(this.tbyy30sl.Text);
                var all1 = int.Parse(this.textBox100.Text) + int.Parse(this.tbxcsl2.Text);
                if (this.textBox100.Text != Convert.ToString(allnum2))
                {
                    MessageBox.Show("不合格总数错误", "提示");
                    return;
                }
                else if (Convert.ToString(all1) != this.tbsjsl2.Text)
                {
                    MessageBox.Show("数量与上接数量不符", "提示");
                    return;
                }
            //}
            //else if (yh.机构 == "测试")
            //{
                if (this.tbyy39sl.Text == "")
                {
                    this.tbyy39sl.Text = "0";
                }
                if (this.tbyy38.Text == "")
                {
                    this.tbyy38.Text = "0";
                }
                if (this.tbyy37.Text == "")
                {
                    this.tbyy37.Text = "0";
                }
                if (this.tbyy36.Text == "")
                {
                    this.tbyy36.Text = "0";
                }
                if (this.tbyy35.Text == "")
                {
                    this.tbyy35.Text = "0";
                }
                if (this.tbyy34.Text == "")
                {
                    this.tbyy34.Text = "0";
                }
                if (this.tbyy33.Text == "")
                {
                    this.tbyy33.Text = "0";
                }
                if (this.tbyy32.Text == "")
                {
                    this.tbyy32.Text = "0";
                }
                if (this.tbyy31.Text == "")
                {
                    this.tbyy31.Text = "0";
                }
                if (this.tbbhgsl2.Text == "")
                {
                    this.tbbhgsl2.Text = "0";
                }
                var allnum3 = int.Parse(this.tbyy31.Text) + int.Parse(this.tbyy32.Text) + int.Parse(this.tbyy33.Text) + int.Parse(this.tbyy34.Text) + int.Parse(this.tbyy35.Text) + int.Parse(this.tbyy36.Text) + int.Parse(this.tbyy37.Text) + int.Parse(this.tbyy38.Text) + int.Parse(this.tbyy39sl.Text);
                var all2 = int.Parse(this.tbbhgsl2.Text) + int.Parse(tbxcsl4.Text);
                if (this.tbbhgsl2.Text != Convert.ToString(allnum3))
                {
                    MessageBox.Show("不合格总数错误", "提示");
                    return;
                }
                else if (Convert.ToString(all2) != this.tbsjsl4.Text)
                {
                    MessageBox.Show("数量与上接数量不符", "提示");
                    return;
                }
            //}
            //else if (yh.机构 == "清洗")
            //{
                if (this.tbyy40.Text == "")
                {
                    this.tbyy40.Text = "0";
                }
                if (this.tbyy41sl.Text == "")
                {
                    this.tbyy41sl.Text = "0";
                }
                if (this.tbbhgsl3.Text == "")
                {
                    this.tbbhgsl3.Text = "0";
                }
                var allnum4 = int.Parse(this.tbyy40.Text) + int.Parse(this.tbyy41sl.Text);
                var all3 = int.Parse(this.tbbhgsl3.Text) + int.Parse(this.tbxcsl5.Text);
                if (this.tbbhgsl3.Text != Convert.ToString(allnum4))
                {
                    MessageBox.Show("不合格总数错误", "提示");
                    return;
                }
                else if (Convert.ToString(all3) != this.tbsjsl5.Text)
                {
                    MessageBox.Show("数量与上接数量不符", "提示");
                    return;
                }
            //}
            //else if (yh.机构 == "包装")
            //{

                if (this.tbyy42.Text == "")
                {
                    this.tbyy42.Text = "0";
                }
                if (this.tbyy43sl.Text == "")
                {
                    this.tbyy43sl.Text = "0";
                }
                if (this.tbbhgsl4.Text == "")
                {
                    this.tbbhgsl4.Text = "0";
                }
                var allnum5 = int.Parse(this.tbyy42.Text) + int.Parse(this.tbyy43sl.Text);
                var all4 =int.Parse(this.tbbhgsl4.Text)+ int.Parse(this.tbxcsl6.Text);
                if (this.tbbhgsl4.Text != Convert.ToString(allnum5))
                {
                    MessageBox.Show("不合格总数错误", "提示");
                    return;
                }
                else if (Convert.ToString(all4) != this.tbsjsl6.Text)
                {
                    MessageBox.Show("数量与上接数量不符", "提示");
                    return;
                }
            //}

            #endregion


            #region
            //if (yh.机构 == "全部")
            //{
                var time = this.dtpxcTime.Text;
                Match m1 = Regex.Match(dtpxcTime.Text, reg);
                Match m2 = Regex.Match(dtp1.Text, reg);
                Match m3 = Regex.Match(dtptime2.Text, reg);
                Match m4 = Regex.Match(dtpfrtime1.Text, regs);
                Match m5 = Regex.Match(dtpqcTime1.Text, regs);
                Match m6 = Regex.Match(dtpxtime3.Text, reg);
                Match m7 = Regex.Match(dtpxctime3.Text, reg);
                Match m8 = Regex.Match(dtpxctime4.Text, reg);
                if (m1.Success == false)
                {
                    MessageBox.Show("备料时间格式输入错误.如[2015-5-5]", "提示");
                    return;
                }
                else if (m2.Success == false)
                {
                    MessageBox.Show("LD耦合焊接时间格式输入错误.如[2015-5-5]", "提示");
                    return;
                }
                else if (m3.Success == false)
                {
                    MessageBox.Show("PT耦合固化时间格式输入错误.如[2015-5-5]", "提示");
                    return;
                }
                else if (m4.Success == false)
                {
                    MessageBox.Show("温循前时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                    return;
                }
                else if (m5.Success == false)
                {
                    MessageBox.Show("温循后时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                    return;
                }
                else if (m6.Success == false)
                {
                    MessageBox.Show("测试时间格式输入错误.如[2015-5-5]", "提示");
                    return;
                }
                else if (m7.Success == false)
                {
                    MessageBox.Show("清洗时间格式输入错误.如[2015-5-5]", "提示");
                    return;
                }
                else if (m8.Success == false)
                {
                    MessageBox.Show("包装时间格式输入错误.如[2015-5-5]", "提示");
                    return;
                }
                else
                {
                    BeiLiaoBind(bhd);
                    LDHanJieBind(bhd);
                    PTGuHuaBind(bhd);
                    WenXunQianBind(bhd);
                    WenXunHouBind(bhd);
                    CeShiBind(bhd);
                    QingXiBind(bhd);
                    BaoZhuangBind(bhd);
                }

            //}
            //else if (yh.机构 == "备料")
            //{
            //    var time = this.dtpxcTime.Text;
            //    Match m = Regex.Match(dtpxcTime.Text, reg);
            //    if (m.Success == false)
            //    {
            //        MessageBox.Show("备料时间格式输入错误.如[2015-5-5]", "提示");
            //        return;
            //    }
            //    else
            //    {
            //        BeiLiaoBind(bhd);
            //    }
            //}

            #endregion
            bhd.lsh1 = this.tbLSH1.Text;
            bhd.lsh2 = this.tbLSH2.Text;
            bhd.lsh3 = this.tbLSH3.Text;

            bhd.case1 = this.tbCASE1.Text;
            bhd.case2 = this.tbCASE2.Text;
            bhd.case3 = this.tbCASE3.Text;

            bhd.ld1 = this.tbLDP1.Text;
            bhd.ld2 = this.tbLDP2.Text;
            bhd.ld3 = this.tbLDP3.Text;

            bhd.pd1 = this.tbPDP1.Text;
            bhd.pd2 = this.tbPDP2.Text;
            bhd.pd3 = this.tbPDP3.Text;

            bhd.ldj1 = this.tbLDN1.Text;
            bhd.ldj2 = this.tbLDN2.Text;
            bhd.ldj3 = this.tbLDN3.Text;
            if (this.tbJC1.Text == "")
            {
                this.tbJC1.Text = "0";
            }
            if (this.tbJC2.Text == "")
            {
                this.tbJC2.Text = "0";
            }
            if (this.tbJC3.Text == "")
            {
                this.tbJC3.Text = "0";
            }
            bhd.jc1 = Convert.ToDecimal(this.tbJC1.Text);
            bhd.jc2 = Convert.ToDecimal(this.tbJC2.Text);
            bhd.jc3 = Convert.ToDecimal(this.tbJC3.Text);

            bhd.oxl1 = this.tbAXL1.Text;
            bhd.oxl2 = this.tbAXL2.Text;
            bhd.oxl3 = this.tbAXL3.Text;

            bhd.ldxp_xinpianjj = this.tbjj.Text;
            bhd.ldxp_jianyanry = this.tbjyry.Text;
            bhd.ldxp_jianyansb = this.tbjysb.Text;
            bhd.备注 = this.rtbremark.Text;
            bhd.LD_xh = this.textBox34.Text;
            bhd.LD_name = this.textBox35.Text;
            bhd.LD_sjdh = this.textBox36.Text;
            bhd.PT_xh = this.textBox39.Text;
            bhd.PT_name = this.textBox38.Text;
            bhd.PT_sjdh = this.textBox37.Text;
            bhd.KT_xh = this.textBox42.Text;
            bhd.KT_name = this.textBox41.Text;
            bhd.KT_sjdh = this.textBox40.Text;
            bhd.NBP_xh0 = this.textBox45.Text;
            bhd.NBP_name0 = this.textBox44.Text;
            bhd.NBP_sjdh0 = this.textBox43.Text;
            bhd.NBP_xh45 = this.textBox51.Text;
            bhd.NBP_name45 = this.textBox50.Text;
            bhd.NBP_sjdh45 = this.textBox49.Text;
            bhd.JK_xh = this.textBox48.Text;
            bhd.JK_name = this.textBox47.Text;
            bhd.JK_sjdh = this.textBox46.Text;
            bool result2 = false;
            result2 = txbll.Add(bhd);
            if (result2 == true)
            {
                MessageBox.Show("添加数据成功", "提示");
                this.btnSend.Enabled = false;
                this.btnSend.BackColor = Color.LightGray;
                this.btnOk.Enabled = false;
                this.btnOk.BackColor = Color.LightGray;
            }
            else
            {
                MessageBox.Show("添加数据失败", "提示");
            }
        }

        #region 方法重构
        /// <summary>
        /// 包装
        /// </summary>
        /// <param name="bhd"></param>
        private void BaoZhuangBind(tsuhan_sg_tx bhd)
        {
            #region 包装
            bhd.BZ_sbbh1 = this.tb19.Text;
            bhd.BZ_sbbh2 = this.tb20.Text;
            bhd.BZ_sbbh3 = this.tb21.Text;
            bhd.BZ_sbbh4 = this.tb22.Text;
            if (this.tbsjsl6.Text == "")
            {
                this.tbsjsl6.Text = "0";
            } 
            bhd.BZ_sjsl = Convert.ToInt32(this.tbsjsl6.Text);
            if (this.tbxcsl6.Text == "")
            {
                this.tbxcsl6.Text = "0";
            }
            bhd.BZ_xcsl = Convert.ToInt32(this.tbxcsl6.Text);
            if (this.dtpxctime4.Text == "")
            {
                this.dtpxctime4.Text =DateTime.Now.ToString("yyyy-MM-dd");
            }
            bhd.BZ_xctime = Convert.ToDateTime(this.dtpxctime4.Text);
            bhd.BZ_czy1 = this.tbcz19.Text;
            bhd.BZ_czy2 = this.tbcz20.Text;
            bhd.BZ_czy3 = this.tbcz21.Text;
            bhd.BZ_czy4 = this.tbcz22.Text;
            bhd.BZ_czyname1 = this.tbname19.Text;
            bhd.BZ_czyname2 = this.tbname20.Text;
            bhd.BZ_czyname3 = this.tbname21.Text;
            bhd.BZ_czyname4 = this.tbname22.Text;
            bhd.BZ_lry = this.tblr7.Text;
            bhd.BZ_lryname = this.tblrname7.Text;
            if (this.tbyy42.Text == "")
            {
                this.tbyy42.Text = "0";
            }
            bhd.bzng1 = Convert.ToInt32(this.tbyy42.Text);
            bhd.bzngoth = this.rtbyy43.Text;
            if (this.tbyy43sl.Text == "")
            {
                this.tbyy43sl.Text = "0";
            }
            bhd.bzngothnum = Convert.ToInt32(this.tbyy43sl.Text);
            if (this.tbbhgsl4.Text == "")
            {
                this.tbbhgsl4.Text = "0";
            }
            bhd.BZ_bhgallsl = Convert.ToInt32(this.tbbhgsl4.Text);
           
            #endregion
        }

        /// <summary>
        /// 清洗
        /// </summary>
        /// <param name="bhd"></param>
        private void QingXiBind(tsuhan_sg_tx bhd)
        {
            #region 清洗
            bhd.QX_sbbh1 = this.tb15.Text;
            bhd.QX_sbbh2 = this.tb16.Text;
            bhd.QX_sbbh3 = this.tb17.Text;
            bhd.QX_sbbh4 = this.tb18.Text;
            if (this.tbsjsl5.Text == "")
            {
                this.tbsjsl5.Text = "0";
            }
            bhd.QX_sjsl = Convert.ToInt32(this.tbsjsl5.Text);
            if (this.tbxcsl5.Text == "")
            {
                this.tbxcsl5.Text = "0";
            }
            bhd.QX_xcsl = Convert.ToInt32(this.tbxcsl5.Text);
            if (this.dtpxctime3.Text == "")
            {
                this.dtpxctime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            bhd.QX_xctime = Convert.ToDateTime(this.dtpxctime3.Text);
            bhd.QX_czy1 = this.tbcz15.Text;
            bhd.QX_czy2 = this.tbcz16.Text;
            bhd.QX_czy3 = this.tbcz17.Text;
            bhd.QX_czy4 = this.tbcz18.Text;
            bhd.QX_czyname1 = this.tbname15.Text;
            bhd.QX_czyname2 = this.tbname16.Text;
            bhd.QX_czyname3 = this.tbname17.Text;
            bhd.QX_czyname4 = this.tbname18.Text;
            bhd.QX_lry = this.tblr6.Text;
            bhd.QX_lryname = this.tblrname6.Text;
            if (this.tbyy40.Text == "")
            {
                this.tbyy40.Text = "0";
            }
            bhd.qxng1 = Convert.ToInt32(this.tbyy40.Text);
            bhd.qxngoth = this.rtbyy41.Text;
            if (this.tbyy41sl.Text == "")
            {
                this.tbyy41sl.Text = "0";
            }
            bhd.qxngothnum = Convert.ToInt32(this.tbyy41sl.Text);
            if (this.tbbhgsl3.Text == "")
            {
                this.tbbhgsl3.Text = "0";
            }
            bhd.QX_bhgallsl = Convert.ToInt32(this.tbbhgsl3.Text);
            
            #endregion
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="bhd"></param>
        private void CeShiBind(tsuhan_sg_tx bhd)
        {
            #region 测试
            bhd.CS_sbbh1 = this.tb11.Text;
            bhd.CS_sbbh2 = this.tb12.Text;
            bhd.CS_sbbh3 = this.tb13.Text;
            bhd.CS_sbbh4 = this.tb14.Text;
            if (this.tbsjsl4.Text == "")
            {
                this.tbsjsl4.Text = "0";
            } 
            bhd.CS_sjsl = Convert.ToInt32(this.tbsjsl4.Text);
            if (this.tbxcsl4.Text == "")
            {
                this.tbxcsl4.Text = "0";
            }
            bhd.CS_xcsl = Convert.ToInt32(this.tbxcsl4.Text);
            if (this.dtpxtime3.Text == "")
            {
                this.dtpxtime3.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            bhd.CS_xctime = Convert.ToDateTime(this.dtpxtime3.Text);
            bhd.CS_czy1 = this.tbcz11.Text;
            bhd.CS_czy2 = this.tbcz12.Text;
            bhd.CS_czy3 = this.tbcz13.Text;
            bhd.CS_czy4 = this.tbcz14.Text;
            bhd.CS_czyname1 = this.tbname11.Text;
            bhd.CS_czyname2 = this.tbname12.Text;
            bhd.CS_czyname3 = this.tbname13.Text;
            bhd.CS_czyname4 = this.tbname14.Text;
            bhd.CS_lry = this.tblr5.Text;
            bhd.CS_lryname = this.tblrname5.Text;
            if (this.tbyy31.Text == "")
            {
                this.tbyy31.Text = "0";
            }
            bhd.csng1 = Convert.ToInt32(this.tbyy31.Text);
            if (this.tbyy32.Text == "")
            {
                this.tbyy32.Text = "0";
            }
            bhd.csng2 = Convert.ToInt32(this.tbyy32.Text);
            if (this.tbyy33.Text == "")
            {
                this.tbyy33.Text = "0";
            }
            bhd.csng3 = Convert.ToInt32(this.tbyy33.Text);
            if (this.tbyy34.Text == "")
            {
                this.tbyy34.Text = "0";
            }
            bhd.csng4 = Convert.ToInt32(this.tbyy34.Text);
            if (this.tbyy35.Text == "")
            {
                this.tbyy35.Text = "0";
            }
            bhd.csng5 = Convert.ToInt32(this.tbyy35.Text);
            if (this.tbyy36.Text == "")
            {
                this.tbyy36.Text = "0";
            }
            bhd.csng6 = Convert.ToInt32(this.tbyy36.Text);
            if (this.tbyy37.Text == "")
            {
                this.tbyy37.Text = "0";
            }
            bhd.csng7 = Convert.ToInt32(this.tbyy37.Text);
            if (this.tbyy38.Text == "")
            {
                this.tbyy38.Text = "0";
            }
            bhd.csng8 = Convert.ToInt32(this.tbyy38.Text);
            bhd.csngoth = this.rtbyy39.Text;
            if (this.tbyy39sl.Text == "")
            {
                this.tbyy39sl.Text = "0";
            }
            bhd.csngothnum = Convert.ToInt32(this.tbyy39sl.Text);
            if (this.tbbhgsl2.Text == "")
            {
                this.tbbhgsl2.Text = "0";
            }
            bhd.CS_bhgallsl = Convert.ToInt32(this.tbbhgsl2.Text);
            
            #endregion
        }

        /// <summary>
        /// 温循后
        /// </summary>
        /// <param name="bhd"></param>
        private void WenXunHouBind(tsuhan_sg_tx bhd)
        {
            #region 温循后
            bhd.WXH_sbbh = this.tb10.Text;
            if (this.tbqcsl1.Text == "")
            {
                this.tbqcsl1.Text = "0";
            }
            bhd.WXH_qcsl = Convert.ToInt32(this.tbqcsl1.Text);
            if (this.tbxcsl3.Text == "")
            {
                this.tbxcsl3.Text = "0";
            }
            bhd.WXH_xcsl = Convert.ToInt32(this.tbxcsl3.Text);
            if (this.dtpqcTime1.Text == "")
            {
                this.dtpqcTime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
            bhd.WXH_xctime = Convert.ToDateTime(this.dtpqcTime1.Text);
            bhd.WXH_wxsc = this.tbwxsc.Text;
            bhd.WXH_czy = this.tbcz10.Text;
            bhd.WXH_czyname = this.tbname10.Text;
            bhd.WX_Hlry = this.tblr4.Text;
            bhd.WXH_lryname = this.tblrname4.Text;
            bhd.WXH_remark = this.rtbremark3.Text;
            #endregion
        }

        /// <summary>
        /// 温循前
        /// </summary>
        /// <param name="bhd"></param>
        private void WenXunQianBind(tsuhan_sg_tx bhd)
        {
            #region 温循前
            bhd.WXQ_sbbh = this.tb9.Text;
            if (this.tbsjsl3.Text == "")
            {
                this.tbsjsl3.Text = "0";
            }
            bhd.WXQ_sjsl = Convert.ToInt32(this.tbsjsl3.Text);
            if (this.tbfrsl1.Text == "")
            {
                this.tbfrsl1.Text = "0";
            }
            bhd.WXQ_frsl = Convert.ToInt32(this.tbfrsl1.Text);
            if (this.dtpfrtime1.Text == "" || this.dtpfrtime1.Text == string.Empty)
            {
                this.dtpfrtime1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
            bhd.WXQ_xctime = Convert.ToDateTime(this.dtpfrtime1.Text);
            bhd.WXQ_czy = this.tbcz9.Text;
            bhd.WXQ_czyname = this.tbname9.Text;
            bhd.WXQ_lry = this.tblr3.Text;
            bhd.WXQ_lryname = this.tblrname3.Text;
            bhd.WXQ_remark = this.rtbremark2.Text;
            #endregion
        }

        /// <summary>
        /// PT耦合固化
        /// </summary>
        /// <param name="bhd"></param>
        private void PTGuHuaBind(tsuhan_sg_tx bhd)
        {
            #region PT耦合固化
            bhd.PT_sbbh1 = this.tb5.Text;
            bhd.PT_sbbh2 = this.tb6.Text;
            bhd.PT_sbbh3 = this.tb7.Text;
            bhd.PT_sbbh4 = this.tb8.Text;
            if (this.tbsjsl2.Text == "")
            {
                this.tbsjsl2.Text = "0";
            }
            bhd.PT_sjsl = Convert.ToInt32(this.tbsjsl2.Text);
            if (this.tbxcsl2.Text == "")
            {
                this.tbxcsl2.Text = "0";
            }
            bhd.PT_xcsl = Convert.ToInt32(this.tbxcsl2.Text);
            if (this.dtptime2.Text == "")
            {
                this.dtptime2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            bhd.PT_xctime = Convert.ToDateTime(this.dtptime2.Text);
            bhd.PT_czy1 = this.tbcz5.Text;
            bhd.PT_czy2 = this.tbcz6.Text;
            bhd.PT_czy3 = this.tbcz7.Text;
            bhd.PT_czy4 = this.tbcz8.Text;
            bhd.PT_czyname1 = this.tbname5.Text;
            bhd.PT_czyname2 = this.tbname6.Text;
            bhd.PT_czyname3 = this.tbname7.Text;
            bhd.PT_czyname4 = this.tbname8.Text;
            bhd.PT_lry = this.tblr2.Text;
            bhd.PT_lryname = this.tblrname2.Text;
            if (this.tbyy21.Text == "")
            {
                this.tbyy21.Text = "0";
            }
            bhd.ptng1 = Convert.ToInt32(this.tbyy21.Text);
            if (this.tbyy22.Text == "")
            {
                this.tbyy22.Text = "0";
            }
            bhd.ptng2 = Convert.ToInt32(this.tbyy22.Text);
            if (this.tbyy23.Text == "")
            {
                this.tbyy23.Text = "0";
            }
            bhd.ptng3 = Convert.ToInt32(this.tbyy23.Text);
            if (this.tbyy24.Text == "")
            {
                this.tbyy24.Text = "0";
            }
            bhd.ptng4 = Convert.ToInt32(this.tbyy24.Text);
            if (this.tbyy25.Text == "")
            {
                this.tbyy25.Text = "0";
            }
            bhd.ptng5 = Convert.ToInt32(this.tbyy25.Text);
            if (this.tbyy26.Text == "")
            {
                this.tbyy26.Text = "0";
            }
            bhd.ptng6 = Convert.ToInt32(this.tbyy26.Text);
            if (this.tbyy27.Text == "")
            {
                this.tbyy27.Text = "0";
            }
            bhd.ptng7 = Convert.ToInt32(this.tbyy27.Text);
            if (this.tbyy28.Text == "")
            {
                this.tbyy28.Text = "0";
            }
            bhd.ptng8 = Convert.ToInt32(this.tbyy28.Text);
            if (this.tbyy29.Text == "")
            {
                this.tbyy29.Text = "0";
            }
            bhd.ptng9 = Convert.ToInt32(this.tbyy29.Text);
            bhd.ptngoth = this.tbyy30.Text;
            if (this.tbyy30sl.Text == "")
            {
                this.tbyy30sl.Text = "0";
            }
            bhd.ptngothnum = Convert.ToInt32(this.tbyy30sl.Text);
            if (this.textBox100.Text == "")
            {
                this.textBox100.Text = "0";
            }
            bhd.PT_bhgallsl = Convert.ToInt32(this.textBox100.Text);
            
            #endregion
        }

        /// <summary>
        /// LD耦合焊接
        /// </summary>
        /// <param name="bhd"></param>
        private void LDHanJieBind(tsuhan_sg_tx bhd)
        {
            #region LD耦合焊接
            bhd.LD_sbbh1 = this.tb1.Text;
            bhd.LD_sbbh2 = this.tb2.Text;
            bhd.LD_sbbh3 = this.tb3.Text;
            bhd.LD_sbbh4 = this.tb4.Text;
            if (this.tbsjsl1.Text == "")
            {
                this.tbsjsl1.Text = "0";
            }
            
            bhd.LD_sjsl = Convert.ToInt32(this.tbsjsl1.Text);
            if (this.tbxcsl1.Text == "")
            {
                this.tbxcsl1.Text = "0";
            }
            bhd.LD_xcsl = Convert.ToInt32(this.tbxcsl1.Text);
            if (this.dtp1.Text == "" || this.dtp1.Text == string.Empty)
            {
                this.dtp1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            bhd.LD_xctime = Convert.ToDateTime(this.dtp1.Text);
            bhd.LD_czy1 = this.tbcz1.Text;
            bhd.LD_czy2 = this.tbcz2.Text;
            bhd.LD_czy3 = this.tbcz3.Text;
            bhd.LD_czy4 = this.tbcz4.Text;
            bhd.LD_czyname1 = this.tbname1.Text;
            bhd.LD_czyname2 = this.tbname2.Text;
            bhd.LD_czyname3 = this.tbname3.Text;
            bhd.LD_czyname4 = this.tbname4.Text;
            bhd.LD_lry = this.tblr1.Text;
            bhd.LD_lryname = this.tblrname1.Text;
            if (this.tbyy11.Text == "")
            {
                this.tbyy11.Text = "0";
            }
            bhd.ldng1 = Convert.ToInt32(this.tbyy11.Text);
            if (this.tbyy12.Text == "")
            {
                this.tbyy12.Text = "0";
            }
            bhd.ldng2 = Convert.ToInt32(this.tbyy12.Text);
            if (this.tbyy13.Text == "")
            {
                this.tbyy13.Text = "0";
            }
            bhd.ldng3 = Convert.ToInt32(this.tbyy13.Text);
            if (this.tbyy14.Text == "")
            {
                this.tbyy14.Text = "0";
            }
            bhd.ldng4 = Convert.ToInt32(this.tbyy14.Text);
            if (this.tbyy15.Text == "")
            {
                this.tbyy15.Text = "0";
            }
            bhd.ldng5 = Convert.ToInt32(this.tbyy15.Text);
            if (this.tbyy16.Text == "")
            {
                this.tbyy16.Text = "0";
            }
            bhd.ldng6 = Convert.ToInt32(this.tbyy16.Text);
            if (this.tbyy17.Text == "")
            {
                this.tbyy17.Text = "0";
            }
            bhd.ldng7 = Convert.ToInt32(this.tbyy17.Text);
            if (this.tbyy18.Text == "")
            {
                this.tbyy18.Text = "0";
            }
            bhd.ldng8 = Convert.ToInt32(this.tbyy18.Text);
            if (this.tbyy19.Text == "")
            {
                this.tbyy19.Text = "0";
            }
            bhd.ldng9 = Convert.ToInt32(this.tbyy19.Text);
            bhd.ldngoth = this.tbyy20.Text;
            if (this.tbyy20sl.Text == "")
            {
                this.tbyy20sl.Text = "0";
            }
            bhd.ldngothnum = Convert.ToInt32(this.tbyy20sl.Text);
            if (this.tbbhksl1.Text=="")
            {
                this.tbbhksl1.Text = "0";
            }
            bhd.LD_bhgallsl = Convert.ToInt32(this.tbbhksl1.Text);
            if (this.tbjzsl1.Text == "")
            {
                this.tbjzsl1.Text = "0";
            }
            bhd.LD_jzsl = Convert.ToInt32(this.tbjzsl1.Text);
            #endregion
        }

        /// <summary>
        /// 备料
        /// </summary>
        /// <param name="bhd"></param>
        private void BeiLiaoBind(tsuhan_sg_tx bhd)
        {
            #region 备料
            bhd.bl_sbbh1 = this.tbsbbh1.Text;
            bhd.bl_sbbh2 = this.tbsbbh2.Text;
            bhd.bl_sbbh3 = this.tbsbbh3.Text;
            bhd.bl_sbbh4 = this.tbsbbh4.Text;
            if (this.tbxcsl.Text=="")
            {
                this.tbxcsl.Text = "0";
            }
            bhd.bl_xcsl = Convert.ToInt32(this.tbxcsl.Text);
            if (this.tbbhgsl.Text == "")
            {
                this.tbbhgsl.Text = "0";
            }
            bhd.bl_bhgallsl = Convert.ToInt32(this.tbbhgsl.Text);
            if (this.dtpxcTime.Text == "" || this.dtpxcTime.Text == string.Empty)
            {
                this.dtpxcTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            bhd.bl_xctime = Convert.ToDateTime(this.dtpxcTime.Text);
            bhd.bl_czy1 = this.tbczy1.Text;
            bhd.bl_czy2 = this.tbczy2.Text;
            bhd.bl_czy3 = this.tbczy3.Text;
            //bhd.bl_czy4 = this.tbczy4.Text;
            //var yh1 = yhbll.GetModel(this.tbczy1.Text);
            //var yh2 = yhbll.GetModel(this.tbczy2.Text);
            //var yh3 = yhbll.GetModel(this.tbczy3.Text);
            //var yh4 = yhbll.GetModel(this.tbczy4.Text);
            //this.tbczName1.Text = yh1.姓名;
            //this.tbczName2.Text = yh2.姓名;
            //this.tbczName3.Text = yh3.姓名;
            //this.tbczName4.Text = yh4.姓名;
            bhd.bl_czyname1 = this.tbczName1.Text;
            bhd.bl_czyname2 = this.tbczName2.Text;
            bhd.bl_czyname3 = this.tbczName3.Text;
            bhd.bl_czyname4 = this.tbczName4.Text;
            bhd.bl_lry = this.tblry.Text;
            bhd.bl_lryname = this.tblrName.Text;
            if (this.tbyy1.Text=="")
            {
                this.tbyy1.Text = "0";
            }
            bhd.blng1 = Convert.ToInt32(this.tbyy1.Text);
            if (this.tbyy2.Text == "")
            {
                this.tbyy2.Text = "0";
            }
            bhd.blng2 = Convert.ToInt32(this.tbyy2.Text);
            if (this.tbyy3.Text == "")
            {
                this.tbyy3.Text = "0";
            }
            bhd.blng3 = Convert.ToInt32(this.tbyy3.Text);
            if (this.tbyy4.Text == "")
            {
                this.tbyy4.Text = "0";
            }
            bhd.blng4 = Convert.ToInt32(this.tbyy4.Text);
            if (this.tbyy5.Text == "")
            {
                this.tbyy5.Text = "0";
            }
            bhd.blng5 = Convert.ToInt32(this.tbyy5.Text);
            if (this.tbyy6.Text == "")
            {
                this.tbyy6.Text = "0";
            }
            bhd.blng6 = Convert.ToInt32(this.tbyy6.Text);
            if (this.tbyy7.Text == "")
            {
                this.tbyy7.Text = "0";
            }
            bhd.blng7 = Convert.ToInt32(this.tbyy7.Text);
            if (this.tbyy8.Text == "")
            {
                this.tbyy8.Text = "0";
            }
            bhd.blng8 = Convert.ToInt32(this.tbyy8.Text);
            if (this.tbyy9.Text == "")
            {
                this.tbyy9.Text = "0";
            }
            bhd.blng9 = Convert.ToInt32(this.tbyy9.Text);
            bhd.blngoth = this.tbyy10.Text;
            if (this.tbyy10Sl.Text == "")
            {
                this.tbyy10Sl.Text = "0";
            }
            bhd.blngothnum = Convert.ToInt32(this.tbyy10Sl.Text);

           
            #endregion
        }
        #endregion

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.tbSGDXH.Text == "")
            {
                MessageBox.Show("随工单号不能为空", "提示");
            }
            else
            {
                DialogResult dr = MessageBox.Show("确定要添加吗？？？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    btnSend.Enabled = true;
                    btnSend.BackColor = Color.Teal;
                }
                else
                {
                    btnSend.Enabled = false;
                    btnSend.BackColor = Color.LightGray;
                }
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //时间正则表达式
            string reg = @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$";
            string regs =@"^(((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d)$";
            var name =Convert.ToInt32(gh);
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);
            var sgdh1 = this.tbSGDXH.Text + this.tbDXH1.Text;
            var str1 = sgdh1.Substring(sgdh1.Length - 1, 1);
            #region 判断不合格数量是否正确
            


                //if (yh.机构 == "全部")
                //{
                    #region 备料
                    if (this.tbyy10Sl.Text == "")
                    {
                        this.tbyy10Sl.Text = "0";
                    }
                    if (this.tbyy9.Text == "")
                    {
                        this.tbyy9.Text = "0";
                    }
                    if (this.tbyy8.Text == "")
                    {
                        this.tbyy8.Text = "0";
                    }
                    if (this.tbyy7.Text == "")
                    {
                        this.tbyy7.Text = "0";
                    }
                    if (this.tbyy6.Text == "")
                    {
                        this.tbyy6.Text = "0";
                    }
                    if (this.tbyy5.Text == "")
                    {
                        this.tbyy5.Text = "0";
                    }
                    if (this.tbyy4.Text == "")
                    {
                        this.tbyy4.Text = "0";
                    }
                    if (this.tbyy3.Text == "")
                    {
                        this.tbyy3.Text = "0";
                    }
                    if (this.tbyy2.Text == "")
                    {
                        this.tbyy2.Text = "0";
                    }
                    if (this.tbyy1.Text == "")
                    {
                        this.tbyy1.Text = "0";
                    }
                    if (this.tbbhgsl.Text == "")
                    {
                        this.tbbhgsl.Text = "0";
                    }
                    var allnum = int.Parse(this.tbyy1.Text) + int.Parse(this.tbyy2.Text) + int.Parse(this.tbyy3.Text) + int.Parse(this.tbyy4.Text) + int.Parse(this.tbyy5.Text) + int.Parse(this.tbyy6.Text) + int.Parse(this.tbyy7.Text) + int.Parse(this.tbyy8.Text) + int.Parse(this.tbyy9.Text) + int.Parse(this.tbyy10Sl.Text);
                   
                    if (this.tbbhgsl.Text != Convert.ToString(allnum))
                    {
                        MessageBox.Show("备料不合格总数错误", "提示");
                        return;
                    }
                    #endregion
                    #region LD耦合焊接
                    if (this.tbyy20sl.Text == "")
                    {
                        this.tbyy20sl.Text = "0";
                    }
                    if (this.tbyy19.Text == "")
                    {
                        this.tbyy19.Text = "0";
                    }
                    if (this.tbyy18.Text == "")
                    {
                        this.tbyy18.Text = "0";
                    }
                    if (this.tbyy17.Text == "")
                    {
                        this.tbyy17.Text = "0";
                    }
                    if (this.tbyy16.Text == "")
                    {
                        this.tbyy16.Text = "0";
                    }
                    if (this.tbyy15.Text == "")
                    {
                        this.tbyy15.Text = "0";
                    }
                    if (this.tbyy14.Text == "")
                    {
                        this.tbyy14.Text = "0";
                    }
                    if (this.tbyy13.Text == "")
                    {
                        this.tbyy13.Text = "0";
                    }
                    if (this.tbyy12.Text == "")
                    {
                        this.tbyy12.Text = "0";
                    }
                    if (this.tbyy11.Text == "")
                    {
                        this.tbyy11.Text = "0";
                    }
                    if (this.tbjzsl1.Text == "")
                    {
                        this.tbjzsl1.Text = "0";
                    }
                    if (this.tbbhksl1.Text == "")
                    {
                        this.tbbhksl1.Text = "0";
                    }

                    var allnum1 = int.Parse(this.tbyy11.Text) + int.Parse(this.tbyy12.Text) + int.Parse(this.tbyy13.Text) + int.Parse(this.tbyy14.Text) + int.Parse(this.tbyy15.Text) + int.Parse(this.tbyy16.Text) + int.Parse(this.tbyy17.Text) + int.Parse(this.tbyy18.Text) + int.Parse(this.tbyy19.Text) + int.Parse(this.tbyy20sl.Text);
                    var num = int.Parse(this.tbbhksl1.Text) + int.Parse(this.tbjzsl1.Text);
                    var all = num + int.Parse(this.tbxcsl1.Text);
                    if (Convert.ToString(num) != Convert.ToString(allnum1))
                    {
                        MessageBox.Show("LD耦合焊接不合格总数错误", "提示");
                        return;
                    }
                    else if (Convert.ToString(all) != this.tbsjsl1.Text)
                    {
                        MessageBox.Show("下传数量与上接数量不符", "提示");
                        return;
                    }
                    #endregion
                    #region PT耦合固化
                    if (this.tbyy30sl.Text == "")
                    {
                        this.tbyy30sl.Text = "0";
                    }
                    if (this.tbyy29.Text == "")
                    {
                        this.tbyy29.Text = "0";
                    }
                    if (this.tbyy28.Text == "")
                    {
                        this.tbyy28.Text = "0";
                    }
                    if (this.tbyy27.Text == "")
                    {
                        this.tbyy27.Text = "0";
                    }
                    if (this.tbyy26.Text == "")
                    {
                        this.tbyy26.Text = "0";
                    }
                    if (this.tbyy25.Text == "")
                    {
                        this.tbyy25.Text = "0";
                    }
                    if (this.tbyy24.Text == "")
                    {
                        this.tbyy24.Text = "0";
                    }
                    if (this.tbyy23.Text == "")
                    {
                        this.tbyy23.Text = "0";
                    }
                    if (this.tbyy22.Text == "")
                    {
                        this.tbyy22.Text = "0";
                    }
                    if (this.tbyy21.Text == "")
                    {
                        this.tbyy21.Text = "0";
                    }
                    if (this.textBox100.Text == "")
                    {
                        this.textBox100.Text = "0";
                    }
                    var allnum2 = int.Parse(this.tbyy21.Text) + int.Parse(this.tbyy22.Text) + int.Parse(this.tbyy23.Text) + int.Parse(this.tbyy24.Text) + int.Parse(this.tbyy25.Text) + int.Parse(this.tbyy26.Text) + int.Parse(this.tbyy27.Text) + int.Parse(this.tbyy28.Text) + int.Parse(this.tbyy29.Text) + int.Parse(this.tbyy30sl.Text);
                    var all2 = allnum2 + int.Parse(this.tbxcsl2.Text);
                    if (this.textBox100.Text != Convert.ToString(allnum2))
                    {
                        MessageBox.Show("PT耦合固化不合格总数错误", "提示");
                        return;
                    }
                    else if (Convert.ToString(all2) != this.tbsjsl2.Text)
                    {
                        MessageBox.Show("数量与上接数量不符", "提示");
                        return;
                    }
                    #endregion
                    #region 测试
                    if (this.tbyy39sl.Text == "")
                    {
                        this.tbyy39sl.Text = "0";
                    }
                    if (this.tbyy38.Text == "")
                    {
                        this.tbyy38.Text = "0";
                    }
                    if (this.tbyy37.Text == "")
                    {
                        this.tbyy37.Text = "0";
                    }
                    if (this.tbyy36.Text == "")
                    {
                        this.tbyy36.Text = "0";
                    }
                    if (this.tbyy35.Text == "")
                    {
                        this.tbyy35.Text = "0";
                    }
                    if (this.tbyy34.Text == "")
                    {
                        this.tbyy34.Text = "0";
                    }
                    if (this.tbyy33.Text == "")
                    {
                        this.tbyy33.Text = "0";
                    }
                    if (this.tbyy32.Text == "")
                    {
                        this.tbyy32.Text = "0";
                    }
                    if (this.tbyy31.Text == "")
                    {
                        this.tbyy31.Text = "0";
                    }
                    if (this.tbbhgsl2.Text == "")
                    {
                        this.tbbhgsl2.Text = "0";
                    }
                    var allnum3 = int.Parse(this.tbyy31.Text) + int.Parse(this.tbyy32.Text) + int.Parse(this.tbyy33.Text) + int.Parse(this.tbyy34.Text) + int.Parse(this.tbyy35.Text) + int.Parse(this.tbyy36.Text) + int.Parse(this.tbyy37.Text) + int.Parse(this.tbyy38.Text) + int.Parse(this.tbyy39sl.Text);
                    var all3 = allnum3 + int.Parse(tbxcsl4.Text);
                    if (this.tbbhgsl2.Text != Convert.ToString(allnum3))
                    {
                        MessageBox.Show("测试不合格总数错误", "提示");
                        return;
                    }
                    else if (Convert.ToString(all3) != this.tbsjsl4.Text)
                    {
                        MessageBox.Show("数量与上接数量不符", "提示");
                        return;
                    }
                    #endregion
                    #region 清洗
                    if (this.tbyy40.Text == "")
                    {
                        this.tbyy40.Text = "0";
                    }
                    if (this.tbyy41sl.Text == "")
                    {
                        this.tbyy41sl.Text = "0";
                    }
                    if (this.tbbhgsl3.Text == "")
                    {
                        this.tbbhgsl3.Text = "0";
                    }
                    var allnum4 = int.Parse(this.tbyy40.Text) + int.Parse(this.tbyy41sl.Text);
                    var all4 = allnum4 + int.Parse(this.tbxcsl5.Text);
                    if (this.tbbhgsl3.Text != Convert.ToString(allnum4))
                    {
                        MessageBox.Show("清洗不合格总数错误", "提示");
                        return;
                    }
                    else if (Convert.ToString(all4) != this.tbsjsl5.Text)
                    {
                        MessageBox.Show("数量与上接数量不符", "提示");
                        return;
                    }
                    #endregion
                    #region 包装
                    if (this.tbyy42.Text == "")
                    {
                        this.tbyy42.Text = "0";
                    }
                    if (this.tbyy43sl.Text == "")
                    {
                        this.tbyy43sl.Text = "0";
                    }
                    if (this.tbbhgsl4.Text == "")
                    {
                        this.tbbhgsl4.Text = "0";
                    }
                    var allnum5 = int.Parse(this.tbyy42.Text) + int.Parse(this.tbyy43sl.Text);
                    var all5 = allnum5 + int.Parse(this.tbxcsl6.Text);
                    if (this.tbbhgsl4.Text != Convert.ToString(allnum5))
                    {
                        MessageBox.Show("包装不合格总数错误", "提示");
                        return;
                    }
                    else if (Convert.ToString(all5) != this.tbsjsl6.Text)
                    {
                        MessageBox.Show("数量与上接数量不符", "提示");
                        return;
                    }
                    #endregion
                #region 
                //    }
            //    else if (yh.机构 == "备料")
            //    {
            //        #region
            //        //if (this.tbyy10Sl.Text == "")
            //        //{
            //        //    this.tbyy10Sl.Text = "0";
            //        //}
            //        //if (this.tbyy9.Text == "")
            //        //{
            //        //    this.tbyy9.Text = "0";
            //        //}
            //        //if (this.tbyy8.Text == "")
            //        //{
            //        //    this.tbyy8.Text = "0";
            //        //}
            //        //if (this.tbyy7.Text == "")
            //        //{
            //        //    this.tbyy7.Text = "0";
            //        //}
            //        //if (this.tbyy6.Text == "")
            //        //{
            //        //    this.tbyy6.Text = "0";
            //        //}
            //        //if (this.tbyy5.Text == "")
            //        //{
            //        //    this.tbyy5.Text = "0";
            //        //}
            //        //if (this.tbyy4.Text == "")
            //        //{
            //        //    this.tbyy4.Text = "0";
            //        //}
            //        //if (this.tbyy3.Text == "")
            //        //{
            //        //    this.tbyy3.Text = "0";
            //        //}
            //        //if (this.tbyy2.Text == "")
            //        //{
            //        //    this.tbyy2.Text = "0";
            //        //}
            //        //if (this.tbyy1.Text == "")
            //        //{
            //        //    this.tbyy1.Text = "0";
            //        //}
            //        //if (this.tbbhgsl.Text == "")
            //        //{
            //        //    this.tbbhgsl.Text = "0";
            //        //}
            //        //var allnum = int.Parse(this.tbyy1.Text) + int.Parse(this.tbyy2.Text) + int.Parse(this.tbyy3.Text) + int.Parse(this.tbyy4.Text) + int.Parse(this.tbyy5.Text) + int.Parse(this.tbyy6.Text) + int.Parse(this.tbyy7.Text) + int.Parse(this.tbyy8.Text) + int.Parse(this.tbyy9.Text) + int.Parse(this.tbyy10Sl.Text);
            //        //if (this.tbbhgsl.Text != Convert.ToString(allnum))
            //        //{
            //        //    MessageBox.Show("不合格总数错误", "提示");
            //        //    return;
            //        //}
            //        #endregion
            //    }
            //    else if (yh.机构 == "LD耦合焊接")
            //    {
            //        #region
            //        if (this.tbyy20sl.Text == "")
            //        {
            //            this.tbyy20sl.Text = "0";
            //        }
            //        if (this.tbyy19.Text == "")
            //        {
            //            this.tbyy19.Text = "0";
            //        }
            //        if (this.tbyy18.Text == "")
            //        {
            //            this.tbyy18.Text = "0";
            //        }
            //        if (this.tbyy17.Text == "")
            //        {
            //            this.tbyy17.Text = "0";
            //        }
            //        if (this.tbyy16.Text == "")
            //        {
            //            this.tbyy16.Text = "0";
            //        }
            //        if (this.tbyy15.Text == "")
            //        {
            //            this.tbyy15.Text = "0";
            //        }
            //        if (this.tbyy14.Text == "")
            //        {
            //            this.tbyy14.Text = "0";
            //        }
            //        if (this.tbyy13.Text == "")
            //        {
            //            this.tbyy13.Text = "0";
            //        }
            //        if (this.tbyy12.Text == "")
            //        {
            //            this.tbyy12.Text = "0";
            //        }
            //        if (this.tbyy11.Text == "")
            //        {
            //            this.tbyy11.Text = "0";
            //        }
            //        if (this.tbjzsl1.Text == "")
            //        {
            //            this.tbjzsl1.Text = "0";
            //        }
            //        if (this.tbbhksl1.Text == "")
            //        {
            //            this.tbbhksl1.Text = "0";
            //        }

            //        var allnum1 = int.Parse(this.tbyy11.Text) + int.Parse(this.tbyy12.Text) + int.Parse(this.tbyy13.Text) + int.Parse(this.tbyy14.Text) + int.Parse(this.tbyy15.Text) + int.Parse(this.tbyy16.Text) + int.Parse(this.tbyy17.Text) + int.Parse(this.tbyy18.Text) + int.Parse(this.tbyy19.Text) + int.Parse(this.tbyy20sl.Text);
            //        var num = int.Parse(this.tbbhksl1.Text) + int.Parse(this.tbjzsl1.Text);
            //        if (this.tbxcsl1.Text == "")
            //        {
            //            this.tbxcsl1.Text = "0";
            //        }
            //        var all = num + int.Parse(this.tbxcsl1.Text);
            //        if (Convert.ToString(num) != Convert.ToString(allnum1))
            //        {
            //            MessageBox.Show("不合格总数错误", "提示");
            //            return;
            //        }
            //        else if (Convert.ToString(all) != this.tbsjsl1.Text)
            //        {
            //            MessageBox.Show("数量与上接数量不符", "提示");
            //            return;
            //        }
            //        #endregion
            //    }
            //    else if (yh.机构 == "PT耦合固化")
            //    {
            //        #region PT耦合固化
            //        if (this.tbyy30sl.Text == "")
            //        {
            //            this.tbyy30sl.Text = "0";
            //        }
            //        if (this.tbyy29.Text == "")
            //        {
            //            this.tbyy29.Text = "0";
            //        }
            //        if (this.tbyy28.Text == "")
            //        {
            //            this.tbyy28.Text = "0";
            //        }
            //        if (this.tbyy27.Text == "")
            //        {
            //            this.tbyy27.Text = "0";
            //        }
            //        if (this.tbyy26.Text == "")
            //        {
            //            this.tbyy26.Text = "0";
            //        }
            //        if (this.tbyy25.Text == "")
            //        {
            //            this.tbyy25.Text = "0";
            //        }
            //        if (this.tbyy24.Text == "")
            //        {
            //            this.tbyy24.Text = "0";
            //        }
            //        if (this.tbyy23.Text == "")
            //        {
            //            this.tbyy23.Text = "0";
            //        }
            //        if (this.tbyy22.Text == "")
            //        {
            //            this.tbyy22.Text = "0";
            //        }
            //        if (this.tbyy21.Text == "")
            //        {
            //            this.tbyy21.Text = "0";
            //        }
            //        if (this.textBox100.Text == "")
            //        {
            //            this.textBox100.Text = "0";
            //        }
            //        var allnum2 = int.Parse(this.tbyy21.Text) + int.Parse(this.tbyy22.Text) + int.Parse(this.tbyy23.Text) + int.Parse(this.tbyy24.Text) + int.Parse(this.tbyy25.Text) + int.Parse(this.tbyy26.Text) + int.Parse(this.tbyy27.Text) + int.Parse(this.tbyy28.Text) + int.Parse(this.tbyy29.Text) + int.Parse(this.tbyy30sl.Text);
            //        if (this.tbxcsl2.Text == "")
            //        {
            //            this.tbxcsl2.Text = "0";
            //        }
            //        var all = allnum2 + int.Parse(this.tbxcsl2.Text);
            //        if (this.textBox100.Text != Convert.ToString(allnum2))
            //        {
            //            MessageBox.Show("不合格总数错误", "提示");
            //            return;
            //        }
            //        else if (Convert.ToString(all) != this.tbsjsl2.Text)
            //        {
            //            MessageBox.Show("数量与上接数量不符", "提示");
            //            return;
            //        }
            //        #endregion
            //    }
            //    else if (yh.机构 == "测试")
            //    {
            //        #region 测试
            //        if (this.tbyy39sl.Text == "")
            //        {
            //            this.tbyy39sl.Text = "0";
            //        }
            //        if (this.tbyy38.Text == "")
            //        {
            //            this.tbyy38.Text = "0";
            //        }
            //        if (this.tbyy37.Text == "")
            //        {
            //            this.tbyy37.Text = "0";
            //        }
            //        if (this.tbyy36.Text == "")
            //        {
            //            this.tbyy36.Text = "0";
            //        }
            //        if (this.tbyy35.Text == "")
            //        {
            //            this.tbyy35.Text = "0";
            //        }
            //        if (this.tbyy34.Text == "")
            //        {
            //            this.tbyy34.Text = "0";
            //        }
            //        if (this.tbyy33.Text == "")
            //        {
            //            this.tbyy33.Text = "0";
            //        }
            //        if (this.tbyy32.Text == "")
            //        {
            //            this.tbyy32.Text = "0";
            //        }
            //        if (this.tbyy31.Text == "")
            //        {
            //            this.tbyy31.Text = "0";
            //        }
            //        if (this.tbbhgsl2.Text == "")
            //        {
            //            this.tbbhgsl2.Text = "0";
            //        }
            //        var allnum3 = int.Parse(this.tbyy31.Text) + int.Parse(this.tbyy32.Text) + int.Parse(this.tbyy33.Text) + int.Parse(this.tbyy34.Text) + int.Parse(this.tbyy35.Text) + int.Parse(this.tbyy36.Text) + int.Parse(this.tbyy37.Text) + int.Parse(this.tbyy38.Text) + int.Parse(this.tbyy39sl.Text);
            //        if (tbxcsl4.Text == "")
            //        {
            //            tbxcsl4.Text = "0";
            //        }
            //        var all = int.Parse(this.tbbhgsl2.Text) + int.Parse(tbxcsl4.Text);
            //        if (this.tbbhgsl2.Text != Convert.ToString(allnum3))
            //        {
            //            MessageBox.Show("不合格总数错误", "提示");
            //            return;
            //        }
            //        else if (Convert.ToString(all) != this.tbsjsl4.Text)
            //        {
            //            MessageBox.Show("数量与上接数量不符", "提示");
            //            return;
            //        }
            //        #endregion
            //    }
            //    else if (yh.机构 == "清洗")
            //    {
            //        #region 清洗
            //        if (this.tbyy40.Text == "")
            //        {
            //            this.tbyy40.Text = "0";
            //        }
            //        if (this.tbyy41sl.Text == "")
            //        {
            //            this.tbyy41sl.Text = "0";
            //        }
            //        if (this.tbbhgsl3.Text == "")
            //        {
            //            this.tbbhgsl3.Text = "0";
            //        }
            //        var allnum4 = int.Parse(this.tbyy40.Text) + int.Parse(this.tbyy41sl.Text);
            //        if (this.tbxcsl5.Text == "")
            //        {
            //            this.tbxcsl5.Text = "0";
            //        }
            //        var all = allnum4 + int.Parse(this.tbxcsl5.Text);
            //        if (this.tbbhgsl3.Text != Convert.ToString(allnum4))
            //        {
            //            MessageBox.Show("不合格总数错误", "提示");
            //            return;
            //        }
            //        else if (Convert.ToString(all) != this.tbsjsl5.Text)
            //        {
            //            MessageBox.Show("数量与上接数量不符", "提示");
            //            return;
            //        }
            //        #endregion
            //    }
            //    else if (yh.机构 == "包装")
            //    {
            //        #region 包装
            //        if (this.tbyy42.Text == "")
            //        {
            //            this.tbyy42.Text = "0";
            //        }
            //        if (this.tbyy43sl.Text == "")
            //        {
            //            this.tbyy43sl.Text = "0";
            //        }
            //        if (this.tbbhgsl4.Text == "")
            //        {
            //            this.tbbhgsl4.Text = "0";
            //        }
            //        var allnum5 = int.Parse(this.tbyy42.Text) + int.Parse(this.tbyy43sl.Text);
            //        if (this.tbxcsl6.Text == "")
            //        {
            //            this.tbxcsl6.Text = "";
            //        }
            //        var all = allnum5 + int.Parse(this.tbxcsl6.Text);
            //        if (this.tbbhgsl4.Text != Convert.ToString(allnum5))
            //        {
            //            MessageBox.Show("不合格总数错误", "提示");
            //            return;
            //        }
            //        else if (Convert.ToString(all) != this.tbsjsl6.Text)
            //        {
            //            MessageBox.Show("下传数量与上接数量不符", "提示");
            //            return;
            //        }
            //        #endregion
                //    }
                #endregion
            //}
            #endregion

            DialogResult dr = MessageBox.Show("确定要修改吗？？？","提示",MessageBoxButtons.YesNo);
            
             if (dr == DialogResult.Yes)
             {
                 var sgd = this.tbSGDXH.Text;
                 if (sgd != "")
                 {
                     tsuhan_sg_tx bhd = new tsuhan_sg_tx();
                     tsuhan_sg_bhd bh = new tsuhan_sg_bhd();
                     var sgdh = this.tbSGDXH.Text + this.tbDXH1.Text;
                     var str = sgdh.Substring(sgdh.Length - 1, 1);
                     bhd.随工单号 =sgdh ;
                    
                     var tx = txbll.QueryByXuhao(sgdh);
                     bhd.id = tx.id;
                     //if (str == "R")
                     //{
                         #region 判断时间格式
                         //if (yh.机构 == "全部")
                         //{
                             var time = this.dtpxcTime.Text;
                             Match m1 = Regex.Match(dtpxcTime.Text, reg);
                             Match m2 = Regex.Match(dtp1.Text, reg);
                             Match m3 = Regex.Match(dtptime2.Text, reg);
                             Match m4 = Regex.Match(dtpfrtime1.Text, regs);
                             Match m5 = Regex.Match(dtpqcTime1.Text, regs);
                             Match m6 = Regex.Match(dtpxtime3.Text, reg);
                             Match m7 = Regex.Match(dtpxctime3.Text, reg);
                             Match m8 = Regex.Match(dtpxctime4.Text, reg);
                             if (m1.Success == false)
                             {
                                 MessageBox.Show("备料时间格式输入错误.如[2015-5-5]", "提示");
                                 return;
                             }
                             else if (m2.Success == false)
                             {
                                 MessageBox.Show("LD耦合焊接时间格式输入错误.如[2015-5-5]", "提示");
                                 return;
                             }
                             else if (m3.Success == false)
                             {
                                 MessageBox.Show("PT耦合固化时间格式输入错误.如[2015-5-5]", "提示");
                                 return;
                             }
                             else if (m4.Success == false)
                             {
                                 MessageBox.Show("温循前时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                                 return;
                             }
                             else if (m5.Success == false)
                             {
                                 MessageBox.Show("温循后时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                                 return;
                             }
                             else if (m6.Success == false)
                             {
                                 MessageBox.Show("测试时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                                 return;
                             }
                             else if (m7.Success == false)
                             {
                                 MessageBox.Show("清洗时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                                 return;
                             }
                             else if (m8.Success == false)
                             {
                                 MessageBox.Show("包装时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                                 return;
                             }
                             else
                             {
                                 BeiLiaoBind(bhd);
                                 LDHanJieBind(bhd);
                                 PTGuHuaBind(bhd);
                                 WenXunQianBind(bhd);
                                 WenXunHouBind(bhd);
                                 CeShiBind(bhd);
                                 QingXiBind(bhd);
                                 BaoZhuangBind(bhd);
                             }

                         //}
                         //else if (yh.机构 == "备料")
                         //{
                         //    if (tx.bl_xcsl != null)
                         //    {
                         //        MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                         //        return;
                         //    }
                         //    else
                         //    {
                         //        var time = this.dtpxcTime.Text;
                         //        Match m = Regex.Match(dtpxcTime.Text, reg);
                         //        if (m.Success == false)
                         //        {
                         //            MessageBox.Show("备料时间格式输入错误.如[2015-5-5]", "提示");
                         //            return;
                         //        }
                         //        else
                         //        {
                         //            BeiLiaoBind(bhd);

                         //        }
                         //    }
                         //}
                         //else if (yh.机构 == "LD耦合焊接")
                         //{
                         //    if (tx.LD_xcsl != null)
                         //    {
                         //        MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                         //        return;
                         //    }
                         //    else
                         //    {
                         //        var time = this.dtp1.Text;
                         //        Match m = Regex.Match(dtp1.Text, reg);
                         //        if (m.Success == false)
                         //        {
                         //            MessageBox.Show("LD耦合焊接时间格式输入错误.如[2015-5-5]", "提示");
                         //            return;
                         //        }
                         //        else
                         //        {
                         //            BeiLiaoBind(bhd);
                         //            LDHanJieBind(bhd);
                         //            //if (this.tbsjsl1.Text != Convert.ToString(tx.bl_xcsl))
                         //            //{
                         //            //    MessageBox.Show("LD耦合焊接上接数量与备料下传数量不符", "提示");
                         //            //    return;
                         //            //}
                         //        }
                         //    }
                         //}
                         //else if (yh.机构 == "PT耦合固化")
                         //{
                         //    if (tx.PT_xcsl != null)
                         //    {
                         //        MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                         //        return;
                         //    }
                         //    else
                         //    {
                         //        var time = this.dtptime2.Text;
                         //        Match m = Regex.Match(dtptime2.Text, reg);
                         //        if (m.Success == false)
                         //        {
                         //            MessageBox.Show("PT耦合固化时间格式输入错误.如[2015-5-5]", "提示");
                         //            return;
                         //        }
                         //        else
                         //        {
                         //            BeiLiaoBind(bhd);
                         //            LDHanJieBind(bhd);
                         //            PTGuHuaBind(bhd);
                         //            //if (this.tbsjsl2.Text != Convert.ToString(tx.LD_xcsl))
                         //            //{
                         //            //    MessageBox.Show("PT耦合固化上接数量与LD耦合焊接下传数量不符", "提示");
                         //            //    return;
                         //            //}
                         //        }
                         //    }
                         //}
                         //else if (yh.机构 == "温循前")
                         //{
                         //    if (tx.WXQ_frsl != null)
                         //    {
                         //        MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                         //        return;
                         //    }
                         //    else
                         //    {
                         //        var time = this.dtpfrtime1.Text;
                         //        Match m = Regex.Match(dtpfrtime1.Text, regs);
                         //        if (m.Success == false)
                         //        {
                         //            MessageBox.Show("温循前时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                         //            return;
                         //        }
                         //        else
                         //        {
                         //            BeiLiaoBind(bhd);
                         //            LDHanJieBind(bhd);
                         //            PTGuHuaBind(bhd);
                         //            WenXunQianBind(bhd);

                         //            //if (this.tbsjsl3.Text != Convert.ToString(tx.PT_xcsl))
                         //            //{
                         //            //    MessageBox.Show("温循前上接数量与PT耦合固化下传数量不符", "提示");
                         //            //    return;
                         //            //}
                         //        }
                         //    }
                         //}
                         //else if (yh.机构 == "温循后")
                         //{
                         //    if (tx.WXH_xcsl != null)
                         //    {
                         //        MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                         //        return;
                         //    }
                         //    else
                         //    {
                         //        var time = this.dtpqcTime1.Text;
                         //        Match m = Regex.Match(dtpqcTime1.Text, regs);
                         //        if (m.Success == false)
                         //        {
                         //            MessageBox.Show("温循后时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                         //            return;
                         //        }
                         //        else
                         //        {

                         //            BeiLiaoBind(bhd);
                         //            LDHanJieBind(bhd);
                         //            PTGuHuaBind(bhd);
                         //            WenXunQianBind(bhd);
                         //            WenXunHouBind(bhd);
                         //            //if (this.tbqcsl1.Text != Convert.ToString(tx.WXQ_frsl))
                         //            //{
                         //            //    MessageBox.Show("温循后上接数量与温循前放入数量不符", "提示");
                         //            //    return;
                         //            //}
                         //        }
                         //    }
                         //}
                         //else if (yh.机构 == "测试")
                         //{
                         //    if (tx.CS_xcsl != null)
                         //    {
                         //        MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                         //        return;
                         //    }
                         //    else
                         //    {
                         //        var time = this.dtpxtime3.Text;
                         //        Match m = Regex.Match(dtpxtime3.Text, reg);
                         //        if (m.Success == false)
                         //        {
                         //            MessageBox.Show("测试时间格式输入错误.如[2015-5-5]", "提示");
                         //            return;
                         //        }
                         //        else
                         //        {

                         //            BeiLiaoBind(bhd);
                         //            LDHanJieBind(bhd);
                         //            PTGuHuaBind(bhd);
                         //            WenXunQianBind(bhd);
                         //            WenXunHouBind(bhd);
                         //            CeShiBind(bhd);
                         //            //if (this.tbsjsl4.Text != Convert.ToString(tx.WXH_qcsl))
                         //            //{
                         //            //    MessageBox.Show("测试上接数量与温循后下传数量不符", "提示");
                         //            //    return;
                         //            //}
                         //        }
                         //    }
                         //}
                         //else if (yh.机构 == "清洗")
                         //{
                         //    if (tx.QX_xcsl != null)
                         //    {
                         //        MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                         //        return;
                         //    }
                         //    else
                         //    {
                         //        var time = this.dtpxctime3.Text;
                         //        Match m = Regex.Match(dtpxctime3.Text, reg);
                         //        if (m.Success == false)
                         //        {
                         //            MessageBox.Show("清洗时间格式输入错误.如[2015-5-5]", "提示");
                         //            return;
                         //        }
                         //        else
                         //        {
                         //            BeiLiaoBind(bhd);
                         //            LDHanJieBind(bhd);
                         //            PTGuHuaBind(bhd);
                         //            WenXunQianBind(bhd);
                         //            WenXunHouBind(bhd);
                         //            CeShiBind(bhd);
                         //            QingXiBind(bhd);
                         //            //if (this.tbsjsl5.Text != Convert.ToString(tx.CS_xcsl))
                         //            //{
                         //            //    MessageBox.Show("清洗上接数量与测试下传数量不符", "提示");
                         //            //    return;
                         //            //}
                         //        }
                         //    }
                         //}
                         //else if (yh.机构 == "包装")
                         //{
                         //    if (tx.BZ_xcsl != null)
                         //    {
                         //        MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                         //        return;
                         //    }
                         //    else
                         //    {
                         //        var time = this.dtpxctime4.Text;
                         //        Match m = Regex.Match(dtpxctime4.Text, reg);
                         //        if (m.Success == false)
                         //        {
                         //            MessageBox.Show("包装时间格式输入错误.如[2015-5-5]", "提示");
                         //            return;
                         //        }
                         //        else
                         //        {
                         //            BeiLiaoBind(bhd);
                         //            LDHanJieBind(bhd);
                         //            PTGuHuaBind(bhd);
                         //            WenXunQianBind(bhd);
                         //            WenXunHouBind(bhd);
                         //            CeShiBind(bhd);
                         //            QingXiBind(bhd);
                         //            BaoZhuangBind(bhd);
                         //            //if (this.tbsjsl6.Text != Convert.ToString(tx.QX_xcsl))
                         //            //{
                         //            //    MessageBox.Show("包装上接数量与清洗下传数量不符", "提示");
                         //            //    return;
                         //            //}
                         //        }
                             //}
                         //}

                         #endregion
                             #region
                             //}
                     //else
                     //{
                     //    #region 判断时间格式
                     //    if (yh.机构 == "全部")
                     //    {
                     //        var time = this.dtpxcTime.Text;
                     //        Match m1 = Regex.Match(dtpxcTime.Text, reg);
                     //        Match m2 = Regex.Match(dtp1.Text, reg);
                     //        Match m3 = Regex.Match(dtptime2.Text, reg);
                     //        Match m4 = Regex.Match(dtpfrtime1.Text, regs);
                     //        Match m5 = Regex.Match(dtpqcTime1.Text, regs);
                     //        Match m6 = Regex.Match(dtpxtime3.Text, reg);
                     //        Match m7 = Regex.Match(dtpxctime3.Text, reg);
                     //        Match m8 = Regex.Match(dtpxctime4.Text, reg);
                     //        if (m1.Success == false)
                     //        {
                     //            MessageBox.Show("备料时间格式输入错误.如[2015-5-5]", "提示");
                     //            return;
                     //        }
                     //        else if (m2.Success == false)
                     //        {
                     //            MessageBox.Show("LD耦合焊接时间格式输入错误.如[2015-5-5]", "提示");
                     //            return;
                     //        }
                     //        else if (m3.Success == false)
                     //        {
                     //            MessageBox.Show("PT耦合固化时间格式输入错误.如[2015-5-5]", "提示");
                     //            return;
                     //        }
                     //        else if (m4.Success == false)
                     //        {
                     //            MessageBox.Show("温循前时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                     //            return;
                     //        }
                     //        else if (m5.Success == false)
                     //        {
                     //            MessageBox.Show("温循后时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                     //            return;
                     //        }
                     //        else if (m6.Success == false)
                     //        {
                     //            MessageBox.Show("测试时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                     //            return;
                     //        }
                     //        else if (m7.Success == false)
                     //        {
                     //            MessageBox.Show("清洗时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                     //            return;
                     //        }
                     //        else if (m8.Success == false)
                     //        {
                     //            MessageBox.Show("包装时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            BeiLiaoBind(bhd);
                     //            LDHanJieBind(bhd);
                     //            PTGuHuaBind(bhd);
                     //            WenXunQianBind(bhd);
                     //            WenXunHouBind(bhd);
                     //            CeShiBind(bhd);
                     //            QingXiBind(bhd);
                     //            BaoZhuangBind(bhd);
                     //        }

                     //    }
                     //    else if (yh.机构 == "备料")
                     //    {
                     //        if (tx.bl_xcsl != null)
                     //        {
                     //            MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            var time = this.dtpxcTime.Text;
                     //            Match m = Regex.Match(dtpxcTime.Text, reg);
                     //            if (m.Success == false)
                     //            {
                     //                MessageBox.Show("备料时间格式输入错误.如[2015-5-5]", "提示");
                     //                return;
                     //            }
                     //            else
                     //            {
                     //                BeiLiaoBind(bhd);

                     //            }
                     //        }
                     //    }
                     //    else if (yh.机构 == "LD耦合焊接")
                     //    {
                     //        if (tx.LD_xcsl != null)
                     //        {
                     //            MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            var time = this.dtp1.Text;
                     //            Match m = Regex.Match(dtp1.Text, reg);
                     //            if (m.Success == false)
                     //            {
                     //                MessageBox.Show("LD耦合焊接时间格式输入错误.如[2015-5-5]", "提示");
                     //                return;
                     //            }
                     //            else
                     //            {
                     //                BeiLiaoBind(bhd);
                     //                LDHanJieBind(bhd);
                     //                if (this.tbsjsl1.Text != Convert.ToString(tx.bl_xcsl))
                     //                {
                     //                    MessageBox.Show("LD耦合焊接上接数量与备料下传数量不符", "提示");
                     //                    return;
                     //                }
                     //            }
                     //        }
                     //    }
                     //    else if (yh.机构 == "PT耦合固化")
                     //    {
                     //        if (tx.PT_xcsl != null)
                     //        {
                     //            MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            var time = this.dtptime2.Text;
                     //            Match m = Regex.Match(dtptime2.Text, reg);
                     //            if (m.Success == false)
                     //            {
                     //                MessageBox.Show("PT耦合固化时间格式输入错误.如[2015-5-5]", "提示");
                     //                return;
                     //            }
                     //            else
                     //            {
                     //                BeiLiaoBind(bhd);
                     //                LDHanJieBind(bhd);
                     //                PTGuHuaBind(bhd);
                     //                if (this.tbsjsl2.Text != Convert.ToString(tx.LD_xcsl))
                     //                {
                     //                    MessageBox.Show("PT耦合固化上接数量与LD耦合焊接下传数量不符", "提示");
                     //                    return;
                     //                }
                     //            }
                     //        }
                     //    }
                     //    else if (yh.机构 == "温循前")
                     //    {
                     //        if (tx.WXQ_frsl != null)
                     //        {
                     //            MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            var time = this.dtpfrtime1.Text;
                     //            Match m = Regex.Match(dtpfrtime1.Text, regs);
                     //            if (m.Success == false)
                     //            {
                     //                MessageBox.Show("温循前时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                     //                return;
                     //            }
                     //            else
                     //            {
                     //                BeiLiaoBind(bhd);
                     //                LDHanJieBind(bhd);
                     //                PTGuHuaBind(bhd);
                     //                WenXunQianBind(bhd);

                     //                if (this.tbsjsl3.Text != Convert.ToString(tx.PT_xcsl))
                     //                {
                     //                    MessageBox.Show("温循前上接数量与PT耦合固化下传数量不符", "提示");
                     //                    return;
                     //                }
                     //            }
                     //        }
                     //    }
                     //    else if (yh.机构 == "温循后")
                     //    {
                     //        if (tx.WXH_xcsl != null)
                     //        {
                     //            MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            var time = this.dtpqcTime1.Text;
                     //            Match m = Regex.Match(dtpqcTime1.Text, regs);
                     //            if (m.Success == false)
                     //            {
                     //                MessageBox.Show("温循后时间格式输入错误.如[2015-5-5 00:00:00]", "提示");
                     //                return;
                     //            }
                     //            else
                     //            {

                     //                BeiLiaoBind(bhd);
                     //                LDHanJieBind(bhd);
                     //                PTGuHuaBind(bhd);
                     //                WenXunQianBind(bhd);
                     //                WenXunHouBind(bhd);
                     //                if (this.tbqcsl1.Text != Convert.ToString(tx.WXQ_frsl))
                     //                {
                     //                    MessageBox.Show("温循后上接数量与温循前放入数量不符", "提示");
                     //                    return;
                     //                }
                     //            }
                     //        }
                     //    }
                     //    else if (yh.机构 == "测试")
                     //    {
                     //        if (tx.CS_xcsl != null)
                     //        {
                     //            MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            var time = this.dtpxtime3.Text;
                     //            Match m = Regex.Match(dtpxtime3.Text, reg);
                     //            if (m.Success == false)
                     //            {
                     //                MessageBox.Show("测试时间格式输入错误.如[2015-5-5]", "提示");
                     //                return;
                     //            }
                     //            else
                     //            {

                     //                BeiLiaoBind(bhd);
                     //                LDHanJieBind(bhd);
                     //                PTGuHuaBind(bhd);
                     //                WenXunQianBind(bhd);
                     //                WenXunHouBind(bhd);
                     //                CeShiBind(bhd);
                     //                if (this.tbsjsl4.Text != Convert.ToString(tx.WXH_qcsl))
                     //                {
                     //                    MessageBox.Show("测试上接数量与温循后下传数量不符", "提示");
                     //                    return;
                     //                }
                     //            }
                     //        }
                     //    }
                     //    else if (yh.机构 == "清洗")
                     //    {
                     //        if (tx.QX_xcsl != null)
                     //        {
                     //            MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            var time = this.dtpxctime3.Text;
                     //            Match m = Regex.Match(dtpxctime3.Text, reg);
                     //            if (m.Success == false)
                     //            {
                     //                MessageBox.Show("清洗时间格式输入错误.如[2015-5-5]", "提示");
                     //                return;
                     //            }
                     //            else
                     //            {
                     //                BeiLiaoBind(bhd);
                     //                LDHanJieBind(bhd);
                     //                PTGuHuaBind(bhd);
                     //                WenXunQianBind(bhd);
                     //                WenXunHouBind(bhd);
                     //                CeShiBind(bhd);
                     //                QingXiBind(bhd);
                     //                if (this.tbsjsl5.Text != Convert.ToString(tx.CS_xcsl))
                     //                {
                     //                    MessageBox.Show("清洗上接数量与测试下传数量不符", "提示");
                     //                    return;
                     //                }
                     //            }
                     //        }
                     //    }
                     //    else if (yh.机构 == "包装")
                     //    {
                     //        if (tx.BZ_xcsl != null)
                     //        {
                     //            MessageBox.Show("此单你已经提交过了,不能再修改", "提示");
                     //            return;
                     //        }
                     //        else
                     //        {
                     //            var time = this.dtpxctime4.Text;
                     //            Match m = Regex.Match(dtpxctime4.Text, reg);
                     //            if (m.Success == false)
                     //            {
                     //                MessageBox.Show("包装时间格式输入错误.如[2015-5-5]", "提示");
                     //                return;
                     //            }
                     //            else
                     //            {
                     //                BeiLiaoBind(bhd);
                     //                LDHanJieBind(bhd);
                     //                PTGuHuaBind(bhd);
                     //                WenXunQianBind(bhd);
                     //                WenXunHouBind(bhd);
                     //                CeShiBind(bhd);
                     //                QingXiBind(bhd);
                     //                BaoZhuangBind(bhd);
                     //                if (this.tbsjsl6.Text != Convert.ToString(tx.QX_xcsl))
                     //                {
                     //                    MessageBox.Show("包装上接数量与清洗下传数量不符", "提示");
                     //                    return;
                     //                }
                     //            }
                     //        }
                     //    }

                     //    #endregion
                             //}
                             #endregion
                             bhd.lsh1 = this.tbLSH1.Text;
                     bhd.lsh2 = this.tbLSH2.Text;
                     bhd.lsh3 = this.tbLSH3.Text;

                     bhd.case1 = this.tbCASE1.Text;
                     bhd.case2 = this.tbCASE2.Text;
                     bhd.case3 = this.tbCASE3.Text;

                     bhd.ld1 = this.tbLDP1.Text;
                     bhd.ld2 = this.tbLDP2.Text;
                     bhd.ld3 = this.tbLDP3.Text;

                     bhd.pd1 = this.tbPDP1.Text;
                     bhd.pd2 = this.tbPDP2.Text;
                     bhd.pd3 = this.tbPDP3.Text;

                     bhd.ldj1 = this.tbLDN1.Text;
                     bhd.ldj2 = this.tbLDN2.Text;
                     bhd.ldj3 = this.tbLDN3.Text;

                     if (this.tbJC1.Text=="")
                     {
                         this.tbJC1.Text = "0";
                     }
                     bhd.jc1 = Convert.ToDecimal(this.tbJC1.Text);
                     if (this.tbJC2.Text == "")
                     {
                         this.tbJC2.Text = "0";
                     }
                     bhd.jc2 = Convert.ToDecimal(this.tbJC2.Text);
                     if (this.tbJC3.Text == "")
                     {
                         this.tbJC3.Text = "0";
                     }
                     bhd.jc3 = Convert.ToDecimal(this.tbJC3.Text);

                     bhd.oxl1 = this.tbAXL1.Text;
                     bhd.oxl2 = this.tbAXL2.Text;
                     bhd.oxl3 = this.tbAXL3.Text;

                     bhd.ldxp_xinpianjj = this.tbjj.Text;
                     bhd.ldxp_jianyanry = this.tbjyry.Text;
                     bhd.ldxp_jianyansb = this.tbjysb.Text;
                     bhd.备注 = this.rtbremark.Text;
                     bhd.LD_xh = this.textBox34.Text;
                     bhd.LD_name = this.textBox35.Text;
                     bhd.LD_sjdh = this.textBox36.Text;
                     bhd.PT_xh = this.textBox39.Text;
                     bhd.PT_name = this.textBox38.Text;
                     bhd.PT_sjdh = this.textBox37.Text;
                     bhd.KT_xh = this.textBox42.Text;
                     bhd.KT_name = this.textBox41.Text;
                     bhd.KT_sjdh = this.textBox40.Text;
                     bhd.NBP_xh0 = this.textBox45.Text;
                     bhd.NBP_name0 = this.textBox44.Text;
                     bhd.NBP_sjdh0 = this.textBox43.Text;
                     bhd.NBP_xh45 = this.textBox51.Text;
                     bhd.NBP_name45 = this.textBox50.Text;
                     bhd.NBP_sjdh45 = this.textBox49.Text;
                     bhd.JK_xh = this.textBox48.Text;
                     bhd.JK_name = this.textBox47.Text;
                     bhd.JK_sjdh = this.textBox46.Text;
                    // bool result3 = bhdbll.Add(bh);
                     bool result = false;
                     //bool result1 = false;
                     result= txbll.Update(bhd);
                     //result1 = bhdbll.Update(bh);
                     if (result == true)
                     {
                         MessageBox.Show("修改成功！", "提示");
                         this.btnUpdate.Enabled = false;
                     }
                     else
                     {
                         MessageBox.Show("修改失败！", "提示");
                     }
                 }
             }
        
        }

     

        private void dtpqcTime1_MouseLeave(object sender, EventArgs e)
        {
            //var name = Convert.ToInt32(gh);;
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);
            tsuhan_sg_tx gt = txbll.GetAllTx();
            //if (yh.机构=="全部")
            //{
            DateTime time1 = Convert.ToDateTime(this.dtpfrtime1.Text);
            DateTime time2 = Convert.ToDateTime(this.dtpqcTime1.Text);
            TimeSpan ts = time2 - time1;
            double totalhours = ts.TotalHours;
            this.tbwxsc.Text = Convert.ToString(totalhours);//.Substring(0,5);
            //}
            //else if (yh.机构 == "温循后")
            //{
                //DateTime time1 = Convert.ToDateTime(this.dtpfrtime1.Text);
                //DateTime time2 = Convert.ToDateTime(this.dtpqcTime1.Text);
                //TimeSpan ts = time2 - time1;
                //double totalhours = ts.TotalHours;
                //this.tbwxsc.Text = totalhours.ToString().Substring(0,5);
            //}
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxcsl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbczy1_MouseUp(object sender, MouseEventArgs e)
        {
            tsuhan_sg_tx bhd = new tsuhan_sg_tx();
            //var name = Convert.ToInt32(gh);
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);

            if (this.tabControl1.SelectedTab == tabPage1)
            {
                #region 备料
                bhd.bl_czy1 = this.tbczy1.Text;
                bool result1;
                result1 = yhbll.Exist(this.tbczy1.Text);
                if (this.tbczy1.Text == "")
                {
                    this.tbczy1.Text = "0";
                }
                else if (result1 != true)
                {
                    rg.ShowDialog();
                    this.tbczName1.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tbczy1.Text);
                    this.tbczName1.Text = yh1.姓名;
                    bhd.bl_czyname1 = this.tbczName1.Text;

                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage2)
            {
                #region LD耦合焊接
                bhd.LD_czy1 = this.tbcz1.Text;
                bool result1;
                result1 = yhbll.Exist(this.tbcz1.Text);
                if (this.tbcz1.Text == "")
                {
                    this.tbcz1.Text = "0";
                }
                else if (result1 != true)
                {
                    rg.ShowDialog();
                    this.tbname1.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tbcz1.Text);
                    this.tbname1.Text = yh1.姓名;
                    bhd.LD_czyname1 = this.tbname1.Text;

                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage3)
            {
                #region PT耦合固化
                bhd.PT_czy1 = this.tbcz5.Text;
                bool result1;
                result1 = yhbll.Exist(this.tbcz5.Text);
                if (this.tbcz5.Text == "")
                {
                    this.tbcz5.Text = "0";
                }
                else if (result1 != true)
                {
                    rg.ShowDialog();
                    this.tbname5.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tbcz5.Text);
                    this.tbname5.Text = yh1.姓名;
                    bhd.PT_czyname1 = this.tbname5.Text;

                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage4)
            {
                #region 温循前
                bhd.WXQ_czy = this.tbcz9.Text;
                bool result1;
                result1 = yhbll.Exist(this.tbcz9.Text);
                if (this.tbcz9.Text == "")
                {
                    this.tbcz9.Text = "0";
                }
                else if (result1 != true)
                {
                    rg.ShowDialog();
                    this.tbname9.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tbcz9.Text);
                    this.tbname9.Text = yh1.姓名;
                    bhd.WXQ_czyname = this.tbname9.Text;

                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage5)
            {
                #region 温循后
                bhd.WXH_czy = this.tbcz10.Text;
                bool result1;
                result1 = yhbll.Exist(this.tbcz10.Text);

                if (this.tbcz10.Text == "")
                {
                    this.tbcz10.Text = "0";
                }
                else if (result1 != true)
                {
                    rg.ShowDialog();
                    this.tbname10.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tbcz10.Text);
                    this.tbname10.Text = yh1.姓名;
                    bhd.WXH_czyname = this.tbname10.Text;

                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage6)
            {
                #region 测试
                bhd.CS_czy1 = this.tbcz11.Text;
                bool result1;
                result1 = yhbll.Exist(this.tbcz11.Text);
                if (this.tbcz11.Text == "")
                {
                    this.tbcz11.Text = "0";
                }
                else if (result1 != true)
                {
                    rg.ShowDialog();
                    this.tbname11.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tbcz11.Text);
                    this.tbname11.Text = yh1.姓名;
                    bhd.CS_czyname1 = this.tbname11.Text;
                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage7)
            {
                #region 清洗
                bhd.QX_czy1 = this.tbcz15.Text;
                bool result1;
                result1 = yhbll.Exist(this.tbcz15.Text);
                if (this.tbcz15.Text == "")
                {
                    this.tbcz15.Text = "0";
                }
                else if (result1 != true)
                {
                    rg.ShowDialog();
                    this.tbname15.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tbcz15.Text);
                    this.tbname15.Text = yh1.姓名;
                    bhd.QX_czyname1 = this.tbname15.Text;
                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage8)
            {
                #region 包装
                bhd.BZ_czy1 = this.tbcz19.Text;
                bool result1;
                result1 = yhbll.Exist(this.tbcz19.Text);
                if (this.tbcz19.Text == "")
                {
                    this.tbcz19.Text = "0";
                }
                else if (result1 != true)
                {
                    rg.ShowDialog();
                    this.tbname19.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tbcz19.Text);
                    this.tbname19.Text = yh1.姓名;
                    bhd.BZ_czyname1 = this.tbname19.Text;
                }
                #endregion
            }

            #region
            //if (yh.机构 == "全部")
            //{
            //    if (this.tabControl1.SelectedTab == tabPage1)
            //    {
            //        #region 备料
            //        bhd.bl_czy1 = this.tbczy1.Text;
            //        bool result1;
            //        result1 = yhbll.Exist(this.tbczy1.Text);
            //        if (this.tbczy1.Text == "")
            //        {
            //            this.tbczy1.Text = "0";
            //        }
            //        else if (result1 != true)
            //        {
            //            rg.ShowDialog();
            //            this.tbczName1.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh1 = yhbll.GetModel(this.tbczy1.Text);
            //            this.tbczName1.Text = yh1.姓名;
            //            bhd.bl_czyname1 = this.tbczName1.Text;

            //        }
            //        #endregion
            //        #region 备料
            //        bhd.bl_czy2 = this.tbczy2.Text;
            //        bool result2;
            //        result2 = yhbll.Exist(this.tbczy2.Text);

            //        if (this.tbczy2.Text == "")
            //        {
            //            this.tbczy2.Text = "0";
            //        }
            //        else if (result2 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbczName2.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh2 = yhbll.GetModel(this.tbczy2.Text);
            //            this.tbczName2.Text = yh2.姓名;
            //            bhd.bl_czyname2 = this.tbczName2.Text;

            //        }
            //        #endregion
            //        #region 备料
            //        bhd.bl_czy3 = this.tbczy3.Text;
            //        bool result3;
            //        result3 = yhbll.Exist(this.tbczy3.Text);

            //        if (this.tbczy3.Text == "")
            //        {
            //            this.tbczy3.Text = "0";
            //        }
            //        else if (result3 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbczName3.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh3 = yhbll.GetModel(this.tbczy3.Text);
            //            this.tbczName3.Text = yh3.姓名;
            //            bhd.bl_czyname3 = this.tbczName3.Text;

            //        }
            //        #endregion
            //        #region 备料
            //        bhd.bl_czy4 = this.tbczy4.Text;
            //        bool result4;
            //        result4 = yhbll.Exist(this.tbczy4.Text);
            //        if (this.tbczy4.Text == "")
            //        {
            //            this.tbczy4.Text = "0";
            //        }
            //        else if (result4 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbczName4.Text = "";

            //            return;
            //        }
            //        else
            //        {
            //            var yh4 = yhbll.GetModel(this.tbczy4.Text);
            //            this.tbczName4.Text = yh4.姓名;
            //            bhd.bl_czyname4 = this.tbczName4.Text;
            //        }

            //        #endregion
            //    }
            //    else if (this.tabControl1.SelectedTab == tabPage2)
            //    {
            //        #region LD耦合焊接
            //        bhd.LD_czy1 = this.tbcz1.Text;
            //        bool result1;
            //        result1 = yhbll.Exist(this.tbcz1.Text);
            //        if (this.tbcz1.Text == "")
            //        {
            //            this.tbcz1.Text = "0";
            //        }
            //        else if (result1 != true)
            //        {
            //            rg.ShowDialog();
            //            this.tbname1.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh1 = yhbll.GetModel(this.tbcz1.Text);
            //            this.tbname1.Text = yh1.姓名;
            //            bhd.LD_czyname1 = this.tbname1.Text;

            //        }
            //        #endregion
            //        #region LD耦合焊接
            //        bhd.LD_czy2 = this.tbcz2.Text;
            //        bool result2;
            //        result2 = yhbll.Exist(this.tbcz2.Text);

            //        if (this.tbcz2.Text == "")
            //        {
            //            this.tbcz2.Text = "0";
            //        }
            //        else if (result2 != true)
            //        {
            //            this.tbname2.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh2 = yhbll.GetModel(this.tbcz2.Text);
            //            this.tbname2.Text = yh2.姓名;
            //            bhd.LD_czyname1 = this.tbname1.Text;

            //        }
            //        #endregion
            //        #region LD耦合焊接
            //        bhd.LD_czy3 = this.tbcz3.Text;
            //        bool result3;
            //        result3 = yhbll.Exist(this.tbcz3.Text);

            //        if (this.tbcz3.Text == "")
            //        {
            //            this.tbcz3.Text = "0";
            //        }
            //        else if (result3 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname3.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh3 = yhbll.GetModel(this.tbcz3.Text);
            //            this.tbname3.Text = yh3.姓名;
            //            bhd.LD_czyname2 = this.tbname2.Text;

            //        }
            //        #endregion
            //        #region LD耦合焊接
            //        bhd.LD_czy4 = this.tbcz4.Text;
            //        bool result4;
            //        result4 = yhbll.Exist(this.tbcz4.Text);
            //        if (this.tbcz4.Text == "")
            //        {
            //            this.tbcz4.Text = "0";
            //        }
            //        else if (result4 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname4.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh4 = yhbll.GetModel(this.tbcz4.Text);
            //            this.tbname4.Text = yh4.姓名;
            //            bhd.LD_czyname3 = this.tbname3.Text;
            //        }
            //        #endregion
            //    }
            //    else if (this.tabControl1.SelectedTab == tabPage3)
            //    {
            //        #region PT耦合固化
            //        bhd.PT_czy1 = this.tbcz5.Text;
            //        bool result1;
            //        result1 = yhbll.Exist(this.tbcz5.Text);
            //        if (this.tbcz5.Text == "")
            //        {
            //            this.tbcz5.Text = "0";
            //        }
            //        else if (result1 != true)
            //        {
            //            rg.ShowDialog();
            //            this.tbname5.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh1 = yhbll.GetModel(this.tbcz5.Text);
            //            this.tbname5.Text = yh1.姓名;
            //            bhd.PT_czyname1 = this.tbname5.Text;

            //        }
            //        #endregion
            //        #region PT耦合固化
            //        bhd.PT_czy2 = this.tbcz6.Text;
            //        bool result2;
            //        result2 = yhbll.Exist(this.tbcz6.Text);

            //        if (this.tbcz6.Text == "")
            //        {
            //            this.tbcz6.Text = "0";
            //        }
            //        else if (result2 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname6.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh2 = yhbll.GetModel(this.tbcz6.Text);
            //            this.tbname6.Text = yh2.姓名;
            //            bhd.PT_czyname2 = this.tbname6.Text;

            //        }

            //        #endregion
            //        #region PT耦合固化
            //        bhd.PT_czy3 = this.tbcz7.Text;
            //        bool result3;
            //        result3 = yhbll.Exist(this.tbcz7.Text);

            //        if (this.tbcz7.Text == "")
            //        {
            //            this.tbcz7.Text = "0";
            //        }
            //        else if (result3 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname7.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh3 = yhbll.GetModel(this.tbcz7.Text);
            //            this.tbname7.Text = yh3.姓名;
            //            bhd.PT_czyname3 = this.tbname7.Text;

            //        }
            //        #endregion
            //        #region PT耦合固化
            //        bhd.PT_czy4 = this.tbcz8.Text;
            //        bool result4;
            //        result4 = yhbll.Exist(this.tbcz8.Text);

            //        if (this.tbcz8.Text == "")
            //        {
            //            this.tbcz8.Text = "0";
            //        }
            //        else if (result4 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname8.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh4 = yhbll.GetModel(this.tbcz8.Text);
            //            this.tbname8.Text = yh4.姓名;
            //            bhd.PT_czyname4 = this.tbname8.Text;
            //        }

            //        #endregion
            //    }
            //    else if (this.tabControl1.SelectedTab == tabPage4)
            //    {
            //        #region 温循前
            //        bhd.WXQ_czy = this.tbcz9.Text;
            //        bool result1;
            //        result1 = yhbll.Exist(this.tbcz9.Text);
            //        if (this.tbcz9.Text == "")
            //        {
            //            this.tbcz9.Text = "0";
            //        }
            //        else if (result1 != true)
            //        {
            //            rg.ShowDialog();
            //            this.tbname9.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh1 = yhbll.GetModel(this.tbcz9.Text);
            //            this.tbname9.Text = yh1.姓名;
            //            bhd.WXQ_czyname = this.tbname9.Text;

            //        }
            //        #endregion
            //    }
            //    else if (this.tabControl1.SelectedTab == tabPage5)
            //    {
            //        #region 温循后
            //        bhd.WXH_czy = this.tbcz10.Text;
            //        bool result1;
            //        result1 = yhbll.Exist(this.tbcz10.Text);

            //        if (this.tbcz10.Text == "")
            //        {
            //            this.tbcz10.Text = "0";
            //        }
            //        else if (result1 != true)
            //        {
            //            rg.ShowDialog();
            //            this.tbname10.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh1 = yhbll.GetModel(this.tbcz10.Text);
            //            this.tbname10.Text = yh1.姓名;
            //            bhd.WXH_czyname = this.tbname10.Text;

            //        }
            //        #endregion
            //    }
            //    else if (this.tabControl1.SelectedTab == tabPage6)
            //    {
            //        #region 测试
            //        bhd.CS_czy1 = this.tbcz11.Text;
            //        bool result1;
            //        result1 = yhbll.Exist(this.tbcz11.Text);
            //        if (this.tbcz11.Text == "")
            //        {
            //            this.tbcz11.Text = "0";
            //        }
            //        else if (result1 != true)
            //        {
            //            rg.ShowDialog();
            //            this.tbname11.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh1 = yhbll.GetModel(this.tbcz11.Text);
            //            this.tbname11.Text = yh1.姓名;
            //            bhd.CS_czyname1 = this.tbname11.Text;
            //        }
            //        #endregion

            //        #region 测试
            //        bhd.CS_czy2 = this.tbcz12.Text;
            //        bool result2;
            //        result2 = yhbll.Exist(this.tbcz12.Text);

            //        if (this.tbcz12.Text == "")
            //        {
            //            this.tbcz12.Text = "0";
            //        }
            //        else if (result2 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname12.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh2 = yhbll.GetModel(this.tbcz12.Text);
            //            this.tbname12.Text = yh2.姓名;
            //            bhd.CS_czyname2 = this.tbname12.Text;
            //        }
            //        #endregion
            //        #region 测试
            //        bhd.CS_czy3 = this.tbcz13.Text;
            //        bool result3;
            //        result3 = yhbll.Exist(this.tbcz13.Text);

            //        if (this.tbcz13.Text == "")
            //        {
            //            this.tbcz13.Text = "0";
            //        }
            //        else if (result3 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname13.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh3 = yhbll.GetModel(this.tbcz13.Text);
            //            this.tbname13.Text = yh3.姓名;
            //            bhd.CS_czyname3 = this.tbname13.Text;
            //        }

            //        #endregion
            //        #region 测试
            //        bhd.CS_czy4 = this.tbcz14.Text;
            //        bool result4;
            //        result4 = yhbll.Exist(this.tbcz14.Text);

            //        if (this.tbcz14.Text == "")
            //        {
            //            this.tbcz14.Text = "0";
            //        }
            //        else if (result4 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname14.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh4 = yhbll.GetModel(this.tbcz14.Text);
            //            this.tbname14.Text = yh4.姓名;
            //            bhd.CS_czyname4 = this.tbname14.Text;
            //        }
            //        #endregion
            //    }
            //    else if (this.tabControl1.SelectedTab == tabPage7)
            //    {
            //        #region 清洗
            //        bhd.QX_czy1 = this.tbcz15.Text;
            //        bool result1;
            //        result1 = yhbll.Exist(this.tbcz15.Text);
            //        if (this.tbcz15.Text == "")
            //        {
            //            this.tbcz15.Text = "0";
            //        }
            //        else if (result1 != true)
            //        {
            //            rg.ShowDialog();
            //            this.tbname15.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh1 = yhbll.GetModel(this.tbcz15.Text);
            //            this.tbname15.Text = yh1.姓名;
            //            bhd.QX_czyname1 = this.tbname15.Text;
            //        }
            //        #endregion
            //        #region 清洗
            //        bhd.QX_czy2 = this.tbcz16.Text;
            //        bool result2;
            //        result2 = yhbll.Exist(this.tbcz16.Text);
            //        if (this.tbcz16.Text == "")
            //        {
            //            this.tbcz16.Text = "0";
            //        }
            //        else if (result2 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname16.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh2 = yhbll.GetModel(this.tbcz16.Text);
            //            this.tbname16.Text = yh2.姓名;
            //            bhd.QX_czyname2 = this.tbname16.Text;
            //        }
            //        #endregion
            //        #region 清洗
            //        bhd.QX_czy3 = this.tbcz17.Text;
            //        bool result3;
            //        result3 = yhbll.Exist(this.tbcz17.Text);

            //        if (this.tbcz17.Text == "")
            //        {
            //            this.tbcz17.Text = "0";
            //        }
            //        else if (result3 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname17.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh3 = yhbll.GetModel(this.tbcz17.Text);
            //            this.tbname17.Text = yh3.姓名;
            //            bhd.QX_czyname3 = this.tbname17.Text;
            //        }
            //        #endregion
            //        #region 清洗
            //        bhd.QX_czy4 = this.tbcz18.Text;
            //        bool result4;
            //        result4 = yhbll.Exist(this.tbcz18.Text);


            //        if (this.tbcz18.Text == "")
            //        {
            //            this.tbcz18.Text = "0";
            //        }
            //        else if (result4 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname18.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh4 = yhbll.GetModel(this.tbcz18.Text);
            //            this.tbname18.Text = yh4.姓名;
            //            bhd.QX_czyname4 = this.tbname18.Text;
            //        }
            //        #endregion
            //    }
            //    else if (this.tabControl1.SelectedTab == tabPage8)
            //    {
            //        #region 包装
            //        bhd.BZ_czy1 = this.tbcz19.Text;
            //        bool result1;
            //        result1 = yhbll.Exist(this.tbcz19.Text);
            //        if (this.tbcz19.Text == "")
            //        {
            //            this.tbcz19.Text = "0";
            //        }
            //        else if (result1 != true)
            //        {
            //            rg.ShowDialog();
            //            this.tbname19.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh1 = yhbll.GetModel(this.tbcz19.Text);
            //            this.tbname19.Text = yh1.姓名;
            //            bhd.BZ_czyname1 = this.tbname19.Text;
            //        }
            //        #endregion
            //        #region 包装
            //        bhd.BZ_czy2 = this.tbcz20.Text;
            //        bool result2;
            //        result2 = yhbll.Exist(this.tbcz20.Text);

            //        if (this.tbcz20.Text == "")
            //        {
            //            this.tbcz20.Text = "0";
            //        }
            //        else if (result2 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname20.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh2 = yhbll.GetModel(this.tbcz20.Text);
            //            this.tbname20.Text = yh2.姓名;
            //            bhd.BZ_czyname2 = this.tbname20.Text;
            //        }
            //        #endregion
            //        #region 包装
            //        bhd.BZ_czy3 = this.tbcz21.Text;
            //        bool result3;
            //        result3 = yhbll.Exist(this.tbcz21.Text);

            //        if (this.tbcz21.Text == "")
            //        {
            //            this.tbcz21.Text = "0";
            //        }
            //        else if (result3 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname21.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh3 = yhbll.GetModel(this.tbcz21.Text);
            //            this.tbname21.Text = yh3.姓名;
            //            bhd.BZ_czyname3 = this.tbname21.Text;
            //        }

            //        #endregion
            //        #region 包装
            //        bhd.BZ_czy4 = this.tbcz22.Text;
            //        bool result4;
            //        result4 = yhbll.Exist(this.tbcz22.Text);

            //        if (this.tbcz22.Text == "")
            //        {
            //            this.tbcz22.Text = "0";
            //        }
            //        else if (result4 != true)
            //        {
            //            //rg.ShowDialog();
            //            this.tbname22.Text = "";
            //            return;
            //        }
            //        else
            //        {
            //            var yh4 = yhbll.GetModel(this.tbcz22.Text);
            //            this.tbname22.Text = yh4.姓名;
            //            bhd.BZ_czyname4 = this.tbname22.Text;
            //        }
            //        #endregion
            //    }
            //}
            //if (yh.机构 == "备料")
            //{
            //    #region 备料
            //    bhd.bl_czy1 = this.tbczy1.Text;
            //    bool result1;
            //    result1 = yhbll.Exist(this.tbczy1.Text);
            //    if (this.tbczy1.Text == "")
            //    {
            //        this.tbczy1.Text = "0";
            //    }
            //    else if (result1 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbczName1.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh1 = yhbll.GetModel(this.tbczy1.Text);
            //        this.tbczName1.Text = yh1.姓名;
            //        bhd.bl_czyname1 = this.tbczName1.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "LD耦合焊接")
            //{
            //    #region LD耦合焊接
            //    bhd.LD_czy1 = this.tbcz1.Text;
            //    bool result1;
            //    result1 = yhbll.Exist(this.tbcz1.Text);
            //    if (this.tbcz1.Text == "")
            //    {
            //        this.tbcz1.Text = "0";
            //    }
            //    else if (result1 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname1.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh1 = yhbll.GetModel(this.tbcz1.Text);
            //        this.tbname1.Text = yh1.姓名;
            //        bhd.LD_czyname1 = this.tbname1.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "PT耦合固化")
            //{
            //    #region PT耦合固化
            //    bhd.PT_czy1 = this.tbcz5.Text;
            //    bool result1;
            //    result1 = yhbll.Exist(this.tbcz5.Text);
            //    if (this.tbcz5.Text == "")
            //    {
            //        this.tbcz5.Text = "0";
            //    }
            //    else if (result1 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname5.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh1 = yhbll.GetModel(this.tbcz5.Text);
            //        this.tbname5.Text = yh1.姓名;
            //        bhd.PT_czyname1 = this.tbname5.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "温循前")
            //{
            //    #region 温循前
            //    bhd.WXQ_czy = this.tbcz9.Text;
            //    bool result1;
            //    result1 = yhbll.Exist(this.tbcz9.Text);
            //    if (this.tbcz9.Text == "")
            //    {
            //        this.tbcz9.Text = "0";
            //    }
            //    else if (result1 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname9.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh1 = yhbll.GetModel(this.tbcz9.Text);
            //        this.tbname9.Text = yh1.姓名;
            //        bhd.WXQ_czyname = this.tbname9.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "温循后")
            //{
            //    #region 温循后
            //    bhd.WXH_czy = this.tbcz10.Text;
            //    bool result1;
            //    result1 = yhbll.Exist(this.tbcz10.Text);

            //    if (this.tbcz10.Text == "")
            //    {
            //        this.tbcz10.Text = "0";
            //    }
            //    else if (result1 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname10.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh1 = yhbll.GetModel(this.tbcz10.Text);
            //        this.tbname10.Text = yh1.姓名;
            //        bhd.WXH_czyname = this.tbname10.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "测试")
            //{
            //    #region 测试
            //    bhd.CS_czy1 = this.tbcz11.Text;
            //    bool result1;
            //    result1 = yhbll.Exist(this.tbcz11.Text);
            //    if (this.tbcz11.Text == "")
            //    {
            //        this.tbcz11.Text = "0";
            //    }
            //    else if (result1 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname11.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh1 = yhbll.GetModel(this.tbcz11.Text);
            //        this.tbname11.Text = yh1.姓名;
            //        bhd.CS_czyname1 = this.tbname11.Text;
            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "清洗")
            //{
            //    #region 清洗
            //    bhd.QX_czy1 = this.tbcz15.Text;
            //    bool result1;
            //    result1 = yhbll.Exist(this.tbcz15.Text);
            //    if (this.tbcz15.Text == "")
            //    {
            //        this.tbcz15.Text = "0";
            //    }
            //    else if (result1 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname15.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh1 = yhbll.GetModel(this.tbcz15.Text);
            //        this.tbname15.Text = yh1.姓名;
            //        bhd.QX_czyname1 = this.tbname15.Text;
            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "包装")
            //{
            //    #region 包装
            //    bhd.BZ_czy1 = this.tbcz19.Text;
            //    bool result1;
            //    result1 = yhbll.Exist(this.tbcz19.Text);
            //    if (this.tbcz19.Text == "")
            //    {
            //        this.tbcz19.Text = "0";
            //    }
            //    else if (result1 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname19.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh1 = yhbll.GetModel(this.tbcz19.Text);
            //        this.tbname19.Text = yh1.姓名;
            //        bhd.BZ_czyname1 = this.tbname19.Text;
            //    }
            //    #endregion

            //}
            #endregion
        }

        private void tbczy2_MouseUp(object sender, MouseEventArgs e)
        {
            tsuhan_sg_tx bhd = new tsuhan_sg_tx();
            //var name = Convert.ToInt32(gh);;
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);
            //if (yh.机构 == "全部")
            //{
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    
                    #region 备料
                    bhd.bl_czy2 = this.tbczy2.Text;
                    bool result2;
                    result2 = yhbll.Exist(this.tbczy2.Text);

                    if (this.tbczy2.Text == "")
                    {
                        this.tbczy2.Text = "0";
                    }
                    else if (result2 != true)
                    {
                        //rg.ShowDialog();
                        this.tbczName2.Text = "";
                        return;
                    }
                    else
                    {
                        var yh2 = yhbll.GetModel(this.tbczy2.Text);
                        this.tbczName2.Text = yh2.姓名;
                        bhd.bl_czyname2 = this.tbczName2.Text;

                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage2)
                {
                    #region LD耦合焊接
                    bhd.LD_czy2 = this.tbcz2.Text;
                    bool result2;
                    result2 = yhbll.Exist(this.tbcz2.Text);

                    if (this.tbcz2.Text == "")
                    {
                        this.tbcz2.Text = "0";
                    }
                    else if (result2 != true)
                    {
                        this.tbname2.Text = "";
                        return;
                    }
                    else
                    {
                        var yh2 = yhbll.GetModel(this.tbcz2.Text);
                        this.tbname2.Text = yh2.姓名;
                        bhd.LD_czyname1 = this.tbname1.Text;

                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage3)
                {
                    #region PT耦合固化
                    bhd.PT_czy2 = this.tbcz6.Text;
                    bool result2;
                    result2 = yhbll.Exist(this.tbcz6.Text);

                    if (this.tbcz6.Text == "")
                    {
                        this.tbcz6.Text = "0";
                    }
                    else if (result2 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname6.Text = "";
                        return;
                    }
                    else
                    {
                        var yh2 = yhbll.GetModel(this.tbcz6.Text);
                        this.tbname6.Text = yh2.姓名;
                        bhd.PT_czyname2 = this.tbname6.Text;

                    }

                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage6)
                {
                    #region 测试
                    bhd.CS_czy2 = this.tbcz12.Text;
                    bool result2;
                    result2 = yhbll.Exist(this.tbcz12.Text);

                    if (this.tbcz12.Text == "")
                    {
                        this.tbcz12.Text = "0";
                    }
                    else if (result2 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname12.Text = "";
                        return;
                    }
                    else
                    {
                        var yh2 = yhbll.GetModel(this.tbcz12.Text);
                        this.tbname12.Text = yh2.姓名;
                        bhd.CS_czyname2 = this.tbname12.Text;
                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage7)
                {
                    #region 清洗
                    bhd.QX_czy2 = this.tbcz16.Text;
                    bool result2;
                    result2 = yhbll.Exist(this.tbcz16.Text);
                    if (this.tbcz16.Text == "")
                    {
                        this.tbcz16.Text = "0";
                    }
                    else if (result2 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname16.Text = "";
                        return;
                    }
                    else
                    {
                        var yh2 = yhbll.GetModel(this.tbcz16.Text);
                        this.tbname16.Text = yh2.姓名;
                        bhd.QX_czyname2 = this.tbname16.Text;
                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage8)
                {
                    #region 包装
                    bhd.BZ_czy2 = this.tbcz20.Text;
                    bool result2;
                    result2 = yhbll.Exist(this.tbcz20.Text);

                    if (this.tbcz20.Text == "")
                    {
                        this.tbcz20.Text = "0";
                    }
                    else if (result2 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname20.Text = "";
                        return;
                    }
                    else
                    {
                        var yh2 = yhbll.GetModel(this.tbcz20.Text);
                        this.tbname20.Text = yh2.姓名;
                        bhd.BZ_czyname2 = this.tbname20.Text;
                    }
                    #endregion
                }
            //}
            //if (yh.机构 == "备料")
            //{
            //    #region 备料
            //    bhd.bl_czy2 = this.tbczy2.Text;
            //    bool result2;
            //    result2 = yhbll.Exist(this.tbczy2.Text);
            //    if (this.tbczy2.Text == "")
            //    {
            //        this.tbczy2.Text = "0";
            //    }
            //    else if (result2 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbczName2.Text = "";
            //        this.tbczy2.Text = "0";
            //        return;
            //    }
            //    else
            //    {
            //        var yh2 = yhbll.GetModel(this.tbczy2.Text);
            //        this.tbczName2.Text = yh2.姓名;
            //        bhd.bl_czyname2 = this.tbczName2.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "LD耦合焊接")
            //{
            //    #region LD耦合焊接
            //    bhd.LD_czy2 = this.tbcz2.Text;
            //    bool result2;
            //    result2 = yhbll.Exist(this.tbcz2.Text);

            //    if (this.tbcz2.Text == "")
            //    {
            //        this.tbcz2.Text = "0";
            //    }
            //    else if (result2 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbcz2.Text = "0";
            //        this.tbname2.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh2 = yhbll.GetModel(this.tbcz2.Text);
            //        this.tbname2.Text = yh2.姓名;
            //        bhd.LD_czyname2 = this.tbname2.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "PT耦合固化")
            //{
            //    #region PT耦合固化
            //    bhd.PT_czy2 = this.tbcz6.Text;
            //    bool result2;
            //    result2 = yhbll.Exist(this.tbcz6.Text);

            //    if (this.tbcz6.Text == "")
            //    {
            //        this.tbcz6.Text = "0";
            //    }
            //    else if (result2 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname6.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh2 = yhbll.GetModel(this.tbcz6.Text);
            //        this.tbname6.Text = yh2.姓名;
            //        bhd.PT_czyname2 = this.tbname6.Text;

            //    }

            //    #endregion
            //}
            //else if (yh.机构 == "测试")
            //{
            //    #region 测试
            //    bhd.CS_czy2 = this.tbcz12.Text;
            //    bool result2;
            //    result2 = yhbll.Exist(this.tbcz12.Text);

            //    if (this.tbcz12.Text == "")
            //    {
            //        this.tbcz12.Text = "0";
            //    }
            //    else if (result2 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname12.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh2 = yhbll.GetModel(this.tbcz12.Text);
            //        this.tbname12.Text = yh2.姓名;
            //        bhd.CS_czyname2 = this.tbname12.Text;
            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "清洗")
            //{
            //    #region 清洗
            //    bhd.QX_czy2 = this.tbcz16.Text;
            //    bool result2;
            //    result2 = yhbll.Exist(this.tbcz16.Text);
            //    if (this.tbcz16.Text == "")
            //    {
            //        this.tbcz16.Text = "0";
            //    }
            //    else if (result2 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname16.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh2 = yhbll.GetModel(this.tbcz16.Text);
            //        this.tbname16.Text = yh2.姓名;
            //        bhd.QX_czyname2 = this.tbname16.Text;
            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "包装")
            //{
            //    #region 包装
            //    bhd.BZ_czy2 = this.tbcz20.Text;
            //    bool result2;
            //    result2 = yhbll.Exist(this.tbcz20.Text);

            //    if (this.tbcz20.Text == "")
            //    {
            //        this.tbcz20.Text = "0";
            //    }
            //    else if (result2 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname20.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh2 = yhbll.GetModel(this.tbcz20.Text);
            //        this.tbname20.Text = yh2.姓名;
            //        bhd.BZ_czyname2 = this.tbname20.Text;
            //    }
            //    #endregion

            //}
           
        }

        private void tbczy3_MouseUp(object sender, MouseEventArgs e)
        {
            tsuhan_sg_tx bhd = new tsuhan_sg_tx();
            //var name = Convert.ToInt32(gh);
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);
            //if (yh.机构 == "全部")
            //{
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    #region 备料
                    bhd.bl_czy3 = this.tbczy3.Text;
                    bool result3;
                    result3 = yhbll.Exist(this.tbczy3.Text);

                    if (this.tbczy3.Text == "")
                    {
                        this.tbczy3.Text = "0";
                    }
                    else if (result3 != true)
                    {
                        //rg.ShowDialog();
                        this.tbczName3.Text = "";
                        return;
                    }
                    else
                    {
                        var yh3 = yhbll.GetModel(this.tbczy3.Text);
                        this.tbczName3.Text = yh3.姓名;
                        bhd.bl_czyname3 = this.tbczName3.Text;

                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage2)
                {
                    #region LD耦合焊接
                    bhd.LD_czy3 = this.tbcz3.Text;
                    bool result3;
                    result3 = yhbll.Exist(this.tbcz3.Text);

                    if (this.tbcz3.Text == "")
                    {
                        this.tbcz3.Text = "0";
                    }
                    else if (result3 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname3.Text = "";
                        return;
                    }
                    else
                    {
                        var yh3 = yhbll.GetModel(this.tbcz3.Text);
                        this.tbname3.Text = yh3.姓名;
                        bhd.LD_czyname2 = this.tbname2.Text;

                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage3)
                {
                    #region PT耦合固化
                    bhd.PT_czy3 = this.tbcz7.Text;
                    bool result3;
                    result3 = yhbll.Exist(this.tbcz7.Text);

                    if (this.tbcz7.Text == "")
                    {
                        this.tbcz7.Text = "0";
                    }
                    else if (result3 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname7.Text = "";
                        return;
                    }
                    else
                    {
                        var yh3 = yhbll.GetModel(this.tbcz7.Text);
                        this.tbname7.Text = yh3.姓名;
                        bhd.PT_czyname3 = this.tbname7.Text;

                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage6)
                {
                    #region 测试
                    bhd.CS_czy3 = this.tbcz13.Text;
                    bool result3;
                    result3 = yhbll.Exist(this.tbcz13.Text);

                    if (this.tbcz13.Text == "")
                    {
                        this.tbcz13.Text = "0";
                    }
                    else if (result3 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname13.Text = "";
                        return;
                    }
                    else
                    {
                        var yh3 = yhbll.GetModel(this.tbcz13.Text);
                        this.tbname13.Text = yh3.姓名;
                        bhd.CS_czyname3 = this.tbname13.Text;
                    }

                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage7)
                {
                    #region 清洗
                    bhd.QX_czy3 = this.tbcz17.Text;
                    bool result3;
                    result3 = yhbll.Exist(this.tbcz17.Text);

                    if (this.tbcz17.Text == "")
                    {
                        this.tbcz17.Text = "0";
                    }
                    else if (result3 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname17.Text = "";
                        return;
                    }
                    else
                    {
                        var yh3 = yhbll.GetModel(this.tbcz17.Text);
                        this.tbname17.Text = yh3.姓名;
                        bhd.QX_czyname3 = this.tbname17.Text;
                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage8)
                {
                    #region 包装
                    bhd.BZ_czy2 = this.tbcz21.Text;
                    bool result2;
                    result2 = yhbll.Exist(this.tbcz21.Text);

                    if (this.tbcz21.Text == "")
                    {
                        this.tbcz21.Text = "0";
                    }
                    else if (result2 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname21.Text = "";
                        return;
                    }
                    else
                    {
                        var yh2 = yhbll.GetModel(this.tbcz21.Text);
                        this.tbname21.Text = yh2.姓名;
                        bhd.BZ_czyname2 = this.tbname21.Text;
                    }
                    #endregion
                }
            //}
            //if (yh.机构 == "备料")
            //{
            //    #region 备料
            //    bhd.bl_czy3 = this.tbczy3.Text;
            //    bool result3;
            //    result3 = yhbll.Exist(this.tbczy3.Text);

            //    if (this.tbczy3.Text == "")
            //    {
            //        this.tbczy3.Text = "0";
            //    }
            //    else if (result3 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbczName3.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh3 = yhbll.GetModel(this.tbczy3.Text);
            //        this.tbczName3.Text = yh3.姓名;
            //        bhd.bl_czyname3 = this.tbczName3.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "LD耦合焊接")
            //{
            //    #region LD耦合焊接
            //    bhd.LD_czy3 = this.tbcz3.Text;
            //    bool result3;
            //    result3 = yhbll.Exist(this.tbcz3.Text);

            //    if (this.tbcz3.Text == "")
            //    {
            //        this.tbcz3.Text = "0";
            //    }
            //    else if (result3 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname3.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh3 = yhbll.GetModel(this.tbcz3.Text);
            //        this.tbname3.Text = yh3.姓名;
            //        bhd.LD_czyname3 = this.tbname3.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "PT耦合固化")
            //{
            //    #region PT耦合固化
            //    bhd.PT_czy3 = this.tbcz7.Text;
            //    bool result3;
            //    result3 = yhbll.Exist(this.tbcz7.Text);

            //    if (this.tbcz7.Text == "")
            //    {
            //        this.tbcz7.Text = "0";
            //    }
            //    else if (result3 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname7.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh3 = yhbll.GetModel(this.tbcz7.Text);
            //        this.tbname7.Text = yh3.姓名;
            //        bhd.PT_czyname3 = this.tbname7.Text;

            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "测试")
            //{
            //    #region 测试
            //    bhd.CS_czy3 = this.tbcz13.Text;
            //    bool result3;
            //    result3 = yhbll.Exist(this.tbcz13.Text);

            //    if (this.tbcz13.Text == "")
            //    {
            //        this.tbcz13.Text = "0";
            //    }
            //    else if (result3 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname13.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh3 = yhbll.GetModel(this.tbcz13.Text);
            //        this.tbname13.Text = yh3.姓名;
            //        bhd.CS_czyname3 = this.tbname13.Text;
            //    }

            //    #endregion
            //}
            //else if (yh.机构 == "清洗")
            //{
            //    #region 清洗
            //    bhd.QX_czy3 = this.tbcz17.Text;
            //    bool result3;
            //    result3 = yhbll.Exist(this.tbcz17.Text);

            //    if (this.tbcz17.Text == "")
            //    {
            //        this.tbcz17.Text = "0";
            //    }
            //    else if (result3 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname17.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh3 = yhbll.GetModel(this.tbcz17.Text);
            //        this.tbname17.Text = yh3.姓名;
            //        bhd.QX_czyname3 = this.tbname17.Text;
            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "包装")
            //{
            //    #region 包装
            //    bhd.BZ_czy3 = this.tbcz21.Text;
            //    bool result3;
            //    result3 = yhbll.Exist(this.tbcz21.Text);

            //    if (this.tbcz21.Text == "")
            //    {
            //        this.tbcz21.Text = "0";
            //    }
            //    else if (result3 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname21.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh3 = yhbll.GetModel(this.tbcz21.Text);
            //        this.tbname21.Text = yh3.姓名;
            //        bhd.BZ_czyname3 = this.tbname21.Text;
            //    }

            //    #endregion

            //}
        }

        private void tbczy4_MouseUp(object sender, MouseEventArgs e)
        {

            tsuhan_sg_tx bhd = new tsuhan_sg_tx();
            var name =Convert.ToInt32(gh);
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);
            //if (yh.机构 == "全部")
            //{
                if (this.tabControl1.SelectedTab == tabPage1)
                {
                    #region 备料
                    bhd.bl_czy4 = this.tbczy4.Text;
                    bool result4;
                    var t = this.tbczy4.Text;
                    result4 = yhbll.Exist(t);
                    if (this.tbczy4.Text == "")
                    {
                        this.tbczy4.Text = "0";
                    }
                    else if (result4 != true)
                    {
                        //rg.ShowDialog();
                        this.tbczName4.Text = "";
                        return;
                    }
                    else
                    {
                        var yh4 = yhbll.GetModel(this.tbczy4.Text);
                        this.tbczName4.Text = yh4.姓名;
                        bhd.bl_czyname4 = this.tbczName4.Text;
                    }

                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage2)
                {
                    #region LD耦合焊接
                    bhd.LD_czy4 = this.tbcz4.Text;
                    bool result4;
                    result4 = yhbll.Exist(this.tbcz4.Text);
                    if (this.tbcz4.Text == "")
                    {
                        this.tbcz4.Text = "0";
                    }
                    else if (result4 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname4.Text = "";
                        return;
                    }
                    else
                    {
                        var yh4 = yhbll.GetModel(this.tbcz4.Text);
                        this.tbname4.Text = yh4.姓名;
                        bhd.LD_czyname3 = this.tbname3.Text;
                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage3)
                {
                    #region PT耦合固化
                    bhd.PT_czy4 = this.tbcz8.Text;
                    bool result4;
                    result4 = yhbll.Exist(this.tbcz8.Text);

                    if (this.tbcz8.Text == "")
                    {
                        this.tbcz8.Text = "0";
                    }
                    else if (result4 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname8.Text = "";
                        return;
                    }
                    else
                    {
                        var yh4 = yhbll.GetModel(this.tbcz8.Text);
                        this.tbname8.Text = yh4.姓名;
                        bhd.PT_czyname4 = this.tbname8.Text;
                    }

                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage6)
                {
                    #region 测试
                    bhd.CS_czy4 = this.tbcz14.Text;
                    bool result4;
                    result4 = yhbll.Exist(this.tbcz14.Text);

                    if (this.tbcz14.Text == "")
                    {
                        this.tbcz14.Text = "0";
                    }
                    else if (result4 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname14.Text = "";
                        return;
                    }
                    else
                    {
                        var yh4 = yhbll.GetModel(this.tbcz14.Text);
                        this.tbname14.Text = yh4.姓名;
                        bhd.CS_czyname4 = this.tbname14.Text;
                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage7)
                {
                    #region 清洗
                    bhd.QX_czy4 = this.tbcz18.Text;
                    bool result4;
                    result4 = yhbll.Exist(this.tbcz18.Text);


                    if (this.tbcz18.Text == "")
                    {
                        this.tbcz18.Text = "0";
                    }
                    else if (result4 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname18.Text = "";
                        return;
                    }
                    else
                    {
                        var yh4 = yhbll.GetModel(this.tbcz18.Text);
                        this.tbname18.Text = yh4.姓名;
                        bhd.QX_czyname4 = this.tbname18.Text;
                    }
                    #endregion
                }
                else if (this.tabControl1.SelectedTab == tabPage8)
                {
                    #region 包装
                    bhd.BZ_czy4 = this.tbcz22.Text;
                    bool result4;
                    result4 = yhbll.Exist(this.tbcz22.Text);

                    if (this.tbcz22.Text == "")
                    {
                        this.tbcz22.Text = "0";
                    }
                    else if (result4 != true)
                    {
                        //rg.ShowDialog();
                        this.tbname22.Text = "";
                        return;
                    }
                    else
                    {
                        var yh4 = yhbll.GetModel(this.tbcz22.Text);
                        this.tbname22.Text = yh4.姓名;
                        bhd.BZ_czyname4 = this.tbname22.Text;
                    }
                    #endregion
                }
            //}
            //if (yh.机构 == "备料")
            //{
            //    #region 备料
            //    bhd.bl_czy4 = this.tbczy4.Text;
            //    bool result4;
            //    result4 = yhbll.Exist(this.tbczy4.Text);
            //    if (this.tbczy4.Text == "")
            //    {
            //        this.tbczy4.Text = "0";
            //    }
            //    else if (result4 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbczName4.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh4 = yhbll.GetModel(this.tbczy4.Text);
            //        this.tbczName4.Text = yh4.姓名;
            //        bhd.bl_czyname4 = this.tbczName4.Text;
            //    }

            //    #endregion
            //}
            //else if (yh.机构 == "LD耦合焊接")
            //{
            //    #region LD耦合焊接
            //    bhd.LD_czy4 = this.tbcz4.Text;
            //    bool result4;
            //    result4 = yhbll.Exist(this.tbcz4.Text);
            //    if (this.tbcz4.Text == "")
            //    {
            //        this.tbcz4.Text = "0";
            //    }
            //    else if (result4 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname4.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh4 = yhbll.GetModel(this.tbcz4.Text);
            //        this.tbname4.Text = yh4.姓名;
            //        bhd.LD_czyname4 = this.tbname4.Text;
            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "PT耦合固化")
            //{
            //    #region PT耦合固化
            //    bhd.PT_czy4 = this.tbcz8.Text;
            //    bool result4;
            //    result4 = yhbll.Exist(this.tbcz8.Text);

            //    if (this.tbcz8.Text == "")
            //    {
            //        this.tbcz8.Text = "0";
            //    }
            //    else if (result4 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname8.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh4 = yhbll.GetModel(this.tbcz8.Text);
            //        this.tbname8.Text = yh4.姓名;
            //        bhd.PT_czyname4 = this.tbname8.Text;
            //    }

            //    #endregion
            //}
            //else if (yh.机构 == "测试")
            //{
            //    #region 测试
            //    bhd.CS_czy4 = this.tbcz14.Text;
            //    bool result4;
            //    result4 = yhbll.Exist(this.tbcz14.Text);

            //    if (this.tbcz14.Text == "")
            //    {
            //        this.tbcz14.Text = "0";
            //    }
            //    else if (result4 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname14.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh4 = yhbll.GetModel(this.tbcz14.Text);
            //        this.tbname14.Text = yh4.姓名;
            //        bhd.CS_czyname4 = this.tbname14.Text;
            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "清洗")
            //{
            //    #region 清洗
            //    bhd.QX_czy4 = this.tbcz18.Text;
            //    bool result4;
            //    result4 = yhbll.Exist(this.tbcz18.Text);


            //    if (this.tbcz18.Text == "")
            //    {
            //        this.tbcz18.Text = "0";
            //    }
            //    else if (result4 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname18.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh4 = yhbll.GetModel(this.tbcz18.Text);
            //        this.tbname18.Text = yh4.姓名;
            //        bhd.QX_czyname4 = this.tbname18.Text;
            //    }
            //    #endregion
            //}
            //else if (yh.机构 == "包装")
            //{
            //    #region 包装
            //    bhd.BZ_czy4 = this.tbcz22.Text;
            //    bool result4;
            //    result4 = yhbll.Exist(this.tbcz22.Text);

            //    if (this.tbcz22.Text == "")
            //    {
            //        this.tbcz22.Text = "0";
            //    }
            //    else if (result4 != true)
            //    {
            //        rg.ShowDialog();
            //        this.tbname22.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        var yh4 = yhbll.GetModel(this.tbcz22.Text);
            //        this.tbname22.Text = yh4.姓名;
            //        bhd.BZ_czyname4 = this.tbname22.Text;
            //    }
            //    #endregion

            //}
        }

        private void tblry_MouseUp(object sender, MouseEventArgs e)
        {
            tsuhan_sg_tx bhd = new tsuhan_sg_tx();
            //var name = Convert.ToInt32(gh);
            tsuhan_scgl_yh yh = yhbll.GetModel(gh);

            if (this.tabControl1.SelectedTab == tabPage1)
            {
                #region 备料
                bhd.bl_lry = this.tblry.Text;
                bool result5;
                result5 = yhbll.Exist(this.tblry.Text);
                if (this.tblry.Text == "")
                {
                    this.tblry.Text = "0";
                }
                else if (result5 != true)
                {
                    //rg.ShowDialog();
                    this.tblrName.Text = "";

                    return;
                }
                else
                {
                    var yh5 = yhbll.GetModel(this.tblry.Text);
                    this.tblrName.Text = yh5.姓名;
                    bhd.bl_lry = this.tblrName.Text;
                }

                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage2)
            {
                #region LD耦合焊接
                bhd.LD_lry = this.tblr1.Text;
                bool result5;
                result5 = yhbll.Exist(this.tblr1.Text);
                if (this.tblr1.Text == "")
                {
                    this.tblr1.Text = "0";
                }
                else if (result5 != true)
                {
                    this.tblrname1.Text = "";
                    return;
                }
                else
                {
                    var yh5 = yhbll.GetModel(this.tblr1.Text);
                    this.tblrname1.Text = yh5.姓名;
                    bhd.LD_lryname = this.tblrname1.Text;
                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage3)
            {
                #region PT耦合固化
                bhd.PT_lry = this.tblr2.Text;
                bool result5;
                result5 = yhbll.Exist(this.tblr2.Text);

                if (this.tblr2.Text == "")
                {
                    this.tblr2.Text = "0";
                }
                else if (result5 != true)
                {
                    //rg.ShowDialog();
                    this.tblrname2.Text = "";
                    return;
                }
                else
                {
                    var yh5 = yhbll.GetModel(this.tblr2.Text);
                    this.tblrname2.Text = yh5.姓名;
                    bhd.PT_lryname = this.tblrname2.Text;
                }

                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage4)
            {
                #region 温循前
                bhd.WXQ_lry = this.tblr3.Text;
                bool result2;
                result2 = yhbll.Exist(this.tblr3.Text);
                if (this.tblr3.Text == "")
                {
                    this.tblr3.Text = "0";
                }
                else if (result2 != true)
                {
                    //rg.ShowDialog();
                    this.tblrname3.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tblr3.Text);
                    this.tblrname3.Text = yh1.姓名;
                    bhd.WXQ_lryname = this.tblrname3.Text;

                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage5)
            {
                #region 温循后
                bhd.WX_Hlry = this.tblr4.Text;
                bool result2;
                result2 = yhbll.Exist(this.tblr4.Text);

                if (this.tblr4.Text == "")
                {
                    this.tblr4.Text = "0";
                }
                else if (result2 != true)
                {
                    //rg.ShowDialog();
                    this.tblrname4.Text = "";
                    return;
                }
                else
                {
                    var yh1 = yhbll.GetModel(this.tblr4.Text);
                    this.tblrname4.Text = yh1.姓名;
                    bhd.WXH_czyname = this.tblrname4.Text;

                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage6)
            {
                #region 测试
                bhd.CS_lry = this.tblr5.Text;
                bool result5;
                result5 = yhbll.Exist(this.tblr5.Text);

                if (this.tblr5.Text == "")
                {
                    this.tblr5.Text = "0";
                }
                else if (result5 != true)
                {
                    //rg.ShowDialog();
                    this.tblrname5.Text = "";
                    return;
                }
                else
                {
                    var yh4 = yhbll.GetModel(this.tblr5.Text);
                    this.tblrname5.Text = yh4.姓名;
                    bhd.CS_czyname4 = this.tblrname5.Text;
                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage7)
            {
                #region 清洗
                bhd.QX_lry = this.tblr6.Text;
                bool result5;
                result5 = yhbll.Exist(this.tblr6.Text);


                if (this.tblr6.Text == "")
                {
                    this.tblr6.Text = "0";
                }
                else if (result5 != true)
                {
                    //rg.ShowDialog();
                    this.tblrname6.Text = "";
                    return;
                }
                else
                {
                    var yh4 = yhbll.GetModel(this.tblr6.Text);
                    this.tblrname6.Text = yh4.姓名;
                    bhd.QX_lryname = this.tblrname6.Text;
                }
                #endregion
            }
            else if (this.tabControl1.SelectedTab == tabPage8)
            {
                #region 包装
                bhd.BZ_lry = this.tblr7.Text;
                bool result5;
                result5 = yhbll.Exist(this.tblr7.Text);

                if (this.tblr7.Text == "")
                {
                    this.tblr7.Text = "0";
                }
                else if (result5 != true)
                {
                    //rg.ShowDialog();
                    this.tblrname7.Text = "";
                    return;
                }
                else
                {
                    var yh4 = yhbll.GetModel(this.tblr7.Text);
                    this.tblrname7.Text = yh4.姓名;
                    bhd.BZ_lryname = this.tblrname7.Text;
                }
                #endregion
            }
        }


    }
}
