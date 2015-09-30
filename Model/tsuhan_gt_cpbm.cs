using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tsuhan_gt_cpbm:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tsuhan_gt_cpbm
	{
		public tsuhan_gt_cpbm()
		{}
		#region Model
		private int _cpid;
		private string _成品编码;
		private string _录入员;
		private DateTime? _时间;
		/// <summary>
		/// 
		/// </summary>
		public int cpId
		{
			set{ _cpid=value;}
			get{return _cpid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 成品编码
		{
			set{ _成品编码=value;}
			get{return _成品编码;}
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

