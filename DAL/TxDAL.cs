using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;
using Maticsoft.Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 随工单记录详情操作类
    /// </summary>
    public class TxDAL
    {
        DbHelperSQLP dbhelper1 = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString"));

        /// <summary>
        /// 根据随工单号查询
        /// </summary>
        /// <param name="随工单号"></param>
        /// <returns></returns>
        public tsuhan_sg_tx QueryByXuhao(string 随工单号)
        {
            string sql = "select * from tsuhan_sg_tx where 随工单号 =@随工单号";
            SqlParameter[] parameters = {
                                            new SqlParameter("@随工单号",SqlDbType.NVarChar,20)
                                        };
            parameters[0].Value = 随工单号;
            DataSet ds = dbhelper1.Query(sql.ToString(), parameters);
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
        public Maticsoft.Model.tsuhan_sg_tx DataRowToModel(DataRow row)
        {
            Maticsoft.Model.tsuhan_sg_tx model = new Maticsoft.Model.tsuhan_sg_tx();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["随工单号"] != null)
                {
                    model.随工单号 = row["随工单号"].ToString();
                }
                if (row["备料"] != null)
                {
                    model.备料 = row["备料"].ToString();
                }
                if (row["bl_sbbh1"] != null)
                {
                    model.bl_sbbh1 = row["bl_sbbh1"].ToString();
                }
                if (row["bl_sbbh2"] != null)
                {
                    model.bl_sbbh2 = row["bl_sbbh2"].ToString();
                }
                if (row["bl_sbbh3"] != null)
                {
                    model.bl_sbbh3 = row["bl_sbbh3"].ToString();
                }
                if (row["bl_sbbh4"] != null)
                {
                    model.bl_sbbh4 = row["bl_sbbh4"].ToString();
                }
                if (row["bl_xcsl"] != null && row["bl_xcsl"].ToString() != "")
                {
                    model.bl_xcsl = int.Parse(row["bl_xcsl"].ToString());
                }
                if (row["bl_xctime"] != null && row["bl_xctime"].ToString() != "")
                {
                    model.bl_xctime = DateTime.Parse(row["bl_xctime"].ToString());
                }
                if (row["bl_czy1"] != null)
                {
                    model.bl_czy1 = row["bl_czy1"].ToString();
                }
                if (row["bl_czy2"] != null)
                {
                    model.bl_czy2 = row["bl_czy2"].ToString();
                }
                if (row["bl_czy3"] != null)
                {
                    model.bl_czy3 = row["bl_czy3"].ToString();
                }
                if (row["bl_czy4"] != null)
                {
                    model.bl_czy4 = row["bl_czy4"].ToString();
                }
                if (row["bl_czyname1"] != null)
                {
                    model.bl_czyname1 = row["bl_czyname1"].ToString();
                }
                if (row["bl_czyname2"] != null)
                {
                    model.bl_czyname2 = row["bl_czyname2"].ToString();
                }
                if (row["bl_czyname3"] != null)
                {
                    model.bl_czyname3 = row["bl_czyname3"].ToString();
                }
                if (row["bl_czyname4"] != null)
                {
                    model.bl_czyname4 = row["bl_czyname4"].ToString();
                }
                if (row["bl_lry"] != null)
                {
                    model.bl_lry = row["bl_lry"].ToString();
                }
                if (row["bl_lryname"] != null)
                {
                    model.bl_lryname = row["bl_lryname"].ToString();
                }
                if (row["bl_bhgallsl"] != null && row["bl_bhgallsl"].ToString() != "")
                {
                    model.bl_bhgallsl = int.Parse(row["bl_bhgallsl"].ToString());
                }
                if (row["blng1"] != null && row["blng1"].ToString() != "")
                {
                    model.blng1 = int.Parse(row["blng1"].ToString());
                }
                if (row["blng2"] != null && row["blng2"].ToString() != "")
                {
                    model.blng2 = int.Parse(row["blng2"].ToString());
                }
                if (row["blng3"] != null && row["blng3"].ToString() != "")
                {
                    model.blng3 = int.Parse(row["blng3"].ToString());
                }
                if (row["blng4"] != null && row["blng4"].ToString() != "")
                {
                    model.blng4 = int.Parse(row["blng4"].ToString());
                }
                if (row["blng5"] != null && row["blng5"].ToString() != "")
                {
                    model.blng5 = int.Parse(row["blng5"].ToString());
                }
                if (row["blng6"] != null && row["blng6"].ToString() != "")
                {
                    model.blng6 = int.Parse(row["blng6"].ToString());
                }
                if (row["blng7"] != null && row["blng7"].ToString() != "")
                {
                    model.blng7 = int.Parse(row["blng7"].ToString());
                }
                if (row["blng8"] != null && row["blng8"].ToString() != "")
                {
                    model.blng8 = int.Parse(row["blng8"].ToString());
                }
                if (row["blng9"] != null && row["blng9"].ToString() != "")
                {
                    model.blng9 = int.Parse(row["blng9"].ToString());
                }
                if (row["blngoth"] != null)
                {
                    model.blngoth = row["blngoth"].ToString();
                }
                if (row["blngothnum"] != null && row["blngothnum"].ToString() != "")
                {
                    model.blngothnum = int.Parse(row["blngothnum"].ToString());
                }
                if (row["LD焊接"] != null)
                {
                    model.LD焊接 = row["LD焊接"].ToString();
                }
                if (row["LD_sbbh1"] != null)
                {
                    model.LD_sbbh1 = row["LD_sbbh1"].ToString();
                }
                if (row["LD_sbbh2"] != null)
                {
                    model.LD_sbbh2 = row["LD_sbbh2"].ToString();
                }
                if (row["LD_sbbh3"] != null)
                {
                    model.LD_sbbh3 = row["LD_sbbh3"].ToString();
                }
                if (row["LD_sbbh4"] != null)
                {
                    model.LD_sbbh4 = row["LD_sbbh4"].ToString();
                }
                if (row["LD_sjsl"] != null && row["LD_sjsl"].ToString() != "")
                {
                    model.LD_sjsl = int.Parse(row["LD_sjsl"].ToString());
                }
                if (row["LD_xcsl"] != null && row["LD_xcsl"].ToString() != "")
                {
                    model.LD_xcsl = int.Parse(row["LD_xcsl"].ToString());
                }
                if (row["LD_xctime"] != null && row["LD_xctime"].ToString() != "")
                {
                    model.LD_xctime = DateTime.Parse(row["LD_xctime"].ToString());
                }
                if (row["LD_czy1"] != null)
                {
                    model.LD_czy1 = row["LD_czy1"].ToString();
                }
                if (row["LD_czy2"] != null)
                {
                    model.LD_czy2 = row["LD_czy2"].ToString();
                }
                if (row["LD_czy3"] != null)
                {
                    model.LD_czy3 = row["LD_czy3"].ToString();
                }
                if (row["LD_czy4"] != null)
                {
                    model.LD_czy4 = row["LD_czy4"].ToString();
                }
                if (row["LD_czyname1"] != null)
                {
                    model.LD_czyname1 = row["LD_czyname1"].ToString();
                }
                if (row["LD_czyname2"] != null)
                {
                    model.LD_czyname2 = row["LD_czyname2"].ToString();
                }
                if (row["LD_czyname3"] != null)
                {
                    model.LD_czyname3 = row["LD_czyname3"].ToString();
                }
                if (row["LD_czyname4"] != null)
                {
                    model.LD_czyname4 = row["LD_czyname4"].ToString();
                }
                if (row["LD_lry"] != null)
                {
                    model.LD_lry = row["LD_lry"].ToString();
                }
                if (row["LD_lryname"] != null)
                {
                    model.LD_lryname = row["LD_lryname"].ToString();
                }
                if (row["LD_bhgallsl"] != null && row["LD_bhgallsl"].ToString() != "")
                {
                    model.LD_bhgallsl = int.Parse(row["LD_bhgallsl"].ToString());
                }
                if (row["LD_jzsl"] != null && row["LD_jzsl"].ToString() != "")
                {
                    model.LD_jzsl = int.Parse(row["LD_jzsl"].ToString());
                }
                if (row["ldng1"] != null && row["ldng1"].ToString() != "")
                {
                    model.ldng1 = int.Parse(row["ldng1"].ToString());
                }
                if (row["ldng2"] != null && row["ldng2"].ToString() != "")
                {
                    model.ldng2 = int.Parse(row["ldng2"].ToString());
                }
                if (row["ldng3"] != null && row["ldng3"].ToString() != "")
                {
                    model.ldng3 = int.Parse(row["ldng3"].ToString());
                }
                if (row["ldng4"] != null && row["ldng4"].ToString() != "")
                {
                    model.ldng4 = int.Parse(row["ldng4"].ToString());
                }
                if (row["ldng5"] != null && row["ldng5"].ToString() != "")
                {
                    model.ldng5 = int.Parse(row["ldng5"].ToString());
                }
                if (row["ldng6"] != null && row["ldng6"].ToString() != "")
                {
                    model.ldng6 = int.Parse(row["ldng6"].ToString());
                }
                if (row["ldng7"] != null && row["ldng7"].ToString() != "")
                {
                    model.ldng7 = int.Parse(row["ldng7"].ToString());
                }
                if (row["ldng8"] != null && row["ldng8"].ToString() != "")
                {
                    model.ldng8 = int.Parse(row["ldng8"].ToString());
                }
                if (row["ldng9"] != null && row["ldng9"].ToString() != "")
                {
                    model.ldng9 = int.Parse(row["ldng9"].ToString());
                }
                if (row["ldngoth"] != null)
                {
                    model.ldngoth = row["ldngoth"].ToString();
                }
                if (row["ldngothnum"] != null && row["ldngothnum"].ToString() != "")
                {
                    model.ldngothnum = int.Parse(row["ldngothnum"].ToString());
                }
                if (row["PT耦合固化"] != null)
                {
                    model.PT耦合固化 = row["PT耦合固化"].ToString();
                }
                if (row["PT_sbbh1"] != null)
                {
                    model.PT_sbbh1 = row["PT_sbbh1"].ToString();
                }
                if (row["PT_sbbh2"] != null)
                {
                    model.PT_sbbh2 = row["PT_sbbh2"].ToString();
                }
                if (row["PT_sbbh3"] != null)
                {
                    model.PT_sbbh3 = row["PT_sbbh3"].ToString();
                }
                if (row["PT_sbbh4"] != null)
                {
                    model.PT_sbbh4 = row["PT_sbbh4"].ToString();
                }
                if (row["PT_sjsl"] != null && row["PT_sjsl"].ToString() != "")
                {
                    model.PT_sjsl = int.Parse(row["PT_sjsl"].ToString());
                }
                if (row["PT_xcsl"] != null && row["PT_xcsl"].ToString() != "")
                {
                    model.PT_xcsl = int.Parse(row["PT_xcsl"].ToString());
                }
                if (row["PT_xctime"] != null && row["PT_xctime"].ToString() != "")
                {
                    model.PT_xctime = DateTime.Parse(row["PT_xctime"].ToString());
                }
                if (row["PT_czy1"] != null)
                {
                    model.PT_czy1 = row["PT_czy1"].ToString();
                }
                if (row["PT_czy2"] != null)
                {
                    model.PT_czy2 = row["PT_czy2"].ToString();
                }
                if (row["PT_czy3"] != null)
                {
                    model.PT_czy3 = row["PT_czy3"].ToString();
                }
                if (row["PT_czy4"] != null)
                {
                    model.PT_czy4 = row["PT_czy4"].ToString();
                }
                if (row["PT_czyname1"] != null)
                {
                    model.PT_czyname1 = row["PT_czyname1"].ToString();
                }
                if (row["PT_czyname2"] != null)
                {
                    model.PT_czyname2 = row["PT_czyname2"].ToString();
                }
                if (row["PT_czyname3"] != null)
                {
                    model.PT_czyname3 = row["PT_czyname3"].ToString();
                }
                if (row["PT_czyname4"] != null)
                {
                    model.PT_czyname4 = row["PT_czyname4"].ToString();
                }
                if (row["PT_lry"] != null)
                {
                    model.PT_lry = row["PT_lry"].ToString();
                }
                if (row["PT_lryname"] != null)
                {
                    model.PT_lryname = row["PT_lryname"].ToString();
                }
                if (row["PT_bhgallsl"] != null && row["PT_bhgallsl"].ToString() != "")
                {
                    model.PT_bhgallsl = int.Parse(row["PT_bhgallsl"].ToString());
                }
                if (row["PT_bhgyy"] != null)
                {
                    model.PT_bhgyy = row["PT_bhgyy"].ToString();
                }
                if (row["ptng1"] != null && row["ptng1"].ToString() != "")
                {
                    model.ptng1 = int.Parse(row["ptng1"].ToString());
                }
                if (row["ptng2"] != null && row["ptng2"].ToString() != "")
                {
                    model.ptng2 = int.Parse(row["ptng2"].ToString());
                }
                if (row["ptng3"] != null && row["ptng3"].ToString() != "")
                {
                    model.ptng3 = int.Parse(row["ptng3"].ToString());
                }
                if (row["ptng4"] != null && row["ptng4"].ToString() != "")
                {
                    model.ptng4 = int.Parse(row["ptng4"].ToString());
                }
                if (row["ptng5"] != null && row["ptng5"].ToString() != "")
                {
                    model.ptng5 = int.Parse(row["ptng5"].ToString());
                }
                if (row["ptng6"] != null && row["ptng6"].ToString() != "")
                {
                    model.ptng6 = int.Parse(row["ptng6"].ToString());
                }
                if (row["ptng7"] != null && row["ptng7"].ToString() != "")
                {
                    model.ptng7 = int.Parse(row["ptng7"].ToString());
                }
                if (row["ptng8"] != null && row["ptng8"].ToString() != "")
                {
                    model.ptng8 = int.Parse(row["ptng8"].ToString());
                }
                if (row["ptng9"] != null && row["ptng9"].ToString() != "")
                {
                    model.ptng9 = int.Parse(row["ptng9"].ToString());
                }
                if (row["ptngoth"] != null)
                {
                    model.ptngoth = row["ptngoth"].ToString();
                }
                if (row["ptngothnum"] != null && row["ptngothnum"].ToString() != "")
                {
                    model.ptngothnum = int.Parse(row["ptngothnum"].ToString());
                }
                if (row["温循前"] != null)
                {
                    model.温循前 = row["温循前"].ToString();
                }
                if (row["WXQ_sbbh"] != null)
                {
                    model.WXQ_sbbh = row["WXQ_sbbh"].ToString();
                }
                if (row["WXQ_sjsl"] != null && row["WXQ_sjsl"].ToString() != "")
                {
                    model.WXQ_sjsl = int.Parse(row["WXQ_sjsl"].ToString());
                }
                if (row["WXQ_frsl"] != null && row["WXQ_frsl"].ToString() != "")
                {
                    model.WXQ_frsl = int.Parse(row["WXQ_frsl"].ToString());
                }
                if (row["WXQ_xctime"] != null && row["WXQ_xctime"].ToString() != "")
                {
                    model.WXQ_xctime = DateTime.Parse(row["WXQ_xctime"].ToString());
                }
                if (row["WXQ_czy"] != null)
                {
                    model.WXQ_czy = row["WXQ_czy"].ToString();
                }
                if (row["WXQ_czyname"] != null)
                {
                    model.WXQ_czyname = row["WXQ_czyname"].ToString();
                }
                if (row["WXQ_lry"] != null)
                {
                    model.WXQ_lry = row["WXQ_lry"].ToString();
                }
                if (row["WXQ_lryname"] != null)
                {
                    model.WXQ_lryname = row["WXQ_lryname"].ToString();
                }
                if (row["WXQ_remark"] != null)
                {
                    model.WXQ_remark = row["WXQ_remark"].ToString();
                }
                if (row["温循后"] != null)
                {
                    model.温循后 = row["温循后"].ToString();
                }
                if (row["WXH_sbbh"] != null)
                {
                    model.WXH_sbbh = row["WXH_sbbh"].ToString();
                }
                if (row["WXH_qcsl"] != null && row["WXH_qcsl"].ToString() != "")
                {
                    model.WXH_qcsl = int.Parse(row["WXH_qcsl"].ToString());
                }
                if (row["WXH_xcsl"] != null && row["WXH_xcsl"].ToString() != "")
                {
                    model.WXH_xcsl = int.Parse(row["WXH_xcsl"].ToString());
                }
                if (row["WXH_wxsc"] != null)
                {
                    model.WXH_wxsc = row["WXH_wxsc"].ToString();
                }
                if (row["WXH_xctime"] != null && row["WXH_xctime"].ToString() != "")
                {
                    model.WXH_xctime = DateTime.Parse(row["WXH_xctime"].ToString());
                }
                if (row["WXH_czy"] != null)
                {
                    model.WXH_czy = row["WXH_czy"].ToString();
                }
                if (row["WXH_czyname"] != null)
                {
                    model.WXH_czyname = row["WXH_czyname"].ToString();
                }
                if (row["WX_Hlry"] != null)
                {
                    model.WX_Hlry = row["WX_Hlry"].ToString();
                }
                if (row["WXH_lryname"] != null)
                {
                    model.WXH_lryname = row["WXH_lryname"].ToString();
                }
                if (row["WXH_remark"] != null)
                {
                    model.WXH_remark = row["WXH_remark"].ToString();
                }
                if (row["测试"] != null)
                {
                    model.测试 = row["测试"].ToString();
                }
                if (row["CS_sbbh1"] != null)
                {
                    model.CS_sbbh1 = row["CS_sbbh1"].ToString();
                }
                if (row["CS_sbbh2"] != null)
                {
                    model.CS_sbbh2 = row["CS_sbbh2"].ToString();
                }
                if (row["CS_sbbh3"] != null)
                {
                    model.CS_sbbh3 = row["CS_sbbh3"].ToString();
                }
                if (row["CS_sbbh4"] != null)
                {
                    model.CS_sbbh4 = row["CS_sbbh4"].ToString();
                }
                if (row["CS_sjsl"] != null && row["CS_sjsl"].ToString() != "")
                {
                    model.CS_sjsl = int.Parse(row["CS_sjsl"].ToString());
                }
                if (row["CS_xcsl"] != null && row["CS_xcsl"].ToString() != "")
                {
                    model.CS_xcsl = int.Parse(row["CS_xcsl"].ToString());
                }
                if (row["CS_xctime"] != null && row["CS_xctime"].ToString() != "")
                {
                    model.CS_xctime = DateTime.Parse(row["CS_xctime"].ToString());
                }
                if (row["CS_czy1"] != null)
                {
                    model.CS_czy1 = row["CS_czy1"].ToString();
                }
                if (row["CS_czy2"] != null)
                {
                    model.CS_czy2 = row["CS_czy2"].ToString();
                }
                if (row["CS_czy3"] != null)
                {
                    model.CS_czy3 = row["CS_czy3"].ToString();
                }
                if (row["CS_czy4"] != null)
                {
                    model.CS_czy4 = row["CS_czy4"].ToString();
                }
                if (row["CS_czyname1"] != null)
                {
                    model.CS_czyname1 = row["CS_czyname1"].ToString();
                }
                if (row["CS_czyname2"] != null)
                {
                    model.CS_czyname2 = row["CS_czyname2"].ToString();
                }
                if (row["CS_czyname3"] != null)
                {
                    model.CS_czyname3 = row["CS_czyname3"].ToString();
                }
                if (row["CS_czyname4"] != null)
                {
                    model.CS_czyname4 = row["CS_czyname4"].ToString();
                }
                if (row["CS_lry"] != null)
                {
                    model.CS_lry = row["CS_lry"].ToString();
                }
                if (row["CS_lryname"] != null)
                {
                    model.CS_lryname = row["CS_lryname"].ToString();
                }
                if (row["CS_bhgallsl"] != null && row["CS_bhgallsl"].ToString() != "")
                {
                    model.CS_bhgallsl = int.Parse(row["CS_bhgallsl"].ToString());
                }
                if (row["csng1"] != null && row["csng1"].ToString() != "")
                {
                    model.csng1 = int.Parse(row["csng1"].ToString());
                }
                if (row["csng2"] != null && row["csng2"].ToString() != "")
                {
                    model.csng2 = int.Parse(row["csng2"].ToString());
                }
                if (row["csng3"] != null && row["csng3"].ToString() != "")
                {
                    model.csng3 = int.Parse(row["csng3"].ToString());
                }
                if (row["csng4"] != null && row["csng4"].ToString() != "")
                {
                    model.csng4 = int.Parse(row["csng4"].ToString());
                }
                if (row["csng5"] != null && row["csng5"].ToString() != "")
                {
                    model.csng5 = int.Parse(row["csng5"].ToString());
                }
                if (row["csng6"] != null && row["csng6"].ToString() != "")
                {
                    model.csng6 = int.Parse(row["csng6"].ToString());
                }
                if (row["csng7"] != null && row["csng7"].ToString() != "")
                {
                    model.csng7 = int.Parse(row["csng7"].ToString());
                }
                if (row["csng8"] != null && row["csng8"].ToString() != "")
                {
                    model.csng8 = int.Parse(row["csng8"].ToString());
                }
                if (row["csng9"] != null && row["csng9"].ToString() != "")
                {
                    model.csng9 = int.Parse(row["csng9"].ToString());
                }
                if (row["csngoth"] != null)
                {
                    model.csngoth = row["csngoth"].ToString();
                }
                if (row["csngothnum"] != null && row["csngothnum"].ToString() != "")
                {
                    model.csngothnum = int.Parse(row["csngothnum"].ToString());
                }
                if (row["清洗"] != null)
                {
                    model.清洗 = row["清洗"].ToString();
                }
                if (row["QX_sbbh1"] != null)
                {
                    model.QX_sbbh1 = row["QX_sbbh1"].ToString();
                }
                if (row["QX_sbbh2"] != null)
                {
                    model.QX_sbbh2 = row["QX_sbbh2"].ToString();
                }
                if (row["QX_sbbh3"] != null)
                {
                    model.QX_sbbh3 = row["QX_sbbh3"].ToString();
                }
                if (row["QX_sbbh4"] != null)
                {
                    model.QX_sbbh4 = row["QX_sbbh4"].ToString();
                }
                if (row["QX_sjsl"] != null && row["QX_sjsl"].ToString() != "")
                {
                    model.QX_sjsl = int.Parse(row["QX_sjsl"].ToString());
                }
                if (row["QX_xcsl"] != null && row["QX_xcsl"].ToString() != "")
                {
                    model.QX_xcsl = int.Parse(row["QX_xcsl"].ToString());
                }
                if (row["QX_xctime"] != null && row["QX_xctime"].ToString() != "")
                {
                    model.QX_xctime = DateTime.Parse(row["QX_xctime"].ToString());
                }
                if (row["QX_czy1"] != null)
                {
                    model.QX_czy1 = row["QX_czy1"].ToString();
                }
                if (row["QX_czy2"] != null)
                {
                    model.QX_czy2 = row["QX_czy2"].ToString();
                }
                if (row["QX_czy3"] != null)
                {
                    model.QX_czy3 = row["QX_czy3"].ToString();
                }
                if (row["QX_czy4"] != null)
                {
                    model.QX_czy4 = row["QX_czy4"].ToString();
                }
                if (row["QX_czyname1"] != null)
                {
                    model.QX_czyname1 = row["QX_czyname1"].ToString();
                }
                if (row["QX_czyname2"] != null)
                {
                    model.QX_czyname2 = row["QX_czyname2"].ToString();
                }
                if (row["QX_czyname3"] != null)
                {
                    model.QX_czyname3 = row["QX_czyname3"].ToString();
                }
                if (row["QX_czyname4"] != null)
                {
                    model.QX_czyname4 = row["QX_czyname4"].ToString();
                }
                if (row["QX_lry"] != null)
                {
                    model.QX_lry = row["QX_lry"].ToString();
                }
                if (row["QX_lryname"] != null)
                {
                    model.QX_lryname = row["QX_lryname"].ToString();
                }
                if (row["QX_bhgallsl"] != null && row["QX_bhgallsl"].ToString() != "")
                {
                    model.QX_bhgallsl = int.Parse(row["QX_bhgallsl"].ToString());
                }
                if (row["qxng1"] != null && row["qxng1"].ToString() != "")
                {
                    model.qxng1 = int.Parse(row["qxng1"].ToString());
                }
                if (row["qxngoth"] != null)
                {
                    model.qxngoth = row["qxngoth"].ToString();
                }
                if (row["qxngothnum"] != null && row["qxngothnum"].ToString() != "")
                {
                    model.qxngothnum = int.Parse(row["qxngothnum"].ToString());
                }
                if (row["包装"] != null)
                {
                    model.包装 = row["包装"].ToString();
                }
                if (row["BZ_sbbh1"] != null)
                {
                    model.BZ_sbbh1 = row["BZ_sbbh1"].ToString();
                }
                if (row["BZ_sbbh2"] != null)
                {
                    model.BZ_sbbh2 = row["BZ_sbbh2"].ToString();
                }
                if (row["BZ_sbbh3"] != null)
                {
                    model.BZ_sbbh3 = row["BZ_sbbh3"].ToString();
                }
                if (row["BZ_sbbh4"] != null)
                {
                    model.BZ_sbbh4 = row["BZ_sbbh4"].ToString();
                }
                if (row["BZ_sjsl"] != null && row["BZ_sjsl"].ToString() != "")
                {
                    model.BZ_sjsl = int.Parse(row["BZ_sjsl"].ToString());
                }
                if (row["BZ_xcsl"] != null && row["BZ_xcsl"].ToString() != "")
                {
                    model.BZ_xcsl = int.Parse(row["BZ_xcsl"].ToString());
                }
                if (row["BZ_xctime"] != null && row["BZ_xctime"].ToString() != "")
                {
                    model.BZ_xctime = DateTime.Parse(row["BZ_xctime"].ToString());
                }
                if (row["BZ_czy1"] != null)
                {
                    model.BZ_czy1 = row["BZ_czy1"].ToString();
                }
                if (row["BZ_czy2"] != null)
                {
                    model.BZ_czy2 = row["BZ_czy2"].ToString();
                }
                if (row["BZ_czy3"] != null)
                {
                    model.BZ_czy3 = row["BZ_czy3"].ToString();
                }
                if (row["BZ_czy4"] != null)
                {
                    model.BZ_czy4 = row["BZ_czy4"].ToString();
                }
                if (row["BZ_czyname1"] != null)
                {
                    model.BZ_czyname1 = row["BZ_czyname1"].ToString();
                }
                if (row["BZ_czyname2"] != null)
                {
                    model.BZ_czyname2 = row["BZ_czyname2"].ToString();
                }
                if (row["BZ_czyname3"] != null)
                {
                    model.BZ_czyname3 = row["BZ_czyname3"].ToString();
                }
                if (row["BZ_czyname4"] != null)
                {
                    model.BZ_czyname4 = row["BZ_czyname4"].ToString();
                }
                if (row["BZ_lry"] != null)
                {
                    model.BZ_lry = row["BZ_lry"].ToString();
                }
                if (row["BZ_lryname"] != null)
                {
                    model.BZ_lryname = row["BZ_lryname"].ToString();
                }
                if (row["BZ_bhgallsl"] != null && row["BZ_bhgallsl"].ToString() != "")
                {
                    model.BZ_bhgallsl = int.Parse(row["BZ_bhgallsl"].ToString());
                }
                if (row["bzng1"] != null && row["bzng1"].ToString() != "")
                {
                    model.bzng1 = int.Parse(row["bzng1"].ToString());
                }
                if (row["bzngoth"] != null)
                {
                    model.bzngoth = row["bzngoth"].ToString();
                }
                if (row["bzngothnum"] != null && row["bzngothnum"].ToString() != "")
                {
                    model.bzngothnum = int.Parse(row["bzngothnum"].ToString());
                }
                if (row["gcsj_liushuih"] != null)
                {
                    model.gcsj_liushuih = row["gcsj_liushuih"].ToString();
                }
                if (row["lsh1"] != null)
                {
                    model.lsh1 = row["lsh1"].ToString();
                }
                if (row["lsh2"] != null)
                {
                    model.lsh2 = row["lsh2"].ToString();
                }
                if (row["lsh3"] != null)
                {
                    model.lsh3 = row["lsh3"].ToString();
                }
                if (row["gcsj_CASE"] != null)
                {
                    model.gcsj_CASE = row["gcsj_CASE"].ToString();
                }
                if (row["case1"] != null)
                {
                    model.case1 = row["case1"].ToString();
                }
                if (row["case2"] != null)
                {
                    model.case2 = row["case2"].ToString();
                }
                if (row["case3"] != null)
                {
                    model.case3 = row["case3"].ToString();
                }
                if (row["gcsj_LDjia"] != null)
                {
                    model.gcsj_LDjia = row["gcsj_LDjia"].ToString();
                }
                if (row["ld1"] != null)
                {
                    model.ld1 = row["ld1"].ToString();
                }
                if (row["ld2"] != null)
                {
                    model.ld2 = row["ld2"].ToString();
                }
                if (row["ld3"] != null)
                {
                    model.ld3 = row["ld3"].ToString();
                }
                if (row["gcsj_PDjia"] != null)
                {
                    model.gcsj_PDjia = row["gcsj_PDjia"].ToString();
                }
                if (row["pd1"] != null)
                {
                    model.pd1 = row["pd1"].ToString();
                }
                if (row["pd2"] != null)
                {
                    model.pd2 = row["pd2"].ToString();
                }
                if (row["pd3"] != null)
                {
                    model.pd3 = row["pd3"].ToString();
                }
                if (row["gcsj_LDjian"] != null)
                {
                    model.gcsj_LDjian = row["gcsj_LDjian"].ToString();
                }
                if (row["ldj1"] != null)
                {
                    model.ldj1 = row["ldj1"].ToString();
                }
                if (row["ldj2"] != null)
                {
                    model.ldj2 = row["ldj2"].ToString();
                }
                if (row["ldj3"] != null)
                {
                    model.ldj3 = row["ldj3"].ToString();
                }
                if (row["gcsj_jicha"] != null)
                {
                    model.gcsj_jicha = row["gcsj_jicha"].ToString();
                }
                if (row["jc1"] != null && row["jc1"].ToString() != "")
                {
                    model.jc1 = decimal.Parse(row["jc1"].ToString());
                }
                if (row["jc2"] != null && row["jc2"].ToString() != "")
                {
                    model.jc2 = decimal.Parse(row["jc2"].ToString());
                }
                if (row["jc3"] != null && row["jc3"].ToString() != "")
                {
                    model.jc3 = decimal.Parse(row["jc3"].ToString());
                }
                if (row["gcsj_yatou"] != null)
                {
                    model.gcsj_yatou = row["gcsj_yatou"].ToString();
                }
                if (row["yt1"] != null)
                {
                    model.yt1 = row["yt1"].ToString();
                }
                if (row["yt2"] != null)
                {
                    model.yt2 = row["yt2"].ToString();
                }
                if (row["yt3"] != null)
                {
                    model.yt3 = row["yt3"].ToString();
                }
                if (row["gcsj_oxianliang"] != null)
                {
                    model.gcsj_oxianliang = row["gcsj_oxianliang"].ToString();
                }
                if (row["oxl1"] != null)
                {
                    model.oxl1 = row["oxl1"].ToString();
                }
                if (row["oxl2"] != null)
                {
                    model.oxl2 = row["oxl2"].ToString();
                }
                if (row["oxl3"] != null)
                {
                    model.oxl3 = row["oxl3"].ToString();
                }
                if (row["ldxp_xinpianjj"] != null)
                {
                    model.ldxp_xinpianjj = row["ldxp_xinpianjj"].ToString();
                }
                if (row["ldxp_jianyanry"] != null)
                {
                    model.ldxp_jianyanry = row["ldxp_jianyanry"].ToString();
                }
                if (row["ldxp_jianyansb"] != null)
                {
                    model.ldxp_jianyansb = row["ldxp_jianyansb"].ToString();
                }
                if (row["bggSum"] != null && row["bggSum"].ToString() != "")
                {
                    model.bggSum = int.Parse(row["bggSum"].ToString());
                }
                if (row["备注"] != null)
                {
                    model.备注 = row["备注"].ToString();
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
        /// 新增随工单
        /// </summary>
        /// <param name="bhd"></param>
        /// <returns></returns>
        public bool Add(tsuhan_sg_tx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_sg_tx(");
            strSql.Append("随工单号,备料,bl_sbbh1,bl_sbbh2,bl_sbbh3,bl_sbbh4,bl_xcsl,bl_xctime,bl_czy1,bl_czy2,bl_czy3,bl_czy4,bl_czyname1,bl_czyname2,bl_czyname3,bl_czyname4,bl_lry,bl_lryname,bl_bhgallsl,blng1,blng2,blng3,blng4,blng5,blng6,blng7,blng8,blng9,blngoth,blngothnum,LD焊接,LD_sbbh1,LD_sbbh2,LD_sbbh3,LD_sbbh4,LD_sjsl,LD_xcsl,LD_xctime,LD_czy1,LD_czy2,LD_czy3,LD_czy4,LD_czyname1,LD_czyname2,LD_czyname3,LD_czyname4,LD_lry,LD_lryname,LD_bhgallsl,LD_jzsl,ldng1,ldng2,ldng3,ldng4,ldng5,ldng6,ldng7,ldng8,ldng9,ldngoth,ldngothnum,PT耦合固化,PT_sbbh1,PT_sbbh2,PT_sbbh3,PT_sbbh4,PT_sjsl,PT_xcsl,PT_xctime,PT_czy1,PT_czy2,PT_czy3,PT_czy4,PT_czyname1,PT_czyname2,PT_czyname3,PT_czyname4,PT_lry,PT_lryname,PT_bhgallsl,PT_bhgyy,ptng1,ptng2,ptng3,ptng4,ptng5,ptng6,ptng7,ptng8,ptng9,ptngoth,ptngothnum,温循前,WXQ_sbbh,WXQ_sjsl,WXQ_frsl,WXQ_xctime,WXQ_czy,WXQ_czyname,WXQ_lry,WXQ_lryname,WXQ_remark,温循后,WXH_sbbh,WXH_qcsl,WXH_xcsl,WXH_wxsc,WXH_xctime,WXH_czy,WXH_czyname,WX_Hlry,WXH_lryname,WXH_remark,测试,CS_sbbh1,CS_sbbh2,CS_sbbh3,CS_sbbh4,CS_sjsl,CS_xcsl,CS_xctime,CS_czy1,CS_czy2,CS_czy3,CS_czy4,CS_czyname1,CS_czyname2,CS_czyname3,CS_czyname4,CS_lry,CS_lryname,CS_bhgallsl,csng1,csng2,csng3,csng4,csng5,csng6,csng7,csng8,csng9,csngoth,csngothnum,清洗,QX_sbbh1,QX_sbbh2,QX_sbbh3,QX_sbbh4,QX_sjsl,QX_xcsl,QX_xctime,QX_czy1,QX_czy2,QX_czy3,QX_czy4,QX_czyname1,QX_czyname2,QX_czyname3,QX_czyname4,QX_lry,QX_lryname,QX_bhgallsl,qxng1,qxngoth,qxngothnum,包装,BZ_sbbh1,BZ_sbbh2,BZ_sbbh3,BZ_sbbh4,BZ_sjsl,BZ_xcsl,BZ_xctime,BZ_czy1,BZ_czy2,BZ_czy3,BZ_czy4,BZ_czyname1,BZ_czyname2,BZ_czyname3,BZ_czyname4,BZ_lry,BZ_lryname,BZ_bhgallsl,bzng1,bzngoth,bzngothnum,gcsj_liushuih,lsh1,lsh2,lsh3,gcsj_CASE,case1,case2,case3,gcsj_LDjia,ld1,ld2,ld3,gcsj_PDjia,pd1,pd2,pd3,gcsj_LDjian,ldj1,ldj2,ldj3,gcsj_jicha,jc1,jc2,jc3,gcsj_yatou,yt1,yt2,yt3,gcsj_oxianliang,oxl1,oxl2,oxl3,ldxp_xinpianjj,ldxp_jianyanry,ldxp_jianyansb,bggSum,备注,LD_lx,LD_xh,LD_name,LD_sjdh,LD_remark,PT_lx,PT_xh,PT_name,PT_sjdh,PT_remark,KT_lx,KT_xh,KT_name,KT_sjdh,KT_remark,NBP_lx0,NBP_xh0,NBP_name0,NBP_sjdh0,NBP_remark0,NBP_lx45,NBP_xh45,NBP_name45,NBP_sjdh45,NBP_remark45,JK_lx,JK_xh,JK_name,JK_sjdh,JK_remark)");
            strSql.Append(" values (");
            strSql.Append("@随工单号,@备料,@bl_sbbh1,@bl_sbbh2,@bl_sbbh3,@bl_sbbh4,@bl_xcsl,@bl_xctime,@bl_czy1,@bl_czy2,@bl_czy3,@bl_czy4,@bl_czyname1,@bl_czyname2,@bl_czyname3,@bl_czyname4,@bl_lry,@bl_lryname,@bl_bhgallsl,@blng1,@blng2,@blng3,@blng4,@blng5,@blng6,@blng7,@blng8,@blng9,@blngoth,@blngothnum,@LD焊接,@LD_sbbh1,@LD_sbbh2,@LD_sbbh3,@LD_sbbh4,@LD_sjsl,@LD_xcsl,@LD_xctime,@LD_czy1,@LD_czy2,@LD_czy3,@LD_czy4,@LD_czyname1,@LD_czyname2,@LD_czyname3,@LD_czyname4,@LD_lry,@LD_lryname,@LD_bhgallsl,@LD_jzsl,@ldng1,@ldng2,@ldng3,@ldng4,@ldng5,@ldng6,@ldng7,@ldng8,@ldng9,@ldngoth,@ldngothnum,@PT耦合固化,@PT_sbbh1,@PT_sbbh2,@PT_sbbh3,@PT_sbbh4,@PT_sjsl,@PT_xcsl,@PT_xctime,@PT_czy1,@PT_czy2,@PT_czy3,@PT_czy4,@PT_czyname1,@PT_czyname2,@PT_czyname3,@PT_czyname4,@PT_lry,@PT_lryname,@PT_bhgallsl,@PT_bhgyy,@ptng1,@ptng2,@ptng3,@ptng4,@ptng5,@ptng6,@ptng7,@ptng8,@ptng9,@ptngoth,@ptngothnum,@温循前,@WXQ_sbbh,@WXQ_sjsl,@WXQ_frsl,@WXQ_xctime,@WXQ_czy,@WXQ_czyname,@WXQ_lry,@WXQ_lryname,@WXQ_remark,@温循后,@WXH_sbbh,@WXH_qcsl,@WXH_xcsl,@WXH_wxsc,@WXH_xctime,@WXH_czy,@WXH_czyname,@WX_Hlry,@WXH_lryname,@WXH_remark,@测试,@CS_sbbh1,@CS_sbbh2,@CS_sbbh3,@CS_sbbh4,@CS_sjsl,@CS_xcsl,@CS_xctime,@CS_czy1,@CS_czy2,@CS_czy3,@CS_czy4,@CS_czyname1,@CS_czyname2,@CS_czyname3,@CS_czyname4,@CS_lry,@CS_lryname,@CS_bhgallsl,@csng1,@csng2,@csng3,@csng4,@csng5,@csng6,@csng7,@csng8,@csng9,@csngoth,@csngothnum,@清洗,@QX_sbbh1,@QX_sbbh2,@QX_sbbh3,@QX_sbbh4,@QX_sjsl,@QX_xcsl,@QX_xctime,@QX_czy1,@QX_czy2,@QX_czy3,@QX_czy4,@QX_czyname1,@QX_czyname2,@QX_czyname3,@QX_czyname4,@QX_lry,@QX_lryname,@QX_bhgallsl,@qxng1,@qxngoth,@qxngothnum,@包装,@BZ_sbbh1,@BZ_sbbh2,@BZ_sbbh3,@BZ_sbbh4,@BZ_sjsl,@BZ_xcsl,@BZ_xctime,@BZ_czy1,@BZ_czy2,@BZ_czy3,@BZ_czy4,@BZ_czyname1,@BZ_czyname2,@BZ_czyname3,@BZ_czyname4,@BZ_lry,@BZ_lryname,@BZ_bhgallsl,@bzng1,@bzngoth,@bzngothnum,@gcsj_liushuih,@lsh1,@lsh2,@lsh3,@gcsj_CASE,@case1,@case2,@case3,@gcsj_LDjia,@ld1,@ld2,@ld3,@gcsj_PDjia,@pd1,@pd2,@pd3,@gcsj_LDjian,@ldj1,@ldj2,@ldj3,@gcsj_jicha,@jc1,@jc2,@jc3,@gcsj_yatou,@yt1,@yt2,@yt3,@gcsj_oxianliang,@oxl1,@oxl2,@oxl3,@ldxp_xinpianjj,@ldxp_jianyanry,@ldxp_jianyansb,@bggSum,@备注,@LD_lx,@LD_xh,@LD_name,@LD_sjdh,@LD_remark,@PT_lx,@PT_xh,@PT_name,@PT_sjdh,@PT_remark,@KT_lx,@KT_xh,@KT_name,@KT_sjdh,@KT_remark,@NBP_lx0,@NBP_xh0,@NBP_name0,@NBP_sjdh0,@NBP_remark0,@NBP_lx45,@NBP_xh45,@NBP_name45,@NBP_sjdh45,@NBP_remark45,@JK_lx,@JK_xh,@JK_name,@JK_sjdh,@JK_remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@随工单号", SqlDbType.NVarChar,20),
					new SqlParameter("@备料", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_xcsl", SqlDbType.Int,4),
					new SqlParameter("@bl_xctime", SqlDbType.DateTime),
					new SqlParameter("@bl_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@blng1", SqlDbType.Int,4),
					new SqlParameter("@blng2", SqlDbType.Int,4),
					new SqlParameter("@blng3", SqlDbType.Int,4),
					new SqlParameter("@blng4", SqlDbType.Int,4),
					new SqlParameter("@blng5", SqlDbType.Int,4),
					new SqlParameter("@blng6", SqlDbType.Int,4),
					new SqlParameter("@blng7", SqlDbType.Int,4),
					new SqlParameter("@blng8", SqlDbType.Int,4),
					new SqlParameter("@blng9", SqlDbType.Int,4),
					new SqlParameter("@blngoth", SqlDbType.VarChar,50),
					new SqlParameter("@blngothnum", SqlDbType.Int,4),
					new SqlParameter("@LD焊接", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sjsl", SqlDbType.Int,4),
					new SqlParameter("@LD_xcsl", SqlDbType.Int,4),
					new SqlParameter("@LD_xctime", SqlDbType.DateTime),
					new SqlParameter("@LD_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@LD_jzsl", SqlDbType.Int,4),
					new SqlParameter("@ldng1", SqlDbType.Int,4),
					new SqlParameter("@ldng2", SqlDbType.Int,4),
					new SqlParameter("@ldng3", SqlDbType.Int,4),
					new SqlParameter("@ldng4", SqlDbType.Int,4),
					new SqlParameter("@ldng5", SqlDbType.Int,4),
					new SqlParameter("@ldng6", SqlDbType.Int,4),
					new SqlParameter("@ldng7", SqlDbType.Int,4),
					new SqlParameter("@ldng8", SqlDbType.Int,4),
					new SqlParameter("@ldng9", SqlDbType.Int,4),
					new SqlParameter("@ldngoth", SqlDbType.VarChar,30),
					new SqlParameter("@ldngothnum", SqlDbType.Int,4),
					new SqlParameter("@PT耦合固化", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sjsl", SqlDbType.Int,4),
					new SqlParameter("@PT_xcsl", SqlDbType.Int,4),
					new SqlParameter("@PT_xctime", SqlDbType.DateTime),
					new SqlParameter("@PT_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@PT_bhgyy", SqlDbType.NVarChar,200),
					new SqlParameter("@ptng1", SqlDbType.Int,4),
					new SqlParameter("@ptng2", SqlDbType.Int,4),
					new SqlParameter("@ptng3", SqlDbType.Int,4),
					new SqlParameter("@ptng4", SqlDbType.Int,4),
					new SqlParameter("@ptng5", SqlDbType.Int,4),
					new SqlParameter("@ptng6", SqlDbType.Int,4),
					new SqlParameter("@ptng7", SqlDbType.Int,4),
					new SqlParameter("@ptng8", SqlDbType.Int,4),
					new SqlParameter("@ptng9", SqlDbType.Int,4),
					new SqlParameter("@ptngoth", SqlDbType.VarChar,30),
					new SqlParameter("@ptngothnum", SqlDbType.Int,4),
					new SqlParameter("@温循前", SqlDbType.NVarChar,10),
					new SqlParameter("@WXQ_sbbh", SqlDbType.NVarChar,10),
					new SqlParameter("@WXQ_sjsl", SqlDbType.Int,4),
					new SqlParameter("@WXQ_frsl", SqlDbType.Int,4),
					new SqlParameter("@WXQ_xctime", SqlDbType.DateTime),
					new SqlParameter("@WXQ_czy", SqlDbType.NVarChar,10),
					new SqlParameter("@WXQ_czyname", SqlDbType.NVarChar,20),
					new SqlParameter("@WXQ_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@WXQ_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@WXQ_remark", SqlDbType.NVarChar,50),
					new SqlParameter("@温循后", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_sbbh", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_qcsl", SqlDbType.Int,4),
					new SqlParameter("@WXH_xcsl", SqlDbType.Int,4),
					new SqlParameter("@WXH_wxsc", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_xctime", SqlDbType.DateTime),
					new SqlParameter("@WXH_czy", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_czyname", SqlDbType.NVarChar,20),
					new SqlParameter("@WX_Hlry", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@WXH_remark", SqlDbType.NVarChar,50),
					new SqlParameter("@测试", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sjsl", SqlDbType.Int,4),
					new SqlParameter("@CS_xcsl", SqlDbType.Int,4),
					new SqlParameter("@CS_xctime", SqlDbType.DateTime),
					new SqlParameter("@CS_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@csng1", SqlDbType.Int,4),
					new SqlParameter("@csng2", SqlDbType.Int,4),
					new SqlParameter("@csng3", SqlDbType.Int,4),
					new SqlParameter("@csng4", SqlDbType.Int,4),
					new SqlParameter("@csng5", SqlDbType.Int,4),
					new SqlParameter("@csng6", SqlDbType.Int,4),
					new SqlParameter("@csng7", SqlDbType.Int,4),
					new SqlParameter("@csng8", SqlDbType.Int,4),
					new SqlParameter("@csng9", SqlDbType.Int,4),
					new SqlParameter("@csngoth", SqlDbType.VarChar,30),
					new SqlParameter("@csngothnum", SqlDbType.Int,4),
					new SqlParameter("@清洗", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sjsl", SqlDbType.Int,4),
					new SqlParameter("@QX_xcsl", SqlDbType.Int,4),
					new SqlParameter("@QX_xctime", SqlDbType.DateTime),
					new SqlParameter("@QX_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@qxng1", SqlDbType.Int,4),
					new SqlParameter("@qxngoth", SqlDbType.VarChar,30),
					new SqlParameter("@qxngothnum", SqlDbType.Int,4),
					new SqlParameter("@包装", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sjsl", SqlDbType.Int,4),
					new SqlParameter("@BZ_xcsl", SqlDbType.Int,4),
					new SqlParameter("@BZ_xctime", SqlDbType.DateTime),
					new SqlParameter("@BZ_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@bzng1", SqlDbType.Int,4),
					new SqlParameter("@bzngoth", SqlDbType.VarChar,30),
					new SqlParameter("@bzngothnum", SqlDbType.Int,4),
					new SqlParameter("@gcsj_liushuih", SqlDbType.NVarChar,10),
					new SqlParameter("@lsh1", SqlDbType.NVarChar,20),
					new SqlParameter("@lsh2", SqlDbType.NVarChar,20),
					new SqlParameter("@lsh3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_CASE", SqlDbType.NVarChar,10),
					new SqlParameter("@case1", SqlDbType.NVarChar,20),
					new SqlParameter("@case2", SqlDbType.NVarChar,20),
					new SqlParameter("@case3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_LDjia", SqlDbType.NVarChar,10),
					new SqlParameter("@ld1", SqlDbType.NVarChar,20),
					new SqlParameter("@ld2", SqlDbType.NVarChar,20),
					new SqlParameter("@ld3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_PDjia", SqlDbType.NVarChar,10),
					new SqlParameter("@pd1", SqlDbType.NVarChar,20),
					new SqlParameter("@pd2", SqlDbType.NVarChar,20),
					new SqlParameter("@pd3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_LDjian", SqlDbType.NVarChar,10),
					new SqlParameter("@ldj1", SqlDbType.NVarChar,20),
					new SqlParameter("@ldj2", SqlDbType.NVarChar,20),
					new SqlParameter("@ldj3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_jicha", SqlDbType.NVarChar,10),
					new SqlParameter("@jc1", SqlDbType.Float,8),
					new SqlParameter("@jc2", SqlDbType.Float,8),
					new SqlParameter("@jc3", SqlDbType.Float,8),
					new SqlParameter("@gcsj_yatou", SqlDbType.NVarChar,10),
					new SqlParameter("@yt1", SqlDbType.NVarChar,20),
					new SqlParameter("@yt2", SqlDbType.NVarChar,20),
					new SqlParameter("@yt3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_oxianliang", SqlDbType.NVarChar,10),
					new SqlParameter("@oxl1", SqlDbType.NVarChar,20),
					new SqlParameter("@oxl2", SqlDbType.NVarChar,20),
					new SqlParameter("@oxl3", SqlDbType.NVarChar,20),
					new SqlParameter("@ldxp_xinpianjj", SqlDbType.NVarChar,10),
					new SqlParameter("@ldxp_jianyanry", SqlDbType.NVarChar,10),
					new SqlParameter("@ldxp_jianyansb", SqlDbType.NVarChar,20),
					new SqlParameter("@bggSum", SqlDbType.Int,4),
					new SqlParameter("@备注", SqlDbType.NVarChar,100),
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
            parameters[0].Value = model.随工单号;
            parameters[1].Value = model.备料;
            parameters[2].Value = model.bl_sbbh1;
            parameters[3].Value = model.bl_sbbh2;
            parameters[4].Value = model.bl_sbbh3;
            parameters[5].Value = model.bl_sbbh4;
            parameters[6].Value = model.bl_xcsl;
            parameters[7].Value = model.bl_xctime;
            parameters[8].Value = model.bl_czy1;
            parameters[9].Value = model.bl_czy2;
            parameters[10].Value = model.bl_czy3;
            parameters[11].Value = model.bl_czy4;
            parameters[12].Value = model.bl_czyname1;
            parameters[13].Value = model.bl_czyname2;
            parameters[14].Value = model.bl_czyname3;
            parameters[15].Value = model.bl_czyname4;
            parameters[16].Value = model.bl_lry;
            parameters[17].Value = model.bl_lryname;
            parameters[18].Value = model.bl_bhgallsl;
            parameters[19].Value = model.blng1;
            parameters[20].Value = model.blng2;
            parameters[21].Value = model.blng3;
            parameters[22].Value = model.blng4;
            parameters[23].Value = model.blng5;
            parameters[24].Value = model.blng6;
            parameters[25].Value = model.blng7;
            parameters[26].Value = model.blng8;
            parameters[27].Value = model.blng9;
            parameters[28].Value = model.blngoth;
            parameters[29].Value = model.blngothnum;
            parameters[30].Value = model.LD焊接;
            parameters[31].Value = model.LD_sbbh1;
            parameters[32].Value = model.LD_sbbh2;
            parameters[33].Value = model.LD_sbbh3;
            parameters[34].Value = model.LD_sbbh4;
            parameters[35].Value = model.LD_sjsl;
            parameters[36].Value = model.LD_xcsl;
            parameters[37].Value = model.LD_xctime;
            parameters[38].Value = model.LD_czy1;
            parameters[39].Value = model.LD_czy2;
            parameters[40].Value = model.LD_czy3;
            parameters[41].Value = model.LD_czy4;
            parameters[42].Value = model.LD_czyname1;
            parameters[43].Value = model.LD_czyname2;
            parameters[44].Value = model.LD_czyname3;
            parameters[45].Value = model.LD_czyname4;
            parameters[46].Value = model.LD_lry;
            parameters[47].Value = model.LD_lryname;
            parameters[48].Value = model.LD_bhgallsl;
            parameters[49].Value = model.LD_jzsl;
            parameters[50].Value = model.ldng1;
            parameters[51].Value = model.ldng2;
            parameters[52].Value = model.ldng3;
            parameters[53].Value = model.ldng4;
            parameters[54].Value = model.ldng5;
            parameters[55].Value = model.ldng6;
            parameters[56].Value = model.ldng7;
            parameters[57].Value = model.ldng8;
            parameters[58].Value = model.ldng9;
            parameters[59].Value = model.ldngoth;
            parameters[60].Value = model.ldngothnum;
            parameters[61].Value = model.PT耦合固化;
            parameters[62].Value = model.PT_sbbh1;
            parameters[63].Value = model.PT_sbbh2;
            parameters[64].Value = model.PT_sbbh3;
            parameters[65].Value = model.PT_sbbh4;
            parameters[66].Value = model.PT_sjsl;
            parameters[67].Value = model.PT_xcsl;
            parameters[68].Value = model.PT_xctime;
            parameters[69].Value = model.PT_czy1;
            parameters[70].Value = model.PT_czy2;
            parameters[71].Value = model.PT_czy3;
            parameters[72].Value = model.PT_czy4;
            parameters[73].Value = model.PT_czyname1;
            parameters[74].Value = model.PT_czyname2;
            parameters[75].Value = model.PT_czyname3;
            parameters[76].Value = model.PT_czyname4;
            parameters[77].Value = model.PT_lry;
            parameters[78].Value = model.PT_lryname;
            parameters[79].Value = model.PT_bhgallsl;
            parameters[80].Value = model.PT_bhgyy;
            parameters[81].Value = model.ptng1;
            parameters[82].Value = model.ptng2;
            parameters[83].Value = model.ptng3;
            parameters[84].Value = model.ptng4;
            parameters[85].Value = model.ptng5;
            parameters[86].Value = model.ptng6;
            parameters[87].Value = model.ptng7;
            parameters[88].Value = model.ptng8;
            parameters[89].Value = model.ptng9;
            parameters[90].Value = model.ptngoth;
            parameters[91].Value = model.ptngothnum;
            parameters[92].Value = model.温循前;
            parameters[93].Value = model.WXQ_sbbh;
            parameters[94].Value = model.WXQ_sjsl;
            parameters[95].Value = model.WXQ_frsl;
            parameters[96].Value = model.WXQ_xctime;
            parameters[97].Value = model.WXQ_czy;
            parameters[98].Value = model.WXQ_czyname;
            parameters[99].Value = model.WXQ_lry;
            parameters[100].Value = model.WXQ_lryname;
            parameters[101].Value = model.WXQ_remark;
            parameters[102].Value = model.温循后;
            parameters[103].Value = model.WXH_sbbh;
            parameters[104].Value = model.WXH_qcsl;
            parameters[105].Value = model.WXH_xcsl;
            parameters[106].Value = model.WXH_wxsc;
            parameters[107].Value = model.WXH_xctime;
            parameters[108].Value = model.WXH_czy;
            parameters[109].Value = model.WXH_czyname;
            parameters[110].Value = model.WX_Hlry;
            parameters[111].Value = model.WXH_lryname;
            parameters[112].Value = model.WXH_remark;
            parameters[113].Value = model.测试;
            parameters[114].Value = model.CS_sbbh1;
            parameters[115].Value = model.CS_sbbh2;
            parameters[116].Value = model.CS_sbbh3;
            parameters[117].Value = model.CS_sbbh4;
            parameters[118].Value = model.CS_sjsl;
            parameters[119].Value = model.CS_xcsl;
            parameters[120].Value = model.CS_xctime;
            parameters[121].Value = model.CS_czy1;
            parameters[122].Value = model.CS_czy2;
            parameters[123].Value = model.CS_czy3;
            parameters[124].Value = model.CS_czy4;
            parameters[125].Value = model.CS_czyname1;
            parameters[126].Value = model.CS_czyname2;
            parameters[127].Value = model.CS_czyname3;
            parameters[128].Value = model.CS_czyname4;
            parameters[129].Value = model.CS_lry;
            parameters[130].Value = model.CS_lryname;
            parameters[131].Value = model.CS_bhgallsl;
            parameters[132].Value = model.csng1;
            parameters[133].Value = model.csng2;
            parameters[134].Value = model.csng3;
            parameters[135].Value = model.csng4;
            parameters[136].Value = model.csng5;
            parameters[137].Value = model.csng6;
            parameters[138].Value = model.csng7;
            parameters[139].Value = model.csng8;
            parameters[140].Value = model.csng9;
            parameters[141].Value = model.csngoth;
            parameters[142].Value = model.csngothnum;
            parameters[143].Value = model.清洗;
            parameters[144].Value = model.QX_sbbh1;
            parameters[145].Value = model.QX_sbbh2;
            parameters[146].Value = model.QX_sbbh3;
            parameters[147].Value = model.QX_sbbh4;
            parameters[148].Value = model.QX_sjsl;
            parameters[149].Value = model.QX_xcsl;
            parameters[150].Value = model.QX_xctime;
            parameters[151].Value = model.QX_czy1;
            parameters[152].Value = model.QX_czy2;
            parameters[153].Value = model.QX_czy3;
            parameters[154].Value = model.QX_czy4;
            parameters[155].Value = model.QX_czyname1;
            parameters[156].Value = model.QX_czyname2;
            parameters[157].Value = model.QX_czyname3;
            parameters[158].Value = model.QX_czyname4;
            parameters[159].Value = model.QX_lry;
            parameters[160].Value = model.QX_lryname;
            parameters[161].Value = model.QX_bhgallsl;
            parameters[162].Value = model.qxng1;
            parameters[163].Value = model.qxngoth;
            parameters[164].Value = model.qxngothnum;
            parameters[165].Value = model.包装;
            parameters[166].Value = model.BZ_sbbh1;
            parameters[167].Value = model.BZ_sbbh2;
            parameters[168].Value = model.BZ_sbbh3;
            parameters[169].Value = model.BZ_sbbh4;
            parameters[170].Value = model.BZ_sjsl;
            parameters[171].Value = model.BZ_xcsl;
            parameters[172].Value = model.BZ_xctime;
            parameters[173].Value = model.BZ_czy1;
            parameters[174].Value = model.BZ_czy2;
            parameters[175].Value = model.BZ_czy3;
            parameters[176].Value = model.BZ_czy4;
            parameters[177].Value = model.BZ_czyname1;
            parameters[178].Value = model.BZ_czyname2;
            parameters[179].Value = model.BZ_czyname3;
            parameters[180].Value = model.BZ_czyname4;
            parameters[181].Value = model.BZ_lry;
            parameters[182].Value = model.BZ_lryname;
            parameters[183].Value = model.BZ_bhgallsl;
            parameters[184].Value = model.bzng1;
            parameters[185].Value = model.bzngoth;
            parameters[186].Value = model.bzngothnum;
            parameters[187].Value = model.gcsj_liushuih;
            parameters[188].Value = model.lsh1;
            parameters[189].Value = model.lsh2;
            parameters[190].Value = model.lsh3;
            parameters[191].Value = model.gcsj_CASE;
            parameters[192].Value = model.case1;
            parameters[193].Value = model.case2;
            parameters[194].Value = model.case3;
            parameters[195].Value = model.gcsj_LDjia;
            parameters[196].Value = model.ld1;
            parameters[197].Value = model.ld2;
            parameters[198].Value = model.ld3;
            parameters[199].Value = model.gcsj_PDjia;
            parameters[200].Value = model.pd1;
            parameters[201].Value = model.pd2;
            parameters[202].Value = model.pd3;
            parameters[203].Value = model.gcsj_LDjian;
            parameters[204].Value = model.ldj1;
            parameters[205].Value = model.ldj2;
            parameters[206].Value = model.ldj3;
            parameters[207].Value = model.gcsj_jicha;
            parameters[208].Value = model.jc1;
            parameters[209].Value = model.jc2;
            parameters[210].Value = model.jc3;
            parameters[211].Value = model.gcsj_yatou;
            parameters[212].Value = model.yt1;
            parameters[213].Value = model.yt2;
            parameters[214].Value = model.yt3;
            parameters[215].Value = model.gcsj_oxianliang;
            parameters[216].Value = model.oxl1;
            parameters[217].Value = model.oxl2;
            parameters[218].Value = model.oxl3;
            parameters[219].Value = model.ldxp_xinpianjj;
            parameters[220].Value = model.ldxp_jianyanry;
            parameters[221].Value = model.ldxp_jianyansb;
            parameters[222].Value = model.bggSum;
            parameters[223].Value = model.备注;
            parameters[224].Value = model.LD_lx;
            parameters[225].Value = model.LD_xh;
            parameters[226].Value = model.LD_name;
            parameters[227].Value = model.LD_sjdh;
            parameters[228].Value = model.LD_remark;
            parameters[229].Value = model.PT_lx;
            parameters[230].Value = model.PT_xh;
            parameters[231].Value = model.PT_name;
            parameters[232].Value = model.PT_sjdh;
            parameters[233].Value = model.PT_remark;
            parameters[234].Value = model.KT_lx;
            parameters[235].Value = model.KT_xh;
            parameters[236].Value = model.KT_name;
            parameters[237].Value = model.KT_sjdh;
            parameters[238].Value = model.KT_remark;
            parameters[239].Value = model.NBP_lx0;
            parameters[240].Value = model.NBP_xh0;
            parameters[241].Value = model.NBP_name0;
            parameters[242].Value = model.NBP_sjdh0;
            parameters[243].Value = model.NBP_remark0;
            parameters[244].Value = model.NBP_lx45;
            parameters[245].Value = model.NBP_xh45;
            parameters[246].Value = model.NBP_name45;
            parameters[247].Value = model.NBP_sjdh45;
            parameters[248].Value = model.NBP_remark45;
            parameters[249].Value = model.JK_lx;
            parameters[250].Value = model.JK_xh;
            parameters[251].Value = model.JK_name;
            parameters[252].Value = model.JK_sjdh;
            parameters[253].Value = model.JK_remark;

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
        public bool Update(Maticsoft.Model.tsuhan_sg_tx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsuhan_sg_tx set ");
            strSql.Append("备料=@备料,");
            strSql.Append("bl_sbbh1=@bl_sbbh1,");
            strSql.Append("bl_sbbh2=@bl_sbbh2,");
            strSql.Append("bl_sbbh3=@bl_sbbh3,");
            strSql.Append("bl_sbbh4=@bl_sbbh4,");
            strSql.Append("bl_xcsl=@bl_xcsl,");
            strSql.Append("bl_xctime=@bl_xctime,");
            strSql.Append("bl_czy1=@bl_czy1,");
            strSql.Append("bl_czy2=@bl_czy2,");
            strSql.Append("bl_czy3=@bl_czy3,");
            strSql.Append("bl_czy4=@bl_czy4,");
            strSql.Append("bl_czyname1=@bl_czyname1,");
            strSql.Append("bl_czyname2=@bl_czyname2,");
            strSql.Append("bl_czyname3=@bl_czyname3,");
            strSql.Append("bl_czyname4=@bl_czyname4,");
            strSql.Append("bl_lry=@bl_lry,");
            strSql.Append("bl_lryname=@bl_lryname,");
            strSql.Append("bl_bhgallsl=@bl_bhgallsl,");
            strSql.Append("blng1=@blng1,");
            strSql.Append("blng2=@blng2,");
            strSql.Append("blng3=@blng3,");
            strSql.Append("blng4=@blng4,");
            strSql.Append("blng5=@blng5,");
            strSql.Append("blng6=@blng6,");
            strSql.Append("blng7=@blng7,");
            strSql.Append("blng8=@blng8,");
            strSql.Append("blng9=@blng9,");
            strSql.Append("blngoth=@blngoth,");
            strSql.Append("blngothnum=@blngothnum,");
            strSql.Append("LD焊接=@LD焊接,");
            strSql.Append("LD_sbbh1=@LD_sbbh1,");
            strSql.Append("LD_sbbh2=@LD_sbbh2,");
            strSql.Append("LD_sbbh3=@LD_sbbh3,");
            strSql.Append("LD_sbbh4=@LD_sbbh4,");
            strSql.Append("LD_sjsl=@LD_sjsl,");
            strSql.Append("LD_xcsl=@LD_xcsl,");
            strSql.Append("LD_xctime=@LD_xctime,");
            strSql.Append("LD_czy1=@LD_czy1,");
            strSql.Append("LD_czy2=@LD_czy2,");
            strSql.Append("LD_czy3=@LD_czy3,");
            strSql.Append("LD_czy4=@LD_czy4,");
            strSql.Append("LD_czyname1=@LD_czyname1,");
            strSql.Append("LD_czyname2=@LD_czyname2,");
            strSql.Append("LD_czyname3=@LD_czyname3,");
            strSql.Append("LD_czyname4=@LD_czyname4,");
            strSql.Append("LD_lry=@LD_lry,");
            strSql.Append("LD_lryname=@LD_lryname,");
            strSql.Append("LD_bhgallsl=@LD_bhgallsl,");
            strSql.Append("LD_jzsl=@LD_jzsl,");
            strSql.Append("ldng1=@ldng1,");
            strSql.Append("ldng2=@ldng2,");
            strSql.Append("ldng3=@ldng3,");
            strSql.Append("ldng4=@ldng4,");
            strSql.Append("ldng5=@ldng5,");
            strSql.Append("ldng6=@ldng6,");
            strSql.Append("ldng7=@ldng7,");
            strSql.Append("ldng8=@ldng8,");
            strSql.Append("ldng9=@ldng9,");
            strSql.Append("ldngoth=@ldngoth,");
            strSql.Append("ldngothnum=@ldngothnum,");
            strSql.Append("PT耦合固化=@PT耦合固化,");
            strSql.Append("PT_sbbh1=@PT_sbbh1,");
            strSql.Append("PT_sbbh2=@PT_sbbh2,");
            strSql.Append("PT_sbbh3=@PT_sbbh3,");
            strSql.Append("PT_sbbh4=@PT_sbbh4,");
            strSql.Append("PT_sjsl=@PT_sjsl,");
            strSql.Append("PT_xcsl=@PT_xcsl,");
            strSql.Append("PT_xctime=@PT_xctime,");
            strSql.Append("PT_czy1=@PT_czy1,");
            strSql.Append("PT_czy2=@PT_czy2,");
            strSql.Append("PT_czy3=@PT_czy3,");
            strSql.Append("PT_czy4=@PT_czy4,");
            strSql.Append("PT_czyname1=@PT_czyname1,");
            strSql.Append("PT_czyname2=@PT_czyname2,");
            strSql.Append("PT_czyname3=@PT_czyname3,");
            strSql.Append("PT_czyname4=@PT_czyname4,");
            strSql.Append("PT_lry=@PT_lry,");
            strSql.Append("PT_lryname=@PT_lryname,");
            strSql.Append("PT_bhgallsl=@PT_bhgallsl,");
            strSql.Append("PT_bhgyy=@PT_bhgyy,");
            strSql.Append("ptng1=@ptng1,");
            strSql.Append("ptng2=@ptng2,");
            strSql.Append("ptng3=@ptng3,");
            strSql.Append("ptng4=@ptng4,");
            strSql.Append("ptng5=@ptng5,");
            strSql.Append("ptng6=@ptng6,");
            strSql.Append("ptng7=@ptng7,");
            strSql.Append("ptng8=@ptng8,");
            strSql.Append("ptng9=@ptng9,");
            strSql.Append("ptngoth=@ptngoth,");
            strSql.Append("ptngothnum=@ptngothnum,");
            strSql.Append("温循前=@温循前,");
            strSql.Append("WXQ_sbbh=@WXQ_sbbh,");
            strSql.Append("WXQ_sjsl=@WXQ_sjsl,");
            strSql.Append("WXQ_frsl=@WXQ_frsl,");
            strSql.Append("WXQ_xctime=@WXQ_xctime,");
            strSql.Append("WXQ_czy=@WXQ_czy,");
            strSql.Append("WXQ_czyname=@WXQ_czyname,");
            strSql.Append("WXQ_lry=@WXQ_lry,");
            strSql.Append("WXQ_lryname=@WXQ_lryname,");
            strSql.Append("WXQ_remark=@WXQ_remark,");
            strSql.Append("温循后=@温循后,");
            strSql.Append("WXH_sbbh=@WXH_sbbh,");
            strSql.Append("WXH_qcsl=@WXH_qcsl,");
            strSql.Append("WXH_xcsl=@WXH_xcsl,");
            strSql.Append("WXH_wxsc=@WXH_wxsc,");
            strSql.Append("WXH_xctime=@WXH_xctime,");
            strSql.Append("WXH_czy=@WXH_czy,");
            strSql.Append("WXH_czyname=@WXH_czyname,");
            strSql.Append("WX_Hlry=@WX_Hlry,");
            strSql.Append("WXH_lryname=@WXH_lryname,");
            strSql.Append("WXH_remark=@WXH_remark,");
            strSql.Append("测试=@测试,");
            strSql.Append("CS_sbbh1=@CS_sbbh1,");
            strSql.Append("CS_sbbh2=@CS_sbbh2,");
            strSql.Append("CS_sbbh3=@CS_sbbh3,");
            strSql.Append("CS_sbbh4=@CS_sbbh4,");
            strSql.Append("CS_sjsl=@CS_sjsl,");
            strSql.Append("CS_xcsl=@CS_xcsl,");
            strSql.Append("CS_xctime=@CS_xctime,");
            strSql.Append("CS_czy1=@CS_czy1,");
            strSql.Append("CS_czy2=@CS_czy2,");
            strSql.Append("CS_czy3=@CS_czy3,");
            strSql.Append("CS_czy4=@CS_czy4,");
            strSql.Append("CS_czyname1=@CS_czyname1,");
            strSql.Append("CS_czyname2=@CS_czyname2,");
            strSql.Append("CS_czyname3=@CS_czyname3,");
            strSql.Append("CS_czyname4=@CS_czyname4,");
            strSql.Append("CS_lry=@CS_lry,");
            strSql.Append("CS_lryname=@CS_lryname,");
            strSql.Append("CS_bhgallsl=@CS_bhgallsl,");
            strSql.Append("csng1=@csng1,");
            strSql.Append("csng2=@csng2,");
            strSql.Append("csng3=@csng3,");
            strSql.Append("csng4=@csng4,");
            strSql.Append("csng5=@csng5,");
            strSql.Append("csng6=@csng6,");
            strSql.Append("csng7=@csng7,");
            strSql.Append("csng8=@csng8,");
            strSql.Append("csng9=@csng9,");
            strSql.Append("csngoth=@csngoth,");
            strSql.Append("csngothnum=@csngothnum,");
            strSql.Append("清洗=@清洗,");
            strSql.Append("QX_sbbh1=@QX_sbbh1,");
            strSql.Append("QX_sbbh2=@QX_sbbh2,");
            strSql.Append("QX_sbbh3=@QX_sbbh3,");
            strSql.Append("QX_sbbh4=@QX_sbbh4,");
            strSql.Append("QX_sjsl=@QX_sjsl,");
            strSql.Append("QX_xcsl=@QX_xcsl,");
            strSql.Append("QX_xctime=@QX_xctime,");
            strSql.Append("QX_czy1=@QX_czy1,");
            strSql.Append("QX_czy2=@QX_czy2,");
            strSql.Append("QX_czy3=@QX_czy3,");
            strSql.Append("QX_czy4=@QX_czy4,");
            strSql.Append("QX_czyname1=@QX_czyname1,");
            strSql.Append("QX_czyname2=@QX_czyname2,");
            strSql.Append("QX_czyname3=@QX_czyname3,");
            strSql.Append("QX_czyname4=@QX_czyname4,");
            strSql.Append("QX_lry=@QX_lry,");
            strSql.Append("QX_lryname=@QX_lryname,");
            strSql.Append("QX_bhgallsl=@QX_bhgallsl,");
            strSql.Append("qxng1=@qxng1,");
            strSql.Append("qxngoth=@qxngoth,");
            strSql.Append("qxngothnum=@qxngothnum,");
            strSql.Append("包装=@包装,");
            strSql.Append("BZ_sbbh1=@BZ_sbbh1,");
            strSql.Append("BZ_sbbh2=@BZ_sbbh2,");
            strSql.Append("BZ_sbbh3=@BZ_sbbh3,");
            strSql.Append("BZ_sbbh4=@BZ_sbbh4,");
            strSql.Append("BZ_sjsl=@BZ_sjsl,");
            strSql.Append("BZ_xcsl=@BZ_xcsl,");
            strSql.Append("BZ_xctime=@BZ_xctime,");
            strSql.Append("BZ_czy1=@BZ_czy1,");
            strSql.Append("BZ_czy2=@BZ_czy2,");
            strSql.Append("BZ_czy3=@BZ_czy3,");
            strSql.Append("BZ_czy4=@BZ_czy4,");
            strSql.Append("BZ_czyname1=@BZ_czyname1,");
            strSql.Append("BZ_czyname2=@BZ_czyname2,");
            strSql.Append("BZ_czyname3=@BZ_czyname3,");
            strSql.Append("BZ_czyname4=@BZ_czyname4,");
            strSql.Append("BZ_lry=@BZ_lry,");
            strSql.Append("BZ_lryname=@BZ_lryname,");
            strSql.Append("BZ_bhgallsl=@BZ_bhgallsl,");
            strSql.Append("bzng1=@bzng1,");
            strSql.Append("bzngoth=@bzngoth,");
            strSql.Append("bzngothnum=@bzngothnum,");
            strSql.Append("gcsj_liushuih=@gcsj_liushuih,");
            strSql.Append("lsh1=@lsh1,");
            strSql.Append("lsh2=@lsh2,");
            strSql.Append("lsh3=@lsh3,");
            strSql.Append("gcsj_CASE=@gcsj_CASE,");
            strSql.Append("case1=@case1,");
            strSql.Append("case2=@case2,");
            strSql.Append("case3=@case3,");
            strSql.Append("gcsj_LDjia=@gcsj_LDjia,");
            strSql.Append("ld1=@ld1,");
            strSql.Append("ld2=@ld2,");
            strSql.Append("ld3=@ld3,");
            strSql.Append("gcsj_PDjia=@gcsj_PDjia,");
            strSql.Append("pd1=@pd1,");
            strSql.Append("pd2=@pd2,");
            strSql.Append("pd3=@pd3,");
            strSql.Append("gcsj_LDjian=@gcsj_LDjian,");
            strSql.Append("ldj1=@ldj1,");
            strSql.Append("ldj2=@ldj2,");
            strSql.Append("ldj3=@ldj3,");
            strSql.Append("gcsj_jicha=@gcsj_jicha,");
            strSql.Append("jc1=@jc1,");
            strSql.Append("jc2=@jc2,");
            strSql.Append("jc3=@jc3,");
            strSql.Append("gcsj_yatou=@gcsj_yatou,");
            strSql.Append("yt1=@yt1,");
            strSql.Append("yt2=@yt2,");
            strSql.Append("yt3=@yt3,");
            strSql.Append("gcsj_oxianliang=@gcsj_oxianliang,");
            strSql.Append("oxl1=@oxl1,");
            strSql.Append("oxl2=@oxl2,");
            strSql.Append("oxl3=@oxl3,");
            strSql.Append("ldxp_xinpianjj=@ldxp_xinpianjj,");
            strSql.Append("ldxp_jianyanry=@ldxp_jianyanry,");
            strSql.Append("ldxp_jianyansb=@ldxp_jianyansb,");
            strSql.Append("bggSum=@bggSum,");
            strSql.Append("备注=@备注,");
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
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@备料", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_xcsl", SqlDbType.Int,4),
					new SqlParameter("@bl_xctime", SqlDbType.DateTime),
					new SqlParameter("@bl_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@bl_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@bl_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@blng1", SqlDbType.Int,4),
					new SqlParameter("@blng2", SqlDbType.Int,4),
					new SqlParameter("@blng3", SqlDbType.Int,4),
					new SqlParameter("@blng4", SqlDbType.Int,4),
					new SqlParameter("@blng5", SqlDbType.Int,4),
					new SqlParameter("@blng6", SqlDbType.Int,4),
					new SqlParameter("@blng7", SqlDbType.Int,4),
					new SqlParameter("@blng8", SqlDbType.Int,4),
					new SqlParameter("@blng9", SqlDbType.Int,4),
					new SqlParameter("@blngoth", SqlDbType.VarChar,50),
					new SqlParameter("@blngothnum", SqlDbType.Int,4),
					new SqlParameter("@LD焊接", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_sjsl", SqlDbType.Int,4),
					new SqlParameter("@LD_xcsl", SqlDbType.Int,4),
					new SqlParameter("@LD_xctime", SqlDbType.DateTime),
					new SqlParameter("@LD_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@LD_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@LD_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@LD_jzsl", SqlDbType.Int,4),
					new SqlParameter("@ldng1", SqlDbType.Int,4),
					new SqlParameter("@ldng2", SqlDbType.Int,4),
					new SqlParameter("@ldng3", SqlDbType.Int,4),
					new SqlParameter("@ldng4", SqlDbType.Int,4),
					new SqlParameter("@ldng5", SqlDbType.Int,4),
					new SqlParameter("@ldng6", SqlDbType.Int,4),
					new SqlParameter("@ldng7", SqlDbType.Int,4),
					new SqlParameter("@ldng8", SqlDbType.Int,4),
					new SqlParameter("@ldng9", SqlDbType.Int,4),
					new SqlParameter("@ldngoth", SqlDbType.VarChar,30),
					new SqlParameter("@ldngothnum", SqlDbType.Int,4),
					new SqlParameter("@PT耦合固化", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_sjsl", SqlDbType.Int,4),
					new SqlParameter("@PT_xcsl", SqlDbType.Int,4),
					new SqlParameter("@PT_xctime", SqlDbType.DateTime),
					new SqlParameter("@PT_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@PT_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@PT_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@PT_bhgyy", SqlDbType.NVarChar,200),
					new SqlParameter("@ptng1", SqlDbType.Int,4),
					new SqlParameter("@ptng2", SqlDbType.Int,4),
					new SqlParameter("@ptng3", SqlDbType.Int,4),
					new SqlParameter("@ptng4", SqlDbType.Int,4),
					new SqlParameter("@ptng5", SqlDbType.Int,4),
					new SqlParameter("@ptng6", SqlDbType.Int,4),
					new SqlParameter("@ptng7", SqlDbType.Int,4),
					new SqlParameter("@ptng8", SqlDbType.Int,4),
					new SqlParameter("@ptng9", SqlDbType.Int,4),
					new SqlParameter("@ptngoth", SqlDbType.VarChar,30),
					new SqlParameter("@ptngothnum", SqlDbType.Int,4),
					new SqlParameter("@温循前", SqlDbType.NVarChar,10),
					new SqlParameter("@WXQ_sbbh", SqlDbType.NVarChar,10),
					new SqlParameter("@WXQ_sjsl", SqlDbType.Int,4),
					new SqlParameter("@WXQ_frsl", SqlDbType.Int,4),
					new SqlParameter("@WXQ_xctime", SqlDbType.DateTime),
					new SqlParameter("@WXQ_czy", SqlDbType.NVarChar,10),
					new SqlParameter("@WXQ_czyname", SqlDbType.NVarChar,20),
					new SqlParameter("@WXQ_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@WXQ_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@WXQ_remark", SqlDbType.NVarChar,50),
					new SqlParameter("@温循后", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_sbbh", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_qcsl", SqlDbType.Int,4),
					new SqlParameter("@WXH_xcsl", SqlDbType.Int,4),
					new SqlParameter("@WXH_wxsc", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_xctime", SqlDbType.DateTime),
					new SqlParameter("@WXH_czy", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_czyname", SqlDbType.NVarChar,20),
					new SqlParameter("@WX_Hlry", SqlDbType.NVarChar,10),
					new SqlParameter("@WXH_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@WXH_remark", SqlDbType.NVarChar,50),
					new SqlParameter("@测试", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_sjsl", SqlDbType.Int,4),
					new SqlParameter("@CS_xcsl", SqlDbType.Int,4),
					new SqlParameter("@CS_xctime", SqlDbType.DateTime),
					new SqlParameter("@CS_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@CS_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@CS_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@csng1", SqlDbType.Int,4),
					new SqlParameter("@csng2", SqlDbType.Int,4),
					new SqlParameter("@csng3", SqlDbType.Int,4),
					new SqlParameter("@csng4", SqlDbType.Int,4),
					new SqlParameter("@csng5", SqlDbType.Int,4),
					new SqlParameter("@csng6", SqlDbType.Int,4),
					new SqlParameter("@csng7", SqlDbType.Int,4),
					new SqlParameter("@csng8", SqlDbType.Int,4),
					new SqlParameter("@csng9", SqlDbType.Int,4),
					new SqlParameter("@csngoth", SqlDbType.VarChar,30),
					new SqlParameter("@csngothnum", SqlDbType.Int,4),
					new SqlParameter("@清洗", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_sjsl", SqlDbType.Int,4),
					new SqlParameter("@QX_xcsl", SqlDbType.Int,4),
					new SqlParameter("@QX_xctime", SqlDbType.DateTime),
					new SqlParameter("@QX_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@QX_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@QX_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@qxng1", SqlDbType.Int,4),
					new SqlParameter("@qxngoth", SqlDbType.VarChar,30),
					new SqlParameter("@qxngothnum", SqlDbType.Int,4),
					new SqlParameter("@包装", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sbbh1", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sbbh2", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sbbh3", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sbbh4", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_sjsl", SqlDbType.Int,4),
					new SqlParameter("@BZ_xcsl", SqlDbType.Int,4),
					new SqlParameter("@BZ_xctime", SqlDbType.DateTime),
					new SqlParameter("@BZ_czy1", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_czy2", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_czy3", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_czy4", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_czyname1", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_czyname2", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_czyname3", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_czyname4", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_lry", SqlDbType.NVarChar,10),
					new SqlParameter("@BZ_lryname", SqlDbType.NVarChar,20),
					new SqlParameter("@BZ_bhgallsl", SqlDbType.Int,4),
					new SqlParameter("@bzng1", SqlDbType.Int,4),
					new SqlParameter("@bzngoth", SqlDbType.VarChar,30),
					new SqlParameter("@bzngothnum", SqlDbType.Int,4),
					new SqlParameter("@gcsj_liushuih", SqlDbType.NVarChar,10),
					new SqlParameter("@lsh1", SqlDbType.NVarChar,20),
					new SqlParameter("@lsh2", SqlDbType.NVarChar,20),
					new SqlParameter("@lsh3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_CASE", SqlDbType.NVarChar,10),
					new SqlParameter("@case1", SqlDbType.NVarChar,20),
					new SqlParameter("@case2", SqlDbType.NVarChar,20),
					new SqlParameter("@case3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_LDjia", SqlDbType.NVarChar,10),
					new SqlParameter("@ld1", SqlDbType.NVarChar,20),
					new SqlParameter("@ld2", SqlDbType.NVarChar,20),
					new SqlParameter("@ld3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_PDjia", SqlDbType.NVarChar,10),
					new SqlParameter("@pd1", SqlDbType.NVarChar,20),
					new SqlParameter("@pd2", SqlDbType.NVarChar,20),
					new SqlParameter("@pd3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_LDjian", SqlDbType.NVarChar,10),
					new SqlParameter("@ldj1", SqlDbType.NVarChar,20),
					new SqlParameter("@ldj2", SqlDbType.NVarChar,20),
					new SqlParameter("@ldj3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_jicha", SqlDbType.NVarChar,10),
					new SqlParameter("@jc1", SqlDbType.Float,8),
					new SqlParameter("@jc2", SqlDbType.Float,8),
					new SqlParameter("@jc3", SqlDbType.Float,8),
					new SqlParameter("@gcsj_yatou", SqlDbType.NVarChar,10),
					new SqlParameter("@yt1", SqlDbType.NVarChar,20),
					new SqlParameter("@yt2", SqlDbType.NVarChar,20),
					new SqlParameter("@yt3", SqlDbType.NVarChar,20),
					new SqlParameter("@gcsj_oxianliang", SqlDbType.NVarChar,10),
					new SqlParameter("@oxl1", SqlDbType.NVarChar,20),
					new SqlParameter("@oxl2", SqlDbType.NVarChar,20),
					new SqlParameter("@oxl3", SqlDbType.NVarChar,20),
					new SqlParameter("@ldxp_xinpianjj", SqlDbType.NVarChar,10),
					new SqlParameter("@ldxp_jianyanry", SqlDbType.NVarChar,10),
					new SqlParameter("@ldxp_jianyansb", SqlDbType.NVarChar,20),
					new SqlParameter("@bggSum", SqlDbType.Int,4),
					new SqlParameter("@备注", SqlDbType.NVarChar,100),
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
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@随工单号", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.备料;
            parameters[1].Value = model.bl_sbbh1;
            parameters[2].Value = model.bl_sbbh2;
            parameters[3].Value = model.bl_sbbh3;
            parameters[4].Value = model.bl_sbbh4;
            parameters[5].Value = model.bl_xcsl;
            parameters[6].Value = model.bl_xctime;
            parameters[7].Value = model.bl_czy1;
            parameters[8].Value = model.bl_czy2;
            parameters[9].Value = model.bl_czy3;
            parameters[10].Value = model.bl_czy4;
            parameters[11].Value = model.bl_czyname1;
            parameters[12].Value = model.bl_czyname2;
            parameters[13].Value = model.bl_czyname3;
            parameters[14].Value = model.bl_czyname4;
            parameters[15].Value = model.bl_lry;
            parameters[16].Value = model.bl_lryname;
            parameters[17].Value = model.bl_bhgallsl;
            parameters[18].Value = model.blng1;
            parameters[19].Value = model.blng2;
            parameters[20].Value = model.blng3;
            parameters[21].Value = model.blng4;
            parameters[22].Value = model.blng5;
            parameters[23].Value = model.blng6;
            parameters[24].Value = model.blng7;
            parameters[25].Value = model.blng8;
            parameters[26].Value = model.blng9;
            parameters[27].Value = model.blngoth;
            parameters[28].Value = model.blngothnum;
            parameters[29].Value = model.LD焊接;
            parameters[30].Value = model.LD_sbbh1;
            parameters[31].Value = model.LD_sbbh2;
            parameters[32].Value = model.LD_sbbh3;
            parameters[33].Value = model.LD_sbbh4;
            parameters[34].Value = model.LD_sjsl;
            parameters[35].Value = model.LD_xcsl;
            parameters[36].Value = model.LD_xctime;
            parameters[37].Value = model.LD_czy1;
            parameters[38].Value = model.LD_czy2;
            parameters[39].Value = model.LD_czy3;
            parameters[40].Value = model.LD_czy4;
            parameters[41].Value = model.LD_czyname1;
            parameters[42].Value = model.LD_czyname2;
            parameters[43].Value = model.LD_czyname3;
            parameters[44].Value = model.LD_czyname4;
            parameters[45].Value = model.LD_lry;
            parameters[46].Value = model.LD_lryname;
            parameters[47].Value = model.LD_bhgallsl;
            parameters[48].Value = model.LD_jzsl;
            parameters[49].Value = model.ldng1;
            parameters[50].Value = model.ldng2;
            parameters[51].Value = model.ldng3;
            parameters[52].Value = model.ldng4;
            parameters[53].Value = model.ldng5;
            parameters[54].Value = model.ldng6;
            parameters[55].Value = model.ldng7;
            parameters[56].Value = model.ldng8;
            parameters[57].Value = model.ldng9;
            parameters[58].Value = model.ldngoth;
            parameters[59].Value = model.ldngothnum;
            parameters[60].Value = model.PT耦合固化;
            parameters[61].Value = model.PT_sbbh1;
            parameters[62].Value = model.PT_sbbh2;
            parameters[63].Value = model.PT_sbbh3;
            parameters[64].Value = model.PT_sbbh4;
            parameters[65].Value = model.PT_sjsl;
            parameters[66].Value = model.PT_xcsl;
            parameters[67].Value = model.PT_xctime;
            parameters[68].Value = model.PT_czy1;
            parameters[69].Value = model.PT_czy2;
            parameters[70].Value = model.PT_czy3;
            parameters[71].Value = model.PT_czy4;
            parameters[72].Value = model.PT_czyname1;
            parameters[73].Value = model.PT_czyname2;
            parameters[74].Value = model.PT_czyname3;
            parameters[75].Value = model.PT_czyname4;
            parameters[76].Value = model.PT_lry;
            parameters[77].Value = model.PT_lryname;
            parameters[78].Value = model.PT_bhgallsl;
            parameters[79].Value = model.PT_bhgyy;
            parameters[80].Value = model.ptng1;
            parameters[81].Value = model.ptng2;
            parameters[82].Value = model.ptng3;
            parameters[83].Value = model.ptng4;
            parameters[84].Value = model.ptng5;
            parameters[85].Value = model.ptng6;
            parameters[86].Value = model.ptng7;
            parameters[87].Value = model.ptng8;
            parameters[88].Value = model.ptng9;
            parameters[89].Value = model.ptngoth;
            parameters[90].Value = model.ptngothnum;
            parameters[91].Value = model.温循前;
            parameters[92].Value = model.WXQ_sbbh;
            parameters[93].Value = model.WXQ_sjsl;
            parameters[94].Value = model.WXQ_frsl;
            parameters[95].Value = model.WXQ_xctime;
            parameters[96].Value = model.WXQ_czy;
            parameters[97].Value = model.WXQ_czyname;
            parameters[98].Value = model.WXQ_lry;
            parameters[99].Value = model.WXQ_lryname;
            parameters[100].Value = model.WXQ_remark;
            parameters[101].Value = model.温循后;
            parameters[102].Value = model.WXH_sbbh;
            parameters[103].Value = model.WXH_qcsl;
            parameters[104].Value = model.WXH_xcsl;
            parameters[105].Value = model.WXH_wxsc;
            parameters[106].Value = model.WXH_xctime;
            parameters[107].Value = model.WXH_czy;
            parameters[108].Value = model.WXH_czyname;
            parameters[109].Value = model.WX_Hlry;
            parameters[110].Value = model.WXH_lryname;
            parameters[111].Value = model.WXH_remark;
            parameters[112].Value = model.测试;
            parameters[113].Value = model.CS_sbbh1;
            parameters[114].Value = model.CS_sbbh2;
            parameters[115].Value = model.CS_sbbh3;
            parameters[116].Value = model.CS_sbbh4;
            parameters[117].Value = model.CS_sjsl;
            parameters[118].Value = model.CS_xcsl;
            parameters[119].Value = model.CS_xctime;
            parameters[120].Value = model.CS_czy1;
            parameters[121].Value = model.CS_czy2;
            parameters[122].Value = model.CS_czy3;
            parameters[123].Value = model.CS_czy4;
            parameters[124].Value = model.CS_czyname1;
            parameters[125].Value = model.CS_czyname2;
            parameters[126].Value = model.CS_czyname3;
            parameters[127].Value = model.CS_czyname4;
            parameters[128].Value = model.CS_lry;
            parameters[129].Value = model.CS_lryname;
            parameters[130].Value = model.CS_bhgallsl;
            parameters[131].Value = model.csng1;
            parameters[132].Value = model.csng2;
            parameters[133].Value = model.csng3;
            parameters[134].Value = model.csng4;
            parameters[135].Value = model.csng5;
            parameters[136].Value = model.csng6;
            parameters[137].Value = model.csng7;
            parameters[138].Value = model.csng8;
            parameters[139].Value = model.csng9;
            parameters[140].Value = model.csngoth;
            parameters[141].Value = model.csngothnum;
            parameters[142].Value = model.清洗;
            parameters[143].Value = model.QX_sbbh1;
            parameters[144].Value = model.QX_sbbh2;
            parameters[145].Value = model.QX_sbbh3;
            parameters[146].Value = model.QX_sbbh4;
            parameters[147].Value = model.QX_sjsl;
            parameters[148].Value = model.QX_xcsl;
            parameters[149].Value = model.QX_xctime;
            parameters[150].Value = model.QX_czy1;
            parameters[151].Value = model.QX_czy2;
            parameters[152].Value = model.QX_czy3;
            parameters[153].Value = model.QX_czy4;
            parameters[154].Value = model.QX_czyname1;
            parameters[155].Value = model.QX_czyname2;
            parameters[156].Value = model.QX_czyname3;
            parameters[157].Value = model.QX_czyname4;
            parameters[158].Value = model.QX_lry;
            parameters[159].Value = model.QX_lryname;
            parameters[160].Value = model.QX_bhgallsl;
            parameters[161].Value = model.qxng1;
            parameters[162].Value = model.qxngoth;
            parameters[163].Value = model.qxngothnum;
            parameters[164].Value = model.包装;
            parameters[165].Value = model.BZ_sbbh1;
            parameters[166].Value = model.BZ_sbbh2;
            parameters[167].Value = model.BZ_sbbh3;
            parameters[168].Value = model.BZ_sbbh4;
            parameters[169].Value = model.BZ_sjsl;
            parameters[170].Value = model.BZ_xcsl;
            parameters[171].Value = model.BZ_xctime;
            parameters[172].Value = model.BZ_czy1;
            parameters[173].Value = model.BZ_czy2;
            parameters[174].Value = model.BZ_czy3;
            parameters[175].Value = model.BZ_czy4;
            parameters[176].Value = model.BZ_czyname1;
            parameters[177].Value = model.BZ_czyname2;
            parameters[178].Value = model.BZ_czyname3;
            parameters[179].Value = model.BZ_czyname4;
            parameters[180].Value = model.BZ_lry;
            parameters[181].Value = model.BZ_lryname;
            parameters[182].Value = model.BZ_bhgallsl;
            parameters[183].Value = model.bzng1;
            parameters[184].Value = model.bzngoth;
            parameters[185].Value = model.bzngothnum;
            parameters[186].Value = model.gcsj_liushuih;
            parameters[187].Value = model.lsh1;
            parameters[188].Value = model.lsh2;
            parameters[189].Value = model.lsh3;
            parameters[190].Value = model.gcsj_CASE;
            parameters[191].Value = model.case1;
            parameters[192].Value = model.case2;
            parameters[193].Value = model.case3;
            parameters[194].Value = model.gcsj_LDjia;
            parameters[195].Value = model.ld1;
            parameters[196].Value = model.ld2;
            parameters[197].Value = model.ld3;
            parameters[198].Value = model.gcsj_PDjia;
            parameters[199].Value = model.pd1;
            parameters[200].Value = model.pd2;
            parameters[201].Value = model.pd3;
            parameters[202].Value = model.gcsj_LDjian;
            parameters[203].Value = model.ldj1;
            parameters[204].Value = model.ldj2;
            parameters[205].Value = model.ldj3;
            parameters[206].Value = model.gcsj_jicha;
            parameters[207].Value = model.jc1;
            parameters[208].Value = model.jc2;
            parameters[209].Value = model.jc3;
            parameters[210].Value = model.gcsj_yatou;
            parameters[211].Value = model.yt1;
            parameters[212].Value = model.yt2;
            parameters[213].Value = model.yt3;
            parameters[214].Value = model.gcsj_oxianliang;
            parameters[215].Value = model.oxl1;
            parameters[216].Value = model.oxl2;
            parameters[217].Value = model.oxl3;
            parameters[218].Value = model.ldxp_xinpianjj;
            parameters[219].Value = model.ldxp_jianyanry;
            parameters[220].Value = model.ldxp_jianyansb;
            parameters[221].Value = model.bggSum;
            parameters[222].Value = model.备注;
            parameters[223].Value = model.LD_lx;
            parameters[224].Value = model.LD_xh;
            parameters[225].Value = model.LD_name;
            parameters[226].Value = model.LD_sjdh;
            parameters[227].Value = model.LD_remark;
            parameters[228].Value = model.PT_lx;
            parameters[229].Value = model.PT_xh;
            parameters[230].Value = model.PT_name;
            parameters[231].Value = model.PT_sjdh;
            parameters[232].Value = model.PT_remark;
            parameters[233].Value = model.KT_lx;
            parameters[234].Value = model.KT_xh;
            parameters[235].Value = model.KT_name;
            parameters[236].Value = model.KT_sjdh;
            parameters[237].Value = model.KT_remark;
            parameters[238].Value = model.NBP_lx0;
            parameters[239].Value = model.NBP_xh0;
            parameters[240].Value = model.NBP_name0;
            parameters[241].Value = model.NBP_sjdh0;
            parameters[242].Value = model.NBP_remark0;
            parameters[243].Value = model.NBP_lx45;
            parameters[244].Value = model.NBP_xh45;
            parameters[245].Value = model.NBP_name45;
            parameters[246].Value = model.NBP_sjdh45;
            parameters[247].Value = model.NBP_remark45;
            parameters[248].Value = model.JK_lx;
            parameters[249].Value = model.JK_xh;
            parameters[250].Value = model.JK_name;
            parameters[251].Value = model.JK_sjdh;
            parameters[252].Value = model.JK_remark;
            parameters[253].Value = model.id;
            parameters[254].Value = model.随工单号;

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
        /// 判断是否存在该条记录
        /// </summary>
        /// <param name="随工单号"></param>
        /// <returns></returns>
        public bool Exists(string 随工单号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsuhan_sg_tx");
            strSql.Append(" where 随工单号=@随工单号 ");
            SqlParameter[] parameters = {
					new SqlParameter("@随工单号", SqlDbType.NVarChar,20)			};
            parameters[0].Value = 随工单号;
            return dbhelper1.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns></returns>
        public tsuhan_sg_tx GetAllTx()
        {
            string sql = "select * from tsuhan_sg_tx";
            DataSet ds = dbhelper1.Query(sql.ToString());
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
