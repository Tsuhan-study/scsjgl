using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// baozhuang_chuhuo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class baozhuang_chuhuo
	{
		public baozhuang_chuhuo()
		{}
		#region Model
		private string _备货单;
		private string _出货日期;
		private int? _出货数量;
		/// <summary>
		/// 
		/// </summary>
		public string 备货单
		{
			set{ _备货单=value;}
			get{return _备货单;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 出货日期
		{
			set{ _出货日期=value;}
			get{return _出货日期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 出货数量
		{
			set{ _出货数量=value;}
			get{return _出货数量;}
		}

        public int 总数量 { get; set; }
       
		#endregion Model

	}
}

