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
    /// <summary>
    /// 材料清单操作类
    /// </summary>
    public class BhdDAL
    {
        DbHelperSQLP dbhelper1 = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString"));
        /// <summary>
        /// 根据备货单号查询材料清单
        /// </summary>
        /// <param name="beiHuo"></param>
        /// <returns></returns>
        public tsuhan_sg_bhd QueryByBei(string beiHuo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsuhan_sg_bhd where ");
            strSql.Append("备货单号 = @beiHuo");
            SqlParameter[] parameters ={
                                          new SqlParameter("@beiHuo",SqlDbType.NVarChar,30)
                                      };
            parameters[0].Value = beiHuo;
            tsuhan_sg_bhd model = new tsuhan_sg_bhd();
            DataSet ds = dbhelper1.Query(strSql.ToString(),parameters);
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
        public Maticsoft.Model.tsuhan_sg_bhd DataRowToModel(DataRow row)
        {
            Maticsoft.Model.tsuhan_sg_bhd model = new Maticsoft.Model.tsuhan_sg_bhd();
            if (row != null)
            {
                if (row["备货单号"] != null)
                {
                    model.备货单号 = row["备货单号"].ToString();
                }
                if (row["LD_lx"] != null)
                {
                    model.LD_lx = row["LD_lx"].ToString();
                }
                if (row["LD_xh"] != null)
                {
                    model.LD_xh = row["LD_xh"].ToString();
                }
                if (row["LD_name"] != null)
                {
                    model.LD_name = row["LD_name"].ToString();
                }
                if (row["LD_sjdh"] != null)
                {
                    model.LD_sjdh = row["LD_sjdh"].ToString();
                }
                if (row["LD_remark"] != null)
                {
                    model.LD_remark = row["LD_remark"].ToString();
                }
                if (row["PT_lx"] != null)
                {
                    model.PT_lx = row["PT_lx"].ToString();
                }
                if (row["PT_xh"] != null)
                {
                    model.PT_xh = row["PT_xh"].ToString();
                }
                if (row["PT_name"] != null)
                {
                    model.PT_name = row["PT_name"].ToString();
                }
                if (row["PT_sjdh"] != null)
                {
                    model.PT_sjdh = row["PT_sjdh"].ToString();
                }
                if (row["PT_remark"] != null)
                {
                    model.PT_remark = row["PT_remark"].ToString();
                }
                if (row["KT_lx"] != null)
                {
                    model.KT_lx = row["KT_lx"].ToString();
                }
                if (row["KT_xh"] != null)
                {
                    model.KT_xh = row["KT_xh"].ToString();
                }
                if (row["KT_name"] != null)
                {
                    model.KT_name = row["KT_name"].ToString();
                }
                if (row["KT_sjdh"] != null)
                {
                    model.KT_sjdh = row["KT_sjdh"].ToString();
                }
                if (row["KT_remark"] != null)
                {
                    model.KT_remark = row["KT_remark"].ToString();
                }
                if (row["NBP_lx0"] != null)
                {
                    model.NBP_lx0 = row["NBP_lx0"].ToString();
                }
                if (row["NBP_xh0"] != null)
                {
                    model.NBP_xh0 = row["NBP_xh0"].ToString();
                }
                if (row["NBP_name0"] != null)
                {
                    model.NBP_name0 = row["NBP_name0"].ToString();
                }
                if (row["NBP_sjdh0"] != null)
                {
                    model.NBP_sjdh0 = row["NBP_sjdh0"].ToString();
                }
                if (row["NBP_remark0"] != null)
                {
                    model.NBP_remark0 = row["NBP_remark0"].ToString();
                }
                if (row["NBP_lx45"] != null)
                {
                    model.NBP_lx45 = row["NBP_lx45"].ToString();
                }
                if (row["NBP_xh45"] != null)
                {
                    model.NBP_xh45 = row["NBP_xh45"].ToString();
                }
                if (row["NBP_name45"] != null)
                {
                    model.NBP_name45 = row["NBP_name45"].ToString();
                }
                if (row["NBP_sjdh45"] != null)
                {
                    model.NBP_sjdh45 = row["NBP_sjdh45"].ToString();
                }
                if (row["NBP_remark45"] != null)
                {
                    model.NBP_remark45 = row["NBP_remark45"].ToString();
                }
                if (row["JK_lx"] != null)
                {
                    model.JK_lx = row["JK_lx"].ToString();
                }
                if (row["JK_xh"] != null)
                {
                    model.JK_xh = row["JK_xh"].ToString();
                }
                if (row["JK_name"] != null)
                {
                    model.JK_name = row["JK_name"].ToString();
                }
                if (row["JK_sjdh"] != null)
                {
                    model.JK_sjdh = row["JK_sjdh"].ToString();
                }
                if (row["JK_remark"] != null)
                {
                    model.JK_remark = row["JK_remark"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 判断是否存在该记录
        /// </summary>
        /// <param name="备货单号"></param>
        /// <returns></returns>
        public bool Exists(string 备货单号)
        {
            string sql = "select * from tsuhan_sg_bhd where 备货单号='" + 备货单号 + "'";
            SqlParameter[] parameters = {
					new SqlParameter("@备货单号", SqlDbType.NVarChar,30)			};
            parameters[0].Value = 备货单号;
            return dbhelper1.Exists(sql, parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(tsuhan_sg_bhd model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_sg_bhd(");
            strSql.Append("备货单号,LD_lx,LD_xh,LD_name,LD_sjdh,LD_remark,PT_lx,PT_xh,PT_name,PT_sjdh,PT_remark,KT_lx,KT_xh,KT_name,KT_sjdh,KT_remark,NBP_lx0,NBP_xh0,NBP_name0,NBP_sjdh0,NBP_remark0,NBP_lx45,NBP_xh45,NBP_name45,NBP_sjdh45,NBP_remark45,JK_lx,JK_xh,JK_name,JK_sjdh,JK_remark)");
            strSql.Append(" values (");
            strSql.Append("@备货单号,@LD_lx,@LD_xh,@LD_name,@LD_sjdh,@LD_remark,@PT_lx,@PT_xh,@PT_name,@PT_sjdh,@PT_remark,@KT_lx,@KT_xh,@KT_name,@KT_sjdh,@KT_remark,@NBP_lx0,@NBP_xh0,@NBP_name0,@NBP_sjdh0,@NBP_remark0,@NBP_lx45,@NBP_xh45,@NBP_name45,@NBP_sjdh45,@NBP_remark45,@JK_lx,@JK_xh,@JK_name,@JK_sjdh,@JK_remark)");
            SqlParameter[] parameters = {
                    new SqlParameter("@备货单号", SqlDbType.NVarChar,30),
                    new SqlParameter("@LD_lx", SqlDbType.NVarChar,30),
                    new SqlParameter("@LD_xh", SqlDbType.NVarChar,20),
                    new SqlParameter("@LD_name", SqlDbType.NVarChar,30),
                    new SqlParameter("@LD_sjdh", SqlDbType.NVarChar,20),
                    new SqlParameter("@LD_remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@PT_lx", SqlDbType.NVarChar,30),
                    new SqlParameter("@PT_xh", SqlDbType.NVarChar,20),
                    new SqlParameter("@PT_name", SqlDbType.NVarChar,30),
                    new SqlParameter("@PT_sjdh", SqlDbType.NVarChar,20),
                    new SqlParameter("@PT_remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@KT_lx", SqlDbType.NVarChar,30),
                    new SqlParameter("@KT_xh", SqlDbType.NVarChar,20),
                    new SqlParameter("@KT_name", SqlDbType.NVarChar,30),
                    new SqlParameter("@KT_sjdh", SqlDbType.NVarChar,20),
                    new SqlParameter("@KT_remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@NBP_lx0", SqlDbType.NVarChar,30),
                    new SqlParameter("@NBP_xh0", SqlDbType.NVarChar,20),
                    new SqlParameter("@NBP_name0", SqlDbType.NVarChar,30),
                    new SqlParameter("@NBP_sjdh0", SqlDbType.NVarChar,20),
                    new SqlParameter("@NBP_remark0", SqlDbType.NVarChar,50),
                    new SqlParameter("@NBP_lx45", SqlDbType.NVarChar,30),
                    new SqlParameter("@NBP_xh45", SqlDbType.NVarChar,20),
                    new SqlParameter("@NBP_name45", SqlDbType.NVarChar,30),
                    new SqlParameter("@NBP_sjdh45", SqlDbType.NVarChar,20),
                    new SqlParameter("@NBP_remark45", SqlDbType.NVarChar,50),
                    new SqlParameter("@JK_lx", SqlDbType.NVarChar,30),
                    new SqlParameter("@JK_xh", SqlDbType.NVarChar,20),
                    new SqlParameter("@JK_name", SqlDbType.NVarChar,30),
                    new SqlParameter("@JK_sjdh", SqlDbType.NVarChar,20),
                    new SqlParameter("@JK_remark", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.备货单号;
            parameters[1].Value = model.LD_lx;
            parameters[2].Value = model.LD_xh;
            parameters[3].Value = model.LD_name;
            parameters[4].Value = model.LD_sjdh;
            parameters[5].Value = model.LD_remark;
            parameters[6].Value = model.PT_lx;
            parameters[7].Value = model.PT_xh;
            parameters[8].Value = model.PT_name;
            parameters[9].Value = model.PT_sjdh;
            parameters[10].Value = model.PT_remark;
            parameters[11].Value = model.KT_lx;
            parameters[12].Value = model.KT_xh;
            parameters[13].Value = model.KT_name;
            parameters[14].Value = model.KT_sjdh;
            parameters[15].Value = model.KT_remark;
            parameters[16].Value = model.NBP_lx0;
            parameters[17].Value = model.NBP_xh0;
            parameters[18].Value = model.NBP_name0;
            parameters[19].Value = model.NBP_sjdh0;
            parameters[20].Value = model.NBP_remark0;
            parameters[21].Value = model.NBP_lx45;
            parameters[22].Value = model.NBP_xh45;
            parameters[23].Value = model.NBP_name45;
            parameters[24].Value = model.NBP_sjdh45;
            parameters[25].Value = model.NBP_remark45;
            parameters[26].Value = model.JK_lx;
            parameters[27].Value = model.JK_xh;
            parameters[28].Value = model.JK_name;
            parameters[29].Value = model.JK_sjdh;
            parameters[30].Value = model.JK_remark;

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
        public bool Update(tsuhan_sg_bhd model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsuhan_sg_bhd set ");
            strSql.Append("LD_lx=@LD_lx,");
            strSql.Append("LD_xh=@LD_xh,");
            strSql.Append("LD_name=@LD_name,");
            strSql.Append("LD_sjdh=@LD_sjdh,");
            strSql.Append("LD_remark=@LD_remark,");
            strSql.Append("PT_lx=@PT_lx,");
            strSql.Append("PT_xh=@PT_xh,");
            strSql.Append("PT_name=@PT_name,");
            strSql.Append("PT_sjdh=@PT_sjdh,");
            strSql.Append("PT_remark=@PT_remark,");
            strSql.Append("KT_lx=@KT_lx,");
            strSql.Append("KT_xh=@KT_xh,");
            strSql.Append("KT_name=@KT_name,");
            strSql.Append("KT_sjdh=@KT_sjdh,");
            strSql.Append("KT_remark=@KT_remark,");
            strSql.Append("NBP_lx0=@NBP_lx0,");
            strSql.Append("NBP_xh0=@NBP_xh0,");
            strSql.Append("NBP_name0=@NBP_name0,");
            strSql.Append("NBP_sjdh0=@NBP_sjdh0,");
            strSql.Append("NBP_remark0=@NBP_remark0,");
            strSql.Append("NBP_lx45=@NBP_lx45,");
            strSql.Append("NBP_xh45=@NBP_xh45,");
            strSql.Append("NBP_name45=@NBP_name45,");
            strSql.Append("NBP_sjdh45=@NBP_sjdh45,");
            strSql.Append("NBP_remark45=@NBP_remark45,");
            strSql.Append("JK_lx=@JK_lx,");
            strSql.Append("JK_xh=@JK_xh,");
            strSql.Append("JK_name=@JK_name,");
            strSql.Append("JK_sjdh=@JK_sjdh,");
            strSql.Append("JK_remark=@JK_remark");
            strSql.Append(" where 备货单号=@备货单号 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@LD_lx", SqlDbType.NVarChar,30),
                    new SqlParameter("@LD_xh", SqlDbType.NVarChar,20),
                    new SqlParameter("@LD_name", SqlDbType.NVarChar,30),
                    new SqlParameter("@LD_sjdh", SqlDbType.NVarChar,20),
                    new SqlParameter("@LD_remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@PT_lx", SqlDbType.NVarChar,30),
                    new SqlParameter("@PT_xh", SqlDbType.NVarChar,20),
                    new SqlParameter("@PT_name", SqlDbType.NVarChar,30),
                    new SqlParameter("@PT_sjdh", SqlDbType.NVarChar,20),
                    new SqlParameter("@PT_remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@KT_lx", SqlDbType.NVarChar,30),
                    new SqlParameter("@KT_xh", SqlDbType.NVarChar,20),
                    new SqlParameter("@KT_name", SqlDbType.NVarChar,30),
                    new SqlParameter("@KT_sjdh", SqlDbType.NVarChar,20),
                    new SqlParameter("@KT_remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@NBP_lx0", SqlDbType.NVarChar,30),
                    new SqlParameter("@NBP_xh0", SqlDbType.NVarChar,20),
                    new SqlParameter("@NBP_name0", SqlDbType.NVarChar,30),
                    new SqlParameter("@NBP_sjdh0", SqlDbType.NVarChar,20),
                    new SqlParameter("@NBP_remark0", SqlDbType.NVarChar,50),
                    new SqlParameter("@NBP_lx45", SqlDbType.NVarChar,30),
                    new SqlParameter("@NBP_xh45", SqlDbType.NVarChar,20),
                    new SqlParameter("@NBP_name45", SqlDbType.NVarChar,30),
                    new SqlParameter("@NBP_sjdh45", SqlDbType.NVarChar,20),
                    new SqlParameter("@NBP_remark45", SqlDbType.NVarChar,50),
                    new SqlParameter("@JK_lx", SqlDbType.NVarChar,30),
                    new SqlParameter("@JK_xh", SqlDbType.NVarChar,20),
                    new SqlParameter("@JK_name", SqlDbType.NVarChar,30),
                    new SqlParameter("@JK_sjdh", SqlDbType.NVarChar,20),
                    new SqlParameter("@JK_remark", SqlDbType.NVarChar,50),
                    new SqlParameter("@备货单号", SqlDbType.NVarChar,30)};
            parameters[0].Value = model.LD_lx;
            parameters[1].Value = model.LD_xh;
            parameters[2].Value = model.LD_name;
            parameters[3].Value = model.LD_sjdh;
            parameters[4].Value = model.LD_remark;
            parameters[5].Value = model.PT_lx;
            parameters[6].Value = model.PT_xh;
            parameters[7].Value = model.PT_name;
            parameters[8].Value = model.PT_sjdh;
            parameters[9].Value = model.PT_remark;
            parameters[10].Value = model.KT_lx;
            parameters[11].Value = model.KT_xh;
            parameters[12].Value = model.KT_name;
            parameters[13].Value = model.KT_sjdh;
            parameters[14].Value = model.KT_remark;
            parameters[15].Value = model.NBP_lx0;
            parameters[16].Value = model.NBP_xh0;
            parameters[17].Value = model.NBP_name0;
            parameters[18].Value = model.NBP_sjdh0;
            parameters[19].Value = model.NBP_remark0;
            parameters[20].Value = model.NBP_lx45;
            parameters[21].Value = model.NBP_xh45;
            parameters[22].Value = model.NBP_name45;
            parameters[23].Value = model.NBP_sjdh45;
            parameters[24].Value = model.NBP_remark45;
            parameters[25].Value = model.JK_lx;
            parameters[26].Value = model.JK_xh;
            parameters[27].Value = model.JK_name;
            parameters[28].Value = model.JK_sjdh;
            parameters[29].Value = model.JK_remark;
            parameters[30].Value = model.备货单号;

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
    }
}
