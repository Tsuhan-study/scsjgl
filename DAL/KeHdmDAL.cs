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
    public class KeHdmDAL
    {
        DbHelperSQLP dbhelper3 = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString"));

        /// <summary>
        /// 查询所有的客户代码
        /// </summary>
        /// <returns></returns>
        public DataSet GetKeHTable()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM tsuhan_scgl_khdm");
            return dbhelper3.Query(strSql.ToString());
        }

        /// <summary>
        /// 判断客户代码是否存在
        /// </summary>
        /// <param name="dm"></param>
        /// <returns></returns>
        public bool Exist(string 客户代码)
        {
            string sql = "SELECT * FROM tsuhan_scgl_khdm where 客户代码='" + 客户代码 + "'";
            SqlParameter[] parameters = {
					new SqlParameter("@客户代码", SqlDbType.VarChar,30)			};
            parameters[0].Value = 客户代码;
            return dbhelper3.Exists(sql, parameters);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(tsuhan_scgl_khdm model)
        {
            StringBuilder strSql = new StringBuilder();
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

            int rows = dbhelper3.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除
        /// </summary>
        /// <param name="kh"></param>
        /// <returns></returns>
        public bool Delete(string 客户代码)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsuhan_scgl_khdm ");
            strSql.Append(" where ");
            strSql.Append("客户代码=@客户代码");
            SqlParameter[] parameters = {
                   new SqlParameter("@客户代码", SqlDbType.VarChar,30)
			};
            parameters[0].Value = 客户代码;

            int rows = dbhelper3.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
