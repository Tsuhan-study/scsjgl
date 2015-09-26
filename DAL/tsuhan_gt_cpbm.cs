using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_gt_cpbm
	/// </summary>
	public partial class tsuhan_gt_cpbm
	{
		public tsuhan_gt_cpbm()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("cpId", "tsuhan_gt_cpbm"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int cpId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tsuhan_gt_cpbm");
			strSql.Append(" where cpId=@cpId");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Int,4)
			};
			parameters[0].Value = cpId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.tsuhan_gt_cpbm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_gt_cpbm(");
			strSql.Append("成品编码,录入员,时间)");
			strSql.Append(" values (");
			strSql.Append("@成品编码,@录入员,@时间)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@成品编码", SqlDbType.NVarChar,30),
					new SqlParameter("@录入员", SqlDbType.NVarChar,10),
					new SqlParameter("@时间", SqlDbType.DateTime)};
			parameters[0].Value = model.成品编码;
			parameters[1].Value = model.录入员;
			parameters[2].Value = model.时间;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tsuhan_gt_cpbm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_gt_cpbm set ");
			strSql.Append("成品编码=@成品编码,");
			strSql.Append("录入员=@录入员,");
			strSql.Append("时间=@时间");
			strSql.Append(" where cpId=@cpId");
			SqlParameter[] parameters = {
					new SqlParameter("@成品编码", SqlDbType.NVarChar,30),
					new SqlParameter("@录入员", SqlDbType.NVarChar,10),
					new SqlParameter("@时间", SqlDbType.DateTime),
					new SqlParameter("@cpId", SqlDbType.Int,4)};
			parameters[0].Value = model.成品编码;
			parameters[1].Value = model.录入员;
			parameters[2].Value = model.时间;
			parameters[3].Value = model.cpId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int cpId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_gt_cpbm ");
			strSql.Append(" where cpId=@cpId");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Int,4)
			};
			parameters[0].Value = cpId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string cpIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_gt_cpbm ");
			strSql.Append(" where cpId in ("+cpIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.tsuhan_gt_cpbm GetModel(int cpId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 cpId,成品编码,录入员,时间 from tsuhan_gt_cpbm ");
			strSql.Append(" where cpId=@cpId");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Int,4)
			};
			parameters[0].Value = cpId;

			Maticsoft.Model.tsuhan_gt_cpbm model=new Maticsoft.Model.tsuhan_gt_cpbm();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.tsuhan_gt_cpbm DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_gt_cpbm model=new Maticsoft.Model.tsuhan_gt_cpbm();
			if (row != null)
			{
				if(row["cpId"]!=null && row["cpId"].ToString()!="")
				{
					model.cpId=int.Parse(row["cpId"].ToString());
				}
				if(row["成品编码"]!=null)
				{
					model.成品编码=row["成品编码"].ToString();
				}
				if(row["录入员"]!=null)
				{
					model.录入员=row["录入员"].ToString();
				}
				if(row["时间"]!=null && row["时间"].ToString()!="")
				{
					model.时间=DateTime.Parse(row["时间"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select cpId,成品编码,录入员,时间 ");
			strSql.Append(" FROM tsuhan_gt_cpbm ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" cpId,成品编码,录入员,时间 ");
			strSql.Append(" FROM tsuhan_gt_cpbm ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tsuhan_gt_cpbm ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.cpId desc");
			}
			strSql.Append(")AS Row, T.*  from tsuhan_gt_cpbm T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tsuhan_gt_cpbm";
			parameters[1].Value = "cpId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

