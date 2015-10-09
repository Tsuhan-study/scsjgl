using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_scgl_iqc_jkzjldata
	/// </summary>
	public partial class tsuhan_scgl_iqc_jkzjldata
	{
		public tsuhan_scgl_iqc_jkzjldata()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "tsuhan_scgl_iqc_jkzjldata"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tsuhan_scgl_iqc_jkzjldata");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_scgl_iqc_jkzjldata model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_scgl_iqc_jkzjldata(");
			strSql.Append("id,pch,check1name,check1value,check1result,check2name,check2value,check2result,check3name,check3value,check3result,check4name,check4value,check4result,check5name,check5value,check5result,check6name,check6value,check6result,check7name,check7value,check7result,check8name,check8value,check8result,check9name,check9value,check9result,check10name,check10value,check10result,check11name,check11value,check11result,recorder,recordtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@pch,@check1name,@check1value,@check1result,@check2name,@check2value,@check2result,@check3name,@check3value,@check3result,@check4name,@check4value,@check4result,@check5name,@check5value,@check5result,@check6name,@check6value,@check6result,@check7name,@check7value,@check7result,@check8name,@check8value,@check8result,@check9name,@check9value,@check9result,@check10name,@check10value,@check10result,@check11name,@check11value,@check11result,@recorder,@recordtime)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pch", SqlDbType.NChar,30),
					new SqlParameter("@check1name", SqlDbType.NChar,20),
					new SqlParameter("@check1value", SqlDbType.NChar,10),
					new SqlParameter("@check1result", SqlDbType.NChar,10),
					new SqlParameter("@check2name", SqlDbType.NChar,20),
					new SqlParameter("@check2value", SqlDbType.NChar,10),
					new SqlParameter("@check2result", SqlDbType.NChar,10),
					new SqlParameter("@check3name", SqlDbType.NChar,20),
					new SqlParameter("@check3value", SqlDbType.NChar,10),
					new SqlParameter("@check3result", SqlDbType.NChar,10),
					new SqlParameter("@check4name", SqlDbType.NChar,20),
					new SqlParameter("@check4value", SqlDbType.NChar,10),
					new SqlParameter("@check4result", SqlDbType.NChar,10),
					new SqlParameter("@check5name", SqlDbType.NChar,20),
					new SqlParameter("@check5value", SqlDbType.NChar,10),
					new SqlParameter("@check5result", SqlDbType.NChar,10),
					new SqlParameter("@check6name", SqlDbType.NChar,20),
					new SqlParameter("@check6value", SqlDbType.NChar,10),
					new SqlParameter("@check6result", SqlDbType.NChar,10),
					new SqlParameter("@check7name", SqlDbType.NChar,20),
					new SqlParameter("@check7value", SqlDbType.NChar,10),
					new SqlParameter("@check7result", SqlDbType.NChar,10),
					new SqlParameter("@check8name", SqlDbType.NChar,20),
					new SqlParameter("@check8value", SqlDbType.NChar,10),
					new SqlParameter("@check8result", SqlDbType.NChar,10),
					new SqlParameter("@check9name", SqlDbType.NChar,20),
					new SqlParameter("@check9value", SqlDbType.NChar,10),
					new SqlParameter("@check9result", SqlDbType.NChar,10),
					new SqlParameter("@check10name", SqlDbType.NChar,20),
					new SqlParameter("@check10value", SqlDbType.NChar,10),
					new SqlParameter("@check10result", SqlDbType.NChar,10),
					new SqlParameter("@check11name", SqlDbType.NChar,20),
					new SqlParameter("@check11value", SqlDbType.NChar,10),
					new SqlParameter("@check11result", SqlDbType.NChar,10),
					new SqlParameter("@recorder", SqlDbType.NChar,10),
					new SqlParameter("@recordtime", SqlDbType.Timestamp,8)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.pch;
			parameters[2].Value = model.check1name;
			parameters[3].Value = model.check1value;
			parameters[4].Value = model.check1result;
			parameters[5].Value = model.check2name;
			parameters[6].Value = model.check2value;
			parameters[7].Value = model.check2result;
			parameters[8].Value = model.check3name;
			parameters[9].Value = model.check3value;
			parameters[10].Value = model.check3result;
			parameters[11].Value = model.check4name;
			parameters[12].Value = model.check4value;
			parameters[13].Value = model.check4result;
			parameters[14].Value = model.check5name;
			parameters[15].Value = model.check5value;
			parameters[16].Value = model.check5result;
			parameters[17].Value = model.check6name;
			parameters[18].Value = model.check6value;
			parameters[19].Value = model.check6result;
			parameters[20].Value = model.check7name;
			parameters[21].Value = model.check7value;
			parameters[22].Value = model.check7result;
			parameters[23].Value = model.check8name;
			parameters[24].Value = model.check8value;
			parameters[25].Value = model.check8result;
			parameters[26].Value = model.check9name;
			parameters[27].Value = model.check9value;
			parameters[28].Value = model.check9result;
			parameters[29].Value = model.check10name;
			parameters[30].Value = model.check10value;
			parameters[31].Value = model.check10result;
			parameters[32].Value = model.check11name;
			parameters[33].Value = model.check11value;
			parameters[34].Value = model.check11result;
			parameters[35].Value = model.recorder;
			parameters[36].Value = model.recordtime;

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
		public bool Update(Maticsoft.Model.tsuhan_scgl_iqc_jkzjldata model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_scgl_iqc_jkzjldata set ");
			strSql.Append("pch=@pch,");
			strSql.Append("check1name=@check1name,");
			strSql.Append("check1value=@check1value,");
			strSql.Append("check1result=@check1result,");
			strSql.Append("check2name=@check2name,");
			strSql.Append("check2value=@check2value,");
			strSql.Append("check2result=@check2result,");
			strSql.Append("check3name=@check3name,");
			strSql.Append("check3value=@check3value,");
			strSql.Append("check3result=@check3result,");
			strSql.Append("check4name=@check4name,");
			strSql.Append("check4value=@check4value,");
			strSql.Append("check4result=@check4result,");
			strSql.Append("check5name=@check5name,");
			strSql.Append("check5value=@check5value,");
			strSql.Append("check5result=@check5result,");
			strSql.Append("check6name=@check6name,");
			strSql.Append("check6value=@check6value,");
			strSql.Append("check6result=@check6result,");
			strSql.Append("check7name=@check7name,");
			strSql.Append("check7value=@check7value,");
			strSql.Append("check7result=@check7result,");
			strSql.Append("check8name=@check8name,");
			strSql.Append("check8value=@check8value,");
			strSql.Append("check8result=@check8result,");
			strSql.Append("check9name=@check9name,");
			strSql.Append("check9value=@check9value,");
			strSql.Append("check9result=@check9result,");
			strSql.Append("check10name=@check10name,");
			strSql.Append("check10value=@check10value,");
			strSql.Append("check10result=@check10result,");
			strSql.Append("check11name=@check11name,");
			strSql.Append("check11value=@check11value,");
			strSql.Append("check11result=@check11result,");
			strSql.Append("recorder=@recorder");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.NChar,30),
					new SqlParameter("@check1name", SqlDbType.NChar,20),
					new SqlParameter("@check1value", SqlDbType.NChar,10),
					new SqlParameter("@check1result", SqlDbType.NChar,10),
					new SqlParameter("@check2name", SqlDbType.NChar,20),
					new SqlParameter("@check2value", SqlDbType.NChar,10),
					new SqlParameter("@check2result", SqlDbType.NChar,10),
					new SqlParameter("@check3name", SqlDbType.NChar,20),
					new SqlParameter("@check3value", SqlDbType.NChar,10),
					new SqlParameter("@check3result", SqlDbType.NChar,10),
					new SqlParameter("@check4name", SqlDbType.NChar,20),
					new SqlParameter("@check4value", SqlDbType.NChar,10),
					new SqlParameter("@check4result", SqlDbType.NChar,10),
					new SqlParameter("@check5name", SqlDbType.NChar,20),
					new SqlParameter("@check5value", SqlDbType.NChar,10),
					new SqlParameter("@check5result", SqlDbType.NChar,10),
					new SqlParameter("@check6name", SqlDbType.NChar,20),
					new SqlParameter("@check6value", SqlDbType.NChar,10),
					new SqlParameter("@check6result", SqlDbType.NChar,10),
					new SqlParameter("@check7name", SqlDbType.NChar,20),
					new SqlParameter("@check7value", SqlDbType.NChar,10),
					new SqlParameter("@check7result", SqlDbType.NChar,10),
					new SqlParameter("@check8name", SqlDbType.NChar,20),
					new SqlParameter("@check8value", SqlDbType.NChar,10),
					new SqlParameter("@check8result", SqlDbType.NChar,10),
					new SqlParameter("@check9name", SqlDbType.NChar,20),
					new SqlParameter("@check9value", SqlDbType.NChar,10),
					new SqlParameter("@check9result", SqlDbType.NChar,10),
					new SqlParameter("@check10name", SqlDbType.NChar,20),
					new SqlParameter("@check10value", SqlDbType.NChar,10),
					new SqlParameter("@check10result", SqlDbType.NChar,10),
					new SqlParameter("@check11name", SqlDbType.NChar,20),
					new SqlParameter("@check11value", SqlDbType.NChar,10),
					new SqlParameter("@check11result", SqlDbType.NChar,10),
					new SqlParameter("@recorder", SqlDbType.NChar,10),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.pch;
			parameters[1].Value = model.check1name;
			parameters[2].Value = model.check1value;
			parameters[3].Value = model.check1result;
			parameters[4].Value = model.check2name;
			parameters[5].Value = model.check2value;
			parameters[6].Value = model.check2result;
			parameters[7].Value = model.check3name;
			parameters[8].Value = model.check3value;
			parameters[9].Value = model.check3result;
			parameters[10].Value = model.check4name;
			parameters[11].Value = model.check4value;
			parameters[12].Value = model.check4result;
			parameters[13].Value = model.check5name;
			parameters[14].Value = model.check5value;
			parameters[15].Value = model.check5result;
			parameters[16].Value = model.check6name;
			parameters[17].Value = model.check6value;
			parameters[18].Value = model.check6result;
			parameters[19].Value = model.check7name;
			parameters[20].Value = model.check7value;
			parameters[21].Value = model.check7result;
			parameters[22].Value = model.check8name;
			parameters[23].Value = model.check8value;
			parameters[24].Value = model.check8result;
			parameters[25].Value = model.check9name;
			parameters[26].Value = model.check9value;
			parameters[27].Value = model.check9result;
			parameters[28].Value = model.check10name;
			parameters[29].Value = model.check10value;
			parameters[30].Value = model.check10result;
			parameters[31].Value = model.check11name;
			parameters[32].Value = model.check11value;
			parameters[33].Value = model.check11result;
			parameters[34].Value = model.recorder;
			parameters[35].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_scgl_iqc_jkzjldata ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_scgl_iqc_jkzjldata ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public Maticsoft.Model.tsuhan_scgl_iqc_jkzjldata GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,pch,check1name,check1value,check1result,check2name,check2value,check2result,check3name,check3value,check3result,check4name,check4value,check4result,check5name,check5value,check5result,check6name,check6value,check6result,check7name,check7value,check7result,check8name,check8value,check8result,check9name,check9value,check9result,check10name,check10value,check10result,check11name,check11value,check11result,recorder,recordtime from tsuhan_scgl_iqc_jkzjldata ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			Maticsoft.Model.tsuhan_scgl_iqc_jkzjldata model=new Maticsoft.Model.tsuhan_scgl_iqc_jkzjldata();
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
		public Maticsoft.Model.tsuhan_scgl_iqc_jkzjldata DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_scgl_iqc_jkzjldata model=new Maticsoft.Model.tsuhan_scgl_iqc_jkzjldata();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["pch"]!=null)
				{
					model.pch=row["pch"].ToString();
				}
				if(row["check1name"]!=null)
				{
					model.check1name=row["check1name"].ToString();
				}
				if(row["check1value"]!=null)
				{
					model.check1value=row["check1value"].ToString();
				}
				if(row["check1result"]!=null)
				{
					model.check1result=row["check1result"].ToString();
				}
				if(row["check2name"]!=null)
				{
					model.check2name=row["check2name"].ToString();
				}
				if(row["check2value"]!=null)
				{
					model.check2value=row["check2value"].ToString();
				}
				if(row["check2result"]!=null)
				{
					model.check2result=row["check2result"].ToString();
				}
				if(row["check3name"]!=null)
				{
					model.check3name=row["check3name"].ToString();
				}
				if(row["check3value"]!=null)
				{
					model.check3value=row["check3value"].ToString();
				}
				if(row["check3result"]!=null)
				{
					model.check3result=row["check3result"].ToString();
				}
				if(row["check4name"]!=null)
				{
					model.check4name=row["check4name"].ToString();
				}
				if(row["check4value"]!=null)
				{
					model.check4value=row["check4value"].ToString();
				}
				if(row["check4result"]!=null)
				{
					model.check4result=row["check4result"].ToString();
				}
				if(row["check5name"]!=null)
				{
					model.check5name=row["check5name"].ToString();
				}
				if(row["check5value"]!=null)
				{
					model.check5value=row["check5value"].ToString();
				}
				if(row["check5result"]!=null)
				{
					model.check5result=row["check5result"].ToString();
				}
				if(row["check6name"]!=null)
				{
					model.check6name=row["check6name"].ToString();
				}
				if(row["check6value"]!=null)
				{
					model.check6value=row["check6value"].ToString();
				}
				if(row["check6result"]!=null)
				{
					model.check6result=row["check6result"].ToString();
				}
				if(row["check7name"]!=null)
				{
					model.check7name=row["check7name"].ToString();
				}
				if(row["check7value"]!=null)
				{
					model.check7value=row["check7value"].ToString();
				}
				if(row["check7result"]!=null)
				{
					model.check7result=row["check7result"].ToString();
				}
				if(row["check8name"]!=null)
				{
					model.check8name=row["check8name"].ToString();
				}
				if(row["check8value"]!=null)
				{
					model.check8value=row["check8value"].ToString();
				}
				if(row["check8result"]!=null)
				{
					model.check8result=row["check8result"].ToString();
				}
				if(row["check9name"]!=null)
				{
					model.check9name=row["check9name"].ToString();
				}
				if(row["check9value"]!=null)
				{
					model.check9value=row["check9value"].ToString();
				}
				if(row["check9result"]!=null)
				{
					model.check9result=row["check9result"].ToString();
				}
				if(row["check10name"]!=null)
				{
					model.check10name=row["check10name"].ToString();
				}
				if(row["check10value"]!=null)
				{
					model.check10value=row["check10value"].ToString();
				}
				if(row["check10result"]!=null)
				{
					model.check10result=row["check10result"].ToString();
				}
				if(row["check11name"]!=null)
				{
					model.check11name=row["check11name"].ToString();
				}
				if(row["check11value"]!=null)
				{
					model.check11value=row["check11value"].ToString();
				}
				if(row["check11result"]!=null)
				{
					model.check11result=row["check11result"].ToString();
				}
				if(row["recorder"]!=null)
				{
					model.recorder=row["recorder"].ToString();
				}
				if(row["recordtime"]!=null && row["recordtime"].ToString()!="")
				{
					model.recordtime=DateTime.Parse(row["recordtime"].ToString());
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
			strSql.Append("select id,pch,check1name,check1value,check1result,check2name,check2value,check2result,check3name,check3value,check3result,check4name,check4value,check4result,check5name,check5value,check5result,check6name,check6value,check6result,check7name,check7value,check7result,check8name,check8value,check8result,check9name,check9value,check9result,check10name,check10value,check10result,check11name,check11value,check11result,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_jkzjldata ");
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
			strSql.Append(" id,pch,check1name,check1value,check1result,check2name,check2value,check2result,check3name,check3value,check3result,check4name,check4value,check4result,check5name,check5value,check5result,check6name,check6value,check6result,check7name,check7value,check7result,check8name,check8value,check8result,check9name,check9value,check9result,check10name,check10value,check10result,check11name,check11value,check11result,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_jkzjldata ");
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
			strSql.Append("select count(1) FROM tsuhan_scgl_iqc_jkzjldata ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from tsuhan_scgl_iqc_jkzjldata T ");
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
			parameters[0].Value = "tsuhan_scgl_iqc_jkzjldata";
			parameters[1].Value = "id";
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

