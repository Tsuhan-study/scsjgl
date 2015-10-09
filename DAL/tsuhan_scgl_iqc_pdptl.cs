using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_scgl_iqc_pdptl
	/// </summary>
	public partial class tsuhan_scgl_iqc_pdptl
	{
		public tsuhan_scgl_iqc_pdptl()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string pch)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tsuhan_scgl_iqc_pdptl");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.Char,30)			};
			parameters[0].Value = pch;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_scgl_iqc_pdptl model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_scgl_iqc_pdptl(");
			strSql.Append("id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,wlbm,ggxhbc,gm,gwpl,sulv,ohrq,ohbc,cjybl,gjwx,other,checkcondition,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,check1name,check1value,check1result,check1bz,check2name,check2value,check2result,check2bz,check3name,check3value,check3result,check3bz,check4name,check4value,check4result,check4bz,check5name,check5value,check5result,check5bz,check6name,check6value,check6result,check6bz,check7name,check7value,check7result,check7bz,recorder,recordtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@pch,@jylx,@gysdm,@rkdh,@dhrq,@sl,@wlmc,@wlbm,@ggxhbc,@gm,@gwpl,@sulv,@ohrq,@ohbc,@cjybl,@gjwx,@other,@checkcondition,@cybz,@aql,@qjyn,@okrate,@wg_jyyjbz,@wg_cjybsl,@wg_okng,@wg_sign,@wg_ngindex,@bs_okng,@bs_sign,@bs_ngindex,@bz_okng,@bz_sign,@bz_ngindex,@report,@report_sign,@ngdescription,@checkjg,@checker,@checkertime,@groupleader,@grouptime,@remarks,@ggsbh,@check1name,@check1value,@check1result,@check1bz,@check2name,@check2value,@check2result,@check2bz,@check3name,@check3value,@check3result,@check3bz,@check4name,@check4value,@check4result,@check4bz,@check5name,@check5value,@check5result,@check5bz,@check6name,@check6value,@check6result,@check6bz,@check7name,@check7value,@check7result,@check7bz,@recorder,@recordtime)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pch", SqlDbType.Char,30),
					new SqlParameter("@jylx", SqlDbType.Char,30),
					new SqlParameter("@gysdm", SqlDbType.Char,30),
					new SqlParameter("@rkdh", SqlDbType.Char,30),
					new SqlParameter("@dhrq", SqlDbType.Char,30),
					new SqlParameter("@sl", SqlDbType.Int,4),
					new SqlParameter("@wlmc", SqlDbType.Char,30),
					new SqlParameter("@wlbm", SqlDbType.Char,30),
					new SqlParameter("@ggxhbc", SqlDbType.Char,30),
					new SqlParameter("@gm", SqlDbType.Char,10),
					new SqlParameter("@gwpl", SqlDbType.Char,10),
					new SqlParameter("@sulv", SqlDbType.Char,10),
					new SqlParameter("@ohrq", SqlDbType.Char,10),
					new SqlParameter("@ohbc", SqlDbType.Char,10),
					new SqlParameter("@cjybl", SqlDbType.Int,4),
					new SqlParameter("@gjwx", SqlDbType.Char,10),
					new SqlParameter("@other", SqlDbType.Char,30),
					new SqlParameter("@checkcondition", SqlDbType.Char,100),
					new SqlParameter("@cybz", SqlDbType.Char,100),
					new SqlParameter("@aql", SqlDbType.Char,30),
					new SqlParameter("@qjyn", SqlDbType.Bit,1),
					new SqlParameter("@okrate", SqlDbType.Int,4),
					new SqlParameter("@wg_jyyjbz", SqlDbType.Char,100),
					new SqlParameter("@wg_cjybsl", SqlDbType.Int,4),
					new SqlParameter("@wg_okng", SqlDbType.Char,10),
					new SqlParameter("@wg_sign", SqlDbType.Char,10),
					new SqlParameter("@wg_ngindex", SqlDbType.Char,200),
					new SqlParameter("@bs_okng", SqlDbType.Char,10),
					new SqlParameter("@bs_sign", SqlDbType.Char,10),
					new SqlParameter("@bs_ngindex", SqlDbType.Char,200),
					new SqlParameter("@bz_okng", SqlDbType.Char,10),
					new SqlParameter("@bz_sign", SqlDbType.Char,10),
					new SqlParameter("@bz_ngindex", SqlDbType.Char,200),
					new SqlParameter("@report", SqlDbType.Char,200),
					new SqlParameter("@report_sign", SqlDbType.Char,10),
					new SqlParameter("@ngdescription", SqlDbType.Char,500),
					new SqlParameter("@checkjg", SqlDbType.Char,300),
					new SqlParameter("@checker", SqlDbType.Char,10),
					new SqlParameter("@checkertime", SqlDbType.DateTime),
					new SqlParameter("@groupleader", SqlDbType.Char,10),
					new SqlParameter("@grouptime", SqlDbType.DateTime),
					new SqlParameter("@remarks", SqlDbType.Char,10),
					new SqlParameter("@ggsbh", SqlDbType.NChar,10),
					new SqlParameter("@check1name", SqlDbType.NChar,20),
					new SqlParameter("@check1value", SqlDbType.Float,8),
					new SqlParameter("@check1result", SqlDbType.NChar,10),
					new SqlParameter("@check1bz", SqlDbType.NChar,10),
					new SqlParameter("@check2name", SqlDbType.NChar,20),
					new SqlParameter("@check2value", SqlDbType.Float,8),
					new SqlParameter("@check2result", SqlDbType.NChar,10),
					new SqlParameter("@check2bz", SqlDbType.NChar,10),
					new SqlParameter("@check3name", SqlDbType.NChar,20),
					new SqlParameter("@check3value", SqlDbType.Float,8),
					new SqlParameter("@check3result", SqlDbType.NChar,10),
					new SqlParameter("@check3bz", SqlDbType.NChar,10),
					new SqlParameter("@check4name", SqlDbType.NChar,20),
					new SqlParameter("@check4value", SqlDbType.Float,8),
					new SqlParameter("@check4result", SqlDbType.NChar,10),
					new SqlParameter("@check4bz", SqlDbType.NChar,10),
					new SqlParameter("@check5name", SqlDbType.NChar,20),
					new SqlParameter("@check5value", SqlDbType.Float,8),
					new SqlParameter("@check5result", SqlDbType.NChar,10),
					new SqlParameter("@check5bz", SqlDbType.NChar,10),
					new SqlParameter("@check6name", SqlDbType.NChar,20),
					new SqlParameter("@check6value", SqlDbType.Float,8),
					new SqlParameter("@check6result", SqlDbType.NChar,10),
					new SqlParameter("@check6bz", SqlDbType.NChar,10),
					new SqlParameter("@check7name", SqlDbType.NChar,20),
					new SqlParameter("@check7value", SqlDbType.Float,8),
					new SqlParameter("@check7result", SqlDbType.NChar,10),
					new SqlParameter("@check7bz", SqlDbType.NChar,10),
					new SqlParameter("@recorder", SqlDbType.NChar,10),
					new SqlParameter("@recordtime", SqlDbType.Timestamp,8)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.pch;
			parameters[2].Value = model.jylx;
			parameters[3].Value = model.gysdm;
			parameters[4].Value = model.rkdh;
			parameters[5].Value = model.dhrq;
			parameters[6].Value = model.sl;
			parameters[7].Value = model.wlmc;
			parameters[8].Value = model.wlbm;
			parameters[9].Value = model.ggxhbc;
			parameters[10].Value = model.gm;
			parameters[11].Value = model.gwpl;
			parameters[12].Value = model.sulv;
			parameters[13].Value = model.ohrq;
			parameters[14].Value = model.ohbc;
			parameters[15].Value = model.cjybl;
			parameters[16].Value = model.gjwx;
			parameters[17].Value = model.other;
			parameters[18].Value = model.checkcondition;
			parameters[19].Value = model.cybz;
			parameters[20].Value = model.aql;
			parameters[21].Value = model.qjyn;
			parameters[22].Value = model.okrate;
			parameters[23].Value = model.wg_jyyjbz;
			parameters[24].Value = model.wg_cjybsl;
			parameters[25].Value = model.wg_okng;
			parameters[26].Value = model.wg_sign;
			parameters[27].Value = model.wg_ngindex;
			parameters[28].Value = model.bs_okng;
			parameters[29].Value = model.bs_sign;
			parameters[30].Value = model.bs_ngindex;
			parameters[31].Value = model.bz_okng;
			parameters[32].Value = model.bz_sign;
			parameters[33].Value = model.bz_ngindex;
			parameters[34].Value = model.report;
			parameters[35].Value = model.report_sign;
			parameters[36].Value = model.ngdescription;
			parameters[37].Value = model.checkjg;
			parameters[38].Value = model.checker;
			parameters[39].Value = model.checkertime;
			parameters[40].Value = model.groupleader;
			parameters[41].Value = model.grouptime;
			parameters[42].Value = model.remarks;
			parameters[43].Value = model.ggsbh;
			parameters[44].Value = model.check1name;
			parameters[45].Value = model.check1value;
			parameters[46].Value = model.check1result;
			parameters[47].Value = model.check1bz;
			parameters[48].Value = model.check2name;
			parameters[49].Value = model.check2value;
			parameters[50].Value = model.check2result;
			parameters[51].Value = model.check2bz;
			parameters[52].Value = model.check3name;
			parameters[53].Value = model.check3value;
			parameters[54].Value = model.check3result;
			parameters[55].Value = model.check3bz;
			parameters[56].Value = model.check4name;
			parameters[57].Value = model.check4value;
			parameters[58].Value = model.check4result;
			parameters[59].Value = model.check4bz;
			parameters[60].Value = model.check5name;
			parameters[61].Value = model.check5value;
			parameters[62].Value = model.check5result;
			parameters[63].Value = model.check5bz;
			parameters[64].Value = model.check6name;
			parameters[65].Value = model.check6value;
			parameters[66].Value = model.check6result;
			parameters[67].Value = model.check6bz;
			parameters[68].Value = model.check7name;
			parameters[69].Value = model.check7value;
			parameters[70].Value = model.check7result;
			parameters[71].Value = model.check7bz;
			parameters[72].Value = model.recorder;
			parameters[73].Value = model.recordtime;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.tsuhan_scgl_iqc_pdptl model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_scgl_iqc_pdptl set ");
			strSql.Append("id=@id,");
			strSql.Append("jylx=@jylx,");
			strSql.Append("gysdm=@gysdm,");
			strSql.Append("rkdh=@rkdh,");
			strSql.Append("dhrq=@dhrq,");
			strSql.Append("sl=@sl,");
			strSql.Append("wlmc=@wlmc,");
			strSql.Append("wlbm=@wlbm,");
			strSql.Append("ggxhbc=@ggxhbc,");
			strSql.Append("gm=@gm,");
			strSql.Append("gwpl=@gwpl,");
			strSql.Append("sulv=@sulv,");
			strSql.Append("ohrq=@ohrq,");
			strSql.Append("ohbc=@ohbc,");
			strSql.Append("cjybl=@cjybl,");
			strSql.Append("gjwx=@gjwx,");
			strSql.Append("other=@other,");
			strSql.Append("checkcondition=@checkcondition,");
			strSql.Append("cybz=@cybz,");
			strSql.Append("aql=@aql,");
			strSql.Append("qjyn=@qjyn,");
			strSql.Append("okrate=@okrate,");
			strSql.Append("wg_jyyjbz=@wg_jyyjbz,");
			strSql.Append("wg_cjybsl=@wg_cjybsl,");
			strSql.Append("wg_okng=@wg_okng,");
			strSql.Append("wg_sign=@wg_sign,");
			strSql.Append("wg_ngindex=@wg_ngindex,");
			strSql.Append("bs_okng=@bs_okng,");
			strSql.Append("bs_sign=@bs_sign,");
			strSql.Append("bs_ngindex=@bs_ngindex,");
			strSql.Append("bz_okng=@bz_okng,");
			strSql.Append("bz_sign=@bz_sign,");
			strSql.Append("bz_ngindex=@bz_ngindex,");
			strSql.Append("report=@report,");
			strSql.Append("report_sign=@report_sign,");
			strSql.Append("ngdescription=@ngdescription,");
			strSql.Append("checkjg=@checkjg,");
			strSql.Append("checker=@checker,");
			strSql.Append("checkertime=@checkertime,");
			strSql.Append("groupleader=@groupleader,");
			strSql.Append("grouptime=@grouptime,");
			strSql.Append("remarks=@remarks,");
			strSql.Append("ggsbh=@ggsbh,");
			strSql.Append("check1name=@check1name,");
			strSql.Append("check1value=@check1value,");
			strSql.Append("check1result=@check1result,");
			strSql.Append("check1bz=@check1bz,");
			strSql.Append("check2name=@check2name,");
			strSql.Append("check2value=@check2value,");
			strSql.Append("check2result=@check2result,");
			strSql.Append("check2bz=@check2bz,");
			strSql.Append("check3name=@check3name,");
			strSql.Append("check3value=@check3value,");
			strSql.Append("check3result=@check3result,");
			strSql.Append("check3bz=@check3bz,");
			strSql.Append("check4name=@check4name,");
			strSql.Append("check4value=@check4value,");
			strSql.Append("check4result=@check4result,");
			strSql.Append("check4bz=@check4bz,");
			strSql.Append("check5name=@check5name,");
			strSql.Append("check5value=@check5value,");
			strSql.Append("check5result=@check5result,");
			strSql.Append("check5bz=@check5bz,");
			strSql.Append("check6name=@check6name,");
			strSql.Append("check6value=@check6value,");
			strSql.Append("check6result=@check6result,");
			strSql.Append("check6bz=@check6bz,");
			strSql.Append("check7name=@check7name,");
			strSql.Append("check7value=@check7value,");
			strSql.Append("check7result=@check7result,");
			strSql.Append("check7bz=@check7bz,");
			strSql.Append("recorder=@recorder");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@jylx", SqlDbType.Char,30),
					new SqlParameter("@gysdm", SqlDbType.Char,30),
					new SqlParameter("@rkdh", SqlDbType.Char,30),
					new SqlParameter("@dhrq", SqlDbType.Char,30),
					new SqlParameter("@sl", SqlDbType.Int,4),
					new SqlParameter("@wlmc", SqlDbType.Char,30),
					new SqlParameter("@wlbm", SqlDbType.Char,30),
					new SqlParameter("@ggxhbc", SqlDbType.Char,30),
					new SqlParameter("@gm", SqlDbType.Char,10),
					new SqlParameter("@gwpl", SqlDbType.Char,10),
					new SqlParameter("@sulv", SqlDbType.Char,10),
					new SqlParameter("@ohrq", SqlDbType.Char,10),
					new SqlParameter("@ohbc", SqlDbType.Char,10),
					new SqlParameter("@cjybl", SqlDbType.Int,4),
					new SqlParameter("@gjwx", SqlDbType.Char,10),
					new SqlParameter("@other", SqlDbType.Char,30),
					new SqlParameter("@checkcondition", SqlDbType.Char,100),
					new SqlParameter("@cybz", SqlDbType.Char,100),
					new SqlParameter("@aql", SqlDbType.Char,30),
					new SqlParameter("@qjyn", SqlDbType.Bit,1),
					new SqlParameter("@okrate", SqlDbType.Int,4),
					new SqlParameter("@wg_jyyjbz", SqlDbType.Char,100),
					new SqlParameter("@wg_cjybsl", SqlDbType.Int,4),
					new SqlParameter("@wg_okng", SqlDbType.Char,10),
					new SqlParameter("@wg_sign", SqlDbType.Char,10),
					new SqlParameter("@wg_ngindex", SqlDbType.Char,200),
					new SqlParameter("@bs_okng", SqlDbType.Char,10),
					new SqlParameter("@bs_sign", SqlDbType.Char,10),
					new SqlParameter("@bs_ngindex", SqlDbType.Char,200),
					new SqlParameter("@bz_okng", SqlDbType.Char,10),
					new SqlParameter("@bz_sign", SqlDbType.Char,10),
					new SqlParameter("@bz_ngindex", SqlDbType.Char,200),
					new SqlParameter("@report", SqlDbType.Char,200),
					new SqlParameter("@report_sign", SqlDbType.Char,10),
					new SqlParameter("@ngdescription", SqlDbType.Char,500),
					new SqlParameter("@checkjg", SqlDbType.Char,300),
					new SqlParameter("@checker", SqlDbType.Char,10),
					new SqlParameter("@checkertime", SqlDbType.DateTime),
					new SqlParameter("@groupleader", SqlDbType.Char,10),
					new SqlParameter("@grouptime", SqlDbType.DateTime),
					new SqlParameter("@remarks", SqlDbType.Char,10),
					new SqlParameter("@ggsbh", SqlDbType.NChar,10),
					new SqlParameter("@check1name", SqlDbType.NChar,20),
					new SqlParameter("@check1value", SqlDbType.Float,8),
					new SqlParameter("@check1result", SqlDbType.NChar,10),
					new SqlParameter("@check1bz", SqlDbType.NChar,10),
					new SqlParameter("@check2name", SqlDbType.NChar,20),
					new SqlParameter("@check2value", SqlDbType.Float,8),
					new SqlParameter("@check2result", SqlDbType.NChar,10),
					new SqlParameter("@check2bz", SqlDbType.NChar,10),
					new SqlParameter("@check3name", SqlDbType.NChar,20),
					new SqlParameter("@check3value", SqlDbType.Float,8),
					new SqlParameter("@check3result", SqlDbType.NChar,10),
					new SqlParameter("@check3bz", SqlDbType.NChar,10),
					new SqlParameter("@check4name", SqlDbType.NChar,20),
					new SqlParameter("@check4value", SqlDbType.Float,8),
					new SqlParameter("@check4result", SqlDbType.NChar,10),
					new SqlParameter("@check4bz", SqlDbType.NChar,10),
					new SqlParameter("@check5name", SqlDbType.NChar,20),
					new SqlParameter("@check5value", SqlDbType.Float,8),
					new SqlParameter("@check5result", SqlDbType.NChar,10),
					new SqlParameter("@check5bz", SqlDbType.NChar,10),
					new SqlParameter("@check6name", SqlDbType.NChar,20),
					new SqlParameter("@check6value", SqlDbType.Float,8),
					new SqlParameter("@check6result", SqlDbType.NChar,10),
					new SqlParameter("@check6bz", SqlDbType.NChar,10),
					new SqlParameter("@check7name", SqlDbType.NChar,20),
					new SqlParameter("@check7value", SqlDbType.Float,8),
					new SqlParameter("@check7result", SqlDbType.NChar,10),
					new SqlParameter("@check7bz", SqlDbType.NChar,10),
					new SqlParameter("@recorder", SqlDbType.NChar,10),
					new SqlParameter("@pch", SqlDbType.Char,30)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.jylx;
			parameters[2].Value = model.gysdm;
			parameters[3].Value = model.rkdh;
			parameters[4].Value = model.dhrq;
			parameters[5].Value = model.sl;
			parameters[6].Value = model.wlmc;
			parameters[7].Value = model.wlbm;
			parameters[8].Value = model.ggxhbc;
			parameters[9].Value = model.gm;
			parameters[10].Value = model.gwpl;
			parameters[11].Value = model.sulv;
			parameters[12].Value = model.ohrq;
			parameters[13].Value = model.ohbc;
			parameters[14].Value = model.cjybl;
			parameters[15].Value = model.gjwx;
			parameters[16].Value = model.other;
			parameters[17].Value = model.checkcondition;
			parameters[18].Value = model.cybz;
			parameters[19].Value = model.aql;
			parameters[20].Value = model.qjyn;
			parameters[21].Value = model.okrate;
			parameters[22].Value = model.wg_jyyjbz;
			parameters[23].Value = model.wg_cjybsl;
			parameters[24].Value = model.wg_okng;
			parameters[25].Value = model.wg_sign;
			parameters[26].Value = model.wg_ngindex;
			parameters[27].Value = model.bs_okng;
			parameters[28].Value = model.bs_sign;
			parameters[29].Value = model.bs_ngindex;
			parameters[30].Value = model.bz_okng;
			parameters[31].Value = model.bz_sign;
			parameters[32].Value = model.bz_ngindex;
			parameters[33].Value = model.report;
			parameters[34].Value = model.report_sign;
			parameters[35].Value = model.ngdescription;
			parameters[36].Value = model.checkjg;
			parameters[37].Value = model.checker;
			parameters[38].Value = model.checkertime;
			parameters[39].Value = model.groupleader;
			parameters[40].Value = model.grouptime;
			parameters[41].Value = model.remarks;
			parameters[42].Value = model.ggsbh;
			parameters[43].Value = model.check1name;
			parameters[44].Value = model.check1value;
			parameters[45].Value = model.check1result;
			parameters[46].Value = model.check1bz;
			parameters[47].Value = model.check2name;
			parameters[48].Value = model.check2value;
			parameters[49].Value = model.check2result;
			parameters[50].Value = model.check2bz;
			parameters[51].Value = model.check3name;
			parameters[52].Value = model.check3value;
			parameters[53].Value = model.check3result;
			parameters[54].Value = model.check3bz;
			parameters[55].Value = model.check4name;
			parameters[56].Value = model.check4value;
			parameters[57].Value = model.check4result;
			parameters[58].Value = model.check4bz;
			parameters[59].Value = model.check5name;
			parameters[60].Value = model.check5value;
			parameters[61].Value = model.check5result;
			parameters[62].Value = model.check5bz;
			parameters[63].Value = model.check6name;
			parameters[64].Value = model.check6value;
			parameters[65].Value = model.check6result;
			parameters[66].Value = model.check6bz;
			parameters[67].Value = model.check7name;
			parameters[68].Value = model.check7value;
			parameters[69].Value = model.check7result;
			parameters[70].Value = model.check7bz;
			parameters[71].Value = model.recorder;
			parameters[72].Value = model.pch;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string pch)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_scgl_iqc_pdptl ");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.Char,30)			};
			parameters[0].Value = pch;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string pchlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_scgl_iqc_pdptl ");
			strSql.Append(" where pch in ("+pchlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.tsuhan_scgl_iqc_pdptl GetModel(string pch)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,wlbm,ggxhbc,gm,gwpl,sulv,ohrq,ohbc,cjybl,gjwx,other,checkcondition,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,check1name,check1value,check1result,check1bz,check2name,check2value,check2result,check2bz,check3name,check3value,check3result,check3bz,check4name,check4value,check4result,check4bz,check5name,check5value,check5result,check5bz,check6name,check6value,check6result,check6bz,check7name,check7value,check7result,check7bz,recorder,recordtime from tsuhan_scgl_iqc_pdptl ");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.Char,30)			};
			parameters[0].Value = pch;

			Maticsoft.Model.tsuhan_scgl_iqc_pdptl model=new Maticsoft.Model.tsuhan_scgl_iqc_pdptl();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Maticsoft.Model.tsuhan_scgl_iqc_pdptl DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_scgl_iqc_pdptl model=new Maticsoft.Model.tsuhan_scgl_iqc_pdptl();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["pch"]!=null)
				{
					model.pch=row["pch"].ToString();
				}
				if(row["jylx"]!=null)
				{
					model.jylx=row["jylx"].ToString();
				}
				if(row["gysdm"]!=null)
				{
					model.gysdm=row["gysdm"].ToString();
				}
				if(row["rkdh"]!=null)
				{
					model.rkdh=row["rkdh"].ToString();
				}
				if(row["dhrq"]!=null)
				{
					model.dhrq=row["dhrq"].ToString();
				}
				if(row["sl"]!=null && row["sl"].ToString()!="")
				{
					model.sl=int.Parse(row["sl"].ToString());
				}
				if(row["wlmc"]!=null)
				{
					model.wlmc=row["wlmc"].ToString();
				}
				if(row["wlbm"]!=null)
				{
					model.wlbm=row["wlbm"].ToString();
				}
				if(row["ggxhbc"]!=null)
				{
					model.ggxhbc=row["ggxhbc"].ToString();
				}
				if(row["gm"]!=null)
				{
					model.gm=row["gm"].ToString();
				}
				if(row["gwpl"]!=null)
				{
					model.gwpl=row["gwpl"].ToString();
				}
				if(row["sulv"]!=null)
				{
					model.sulv=row["sulv"].ToString();
				}
				if(row["ohrq"]!=null)
				{
					model.ohrq=row["ohrq"].ToString();
				}
				if(row["ohbc"]!=null)
				{
					model.ohbc=row["ohbc"].ToString();
				}
				if(row["cjybl"]!=null && row["cjybl"].ToString()!="")
				{
					model.cjybl=int.Parse(row["cjybl"].ToString());
				}
				if(row["gjwx"]!=null)
				{
					model.gjwx=row["gjwx"].ToString();
				}
				if(row["other"]!=null)
				{
					model.other=row["other"].ToString();
				}
				if(row["checkcondition"]!=null)
				{
					model.checkcondition=row["checkcondition"].ToString();
				}
				if(row["cybz"]!=null)
				{
					model.cybz=row["cybz"].ToString();
				}
				if(row["aql"]!=null)
				{
					model.aql=row["aql"].ToString();
				}
				if(row["qjyn"]!=null && row["qjyn"].ToString()!="")
				{
					if((row["qjyn"].ToString()=="1")||(row["qjyn"].ToString().ToLower()=="true"))
					{
						model.qjyn=true;
					}
					else
					{
						model.qjyn=false;
					}
				}
				if(row["okrate"]!=null && row["okrate"].ToString()!="")
				{
					model.okrate=int.Parse(row["okrate"].ToString());
				}
				if(row["wg_jyyjbz"]!=null)
				{
					model.wg_jyyjbz=row["wg_jyyjbz"].ToString();
				}
				if(row["wg_cjybsl"]!=null && row["wg_cjybsl"].ToString()!="")
				{
					model.wg_cjybsl=int.Parse(row["wg_cjybsl"].ToString());
				}
				if(row["wg_okng"]!=null)
				{
					model.wg_okng=row["wg_okng"].ToString();
				}
				if(row["wg_sign"]!=null)
				{
					model.wg_sign=row["wg_sign"].ToString();
				}
				if(row["wg_ngindex"]!=null)
				{
					model.wg_ngindex=row["wg_ngindex"].ToString();
				}
				if(row["bs_okng"]!=null)
				{
					model.bs_okng=row["bs_okng"].ToString();
				}
				if(row["bs_sign"]!=null)
				{
					model.bs_sign=row["bs_sign"].ToString();
				}
				if(row["bs_ngindex"]!=null)
				{
					model.bs_ngindex=row["bs_ngindex"].ToString();
				}
				if(row["bz_okng"]!=null)
				{
					model.bz_okng=row["bz_okng"].ToString();
				}
				if(row["bz_sign"]!=null)
				{
					model.bz_sign=row["bz_sign"].ToString();
				}
				if(row["bz_ngindex"]!=null)
				{
					model.bz_ngindex=row["bz_ngindex"].ToString();
				}
				if(row["report"]!=null)
				{
					model.report=row["report"].ToString();
				}
				if(row["report_sign"]!=null)
				{
					model.report_sign=row["report_sign"].ToString();
				}
				if(row["ngdescription"]!=null)
				{
					model.ngdescription=row["ngdescription"].ToString();
				}
				if(row["checkjg"]!=null)
				{
					model.checkjg=row["checkjg"].ToString();
				}
				if(row["checker"]!=null)
				{
					model.checker=row["checker"].ToString();
				}
				if(row["checkertime"]!=null && row["checkertime"].ToString()!="")
				{
					model.checkertime=DateTime.Parse(row["checkertime"].ToString());
				}
				if(row["groupleader"]!=null)
				{
					model.groupleader=row["groupleader"].ToString();
				}
				if(row["grouptime"]!=null && row["grouptime"].ToString()!="")
				{
					model.grouptime=DateTime.Parse(row["grouptime"].ToString());
				}
				if(row["remarks"]!=null)
				{
					model.remarks=row["remarks"].ToString();
				}
				if(row["ggsbh"]!=null)
				{
					model.ggsbh=row["ggsbh"].ToString();
				}
				if(row["check1name"]!=null)
				{
					model.check1name=row["check1name"].ToString();
				}
				if(row["check1value"]!=null && row["check1value"].ToString()!="")
				{
					model.check1value=decimal.Parse(row["check1value"].ToString());
				}
				if(row["check1result"]!=null)
				{
					model.check1result=row["check1result"].ToString();
				}
				if(row["check1bz"]!=null)
				{
					model.check1bz=row["check1bz"].ToString();
				}
				if(row["check2name"]!=null)
				{
					model.check2name=row["check2name"].ToString();
				}
				if(row["check2value"]!=null && row["check2value"].ToString()!="")
				{
					model.check2value=decimal.Parse(row["check2value"].ToString());
				}
				if(row["check2result"]!=null)
				{
					model.check2result=row["check2result"].ToString();
				}
				if(row["check2bz"]!=null)
				{
					model.check2bz=row["check2bz"].ToString();
				}
				if(row["check3name"]!=null)
				{
					model.check3name=row["check3name"].ToString();
				}
				if(row["check3value"]!=null && row["check3value"].ToString()!="")
				{
					model.check3value=decimal.Parse(row["check3value"].ToString());
				}
				if(row["check3result"]!=null)
				{
					model.check3result=row["check3result"].ToString();
				}
				if(row["check3bz"]!=null)
				{
					model.check3bz=row["check3bz"].ToString();
				}
				if(row["check4name"]!=null)
				{
					model.check4name=row["check4name"].ToString();
				}
				if(row["check4value"]!=null && row["check4value"].ToString()!="")
				{
					model.check4value=decimal.Parse(row["check4value"].ToString());
				}
				if(row["check4result"]!=null)
				{
					model.check4result=row["check4result"].ToString();
				}
				if(row["check4bz"]!=null)
				{
					model.check4bz=row["check4bz"].ToString();
				}
				if(row["check5name"]!=null)
				{
					model.check5name=row["check5name"].ToString();
				}
				if(row["check5value"]!=null && row["check5value"].ToString()!="")
				{
					model.check5value=decimal.Parse(row["check5value"].ToString());
				}
				if(row["check5result"]!=null)
				{
					model.check5result=row["check5result"].ToString();
				}
				if(row["check5bz"]!=null)
				{
					model.check5bz=row["check5bz"].ToString();
				}
				if(row["check6name"]!=null)
				{
					model.check6name=row["check6name"].ToString();
				}
				if(row["check6value"]!=null && row["check6value"].ToString()!="")
				{
					model.check6value=decimal.Parse(row["check6value"].ToString());
				}
				if(row["check6result"]!=null)
				{
					model.check6result=row["check6result"].ToString();
				}
				if(row["check6bz"]!=null)
				{
					model.check6bz=row["check6bz"].ToString();
				}
				if(row["check7name"]!=null)
				{
					model.check7name=row["check7name"].ToString();
				}
				if(row["check7value"]!=null && row["check7value"].ToString()!="")
				{
					model.check7value=decimal.Parse(row["check7value"].ToString());
				}
				if(row["check7result"]!=null)
				{
					model.check7result=row["check7result"].ToString();
				}
				if(row["check7bz"]!=null)
				{
					model.check7bz=row["check7bz"].ToString();
				}
				if(row["recorder"]!=null)
				{
					model.recorder=row["recorder"].ToString();
				}
				if(row["recordtime"]!=null && row["recordtime"].ToString()!="")
				{
					model.recordtime=DateTime.Parse(row["recordtime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,wlbm,ggxhbc,gm,gwpl,sulv,ohrq,ohbc,cjybl,gjwx,other,checkcondition,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,check1name,check1value,check1result,check1bz,check2name,check2value,check2result,check2bz,check3name,check3value,check3result,check3bz,check4name,check4value,check4result,check4bz,check5name,check5value,check5result,check5bz,check6name,check6value,check6result,check6bz,check7name,check7value,check7result,check7bz,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_pdptl ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,wlbm,ggxhbc,gm,gwpl,sulv,ohrq,ohbc,cjybl,gjwx,other,checkcondition,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,check1name,check1value,check1result,check1bz,check2name,check2value,check2result,check2bz,check3name,check3value,check3result,check3bz,check4name,check4value,check4result,check4bz,check5name,check5value,check5result,check5bz,check6name,check6value,check6result,check6bz,check7name,check7value,check7result,check7bz,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_pdptl ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tsuhan_scgl_iqc_pdptl ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.pch desc");
			}
			strSql.Append(")AS Row, T.*  from tsuhan_scgl_iqc_pdptl T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tsuhan_scgl_iqc_pdptl";
			parameters[1].Value = "pch";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

