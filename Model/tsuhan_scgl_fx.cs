using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tsuhan_scgl_fx:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tsuhan_scgl_fx
	{
		public tsuhan_scgl_fx()
		{}
        #region Model
        private int _id;
        private string _序列号;
        private string _客户;
        private string _型号;
        private string _成品编码;
        private string _原因;
        private string _工位;
        private string _处理方式;
        private string _不良现象;
        private int? _次数;
        private string _关联码;
        private DateTime? _进时间;
        private DateTime? _出时间;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 序列号
        {
            set { _序列号 = value; }
            get { return _序列号; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 客户
        {
            set { _客户 = value; }
            get { return _客户; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 型号
        {
            set { _型号 = value; }
            get { return _型号; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 成品编码
        {
            set { _成品编码 = value; }
            get { return _成品编码; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 原因
        {
            set { _原因 = value; }
            get { return _原因; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 工位
        {
            set { _工位 = value; }
            get { return _工位; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 处理方式
        {
            set { _处理方式 = value; }
            get { return _处理方式; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 不良现象
        {
            set { _不良现象 = value; }
            get { return _不良现象; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? 次数
        {
            set { _次数 = value; }
            get { return _次数; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string 关联码
        {
            set { _关联码 = value; }
            get { return _关联码; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? 进时间
        {
            set { _进时间 = value; }
            get { return _进时间; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? 出时间
        {
            set { _出时间 = value; }
            get { return _出时间; }
        }
        #endregion Model

	}
}

