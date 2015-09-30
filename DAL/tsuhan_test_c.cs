using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_test_c
	/// </summary>
	public partial class tsuhan_test_c
	{

        DbHelperSQLP dbhelper1 = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString2"));
		public tsuhan_test_c()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string 序列号)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tsuhan_test_c");
			strSql.Append(" where 序列号=@序列号");
			SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,25)			};
			parameters[0].Value = 序列号;

            return dbhelper1.Exists(strSql.ToString(), parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_test_c model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_test_c(");
			strSql.Append("序列号,型号,随工单,备货单,成品编码,客户,小包装盒号,中包装盒号,大包装盒号,包装_op,Tc_c,LDλc,Pf_c,Ith_c,If_c,Vf_c,Imo_c,Es_c,Rs_c,Kink_c,Liv_判定,Liv_op,Liv_time,Cw_c,Sp_c,Smsr_c,GP_op,Gp_判定,Gp_time,Sen_c,G_c,Vbr_c,Iop_c,Io_c,Id_c,Icc_c,PTλc,Pt_op,Pt_判定,Sen_time,Pf_d)");
			strSql.Append(" values (");
			strSql.Append("@序列号,@型号,@随工单,@备货单,@成品编码,@客户,@小包装盒号,@中包装盒号,@大包装盒号,@包装_op,@Tc_c,@LDλc,@Pf_c,@Ith_c,@If_c,@Vf_c,@Imo_c,@Es_c,@Rs_c,@Kink_c,@Liv_判定,@Liv_op,@Liv_time,@Cw_c,@Sp_c,@Smsr_c,@GP_op,@Gp_判定,@Gp_time,@Sen_c,@G_c,@Vbr_c,@Iop_c,@Io_c,@Id_c,@Icc_c,@PTλc,@Pt_op,@Pt_判定,@Sen_time,@Pf_d)");
			SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,25),
					new SqlParameter("@型号", SqlDbType.NVarChar,25),
					new SqlParameter("@随工单", SqlDbType.NVarChar,25),
					new SqlParameter("@备货单", SqlDbType.NVarChar,25),
					new SqlParameter("@成品编码", SqlDbType.NVarChar,25),
					new SqlParameter("@客户", SqlDbType.NVarChar,10),
					new SqlParameter("@小包装盒号", SqlDbType.NVarChar,25),
					new SqlParameter("@中包装盒号", SqlDbType.NVarChar,25),
					new SqlParameter("@大包装盒号", SqlDbType.NVarChar,25),
					new SqlParameter("@包装_op", SqlDbType.NVarChar,8),
					new SqlParameter("@Tc_c", SqlDbType.Float,8),
					new SqlParameter("@LDλc", SqlDbType.NVarChar,6),
					new SqlParameter("@Pf_c", SqlDbType.Float,8),
					new SqlParameter("@Ith_c", SqlDbType.Float,8),
					new SqlParameter("@If_c", SqlDbType.Float,8),
					new SqlParameter("@Vf_c", SqlDbType.Float,8),
					new SqlParameter("@Imo_c", SqlDbType.Int,4),
					new SqlParameter("@Es_c", SqlDbType.Float,8),
					new SqlParameter("@Rs_c", SqlDbType.Float,8),
					new SqlParameter("@Kink_c", SqlDbType.Int,4),
					new SqlParameter("@Liv_判定", SqlDbType.NVarChar,6),
					new SqlParameter("@Liv_op", SqlDbType.NVarChar,8),
					new SqlParameter("@Liv_time", SqlDbType.DateTime),
					new SqlParameter("@Cw_c", SqlDbType.Float,8),
					new SqlParameter("@Sp_c", SqlDbType.Float,8),
					new SqlParameter("@Smsr_c", SqlDbType.Float,8),
					new SqlParameter("@GP_op", SqlDbType.NVarChar,8),
					new SqlParameter("@Gp_判定", SqlDbType.NVarChar,6),
					new SqlParameter("@Gp_time", SqlDbType.DateTime),
					new SqlParameter("@Sen_c", SqlDbType.Float,8),
					new SqlParameter("@G_c", SqlDbType.Float,8),
					new SqlParameter("@Vbr_c", SqlDbType.Float,8),
					new SqlParameter("@Iop_c", SqlDbType.Float,8),
					new SqlParameter("@Io_c", SqlDbType.Float,8),
					new SqlParameter("@Id_c", SqlDbType.Int,4),
					new SqlParameter("@Icc_c", SqlDbType.Float,8),
					new SqlParameter("@PTλc", SqlDbType.NVarChar,8),
					new SqlParameter("@Pt_op", SqlDbType.NVarChar,8),
					new SqlParameter("@Pt_判定", SqlDbType.NVarChar,6),
					new SqlParameter("@Sen_time", SqlDbType.DateTime),
					new SqlParameter("@Pf_d", SqlDbType.Float,8)};
			parameters[0].Value = model.序列号;
			parameters[1].Value = model.型号;
			parameters[2].Value = model.随工单;
			parameters[3].Value = model.备货单;
			parameters[4].Value = model.成品编码;
			parameters[5].Value = model.客户;
			parameters[6].Value = model.小包装盒号;
			parameters[7].Value = model.中包装盒号;
			parameters[8].Value = model.大包装盒号;
			parameters[9].Value = model.包装_op;
			parameters[10].Value = model.Tc_c;
			parameters[11].Value = model.LDλc;
			parameters[12].Value = model.Pf_c;
			parameters[13].Value = model.Ith_c;
			parameters[14].Value = model.If_c;
			parameters[15].Value = model.Vf_c;
			parameters[16].Value = model.Imo_c;
			parameters[17].Value = model.Es_c;
			parameters[18].Value = model.Rs_c;
			parameters[19].Value = model.Kink_c;
			parameters[20].Value = model.Liv_判定;
			parameters[21].Value = model.Liv_op;
			parameters[22].Value = model.Liv_time;
			parameters[23].Value = model.Cw_c;
			parameters[24].Value = model.Sp_c;
			parameters[25].Value = model.Smsr_c;
			parameters[26].Value = model.GP_op;
			parameters[27].Value = model.Gp_判定;
			parameters[28].Value = model.Gp_time;
			parameters[29].Value = model.Sen_c;
			parameters[30].Value = model.G_c;
			parameters[31].Value = model.Vbr_c;
			parameters[32].Value = model.Iop_c;
			parameters[33].Value = model.Io_c;
			parameters[34].Value = model.Id_c;
			parameters[35].Value = model.Icc_c;
			parameters[36].Value = model.PTλc;
			parameters[37].Value = model.Pt_op;
			parameters[38].Value = model.Pt_判定;
			parameters[39].Value = model.Sen_time;
			parameters[40].Value = model.Pf_d;

            int rows = dbhelper1.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Update(Maticsoft.Model.tsuhan_test_c model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_test_c set ");
			strSql.Append("型号=@型号,");
			strSql.Append("随工单=@随工单,");
			strSql.Append("备货单=@备货单,");
			strSql.Append("成品编码=@成品编码,");
			strSql.Append("客户=@客户,");
			strSql.Append("小包装盒号=@小包装盒号,");
			strSql.Append("中包装盒号=@中包装盒号,");
			strSql.Append("大包装盒号=@大包装盒号,");
			strSql.Append("包装_op=@包装_op,");
			strSql.Append("Tc_c=@Tc_c,");
			strSql.Append("LDλc=@LDλc,");
			strSql.Append("Pf_c=@Pf_c,");
			strSql.Append("Ith_c=@Ith_c,");
			strSql.Append("If_c=@If_c,");
			strSql.Append("Vf_c=@Vf_c,");
			strSql.Append("Imo_c=@Imo_c,");
			strSql.Append("Es_c=@Es_c,");
			strSql.Append("Rs_c=@Rs_c,");
			strSql.Append("Kink_c=@Kink_c,");
			strSql.Append("Liv_判定=@Liv_判定,");
			strSql.Append("Liv_op=@Liv_op,");
			strSql.Append("Liv_time=@Liv_time,");
			strSql.Append("Cw_c=@Cw_c,");
			strSql.Append("Sp_c=@Sp_c,");
			strSql.Append("Smsr_c=@Smsr_c,");
			strSql.Append("GP_op=@GP_op,");
			strSql.Append("Gp_判定=@Gp_判定,");
			strSql.Append("Gp_time=@Gp_time,");
			strSql.Append("Sen_c=@Sen_c,");
			strSql.Append("G_c=@G_c,");
			strSql.Append("Vbr_c=@Vbr_c,");
			strSql.Append("Iop_c=@Iop_c,");
			strSql.Append("Io_c=@Io_c,");
			strSql.Append("Id_c=@Id_c,");
			strSql.Append("Icc_c=@Icc_c,");
			strSql.Append("PTλc=@PTλc,");
			strSql.Append("Pt_op=@Pt_op,");
			strSql.Append("Pt_判定=@Pt_判定,");
			strSql.Append("Sen_time=@Sen_time,");
			strSql.Append("Pf_d=@Pf_d");
			strSql.Append(" where 序列号=@序列号 ");
			SqlParameter[] parameters = {
					new SqlParameter("@型号", SqlDbType.NVarChar,25),
					new SqlParameter("@随工单", SqlDbType.NVarChar,25),
					new SqlParameter("@备货单", SqlDbType.NVarChar,25),
					new SqlParameter("@成品编码", SqlDbType.NVarChar,25),
					new SqlParameter("@客户", SqlDbType.NVarChar,10),
					new SqlParameter("@小包装盒号", SqlDbType.NVarChar,25),
					new SqlParameter("@中包装盒号", SqlDbType.NVarChar,25),
					new SqlParameter("@大包装盒号", SqlDbType.NVarChar,25),
					new SqlParameter("@包装_op", SqlDbType.NVarChar,8),
					new SqlParameter("@Tc_c", SqlDbType.Float,8),
					new SqlParameter("@LDλc", SqlDbType.NVarChar,6),
					new SqlParameter("@Pf_c", SqlDbType.Float,8),
					new SqlParameter("@Ith_c", SqlDbType.Float,8),
					new SqlParameter("@If_c", SqlDbType.Float,8),
					new SqlParameter("@Vf_c", SqlDbType.Float,8),
					new SqlParameter("@Imo_c", SqlDbType.Int,4),
					new SqlParameter("@Es_c", SqlDbType.Float,8),
					new SqlParameter("@Rs_c", SqlDbType.Float,8),
					new SqlParameter("@Kink_c", SqlDbType.Int,4),
					new SqlParameter("@Liv_判定", SqlDbType.NVarChar,6),
					new SqlParameter("@Liv_op", SqlDbType.NVarChar,8),
					new SqlParameter("@Liv_time", SqlDbType.DateTime),
					new SqlParameter("@Cw_c", SqlDbType.Float,8),
					new SqlParameter("@Sp_c", SqlDbType.Float,8),
					new SqlParameter("@Smsr_c", SqlDbType.Float,8),
					new SqlParameter("@GP_op", SqlDbType.NVarChar,8),
					new SqlParameter("@Gp_判定", SqlDbType.NVarChar,6),
					new SqlParameter("@Gp_time", SqlDbType.DateTime),
					new SqlParameter("@Sen_c", SqlDbType.Float,8),
					new SqlParameter("@G_c", SqlDbType.Float,8),
					new SqlParameter("@Vbr_c", SqlDbType.Float,8),
					new SqlParameter("@Iop_c", SqlDbType.Float,8),
					new SqlParameter("@Io_c", SqlDbType.Float,8),
					new SqlParameter("@Id_c", SqlDbType.Int,4),
					new SqlParameter("@Icc_c", SqlDbType.Float,8),
					new SqlParameter("@PTλc", SqlDbType.NVarChar,8),
					new SqlParameter("@Pt_op", SqlDbType.NVarChar,8),
					new SqlParameter("@Pt_判定", SqlDbType.NVarChar,6),
					new SqlParameter("@Sen_time", SqlDbType.DateTime),
					new SqlParameter("@Pf_d", SqlDbType.Float,8),
					new SqlParameter("@序列号", SqlDbType.NVarChar,25)};
			parameters[0].Value = model.型号;
			parameters[1].Value = model.随工单;
			parameters[2].Value = model.备货单;
			parameters[3].Value = model.成品编码;
			parameters[4].Value = model.客户;
			parameters[5].Value = model.小包装盒号;
			parameters[6].Value = model.中包装盒号;
			parameters[7].Value = model.大包装盒号;
			parameters[8].Value = model.包装_op;
			parameters[9].Value = model.Tc_c;
			parameters[10].Value = model.LDλc;
			parameters[11].Value = model.Pf_c;
			parameters[12].Value = model.Ith_c;
			parameters[13].Value = model.If_c;
			parameters[14].Value = model.Vf_c;
			parameters[15].Value = model.Imo_c;
			parameters[16].Value = model.Es_c;
			parameters[17].Value = model.Rs_c;
			parameters[18].Value = model.Kink_c;
			parameters[19].Value = model.Liv_判定;
			parameters[20].Value = model.Liv_op;
			parameters[21].Value = model.Liv_time;
			parameters[22].Value = model.Cw_c;
			parameters[23].Value = model.Sp_c;
			parameters[24].Value = model.Smsr_c;
			parameters[25].Value = model.GP_op;
			parameters[26].Value = model.Gp_判定;
			parameters[27].Value = model.Gp_time;
			parameters[28].Value = model.Sen_c;
			parameters[29].Value = model.G_c;
			parameters[30].Value = model.Vbr_c;
			parameters[31].Value = model.Iop_c;
			parameters[32].Value = model.Io_c;
			parameters[33].Value = model.Id_c;
			parameters[34].Value = model.Icc_c;
			parameters[35].Value = model.PTλc;
			parameters[36].Value = model.Pt_op;
			parameters[37].Value = model.Pt_判定;
			parameters[38].Value = model.Sen_time;
			parameters[39].Value = model.Pf_d;
			parameters[40].Value = model.序列号;

            int rows = dbhelper1.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Delete(string 序列号)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_test_c ");
			strSql.Append(" where 序列号=@序列号 ");
			SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,25)			};
			parameters[0].Value = 序列号;

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
		public bool DeleteList(string 序列号list )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_test_c ");
			strSql.Append(" where 序列号 in ("+序列号list + ")  ");
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
		public Maticsoft.Model.tsuhan_test_c GetModel(string 序列号)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 序列号,型号,随工单,备货单,成品编码,客户,小包装盒号,中包装盒号,大包装盒号,包装_op,Tc_c,LDλc,Pf_c,Ith_c,If_c,Vf_c,Imo_c,Es_c,Rs_c,Kink_c,Liv_判定,Liv_op,Liv_time,Cw_c,Sp_c,Smsr_c,GP_op,Gp_判定,Gp_time,Sen_c,G_c,Vbr_c,Iop_c,Io_c,Id_c,Icc_c,PTλc,Pt_op,Pt_判定,Sen_time,Pf_d from tsuhan_test_c ");
			strSql.Append(" where 序列号=@序列号 ");
			SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,25)			};
			parameters[0].Value = 序列号;

			Maticsoft.Model.tsuhan_test_c model=new Maticsoft.Model.tsuhan_test_c();
            DataSet ds = dbhelper1.Query(strSql.ToString(), parameters);
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
		public Maticsoft.Model.tsuhan_test_c DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_test_c model=new Maticsoft.Model.tsuhan_test_c();
			if (row != null)
			{
				if(row["序列号"]!=null)
				{
					model.序列号=row["序列号"].ToString();
				}
				if(row["型号"]!=null)
				{
					model.型号=row["型号"].ToString();
				}
				if(row["随工单"]!=null)
				{
					model.随工单=row["随工单"].ToString();
				}
				if(row["备货单"]!=null)
				{
					model.备货单=row["备货单"].ToString();
				}
				if(row["成品编码"]!=null)
				{
					model.成品编码=row["成品编码"].ToString();
				}
				if(row["客户"]!=null)
				{
					model.客户=row["客户"].ToString();
				}
				if(row["小包装盒号"]!=null)
				{
					model.小包装盒号=row["小包装盒号"].ToString();
				}
				if(row["中包装盒号"]!=null)
				{
					model.中包装盒号=row["中包装盒号"].ToString();
				}
				if(row["大包装盒号"]!=null)
				{
					model.大包装盒号=row["大包装盒号"].ToString();
				}
				if(row["包装_op"]!=null)
				{
					model.包装_op=row["包装_op"].ToString();
				}
				if(row["Tc_c"]!=null && row["Tc_c"].ToString()!="")
				{
					model.Tc_c=decimal.Parse(row["Tc_c"].ToString());
				}
				if(row["LDλc"]!=null)
				{
					model.LDλc=row["LDλc"].ToString();
				}
				if(row["Pf_c"]!=null && row["Pf_c"].ToString()!="")
				{
					model.Pf_c=decimal.Parse(row["Pf_c"].ToString());
				}
				if(row["Ith_c"]!=null && row["Ith_c"].ToString()!="")
				{
					model.Ith_c=decimal.Parse(row["Ith_c"].ToString());
				}
				if(row["If_c"]!=null && row["If_c"].ToString()!="")
				{
					model.If_c=decimal.Parse(row["If_c"].ToString());
				}
				if(row["Vf_c"]!=null && row["Vf_c"].ToString()!="")
				{
					model.Vf_c=decimal.Parse(row["Vf_c"].ToString());
				}
				if(row["Imo_c"]!=null && row["Imo_c"].ToString()!="")
				{
					model.Imo_c=int.Parse(row["Imo_c"].ToString());
				}
				if(row["Es_c"]!=null && row["Es_c"].ToString()!="")
				{
					model.Es_c=decimal.Parse(row["Es_c"].ToString());
				}
				if(row["Rs_c"]!=null && row["Rs_c"].ToString()!="")
				{
					model.Rs_c=decimal.Parse(row["Rs_c"].ToString());
				}
				if(row["Kink_c"]!=null && row["Kink_c"].ToString()!="")
				{
					model.Kink_c=int.Parse(row["Kink_c"].ToString());
				}
				if(row["Liv_判定"]!=null)
				{
					model.Liv_判定=row["Liv_判定"].ToString();
				}
				if(row["Liv_op"]!=null)
				{
					model.Liv_op=row["Liv_op"].ToString();
				}
				if(row["Liv_time"]!=null && row["Liv_time"].ToString()!="")
				{
					model.Liv_time=DateTime.Parse(row["Liv_time"].ToString());
				}
				if(row["Cw_c"]!=null && row["Cw_c"].ToString()!="")
				{
					model.Cw_c=decimal.Parse(row["Cw_c"].ToString());
				}
				if(row["Sp_c"]!=null && row["Sp_c"].ToString()!="")
				{
					model.Sp_c=decimal.Parse(row["Sp_c"].ToString());
				}
				if(row["Smsr_c"]!=null && row["Smsr_c"].ToString()!="")
				{
					model.Smsr_c=decimal.Parse(row["Smsr_c"].ToString());
				}
				if(row["GP_op"]!=null)
				{
					model.GP_op=row["GP_op"].ToString();
				}
				if(row["Gp_判定"]!=null)
				{
					model.Gp_判定=row["Gp_判定"].ToString();
				}
				if(row["Gp_time"]!=null && row["Gp_time"].ToString()!="")
				{
					model.Gp_time=DateTime.Parse(row["Gp_time"].ToString());
				}
				if(row["Sen_c"]!=null && row["Sen_c"].ToString()!="")
				{
					model.Sen_c=decimal.Parse(row["Sen_c"].ToString());
				}
				if(row["G_c"]!=null && row["G_c"].ToString()!="")
				{
					model.G_c=decimal.Parse(row["G_c"].ToString());
				}
				if(row["Vbr_c"]!=null && row["Vbr_c"].ToString()!="")
				{
					model.Vbr_c=decimal.Parse(row["Vbr_c"].ToString());
				}
				if(row["Iop_c"]!=null && row["Iop_c"].ToString()!="")
				{
					model.Iop_c=decimal.Parse(row["Iop_c"].ToString());
				}
				if(row["Io_c"]!=null && row["Io_c"].ToString()!="")
				{
					model.Io_c=decimal.Parse(row["Io_c"].ToString());
				}
				if(row["Id_c"]!=null && row["Id_c"].ToString()!="")
				{
					model.Id_c=int.Parse(row["Id_c"].ToString());
				}
				if(row["Icc_c"]!=null && row["Icc_c"].ToString()!="")
				{
					model.Icc_c=decimal.Parse(row["Icc_c"].ToString());
				}
				if(row["PTλc"]!=null)
				{
					model.PTλc=row["PTλc"].ToString();
				}
				if(row["Pt_op"]!=null)
				{
					model.Pt_op=row["Pt_op"].ToString();
				}
				if(row["Pt_判定"]!=null)
				{
					model.Pt_判定=row["Pt_判定"].ToString();
				}
				if(row["Sen_time"]!=null && row["Sen_time"].ToString()!="")
				{
					model.Sen_time=DateTime.Parse(row["Sen_time"].ToString());
				}
				if(row["Pf_d"]!=null && row["Pf_d"].ToString()!="")
				{
					model.Pf_d=decimal.Parse(row["Pf_d"].ToString());
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
			strSql.Append("select 序列号,型号,随工单,备货单,成品编码,客户,小包装盒号,中包装盒号,大包装盒号,包装_op,Tc_c,LDλc,Pf_c,Ith_c,If_c,Vf_c,Imo_c,Es_c,Rs_c,Kink_c,Liv_判定,Liv_op,Liv_time,Cw_c,Sp_c,Smsr_c,GP_op,Gp_判定,Gp_time,Sen_c,G_c,Vbr_c,Iop_c,Io_c,Id_c,Icc_c,PTλc,Pt_op,Pt_判定,Sen_time,Pf_d ");
			strSql.Append(" FROM tsuhan_test_c ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return dbhelper1.Query(strSql.ToString());
		}

		
		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

        public DataSet QuerySelect(string cbm1)
        {
            string sql = "";
            if (cbm1=="")
            {
                sql =@"select * FROM tsuhan_test_c 
                        where CONVERT(varchar(10),Liv_time,20) between  DateAdd(yy,-2,GETDATE()) and DateAdd(yy,0,GETDATE())";

            }
            else if (cbm1!=string.Empty)
            {
                sql = @"select * FROM tsuhan_test_c where 备货单='43024' and CONVERT(varchar(10),Liv_time,20) between  DateAdd(mm,-20,GETDATE()) and DateAdd(mm,0,GETDATE())";
            }
            else
            {
                return null;
            }
            return dbhelper1.Query(sql.ToString());
        }

        public Maticsoft.Model.tsuhan_test_c SelectC(string 序列号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsuhan_test_c ");//型号,随工单,成品编码,客户
            strSql.Append(" where 序列号=@序列号 ");
            SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,25)			};
            parameters[0].Value = 序列号;

            Maticsoft.Model.tsuhan_test_c model = new Maticsoft.Model.tsuhan_test_c();
            DataSet ds = dbhelper1.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
    }
}

