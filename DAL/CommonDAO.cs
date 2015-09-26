using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;
using System.Configuration;
using CEP.Framework.Database;
using System.Collections.Generic;

namespace Maticsoft.DAL
{
    /// <summary>
    /// 通过数据库操作类，每一个对应的TableDAO均应扩展自该类
    /// </summary>
    public class CommonDAO
    {


        #region 实体查询

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
       // public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionStringAccounts"].ConnectionString;
        public string ConnectionString = PubConstant.ConnectionString; 
        /// <summary>
        /// 查询实体集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected List<T> QueryEntities<T>(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            DataSet ds = SqlHelper.ExecuteDataset(ConnectionString, commandType, sql, parameters);

            List<T> list = ds.Tables[0].ToList<T>();

            return list;
        }

        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected T QueryEntity<T>(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlDataReader dataReader = SqlHelper.ExecuteReader(ConnectionString, commandType, sql, parameters);
            T entity = dataReader.ToEntity<T>();
            return entity;
        }

        #endregion

    }
}
