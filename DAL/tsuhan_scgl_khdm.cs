using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_scgl_khdm
	/// </summary>
	public partial class tsuhan_scgl_khdm
	{
		public tsuhan_scgl_khdm()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_scgl_khdm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_scgl_khdm(");
			strSql.Append("id,客户代码,客户信息,录入员,录入时间)");
			strSql.Append(" values (");
			strSql.Append("@id,@客户代码,@客户信息,@录入员,@录入时间)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@客户代码", SqlDbType.VarChar,30),
					new SqlParameter("@客户信息", SqlDbType.VarChar,100),
					new SqlParameter("@录入员", SqlDbType.VarChar,20),
					new SqlParameter("@录入时间", SqlDbType.VarChar,50)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.客户代码;
			parameters[2].Value = model.客户信息;
			parameters[3].Value = model.录入员;
			parameters[4].Value = model.录入时间;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tsuhan_scgl_khdm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_scgl_khdm set ");
			strSql.Append("id=@id,");
			strSql.Append("客户代码=@客户代码,");
			strSql.Append("客户信息=@客户信息,");
			strSql.Append("录入员=@录入员,");
			strSql.Append("录入时间=@录入时间");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@客户代码", SqlDbType.VarChar,30),
					new SqlParameter("@客户信息", SqlDbType.VarChar,100),
					new SqlParameter("@录入员", SqlDbType.VarChar,20),
					new SqlParameter("@录入时间", SqlDbType.VarChar,50)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.客户代码;
			parameters[2].Value = model.客户信息;
			parameters[3].Value = model.录入员;
			parameters[4].Value = model.录入时间;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_scgl_khdm ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.tsuhan_scgl_khdm GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,客户代码,客户信息,录入员,录入时间 from tsuhan_scgl_khdm ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.tsuhan_scgl_khdm model=new Maticsoft.Model.tsuhan_scgl_khdm();
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
		public Maticsoft.Model.tsuhan_scgl_khdm DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_scgl_khdm model=new Maticsoft.Model.tsuhan_scgl_khdm();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["客户代码"]!=null)
				{
					model.客户代码=row["客户代码"].ToString();
				}
				if(row["客户信息"]!=null)
				{
					model.客户信息=row["客户信息"].ToString();
				}
				if(row["录入员"]!=null)
				{
					model.录入员=row["录入员"].ToString();
				}
				if(row["录入时间"]!=null)
				{
					model.录入时间=row["录入时间"].ToString();
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
			strSql.Append("select id,客户代码,客户信息,录入员,录入时间 ");
			strSql.Append(" FROM tsuhan_scgl_khdm ");
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
			strSql.Append(" id,客户代码,客户信息,录入员,录入时间 ");
			strSql.Append(" FROM tsuhan_scgl_khdm ");
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
			strSql.Append("select count(1) FROM tsuhan_scgl_khdm ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from tsuhan_scgl_khdm T ");
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
			parameters[0].Value = "tsuhan_scgl_khdm";
			parameters[1].Value = "";
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

