using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tsuhan_sg_gt:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tsuhan_sg_gt
	{
		public tsuhan_sg_gt()
		{}
        #region Model
        private int? _id;
		private string _备货单号;
		private DateTime? _交货日期;
		private DateTime? _下单日期;
		private string _表格编号;
		private string _合同编号;
		private string _规格书编号;
		private string _产品名称;
		private int? _备货单数量;
		private int? _随工卡数量;
		private string _产品图号;
		private string _产品类型;
        private string _成品编码;
		private string _bk_a;
		private string _bk_b;
		private string _bk_c;
		private decimal? _ld_ldjj;
		private string _gx_hjfs;
		private decimal? _oh_hqpomin;
		private decimal? _oh_hqpomax;
		private int? _oh_hqbfb;
		private decimal? _oh_hhpomin;
		private decimal? _oh_hhpomax;
		private int? _oh_hhbfb;
		private string _dm_dmzl;
		private int? _pt_rqgl;
		private string _pt_gdlmin;
        private string _pt_gdlmax;
		private int? _gdw_xhcs;
		private decimal? _ld_cspomin;
		private decimal? _ld_cspomax;
		private int? _ld_csbfb;
		private int? _ld_ldkink;
		private int? _ld_pdkink;
		private string _pt_cstj;
		private decimal? _pt_cspl;
		private string _pt_lmd;
		private string _pt_lmd2;
		private int? _pt_iccmin;
		private int? _pt_iccmax;
		private string _bz_qjbq;
		private string _gd_if;
		private decimal? _gd_ccglmin;
		private decimal? _gd_ccglmax;
		private int? _gd_imomin;
		private int? _gd_imomax;
		private int? _gd_ithmin;
		private int? _gd_ithmax;
		private decimal? _gd_vfmin;
		private decimal? _gd_vfmax;
        private string _gd_ptsl;
		private int? _gd_vbrmin;
		private int? _gd_vbrmax;
		private int? _jx_wdmin;
		private int? _jx_wdmax;
		private string _jx_zz;
		private string _jx_pthigh;
		private string _jx_ptwwj;
		private string _jx_ldgj;
		private string _jx_ptgj;
		private string _fh产品名称;
		private string _description;
		private string _物料代码;
		private string _型号属性;
		private string _specification;
		private string _客户型号;
		private string _ld芯片型号;
		private string _pt芯片型号;
		private string _quantity1;
		private string _quantity2;
		private string _数量;
		private string _计划编制;
		private string _技术审核;
		private string _生产审核;
		private string _录入员;
		private DateTime? _录入时间;
        private string _客户代码;
        private DateTime? _生产日期;


        /// <summary>
        /// 
        /// </summary>
        public int? id
        {
            set { _id = value; }
            get { return _id; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string 备货单号
		{
			set{ _备货单号=value;}
			get{return _备货单号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 交货日期
		{
			set{ _交货日期=value;}
			get{return _交货日期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 下单日期
		{
			set{ _下单日期=value;}
			get{return _下单日期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 表格编号
		{
			set{ _表格编号=value;}
			get{return _表格编号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 合同编号
		{
			set{ _合同编号=value;}
			get{return _合同编号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 规格书编号
		{
			set{ _规格书编号=value;}
			get{return _规格书编号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 产品名称
		{
			set{ _产品名称=value;}
			get{return _产品名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 备货单数量
		{
			set{ _备货单数量=value;}
			get{return _备货单数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 随工卡数量
		{
			set{ _随工卡数量=value;}
			get{return _随工卡数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 产品图号
		{
			set{ _产品图号=value;}
			get{return _产品图号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 产品类型
		{
			set{ _产品类型=value;}
			get{return _产品类型;}
		}
        /// <summary>
        /// 成品编码
        /// </summary>
        public string 成品编码
        {
            set { _成品编码 = value; }
            get { return _成品编码; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string BK_A
		{
			set{ _bk_a=value;}
			get{return _bk_a;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BK_B
		{
			set{ _bk_b=value;}
			get{return _bk_b;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BK_C
		{
			set{ _bk_c=value;}
			get{return _bk_c;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LD_LDjj
		{
			set{ _ld_ldjj=value;}
			get{return _ld_ldjj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GX_hjfs
		{
			set{ _gx_hjfs=value;}
			get{return _gx_hjfs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OH_hqPomin
		{
			set{ _oh_hqpomin=value;}
			get{return _oh_hqpomin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OH_hqPomax
		{
			set{ _oh_hqpomax=value;}
			get{return _oh_hqpomax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OH_hqBFB
		{
			set{ _oh_hqbfb=value;}
			get{return _oh_hqbfb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OH_hhPomin
		{
			set{ _oh_hhpomin=value;}
			get{return _oh_hhpomin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OH_hhPomax
		{
			set{ _oh_hhpomax=value;}
			get{return _oh_hhpomax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OH_hhBFB
		{
			set{ _oh_hhbfb=value;}
			get{return _oh_hhbfb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DM_dmzl
		{
			set{ _dm_dmzl=value;}
			get{return _dm_dmzl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PT_rqgl
		{
			set{ _pt_rqgl=value;}
			get{return _pt_rqgl;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string PT_gdlmin
		{
			set{ _pt_gdlmin=value;}
			get{return _pt_gdlmin;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string PT_gdlmax
		{
			set{ _pt_gdlmax=value;}
			get{return _pt_gdlmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GDW_xhcs
		{
			set{ _gdw_xhcs=value;}
			get{return _gdw_xhcs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LD_CSPomin
		{
			set{ _ld_cspomin=value;}
			get{return _ld_cspomin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LD_CSPomax
		{
			set{ _ld_cspomax=value;}
			get{return _ld_cspomax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LD_CSBFB
		{
			set{ _ld_csbfb=value;}
			get{return _ld_csbfb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LD_LDKINK
		{
			set{ _ld_ldkink=value;}
			get{return _ld_ldkink;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LD_PDKINK
		{
			set{ _ld_pdkink=value;}
			get{return _ld_pdkink;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_CStj
		{
			set{ _pt_cstj=value;}
			get{return _pt_cstj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PT_CSpl
		{
			set{ _pt_cspl=value;}
			get{return _pt_cspl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_LMd
		{
			set{ _pt_lmd=value;}
			get{return _pt_lmd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_LMd2
		{
			set{ _pt_lmd2=value;}
			get{return _pt_lmd2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PT_ICCmin
		{
			set{ _pt_iccmin=value;}
			get{return _pt_iccmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PT_ICCmax
		{
			set{ _pt_iccmax=value;}
			get{return _pt_iccmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_QJbq
		{
			set{ _bz_qjbq=value;}
			get{return _bz_qjbq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GD_if
		{
			set{ _gd_if=value;}
			get{return _gd_if;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GD_ccglMin
		{
			set{ _gd_ccglmin=value;}
			get{return _gd_ccglmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GD_ccglMax
		{
			set{ _gd_ccglmax=value;}
			get{return _gd_ccglmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GD_imoMin
		{
			set{ _gd_imomin=value;}
			get{return _gd_imomin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GD_imoMax
		{
			set{ _gd_imomax=value;}
			get{return _gd_imomax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GD_ithMin
		{
			set{ _gd_ithmin=value;}
			get{return _gd_ithmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GD_ithMax
		{
			set{ _gd_ithmax=value;}
			get{return _gd_ithmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GD_vfMin
		{
			set{ _gd_vfmin=value;}
			get{return _gd_vfmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GD_vfMax
		{
			set{ _gd_vfmax=value;}
			get{return _gd_vfmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GD_ptsl
		{
			set{ _gd_ptsl=value;}
			get{return _gd_ptsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GD_vbrMin
		{
			set{ _gd_vbrmin=value;}
			get{return _gd_vbrmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GD_vbrMax
		{
			set{ _gd_vbrmax=value;}
			get{return _gd_vbrmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? JX_wdMin
		{
			set{ _jx_wdmin=value;}
			get{return _jx_wdmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? JX_wdMax
		{
			set{ _jx_wdmax=value;}
			get{return _jx_wdmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JX_zz
		{
			set{ _jx_zz=value;}
			get{return _jx_zz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JX_pthigh
		{
			set{ _jx_pthigh=value;}
			get{return _jx_pthigh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JX_ptwwj
		{
			set{ _jx_ptwwj=value;}
			get{return _jx_ptwwj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JX_ldgj
		{
			set{ _jx_ldgj=value;}
			get{return _jx_ldgj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JX_ptgj
		{
			set{ _jx_ptgj=value;}
			get{return _jx_ptgj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fh产品名称
		{
			set{ _fh产品名称=value;}
			get{return _fh产品名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 物料代码
		{
			set{ _物料代码=value;}
			get{return _物料代码;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 型号属性
		{
			set{ _型号属性=value;}
			get{return _型号属性;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Specification
		{
			set{ _specification=value;}
			get{return _specification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 客户型号
		{
			set{ _客户型号=value;}
			get{return _客户型号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD芯片型号
		{
			set{ _ld芯片型号=value;}
			get{return _ld芯片型号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT芯片型号
		{
			set{ _pt芯片型号=value;}
			get{return _pt芯片型号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Quantity1
		{
			set{ _quantity1=value;}
			get{return _quantity1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Quantity2
		{
			set{ _quantity2=value;}
			get{return _quantity2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 数量
		{
			set{ _数量=value;}
			get{return _数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 计划编制
		{
			set{ _计划编制=value;}
			get{return _计划编制;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 技术审核
		{
			set{ _技术审核=value;}
			get{return _技术审核;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 生产审核
		{
			set{ _生产审核=value;}
			get{return _生产审核;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 录入员
		{
			set{ _录入员=value;}
			get{return _录入员;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 录入时间
		{
			set{ _录入时间=value;}
			get{return _录入时间;}
		}

        public string 客户代码
        {
            set { _客户代码 = value; }
            get { return _客户代码; }
        }

        public DateTime? 生产日期
        {
            set { _生产日期 = value; }
            get { return _生产日期; }
        }
		#endregion Model

	}
}

