using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_scgl_iqc_lbpldata
	/// </summary>
	public partial class tsuhan_scgl_iqc_lbpldata
	{
		public tsuhan_scgl_iqc_lbpldata()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "tsuhan_scgl_iqc_lbpldata"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tsuhan_scgl_iqc_lbpldata");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_scgl_iqc_lbpldata model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_scgl_iqc_lbpldata(");
			strSql.Append("id,pch,model1bc,model2bc,model3bc,p1,tgp1,fsp1,xl1,p2,tgp2,fsp2,xl2,p3,tgp3,fsp3,xl3,recorder,recordtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@pch,@model1bc,@model2bc,@model3bc,@p1,@tgp1,@fsp1,@xl1,@p2,@tgp2,@fsp2,@xl2,@p3,@tgp3,@fsp3,@xl3,@recorder,@recordtime)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pch", SqlDbType.Char,30),
					new SqlParameter("@model1bc", SqlDbType.NChar,10),
					new SqlParameter("@model2bc", SqlDbType.NChar,10),
					new SqlParameter("@model3bc", SqlDbType.NChar,10),
					new SqlParameter("@p1", SqlDbType.Float,8),
					new SqlParameter("@tgp1", SqlDbType.Float,8),
					new SqlParameter("@fsp1", SqlDbType.Float,8),
					new SqlParameter("@xl1", SqlDbType.Float,8),
					new SqlParameter("@p2", SqlDbType.Float,8),
					new SqlParameter("@tgp2", SqlDbType.Float,8),
					new SqlParameter("@fsp2", SqlDbType.Float,8),
					new SqlParameter("@xl2", SqlDbType.Float,8),
					new SqlParameter("@p3", SqlDbType.Float,8),
					new SqlParameter("@tgp3", SqlDbType.Float,8),
					new SqlParameter("@fsp3", SqlDbType.Float,8),
					new SqlParameter("@xl3", SqlDbType.Float,8),
					new SqlParameter("@recorder", SqlDbType.NChar,10),
					new SqlParameter("@recordtime", SqlDbType.Timestamp,8)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.pch;
			parameters[2].Value = model.model1bc;
			parameters[3].Value = model.model2bc;
			parameters[4].Value = model.model3bc;
			parameters[5].Value = model.p1;
			parameters[6].Value = model.tgp1;
			parameters[7].Value = model.fsp1;
			parameters[8].Value = model.xl1;
			parameters[9].Value = model.p2;
			parameters[10].Value = model.tgp2;
			parameters[11].Value = model.fsp2;
			parameters[12].Value = model.xl2;
			parameters[13].Value = model.p3;
			parameters[14].Value = model.tgp3;
			parameters[15].Value = model.fsp3;
			parameters[16].Value = model.xl3;
			parameters[17].Value = model.recorder;
			parameters[18].Value = model.recordtime;

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
		public bool Update(Maticsoft.Model.tsuhan_scgl_iqc_lbpldata model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_scgl_iqc_lbpldata set ");
			strSql.Append("pch=@pch,");
			strSql.Append("model1bc=@model1bc,");
			strSql.Append("model2bc=@model2bc,");
			strSql.Append("model3bc=@model3bc,");
			strSql.Append("p1=@p1,");
			strSql.Append("tgp1=@tgp1,");
			strSql.Append("fsp1=@fsp1,");
			strSql.Append("xl1=@xl1,");
			strSql.Append("p2=@p2,");
			strSql.Append("tgp2=@tgp2,");
			strSql.Append("fsp2=@fsp2,");
			strSql.Append("xl2=@xl2,");
			strSql.Append("p3=@p3,");
			strSql.Append("tgp3=@tgp3,");
			strSql.Append("fsp3=@fsp3,");
			strSql.Append("xl3=@xl3,");
			strSql.Append("recorder=@recorder");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.Char,30),
					new SqlParameter("@model1bc", SqlDbType.NChar,10),
					new SqlParameter("@model2bc", SqlDbType.NChar,10),
					new SqlParameter("@model3bc", SqlDbType.NChar,10),
					new SqlParameter("@p1", SqlDbType.Float,8),
					new SqlParameter("@tgp1", SqlDbType.Float,8),
					new SqlParameter("@fsp1", SqlDbType.Float,8),
					new SqlParameter("@xl1", SqlDbType.Float,8),
					new SqlParameter("@p2", SqlDbType.Float,8),
					new SqlParameter("@tgp2", SqlDbType.Float,8),
					new SqlParameter("@fsp2", SqlDbType.Float,8),
					new SqlParameter("@xl2", SqlDbType.Float,8),
					new SqlParameter("@p3", SqlDbType.Float,8),
					new SqlParameter("@tgp3", SqlDbType.Float,8),
					new SqlParameter("@fsp3", SqlDbType.Float,8),
					new SqlParameter("@xl3", SqlDbType.Float,8),
					new SqlParameter("@recorder", SqlDbType.NChar,10),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.pch;
			parameters[1].Value = model.model1bc;
			parameters[2].Value = model.model2bc;
			parameters[3].Value = model.model3bc;
			parameters[4].Value = model.p1;
			parameters[5].Value = model.tgp1;
			parameters[6].Value = model.fsp1;
			parameters[7].Value = model.xl1;
			parameters[8].Value = model.p2;
			parameters[9].Value = model.tgp2;
			parameters[10].Value = model.fsp2;
			parameters[11].Value = model.xl2;
			parameters[12].Value = model.p3;
			parameters[13].Value = model.tgp3;
			parameters[14].Value = model.fsp3;
			parameters[15].Value = model.xl3;
			parameters[16].Value = model.recorder;
			parameters[17].Value = model.id;

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
			strSql.Append("delete from tsuhan_scgl_iqc_lbpldata ");
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
			strSql.Append("delete from tsuhan_scgl_iqc_lbpldata ");
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
		public Maticsoft.Model.tsuhan_scgl_iqc_lbpldata GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,pch,model1bc,model2bc,model3bc,p1,tgp1,fsp1,xl1,p2,tgp2,fsp2,xl2,p3,tgp3,fsp3,xl3,recorder,recordtime from tsuhan_scgl_iqc_lbpldata ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			Maticsoft.Model.tsuhan_scgl_iqc_lbpldata model=new Maticsoft.Model.tsuhan_scgl_iqc_lbpldata();
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
		public Maticsoft.Model.tsuhan_scgl_iqc_lbpldata DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_scgl_iqc_lbpldata model=new Maticsoft.Model.tsuhan_scgl_iqc_lbpldata();
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
				if(row["model1bc"]!=null)
				{
					model.model1bc=row["model1bc"].ToString();
				}
				if(row["model2bc"]!=null)
				{
					model.model2bc=row["model2bc"].ToString();
				}
				if(row["model3bc"]!=null)
				{
					model.model3bc=row["model3bc"].ToString();
				}
				if(row["p1"]!=null && row["p1"].ToString()!="")
				{
					model.p1=decimal.Parse(row["p1"].ToString());
				}
				if(row["tgp1"]!=null && row["tgp1"].ToString()!="")
				{
					model.tgp1=decimal.Parse(row["tgp1"].ToString());
				}
				if(row["fsp1"]!=null && row["fsp1"].ToString()!="")
				{
					model.fsp1=decimal.Parse(row["fsp1"].ToString());
				}
				if(row["xl1"]!=null && row["xl1"].ToString()!="")
				{
					model.xl1=decimal.Parse(row["xl1"].ToString());
				}
				if(row["p2"]!=null && row["p2"].ToString()!="")
				{
					model.p2=decimal.Parse(row["p2"].ToString());
				}
				if(row["tgp2"]!=null && row["tgp2"].ToString()!="")
				{
					model.tgp2=decimal.Parse(row["tgp2"].ToString());
				}
				if(row["fsp2"]!=null && row["fsp2"].ToString()!="")
				{
					model.fsp2=decimal.Parse(row["fsp2"].ToString());
				}
				if(row["xl2"]!=null && row["xl2"].ToString()!="")
				{
					model.xl2=decimal.Parse(row["xl2"].ToString());
				}
				if(row["p3"]!=null && row["p3"].ToString()!="")
				{
					model.p3=decimal.Parse(row["p3"].ToString());
				}
				if(row["tgp3"]!=null && row["tgp3"].ToString()!="")
				{
					model.tgp3=decimal.Parse(row["tgp3"].ToString());
				}
				if(row["fsp3"]!=null && row["fsp3"].ToString()!="")
				{
					model.fsp3=decimal.Parse(row["fsp3"].ToString());
				}
				if(row["xl3"]!=null && row["xl3"].ToString()!="")
				{
					model.xl3=decimal.Parse(row["xl3"].ToString());
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
			strSql.Append("select id,pch,model1bc,model2bc,model3bc,p1,tgp1,fsp1,xl1,p2,tgp2,fsp2,xl2,p3,tgp3,fsp3,xl3,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_lbpldata ");
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
			strSql.Append(" id,pch,model1bc,model2bc,model3bc,p1,tgp1,fsp1,xl1,p2,tgp2,fsp2,xl2,p3,tgp3,fsp3,xl3,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_lbpldata ");
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
			strSql.Append("select count(1) FROM tsuhan_scgl_iqc_lbpldata ");
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
			strSql.Append(")AS Row, T.*  from tsuhan_scgl_iqc_lbpldata T ");
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
			parameters[0].Value = "tsuhan_scgl_iqc_lbpldata";
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

