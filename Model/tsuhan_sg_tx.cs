using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tsuhan_sg_tx:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tsuhan_sg_tx
	{
		public tsuhan_sg_tx()
		{}
		#region Model
        private int? _id;
		private string _随工单号;
		private string _备料;
		private string _bl_sbbh1;
		private string _bl_sbbh2;
		private string _bl_sbbh3;
		private string _bl_sbbh4;
		private int? _bl_xcsl;
		private DateTime? _bl_xctime;
		private string _bl_czy1;
		private string _bl_czy2;
		private string _bl_czy3;
		private string _bl_czy4;
		private string _bl_czyname1;
		private string _bl_czyname2;
		private string _bl_czyname3;
		private string _bl_czyname4;
		private string _bl_lry;
		private string _bl_lryname;
		private int? _bl_bhgallsl;
		private int? _blng1;
		private int? _blng2;
		private int? _blng3;
		private int? _blng4;
		private int? _blng5;
		private int? _blng6;
		private int? _blng7;
		private int? _blng8;
		private int? _blng9;
		private string _blngoth;
		private int? _blngothnum;
		private string _ld焊接;
		private string _ld_sbbh1;
		private string _ld_sbbh2;
		private string _ld_sbbh3;
		private string _ld_sbbh4;
		private int? _ld_sjsl;
		private int? _ld_xcsl;
		private DateTime? _ld_xctime;
		private string _ld_czy1;
		private string _ld_czy2;
		private string _ld_czy3;
		private string _ld_czy4;
		private string _ld_czyname1;
		private string _ld_czyname2;
		private string _ld_czyname3;
		private string _ld_czyname4;
		private string _ld_lry;
		private string _ld_lryname;
		private int? _ld_bhgallsl;
		private int? _ld_jzsl;
		private int? _ldng1;
		private int? _ldng2;
		private int? _ldng3;
		private int? _ldng4;
		private int? _ldng5;
		private int? _ldng6;
		private int? _ldng7;
		private int? _ldng8;
		private int? _ldng9;
		private string _ldngoth;
		private int? _ldngothnum;
		private string _pt耦合固化;
		private string _pt_sbbh1;
		private string _pt_sbbh2;
		private string _pt_sbbh3;
		private string _pt_sbbh4;
		private int? _pt_sjsl;
		private int? _pt_xcsl;
		private DateTime? _pt_xctime;
		private string _pt_czy1;
		private string _pt_czy2;
		private string _pt_czy3;
		private string _pt_czy4;
		private string _pt_czyname1;
		private string _pt_czyname2;
		private string _pt_czyname3;
		private string _pt_czyname4;
		private string _pt_lry;
		private string _pt_lryname;
		private int? _pt_bhgallsl;
		private string _pt_bhgyy;
		private int? _ptng1;
		private int? _ptng2;
		private int? _ptng3;
		private int? _ptng4;
		private int? _ptng5;
		private int? _ptng6;
		private int? _ptng7;
		private int? _ptng8;
		private int? _ptng9;
		private string _ptngoth;
		private int? _ptngothnum;
		private string _温循前;
		private string _wxq_sbbh;
		private int? _wxq_sjsl;
		private int? _wxq_frsl;
		private DateTime? _wxq_xctime;
		private string _wxq_czy;
		private string _wxq_czyname;
		private string _wxq_lry;
		private string _wxq_lryname;
		private string _wxq_remark;
		private string _温循后;
		private string _wxh_sbbh;
		private int? _wxh_qcsl;
		private int? _wxh_xcsl;
		private string _wxh_wxsc;
		private DateTime? _wxh_xctime;
		private string _wxh_czy;
		private string _wxh_czyname;
		private string _wx_hlry;
		private string _wxh_lryname;
		private string _wxh_remark;
		private string _测试;
		private string _cs_sbbh1;
		private string _cs_sbbh2;
		private string _cs_sbbh3;
		private string _cs_sbbh4;
		private int? _cs_sjsl;
		private int? _cs_xcsl;
		private DateTime? _cs_xctime;
		private string _cs_czy1;
		private string _cs_czy2;
		private string _cs_czy3;
		private string _cs_czy4;
		private string _cs_czyname1;
		private string _cs_czyname2;
		private string _cs_czyname3;
		private string _cs_czyname4;
		private string _cs_lry;
		private string _cs_lryname;
		private int? _cs_bhgallsl;
		private int? _csng1;
		private int? _csng2;
		private int? _csng3;
		private int? _csng4;
		private int? _csng5;
		private int? _csng6;
		private int? _csng7;
		private int? _csng8;
		private int? _csng9;
		private string _csngoth;
		private int? _csngothnum;
		private string _清洗;
		private string _qx_sbbh1;
		private string _qx_sbbh2;
		private string _qx_sbbh3;
		private string _qx_sbbh4;
		private int? _qx_sjsl;
		private int? _qx_xcsl;
		private DateTime? _qx_xctime;
		private string _qx_czy1;
		private string _qx_czy2;
		private string _qx_czy3;
		private string _qx_czy4;
		private string _qx_czyname1;
		private string _qx_czyname2;
		private string _qx_czyname3;
		private string _qx_czyname4;
		private string _qx_lry;
		private string _qx_lryname;
		private int? _qx_bhgallsl;
		private int? _qxng1;
		private string _qxngoth;
		private int? _qxngothnum;
		private string _包装;
		private string _bz_sbbh1;
		private string _bz_sbbh2;
		private string _bz_sbbh3;
		private string _bz_sbbh4;
		private int? _bz_sjsl;
		private int? _bz_xcsl;
		private DateTime? _bz_xctime;
		private string _bz_czy1;
		private string _bz_czy2;
		private string _bz_czy3;
		private string _bz_czy4;
		private string _bz_czyname1;
		private string _bz_czyname2;
		private string _bz_czyname3;
		private string _bz_czyname4;
		private string _bz_lry;
		private string _bz_lryname;
		private int? _bz_bhgallsl;
		private int? _bzng1;
		private string _bzngoth;
		private int? _bzngothnum;
		private string _gcsj_liushuih;
		private string _lsh1;
		private string _lsh2;
		private string _lsh3;
		private string _gcsj_case;
		private string _case1;
		private string _case2;
		private string _case3;
		private string _gcsj_ldjia;
		private string _ld1;
		private string _ld2;
		private string _ld3;
		private string _gcsj_pdjia;
		private string _pd1;
		private string _pd2;
		private string _pd3;
		private string _gcsj_ldjian;
		private string _ldj1;
		private string _ldj2;
		private string _ldj3;
		private string _gcsj_jicha;
		private decimal? _jc1;
		private decimal? _jc2;
		private decimal? _jc3;
		private string _gcsj_yatou;
		private string _yt1;
		private string _yt2;
		private string _yt3;
		private string _gcsj_oxianliang;
		private string _oxl1;
		private string _oxl2;
		private string _oxl3;
		private string _ldxp_xinpianjj;
		private string _ldxp_jianyanry;
		private string _ldxp_jianyansb;
		private int? _bggsum;
		private string _备注;
        private string _ld_lx;
        private string _ld_xh;
        private string _ld_name;
        private string _ld_sjdh;
        private string _ld_remark;
        private string _pt_lx;
        private string _pt_xh;
        private string _pt_name;
        private string _pt_sjdh;
        private string _pt_remark;
        private string _kt_lx;
        private string _kt_xh;
        private string _kt_name;
        private string _kt_sjdh;
        private string _kt_remark;
        private string _nbp_lx0;
        private string _nbp_xh0;
        private string _nbp_name0;
        private string _nbp_sjdh0;
        private string _nbp_remark0;
        private string _nbp_lx45;
        private string _nbp_xh45;
        private string _nbp_name45;
        private string _nbp_sjdh45;
        private string _nbp_remark45;
        private string _jk_lx;
        private string _jk_xh;
        private string _jk_name;
        private string _jk_sjdh;
        private string _jk_remark;

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
		public string 随工单号
		{
			set{ _随工单号=value;}
			get{return _随工单号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 备料
		{
			set{ _备料=value;}
			get{return _备料;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_sbbh1
		{
			set{ _bl_sbbh1=value;}
			get{return _bl_sbbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_sbbh2
		{
			set{ _bl_sbbh2=value;}
			get{return _bl_sbbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_sbbh3
		{
			set{ _bl_sbbh3=value;}
			get{return _bl_sbbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_sbbh4
		{
			set{ _bl_sbbh4=value;}
			get{return _bl_sbbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? bl_xcsl
		{
			set{ _bl_xcsl=value;}
			get{return _bl_xcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? bl_xctime
		{
			set{ _bl_xctime=value;}
			get{return _bl_xctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_czy1
		{
			set{ _bl_czy1=value;}
			get{return _bl_czy1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_czy2
		{
			set{ _bl_czy2=value;}
			get{return _bl_czy2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_czy3
		{
			set{ _bl_czy3=value;}
			get{return _bl_czy3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_czy4
		{
			set{ _bl_czy4=value;}
			get{return _bl_czy4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_czyname1
		{
			set{ _bl_czyname1=value;}
			get{return _bl_czyname1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_czyname2
		{
			set{ _bl_czyname2=value;}
			get{return _bl_czyname2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_czyname3
		{
			set{ _bl_czyname3=value;}
			get{return _bl_czyname3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_czyname4
		{
			set{ _bl_czyname4=value;}
			get{return _bl_czyname4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_lry
		{
			set{ _bl_lry=value;}
			get{return _bl_lry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bl_lryname
		{
			set{ _bl_lryname=value;}
			get{return _bl_lryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? bl_bhgallsl
		{
			set{ _bl_bhgallsl=value;}
			get{return _bl_bhgallsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng1
		{
			set{ _blng1=value;}
			get{return _blng1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng2
		{
			set{ _blng2=value;}
			get{return _blng2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng3
		{
			set{ _blng3=value;}
			get{return _blng3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng4
		{
			set{ _blng4=value;}
			get{return _blng4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng5
		{
			set{ _blng5=value;}
			get{return _blng5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng6
		{
			set{ _blng6=value;}
			get{return _blng6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng7
		{
			set{ _blng7=value;}
			get{return _blng7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng8
		{
			set{ _blng8=value;}
			get{return _blng8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blng9
		{
			set{ _blng9=value;}
			get{return _blng9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string blngoth
		{
			set{ _blngoth=value;}
			get{return _blngoth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blngothnum
		{
			set{ _blngothnum=value;}
			get{return _blngothnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD焊接
		{
			set{ _ld焊接=value;}
			get{return _ld焊接;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_sbbh1
		{
			set{ _ld_sbbh1=value;}
			get{return _ld_sbbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_sbbh2
		{
			set{ _ld_sbbh2=value;}
			get{return _ld_sbbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_sbbh3
		{
			set{ _ld_sbbh3=value;}
			get{return _ld_sbbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_sbbh4
		{
			set{ _ld_sbbh4=value;}
			get{return _ld_sbbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LD_sjsl
		{
			set{ _ld_sjsl=value;}
			get{return _ld_sjsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LD_xcsl
		{
			set{ _ld_xcsl=value;}
			get{return _ld_xcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LD_xctime
		{
			set{ _ld_xctime=value;}
			get{return _ld_xctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_czy1
		{
			set{ _ld_czy1=value;}
			get{return _ld_czy1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_czy2
		{
			set{ _ld_czy2=value;}
			get{return _ld_czy2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_czy3
		{
			set{ _ld_czy3=value;}
			get{return _ld_czy3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_czy4
		{
			set{ _ld_czy4=value;}
			get{return _ld_czy4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_czyname1
		{
			set{ _ld_czyname1=value;}
			get{return _ld_czyname1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_czyname2
		{
			set{ _ld_czyname2=value;}
			get{return _ld_czyname2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_czyname3
		{
			set{ _ld_czyname3=value;}
			get{return _ld_czyname3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_czyname4
		{
			set{ _ld_czyname4=value;}
			get{return _ld_czyname4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_lry
		{
			set{ _ld_lry=value;}
			get{return _ld_lry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LD_lryname
		{
			set{ _ld_lryname=value;}
			get{return _ld_lryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LD_bhgallsl
		{
			set{ _ld_bhgallsl=value;}
			get{return _ld_bhgallsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LD_jzsl
		{
			set{ _ld_jzsl=value;}
			get{return _ld_jzsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng1
		{
			set{ _ldng1=value;}
			get{return _ldng1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng2
		{
			set{ _ldng2=value;}
			get{return _ldng2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng3
		{
			set{ _ldng3=value;}
			get{return _ldng3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng4
		{
			set{ _ldng4=value;}
			get{return _ldng4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng5
		{
			set{ _ldng5=value;}
			get{return _ldng5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng6
		{
			set{ _ldng6=value;}
			get{return _ldng6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng7
		{
			set{ _ldng7=value;}
			get{return _ldng7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng8
		{
			set{ _ldng8=value;}
			get{return _ldng8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldng9
		{
			set{ _ldng9=value;}
			get{return _ldng9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ldngoth
		{
			set{ _ldngoth=value;}
			get{return _ldngoth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ldngothnum
		{
			set{ _ldngothnum=value;}
			get{return _ldngothnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT耦合固化
		{
			set{ _pt耦合固化=value;}
			get{return _pt耦合固化;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_sbbh1
		{
			set{ _pt_sbbh1=value;}
			get{return _pt_sbbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_sbbh2
		{
			set{ _pt_sbbh2=value;}
			get{return _pt_sbbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_sbbh3
		{
			set{ _pt_sbbh3=value;}
			get{return _pt_sbbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_sbbh4
		{
			set{ _pt_sbbh4=value;}
			get{return _pt_sbbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PT_sjsl
		{
			set{ _pt_sjsl=value;}
			get{return _pt_sjsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PT_xcsl
		{
			set{ _pt_xcsl=value;}
			get{return _pt_xcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PT_xctime
		{
			set{ _pt_xctime=value;}
			get{return _pt_xctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_czy1
		{
			set{ _pt_czy1=value;}
			get{return _pt_czy1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_czy2
		{
			set{ _pt_czy2=value;}
			get{return _pt_czy2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_czy3
		{
			set{ _pt_czy3=value;}
			get{return _pt_czy3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_czy4
		{
			set{ _pt_czy4=value;}
			get{return _pt_czy4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_czyname1
		{
			set{ _pt_czyname1=value;}
			get{return _pt_czyname1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_czyname2
		{
			set{ _pt_czyname2=value;}
			get{return _pt_czyname2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_czyname3
		{
			set{ _pt_czyname3=value;}
			get{return _pt_czyname3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_czyname4
		{
			set{ _pt_czyname4=value;}
			get{return _pt_czyname4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_lry
		{
			set{ _pt_lry=value;}
			get{return _pt_lry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_lryname
		{
			set{ _pt_lryname=value;}
			get{return _pt_lryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PT_bhgallsl
		{
			set{ _pt_bhgallsl=value;}
			get{return _pt_bhgallsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_bhgyy
		{
			set{ _pt_bhgyy=value;}
			get{return _pt_bhgyy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng1
		{
			set{ _ptng1=value;}
			get{return _ptng1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng2
		{
			set{ _ptng2=value;}
			get{return _ptng2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng3
		{
			set{ _ptng3=value;}
			get{return _ptng3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng4
		{
			set{ _ptng4=value;}
			get{return _ptng4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng5
		{
			set{ _ptng5=value;}
			get{return _ptng5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng6
		{
			set{ _ptng6=value;}
			get{return _ptng6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng7
		{
			set{ _ptng7=value;}
			get{return _ptng7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng8
		{
			set{ _ptng8=value;}
			get{return _ptng8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptng9
		{
			set{ _ptng9=value;}
			get{return _ptng9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ptngoth
		{
			set{ _ptngoth=value;}
			get{return _ptngoth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ptngothnum
		{
			set{ _ptngothnum=value;}
			get{return _ptngothnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 温循前
		{
			set{ _温循前=value;}
			get{return _温循前;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXQ_sbbh
		{
			set{ _wxq_sbbh=value;}
			get{return _wxq_sbbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WXQ_sjsl
		{
			set{ _wxq_sjsl=value;}
			get{return _wxq_sjsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WXQ_frsl
		{
			set{ _wxq_frsl=value;}
			get{return _wxq_frsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? WXQ_xctime
		{
			set{ _wxq_xctime=value;}
			get{return _wxq_xctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXQ_czy
		{
			set{ _wxq_czy=value;}
			get{return _wxq_czy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXQ_czyname
		{
			set{ _wxq_czyname=value;}
			get{return _wxq_czyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXQ_lry
		{
			set{ _wxq_lry=value;}
			get{return _wxq_lry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXQ_lryname
		{
			set{ _wxq_lryname=value;}
			get{return _wxq_lryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXQ_remark
		{
			set{ _wxq_remark=value;}
			get{return _wxq_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 温循后
		{
			set{ _温循后=value;}
			get{return _温循后;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXH_sbbh
		{
			set{ _wxh_sbbh=value;}
			get{return _wxh_sbbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WXH_qcsl
		{
			set{ _wxh_qcsl=value;}
			get{return _wxh_qcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WXH_xcsl
		{
			set{ _wxh_xcsl=value;}
			get{return _wxh_xcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXH_wxsc
		{
			set{ _wxh_wxsc=value;}
			get{return _wxh_wxsc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? WXH_xctime
		{
			set{ _wxh_xctime=value;}
			get{return _wxh_xctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXH_czy
		{
			set{ _wxh_czy=value;}
			get{return _wxh_czy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXH_czyname
		{
			set{ _wxh_czyname=value;}
			get{return _wxh_czyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WX_Hlry
		{
			set{ _wx_hlry=value;}
			get{return _wx_hlry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXH_lryname
		{
			set{ _wxh_lryname=value;}
			get{return _wxh_lryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXH_remark
		{
			set{ _wxh_remark=value;}
			get{return _wxh_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 测试
		{
			set{ _测试=value;}
			get{return _测试;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_sbbh1
		{
			set{ _cs_sbbh1=value;}
			get{return _cs_sbbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_sbbh2
		{
			set{ _cs_sbbh2=value;}
			get{return _cs_sbbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_sbbh3
		{
			set{ _cs_sbbh3=value;}
			get{return _cs_sbbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_sbbh4
		{
			set{ _cs_sbbh4=value;}
			get{return _cs_sbbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CS_sjsl
		{
			set{ _cs_sjsl=value;}
			get{return _cs_sjsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CS_xcsl
		{
			set{ _cs_xcsl=value;}
			get{return _cs_xcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CS_xctime
		{
			set{ _cs_xctime=value;}
			get{return _cs_xctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_czy1
		{
			set{ _cs_czy1=value;}
			get{return _cs_czy1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_czy2
		{
			set{ _cs_czy2=value;}
			get{return _cs_czy2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_czy3
		{
			set{ _cs_czy3=value;}
			get{return _cs_czy3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_czy4
		{
			set{ _cs_czy4=value;}
			get{return _cs_czy4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_czyname1
		{
			set{ _cs_czyname1=value;}
			get{return _cs_czyname1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_czyname2
		{
			set{ _cs_czyname2=value;}
			get{return _cs_czyname2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_czyname3
		{
			set{ _cs_czyname3=value;}
			get{return _cs_czyname3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_czyname4
		{
			set{ _cs_czyname4=value;}
			get{return _cs_czyname4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_lry
		{
			set{ _cs_lry=value;}
			get{return _cs_lry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CS_lryname
		{
			set{ _cs_lryname=value;}
			get{return _cs_lryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CS_bhgallsl
		{
			set{ _cs_bhgallsl=value;}
			get{return _cs_bhgallsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng1
		{
			set{ _csng1=value;}
			get{return _csng1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng2
		{
			set{ _csng2=value;}
			get{return _csng2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng3
		{
			set{ _csng3=value;}
			get{return _csng3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng4
		{
			set{ _csng4=value;}
			get{return _csng4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng5
		{
			set{ _csng5=value;}
			get{return _csng5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng6
		{
			set{ _csng6=value;}
			get{return _csng6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng7
		{
			set{ _csng7=value;}
			get{return _csng7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng8
		{
			set{ _csng8=value;}
			get{return _csng8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csng9
		{
			set{ _csng9=value;}
			get{return _csng9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string csngoth
		{
			set{ _csngoth=value;}
			get{return _csngoth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? csngothnum
		{
			set{ _csngothnum=value;}
			get{return _csngothnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 清洗
		{
			set{ _清洗=value;}
			get{return _清洗;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_sbbh1
		{
			set{ _qx_sbbh1=value;}
			get{return _qx_sbbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_sbbh2
		{
			set{ _qx_sbbh2=value;}
			get{return _qx_sbbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_sbbh3
		{
			set{ _qx_sbbh3=value;}
			get{return _qx_sbbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_sbbh4
		{
			set{ _qx_sbbh4=value;}
			get{return _qx_sbbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? QX_sjsl
		{
			set{ _qx_sjsl=value;}
			get{return _qx_sjsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? QX_xcsl
		{
			set{ _qx_xcsl=value;}
			get{return _qx_xcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? QX_xctime
		{
			set{ _qx_xctime=value;}
			get{return _qx_xctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_czy1
		{
			set{ _qx_czy1=value;}
			get{return _qx_czy1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_czy2
		{
			set{ _qx_czy2=value;}
			get{return _qx_czy2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_czy3
		{
			set{ _qx_czy3=value;}
			get{return _qx_czy3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_czy4
		{
			set{ _qx_czy4=value;}
			get{return _qx_czy4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_czyname1
		{
			set{ _qx_czyname1=value;}
			get{return _qx_czyname1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_czyname2
		{
			set{ _qx_czyname2=value;}
			get{return _qx_czyname2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_czyname3
		{
			set{ _qx_czyname3=value;}
			get{return _qx_czyname3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_czyname4
		{
			set{ _qx_czyname4=value;}
			get{return _qx_czyname4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_lry
		{
			set{ _qx_lry=value;}
			get{return _qx_lry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QX_lryname
		{
			set{ _qx_lryname=value;}
			get{return _qx_lryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? QX_bhgallsl
		{
			set{ _qx_bhgallsl=value;}
			get{return _qx_bhgallsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? qxng1
		{
			set{ _qxng1=value;}
			get{return _qxng1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qxngoth
		{
			set{ _qxngoth=value;}
			get{return _qxngoth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? qxngothnum
		{
			set{ _qxngothnum=value;}
			get{return _qxngothnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 包装
		{
			set{ _包装=value;}
			get{return _包装;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_sbbh1
		{
			set{ _bz_sbbh1=value;}
			get{return _bz_sbbh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_sbbh2
		{
			set{ _bz_sbbh2=value;}
			get{return _bz_sbbh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_sbbh3
		{
			set{ _bz_sbbh3=value;}
			get{return _bz_sbbh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_sbbh4
		{
			set{ _bz_sbbh4=value;}
			get{return _bz_sbbh4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BZ_sjsl
		{
			set{ _bz_sjsl=value;}
			get{return _bz_sjsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BZ_xcsl
		{
			set{ _bz_xcsl=value;}
			get{return _bz_xcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BZ_xctime
		{
			set{ _bz_xctime=value;}
			get{return _bz_xctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_czy1
		{
			set{ _bz_czy1=value;}
			get{return _bz_czy1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_czy2
		{
			set{ _bz_czy2=value;}
			get{return _bz_czy2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_czy3
		{
			set{ _bz_czy3=value;}
			get{return _bz_czy3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_czy4
		{
			set{ _bz_czy4=value;}
			get{return _bz_czy4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_czyname1
		{
			set{ _bz_czyname1=value;}
			get{return _bz_czyname1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_czyname2
		{
			set{ _bz_czyname2=value;}
			get{return _bz_czyname2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_czyname3
		{
			set{ _bz_czyname3=value;}
			get{return _bz_czyname3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_czyname4
		{
			set{ _bz_czyname4=value;}
			get{return _bz_czyname4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_lry
		{
			set{ _bz_lry=value;}
			get{return _bz_lry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ_lryname
		{
			set{ _bz_lryname=value;}
			get{return _bz_lryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BZ_bhgallsl
		{
			set{ _bz_bhgallsl=value;}
			get{return _bz_bhgallsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? bzng1
		{
			set{ _bzng1=value;}
			get{return _bzng1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bzngoth
		{
			set{ _bzngoth=value;}
			get{return _bzngoth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? bzngothnum
		{
			set{ _bzngothnum=value;}
			get{return _bzngothnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gcsj_liushuih
		{
			set{ _gcsj_liushuih=value;}
			get{return _gcsj_liushuih;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lsh1
		{
			set{ _lsh1=value;}
			get{return _lsh1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lsh2
		{
			set{ _lsh2=value;}
			get{return _lsh2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lsh3
		{
			set{ _lsh3=value;}
			get{return _lsh3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gcsj_CASE
		{
			set{ _gcsj_case=value;}
			get{return _gcsj_case;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string case1
		{
			set{ _case1=value;}
			get{return _case1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string case2
		{
			set{ _case2=value;}
			get{return _case2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string case3
		{
			set{ _case3=value;}
			get{return _case3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gcsj_LDjia
		{
			set{ _gcsj_ldjia=value;}
			get{return _gcsj_ldjia;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ld1
		{
			set{ _ld1=value;}
			get{return _ld1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ld2
		{
			set{ _ld2=value;}
			get{return _ld2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ld3
		{
			set{ _ld3=value;}
			get{return _ld3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gcsj_PDjia
		{
			set{ _gcsj_pdjia=value;}
			get{return _gcsj_pdjia;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pd1
		{
			set{ _pd1=value;}
			get{return _pd1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pd2
		{
			set{ _pd2=value;}
			get{return _pd2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pd3
		{
			set{ _pd3=value;}
			get{return _pd3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gcsj_LDjian
		{
			set{ _gcsj_ldjian=value;}
			get{return _gcsj_ldjian;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ldj1
		{
			set{ _ldj1=value;}
			get{return _ldj1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ldj2
		{
			set{ _ldj2=value;}
			get{return _ldj2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ldj3
		{
			set{ _ldj3=value;}
			get{return _ldj3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gcsj_jicha
		{
			set{ _gcsj_jicha=value;}
			get{return _gcsj_jicha;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? jc1
		{
			set{ _jc1=value;}
			get{return _jc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? jc2
		{
			set{ _jc2=value;}
			get{return _jc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? jc3
		{
			set{ _jc3=value;}
			get{return _jc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gcsj_yatou
		{
			set{ _gcsj_yatou=value;}
			get{return _gcsj_yatou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yt1
		{
			set{ _yt1=value;}
			get{return _yt1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yt2
		{
			set{ _yt2=value;}
			get{return _yt2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yt3
		{
			set{ _yt3=value;}
			get{return _yt3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gcsj_oxianliang
		{
			set{ _gcsj_oxianliang=value;}
			get{return _gcsj_oxianliang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oxl1
		{
			set{ _oxl1=value;}
			get{return _oxl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oxl2
		{
			set{ _oxl2=value;}
			get{return _oxl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oxl3
		{
			set{ _oxl3=value;}
			get{return _oxl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ldxp_xinpianjj
		{
			set{ _ldxp_xinpianjj=value;}
			get{return _ldxp_xinpianjj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ldxp_jianyanry
		{
			set{ _ldxp_jianyanry=value;}
			get{return _ldxp_jianyanry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ldxp_jianyansb
		{
			set{ _ldxp_jianyansb=value;}
			get{return _ldxp_jianyansb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? bggSum
		{
			set{ _bggsum=value;}
			get{return _bggsum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 备注
		{
			set{ _备注=value;}
			get{return _备注;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string LD_lx
        {
            set { _ld_lx = value; }
            get { return _ld_lx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LD_xh
        {
            set { _ld_xh = value; }
            get { return _ld_xh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LD_name
        {
            set { _ld_name = value; }
            get { return _ld_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LD_sjdh
        {
            set { _ld_sjdh = value; }
            get { return _ld_sjdh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LD_remark
        {
            set { _ld_remark = value; }
            get { return _ld_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PT_lx
        {
            set { _pt_lx = value; }
            get { return _pt_lx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PT_xh
        {
            set { _pt_xh = value; }
            get { return _pt_xh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PT_name
        {
            set { _pt_name = value; }
            get { return _pt_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PT_sjdh
        {
            set { _pt_sjdh = value; }
            get { return _pt_sjdh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PT_remark
        {
            set { _pt_remark = value; }
            get { return _pt_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KT_lx
        {
            set { _kt_lx = value; }
            get { return _kt_lx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KT_xh
        {
            set { _kt_xh = value; }
            get { return _kt_xh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KT_name
        {
            set { _kt_name = value; }
            get { return _kt_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KT_sjdh
        {
            set { _kt_sjdh = value; }
            get { return _kt_sjdh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KT_remark
        {
            set { _kt_remark = value; }
            get { return _kt_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_lx0
        {
            set { _nbp_lx0 = value; }
            get { return _nbp_lx0; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_xh0
        {
            set { _nbp_xh0 = value; }
            get { return _nbp_xh0; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_name0
        {
            set { _nbp_name0 = value; }
            get { return _nbp_name0; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_sjdh0
        {
            set { _nbp_sjdh0 = value; }
            get { return _nbp_sjdh0; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_remark0
        {
            set { _nbp_remark0 = value; }
            get { return _nbp_remark0; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_lx45
        {
            set { _nbp_lx45 = value; }
            get { return _nbp_lx45; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_xh45
        {
            set { _nbp_xh45 = value; }
            get { return _nbp_xh45; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_name45
        {
            set { _nbp_name45 = value; }
            get { return _nbp_name45; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_sjdh45
        {
            set { _nbp_sjdh45 = value; }
            get { return _nbp_sjdh45; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NBP_remark45
        {
            set { _nbp_remark45 = value; }
            get { return _nbp_remark45; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JK_lx
        {
            set { _jk_lx = value; }
            get { return _jk_lx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JK_xh
        {
            set { _jk_xh = value; }
            get { return _jk_xh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JK_name
        {
            set { _jk_name = value; }
            get { return _jk_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JK_sjdh
        {
            set { _jk_sjdh = value; }
            get { return _jk_sjdh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JK_remark
        {
            set { _jk_remark = value; }
            get { return _jk_remark; }
        }
		#endregion Model

	}
}

