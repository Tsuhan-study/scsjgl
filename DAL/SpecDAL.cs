using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Maticsoft.DBUtility;
using System.Data.SqlClient;
using Maticsoft.Model;

namespace DAL
{
    public class SpecDAL
    {
        DbHelperSQLP dbhelper1 = new DbHelperSQLP(PubConstant.GetConnectionString("connectionString2"));

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string 规格书)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsuhan_spec");
            strSql.Append(" where 规格书=@规格书 ");
            SqlParameter[] parameters = {
					new SqlParameter("@规格书", SqlDbType.NVarChar,15)			};
            parameters[0].Value = 规格书;

            return dbhelper1.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 绑定规格书编号
        /// </summary>
        /// <returns></returns>
        public DataTable GetSpecsTable()
        {
            string sql = "SELECT * FROM tsuhan_spec";
            return dbhelper1.GetTable(sql, new List<SqlParameter>());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(tsuhan_spec model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_spec(");
            strSql.Append("规格书,产品型号,成品编码,客户代码,LDλc,LD方法,Tc_d,Tc_c,Tc_h,Po,Pomin,PominBFB,Pomax,PomaxBFB,Pohmin,Pohmax,Podmin,Podmax,Ithmin,Ithmax,Ithhmin,Ithhmax,Ithdmin,Ithdmax,Ifmin,Ifmax,Ifhmin,Ifhmax,Ifdmin,Ifdmax,Ifc,Ifh,Ifd,Vfmin,Vfmax,Vfhmin,Vfhmax,Vfdmax,Vfdmin,Imomin,ImominBFB,Imomax,ImomaxBFB,Imohmin,Imohmax,Imodmin,Imodmax,Esmin,EsminBFB,Esmax,EsmaxBFB,Eshmin,Eshmax,Esdmin,Esdmax,Rsmin,Rsmax,Rshmin,Rshmax,Rsdmin,Rsdmax,TEdmin,TEdmax,TEhmin,TEhmax,LDλcmin,LDλcmax,LDλchmin,LDλchmax,LDλcdmin,LDλcdmax,LDλmin,LDλmax,LDλhmin,LDλhmax,LDλdmin,LDλdmax,Srmsmin,Srmsmax,Srmshmin,Srmshmax,Srmsdmin,Srmsdmax,Pkinkmin,Pkinkmax,Pkinkhmin,Pkinkhmax,Pkinkdmin,Pkinkdmax,Kimomin,Kimomax,Kimohmin,Kimohmax,Kimodmin,Kimodmax,ImoKinkmin,ImoKinkmax,Idarkmin,Idarkmax,Txidmin,Txidmax,Txidhmin,Txidhmax,Txiddmin,Txiddmax,qpomin,qpomax,qhpomin,qhpomax,PTλc,PT方法,APT_PT,码型,速率,Sen,通时间,误码率,Vbr34,Vbrmin,Vbrmax,Vbrhmin,Vbrhmax,Vbrdmin,Vbrdmax,Iccmin,Iccmax,Icchmin,Icchmax,Iccdmin,Iccdmax,Iopmin,IopminBFB,Iopmax,Iomin,IominBFB,Iomax,Idmin,Idmax,Senmin,Senmax,SenmaxdB,senhmin,senhmax,sendmin,sendmax,老化前min,老化前minBFB,老化前max,老化前maxBFB,前后对比min,前后对比max,上传时间,审核时间,备注)");
            strSql.Append(" values (");
            strSql.Append("@规格书,@产品型号,@成品编码,@客户代码,@LDλc,@LD方法,@Tc_d,@Tc_c,@Tc_h,@Po,@Pomin,@PominBFB,@Pomax,@PomaxBFB,@Pohmin,@Pohmax,@Podmin,@Podmax,@Ithmin,@Ithmax,@Ithhmin,@Ithhmax,@Ithdmin,@Ithdmax,@Ifmin,@Ifmax,@Ifhmin,@Ifhmax,@Ifdmin,@Ifdmax,@Ifc,@Ifh,@Ifd,@Vfmin,@Vfmax,@Vfhmin,@Vfhmax,@Vfdmax,@Vfdmin,@Imomin,@ImominBFB,@Imomax,@ImomaxBFB,@Imohmin,@Imohmax,@Imodmin,@Imodmax,@Esmin,@EsminBFB,@Esmax,@EsmaxBFB,@Eshmin,@Eshmax,@Esdmin,@Esdmax,@Rsmin,@Rsmax,@Rshmin,@Rshmax,@Rsdmin,@Rsdmax,@TEdmin,@TEdmax,@TEhmin,@TEhmax,@LDλcmin,@LDλcmax,@LDλchmin,@LDλchmax,@LDλcdmin,@LDλcdmax,@LDλmin,@LDλmax,@LDλhmin,@LDλhmax,@LDλdmin,@LDλdmax,@Srmsmin,@Srmsmax,@Srmshmin,@Srmshmax,@Srmsdmin,@Srmsdmax,@Pkinkmin,@Pkinkmax,@Pkinkhmin,@Pkinkhmax,@Pkinkdmin,@Pkinkdmax,@Kimomin,@Kimomax,@Kimohmin,@Kimohmax,@Kimodmin,@Kimodmax,@ImoKinkmin,@ImoKinkmax,@Idarkmin,@Idarkmax,@Txidmin,@Txidmax,@Txidhmin,@Txidhmax,@Txiddmin,@Txiddmax,@qpomin,@qpomax,@qhpomin,@qhpomax,@PTλc,@PT方法,@APT_PT,@码型,@速率,@Sen,@通时间,@误码率,@Vbr34,@Vbrmin,@Vbrmax,@Vbrhmin,@Vbrhmax,@Vbrdmin,@Vbrdmax,@Iccmin,@Iccmax,@Icchmin,@Icchmax,@Iccdmin,@Iccdmax,@Iopmin,@IopminBFB,@Iopmax,@Iomin,@IominBFB,@Iomax,@Idmin,@Idmax,@Senmin,@Senmax,@SenmaxdB,@senhmin,@senhmax,@sendmin,@sendmax,@老化前min,@老化前minBFB,@老化前max,@老化前maxBFB,@前后对比min,@前后对比max,@上传时间,@审核时间,@备注)");
            SqlParameter[] parameters = {
					new SqlParameter("@规格书", SqlDbType.NVarChar,15),
					new SqlParameter("@产品型号", SqlDbType.NVarChar,25),
					new SqlParameter("@成品编码", SqlDbType.NVarChar,25),
					new SqlParameter("@客户代码", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλc", SqlDbType.NVarChar,8),
					new SqlParameter("@LD方法", SqlDbType.NVarChar,10),
					new SqlParameter("@Tc_d", SqlDbType.Float,8),
					new SqlParameter("@Tc_c", SqlDbType.Float,8),
					new SqlParameter("@Tc_h", SqlDbType.Float,8),
					new SqlParameter("@Po", SqlDbType.Float,8),
					new SqlParameter("@Pomin", SqlDbType.Float,8),
					new SqlParameter("@PominBFB", SqlDbType.Int,4),
					new SqlParameter("@Pomax", SqlDbType.Float,8),
					new SqlParameter("@PomaxBFB", SqlDbType.Int,4),
					new SqlParameter("@Pohmin", SqlDbType.Float,8),
					new SqlParameter("@Pohmax", SqlDbType.Float,8),
					new SqlParameter("@Podmin", SqlDbType.Float,8),
					new SqlParameter("@Podmax", SqlDbType.Float,8),
					new SqlParameter("@Ithmin", SqlDbType.Float,8),
					new SqlParameter("@Ithmax", SqlDbType.Float,8),
					new SqlParameter("@Ithhmin", SqlDbType.Float,8),
					new SqlParameter("@Ithhmax", SqlDbType.Float,8),
					new SqlParameter("@Ithdmin", SqlDbType.Float,8),
					new SqlParameter("@Ithdmax", SqlDbType.Float,8),
					new SqlParameter("@Ifmin", SqlDbType.Float,8),
					new SqlParameter("@Ifmax", SqlDbType.Float,8),
					new SqlParameter("@Ifhmin", SqlDbType.Float,8),
					new SqlParameter("@Ifhmax", SqlDbType.Float,8),
					new SqlParameter("@Ifdmin", SqlDbType.Float,8),
					new SqlParameter("@Ifdmax", SqlDbType.Float,8),
					new SqlParameter("@Ifc", SqlDbType.Float,8),
					new SqlParameter("@Ifh", SqlDbType.Float,8),
					new SqlParameter("@Ifd", SqlDbType.Float,8),
					new SqlParameter("@Vfmin", SqlDbType.Float,8),
					new SqlParameter("@Vfmax", SqlDbType.Float,8),
					new SqlParameter("@Vfhmin", SqlDbType.Float,8),
					new SqlParameter("@Vfhmax", SqlDbType.Float,8),
					new SqlParameter("@Vfdmax", SqlDbType.Float,8),
					new SqlParameter("@Vfdmin", SqlDbType.Float,8),
					new SqlParameter("@Imomin", SqlDbType.Int,4),
					new SqlParameter("@ImominBFB", SqlDbType.Int,4),
					new SqlParameter("@Imomax", SqlDbType.Int,4),
					new SqlParameter("@ImomaxBFB", SqlDbType.Int,4),
					new SqlParameter("@Imohmin", SqlDbType.Int,4),
					new SqlParameter("@Imohmax", SqlDbType.Int,4),
					new SqlParameter("@Imodmin", SqlDbType.Int,4),
					new SqlParameter("@Imodmax", SqlDbType.Int,4),
					new SqlParameter("@Esmin", SqlDbType.Float,8),
					new SqlParameter("@EsminBFB", SqlDbType.Int,4),
					new SqlParameter("@Esmax", SqlDbType.Float,8),
					new SqlParameter("@EsmaxBFB", SqlDbType.Int,4),
					new SqlParameter("@Eshmin", SqlDbType.Float,8),
					new SqlParameter("@Eshmax", SqlDbType.Float,8),
					new SqlParameter("@Esdmin", SqlDbType.Float,8),
					new SqlParameter("@Esdmax", SqlDbType.Float,8),
					new SqlParameter("@Rsmin", SqlDbType.Float,8),
					new SqlParameter("@Rsmax", SqlDbType.Float,8),
					new SqlParameter("@Rshmin", SqlDbType.Float,8),
					new SqlParameter("@Rshmax", SqlDbType.Float,8),
					new SqlParameter("@Rsdmin", SqlDbType.Float,8),
					new SqlParameter("@Rsdmax", SqlDbType.Float,8),
					new SqlParameter("@TEdmin", SqlDbType.Float,8),
					new SqlParameter("@TEdmax", SqlDbType.Float,8),
					new SqlParameter("@TEhmin", SqlDbType.Float,8),
					new SqlParameter("@TEhmax", SqlDbType.Float,8),
					new SqlParameter("@LDλcmin", SqlDbType.Float,8),
					new SqlParameter("@LDλcmax", SqlDbType.Float,8),
					new SqlParameter("@LDλchmin", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλchmax", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλcdmin", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλcdmax", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλmin", SqlDbType.Float,8),
					new SqlParameter("@LDλmax", SqlDbType.Float,8),
					new SqlParameter("@LDλhmin", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλhmax", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλdmin", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλdmax", SqlDbType.NVarChar,8),
					new SqlParameter("@Srmsmin", SqlDbType.Float,8),
					new SqlParameter("@Srmsmax", SqlDbType.Float,8),
					new SqlParameter("@Srmshmin", SqlDbType.NVarChar,8),
					new SqlParameter("@Srmshmax", SqlDbType.NVarChar,8),
					new SqlParameter("@Srmsdmin", SqlDbType.NVarChar,8),
					new SqlParameter("@Srmsdmax", SqlDbType.NVarChar,8),
					new SqlParameter("@Pkinkmin", SqlDbType.Int,4),
					new SqlParameter("@Pkinkmax", SqlDbType.Int,4),
					new SqlParameter("@Pkinkhmin", SqlDbType.Int,4),
					new SqlParameter("@Pkinkhmax", SqlDbType.Int,4),
					new SqlParameter("@Pkinkdmin", SqlDbType.Int,4),
					new SqlParameter("@Pkinkdmax", SqlDbType.Int,4),
					new SqlParameter("@Kimomin", SqlDbType.Int,4),
					new SqlParameter("@Kimomax", SqlDbType.Int,4),
					new SqlParameter("@Kimohmin", SqlDbType.Int,4),
					new SqlParameter("@Kimohmax", SqlDbType.Int,4),
					new SqlParameter("@Kimodmin", SqlDbType.Int,4),
					new SqlParameter("@Kimodmax", SqlDbType.Int,4),
					new SqlParameter("@ImoKinkmin", SqlDbType.Int,4),
					new SqlParameter("@ImoKinkmax", SqlDbType.Int,4),
					new SqlParameter("@Idarkmin", SqlDbType.Int,4),
					new SqlParameter("@Idarkmax", SqlDbType.Int,4),
					new SqlParameter("@Txidmin", SqlDbType.Int,4),
					new SqlParameter("@Txidmax", SqlDbType.Int,4),
					new SqlParameter("@Txidhmin", SqlDbType.Float,8),
					new SqlParameter("@Txidhmax", SqlDbType.Float,8),
					new SqlParameter("@Txiddmin", SqlDbType.Float,8),
					new SqlParameter("@Txiddmax", SqlDbType.Float,8),
					new SqlParameter("@qpomin", SqlDbType.Float,8),
					new SqlParameter("@qpomax", SqlDbType.Float,8),
					new SqlParameter("@qhpomin", SqlDbType.Float,8),
					new SqlParameter("@qhpomax", SqlDbType.Float,8),
					new SqlParameter("@PTλc", SqlDbType.NVarChar,10),
					new SqlParameter("@PT方法", SqlDbType.NVarChar,15),
					new SqlParameter("@APT_PT", SqlDbType.NVarChar,10),
					new SqlParameter("@码型", SqlDbType.NVarChar,10),
					new SqlParameter("@速率", SqlDbType.NVarChar,10),
					new SqlParameter("@Sen", SqlDbType.Float,8),
					new SqlParameter("@通时间", SqlDbType.Int,4),
					new SqlParameter("@误码率", SqlDbType.NVarChar,15),
					new SqlParameter("@Vbr34", SqlDbType.NVarChar,15),
					new SqlParameter("@Vbrmin", SqlDbType.Float,8),
					new SqlParameter("@Vbrmax", SqlDbType.Float,8),
					new SqlParameter("@Vbrhmin", SqlDbType.Float,8),
					new SqlParameter("@Vbrhmax", SqlDbType.Float,8),
					new SqlParameter("@Vbrdmin", SqlDbType.Float,8),
					new SqlParameter("@Vbrdmax", SqlDbType.Float,8),
					new SqlParameter("@Iccmin", SqlDbType.Float,8),
					new SqlParameter("@Iccmax", SqlDbType.Float,8),
					new SqlParameter("@Icchmin", SqlDbType.Float,8),
					new SqlParameter("@Icchmax", SqlDbType.Float,8),
					new SqlParameter("@Iccdmin", SqlDbType.Float,8),
					new SqlParameter("@Iccdmax", SqlDbType.Float,8),
					new SqlParameter("@Iopmin", SqlDbType.Float,8),
					new SqlParameter("@IopminBFB", SqlDbType.Int,4),
					new SqlParameter("@Iopmax", SqlDbType.Float,8),
					new SqlParameter("@Iomin", SqlDbType.Float,8),
					new SqlParameter("@IominBFB", SqlDbType.Int,4),
					new SqlParameter("@Iomax", SqlDbType.Float,8),
					new SqlParameter("@Idmin", SqlDbType.Float,8),
					new SqlParameter("@Idmax", SqlDbType.Float,8),
					new SqlParameter("@Senmin", SqlDbType.Float,8),
					new SqlParameter("@Senmax", SqlDbType.Float,8),
					new SqlParameter("@SenmaxdB", SqlDbType.Float,8),
					new SqlParameter("@senhmin", SqlDbType.Float,8),
					new SqlParameter("@senhmax", SqlDbType.Float,8),
					new SqlParameter("@sendmin", SqlDbType.Float,8),
					new SqlParameter("@sendmax", SqlDbType.Float,8),
					new SqlParameter("@老化前min", SqlDbType.Float,8),
					new SqlParameter("@老化前minBFB", SqlDbType.Int,4),
					new SqlParameter("@老化前max", SqlDbType.Float,8),
					new SqlParameter("@老化前maxBFB", SqlDbType.Int,4),
					new SqlParameter("@前后对比min", SqlDbType.Float,8),
					new SqlParameter("@前后对比max", SqlDbType.Float,8),
					new SqlParameter("@上传时间", SqlDbType.DateTime),
					new SqlParameter("@审核时间", SqlDbType.DateTime),
					new SqlParameter("@备注", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.规格书;
            parameters[1].Value = model.产品型号;
            parameters[2].Value = model.成品编码;
            parameters[3].Value = model.客户代码;
            parameters[4].Value = model.LDλc;
            parameters[5].Value = model.LD方法;
            parameters[6].Value = model.Tc_d;
            parameters[7].Value = model.Tc_c;
            parameters[8].Value = model.Tc_h;
            parameters[9].Value = model.Po;
            parameters[10].Value = model.Pomin;
            parameters[11].Value = model.PominBFB;
            parameters[12].Value = model.Pomax;
            parameters[13].Value = model.PomaxBFB;
            parameters[14].Value = model.Pohmin;
            parameters[15].Value = model.Pohmax;
            parameters[16].Value = model.Podmin;
            parameters[17].Value = model.Podmax;
            parameters[18].Value = model.Ithmin;
            parameters[19].Value = model.Ithmax;
            parameters[20].Value = model.Ithhmin;
            parameters[21].Value = model.Ithhmax;
            parameters[22].Value = model.Ithdmin;
            parameters[23].Value = model.Ithdmax;
            parameters[24].Value = model.Ifmin;
            parameters[25].Value = model.Ifmax;
            parameters[26].Value = model.Ifhmin;
            parameters[27].Value = model.Ifhmax;
            parameters[28].Value = model.Ifdmin;
            parameters[29].Value = model.Ifdmax;
            parameters[30].Value = model.Ifc;
            parameters[31].Value = model.Ifh;
            parameters[32].Value = model.Ifd;
            parameters[33].Value = model.Vfmin;
            parameters[34].Value = model.Vfmax;
            parameters[35].Value = model.Vfhmin;
            parameters[36].Value = model.Vfhmax;
            parameters[37].Value = model.Vfdmax;
            parameters[38].Value = model.Vfdmin;
            parameters[39].Value = model.Imomin;
            parameters[40].Value = model.ImominBFB;
            parameters[41].Value = model.Imomax;
            parameters[42].Value = model.ImomaxBFB;
            parameters[43].Value = model.Imohmin;
            parameters[44].Value = model.Imohmax;
            parameters[45].Value = model.Imodmin;
            parameters[46].Value = model.Imodmax;
            parameters[47].Value = model.Esmin;
            parameters[48].Value = model.EsminBFB;
            parameters[49].Value = model.Esmax;
            parameters[50].Value = model.EsmaxBFB;
            parameters[51].Value = model.Eshmin;
            parameters[52].Value = model.Eshmax;
            parameters[53].Value = model.Esdmin;
            parameters[54].Value = model.Esdmax;
            parameters[55].Value = model.Rsmin;
            parameters[56].Value = model.Rsmax;
            parameters[57].Value = model.Rshmin;
            parameters[58].Value = model.Rshmax;
            parameters[59].Value = model.Rsdmin;
            parameters[60].Value = model.Rsdmax;
            parameters[61].Value = model.TEdmin;
            parameters[62].Value = model.TEdmax;
            parameters[63].Value = model.TEhmin;
            parameters[64].Value = model.TEhmax;
            parameters[65].Value = model.LDλcmin;
            parameters[66].Value = model.LDλcmax;
            parameters[67].Value = model.LDλchmin;
            parameters[68].Value = model.LDλchmax;
            parameters[69].Value = model.LDλcdmin;
            parameters[70].Value = model.LDλcdmax;
            parameters[71].Value = model.LDλmin;
            parameters[72].Value = model.LDλmax;
            parameters[73].Value = model.LDλhmin;
            parameters[74].Value = model.LDλhmax;
            parameters[75].Value = model.LDλdmin;
            parameters[76].Value = model.LDλdmax;
            parameters[77].Value = model.Srmsmin;
            parameters[78].Value = model.Srmsmax;
            parameters[79].Value = model.Srmshmin;
            parameters[80].Value = model.Srmshmax;
            parameters[81].Value = model.Srmsdmin;
            parameters[82].Value = model.Srmsdmax;
            parameters[83].Value = model.Pkinkmin;
            parameters[84].Value = model.Pkinkmax;
            parameters[85].Value = model.Pkinkhmin;
            parameters[86].Value = model.Pkinkhmax;
            parameters[87].Value = model.Pkinkdmin;
            parameters[88].Value = model.Pkinkdmax;
            parameters[89].Value = model.Kimomin;
            parameters[90].Value = model.Kimomax;
            parameters[91].Value = model.Kimohmin;
            parameters[92].Value = model.Kimohmax;
            parameters[93].Value = model.Kimodmin;
            parameters[94].Value = model.Kimodmax;
            parameters[95].Value = model.ImoKinkmin;
            parameters[96].Value = model.ImoKinkmax;
            parameters[97].Value = model.Idarkmin;
            parameters[98].Value = model.Idarkmax;
            parameters[99].Value = model.Txidmin;
            parameters[100].Value = model.Txidmax;
            parameters[101].Value = model.Txidhmin;
            parameters[102].Value = model.Txidhmax;
            parameters[103].Value = model.Txiddmin;
            parameters[104].Value = model.Txiddmax;
            parameters[105].Value = model.qpomin;
            parameters[106].Value = model.qpomax;
            parameters[107].Value = model.qhpomin;
            parameters[108].Value = model.qhpomax;
            parameters[109].Value = model.PTλc;
            parameters[110].Value = model.PT方法;
            parameters[111].Value = model.APT_PT;
            parameters[112].Value = model.码型;
            parameters[113].Value = model.速率;
            parameters[114].Value = model.Sen;
            parameters[115].Value = model.通时间;
            parameters[116].Value = model.误码率;
            parameters[117].Value = model.Vbr34;
            parameters[118].Value = model.Vbrmin;
            parameters[119].Value = model.Vbrmax;
            parameters[120].Value = model.Vbrhmin;
            parameters[121].Value = model.Vbrhmax;
            parameters[122].Value = model.Vbrdmin;
            parameters[123].Value = model.Vbrdmax;
            parameters[124].Value = model.Iccmin;
            parameters[125].Value = model.Iccmax;
            parameters[126].Value = model.Icchmin;
            parameters[127].Value = model.Icchmax;
            parameters[128].Value = model.Iccdmin;
            parameters[129].Value = model.Iccdmax;
            parameters[130].Value = model.Iopmin;
            parameters[131].Value = model.IopminBFB;
            parameters[132].Value = model.Iopmax;
            parameters[133].Value = model.Iomin;
            parameters[134].Value = model.IominBFB;
            parameters[135].Value = model.Iomax;
            parameters[136].Value = model.Idmin;
            parameters[137].Value = model.Idmax;
            parameters[138].Value = model.Senmin;
            parameters[139].Value = model.Senmax;
            parameters[140].Value = model.SenmaxdB;
            parameters[141].Value = model.senhmin;
            parameters[142].Value = model.senhmax;
            parameters[143].Value = model.sendmin;
            parameters[144].Value = model.sendmax;
            parameters[145].Value = model.老化前min;
            parameters[146].Value = model.老化前minBFB;
            parameters[147].Value = model.老化前max;
            parameters[148].Value = model.老化前maxBFB;
            parameters[149].Value = model.前后对比min;
            parameters[150].Value = model.前后对比max;
            parameters[151].Value = model.上传时间;
            parameters[152].Value = model.审核时间;
            parameters[153].Value = model.备注;

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
        public bool Update(tsuhan_spec model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsuhan_spec set ");
            strSql.Append("产品型号=@产品型号,");
            strSql.Append("成品编码=@成品编码,");
            strSql.Append("客户代码=@客户代码,");
            strSql.Append("LDλc=@LDλc,");
            strSql.Append("LD方法=@LD方法,");
            strSql.Append("Tc_d=@Tc_d,");
            strSql.Append("Tc_c=@Tc_c,");
            strSql.Append("Tc_h=@Tc_h,");
            strSql.Append("Po=@Po,");
            strSql.Append("Pomin=@Pomin,");
            strSql.Append("PominBFB=@PominBFB,");
            strSql.Append("Pomax=@Pomax,");
            strSql.Append("PomaxBFB=@PomaxBFB,");
            strSql.Append("Pohmin=@Pohmin,");
            strSql.Append("Pohmax=@Pohmax,");
            strSql.Append("Podmin=@Podmin,");
            strSql.Append("Podmax=@Podmax,");
            strSql.Append("Ithmin=@Ithmin,");
            strSql.Append("Ithmax=@Ithmax,");
            strSql.Append("Ithhmin=@Ithhmin,");
            strSql.Append("Ithhmax=@Ithhmax,");
            strSql.Append("Ithdmin=@Ithdmin,");
            strSql.Append("Ithdmax=@Ithdmax,");
            strSql.Append("Ifmin=@Ifmin,");
            strSql.Append("Ifmax=@Ifmax,");
            strSql.Append("Ifhmin=@Ifhmin,");
            strSql.Append("Ifhmax=@Ifhmax,");
            strSql.Append("Ifdmin=@Ifdmin,");
            strSql.Append("Ifdmax=@Ifdmax,");
            strSql.Append("Ifc=@Ifc,");
            strSql.Append("Ifh=@Ifh,");
            strSql.Append("Ifd=@Ifd,");
            strSql.Append("Vfmin=@Vfmin,");
            strSql.Append("Vfmax=@Vfmax,");
            strSql.Append("Vfhmin=@Vfhmin,");
            strSql.Append("Vfhmax=@Vfhmax,");
            strSql.Append("Vfdmax=@Vfdmax,");
            strSql.Append("Vfdmin=@Vfdmin,");
            strSql.Append("Imomin=@Imomin,");
            strSql.Append("ImominBFB=@ImominBFB,");
            strSql.Append("Imomax=@Imomax,");
            strSql.Append("ImomaxBFB=@ImomaxBFB,");
            strSql.Append("Imohmin=@Imohmin,");
            strSql.Append("Imohmax=@Imohmax,");
            strSql.Append("Imodmin=@Imodmin,");
            strSql.Append("Imodmax=@Imodmax,");
            strSql.Append("Esmin=@Esmin,");
            strSql.Append("EsminBFB=@EsminBFB,");
            strSql.Append("Esmax=@Esmax,");
            strSql.Append("EsmaxBFB=@EsmaxBFB,");
            strSql.Append("Eshmin=@Eshmin,");
            strSql.Append("Eshmax=@Eshmax,");
            strSql.Append("Esdmin=@Esdmin,");
            strSql.Append("Esdmax=@Esdmax,");
            strSql.Append("Rsmin=@Rsmin,");
            strSql.Append("Rsmax=@Rsmax,");
            strSql.Append("Rshmin=@Rshmin,");
            strSql.Append("Rshmax=@Rshmax,");
            strSql.Append("Rsdmin=@Rsdmin,");
            strSql.Append("Rsdmax=@Rsdmax,");
            strSql.Append("TEdmin=@TEdmin,");
            strSql.Append("TEdmax=@TEdmax,");
            strSql.Append("TEhmin=@TEhmin,");
            strSql.Append("TEhmax=@TEhmax,");
            strSql.Append("LDλcmin=@LDλcmin,");
            strSql.Append("LDλcmax=@LDλcmax,");
            strSql.Append("LDλchmin=@LDλchmin,");
            strSql.Append("LDλchmax=@LDλchmax,");
            strSql.Append("LDλcdmin=@LDλcdmin,");
            strSql.Append("LDλcdmax=@LDλcdmax,");
            strSql.Append("LDλmin=@LDλmin,");
            strSql.Append("LDλmax=@LDλmax,");
            strSql.Append("LDλhmin=@LDλhmin,");
            strSql.Append("LDλhmax=@LDλhmax,");
            strSql.Append("LDλdmin=@LDλdmin,");
            strSql.Append("LDλdmax=@LDλdmax,");
            strSql.Append("Srmsmin=@Srmsmin,");
            strSql.Append("Srmsmax=@Srmsmax,");
            strSql.Append("Srmshmin=@Srmshmin,");
            strSql.Append("Srmshmax=@Srmshmax,");
            strSql.Append("Srmsdmin=@Srmsdmin,");
            strSql.Append("Srmsdmax=@Srmsdmax,");
            strSql.Append("Pkinkmin=@Pkinkmin,");
            strSql.Append("Pkinkmax=@Pkinkmax,");
            strSql.Append("Pkinkhmin=@Pkinkhmin,");
            strSql.Append("Pkinkhmax=@Pkinkhmax,");
            strSql.Append("Pkinkdmin=@Pkinkdmin,");
            strSql.Append("Pkinkdmax=@Pkinkdmax,");
            strSql.Append("Kimomin=@Kimomin,");
            strSql.Append("Kimomax=@Kimomax,");
            strSql.Append("Kimohmin=@Kimohmin,");
            strSql.Append("Kimohmax=@Kimohmax,");
            strSql.Append("Kimodmin=@Kimodmin,");
            strSql.Append("Kimodmax=@Kimodmax,");
            strSql.Append("ImoKinkmin=@ImoKinkmin,");
            strSql.Append("ImoKinkmax=@ImoKinkmax,");
            strSql.Append("Idarkmin=@Idarkmin,");
            strSql.Append("Idarkmax=@Idarkmax,");
            strSql.Append("Txidmin=@Txidmin,");
            strSql.Append("Txidmax=@Txidmax,");
            strSql.Append("Txidhmin=@Txidhmin,");
            strSql.Append("Txidhmax=@Txidhmax,");
            strSql.Append("Txiddmin=@Txiddmin,");
            strSql.Append("Txiddmax=@Txiddmax,");
            strSql.Append("qpomin=@qpomin,");
            strSql.Append("qpomax=@qpomax,");
            strSql.Append("qhpomin=@qhpomin,");
            strSql.Append("qhpomax=@qhpomax,");
            strSql.Append("PTλc=@PTλc,");
            strSql.Append("PT方法=@PT方法,");
            strSql.Append("APT_PT=@APT_PT,");
            strSql.Append("码型=@码型,");
            strSql.Append("速率=@速率,");
            strSql.Append("Sen=@Sen,");
            strSql.Append("通时间=@通时间,");
            strSql.Append("误码率=@误码率,");
            strSql.Append("Vbr34=@Vbr34,");
            strSql.Append("Vbrmin=@Vbrmin,");
            strSql.Append("Vbrmax=@Vbrmax,");
            strSql.Append("Vbrhmin=@Vbrhmin,");
            strSql.Append("Vbrhmax=@Vbrhmax,");
            strSql.Append("Vbrdmin=@Vbrdmin,");
            strSql.Append("Vbrdmax=@Vbrdmax,");
            strSql.Append("Iccmin=@Iccmin,");
            strSql.Append("Iccmax=@Iccmax,");
            strSql.Append("Icchmin=@Icchmin,");
            strSql.Append("Icchmax=@Icchmax,");
            strSql.Append("Iccdmin=@Iccdmin,");
            strSql.Append("Iccdmax=@Iccdmax,");
            strSql.Append("Iopmin=@Iopmin,");
            strSql.Append("IopminBFB=@IopminBFB,");
            strSql.Append("Iopmax=@Iopmax,");
            strSql.Append("Iomin=@Iomin,");
            strSql.Append("IominBFB=@IominBFB,");
            strSql.Append("Iomax=@Iomax,");
            strSql.Append("Idmin=@Idmin,");
            strSql.Append("Idmax=@Idmax,");
            strSql.Append("Senmin=@Senmin,");
            strSql.Append("Senmax=@Senmax,");
            strSql.Append("SenmaxdB=@SenmaxdB,");
            strSql.Append("senhmin=@senhmin,");
            strSql.Append("senhmax=@senhmax,");
            strSql.Append("sendmin=@sendmin,");
            strSql.Append("sendmax=@sendmax,");
            strSql.Append("老化前min=@老化前min,");
            strSql.Append("老化前minBFB=@老化前minBFB,");
            strSql.Append("老化前max=@老化前max,");
            strSql.Append("老化前maxBFB=@老化前maxBFB,");
            strSql.Append("前后对比min=@前后对比min,");
            strSql.Append("前后对比max=@前后对比max,");
            strSql.Append("上传时间=@上传时间,");
            strSql.Append("审核时间=@审核时间,");
            strSql.Append("备注=@备注");
            strSql.Append(" where 规格书=@规格书 ");
            SqlParameter[] parameters = {
					new SqlParameter("@产品型号", SqlDbType.NVarChar,25),
					new SqlParameter("@成品编码", SqlDbType.NVarChar,25),
					new SqlParameter("@客户代码", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλc", SqlDbType.NVarChar,8),
					new SqlParameter("@LD方法", SqlDbType.NVarChar,10),
					new SqlParameter("@Tc_d", SqlDbType.Float,8),
					new SqlParameter("@Tc_c", SqlDbType.Float,8),
					new SqlParameter("@Tc_h", SqlDbType.Float,8),
					new SqlParameter("@Po", SqlDbType.Float,8),
					new SqlParameter("@Pomin", SqlDbType.Float,8),
					new SqlParameter("@PominBFB", SqlDbType.Int,4),
					new SqlParameter("@Pomax", SqlDbType.Float,8),
					new SqlParameter("@PomaxBFB", SqlDbType.Int,4),
					new SqlParameter("@Pohmin", SqlDbType.Float,8),
					new SqlParameter("@Pohmax", SqlDbType.Float,8),
					new SqlParameter("@Podmin", SqlDbType.Float,8),
					new SqlParameter("@Podmax", SqlDbType.Float,8),
					new SqlParameter("@Ithmin", SqlDbType.Float,8),
					new SqlParameter("@Ithmax", SqlDbType.Float,8),
					new SqlParameter("@Ithhmin", SqlDbType.Float,8),
					new SqlParameter("@Ithhmax", SqlDbType.Float,8),
					new SqlParameter("@Ithdmin", SqlDbType.Float,8),
					new SqlParameter("@Ithdmax", SqlDbType.Float,8),
					new SqlParameter("@Ifmin", SqlDbType.Float,8),
					new SqlParameter("@Ifmax", SqlDbType.Float,8),
					new SqlParameter("@Ifhmin", SqlDbType.Float,8),
					new SqlParameter("@Ifhmax", SqlDbType.Float,8),
					new SqlParameter("@Ifdmin", SqlDbType.Float,8),
					new SqlParameter("@Ifdmax", SqlDbType.Float,8),
					new SqlParameter("@Ifc", SqlDbType.Float,8),
					new SqlParameter("@Ifh", SqlDbType.Float,8),
					new SqlParameter("@Ifd", SqlDbType.Float,8),
					new SqlParameter("@Vfmin", SqlDbType.Float,8),
					new SqlParameter("@Vfmax", SqlDbType.Float,8),
					new SqlParameter("@Vfhmin", SqlDbType.Float,8),
					new SqlParameter("@Vfhmax", SqlDbType.Float,8),
					new SqlParameter("@Vfdmax", SqlDbType.Float,8),
					new SqlParameter("@Vfdmin", SqlDbType.Float,8),
					new SqlParameter("@Imomin", SqlDbType.Int,4),
					new SqlParameter("@ImominBFB", SqlDbType.Int,4),
					new SqlParameter("@Imomax", SqlDbType.Int,4),
					new SqlParameter("@ImomaxBFB", SqlDbType.Int,4),
					new SqlParameter("@Imohmin", SqlDbType.Int,4),
					new SqlParameter("@Imohmax", SqlDbType.Int,4),
					new SqlParameter("@Imodmin", SqlDbType.Int,4),
					new SqlParameter("@Imodmax", SqlDbType.Int,4),
					new SqlParameter("@Esmin", SqlDbType.Float,8),
					new SqlParameter("@EsminBFB", SqlDbType.Int,4),
					new SqlParameter("@Esmax", SqlDbType.Float,8),
					new SqlParameter("@EsmaxBFB", SqlDbType.Int,4),
					new SqlParameter("@Eshmin", SqlDbType.Float,8),
					new SqlParameter("@Eshmax", SqlDbType.Float,8),
					new SqlParameter("@Esdmin", SqlDbType.Float,8),
					new SqlParameter("@Esdmax", SqlDbType.Float,8),
					new SqlParameter("@Rsmin", SqlDbType.Float,8),
					new SqlParameter("@Rsmax", SqlDbType.Float,8),
					new SqlParameter("@Rshmin", SqlDbType.Float,8),
					new SqlParameter("@Rshmax", SqlDbType.Float,8),
					new SqlParameter("@Rsdmin", SqlDbType.Float,8),
					new SqlParameter("@Rsdmax", SqlDbType.Float,8),
					new SqlParameter("@TEdmin", SqlDbType.Float,8),
					new SqlParameter("@TEdmax", SqlDbType.Float,8),
					new SqlParameter("@TEhmin", SqlDbType.Float,8),
					new SqlParameter("@TEhmax", SqlDbType.Float,8),
					new SqlParameter("@LDλcmin", SqlDbType.Float,8),
					new SqlParameter("@LDλcmax", SqlDbType.Float,8),
					new SqlParameter("@LDλchmin", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλchmax", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλcdmin", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλcdmax", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλmin", SqlDbType.Float,8),
					new SqlParameter("@LDλmax", SqlDbType.Float,8),
					new SqlParameter("@LDλhmin", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλhmax", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλdmin", SqlDbType.NVarChar,8),
					new SqlParameter("@LDλdmax", SqlDbType.NVarChar,8),
					new SqlParameter("@Srmsmin", SqlDbType.Float,8),
					new SqlParameter("@Srmsmax", SqlDbType.Float,8),
					new SqlParameter("@Srmshmin", SqlDbType.NVarChar,8),
					new SqlParameter("@Srmshmax", SqlDbType.NVarChar,8),
					new SqlParameter("@Srmsdmin", SqlDbType.NVarChar,8),
					new SqlParameter("@Srmsdmax", SqlDbType.NVarChar,8),
					new SqlParameter("@Pkinkmin", SqlDbType.Int,4),
					new SqlParameter("@Pkinkmax", SqlDbType.Int,4),
					new SqlParameter("@Pkinkhmin", SqlDbType.Int,4),
					new SqlParameter("@Pkinkhmax", SqlDbType.Int,4),
					new SqlParameter("@Pkinkdmin", SqlDbType.Int,4),
					new SqlParameter("@Pkinkdmax", SqlDbType.Int,4),
					new SqlParameter("@Kimomin", SqlDbType.Int,4),
					new SqlParameter("@Kimomax", SqlDbType.Int,4),
					new SqlParameter("@Kimohmin", SqlDbType.Int,4),
					new SqlParameter("@Kimohmax", SqlDbType.Int,4),
					new SqlParameter("@Kimodmin", SqlDbType.Int,4),
					new SqlParameter("@Kimodmax", SqlDbType.Int,4),
					new SqlParameter("@ImoKinkmin", SqlDbType.Int,4),
					new SqlParameter("@ImoKinkmax", SqlDbType.Int,4),
					new SqlParameter("@Idarkmin", SqlDbType.Int,4),
					new SqlParameter("@Idarkmax", SqlDbType.Int,4),
					new SqlParameter("@Txidmin", SqlDbType.Int,4),
					new SqlParameter("@Txidmax", SqlDbType.Int,4),
					new SqlParameter("@Txidhmin", SqlDbType.Float,8),
					new SqlParameter("@Txidhmax", SqlDbType.Float,8),
					new SqlParameter("@Txiddmin", SqlDbType.Float,8),
					new SqlParameter("@Txiddmax", SqlDbType.Float,8),
					new SqlParameter("@qpomin", SqlDbType.Float,8),
					new SqlParameter("@qpomax", SqlDbType.Float,8),
					new SqlParameter("@qhpomin", SqlDbType.Float,8),
					new SqlParameter("@qhpomax", SqlDbType.Float,8),
					new SqlParameter("@PTλc", SqlDbType.NVarChar,10),
					new SqlParameter("@PT方法", SqlDbType.NVarChar,15),
					new SqlParameter("@APT_PT", SqlDbType.NVarChar,10),
					new SqlParameter("@码型", SqlDbType.NVarChar,10),
					new SqlParameter("@速率", SqlDbType.NVarChar,10),
					new SqlParameter("@Sen", SqlDbType.Float,8),
					new SqlParameter("@通时间", SqlDbType.Int,4),
					new SqlParameter("@误码率", SqlDbType.NVarChar,15),
					new SqlParameter("@Vbr34", SqlDbType.NVarChar,15),
					new SqlParameter("@Vbrmin", SqlDbType.Float,8),
					new SqlParameter("@Vbrmax", SqlDbType.Float,8),
					new SqlParameter("@Vbrhmin", SqlDbType.Float,8),
					new SqlParameter("@Vbrhmax", SqlDbType.Float,8),
					new SqlParameter("@Vbrdmin", SqlDbType.Float,8),
					new SqlParameter("@Vbrdmax", SqlDbType.Float,8),
					new SqlParameter("@Iccmin", SqlDbType.Float,8),
					new SqlParameter("@Iccmax", SqlDbType.Float,8),
					new SqlParameter("@Icchmin", SqlDbType.Float,8),
					new SqlParameter("@Icchmax", SqlDbType.Float,8),
					new SqlParameter("@Iccdmin", SqlDbType.Float,8),
					new SqlParameter("@Iccdmax", SqlDbType.Float,8),
					new SqlParameter("@Iopmin", SqlDbType.Float,8),
					new SqlParameter("@IopminBFB", SqlDbType.Int,4),
					new SqlParameter("@Iopmax", SqlDbType.Float,8),
					new SqlParameter("@Iomin", SqlDbType.Float,8),
					new SqlParameter("@IominBFB", SqlDbType.Int,4),
					new SqlParameter("@Iomax", SqlDbType.Float,8),
					new SqlParameter("@Idmin", SqlDbType.Float,8),
					new SqlParameter("@Idmax", SqlDbType.Float,8),
					new SqlParameter("@Senmin", SqlDbType.Float,8),
					new SqlParameter("@Senmax", SqlDbType.Float,8),
					new SqlParameter("@SenmaxdB", SqlDbType.Float,8),
					new SqlParameter("@senhmin", SqlDbType.Float,8),
					new SqlParameter("@senhmax", SqlDbType.Float,8),
					new SqlParameter("@sendmin", SqlDbType.Float,8),
					new SqlParameter("@sendmax", SqlDbType.Float,8),
					new SqlParameter("@老化前min", SqlDbType.Float,8),
					new SqlParameter("@老化前minBFB", SqlDbType.Int,4),
					new SqlParameter("@老化前max", SqlDbType.Float,8),
					new SqlParameter("@老化前maxBFB", SqlDbType.Int,4),
					new SqlParameter("@前后对比min", SqlDbType.Float,8),
					new SqlParameter("@前后对比max", SqlDbType.Float,8),
					new SqlParameter("@上传时间", SqlDbType.DateTime),
					new SqlParameter("@审核时间", SqlDbType.DateTime),
					new SqlParameter("@备注", SqlDbType.NVarChar,50),
					new SqlParameter("@规格书", SqlDbType.NVarChar,15)};
            parameters[0].Value = model.产品型号;
            parameters[1].Value = model.成品编码;
            parameters[2].Value = model.客户代码;
            parameters[3].Value = model.LDλc;
            parameters[4].Value = model.LD方法;
            parameters[5].Value = model.Tc_d;
            parameters[6].Value = model.Tc_c;
            parameters[7].Value = model.Tc_h;
            parameters[8].Value = model.Po;
            parameters[9].Value = model.Pomin;
            parameters[10].Value = model.PominBFB;
            parameters[11].Value = model.Pomax;
            parameters[12].Value = model.PomaxBFB;
            parameters[13].Value = model.Pohmin;
            parameters[14].Value = model.Pohmax;
            parameters[15].Value = model.Podmin;
            parameters[16].Value = model.Podmax;
            parameters[17].Value = model.Ithmin;
            parameters[18].Value = model.Ithmax;
            parameters[19].Value = model.Ithhmin;
            parameters[20].Value = model.Ithhmax;
            parameters[21].Value = model.Ithdmin;
            parameters[22].Value = model.Ithdmax;
            parameters[23].Value = model.Ifmin;
            parameters[24].Value = model.Ifmax;
            parameters[25].Value = model.Ifhmin;
            parameters[26].Value = model.Ifhmax;
            parameters[27].Value = model.Ifdmin;
            parameters[28].Value = model.Ifdmax;
            parameters[29].Value = model.Ifc;
            parameters[30].Value = model.Ifh;
            parameters[31].Value = model.Ifd;
            parameters[32].Value = model.Vfmin;
            parameters[33].Value = model.Vfmax;
            parameters[34].Value = model.Vfhmin;
            parameters[35].Value = model.Vfhmax;
            parameters[36].Value = model.Vfdmax;
            parameters[37].Value = model.Vfdmin;
            parameters[38].Value = model.Imomin;
            parameters[39].Value = model.ImominBFB;
            parameters[40].Value = model.Imomax;
            parameters[41].Value = model.ImomaxBFB;
            parameters[42].Value = model.Imohmin;
            parameters[43].Value = model.Imohmax;
            parameters[44].Value = model.Imodmin;
            parameters[45].Value = model.Imodmax;
            parameters[46].Value = model.Esmin;
            parameters[47].Value = model.EsminBFB;
            parameters[48].Value = model.Esmax;
            parameters[49].Value = model.EsmaxBFB;
            parameters[50].Value = model.Eshmin;
            parameters[51].Value = model.Eshmax;
            parameters[52].Value = model.Esdmin;
            parameters[53].Value = model.Esdmax;
            parameters[54].Value = model.Rsmin;
            parameters[55].Value = model.Rsmax;
            parameters[56].Value = model.Rshmin;
            parameters[57].Value = model.Rshmax;
            parameters[58].Value = model.Rsdmin;
            parameters[59].Value = model.Rsdmax;
            parameters[60].Value = model.TEdmin;
            parameters[61].Value = model.TEdmax;
            parameters[62].Value = model.TEhmin;
            parameters[63].Value = model.TEhmax;
            parameters[64].Value = model.LDλcmin;
            parameters[65].Value = model.LDλcmax;
            parameters[66].Value = model.LDλchmin;
            parameters[67].Value = model.LDλchmax;
            parameters[68].Value = model.LDλcdmin;
            parameters[69].Value = model.LDλcdmax;
            parameters[70].Value = model.LDλmin;
            parameters[71].Value = model.LDλmax;
            parameters[72].Value = model.LDλhmin;
            parameters[73].Value = model.LDλhmax;
            parameters[74].Value = model.LDλdmin;
            parameters[75].Value = model.LDλdmax;
            parameters[76].Value = model.Srmsmin;
            parameters[77].Value = model.Srmsmax;
            parameters[78].Value = model.Srmshmin;
            parameters[79].Value = model.Srmshmax;
            parameters[80].Value = model.Srmsdmin;
            parameters[81].Value = model.Srmsdmax;
            parameters[82].Value = model.Pkinkmin;
            parameters[83].Value = model.Pkinkmax;
            parameters[84].Value = model.Pkinkhmin;
            parameters[85].Value = model.Pkinkhmax;
            parameters[86].Value = model.Pkinkdmin;
            parameters[87].Value = model.Pkinkdmax;
            parameters[88].Value = model.Kimomin;
            parameters[89].Value = model.Kimomax;
            parameters[90].Value = model.Kimohmin;
            parameters[91].Value = model.Kimohmax;
            parameters[92].Value = model.Kimodmin;
            parameters[93].Value = model.Kimodmax;
            parameters[94].Value = model.ImoKinkmin;
            parameters[95].Value = model.ImoKinkmax;
            parameters[96].Value = model.Idarkmin;
            parameters[97].Value = model.Idarkmax;
            parameters[98].Value = model.Txidmin;
            parameters[99].Value = model.Txidmax;
            parameters[100].Value = model.Txidhmin;
            parameters[101].Value = model.Txidhmax;
            parameters[102].Value = model.Txiddmin;
            parameters[103].Value = model.Txiddmax;
            parameters[104].Value = model.qpomin;
            parameters[105].Value = model.qpomax;
            parameters[106].Value = model.qhpomin;
            parameters[107].Value = model.qhpomax;
            parameters[108].Value = model.PTλc;
            parameters[109].Value = model.PT方法;
            parameters[110].Value = model.APT_PT;
            parameters[111].Value = model.码型;
            parameters[112].Value = model.速率;
            parameters[113].Value = model.Sen;
            parameters[114].Value = model.通时间;
            parameters[115].Value = model.误码率;
            parameters[116].Value = model.Vbr34;
            parameters[117].Value = model.Vbrmin;
            parameters[118].Value = model.Vbrmax;
            parameters[119].Value = model.Vbrhmin;
            parameters[120].Value = model.Vbrhmax;
            parameters[121].Value = model.Vbrdmin;
            parameters[122].Value = model.Vbrdmax;
            parameters[123].Value = model.Iccmin;
            parameters[124].Value = model.Iccmax;
            parameters[125].Value = model.Icchmin;
            parameters[126].Value = model.Icchmax;
            parameters[127].Value = model.Iccdmin;
            parameters[128].Value = model.Iccdmax;
            parameters[129].Value = model.Iopmin;
            parameters[130].Value = model.IopminBFB;
            parameters[131].Value = model.Iopmax;
            parameters[132].Value = model.Iomin;
            parameters[133].Value = model.IominBFB;
            parameters[134].Value = model.Iomax;
            parameters[135].Value = model.Idmin;
            parameters[136].Value = model.Idmax;
            parameters[137].Value = model.Senmin;
            parameters[138].Value = model.Senmax;
            parameters[139].Value = model.SenmaxdB;
            parameters[140].Value = model.senhmin;
            parameters[141].Value = model.senhmax;
            parameters[142].Value = model.sendmin;
            parameters[143].Value = model.sendmax;
            parameters[144].Value = model.老化前min;
            parameters[145].Value = model.老化前minBFB;
            parameters[146].Value = model.老化前max;
            parameters[147].Value = model.老化前maxBFB;
            parameters[148].Value = model.前后对比min;
            parameters[149].Value = model.前后对比max;
            parameters[150].Value = model.上传时间;
            parameters[151].Value = model.审核时间;
            parameters[152].Value = model.备注;
            parameters[153].Value = model.规格书;

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
        /// 根据规格书编号查询信息
        /// </summary>
        /// <param name="规格书"></param>
        /// <returns></returns>
        public tsuhan_spec GetModel(string 规格书)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 规格书,产品型号,成品编码,客户代码,LDλc,LD方法,Tc_d,Tc_c,Tc_h,Po,Pomin,PominBFB,Pomax,PomaxBFB,Pohmin,Pohmax,Podmin,Podmax,Ithmin,Ithmax,Ithhmin,Ithhmax,Ithdmin,Ithdmax,Ifmin,Ifmax,Ifhmin,Ifhmax,Ifdmin,Ifdmax,Ifc,Ifh,Ifd,Vfmin,Vfmax,Vfhmin,Vfhmax,Vfdmax,Vfdmin,Imomin,ImominBFB,Imomax,ImomaxBFB,Imohmin,Imohmax,Imodmin,Imodmax,Esmin,EsminBFB,Esmax,EsmaxBFB,Eshmin,Eshmax,Esdmin,Esdmax,Rsmin,Rsmax,Rshmin,Rshmax,Rsdmin,Rsdmax,TEdmin,TEdmax,TEhmin,TEhmax,LDλcmin,LDλcmax,LDλchmin,LDλchmax,LDλcdmin,LDλcdmax,LDλmin,LDλmax,LDλhmin,LDλhmax,LDλdmin,LDλdmax,Srmsmin,Srmsmax,Srmshmin,Srmshmax,Srmsdmin,Srmsdmax,Pkinkmin,Pkinkmax,Pkinkhmin,Pkinkhmax,Pkinkdmin,Pkinkdmax,Kimomin,Kimomax,Kimohmin,Kimohmax,Kimodmin,Kimodmax,ImoKinkmin,ImoKinkmax,Idarkmin,Idarkmax,Txidmin,Txidmax,Txidhmin,Txidhmax,Txiddmin,Txiddmax,qpomin,qpomax,qhpomin,qhpomax,PTλc,PT方法,APT_PT,码型,速率,Sen,通时间,误码率,Vbr34,Vbrmin,Vbrmax,Vbrhmin,Vbrhmax,Vbrdmin,Vbrdmax,Iccmin,Iccmax,Icchmin,Icchmax,Iccdmin,Iccdmax,Iopmin,IopminBFB,Iopmax,Iomin,IominBFB,Iomax,Idmin,Idmax,Senmin,Senmax,SenmaxdB,senhmin,senhmax,sendmin,sendmax,老化前min,老化前minBFB,老化前max,老化前maxBFB,前后对比min,前后对比max,上传时间,审核时间,备注 from tsuhan_spec ");
            strSql.Append(" where 规格书=@规格书 ");
            SqlParameter[] parameters = {
					new SqlParameter("@规格书", SqlDbType.NVarChar,15)			};
            parameters[0].Value = 规格书;

            Maticsoft.Model.tsuhan_spec model = new Maticsoft.Model.tsuhan_spec();
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
        public tsuhan_spec DataRowToModel(DataRow row)
        {
            tsuhan_spec model = new tsuhan_spec();
            if (row != null)
            {
                if (row["规格书"] != null)
                {
                    model.规格书 = row["规格书"].ToString();
                }
                if (row["产品型号"] != null)
                {
                    model.产品型号 = row["产品型号"].ToString();
                }
                if (row["成品编码"] != null)
                {
                    model.成品编码 = row["成品编码"].ToString();
                }
                if (row["客户代码"] != null)
                {
                    model.客户代码 = row["客户代码"].ToString();
                }
                if (row["LDλc"] != null)
                {
                    model.LDλc = row["LDλc"].ToString();
                }
                if (row["LD方法"] != null)
                {
                    model.LD方法 = row["LD方法"].ToString();
                }
                if (row["Tc_d"] != null && row["Tc_d"].ToString() != "")
                {
                    model.Tc_d = decimal.Parse(row["Tc_d"].ToString());
                }
                if (row["Tc_c"] != null && row["Tc_c"].ToString() != "")
                {
                    model.Tc_c = decimal.Parse(row["Tc_c"].ToString());
                }
                if (row["Tc_h"] != null && row["Tc_h"].ToString() != "")
                {
                    model.Tc_h = decimal.Parse(row["Tc_h"].ToString());
                }
                if (row["Po"] != null && row["Po"].ToString() != "")
                {
                    model.Po = decimal.Parse(row["Po"].ToString());
                }
                if (row["Pomin"] != null && row["Pomin"].ToString() != "")
                {
                    model.Pomin = decimal.Parse(row["Pomin"].ToString());
                }
                if (row["PominBFB"] != null && row["PominBFB"].ToString() != "")
                {
                    model.PominBFB = int.Parse(row["PominBFB"].ToString());
                }
                if (row["Pomax"] != null && row["Pomax"].ToString() != "")
                {
                    model.Pomax = decimal.Parse(row["Pomax"].ToString());
                }
                if (row["PomaxBFB"] != null && row["PomaxBFB"].ToString() != "")
                {
                    model.PomaxBFB = int.Parse(row["PomaxBFB"].ToString());
                }
                if (row["Pohmin"] != null && row["Pohmin"].ToString() != "")
                {
                    model.Pohmin = decimal.Parse(row["Pohmin"].ToString());
                }
                if (row["Pohmax"] != null && row["Pohmax"].ToString() != "")
                {
                    model.Pohmax = decimal.Parse(row["Pohmax"].ToString());
                }
                if (row["Podmin"] != null && row["Podmin"].ToString() != "")
                {
                    model.Podmin = decimal.Parse(row["Podmin"].ToString());
                }
                if (row["Podmax"] != null && row["Podmax"].ToString() != "")
                {
                    model.Podmax = decimal.Parse(row["Podmax"].ToString());
                }
                if (row["Ithmin"] != null && row["Ithmin"].ToString() != "")
                {
                    model.Ithmin = decimal.Parse(row["Ithmin"].ToString());
                }
                if (row["Ithmax"] != null && row["Ithmax"].ToString() != "")
                {
                    model.Ithmax = decimal.Parse(row["Ithmax"].ToString());
                }
                if (row["Ithhmin"] != null && row["Ithhmin"].ToString() != "")
                {
                    model.Ithhmin = decimal.Parse(row["Ithhmin"].ToString());
                }
                if (row["Ithhmax"] != null && row["Ithhmax"].ToString() != "")
                {
                    model.Ithhmax = decimal.Parse(row["Ithhmax"].ToString());
                }
                if (row["Ithdmin"] != null && row["Ithdmin"].ToString() != "")
                {
                    model.Ithdmin = decimal.Parse(row["Ithdmin"].ToString());
                }
                if (row["Ithdmax"] != null && row["Ithdmax"].ToString() != "")
                {
                    model.Ithdmax = decimal.Parse(row["Ithdmax"].ToString());
                }
                if (row["Ifmin"] != null && row["Ifmin"].ToString() != "")
                {
                    model.Ifmin = decimal.Parse(row["Ifmin"].ToString());
                }
                if (row["Ifmax"] != null && row["Ifmax"].ToString() != "")
                {
                    model.Ifmax = decimal.Parse(row["Ifmax"].ToString());
                }
                if (row["Ifhmin"] != null && row["Ifhmin"].ToString() != "")
                {
                    model.Ifhmin = decimal.Parse(row["Ifhmin"].ToString());
                }
                if (row["Ifhmax"] != null && row["Ifhmax"].ToString() != "")
                {
                    model.Ifhmax = decimal.Parse(row["Ifhmax"].ToString());
                }
                if (row["Ifdmin"] != null && row["Ifdmin"].ToString() != "")
                {
                    model.Ifdmin = decimal.Parse(row["Ifdmin"].ToString());
                }
                if (row["Ifdmax"] != null && row["Ifdmax"].ToString() != "")
                {
                    model.Ifdmax = decimal.Parse(row["Ifdmax"].ToString());
                }
                if (row["Ifc"] != null && row["Ifc"].ToString() != "")
                {
                    model.Ifc = decimal.Parse(row["Ifc"].ToString());
                }
                if (row["Ifh"] != null && row["Ifh"].ToString() != "")
                {
                    model.Ifh = decimal.Parse(row["Ifh"].ToString());
                }
                if (row["Ifd"] != null && row["Ifd"].ToString() != "")
                {
                    model.Ifd = decimal.Parse(row["Ifd"].ToString());
                }
                if (row["Vfmin"] != null && row["Vfmin"].ToString() != "")
                {
                    model.Vfmin = decimal.Parse(row["Vfmin"].ToString());
                }
                if (row["Vfmax"] != null && row["Vfmax"].ToString() != "")
                {
                    model.Vfmax = decimal.Parse(row["Vfmax"].ToString());
                }
                if (row["Vfhmin"] != null && row["Vfhmin"].ToString() != "")
                {
                    model.Vfhmin = decimal.Parse(row["Vfhmin"].ToString());
                }
                if (row["Vfhmax"] != null && row["Vfhmax"].ToString() != "")
                {
                    model.Vfhmax = decimal.Parse(row["Vfhmax"].ToString());
                }
                if (row["Vfdmax"] != null && row["Vfdmax"].ToString() != "")
                {
                    model.Vfdmax = decimal.Parse(row["Vfdmax"].ToString());
                }
                if (row["Vfdmin"] != null && row["Vfdmin"].ToString() != "")
                {
                    model.Vfdmin = decimal.Parse(row["Vfdmin"].ToString());
                }
                if (row["Imomin"] != null && row["Imomin"].ToString() != "")
                {
                    model.Imomin = int.Parse(row["Imomin"].ToString());
                }
                if (row["ImominBFB"] != null && row["ImominBFB"].ToString() != "")
                {
                    model.ImominBFB = int.Parse(row["ImominBFB"].ToString());
                }
                if (row["Imomax"] != null && row["Imomax"].ToString() != "")
                {
                    model.Imomax = int.Parse(row["Imomax"].ToString());
                }
                if (row["ImomaxBFB"] != null && row["ImomaxBFB"].ToString() != "")
                {
                    model.ImomaxBFB = int.Parse(row["ImomaxBFB"].ToString());
                }
                if (row["Imohmin"] != null && row["Imohmin"].ToString() != "")
                {
                    model.Imohmin = int.Parse(row["Imohmin"].ToString());
                }
                if (row["Imohmax"] != null && row["Imohmax"].ToString() != "")
                {
                    model.Imohmax = int.Parse(row["Imohmax"].ToString());
                }
                if (row["Imodmin"] != null && row["Imodmin"].ToString() != "")
                {
                    model.Imodmin = int.Parse(row["Imodmin"].ToString());
                }
                if (row["Imodmax"] != null && row["Imodmax"].ToString() != "")
                {
                    model.Imodmax = int.Parse(row["Imodmax"].ToString());
                }
                if (row["Esmin"] != null && row["Esmin"].ToString() != "")
                {
                    model.Esmin = decimal.Parse(row["Esmin"].ToString());
                }
                if (row["EsminBFB"] != null && row["EsminBFB"].ToString() != "")
                {
                    model.EsminBFB = int.Parse(row["EsminBFB"].ToString());
                }
                if (row["Esmax"] != null && row["Esmax"].ToString() != "")
                {
                    model.Esmax = decimal.Parse(row["Esmax"].ToString());
                }
                if (row["EsmaxBFB"] != null && row["EsmaxBFB"].ToString() != "")
                {
                    model.EsmaxBFB = int.Parse(row["EsmaxBFB"].ToString());
                }
                if (row["Eshmin"] != null && row["Eshmin"].ToString() != "")
                {
                    model.Eshmin = decimal.Parse(row["Eshmin"].ToString());
                }
                if (row["Eshmax"] != null && row["Eshmax"].ToString() != "")
                {
                    model.Eshmax = decimal.Parse(row["Eshmax"].ToString());
                }
                if (row["Esdmin"] != null && row["Esdmin"].ToString() != "")
                {
                    model.Esdmin = decimal.Parse(row["Esdmin"].ToString());
                }
                if (row["Esdmax"] != null && row["Esdmax"].ToString() != "")
                {
                    model.Esdmax = decimal.Parse(row["Esdmax"].ToString());
                }
                if (row["Rsmin"] != null && row["Rsmin"].ToString() != "")
                {
                    model.Rsmin = decimal.Parse(row["Rsmin"].ToString());
                }
                if (row["Rsmax"] != null && row["Rsmax"].ToString() != "")
                {
                    model.Rsmax = decimal.Parse(row["Rsmax"].ToString());
                }
                if (row["Rshmin"] != null && row["Rshmin"].ToString() != "")
                {
                    model.Rshmin = decimal.Parse(row["Rshmin"].ToString());
                }
                if (row["Rshmax"] != null && row["Rshmax"].ToString() != "")
                {
                    model.Rshmax = decimal.Parse(row["Rshmax"].ToString());
                }
                if (row["Rsdmin"] != null && row["Rsdmin"].ToString() != "")
                {
                    model.Rsdmin = decimal.Parse(row["Rsdmin"].ToString());
                }
                if (row["Rsdmax"] != null && row["Rsdmax"].ToString() != "")
                {
                    model.Rsdmax = decimal.Parse(row["Rsdmax"].ToString());
                }
                if (row["TEdmin"] != null && row["TEdmin"].ToString() != "")
                {
                    model.TEdmin = decimal.Parse(row["TEdmin"].ToString());
                }
                if (row["TEdmax"] != null && row["TEdmax"].ToString() != "")
                {
                    model.TEdmax = decimal.Parse(row["TEdmax"].ToString());
                }
                if (row["TEhmin"] != null && row["TEhmin"].ToString() != "")
                {
                    model.TEhmin = decimal.Parse(row["TEhmin"].ToString());
                }
                if (row["TEhmax"] != null && row["TEhmax"].ToString() != "")
                {
                    model.TEhmax = decimal.Parse(row["TEhmax"].ToString());
                }
                if (row["LDλcmin"] != null && row["LDλcmin"].ToString() != "")
                {
                    model.LDλcmin = decimal.Parse(row["LDλcmin"].ToString());
                }
                if (row["LDλcmax"] != null && row["LDλcmax"].ToString() != "")
                {
                    model.LDλcmax = decimal.Parse(row["LDλcmax"].ToString());
                }
                if (row["LDλchmin"] != null)
                {
                    model.LDλchmin = row["LDλchmin"].ToString();
                }
                if (row["LDλchmax"] != null)
                {
                    model.LDλchmax = row["LDλchmax"].ToString();
                }
                if (row["LDλcdmin"] != null)
                {
                    model.LDλcdmin = row["LDλcdmin"].ToString();
                }
                if (row["LDλcdmax"] != null)
                {
                    model.LDλcdmax = row["LDλcdmax"].ToString();
                }
                if (row["LDλmin"] != null && row["LDλmin"].ToString() != "")
                {
                    model.LDλmin = decimal.Parse(row["LDλmin"].ToString());
                }
                if (row["LDλmax"] != null && row["LDλmax"].ToString() != "")
                {
                    model.LDλmax = decimal.Parse(row["LDλmax"].ToString());
                }
                if (row["LDλhmin"] != null)
                {
                    model.LDλhmin = row["LDλhmin"].ToString();
                }
                if (row["LDλhmax"] != null)
                {
                    model.LDλhmax = row["LDλhmax"].ToString();
                }
                if (row["LDλdmin"] != null)
                {
                    model.LDλdmin = row["LDλdmin"].ToString();
                }
                if (row["LDλdmax"] != null)
                {
                    model.LDλdmax = row["LDλdmax"].ToString();
                }
                if (row["Srmsmin"] != null && row["Srmsmin"].ToString() != "")
                {
                    model.Srmsmin = decimal.Parse(row["Srmsmin"].ToString());
                }
                if (row["Srmsmax"] != null && row["Srmsmax"].ToString() != "")
                {
                    model.Srmsmax = decimal.Parse(row["Srmsmax"].ToString());
                }
                if (row["Srmshmin"] != null)
                {
                    model.Srmshmin = row["Srmshmin"].ToString();
                }
                if (row["Srmshmax"] != null)
                {
                    model.Srmshmax = row["Srmshmax"].ToString();
                }
                if (row["Srmsdmin"] != null)
                {
                    model.Srmsdmin = row["Srmsdmin"].ToString();
                }
                if (row["Srmsdmax"] != null)
                {
                    model.Srmsdmax = row["Srmsdmax"].ToString();
                }
                if (row["Pkinkmin"] != null && row["Pkinkmin"].ToString() != "")
                {
                    model.Pkinkmin = int.Parse(row["Pkinkmin"].ToString());
                }
                if (row["Pkinkmax"] != null && row["Pkinkmax"].ToString() != "")
                {
                    model.Pkinkmax = int.Parse(row["Pkinkmax"].ToString());
                }
                if (row["Pkinkhmin"] != null && row["Pkinkhmin"].ToString() != "")
                {
                    model.Pkinkhmin = int.Parse(row["Pkinkhmin"].ToString());
                }
                if (row["Pkinkhmax"] != null && row["Pkinkhmax"].ToString() != "")
                {
                    model.Pkinkhmax = int.Parse(row["Pkinkhmax"].ToString());
                }
                if (row["Pkinkdmin"] != null && row["Pkinkdmin"].ToString() != "")
                {
                    model.Pkinkdmin = int.Parse(row["Pkinkdmin"].ToString());
                }
                if (row["Pkinkdmax"] != null && row["Pkinkdmax"].ToString() != "")
                {
                    model.Pkinkdmax = int.Parse(row["Pkinkdmax"].ToString());
                }
                if (row["Kimomin"] != null && row["Kimomin"].ToString() != "")
                {
                    model.Kimomin = int.Parse(row["Kimomin"].ToString());
                }
                if (row["Kimomax"] != null && row["Kimomax"].ToString() != "")
                {
                    model.Kimomax = int.Parse(row["Kimomax"].ToString());
                }
                if (row["Kimohmin"] != null && row["Kimohmin"].ToString() != "")
                {
                    model.Kimohmin = int.Parse(row["Kimohmin"].ToString());
                }
                if (row["Kimohmax"] != null && row["Kimohmax"].ToString() != "")
                {
                    model.Kimohmax = int.Parse(row["Kimohmax"].ToString());
                }
                if (row["Kimodmin"] != null && row["Kimodmin"].ToString() != "")
                {
                    model.Kimodmin = int.Parse(row["Kimodmin"].ToString());
                }
                if (row["Kimodmax"] != null && row["Kimodmax"].ToString() != "")
                {
                    model.Kimodmax = int.Parse(row["Kimodmax"].ToString());
                }
                if (row["ImoKinkmin"] != null && row["ImoKinkmin"].ToString() != "")
                {
                    model.ImoKinkmin = int.Parse(row["ImoKinkmin"].ToString());
                }
                if (row["ImoKinkmax"] != null && row["ImoKinkmax"].ToString() != "")
                {
                    model.ImoKinkmax = int.Parse(row["ImoKinkmax"].ToString());
                }
                if (row["Idarkmin"] != null && row["Idarkmin"].ToString() != "")
                {
                    model.Idarkmin = int.Parse(row["Idarkmin"].ToString());
                }
                if (row["Idarkmax"] != null && row["Idarkmax"].ToString() != "")
                {
                    model.Idarkmax = int.Parse(row["Idarkmax"].ToString());
                }
                if (row["Txidmin"] != null && row["Txidmin"].ToString() != "")
                {
                    model.Txidmin = int.Parse(row["Txidmin"].ToString());
                }
                if (row["Txidmax"] != null && row["Txidmax"].ToString() != "")
                {
                    model.Txidmax = int.Parse(row["Txidmax"].ToString());
                }
                if (row["Txidhmin"] != null && row["Txidhmin"].ToString() != "")
                {
                    model.Txidhmin = decimal.Parse(row["Txidhmin"].ToString());
                }
                if (row["Txidhmax"] != null && row["Txidhmax"].ToString() != "")
                {
                    model.Txidhmax = decimal.Parse(row["Txidhmax"].ToString());
                }
                if (row["Txiddmin"] != null && row["Txiddmin"].ToString() != "")
                {
                    model.Txiddmin = decimal.Parse(row["Txiddmin"].ToString());
                }
                if (row["Txiddmax"] != null && row["Txiddmax"].ToString() != "")
                {
                    model.Txiddmax = decimal.Parse(row["Txiddmax"].ToString());
                }
                if (row["qpomin"] != null && row["qpomin"].ToString() != "")
                {
                    model.qpomin = decimal.Parse(row["qpomin"].ToString());
                }
                if (row["qpomax"] != null && row["qpomax"].ToString() != "")
                {
                    model.qpomax = decimal.Parse(row["qpomax"].ToString());
                }
                if (row["qhpomin"] != null && row["qhpomin"].ToString() != "")
                {
                    model.qhpomin = decimal.Parse(row["qhpomin"].ToString());
                }
                if (row["qhpomax"] != null && row["qhpomax"].ToString() != "")
                {
                    model.qhpomax = decimal.Parse(row["qhpomax"].ToString());
                }
                if (row["PTλc"] != null)
                {
                    model.PTλc = row["PTλc"].ToString();
                }
                if (row["PT方法"] != null)
                {
                    model.PT方法 = row["PT方法"].ToString();
                }
                if (row["APT_PT"] != null)
                {
                    model.APT_PT = row["APT_PT"].ToString();
                }
                if (row["码型"] != null)
                {
                    model.码型 = row["码型"].ToString();
                }
                if (row["速率"] != null)
                {
                    model.速率 = row["速率"].ToString();
                }
                if (row["Sen"] != null && row["Sen"].ToString() != "")
                {
                    model.Sen = decimal.Parse(row["Sen"].ToString());
                }
                if (row["通时间"] != null && row["通时间"].ToString() != "")
                {
                    model.通时间 = int.Parse(row["通时间"].ToString());
                }
                if (row["误码率"] != null)
                {
                    model.误码率 = row["误码率"].ToString();
                }
                if (row["Vbr34"] != null)
                {
                    model.Vbr34 = row["Vbr34"].ToString();
                }
                if (row["Vbrmin"] != null && row["Vbrmin"].ToString() != "")
                {
                    model.Vbrmin = decimal.Parse(row["Vbrmin"].ToString());
                }
                if (row["Vbrmax"] != null && row["Vbrmax"].ToString() != "")
                {
                    model.Vbrmax = decimal.Parse(row["Vbrmax"].ToString());
                }
                if (row["Vbrhmin"] != null && row["Vbrhmin"].ToString() != "")
                {
                    model.Vbrhmin = decimal.Parse(row["Vbrhmin"].ToString());
                }
                if (row["Vbrhmax"] != null && row["Vbrhmax"].ToString() != "")
                {
                    model.Vbrhmax = decimal.Parse(row["Vbrhmax"].ToString());
                }
                if (row["Vbrdmin"] != null && row["Vbrdmin"].ToString() != "")
                {
                    model.Vbrdmin = decimal.Parse(row["Vbrdmin"].ToString());
                }
                if (row["Vbrdmax"] != null && row["Vbrdmax"].ToString() != "")
                {
                    model.Vbrdmax = decimal.Parse(row["Vbrdmax"].ToString());
                }
                if (row["Iccmin"] != null && row["Iccmin"].ToString() != "")
                {
                    model.Iccmin = decimal.Parse(row["Iccmin"].ToString());
                }
                if (row["Iccmax"] != null && row["Iccmax"].ToString() != "")
                {
                    model.Iccmax = decimal.Parse(row["Iccmax"].ToString());
                }
                if (row["Icchmin"] != null && row["Icchmin"].ToString() != "")
                {
                    model.Icchmin = decimal.Parse(row["Icchmin"].ToString());
                }
                if (row["Icchmax"] != null && row["Icchmax"].ToString() != "")
                {
                    model.Icchmax = decimal.Parse(row["Icchmax"].ToString());
                }
                if (row["Iccdmin"] != null && row["Iccdmin"].ToString() != "")
                {
                    model.Iccdmin = decimal.Parse(row["Iccdmin"].ToString());
                }
                if (row["Iccdmax"] != null && row["Iccdmax"].ToString() != "")
                {
                    model.Iccdmax = decimal.Parse(row["Iccdmax"].ToString());
                }
                if (row["Iopmin"] != null && row["Iopmin"].ToString() != "")
                {
                    model.Iopmin = decimal.Parse(row["Iopmin"].ToString());
                }
                if (row["IopminBFB"] != null && row["IopminBFB"].ToString() != "")
                {
                    model.IopminBFB = int.Parse(row["IopminBFB"].ToString());
                }
                if (row["Iopmax"] != null && row["Iopmax"].ToString() != "")
                {
                    model.Iopmax = decimal.Parse(row["Iopmax"].ToString());
                }
                if (row["Iomin"] != null && row["Iomin"].ToString() != "")
                {
                    model.Iomin = decimal.Parse(row["Iomin"].ToString());
                }
                if (row["IominBFB"] != null && row["IominBFB"].ToString() != "")
                {
                    model.IominBFB = int.Parse(row["IominBFB"].ToString());
                }
                if (row["Iomax"] != null && row["Iomax"].ToString() != "")
                {
                    model.Iomax = decimal.Parse(row["Iomax"].ToString());
                }
                if (row["Idmin"] != null && row["Idmin"].ToString() != "")
                {
                    model.Idmin = decimal.Parse(row["Idmin"].ToString());
                }
                if (row["Idmax"] != null && row["Idmax"].ToString() != "")
                {
                    model.Idmax = decimal.Parse(row["Idmax"].ToString());
                }
                if (row["Senmin"] != null && row["Senmin"].ToString() != "")
                {
                    model.Senmin = decimal.Parse(row["Senmin"].ToString());
                }
                if (row["Senmax"] != null && row["Senmax"].ToString() != "")
                {
                    model.Senmax = decimal.Parse(row["Senmax"].ToString());
                }
                if (row["SenmaxdB"] != null && row["SenmaxdB"].ToString() != "")
                {
                    model.SenmaxdB = decimal.Parse(row["SenmaxdB"].ToString());
                }
                if (row["senhmin"] != null && row["senhmin"].ToString() != "")
                {
                    model.senhmin = decimal.Parse(row["senhmin"].ToString());
                }
                if (row["senhmax"] != null && row["senhmax"].ToString() != "")
                {
                    model.senhmax = decimal.Parse(row["senhmax"].ToString());
                }
                if (row["sendmin"] != null && row["sendmin"].ToString() != "")
                {
                    model.sendmin = decimal.Parse(row["sendmin"].ToString());
                }
                if (row["sendmax"] != null && row["sendmax"].ToString() != "")
                {
                    model.sendmax = decimal.Parse(row["sendmax"].ToString());
                }
                if (row["老化前min"] != null && row["老化前min"].ToString() != "")
                {
                    model.老化前min = decimal.Parse(row["老化前min"].ToString());
                }
                if (row["老化前minBFB"] != null && row["老化前minBFB"].ToString() != "")
                {
                    model.老化前minBFB = int.Parse(row["老化前minBFB"].ToString());
                }
                if (row["老化前max"] != null && row["老化前max"].ToString() != "")
                {
                    model.老化前max = decimal.Parse(row["老化前max"].ToString());
                }
                if (row["老化前maxBFB"] != null && row["老化前maxBFB"].ToString() != "")
                {
                    model.老化前maxBFB = int.Parse(row["老化前maxBFB"].ToString());
                }
                if (row["前后对比min"] != null && row["前后对比min"].ToString() != "")
                {
                    model.前后对比min = decimal.Parse(row["前后对比min"].ToString());
                }
                if (row["前后对比max"] != null && row["前后对比max"].ToString() != "")
                {
                    model.前后对比max = decimal.Parse(row["前后对比max"].ToString());
                }
                if (row["上传时间"] != null && row["上传时间"].ToString() != "")
                {
                    model.上传时间 = DateTime.Parse(row["上传时间"].ToString());
                }
                if (row["审核时间"] != null && row["审核时间"].ToString() != "")
                {
                    model.审核时间 = DateTime.Parse(row["审核时间"].ToString());
                }
                if (row["备注"] != null)
                {
                    model.备注 = row["备注"].ToString();
                }
            }
            return model;
        }


        public DataSet Query()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM tsuhan_spec");
            return dbhelper1.Query(strSql.ToString());
        }
    }
}
