using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;
using System.Data;
using System.Data.SqlClient;
using Maticsoft.Model;

namespace DAL
{
    public class ChanPxhDAL
    {
        DbHelperSQLP dbhelper3 = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString3"));
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.tsuhan_scgl_cplx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_scgl_cplx(");
            strSql.Append("产品类型,录入员,录入时间)");
            strSql.Append(" values (");
            strSql.Append("@产品类型,@录入员,@录入时间)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@产品类型", SqlDbType.VarChar,100),
					new SqlParameter("@录入员", SqlDbType.VarChar,50),
					new SqlParameter("@录入时间", SqlDbType.DateTime)};
            parameters[0].Value = model.产品类型;
            parameters[1].Value = model.录入员;
            parameters[2].Value = model.录入时间;

            object obj = dbhelper3.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Maticsoft.Model.tsuhan_scgl_cplx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsuhan_scgl_cplx set ");
            strSql.Append("产品类型=@产品类型,");
            strSql.Append("录入员=@录入员,");
            strSql.Append("录入时间=@录入时间");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@产品类型", SqlDbType.VarChar,100),
					new SqlParameter("@录入员", SqlDbType.VarChar,50),
					new SqlParameter("@录入时间", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.产品类型;
            parameters[1].Value = model.录入员;
            parameters[2].Value = model.录入时间;
            parameters[3].Value = model.id;

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
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.tsuhan_scgl_cplx GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,产品类型,录入员,录入时间 from tsuhan_scgl_cplx ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            Maticsoft.Model.tsuhan_scgl_cplx model = new Maticsoft.Model.tsuhan_scgl_cplx();
            DataSet ds = dbhelper3.Query(strSql.ToString(), parameters);
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
        public Maticsoft.Model.tsuhan_scgl_cplx DataRowToModel(DataRow row)
        {
            Maticsoft.Model.tsuhan_scgl_cplx model = new Maticsoft.Model.tsuhan_scgl_cplx();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["产品类型"] != null)
                {
                    model.产品类型 = row["产品类型"].ToString();
                }
                if (row["录入员"] != null)
                {
                    model.录入员 = row["录入员"].ToString();
                }
                if (row["录入时间"] != null && row["录入时间"].ToString() != "")
                {
                    model.录入时间 = DateTime.Parse(row["录入时间"].ToString());
                }
            }
            return model;
        }
        #endregion  BasicMethod

        /// <summary>
        /// 查询所有产品类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetChanPTable()
        {
            string sql = "SELECT * FROM tsuhan_scgl_cplx";
                                                        
            return dbhelper3.GetTable(sql, new List<SqlParameter>());
        }                                               
    }                                                   
}     