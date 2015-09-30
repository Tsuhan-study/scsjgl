using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;
using System.Data.SqlClient;
using System.Data;
using Maticsoft.Model;

namespace DAL
{
    public class RkDAL
    {
		#region  BasicMethod
        DbHelperSQLP dbhelper1 = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString2"));
		
        /// <summary>
        /// 根据备货单和出货日期查询是否有数据
        /// </summary>
        /// <param name="备货单号"></param>
        /// <param name="入库时间"></param>
        /// <returns></returns>
        public bool Exist(string 备货单号,DateTime 入库时间)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsuhan_rkselect");
            strSql.Append(" where 备货单号=@备货单号 and 入库时间=@入库时间");
            SqlParameter[] parameters = {
					new SqlParameter("@备货单号", SqlDbType.NVarChar,20),
                    new SqlParameter("@入库时间", SqlDbType.DateTime,8)
			};
            parameters[0].Value = 备货单号;
            parameters[1].Value = 入库时间;

            return dbhelper1.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 修改
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
        public bool Update1(baozhuang_chuhuo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update baozhuang_chuhuo set ");
            strSql.Append("备货单=@备货单,");
            strSql.Append("出货日期=@出货日期,");
            strSql.Append("出货数量=@出货数量");
            strSql.Append(" where 备货单=@备货单 and 出货日期=@出货日期");
            SqlParameter[] parameters = {
					new SqlParameter("@备货单", SqlDbType.NVarChar,20),
					new SqlParameter("@出货日期", SqlDbType.DateTime),
					new SqlParameter("@出货数量", SqlDbType.Int,4)};
            parameters[0].Value = model.备货单;
            parameters[1].Value = model.出货日期;
            parameters[2].Value = model.出货数量;
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
        /// 根据备货单号，入库时间查询一条记录
        /// </summary>
        /// <param name="sId"></param>
        /// <returns></returns>
        public baozhuang_chuhuo GetModels(string 备货单号, DateTime 入库时间)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 备货单,出货日期,出货数量 from baozhuang_chuhuo ");
            strSql.Append(" where 备货单=@备货单号 and 出货日期=@入库时间");
            SqlParameter[] parameters = {
					new SqlParameter("@备货单号", SqlDbType.NVarChar,25),
                    new SqlParameter("@入库时间", SqlDbType.DateTime,10)
			};
            parameters[0].Value = 备货单号;
            parameters[1].Value = 入库时间;

            baozhuang_chuhuo model = new baozhuang_chuhuo();
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public baozhuang_chuhuo DataRowToModel(DataRow row)
        {
            baozhuang_chuhuo model = new baozhuang_chuhuo();
            if (row != null)
            {
                if (row["备货单"] != null)
                {
                    model.备货单 = row["备货单"].ToString();
                }
                if (row["出货日期"] != null)
                {
                    model.出货日期 = row["出货日期"].ToString();
                }
                if (row["出货数量"] != null && row["出货数量"].ToString() != "")
                {
                    model.出货数量 = int.Parse(row["出货数量"].ToString());
                }
            }
            return model;
        }


		
		
		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

        /// <summary>
        /// 多条件查询
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public DataSet QueryRks(string 备货单, string 出货日期, string time1)
        {
            string sql = "";
            if (备货单 != string.Empty && 出货日期.ToString() != string.Empty && time1!=string.Empty)
            {
                sql = "select * from baozhuang_chuhuo where 备货单 like '%" + 备货单 + "%' and CONVERT(varchar(10),出货日期,23) between '" + 出货日期 + "' and '" + time1 + "' ";

            }
            else if (备货单 == string.Empty && 出货日期.ToString() != string.Empty && time1 != string.Empty)
            {
                sql = "select * from baozhuang_chuhuo where CONVERT(varchar(10),出货日期,23) between '" + 出货日期 + "' and '" + time1 + "' ";
            }
            else if (备货单 != string.Empty && 出货日期.ToString() != string.Empty &&time1==string.Empty)
            {
                 sql = "select * from baozhuang_chuhuo where 备货单 like '%" + 备货单 + "%' and CONVERT(varchar(10),出货日期,23) like '" + 出货日期 + "'";
            }
            else if (备货单 != string.Empty && 出货日期.ToString() == string.Empty && time1 == string.Empty)
            {
                sql = "select * from baozhuang_chuhuo where 备货单 like '%" + 备货单 + "%'";
            }
            else if (备货单 == string.Empty && 出货日期.ToString() != string.Empty && time1 == string.Empty)
            {
                sql = "select * from baozhuang_chuhuo where CONVERT(varchar(10),出货日期,23) like '%" + 出货日期 + "%'";
            }
            else if (备货单 == string.Empty && 出货日期.ToString() == string.Empty && time1 != string.Empty)
            {
                sql = "select * from baozhuang_chuhuo where CONVERT(varchar(10),出货日期,23) like '%" + time1 + "%'";
            }
            else
            {
                return null;
            }
            return dbhelper1.Query(sql.ToString());
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public baozhuang_chuhuo QueryByShul(string 备货单, string 出货日期)
        {
            string sql = "";
            if (备货单 != string.Empty && 出货日期.ToString() != string.Empty)
            {
                sql = @"SELECT 备货单,出货日期,sum(出货数量) as 总数量 FROM [baozhuang_chuhuo]  
                        where 备货单 like '%" + 备货单 + "%' and CONVERT(varchar(10),出货日期,23) like '%" + 出货日期 + "%' group by 备货单,出货日期";
            }
            else if (备货单 != string.Empty && 出货日期.ToString() == string.Empty)
            {
                sql = "SELECT 备货单,sum(出货数量) as 总数量 FROM [baozhuang_chuhuo]  where 备货单 like '%" + 备货单 + "%' group by 备货单";
            }
            else if (备货单 == string.Empty && 出货日期.ToString() != string.Empty)
            {
                sql = @"SELECT 出货日期,sum(出货数量) as 总数量 FROM [baozhuang_chuhuo] 
                        where CONVERT(varchar(10),出货日期,23) like '%" + 出货日期 + "%'group by 出货日期";
            }
            else
            {
                sql = "select sum(出货数量) as 总数量 from baozhuang_chuhuo";
            }

            //baozhuang_chuhuo model = new baozhuang_chuhuo();
            // DataSet ds = dbhelper1.Query(sql.ToString());
            //总数量 = Convert.ToInt32(parameters[0].Value);
            SqlDataReader sdr = dbhelper1.ExecuteReader(sql.ToString());
            
            sdr.Read();
            //总数量 = Convert.ToInt32(sdr.GetOrdinal("总数量").ToString());
            return sdr.ToEntity<baozhuang_chuhuo>();
        }
    }
}
