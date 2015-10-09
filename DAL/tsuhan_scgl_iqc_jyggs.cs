using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_scgl_iqc_jyggs
	/// </summary>
	public partial class tsuhan_scgl_iqc_jyggs
	{
		public tsuhan_scgl_iqc_jyggs()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ggsid", "tsuhan_scgl_iqc_jyggs"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ggsid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tsuhan_scgl_iqc_jyggs");
			strSql.Append(" where ggsid=@ggsid ");
			SqlParameter[] parameters = {
					new SqlParameter("@ggsid", SqlDbType.Int,4)			};
			parameters[0].Value = ggsid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_scgl_iqc_jyggs model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_scgl_iqc_jyggs(");
			strSql.Append("ggsid,ggsmc,ggscplx,ggsrecorder,ggscreattime,check1name,check1min,check1max,check2name,check2min,check2max,check3name,check3min,check3max,check4name,check4min,check4max,check5name,check5min,check5max,check6name,check6min,check6max,check7name,check7min,check7max,check8name,check8min,check8max,check9name,check9min,check9max)");
			strSql.Append(" values (");
			strSql.Append("@ggsid,@ggsmc,@ggscplx,@ggsrecorder,@ggscreattime,@check1name,@check1min,@check1max,@check2name,@check2min,@check2max,@check3name,@check3min,@check3max,@check4name,@check4min,@check4max,@check5name,@check5min,@check5max,@check6name,@check6min,@check6max,@check7name,@check7min,@check7max,@check8name,@check8min,@check8max,@check9name,@check9min,@check9max)");
			SqlParameter[] parameters = {
					new SqlParameter("@ggsid", SqlDbType.Int,4),
					new SqlParameter("@ggsmc", SqlDbType.NChar,20),
					new SqlParameter("@ggscplx", SqlDbType.NChar,10),
					new SqlParameter("@ggsrecorder", SqlDbType.NChar,10),
					new SqlParameter("@ggscreattime", SqlDbType.Timestamp,8),
					new SqlParameter("@check1name", SqlDbType.NChar,10),
					new SqlParameter("@check1min", SqlDbType.Float,8),
					new SqlParameter("@check1max", SqlDbType.Float,8),
					new SqlParameter("@check2name", SqlDbType.NChar,10),
					new SqlParameter("@check2min", SqlDbType.Float,8),
					new SqlParameter("@check2max", SqlDbType.Float,8),
					new SqlParameter("@check3name", SqlDbType.NChar,10),
					new SqlParameter("@check3min", SqlDbType.Float,8),
					new SqlParameter("@check3max", SqlDbType.Float,8),
					new SqlParameter("@check4name", SqlDbType.NChar,10),
					new SqlParameter("@check4min", SqlDbType.Float,8),
					new SqlParameter("@check4max", SqlDbType.Float,8),
					new SqlParameter("@check5name", SqlDbType.NChar,10),
					new SqlParameter("@check5min", SqlDbType.Float,8),
					new SqlParameter("@check5max", SqlDbType.Float,8),
					new SqlParameter("@check6name", SqlDbType.NChar,10),
					new SqlParameter("@check6min", SqlDbType.Float,8),
					new SqlParameter("@check6max", SqlDbType.Float,8),
					new SqlParameter("@check7name", SqlDbType.NChar,10),
					new SqlParameter("@check7min", SqlDbType.Float,8),
					new SqlParameter("@check7max", SqlDbType.Float,8),
					new SqlParameter("@check8name", SqlDbType.NChar,10),
					new SqlParameter("@check8min", SqlDbType.Float,8),
					new SqlParameter("@check8max", SqlDbType.Float,8),
					new SqlParameter("@check9name", SqlDbType.NChar,10),
					new SqlParameter("@check9min", SqlDbType.Float,8),
					new SqlParameter("@check9max", SqlDbType.Float,8)};
			parameters[0].Value = model.ggsid;
			parameters[1].Value = model.ggsmc;
			parameters[2].Value = model.ggscplx;
			parameters[3].Value = model.ggsrecorder;
			parameters[4].Value = model.ggscreattime;
			parameters[5].Value = model.check1name;
			parameters[6].Value = model.check1min;
			parameters[7].Value = model.check1max;
			parameters[8].Value = model.check2name;
			parameters[9].Value = model.check2min;
			parameters[10].Value = model.check2max;
			parameters[11].Value = model.check3name;
			parameters[12].Value = model.check3min;
			parameters[13].Value = model.check3max;
			parameters[14].Value = model.check4name;
			parameters[15].Value = model.check4min;
			parameters[16].Value = model.check4max;
			parameters[17].Value = model.check5name;
			parameters[18].Value = model.check5min;
			parameters[19].Value = model.check5max;
			parameters[20].Value = model.check6name;
			parameters[21].Value = model.check6min;
			parameters[22].Value = model.check6max;
			parameters[23].Value = model.check7name;
			parameters[24].Value = model.check7min;
			parameters[25].Value = model.check7max;
			parameters[26].Value = model.check8name;
			parameters[27].Value = model.check8min;
			parameters[28].Value = model.check8max;
			parameters[29].Value = model.check9name;
			parameters[30].Value = model.check9min;
			parameters[31].Value = model.check9max;

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
		public bool Update(Maticsoft.Model.tsuhan_scgl_iqc_jyggs model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_scgl_iqc_jyggs set ");
			strSql.Append("ggsmc=@ggsmc,");
			strSql.Append("ggscplx=@ggscplx,");
			strSql.Append("ggsrecorder=@ggsrecorder,");
			strSql.Append("check1name=@check1name,");
			strSql.Append("check1min=@check1min,");
			strSql.Append("check1max=@check1max,");
			strSql.Append("check2name=@check2name,");
			strSql.Append("check2min=@check2min,");
			strSql.Append("check2max=@check2max,");
			strSql.Append("check3name=@check3name,");
			strSql.Append("check3min=@check3min,");
			strSql.Append("check3max=@check3max,");
			strSql.Append("check4name=@check4name,");
			strSql.Append("check4min=@check4min,");
			strSql.Append("check4max=@check4max,");
			strSql.Append("check5name=@check5name,");
			strSql.Append("check5min=@check5min,");
			strSql.Append("check5max=@check5max,");
			strSql.Append("check6name=@check6name,");
			strSql.Append("check6min=@check6min,");
			strSql.Append("check6max=@check6max,");
			strSql.Append("check7name=@check7name,");
			strSql.Append("check7min=@check7min,");
			strSql.Append("check7max=@check7max,");
			strSql.Append("check8name=@check8name,");
			strSql.Append("check8min=@check8min,");
			strSql.Append("check8max=@check8max,");
			strSql.Append("check9name=@check9name,");
			strSql.Append("check9min=@check9min,");
			strSql.Append("check9max=@check9max");
			strSql.Append(" where ggsid=@ggsid ");
			SqlParameter[] parameters = {
					new SqlParameter("@ggsmc", SqlDbType.NChar,20),
					new SqlParameter("@ggscplx", SqlDbType.NChar,10),
					new SqlParameter("@ggsrecorder", SqlDbType.NChar,10),
					new SqlParameter("@check1name", SqlDbType.NChar,10),
					new SqlParameter("@check1min", SqlDbType.Float,8),
					new SqlParameter("@check1max", SqlDbType.Float,8),
					new SqlParameter("@check2name", SqlDbType.NChar,10),
					new SqlParameter("@check2min", SqlDbType.Float,8),
					new SqlParameter("@check2max", SqlDbType.Float,8),
					new SqlParameter("@check3name", SqlDbType.NChar,10),
					new SqlParameter("@check3min", SqlDbType.Float,8),
					new SqlParameter("@check3max", SqlDbType.Float,8),
					new SqlParameter("@check4name", SqlDbType.NChar,10),
					new SqlParameter("@check4min", SqlDbType.Float,8),
					new SqlParameter("@check4max", SqlDbType.Float,8),
					new SqlParameter("@check5name", SqlDbType.NChar,10),
					new SqlParameter("@check5min", SqlDbType.Float,8),
					new SqlParameter("@check5max", SqlDbType.Float,8),
					new SqlParameter("@check6name", SqlDbType.NChar,10),
					new SqlParameter("@check6min", SqlDbType.Float,8),
					new SqlParameter("@check6max", SqlDbType.Float,8),
					new SqlParameter("@check7name", SqlDbType.NChar,10),
					new SqlParameter("@check7min", SqlDbType.Float,8),
					new SqlParameter("@check7max", SqlDbType.Float,8),
					new SqlParameter("@check8name", SqlDbType.NChar,10),
					new SqlParameter("@check8min", SqlDbType.Float,8),
					new SqlParameter("@check8max", SqlDbType.Float,8),
					new SqlParameter("@check9name", SqlDbType.NChar,10),
					new SqlParameter("@check9min", SqlDbType.Float,8),
					new SqlParameter("@check9max", SqlDbType.Float,8),
					new SqlParameter("@ggsid", SqlDbType.Int,4)};
			parameters[0].Value = model.ggsmc;
			parameters[1].Value = model.ggscplx;
			parameters[2].Value = model.ggsrecorder;
			parameters[3].Value = model.check1name;
			parameters[4].Value = model.check1min;
			parameters[5].Value = model.check1max;
			parameters[6].Value = model.check2name;
			parameters[7].Value = model.check2min;
			parameters[8].Value = model.check2max;
			parameters[9].Value = model.check3name;
			parameters[10].Value = model.check3min;
			parameters[11].Value = model.check3max;
			parameters[12].Value = model.check4name;
			parameters[13].Value = model.check4min;
			parameters[14].Value = model.check4max;
			parameters[15].Value = model.check5name;
			parameters[16].Value = model.check5min;
			parameters[17].Value = model.check5max;
			parameters[18].Value = model.check6name;
			parameters[19].Value = model.check6min;
			parameters[20].Value = model.check6max;
			parameters[21].Value = model.check7name;
			parameters[22].Value = model.check7min;
			parameters[23].Value = model.check7max;
			parameters[24].Value = model.check8name;
			parameters[25].Value = model.check8min;
			parameters[26].Value = model.check8max;
			parameters[27].Value = model.check9name;
			parameters[28].Value = model.check9min;
			parameters[29].Value = model.check9max;
			parameters[30].Value = model.ggsid;

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
		public bool Delete(int ggsid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_scgl_iqc_jyggs ");
			strSql.Append(" where ggsid=@ggsid ");
			SqlParameter[] parameters = {
					new SqlParameter("@ggsid", SqlDbType.Int,4)			};
			parameters[0].Value = ggsid;

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
		public bool DeleteList(string ggsidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_scgl_iqc_jyggs ");
			strSql.Append(" where ggsid in ("+ggsidlist + ")  ");
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
		public Maticsoft.Model.tsuhan_scgl_iqc_jyggs GetModel(int ggsid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ggsid,ggsmc,ggscplx,ggsrecorder,ggscreattime,check1name,check1min,check1max,check2name,check2min,check2max,check3name,check3min,check3max,check4name,check4min,check4max,check5name,check5min,check5max,check6name,check6min,check6max,check7name,check7min,check7max,check8name,check8min,check8max,check9name,check9min,check9max from tsuhan_scgl_iqc_jyggs ");
			strSql.Append(" where ggsid=@ggsid ");
			SqlParameter[] parameters = {
					new SqlParameter("@ggsid", SqlDbType.Int,4)			};
			parameters[0].Value = ggsid;

			Maticsoft.Model.tsuhan_scgl_iqc_jyggs model=new Maticsoft.Model.tsuhan_scgl_iqc_jyggs();
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
		public Maticsoft.Model.tsuhan_scgl_iqc_jyggs DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_scgl_iqc_jyggs model=new Maticsoft.Model.tsuhan_scgl_iqc_jyggs();
			if (row != null)
			{
				if(row["ggsid"]!=null && row["ggsid"].ToString()!="")
				{
					model.ggsid=int.Parse(row["ggsid"].ToString());
				}
				if(row["ggsmc"]!=null)
				{
					model.ggsmc=row["ggsmc"].ToString();
				}
				if(row["ggscplx"]!=null)
				{
					model.ggscplx=row["ggscplx"].ToString();
				}
				if(row["ggsrecorder"]!=null)
				{
					model.ggsrecorder=row["ggsrecorder"].ToString();
				}
				if(row["ggscreattime"]!=null && row["ggscreattime"].ToString()!="")
				{
					model.ggscreattime=DateTime.Parse(row["ggscreattime"].ToString());
				}
				if(row["check1name"]!=null)
				{
					model.check1name=row["check1name"].ToString();
				}
				if(row["check1min"]!=null && row["check1min"].ToString()!="")
				{
					model.check1min=decimal.Parse(row["check1min"].ToString());
				}
				if(row["check1max"]!=null && row["check1max"].ToString()!="")
				{
					model.check1max=decimal.Parse(row["check1max"].ToString());
				}
				if(row["check2name"]!=null)
				{
					model.check2name=row["check2name"].ToString();
				}
				if(row["check2min"]!=null && row["check2min"].ToString()!="")
				{
					model.check2min=decimal.Parse(row["check2min"].ToString());
				}
				if(row["check2max"]!=null && row["check2max"].ToString()!="")
				{
					model.check2max=decimal.Parse(row["check2max"].ToString());
				}
				if(row["check3name"]!=null)
				{
					model.check3name=row["check3name"].ToString();
				}
				if(row["check3min"]!=null && row["check3min"].ToString()!="")
				{
					model.check3min=decimal.Parse(row["check3min"].ToString());
				}
				if(row["check3max"]!=null && row["check3max"].ToString()!="")
				{
					model.check3max=decimal.Parse(row["check3max"].ToString());
				}
				if(row["check4name"]!=null)
				{
					model.check4name=row["check4name"].ToString();
				}
				if(row["check4min"]!=null && row["check4min"].ToString()!="")
				{
					model.check4min=decimal.Parse(row["check4min"].ToString());
				}
				if(row["check4max"]!=null && row["check4max"].ToString()!="")
				{
					model.check4max=decimal.Parse(row["check4max"].ToString());
				}
				if(row["check5name"]!=null)
				{
					model.check5name=row["check5name"].ToString();
				}
				if(row["check5min"]!=null && row["check5min"].ToString()!="")
				{
					model.check5min=decimal.Parse(row["check5min"].ToString());
				}
				if(row["check5max"]!=null && row["check5max"].ToString()!="")
				{
					model.check5max=decimal.Parse(row["check5max"].ToString());
				}
				if(row["check6name"]!=null)
				{
					model.check6name=row["check6name"].ToString();
				}
				if(row["check6min"]!=null && row["check6min"].ToString()!="")
				{
					model.check6min=decimal.Parse(row["check6min"].ToString());
				}
				if(row["check6max"]!=null && row["check6max"].ToString()!="")
				{
					model.check6max=decimal.Parse(row["check6max"].ToString());
				}
				if(row["check7name"]!=null)
				{
					model.check7name=row["check7name"].ToString();
				}
				if(row["check7min"]!=null && row["check7min"].ToString()!="")
				{
					model.check7min=decimal.Parse(row["check7min"].ToString());
				}
				if(row["check7max"]!=null && row["check7max"].ToString()!="")
				{
					model.check7max=decimal.Parse(row["check7max"].ToString());
				}
				if(row["check8name"]!=null)
				{
					model.check8name=row["check8name"].ToString();
				}
				if(row["check8min"]!=null && row["check8min"].ToString()!="")
				{
					model.check8min=decimal.Parse(row["check8min"].ToString());
				}
				if(row["check8max"]!=null && row["check8max"].ToString()!="")
				{
					model.check8max=decimal.Parse(row["check8max"].ToString());
				}
				if(row["check9name"]!=null)
				{
					model.check9name=row["check9name"].ToString();
				}
				if(row["check9min"]!=null && row["check9min"].ToString()!="")
				{
					model.check9min=decimal.Parse(row["check9min"].ToString());
				}
				if(row["check9max"]!=null && row["check9max"].ToString()!="")
				{
					model.check9max=decimal.Parse(row["check9max"].ToString());
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
			strSql.Append("select ggsid,ggsmc,ggscplx,ggsrecorder,ggscreattime,check1name,check1min,check1max,check2name,check2min,check2max,check3name,check3min,check3max,check4name,check4min,check4max,check5name,check5min,check5max,check6name,check6min,check6max,check7name,check7min,check7max,check8name,check8min,check8max,check9name,check9min,check9max ");
			strSql.Append(" FROM tsuhan_scgl_iqc_jyggs ");
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
			strSql.Append(" ggsid,ggsmc,ggscplx,ggsrecorder,ggscreattime,check1name,check1min,check1max,check2name,check2min,check2max,check3name,check3min,check3max,check4name,check4min,check4max,check5name,check5min,check5max,check6name,check6min,check6max,check7name,check7min,check7max,check8name,check8min,check8max,check9name,check9min,check9max ");
			strSql.Append(" FROM tsuhan_scgl_iqc_jyggs ");
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
			strSql.Append("select count(1) FROM tsuhan_scgl_iqc_jyggs ");
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
				strSql.Append("order by T.ggsid desc");
			}
			strSql.Append(")AS Row, T.*  from tsuhan_scgl_iqc_jyggs T ");
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
			parameters[0].Value = "tsuhan_scgl_iqc_jyggs";
			parameters[1].Value = "ggsid";
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

