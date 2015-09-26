using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tsuhan_scgl_khdm:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tsuhan_scgl_khdm
	{
		public tsuhan_scgl_khdm()
		{}
		#region Model
		private int _id;
		private string _客户代码;
		private string _客户信息;
		private string _录入员;
		private string _录入时间;
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
		public string 客户代码
		{
			set{ _客户代码=value;}
			get{return _客户代码;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 客户信息
		{
			set{ _客户信息=value;}
			get{return _客户信息;}
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
		public string 录入时间
		{
			set{ _录入时间=value;}
			get{return _录入时间;}
		}
		#endregion Model

	}
}

