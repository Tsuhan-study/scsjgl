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
    public class GtDAL
    {
        DbHelperSQLP dbhelper = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString"));
        /// <summary>
        /// 根据备货单号查询信息
        /// </summary>
        /// <param name="备货单号"></param>
        /// <returns></returns>
        public bool Exists(string 备货单号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsuhan_sg_gt");
            strSql.Append(" where 备货单号=@备货单号 ");
            SqlParameter[] parameters = {
					new SqlParameter("@备货单号", SqlDbType.NVarChar,30)			};
            parameters[0].Value = 备货单号;
            return dbhelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询单条记录
        /// </summary>
        /// <param name="备货单号"></param>
        /// <returns></returns>
        public tsuhan_sg_gt GetModel(string 备货单号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,备货单号,交货日期,下单日期,表格编号,合同编号,规格书编号,产品名称,备货单数量,随工卡数量,产品图号,产品类型,成品编码,BK_A,BK_B,BK_C,LD_LDjj,GX_hjfs,OH_hqPomin,OH_hqPomax,OH_hqBFB,OH_hhPomin,OH_hhPomax,OH_hhBFB,DM_dmzl,PT_rqgl,PT_gdlmin,PT_gdlmax,GDW_xhcs,LD_CSPomin,LD_CSPomax,LD_CSBFB,LD_LDKINK,LD_PDKINK,PT_CStj,PT_CSpl,PT_LMd,PT_LMd2,PT_ICCmin,PT_ICCmax,BZ_QJbq,GD_if,GD_ccglMin,GD_ccglMax,GD_imoMin,GD_imoMax,GD_ithMin,GD_ithMax,GD_vfMin,GD_vfMax,GD_ptsl,GD_vbrMin,GD_vbrMax,JX_wdMin,JX_wdMax,JX_zz,JX_pthigh,JX_ptwwj,JX_ldgj,JX_ptgj,fh产品名称,Description,物料代码,型号属性,Specification,客户型号,LD芯片型号,PT芯片型号,Quantity1,Quantity2,数量,计划编制,技术审核,生产审核,录入员,录入时间,客户代码,生产日期 from tsuhan_sg_gt");
            strSql.Append(" where 备货单号=@备货单号 ");
            SqlParameter[] parameters = {
					new SqlParameter("@备货单号", SqlDbType.NVarChar,30)			};
            parameters[0].Value = 备货单号;

            Maticsoft.Model.tsuhan_sg_gt model = new Maticsoft.Model.tsuhan_sg_gt();
            DataSet ds = dbhelper.Query(strSql.ToString(), parameters);
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
        public tsuhan_sg_gt DataRowToModel(DataRow row)
        {
            Maticsoft.Model.tsuhan_sg_gt model = new Maticsoft.Model.tsuhan_sg_gt();
            if (row != null)
            {

                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["备货单号"] != null)
                {
                    model.备货单号 = row["备货单号"].ToString();
                }
                if (row["交货日期"] != null && row["交货日期"].ToString() != "")
                {
                    model.交货日期 = DateTime.Parse(row["交货日期"].ToString());
                }
                if (row["下单日期"] != null && row["下单日期"].ToString() != "")
                {
                    model.下单日期 = DateTime.Parse(row["下单日期"].ToString());
                }
                if (row["表格编号"] != null)
                {
                    model.表格编号 = row["表格编号"].ToString();
                }
                if (row["合同编号"] != null)
                {
                    model.合同编号 = row["合同编号"].ToString();
                }
                if (row["规格书编号"] != null)
                {
                    model.规格书编号 = row["规格书编号"].ToString();
                }
                if (row["产品名称"] != null)
                {
                    model.产品名称 = row["产品名称"].ToString();
                }
                if (row["备货单数量"] != null && row["备货单数量"].ToString() != "")
                {
                    model.备货单数量 = int.Parse(row["备货单数量"].ToString());
                }
                if (row["随工卡数量"] != null && row["随工卡数量"].ToString() != "")
                {
                    model.随工卡数量 = int.Parse(row["随工卡数量"].ToString());
                }
                if (row["产品图号"] != null)
                {
                    model.产品图号 = row["产品图号"].ToString();
                }
                if (row["产品类型"] != null)
                {
                    model.产品类型 = row["产品类型"].ToString();
                }
                if (row["成品编码"] != null)
                {
                    model.成品编码 = row["成品编码"].ToString();
                }
                if (row["BK_A"] != null)
                {
                    model.BK_A = row["BK_A"].ToString();
                }
                if (row["BK_B"] != null)
                {
                    model.BK_B = row["BK_B"].ToString();
                }
                if (row["BK_C"] != null)
                {
                    model.BK_C = row["BK_C"].ToString();
                }
                if (row["LD_LDjj"] != null && row["LD_LDjj"].ToString() != "")
                {
                    model.LD_LDjj = decimal.Parse(row["LD_LDjj"].ToString());
                }
                if (row["GX_hjfs"] != null)
                {
                    model.GX_hjfs = row["GX_hjfs"].ToString();
                }
                if (row["OH_hqPomin"] != null && row["OH_hqPomin"].ToString() != "")
                {
                    model.OH_hqPomin = decimal.Parse(row["OH_hqPomin"].ToString());
                }
                if (row["OH_hqPomax"] != null && row["OH_hqPomax"].ToString() != "")
                {
                    model.OH_hqPomax = decimal.Parse(row["OH_hqPomax"].ToString());
                }
                if (row["OH_hqBFB"] != null && row["OH_hqBFB"].ToString() != "")
                {
                    model.OH_hqBFB = int.Parse(row["OH_hqBFB"].ToString());
                }
                if (row["OH_hhPomin"] != null && row["OH_hhPomin"].ToString() != "")
                {
                    model.OH_hhPomin = decimal.Parse(row["OH_hhPomin"].ToString());
                }
                if (row["OH_hhPomax"] != null && row["OH_hhPomax"].ToString() != "")
                {
                    model.OH_hhPomax = decimal.Parse(row["OH_hhPomax"].ToString());
                }
                if (row["OH_hhBFB"] != null && row["OH_hhBFB"].ToString() != "")
                {
                    model.OH_hhBFB = int.Parse(row["OH_hhBFB"].ToString());
                }
                if (row["DM_dmzl"] != null)
                {
                    model.DM_dmzl = row["DM_dmzl"].ToString();
                }
                if (row["PT_rqgl"] != null && row["PT_rqgl"].ToString() != "")
                {
                    model.PT_rqgl = int.Parse(row["PT_rqgl"].ToString());
                }
                if (row["PT_gdlmin"] != null)
                {
                    model.PT_gdlmin = row["PT_gdlmin"].ToString();
                }
                if (row["PT_gdlmax"] != null)
                {
                    model.PT_gdlmax = row["PT_gdlmax"].ToString();
                }
                if (row["GDW_xhcs"] != null && row["GDW_xhcs"].ToString() != "")
                {
                    model.GDW_xhcs = int.Parse(row["GDW_xhcs"].ToString());
                }
                if (row["LD_CSPomin"] != null && row["LD_CSPomin"].ToString() != "")
                {
                    model.LD_CSPomin = decimal.Parse(row["LD_CSPomin"].ToString());
                }
                if (row["LD_CSPomax"] != null && row["LD_CSPomax"].ToString() != "")
                {
                    model.LD_CSPomax = decimal.Parse(row["LD_CSPomax"].ToString());
                }
                if (row["LD_CSBFB"] != null && row["LD_CSBFB"].ToString() != "")
                {
                    model.LD_CSBFB = int.Parse(row["LD_CSBFB"].ToString());
                }
                if (row["LD_LDKINK"] != null && row["LD_LDKINK"].ToString() != "")
                {
                    model.LD_LDKINK = int.Parse(row["LD_LDKINK"].ToString());
                }
                if (row["LD_PDKINK"] != null && row["LD_PDKINK"].ToString() != "")
                {
                    model.LD_PDKINK = int.Parse(row["LD_PDKINK"].ToString());
                }
                if (row["PT_CStj"] != null)
                {
                    model.PT_CStj = row["PT_CStj"].ToString();
                }
                if (row["PT_CSpl"] != null && row["PT_CSpl"].ToString() != "")
                {
                    model.PT_CSpl = decimal.Parse(row["PT_CSpl"].ToString());
                }
                if (row["PT_LMd"] != null)
                {
                    model.PT_LMd = row["PT_LMd"].ToString();
                }
                if (row["PT_LMd2"] != null)
                {
                    model.PT_LMd2 = row["PT_LMd2"].ToString();
                }
                if (row["PT_ICCmin"] != null && row["PT_ICCmin"].ToString() != "")
                {
                    model.PT_ICCmin = int.Parse(row["PT_ICCmin"].ToString());
                }
                if (row["PT_ICCmax"] != null && row["PT_ICCmax"].ToString() != "")
                {
                    model.PT_ICCmax = int.Parse(row["PT_ICCmax"].ToString());
                }
                if (row["BZ_QJbq"] != null)
                {
                    model.BZ_QJbq = row["BZ_QJbq"].ToString();
                }
                if (row["GD_if"] != null)
                {
                    model.GD_if = row["GD_if"].ToString();
                }
                if (row["GD_ccglMin"] != null && row["GD_ccglMin"].ToString() != "")
                {
                    model.GD_ccglMin = decimal.Parse(row["GD_ccglMin"].ToString());
                }
                if (row["GD_ccglMax"] != null && row["GD_ccglMax"].ToString() != "")
                {
                    model.GD_ccglMax = decimal.Parse(row["GD_ccglMax"].ToString());
                }
                if (row["GD_imoMin"] != null && row["GD_imoMin"].ToString() != "")
                {
                    model.GD_imoMin = int.Parse(row["GD_imoMin"].ToString());
                }
                if (row["GD_imoMax"] != null && row["GD_imoMax"].ToString() != "")
                {
                    model.GD_imoMax = int.Parse(row["GD_imoMax"].ToString());
                }
                if (row["GD_ithMin"] != null && row["GD_ithMin"].ToString() != "")
                {
                    model.GD_ithMin = int.Parse(row["GD_ithMin"].ToString());
                }
                if (row["GD_ithMax"] != null && row["GD_ithMax"].ToString() != "")
                {
                    model.GD_ithMax = int.Parse(row["GD_ithMax"].ToString());
                }
                if (row["GD_vfMin"] != null && row["GD_vfMin"].ToString() != "")
                {
                    model.GD_vfMin = decimal.Parse(row["GD_vfMin"].ToString());
                }
                if (row["GD_vfMax"] != null && row["GD_vfMax"].ToString() != "")
                {
                    model.GD_vfMax = decimal.Parse(row["GD_vfMax"].ToString());
                }
                if (row["GD_ptsl"] != null)
                {
                    model.GD_ptsl = row["GD_ptsl"].ToString();
                }
                if (row["GD_vbrMin"] != null && row["GD_vbrMin"].ToString() != "")
                {
                    model.GD_vbrMin = int.Parse(row["GD_vbrMin"].ToString());
                }
                if (row["GD_vbrMax"] != null && row["GD_vbrMax"].ToString() != "")
                {
                    model.GD_vbrMax = int.Parse(row["GD_vbrMax"].ToString());
                }
                if (row["JX_wdMin"] != null && row["JX_wdMin"].ToString() != "")
                {
                    model.JX_wdMin = int.Parse(row["JX_wdMin"].ToString());
                }
                if (row["JX_wdMax"] != null && row["JX_wdMax"].ToString() != "")
                {
                    model.JX_wdMax = int.Parse(row["JX_wdMax"].ToString());
                }
                if (row["JX_zz"] != null)
                {
                    model.JX_zz = row["JX_zz"].ToString();
                }
                if (row["JX_pthigh"] != null)
                {
                    model.JX_pthigh = row["JX_pthigh"].ToString();
                }
                if (row["JX_ptwwj"] != null)
                {
                    model.JX_ptwwj = row["JX_ptwwj"].ToString();
                }
                if (row["JX_ldgj"] != null)
                {
                    model.JX_ldgj = row["JX_ldgj"].ToString();
                }
                if (row["JX_ptgj"] != null)
                {
                    model.JX_ptgj = row["JX_ptgj"].ToString();
                }
                if (row["fh产品名称"] != null)
                {
                    model.fh产品名称 = row["fh产品名称"].ToString();
                }
                if (row["Description"] != null)
                {
                    model.Description = row["Description"].ToString();
                }
                if (row["物料代码"] != null)
                {
                    model.物料代码 = row["物料代码"].ToString();
                }
                if (row["型号属性"] != null)
                {
                    model.型号属性 = row["型号属性"].ToString();
                }
                if (row["Specification"] != null)
                {
                    model.Specification = row["Specification"].ToString();
                }
                if (row["客户型号"] != null)
                {
                    model.客户型号 = row["客户型号"].ToString();
                }
                if (row["LD芯片型号"] != null)
                {
                    model.LD芯片型号 = row["LD芯片型号"].ToString();
                }
                if (row["PT芯片型号"] != null)
                {
                    model.PT芯片型号 = row["PT芯片型号"].ToString();
                }
                if (row["Quantity1"] != null)
                {
                    model.Quantity1 = row["Quantity1"].ToString();
                }
                if (row["Quantity2"] != null)
                {
                    model.Quantity2 = row["Quantity2"].ToString();
                }
                if (row["数量"] != null)
                {
                    model.数量 = row["数量"].ToString();
                }
                if (row["计划编制"] != null)
                {
                    model.计划编制 = row["计划编制"].ToString();
                }
                if (row["技术审核"] != null)
                {
                    model.技术审核 = row["技术审核"].ToString();
                }
                if (row["生产审核"] != null)
                {
                    model.生产审核 = row["生产审核"].ToString();
                }
                if (row["录入员"] != null)
                {
                    model.录入员 = row["录入员"].ToString();
                }
                if (row["录入时间"] != null && row["录入时间"].ToString() != "")
                {
                    model.录入时间 = DateTime.Parse(row["录入时间"].ToString());
                }
                if (row["客户代码"]!=null)
                {
                    model.客户代码 = row["客户代码"].ToString();
                }
                if (row["生产日期"] != null && row["生产日期"].ToString()!="")
                {
                    model.生产日期 = DateTime.Parse(row["生产日期"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 修改tsuhan_sg_gt表信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Maticsoft.Model.tsuhan_sg_gt model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsuhan_sg_gt set ");
            strSql.Append("交货日期=@交货日期,");
            strSql.Append("下单日期=@下单日期,");
            strSql.Append("表格编号=@表格编号,");
            strSql.Append("合同编号=@合同编号,");
            strSql.Append("规格书编号=@规格书编号,");
            strSql.Append("产品名称=@产品名称,");
            strSql.Append("备货单数量=@备货单数量,");
            strSql.Append("随工卡数量=@随工卡数量,");
            strSql.Append("产品图号=@产品图号,");
            strSql.Append("产品类型=@产品类型,");
            strSql.Append("成品编码=@成品编码,");
            strSql.Append("BK_A=@BK_A,");
            strSql.Append("BK_B=@BK_B,");
            strSql.Append("BK_C=@BK_C,");
            strSql.Append("LD_LDjj=@LD_LDjj,");
            strSql.Append("GX_hjfs=@GX_hjfs,");
            strSql.Append("OH_hqPomin=@OH_hqPomin,");
            strSql.Append("OH_hqPomax=@OH_hqPomax,");
            strSql.Append("OH_hqBFB=@OH_hqBFB,");
            strSql.Append("OH_hhPomin=@OH_hhPomin,");
            strSql.Append("OH_hhPomax=@OH_hhPomax,");
            strSql.Append("OH_hhBFB=@OH_hhBFB,");
            strSql.Append("DM_dmzl=@DM_dmzl,");
            strSql.Append("PT_rqgl=@PT_rqgl,");
            strSql.Append("PT_gdlmin=@PT_gdlmin,");
            strSql.Append("PT_gdlmax=@PT_gdlmax,");
            strSql.Append("GDW_xhcs=@GDW_xhcs,");
            strSql.Append("LD_CSPomin=@LD_CSPomin,");
            strSql.Append("LD_CSPomax=@LD_CSPomax,");
            strSql.Append("LD_CSBFB=@LD_CSBFB,");
            strSql.Append("LD_LDKINK=@LD_LDKINK,");
            strSql.Append("LD_PDKINK=@LD_PDKINK,");
            strSql.Append("PT_CStj=@PT_CStj,");
            strSql.Append("PT_CSpl=@PT_CSpl,");
            strSql.Append("PT_LMd=@PT_LMd,");
            strSql.Append("PT_LMd2=@PT_LMd2,");
            strSql.Append("PT_ICCmin=@PT_ICCmin,");
            strSql.Append("PT_ICCmax=@PT_ICCmax,");
            strSql.Append("BZ_QJbq=@BZ_QJbq,");
            strSql.Append("GD_if=@GD_if,");
            strSql.Append("GD_ccglMin=@GD_ccglMin,");
            strSql.Append("GD_ccglMax=@GD_ccglMax,");
            strSql.Append("GD_imoMin=@GD_imoMin,");
            strSql.Append("GD_imoMax=@GD_imoMax,");
            strSql.Append("GD_ithMin=@GD_ithMin,");
            strSql.Append("GD_ithMax=@GD_ithMax,");
            strSql.Append("GD_vfMin=@GD_vfMin,");
            strSql.Append("GD_vfMax=@GD_vfMax,");
            strSql.Append("GD_ptsl=@GD_ptsl,");
            strSql.Append("GD_vbrMin=@GD_vbrMin,");
            strSql.Append("GD_vbrMax=@GD_vbrMax,");
            strSql.Append("JX_wdMin=@JX_wdMin,");
            strSql.Append("JX_wdMax=@JX_wdMax,");
            strSql.Append("JX_zz=@JX_zz,");
            strSql.Append("JX_pthigh=@JX_pthigh,");
            strSql.Append("JX_ptwwj=@JX_ptwwj,");
            strSql.Append("JX_ldgj=@JX_ldgj,");
            strSql.Append("JX_ptgj=@JX_ptgj,");
            strSql.Append("fh产品名称=@fh产品名称,");
            strSql.Append("Description=@Description,");
            strSql.Append("物料代码=@物料代码,");
            strSql.Append("型号属性=@型号属性,");
            strSql.Append("Specification=@Specification,");
            strSql.Append("客户型号=@客户型号,");
            strSql.Append("LD芯片型号=@LD芯片型号,");
            strSql.Append("PT芯片型号=@PT芯片型号,");
            strSql.Append("Quantity1=@Quantity1,");
            strSql.Append("Quantity2=@Quantity2,");
            strSql.Append("数量=@数量,");
            strSql.Append("计划编制=@计划编制,");
            strSql.Append("技术审核=@技术审核,");
            strSql.Append("生产审核=@生产审核,");
            strSql.Append("录入员=@录入员,");
            strSql.Append("录入时间=@录入时间,");
            strSql.Append("客户代码=@客户代码,");
            strSql.Append("生产日期=@生产日期");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@交货日期", SqlDbType.DateTime),
					new SqlParameter("@下单日期", SqlDbType.DateTime),
					new SqlParameter("@表格编号", SqlDbType.NVarChar,20),
					new SqlParameter("@合同编号", SqlDbType.NVarChar,40),
					new SqlParameter("@规格书编号", SqlDbType.NVarChar,40),
					new SqlParameter("@产品名称", SqlDbType.NVarChar,50),
					new SqlParameter("@备货单数量", SqlDbType.Int,4),
					new SqlParameter("@随工卡数量", SqlDbType.Int,4),
					new SqlParameter("@产品图号", SqlDbType.NVarChar,20),
					new SqlParameter("@产品类型", SqlDbType.NVarChar,10),
					new SqlParameter("@成品编码", SqlDbType.NVarChar,40),
					new SqlParameter("@BK_A", SqlDbType.NVarChar,40),
					new SqlParameter("@BK_B", SqlDbType.NVarChar,40),
					new SqlParameter("@BK_C", SqlDbType.NVarChar,40),
					new SqlParameter("@LD_LDjj", SqlDbType.Float,8),
					new SqlParameter("@GX_hjfs", SqlDbType.NVarChar,15),
					new SqlParameter("@OH_hqPomin", SqlDbType.Float,8),
					new SqlParameter("@OH_hqPomax", SqlDbType.Float,8),
					new SqlParameter("@OH_hqBFB", SqlDbType.Int,4),
					new SqlParameter("@OH_hhPomin", SqlDbType.Float,8),
					new SqlParameter("@OH_hhPomax", SqlDbType.Float,8),
					new SqlParameter("@OH_hhBFB", SqlDbType.Int,4),
					new SqlParameter("@DM_dmzl", SqlDbType.NVarChar,40),
					new SqlParameter("@PT_rqgl", SqlDbType.Int,4),
					new SqlParameter("@PT_gdlmin", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_gdlmax", SqlDbType.NVarChar,20),
					new SqlParameter("@GDW_xhcs", SqlDbType.Int,4),
					new SqlParameter("@LD_CSPomin", SqlDbType.Float,8),
					new SqlParameter("@LD_CSPomax", SqlDbType.Float,8),
					new SqlParameter("@LD_CSBFB", SqlDbType.Int,4),
					new SqlParameter("@LD_LDKINK", SqlDbType.Int,4),
					new SqlParameter("@LD_PDKINK", SqlDbType.Int,4),
					new SqlParameter("@PT_CStj", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_CSpl", SqlDbType.Float,8),
					new SqlParameter("@PT_LMd", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_LMd2", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_ICCmin", SqlDbType.Int,4),
					new SqlParameter("@PT_ICCmax", SqlDbType.Int,4),
					new SqlParameter("@BZ_QJbq", SqlDbType.NVarChar,20),
					new SqlParameter("@GD_if", SqlDbType.NVarChar,10),
					new SqlParameter("@GD_ccglMin", SqlDbType.Float,8),
					new SqlParameter("@GD_ccglMax", SqlDbType.Float,8),
					new SqlParameter("@GD_imoMin", SqlDbType.Int,4),
					new SqlParameter("@GD_imoMax", SqlDbType.Int,4),
					new SqlParameter("@GD_ithMin", SqlDbType.Int,4),
					new SqlParameter("@GD_ithMax", SqlDbType.Int,4),
					new SqlParameter("@GD_vfMin", SqlDbType.Float,8),
					new SqlParameter("@GD_vfMax", SqlDbType.Float,8),
					new SqlParameter("@GD_ptsl", SqlDbType.NVarChar,10),
					new SqlParameter("@GD_vbrMin", SqlDbType.Int,4),
					new SqlParameter("@GD_vbrMax", SqlDbType.Int,4),
					new SqlParameter("@JX_wdMin", SqlDbType.Int,4),
					new SqlParameter("@JX_wdMax", SqlDbType.Int,4),
					new SqlParameter("@JX_zz", SqlDbType.NVarChar,10),
					new SqlParameter("@JX_pthigh", SqlDbType.NVarChar,20),
					new SqlParameter("@JX_ptwwj", SqlDbType.NVarChar,20),
					new SqlParameter("@JX_ldgj", SqlDbType.NVarChar,2),
					new SqlParameter("@JX_ptgj", SqlDbType.NVarChar,2),
					new SqlParameter("@fh产品名称", SqlDbType.NVarChar,50),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@物料代码", SqlDbType.NVarChar,30),
					new SqlParameter("@型号属性", SqlDbType.NVarChar,30),
					new SqlParameter("@Specification", SqlDbType.NVarChar,30),
					new SqlParameter("@客户型号", SqlDbType.NVarChar,50),
					new SqlParameter("@LD芯片型号", SqlDbType.NVarChar,20),
					new SqlParameter("@PT芯片型号", SqlDbType.NVarChar,20),
					new SqlParameter("@Quantity1", SqlDbType.NVarChar,50),
					new SqlParameter("@Quantity2", SqlDbType.NVarChar,50),
					new SqlParameter("@数量", SqlDbType.NVarChar,10),
					new SqlParameter("@计划编制", SqlDbType.NVarChar,10),
					new SqlParameter("@技术审核", SqlDbType.NVarChar,10),
					new SqlParameter("@生产审核", SqlDbType.NVarChar,10),
					new SqlParameter("@录入员", SqlDbType.NVarChar,10),
					new SqlParameter("@录入时间", SqlDbType.DateTime),
					new SqlParameter("@客户代码", SqlDbType.NVarChar,10),
					new SqlParameter("@生产日期", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@备货单号", SqlDbType.NVarChar,30)};
            parameters[0].Value = model.交货日期;
            parameters[1].Value = model.下单日期;
            parameters[2].Value = model.表格编号;
            parameters[3].Value = model.合同编号;
            parameters[4].Value = model.规格书编号;
            parameters[5].Value = model.产品名称;
            parameters[6].Value = model.备货单数量;
            parameters[7].Value = model.随工卡数量;
            parameters[8].Value = model.产品图号;
            parameters[9].Value = model.产品类型;
            parameters[10].Value = model.成品编码;
            parameters[11].Value = model.BK_A;
            parameters[12].Value = model.BK_B;
            parameters[13].Value = model.BK_C;
            parameters[14].Value = model.LD_LDjj;
            parameters[15].Value = model.GX_hjfs;
            parameters[16].Value = model.OH_hqPomin;
            parameters[17].Value = model.OH_hqPomax;
            parameters[18].Value = model.OH_hqBFB;
            parameters[19].Value = model.OH_hhPomin;
            parameters[20].Value = model.OH_hhPomax;
            parameters[21].Value = model.OH_hhBFB;
            parameters[22].Value = model.DM_dmzl;
            parameters[23].Value = model.PT_rqgl;
            parameters[24].Value = model.PT_gdlmin;
            parameters[25].Value = model.PT_gdlmax;
            parameters[26].Value = model.GDW_xhcs;
            parameters[27].Value = model.LD_CSPomin;
            parameters[28].Value = model.LD_CSPomax;
            parameters[29].Value = model.LD_CSBFB;
            parameters[30].Value = model.LD_LDKINK;
            parameters[31].Value = model.LD_PDKINK;
            parameters[32].Value = model.PT_CStj;
            parameters[33].Value = model.PT_CSpl;
            parameters[34].Value = model.PT_LMd;
            parameters[35].Value = model.PT_LMd2;
            parameters[36].Value = model.PT_ICCmin;
            parameters[37].Value = model.PT_ICCmax;
            parameters[38].Value = model.BZ_QJbq;
            parameters[39].Value = model.GD_if;
            parameters[40].Value = model.GD_ccglMin;
            parameters[41].Value = model.GD_ccglMax;
            parameters[42].Value = model.GD_imoMin;
            parameters[43].Value = model.GD_imoMax;
            parameters[44].Value = model.GD_ithMin;
            parameters[45].Value = model.GD_ithMax;
            parameters[46].Value = model.GD_vfMin;
            parameters[47].Value = model.GD_vfMax;
            parameters[48].Value = model.GD_ptsl;
            parameters[49].Value = model.GD_vbrMin;
            parameters[50].Value = model.GD_vbrMax;
            parameters[51].Value = model.JX_wdMin;
            parameters[52].Value = model.JX_wdMax;
            parameters[53].Value = model.JX_zz;
            parameters[54].Value = model.JX_pthigh;
            parameters[55].Value = model.JX_ptwwj;
            parameters[56].Value = model.JX_ldgj;
            parameters[57].Value = model.JX_ptgj;
            parameters[58].Value = model.fh产品名称;
            parameters[59].Value = model.Description;
            parameters[60].Value = model.物料代码;
            parameters[61].Value = model.型号属性;
            parameters[62].Value = model.Specification;
            parameters[63].Value = model.客户型号;
            parameters[64].Value = model.LD芯片型号;
            parameters[65].Value = model.PT芯片型号;
            parameters[66].Value = model.Quantity1;
            parameters[67].Value = model.Quantity2;
            parameters[68].Value = model.数量;
            parameters[69].Value = model.计划编制;
            parameters[70].Value = model.技术审核;
            parameters[71].Value = model.生产审核;
            parameters[72].Value = model.录入员;
            parameters[73].Value = model.录入时间;
            parameters[74].Value = model.客户代码;
            parameters[75].Value = model.生产日期;
            parameters[76].Value = model.id;
            parameters[77].Value = model.备货单号;

            int rows = dbhelper.ExecuteSql(strSql.ToString(), parameters);
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
        /// 新增tsuhan_sg_gt表信息
        /// </summary>
        /// <param name="mogt"></param>
        /// <returns></returns>
        public bool Add(tsuhan_sg_gt model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_sg_gt(");
            strSql.Append("备货单号,交货日期,下单日期,表格编号,合同编号,规格书编号,产品名称,备货单数量,随工卡数量,产品图号,产品类型,成品编码,BK_A,BK_B,BK_C,LD_LDjj,GX_hjfs,OH_hqPomin,OH_hqPomax,OH_hqBFB,OH_hhPomin,OH_hhPomax,OH_hhBFB,DM_dmzl,PT_rqgl,PT_gdlmin,PT_gdlmax,GDW_xhcs,LD_CSPomin,LD_CSPomax,LD_CSBFB,LD_LDKINK,LD_PDKINK,PT_CStj,PT_CSpl,PT_LMd,PT_LMd2,PT_ICCmin,PT_ICCmax,BZ_QJbq,GD_if,GD_ccglMin,GD_ccglMax,GD_imoMin,GD_imoMax,GD_ithMin,GD_ithMax,GD_vfMin,GD_vfMax,GD_ptsl,GD_vbrMin,GD_vbrMax,JX_wdMin,JX_wdMax,JX_zz,JX_pthigh,JX_ptwwj,JX_ldgj,JX_ptgj,fh产品名称,Description,物料代码,型号属性,Specification,客户型号,LD芯片型号,PT芯片型号,Quantity1,Quantity2,数量,计划编制,技术审核,生产审核,录入员,录入时间,客户代码,生产日期)");
            strSql.Append(" values (");
            strSql.Append("@备货单号,@交货日期,@下单日期,@表格编号,@合同编号,@规格书编号,@产品名称,@备货单数量,@随工卡数量,@产品图号,@产品类型,@成品编码,@BK_A,@BK_B,@BK_C,@LD_LDjj,@GX_hjfs,@OH_hqPomin,@OH_hqPomax,@OH_hqBFB,@OH_hhPomin,@OH_hhPomax,@OH_hhBFB,@DM_dmzl,@PT_rqgl,@PT_gdlmin,@PT_gdlmax,@GDW_xhcs,@LD_CSPomin,@LD_CSPomax,@LD_CSBFB,@LD_LDKINK,@LD_PDKINK,@PT_CStj,@PT_CSpl,@PT_LMd,@PT_LMd2,@PT_ICCmin,@PT_ICCmax,@BZ_QJbq,@GD_if,@GD_ccglMin,@GD_ccglMax,@GD_imoMin,@GD_imoMax,@GD_ithMin,@GD_ithMax,@GD_vfMin,@GD_vfMax,@GD_ptsl,@GD_vbrMin,@GD_vbrMax,@JX_wdMin,@JX_wdMax,@JX_zz,@JX_pthigh,@JX_ptwwj,@JX_ldgj,@JX_ptgj,@fh产品名称,@Description,@物料代码,@型号属性,@Specification,@客户型号,@LD芯片型号,@PT芯片型号,@Quantity1,@Quantity2,@数量,@计划编制,@技术审核,@生产审核,@录入员,@录入时间,@客户代码,@生产日期)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@备货单号", SqlDbType.NVarChar,30),
					new SqlParameter("@交货日期", SqlDbType.DateTime),
					new SqlParameter("@下单日期", SqlDbType.DateTime),
					new SqlParameter("@表格编号", SqlDbType.NVarChar,20),
					new SqlParameter("@合同编号", SqlDbType.NVarChar,40),
					new SqlParameter("@规格书编号", SqlDbType.NVarChar,40),
					new SqlParameter("@产品名称", SqlDbType.NVarChar,50),
					new SqlParameter("@备货单数量", SqlDbType.Int,4),
					new SqlParameter("@随工卡数量", SqlDbType.Int,4),
					new SqlParameter("@产品图号", SqlDbType.NVarChar,20),
					new SqlParameter("@产品类型", SqlDbType.NVarChar,10),
					new SqlParameter("@成品编码", SqlDbType.NVarChar,40),
					new SqlParameter("@BK_A", SqlDbType.NVarChar,40),
					new SqlParameter("@BK_B", SqlDbType.NVarChar,40),
					new SqlParameter("@BK_C", SqlDbType.NVarChar,40),
					new SqlParameter("@LD_LDjj", SqlDbType.Float,8),
					new SqlParameter("@GX_hjfs", SqlDbType.NVarChar,15),
					new SqlParameter("@OH_hqPomin", SqlDbType.Float,8),
					new SqlParameter("@OH_hqPomax", SqlDbType.Float,8),
					new SqlParameter("@OH_hqBFB", SqlDbType.Int,4),
					new SqlParameter("@OH_hhPomin", SqlDbType.Float,8),
					new SqlParameter("@OH_hhPomax", SqlDbType.Float,8),
					new SqlParameter("@OH_hhBFB", SqlDbType.Int,4),
					new SqlParameter("@DM_dmzl", SqlDbType.NVarChar,40),
					new SqlParameter("@PT_rqgl", SqlDbType.Int,4),
					new SqlParameter("@PT_gdlmin", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_gdlmax", SqlDbType.NVarChar,20),
					new SqlParameter("@GDW_xhcs", SqlDbType.Int,4),
					new SqlParameter("@LD_CSPomin", SqlDbType.Float,8),
					new SqlParameter("@LD_CSPomax", SqlDbType.Float,8),
					new SqlParameter("@LD_CSBFB", SqlDbType.Int,4),
					new SqlParameter("@LD_LDKINK", SqlDbType.Int,4),
					new SqlParameter("@LD_PDKINK", SqlDbType.Int,4),
					new SqlParameter("@PT_CStj", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_CSpl", SqlDbType.Float,8),
					new SqlParameter("@PT_LMd", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_LMd2", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_ICCmin", SqlDbType.Int,4),
					new SqlParameter("@PT_ICCmax", SqlDbType.Int,4),
					new SqlParameter("@BZ_QJbq", SqlDbType.NVarChar,20),
					new SqlParameter("@GD_if", SqlDbType.NVarChar,10),
					new SqlParameter("@GD_ccglMin", SqlDbType.Float,8),
					new SqlParameter("@GD_ccglMax", SqlDbType.Float,8),
					new SqlParameter("@GD_imoMin", SqlDbType.Int,4),
					new SqlParameter("@GD_imoMax", SqlDbType.Int,4),
					new SqlParameter("@GD_ithMin", SqlDbType.Int,4),
					new SqlParameter("@GD_ithMax", SqlDbType.Int,4),
					new SqlParameter("@GD_vfMin", SqlDbType.Float,8),
					new SqlParameter("@GD_vfMax", SqlDbType.Float,8),
					new SqlParameter("@GD_ptsl", SqlDbType.NVarChar,10),
					new SqlParameter("@GD_vbrMin", SqlDbType.Int,4),
					new SqlParameter("@GD_vbrMax", SqlDbType.Int,4),
					new SqlParameter("@JX_wdMin", SqlDbType.Int,4),
					new SqlParameter("@JX_wdMax", SqlDbType.Int,4),
					new SqlParameter("@JX_zz", SqlDbType.NVarChar,10),
					new SqlParameter("@JX_pthigh", SqlDbType.NVarChar,20),
					new SqlParameter("@JX_ptwwj", SqlDbType.NVarChar,20),
					new SqlParameter("@JX_ldgj", SqlDbType.NVarChar,2),
					new SqlParameter("@JX_ptgj", SqlDbType.NVarChar,2),
					new SqlParameter("@fh产品名称", SqlDbType.NVarChar,50),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@物料代码", SqlDbType.NVarChar,30),
					new SqlParameter("@型号属性", SqlDbType.NVarChar,30),
					new SqlParameter("@Specification", SqlDbType.NVarChar,30),
					new SqlParameter("@客户型号", SqlDbType.NVarChar,50),
					new SqlParameter("@LD芯片型号", SqlDbType.NVarChar,20),
					new SqlParameter("@PT芯片型号", SqlDbType.NVarChar,20),
					new SqlParameter("@Quantity1", SqlDbType.NVarChar,50),
					new SqlParameter("@Quantity2", SqlDbType.NVarChar,50),
					new SqlParameter("@数量", SqlDbType.NVarChar,10),
					new SqlParameter("@计划编制", SqlDbType.NVarChar,10),
					new SqlParameter("@技术审核", SqlDbType.NVarChar,10),
					new SqlParameter("@生产审核", SqlDbType.NVarChar,10),
					new SqlParameter("@录入员", SqlDbType.NVarChar,10),
					new SqlParameter("@录入时间", SqlDbType.DateTime),
					new SqlParameter("@客户代码", SqlDbType.NVarChar,10),
					new SqlParameter("@生产日期", SqlDbType.DateTime)};
            parameters[0].Value = model.备货单号;
            parameters[1].Value = model.交货日期;
            parameters[2].Value = model.下单日期;
            parameters[3].Value = model.表格编号;
            parameters[4].Value = model.合同编号;
            parameters[5].Value = model.规格书编号;
            parameters[6].Value = model.产品名称;
            parameters[7].Value = model.备货单数量;
            parameters[8].Value = model.随工卡数量;
            parameters[9].Value = model.产品图号;
            parameters[10].Value = model.产品类型;
            parameters[11].Value = model.成品编码;
            parameters[12].Value = model.BK_A;
            parameters[13].Value = model.BK_B;
            parameters[14].Value = model.BK_C;
            parameters[15].Value = model.LD_LDjj;
            parameters[16].Value = model.GX_hjfs;
            parameters[17].Value = model.OH_hqPomin;
            parameters[18].Value = model.OH_hqPomax;
            parameters[19].Value = model.OH_hqBFB;
            parameters[20].Value = model.OH_hhPomin;
            parameters[21].Value = model.OH_hhPomax;
            parameters[22].Value = model.OH_hhBFB;
            parameters[23].Value = model.DM_dmzl;
            parameters[24].Value = model.PT_rqgl;
            parameters[25].Value = model.PT_gdlmin;
            parameters[26].Value = model.PT_gdlmax;
            parameters[27].Value = model.GDW_xhcs;
            parameters[28].Value = model.LD_CSPomin;
            parameters[29].Value = model.LD_CSPomax;
            parameters[30].Value = model.LD_CSBFB;
            parameters[31].Value = model.LD_LDKINK;
            parameters[32].Value = model.LD_PDKINK;
            parameters[33].Value = model.PT_CStj;
            parameters[34].Value = model.PT_CSpl;
            parameters[35].Value = model.PT_LMd;
            parameters[36].Value = model.PT_LMd2;
            parameters[37].Value = model.PT_ICCmin;
            parameters[38].Value = model.PT_ICCmax;
            parameters[39].Value = model.BZ_QJbq;
            parameters[40].Value = model.GD_if;
            parameters[41].Value = model.GD_ccglMin;
            parameters[42].Value = model.GD_ccglMax;
            parameters[43].Value = model.GD_imoMin;
            parameters[44].Value = model.GD_imoMax;
            parameters[45].Value = model.GD_ithMin;
            parameters[46].Value = model.GD_ithMax;
            parameters[47].Value = model.GD_vfMin;
            parameters[48].Value = model.GD_vfMax;
            parameters[49].Value = model.GD_ptsl;
            parameters[50].Value = model.GD_vbrMin;
            parameters[51].Value = model.GD_vbrMax;
            parameters[52].Value = model.JX_wdMin;
            parameters[53].Value = model.JX_wdMax;
            parameters[54].Value = model.JX_zz;
            parameters[55].Value = model.JX_pthigh;
            parameters[56].Value = model.JX_ptwwj;
            parameters[57].Value = model.JX_ldgj;
            parameters[58].Value = model.JX_ptgj;
            parameters[59].Value = model.fh产品名称;
            parameters[60].Value = model.Description;
            parameters[61].Value = model.物料代码;
            parameters[62].Value = model.型号属性;
            parameters[63].Value = model.Specification;
            parameters[64].Value = model.客户型号;
            parameters[65].Value = model.LD芯片型号;
            parameters[66].Value = model.PT芯片型号;
            parameters[67].Value = model.Quantity1;
            parameters[68].Value = model.Quantity2;
            parameters[69].Value = model.数量;
            parameters[70].Value = model.计划编制;
            parameters[71].Value = model.技术审核;
            parameters[72].Value = model.生产审核;
            parameters[73].Value = model.录入员;
            parameters[74].Value = model.录入时间;
            parameters[75].Value = model.客户代码;
            parameters[76].Value = model.生产日期;
            int rows = dbhelper.ExecuteSql(strSql.ToString(), parameters);
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
        /// 绑定备货单号
        /// </summary>
        /// <returns></returns>
        public DataTable GetGts()
        {
            string sql = "SELECT * FROM tsuhan_sg_gt";
            return dbhelper.GetTable(sql, new List<SqlParameter>());
        }
    }
}
