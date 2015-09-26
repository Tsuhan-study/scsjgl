using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// tsuhan_test_c
	/// </summary>
	public partial class tsuhan_test_c
	{
		private readonly Maticsoft.DAL.tsuhan_test_c dal=new Maticsoft.DAL.tsuhan_test_c();
		public tsuhan_test_c()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string 序列号)
		{
			return dal.Exists(序列号);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_test_c model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tsuhan_test_c model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string 序列号)
		{
			
			return dal.Delete(序列号);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string 序列号list )
		{
			return dal.DeleteList(序列号list );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.tsuhan_test_c GetModel(string 序列号)
		{
			
			return dal.GetModel(序列号);
		}

	
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tsuhan_test_c> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tsuhan_test_c> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.tsuhan_test_c> modelList = new List<Maticsoft.Model.tsuhan_test_c>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.tsuhan_test_c model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

        public DataSet QuerySelect(string cbm1)
        {
            return dal.QuerySelect(cbm1);
        }
    }
}

