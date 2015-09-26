using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tsuhan_scgl_cplx:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tsuhan_scgl_cplx
	{
		public tsuhan_scgl_cplx()
		{}
		#region Model
		private int _id;
		private string _产品类型;
		private string _录入员;
		private DateTime _录入时间;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
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
		public DateTime 录入时间
		{
			set{ _录入时间=value;}
			get{return _录入时间;}
		}
		#endregion Model

	}
}

