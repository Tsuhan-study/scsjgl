using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tsuhan_gt_cpmc:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tsuhan_gt_cpmc
	{
		public tsuhan_gt_cpmc()
		{}
		#region Model
		private int _cid;
		private string _产品名称;
		private string _录入员;
		private DateTime? _时间;
		/// <summary>
		/// 
		/// </summary>
		public int cId
		{
			set{ _cid=value;}
			get{return _cid;}
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
		public string 录入员
		{
			set{ _录入员=value;}
			get{return _录入员;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 时间
		{
			set{ _时间=value;}
			get{return _时间;}
		}
		#endregion Model

	}
}

