using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Maticsoft.Model;
using System.Data.SqlClient;
using System.Data;
using Maticsoft.DBUtility;

namespace DAL
{
    public class FanXiuDAL
    {
        DbHelperSQLP dbhelper1 = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString"));

        /// <summary>
        /// 查询返修表信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetFXtable()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT 关联码,序列号 FROM tsuhan_scgl_fx");
            strSql.Append(" where 关联码 is not null and 出时间 is not null");
            return dbhelper1.Query(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string 序列号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsuhan_scgl_fx");
            strSql.Append(" where 序列号=@序列号 ");
            SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,20)			};
            parameters[0].Value = 序列号;

            return dbhelper1.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.tsuhan_scgl_fx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_scgl_fx(");
            strSql.Append("序列号,客户,型号,成品编码,原因,工位,处理方式,不良现象,次数,关联码,进时间,出时间)");
            strSql.Append(" values (");
            strSql.Append("@序列号,@客户,@型号,@成品编码,@原因,@工位,@处理方式,@不良现象,@次数,@关联码,@进时间,@出时间)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,20),
					new SqlParameter("@客户", SqlDbType.NVarChar,20),
					new SqlParameter("@型号", SqlDbType.NVarChar,20),
					new SqlParameter("@成品编码", SqlDbType.NVarChar,30),
					new SqlParameter("@原因", SqlDbType.NVarChar,50),
					new SqlParameter("@工位", SqlDbType.NVarChar,20),
					new SqlParameter("@处理方式", SqlDbType.NVarChar,50),
					new SqlParameter("@不良现象", SqlDbType.NVarChar,50),
					new SqlParameter("@次数", SqlDbType.Int,4),
                    new SqlParameter("@关联码",SqlDbType.NVarChar,20),
					new SqlParameter("@进时间", SqlDbType.DateTime,8),
					new SqlParameter("@出时间", SqlDbType.DateTime,8)};
            parameters[0].Value = model.序列号;
            parameters[1].Value = model.客户;
            parameters[2].Value = model.型号;
            parameters[3].Value = model.成品编码;
            parameters[4].Value = model.原因;
            parameters[5].Value = model.工位;
            parameters[6].Value = model.处理方式;
            parameters[7].Value = model.不良现象;
            parameters[8].Value = model.次数;
            parameters[9].Value = model.关联码;
            parameters[10].Value = model.进时间;
            parameters[11].Value = model.出时间;

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
        public bool Update(Maticsoft.Model.tsuhan_scgl_fx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsuhan_scgl_fx set ");
            strSql.Append("序列号=@序列号,");
            strSql.Append("客户=@客户,");
            strSql.Append("型号=@型号,");
            strSql.Append("成品编码=@成品编码,");
            strSql.Append("原因=@原因,");
            strSql.Append("工位=@工位,");
            strSql.Append("处理方式=@处理方式,");
            strSql.Append("不良现象=@不良现象,");
            strSql.Append("次数=@次数,");
            strSql.Append("关联码=@关联码,");
            strSql.Append("进时间=@进时间,");
            strSql.Append("出时间=@出时间");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,20),
					new SqlParameter("@客户", SqlDbType.NVarChar,20),
					new SqlParameter("@型号", SqlDbType.NVarChar,20),
					new SqlParameter("@成品编码", SqlDbType.NVarChar,30),
					new SqlParameter("@原因", SqlDbType.NVarChar,50),
					new SqlParameter("@工位", SqlDbType.NVarChar,20),
					new SqlParameter("@处理方式", SqlDbType.NVarChar,50),
					new SqlParameter("@不良现象", SqlDbType.NVarChar,50),
					new SqlParameter("@次数", SqlDbType.Int,4),
                    new SqlParameter("@关联码",SqlDbType.NVarChar,20),
					new SqlParameter("@进时间", SqlDbType.DateTime,8),
                    new SqlParameter("@出时间",SqlDbType.DateTime,8),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.序列号;
            parameters[1].Value = model.客户;
            parameters[2].Value = model.型号;
            parameters[3].Value = model.成品编码;
            parameters[4].Value = model.原因;
            parameters[5].Value = model.工位;
            parameters[6].Value = model.处理方式;
            parameters[7].Value = model.不良现象;
            parameters[8].Value = model.次数;
            parameters[9].Value = model.关联码;
            parameters[10].Value = model.进时间;
            parameters[11].Value = model.出时间;
            parameters[12].Value = model.id;

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


        public tsuhan_scgl_fx SelectAllXlh(string 序列号)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select * from tsuhan_scgl_fx ");
            strSql.Append("select top 1 id,序列号,客户,型号,成品编码,原因,工位,处理方式,不良现象,次数,关联码,进时间,出时间 from tsuhan_scgl_fx");
            strSql.Append(" where 序列号=@序列号 ");
            strSql.Append(" order by [id] desc ");
            SqlParameter[] parameters = {
					new SqlParameter("@序列号", SqlDbType.NVarChar,20)			};
            parameters[0].Value = 序列号;

            Maticsoft.Model.tsuhan_scgl_fx model = new Maticsoft.Model.tsuhan_scgl_fx();
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
        public Maticsoft.Model.tsuhan_scgl_fx DataRowToModel(DataRow row)
        {
            Maticsoft.Model.tsuhan_scgl_fx model = new Maticsoft.Model.tsuhan_scgl_fx();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["序列号"] != null)
                {
                    model.序列号 = row["序列号"].ToString();
                }
                if (row["客户"] != null)
                {
                    model.客户 = row["客户"].ToString();
                }
                if (row["型号"] != null)
                {
                    model.型号 = row["型号"].ToString();
                }
                if (row["成品编码"] != null)
                {
                    model.成品编码 = row["成品编码"].ToString();
                }
                if (row["原因"] != null)
                {
                    model.原因 = row["原因"].ToString();
                }
                if (row["工位"] != null)
                {
                    model.工位 = row["工位"].ToString();
                }
                if (row["处理方式"] != null)
                {
                    model.处理方式 = row["处理方式"].ToString();
                }
                if (row["不良现象"] != null)
                {
                    model.不良现象 = row["不良现象"].ToString();
                }
                if (row["次数"] != null && row["次数"].ToString() != "")
                {
                    model.次数 = int.Parse(row["次数"].ToString());
                }
                if (row["关联码"] != null)
                {
                    model.关联码 = row["关联码"].ToString();
                }
                if (row["进时间"] != null && row["进时间"].ToString() != "")
                {
                    model.进时间 = DateTime.Parse(row["进时间"].ToString());
                }
                if (row["出时间"] != null && row["出时间"].ToString() != "")
                {
                    model.出时间 = DateTime.Parse(row["出时间"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 判断是否有关联码
        /// </summary>
        /// <param name="gl"></param>
        /// <returns></returns>
        public bool Exist(string 关联码)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsuhan_scgl_fx");
            strSql.Append(" where 关联码=@关联码 ");
            SqlParameter[] parameters = {
					new SqlParameter("@关联码", SqlDbType.NVarChar,20)			};
            parameters[0].Value = 关联码;

            return dbhelper1.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 根据关联码查询信息
        /// </summary>
        /// <param name="gl"></param>
        /// <returns></returns>
        public tsuhan_scgl_fx SelectGLM(string 关联码)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select * from tsuhan_scgl_fx ");
            strSql.Append("select top 1 id,序列号,客户,型号,成品编码,原因,工位,处理方式,不良现象,次数,关联码,进时间,出时间 from tsuhan_scgl_fx");
            strSql.Append(" where 关联码=@关联码 ");
            strSql.Append(" order by [id] desc ");
            SqlParameter[] parameters = {
					new SqlParameter("@关联码", SqlDbType.NVarChar,20)			};
            parameters[0].Value = 关联码;

            Maticsoft.Model.tsuhan_scgl_fx model = new Maticsoft.Model.tsuhan_scgl_fx();
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
        /// 根据出时间查询
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public DataSet GetSelectTime(string 出时间,string time2)
        {
            string sql = @"SELECT 关联码,序列号 FROM tsuhan_scgl_fx where 关联码 is not null and 出时间 is not null
                            and 出时间 between '"+出时间+"' and '"+time2+"'and id in(select max(id) from tsuhan_scgl_fx group by 关联码 having count(*)>1)";
            //StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT 关联码,序列号 FROM tsuhan_scgl_fx");
            //strSql.Append(" where 关联码 is not null and 出时间 is not null");
            //strSql.Append(" and 出时间 between @出时间 and @time2");
            //strSql.Append(" and id in(select max(id) from tsuhan_scgl_fx group by 关联码 having count(*)>1)");
            //SqlParameter[] parameters = {
            //        new SqlParameter("@出时间", SqlDbType.DateTime,8),
            //        new SqlParameter("@time2", SqlDbType.DateTime,8)			};
            //parameters[0].Value = 出时间;
            //parameters[1].Value = time2;
            return dbhelper1.Query(sql.ToString());
        }
    }
}
