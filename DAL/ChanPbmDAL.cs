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
    public class ChanPbmDAL
    {
        DbHelperSQLP dbhelper1 = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString"));

        #region 成品编码
        /// <summary>
        /// 查询所有的成品编码
        /// </summary>
        /// <returns></returns>
        public DataSet GetChanPTable()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM tsuhan_gt_cpbm");
            return dbhelper1.Query(strSql.ToString());
        }

        /// <summary>
        /// 判断是否存在记录
        /// </summary>
        /// <param name="cpbm"></param>
        /// <returns></returns>
        public bool Exist(string 成品编码)
        {
            string sql = "SELECT * FROM tsuhan_gt_cpbm where 成品编码='" + 成品编码 + "'";
            SqlParameter[] parameters = {
					new SqlParameter("@成品编码", SqlDbType.NVarChar,30)			};
            parameters[0].Value = 成品编码;
            return dbhelper1.Exists(sql, parameters);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(tsuhan_gt_cpbm model)
        {
            StringBuilder strSql = new StringBuilder();
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

            int rows = dbhelper1.ExecuteSql(strSql.ToString(), parameters);
            if (rows>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="成品编码"></param>
        /// <returns></returns>
        public bool Delete(string 成品编码)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsuhan_gt_cpbm ");
            strSql.Append(" where 成品编码=@成品编码");
            SqlParameter[] parameters = {
					new SqlParameter("@成品编码", SqlDbType.NVarChar,30)
			};
            parameters[0].Value = 成品编码;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 产品名称
        /// <summary>
        /// 查询所有的产品名称，图号
        /// </summary>
        /// <returns></returns>
        public DataTable GetChanMTable()
        {
            string sql = "SELECT * FROM tsuhan_gt_cpmc";
            return dbhelper1.GetTable(sql, new List<SqlParameter>());
        }


        public DataSet GetChanMAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM tsuhan_gt_cpmc");
            return dbhelper1.Query(strSql.ToString());
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="cpmc"></param>
        /// <returns></returns>
        public bool Add(tsuhan_gt_cpmc model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_gt_cpmc(");
            strSql.Append("产品名称,录入员,时间)");
            strSql.Append(" values (");
            strSql.Append("@产品名称,@录入员,@时间)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@产品名称", SqlDbType.NVarChar,30),
					new SqlParameter("@录入员", SqlDbType.NVarChar,10),
					new SqlParameter("@时间", SqlDbType.DateTime)};
            parameters[0].Value = model.产品名称;
            parameters[1].Value = model.录入员;
            parameters[2].Value = model.时间;

            int rows = dbhelper1.ExecuteSql(strSql.ToString(), parameters);
            if (rows>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteP(string 产品名称)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsuhan_gt_cpmc ");
            strSql.Append(" where 产品名称=@产品名称");
            SqlParameter[] parameters = {
					new SqlParameter("@产品名称", SqlDbType.NVarChar,30)
			};
            parameters[0].Value = 产品名称;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
