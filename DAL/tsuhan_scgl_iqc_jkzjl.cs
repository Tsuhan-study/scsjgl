﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_scgl_iqc_jkzjl
	/// </summary>
	public partial class tsuhan_scgl_iqc_jkzjl
	{
		public tsuhan_scgl_iqc_jkzjl()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string pch)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tsuhan_scgl_iqc_jkzjl");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.NChar,30)			};
			parameters[0].Value = pch;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_scgl_iqc_jkzjl model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_scgl_iqc_jkzjl(");
			strSql.Append("id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,wlbm,ggxhbc,pcsl,cjybl,other,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,check1name,check1value,check1result,check2name,check2value,check2result,check3name,check3value,check3result,check4name,check4value,check4result,check5name,check5value,check5result,check6name,check6value,check6result,check7name,check7value,check7result,check8name,check8value,check8result,check9name,check9value,check9result,check10name,check10value,check10result,check11name,check11value,check11result,recorder,recordtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@pch,@jylx,@gysdm,@rkdh,@dhrq,@sl,@wlmc,@wlbm,@ggxhbc,@pcsl,@cjybl,@other,@cybz,@aql,@qjyn,@okrate,@wg_jyyjbz,@wg_cjybsl,@wg_okng,@wg_sign,@wg_ngindex,@bs_okng,@bs_sign,@bs_ngindex,@bz_okng,@bz_sign,@bz_ngindex,@report,@report_sign,@ngdescription,@checkjg,@checker,@checkertime,@groupleader,@grouptime,@remarks,@ggsbh,@check1name,@check1value,@check1result,@check2name,@check2value,@check2result,@check3name,@check3value,@check3result,@check4name,@check4value,@check4result,@check5name,@check5value,@check5result,@check6name,@check6value,@check6result,@check7name,@check7value,@check7result,@check8name,@check8value,@check8result,@check9name,@check9value,@check9result,@check10name,@check10value,@check10result,@check11name,@check11value,@check11result,@recorder,@recordtime)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pch", SqlDbType.NChar,30),
					new SqlParameter("@jylx", SqlDbType.NChar,30),
					new SqlParameter("@gysdm", SqlDbType.NChar,30),
					new SqlParameter("@rkdh", SqlDbType.NChar,30),
					new SqlParameter("@dhrq", SqlDbType.NChar,30),
					new SqlParameter("@sl", SqlDbType.Int,4),
					new SqlParameter("@wlmc", SqlDbType.NChar,30),
					new SqlParameter("@wlbm", SqlDbType.NChar,30),
					new SqlParameter("@ggxhbc", SqlDbType.NChar,30),
					new SqlParameter("@pcsl", SqlDbType.Int,4),
					new SqlParameter("@cjybl", SqlDbType.Int,4),
					new SqlParameter("@other", SqlDbType.NChar,30),
					new SqlParameter("@cybz", SqlDbType.NChar,100),
					new SqlParameter("@aql", SqlDbType.NChar,30),
					new SqlParameter("@qjyn", SqlDbType.Bit,1),
					new SqlParameter("@okrate", SqlDbType.Float,8),
					new SqlParameter("@wg_jyyjbz", SqlDbType.NChar,100),
					new SqlParameter("@wg_cjybsl", SqlDbType.Int,4),
					new SqlParameter("@wg_okng", SqlDbType.NChar,10),
					new SqlParameter("@wg_sign", SqlDbType.NChar,10),
					new SqlParameter("@wg_ngindex", SqlDbType.NChar,200),
					new SqlParameter("@bs_okng", SqlDbType.NChar,10),
					new SqlParameter("@bs_sign", SqlDbType.NChar,10),
					new SqlParameter("@bs_ngindex", SqlDbType.NChar,200),
					new SqlParameter("@bz_okng", SqlDbType.NChar,10),
					new SqlParameter("@bz_sign", SqlDbType.NChar,10),
					new SqlParameter("@bz_ngindex", SqlDbType.NChar,200),
					new SqlParameter("@report", SqlDbType.NChar,200),
					new SqlParameter("@report_sign", SqlDbType.NChar,10),
					new SqlParameter("@ngdescription", SqlDbType.NChar,500),
					new SqlParameter("@checkjg", SqlDbType.NChar,300),
					new SqlParameter("@checker", SqlDbType.NChar,10),
					new SqlParameter("@checkertime", SqlDbType.DateTime),
					new SqlParameter("@groupleader", SqlDbType.NChar,10),
					new SqlParameter("@grouptime", SqlDbType.DateTime),
					new SqlParameter("@remarks", SqlDbType.NChar,10),
					new SqlParameter("@ggsbh", SqlDbType.NChar,10),
					new SqlParameter("@check1name", SqlDbType.NChar,20),
					new SqlParameter("@check1value", SqlDbType.NChar,10),
					new SqlParameter("@check1result", SqlDbType.NChar,10),
					new SqlParameter("@check2name", SqlDbType.NChar,20),
					new SqlParameter("@check2value", SqlDbType.NChar,10),
					new SqlParameter("@check2result", SqlDbType.NChar,10),
					new SqlParameter("@check3name", SqlDbType.NChar,20),
					new SqlParameter("@check3value", SqlDbType.NChar,10),
					new SqlParameter("@check3result", SqlDbType.NChar,10),
					new SqlParameter("@check4name", SqlDbType.NChar,20),
					new SqlParameter("@check4value", SqlDbType.NChar,10),
					new SqlParameter("@check4result", SqlDbType.NChar,10),
					new SqlParameter("@check5name", SqlDbType.NChar,20),
					new SqlParameter("@check5value", SqlDbType.NChar,10),
					new SqlParameter("@check5result", SqlDbType.NChar,10),
					new SqlParameter("@check6name", SqlDbType.NChar,20),
					new SqlParameter("@check6value", SqlDbType.NChar,10),
					new SqlParameter("@check6result", SqlDbType.NChar,10),
					new SqlParameter("@check7name", SqlDbType.NChar,20),
					new SqlParameter("@check7value", SqlDbType.NChar,10),
					new SqlParameter("@check7result", SqlDbType.NChar,10),
					new SqlParameter("@check8name", SqlDbType.NChar,20),
					new SqlParameter("@check8value", SqlDbType.NChar,10),
					new SqlParameter("@check8result", SqlDbType.NChar,10),
					new SqlParameter("@check9name", SqlDbType.NChar,20),
					new SqlParameter("@check9value", SqlDbType.NChar,10),
					new SqlParameter("@check9result", SqlDbType.NChar,10),
					new SqlParameter("@check10name", SqlDbType.NChar,20),
					new SqlParameter("@check10value", SqlDbType.NChar,10),
					new SqlParameter("@check10result", SqlDbType.NChar,10),
					new SqlParameter("@check11name", SqlDbType.NChar,20),
					new SqlParameter("@check11value", SqlDbType.NChar,10),
					new SqlParameter("@check11result", SqlDbType.NChar,10),
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
			parameters[10].Value = model.pcsl;
			parameters[11].Value = model.cjybl;
			parameters[12].Value = model.other;
			parameters[13].Value = model.cybz;
			parameters[14].Value = model.aql;
			parameters[15].Value = model.qjyn;
			parameters[16].Value = model.okrate;
			parameters[17].Value = model.wg_jyyjbz;
			parameters[18].Value = model.wg_cjybsl;
			parameters[19].Value = model.wg_okng;
			parameters[20].Value = model.wg_sign;
			parameters[21].Value = model.wg_ngindex;
			parameters[22].Value = model.bs_okng;
			parameters[23].Value = model.bs_sign;
			parameters[24].Value = model.bs_ngindex;
			parameters[25].Value = model.bz_okng;
			parameters[26].Value = model.bz_sign;
			parameters[27].Value = model.bz_ngindex;
			parameters[28].Value = model.report;
			parameters[29].Value = model.report_sign;
			parameters[30].Value = model.ngdescription;
			parameters[31].Value = model.checkjg;
			parameters[32].Value = model.checker;
			parameters[33].Value = model.checkertime;
			parameters[34].Value = model.groupleader;
			parameters[35].Value = model.grouptime;
			parameters[36].Value = model.remarks;
			parameters[37].Value = model.ggsbh;
			parameters[38].Value = model.check1name;
			parameters[39].Value = model.check1value;
			parameters[40].Value = model.check1result;
			parameters[41].Value = model.check2name;
			parameters[42].Value = model.check2value;
			parameters[43].Value = model.check2result;
			parameters[44].Value = model.check3name;
			parameters[45].Value = model.check3value;
			parameters[46].Value = model.check3result;
			parameters[47].Value = model.check4name;
			parameters[48].Value = model.check4value;
			parameters[49].Value = model.check4result;
			parameters[50].Value = model.check5name;
			parameters[51].Value = model.check5value;
			parameters[52].Value = model.check5result;
			parameters[53].Value = model.check6name;
			parameters[54].Value = model.check6value;
			parameters[55].Value = model.check6result;
			parameters[56].Value = model.check7name;
			parameters[57].Value = model.check7value;
			parameters[58].Value = model.check7result;
			parameters[59].Value = model.check8name;
			parameters[60].Value = model.check8value;
			parameters[61].Value = model.check8result;
			parameters[62].Value = model.check9name;
			parameters[63].Value = model.check9value;
			parameters[64].Value = model.check9result;
			parameters[65].Value = model.check10name;
			parameters[66].Value = model.check10value;
			parameters[67].Value = model.check10result;
			parameters[68].Value = model.check11name;
			parameters[69].Value = model.check11value;
			parameters[70].Value = model.check11result;
			parameters[71].Value = model.recorder;
			parameters[72].Value = model.recordtime;

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
		public bool Update(Maticsoft.Model.tsuhan_scgl_iqc_jkzjl model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_scgl_iqc_jkzjl set ");
			strSql.Append("id=@id,");
			strSql.Append("jylx=@jylx,");
			strSql.Append("gysdm=@gysdm,");
			strSql.Append("rkdh=@rkdh,");
			strSql.Append("dhrq=@dhrq,");
			strSql.Append("sl=@sl,");
			strSql.Append("wlmc=@wlmc,");
			strSql.Append("wlbm=@wlbm,");
			strSql.Append("ggxhbc=@ggxhbc,");
			strSql.Append("pcsl=@pcsl,");
			strSql.Append("cjybl=@cjybl,");
			strSql.Append("other=@other,");
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
			strSql.Append("check2name=@check2name,");
			strSql.Append("check2value=@check2value,");
			strSql.Append("check2result=@check2result,");
			strSql.Append("check3name=@check3name,");
			strSql.Append("check3value=@check3value,");
			strSql.Append("check3result=@check3result,");
			strSql.Append("check4name=@check4name,");
			strSql.Append("check4value=@check4value,");
			strSql.Append("check4result=@check4result,");
			strSql.Append("check5name=@check5name,");
			strSql.Append("check5value=@check5value,");
			strSql.Append("check5result=@check5result,");
			strSql.Append("check6name=@check6name,");
			strSql.Append("check6value=@check6value,");
			strSql.Append("check6result=@check6result,");
			strSql.Append("check7name=@check7name,");
			strSql.Append("check7value=@check7value,");
			strSql.Append("check7result=@check7result,");
			strSql.Append("check8name=@check8name,");
			strSql.Append("check8value=@check8value,");
			strSql.Append("check8result=@check8result,");
			strSql.Append("check9name=@check9name,");
			strSql.Append("check9value=@check9value,");
			strSql.Append("check9result=@check9result,");
			strSql.Append("check10name=@check10name,");
			strSql.Append("check10value=@check10value,");
			strSql.Append("check10result=@check10result,");
			strSql.Append("check11name=@check11name,");
			strSql.Append("check11value=@check11value,");
			strSql.Append("check11result=@check11result,");
			strSql.Append("recorder=@recorder");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@jylx", SqlDbType.NChar,30),
					new SqlParameter("@gysdm", SqlDbType.NChar,30),
					new SqlParameter("@rkdh", SqlDbType.NChar,30),
					new SqlParameter("@dhrq", SqlDbType.NChar,30),
					new SqlParameter("@sl", SqlDbType.Int,4),
					new SqlParameter("@wlmc", SqlDbType.NChar,30),
					new SqlParameter("@wlbm", SqlDbType.NChar,30),
					new SqlParameter("@ggxhbc", SqlDbType.NChar,30),
					new SqlParameter("@pcsl", SqlDbType.Int,4),
					new SqlParameter("@cjybl", SqlDbType.Int,4),
					new SqlParameter("@other", SqlDbType.NChar,30),
					new SqlParameter("@cybz", SqlDbType.NChar,100),
					new SqlParameter("@aql", SqlDbType.NChar,30),
					new SqlParameter("@qjyn", SqlDbType.Bit,1),
					new SqlParameter("@okrate", SqlDbType.Float,8),
					new SqlParameter("@wg_jyyjbz", SqlDbType.NChar,100),
					new SqlParameter("@wg_cjybsl", SqlDbType.Int,4),
					new SqlParameter("@wg_okng", SqlDbType.NChar,10),
					new SqlParameter("@wg_sign", SqlDbType.NChar,10),
					new SqlParameter("@wg_ngindex", SqlDbType.NChar,200),
					new SqlParameter("@bs_okng", SqlDbType.NChar,10),
					new SqlParameter("@bs_sign", SqlDbType.NChar,10),
					new SqlParameter("@bs_ngindex", SqlDbType.NChar,200),
					new SqlParameter("@bz_okng", SqlDbType.NChar,10),
					new SqlParameter("@bz_sign", SqlDbType.NChar,10),
					new SqlParameter("@bz_ngindex", SqlDbType.NChar,200),
					new SqlParameter("@report", SqlDbType.NChar,200),
					new SqlParameter("@report_sign", SqlDbType.NChar,10),
					new SqlParameter("@ngdescription", SqlDbType.NChar,500),
					new SqlParameter("@checkjg", SqlDbType.NChar,300),
					new SqlParameter("@checker", SqlDbType.NChar,10),
					new SqlParameter("@checkertime", SqlDbType.DateTime),
					new SqlParameter("@groupleader", SqlDbType.NChar,10),
					new SqlParameter("@grouptime", SqlDbType.DateTime),
					new SqlParameter("@remarks", SqlDbType.NChar,10),
					new SqlParameter("@ggsbh", SqlDbType.NChar,10),
					new SqlParameter("@check1name", SqlDbType.NChar,20),
					new SqlParameter("@check1value", SqlDbType.NChar,10),
					new SqlParameter("@check1result", SqlDbType.NChar,10),
					new SqlParameter("@check2name", SqlDbType.NChar,20),
					new SqlParameter("@check2value", SqlDbType.NChar,10),
					new SqlParameter("@check2result", SqlDbType.NChar,10),
					new SqlParameter("@check3name", SqlDbType.NChar,20),
					new SqlParameter("@check3value", SqlDbType.NChar,10),
					new SqlParameter("@check3result", SqlDbType.NChar,10),
					new SqlParameter("@check4name", SqlDbType.NChar,20),
					new SqlParameter("@check4value", SqlDbType.NChar,10),
					new SqlParameter("@check4result", SqlDbType.NChar,10),
					new SqlParameter("@check5name", SqlDbType.NChar,20),
					new SqlParameter("@check5value", SqlDbType.NChar,10),
					new SqlParameter("@check5result", SqlDbType.NChar,10),
					new SqlParameter("@check6name", SqlDbType.NChar,20),
					new SqlParameter("@check6value", SqlDbType.NChar,10),
					new SqlParameter("@check6result", SqlDbType.NChar,10),
					new SqlParameter("@check7name", SqlDbType.NChar,20),
					new SqlParameter("@check7value", SqlDbType.NChar,10),
					new SqlParameter("@check7result", SqlDbType.NChar,10),
					new SqlParameter("@check8name", SqlDbType.NChar,20),
					new SqlParameter("@check8value", SqlDbType.NChar,10),
					new SqlParameter("@check8result", SqlDbType.NChar,10),
					new SqlParameter("@check9name", SqlDbType.NChar,20),
					new SqlParameter("@check9value", SqlDbType.NChar,10),
					new SqlParameter("@check9result", SqlDbType.NChar,10),
					new SqlParameter("@check10name", SqlDbType.NChar,20),
					new SqlParameter("@check10value", SqlDbType.NChar,10),
					new SqlParameter("@check10result", SqlDbType.NChar,10),
					new SqlParameter("@check11name", SqlDbType.NChar,20),
					new SqlParameter("@check11value", SqlDbType.NChar,10),
					new SqlParameter("@check11result", SqlDbType.NChar,10),
					new SqlParameter("@recorder", SqlDbType.NChar,10),
					new SqlParameter("@pch", SqlDbType.NChar,30)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.jylx;
			parameters[2].Value = model.gysdm;
			parameters[3].Value = model.rkdh;
			parameters[4].Value = model.dhrq;
			parameters[5].Value = model.sl;
			parameters[6].Value = model.wlmc;
			parameters[7].Value = model.wlbm;
			parameters[8].Value = model.ggxhbc;
			parameters[9].Value = model.pcsl;
			parameters[10].Value = model.cjybl;
			parameters[11].Value = model.other;
			parameters[12].Value = model.cybz;
			parameters[13].Value = model.aql;
			parameters[14].Value = model.qjyn;
			parameters[15].Value = model.okrate;
			parameters[16].Value = model.wg_jyyjbz;
			parameters[17].Value = model.wg_cjybsl;
			parameters[18].Value = model.wg_okng;
			parameters[19].Value = model.wg_sign;
			parameters[20].Value = model.wg_ngindex;
			parameters[21].Value = model.bs_okng;
			parameters[22].Value = model.bs_sign;
			parameters[23].Value = model.bs_ngindex;
			parameters[24].Value = model.bz_okng;
			parameters[25].Value = model.bz_sign;
			parameters[26].Value = model.bz_ngindex;
			parameters[27].Value = model.report;
			parameters[28].Value = model.report_sign;
			parameters[29].Value = model.ngdescription;
			parameters[30].Value = model.checkjg;
			parameters[31].Value = model.checker;
			parameters[32].Value = model.checkertime;
			parameters[33].Value = model.groupleader;
			parameters[34].Value = model.grouptime;
			parameters[35].Value = model.remarks;
			parameters[36].Value = model.ggsbh;
			parameters[37].Value = model.check1name;
			parameters[38].Value = model.check1value;
			parameters[39].Value = model.check1result;
			parameters[40].Value = model.check2name;
			parameters[41].Value = model.check2value;
			parameters[42].Value = model.check2result;
			parameters[43].Value = model.check3name;
			parameters[44].Value = model.check3value;
			parameters[45].Value = model.check3result;
			parameters[46].Value = model.check4name;
			parameters[47].Value = model.check4value;
			parameters[48].Value = model.check4result;
			parameters[49].Value = model.check5name;
			parameters[50].Value = model.check5value;
			parameters[51].Value = model.check5result;
			parameters[52].Value = model.check6name;
			parameters[53].Value = model.check6value;
			parameters[54].Value = model.check6result;
			parameters[55].Value = model.check7name;
			parameters[56].Value = model.check7value;
			parameters[57].Value = model.check7result;
			parameters[58].Value = model.check8name;
			parameters[59].Value = model.check8value;
			parameters[60].Value = model.check8result;
			parameters[61].Value = model.check9name;
			parameters[62].Value = model.check9value;
			parameters[63].Value = model.check9result;
			parameters[64].Value = model.check10name;
			parameters[65].Value = model.check10value;
			parameters[66].Value = model.check10result;
			parameters[67].Value = model.check11name;
			parameters[68].Value = model.check11value;
			parameters[69].Value = model.check11result;
			parameters[70].Value = model.recorder;
			parameters[71].Value = model.pch;

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
			strSql.Append("delete from tsuhan_scgl_iqc_jkzjl ");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.NChar,30)			};
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
			strSql.Append("delete from tsuhan_scgl_iqc_jkzjl ");
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
		public Maticsoft.Model.tsuhan_scgl_iqc_jkzjl GetModel(string pch)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,wlbm,ggxhbc,pcsl,cjybl,other,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,check1name,check1value,check1result,check2name,check2value,check2result,check3name,check3value,check3result,check4name,check4value,check4result,check5name,check5value,check5result,check6name,check6value,check6result,check7name,check7value,check7result,check8name,check8value,check8result,check9name,check9value,check9result,check10name,check10value,check10result,check11name,check11value,check11result,recorder,recordtime from tsuhan_scgl_iqc_jkzjl ");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.NChar,30)			};
			parameters[0].Value = pch;

			Maticsoft.Model.tsuhan_scgl_iqc_jkzjl model=new Maticsoft.Model.tsuhan_scgl_iqc_jkzjl();
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
		public Maticsoft.Model.tsuhan_scgl_iqc_jkzjl DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_scgl_iqc_jkzjl model=new Maticsoft.Model.tsuhan_scgl_iqc_jkzjl();
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
				if(row["pcsl"]!=null && row["pcsl"].ToString()!="")
				{
					model.pcsl=int.Parse(row["pcsl"].ToString());
				}
				if(row["cjybl"]!=null && row["cjybl"].ToString()!="")
				{
					model.cjybl=int.Parse(row["cjybl"].ToString());
				}
				if(row["other"]!=null)
				{
					model.other=row["other"].ToString();
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
					model.okrate=decimal.Parse(row["okrate"].ToString());
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
				if(row["check1value"]!=null)
				{
					model.check1value=row["check1value"].ToString();
				}
				if(row["check1result"]!=null)
				{
					model.check1result=row["check1result"].ToString();
				}
				if(row["check2name"]!=null)
				{
					model.check2name=row["check2name"].ToString();
				}
				if(row["check2value"]!=null)
				{
					model.check2value=row["check2value"].ToString();
				}
				if(row["check2result"]!=null)
				{
					model.check2result=row["check2result"].ToString();
				}
				if(row["check3name"]!=null)
				{
					model.check3name=row["check3name"].ToString();
				}
				if(row["check3value"]!=null)
				{
					model.check3value=row["check3value"].ToString();
				}
				if(row["check3result"]!=null)
				{
					model.check3result=row["check3result"].ToString();
				}
				if(row["check4name"]!=null)
				{
					model.check4name=row["check4name"].ToString();
				}
				if(row["check4value"]!=null)
				{
					model.check4value=row["check4value"].ToString();
				}
				if(row["check4result"]!=null)
				{
					model.check4result=row["check4result"].ToString();
				}
				if(row["check5name"]!=null)
				{
					model.check5name=row["check5name"].ToString();
				}
				if(row["check5value"]!=null)
				{
					model.check5value=row["check5value"].ToString();
				}
				if(row["check5result"]!=null)
				{
					model.check5result=row["check5result"].ToString();
				}
				if(row["check6name"]!=null)
				{
					model.check6name=row["check6name"].ToString();
				}
				if(row["check6value"]!=null)
				{
					model.check6value=row["check6value"].ToString();
				}
				if(row["check6result"]!=null)
				{
					model.check6result=row["check6result"].ToString();
				}
				if(row["check7name"]!=null)
				{
					model.check7name=row["check7name"].ToString();
				}
				if(row["check7value"]!=null)
				{
					model.check7value=row["check7value"].ToString();
				}
				if(row["check7result"]!=null)
				{
					model.check7result=row["check7result"].ToString();
				}
				if(row["check8name"]!=null)
				{
					model.check8name=row["check8name"].ToString();
				}
				if(row["check8value"]!=null)
				{
					model.check8value=row["check8value"].ToString();
				}
				if(row["check8result"]!=null)
				{
					model.check8result=row["check8result"].ToString();
				}
				if(row["check9name"]!=null)
				{
					model.check9name=row["check9name"].ToString();
				}
				if(row["check9value"]!=null)
				{
					model.check9value=row["check9value"].ToString();
				}
				if(row["check9result"]!=null)
				{
					model.check9result=row["check9result"].ToString();
				}
				if(row["check10name"]!=null)
				{
					model.check10name=row["check10name"].ToString();
				}
				if(row["check10value"]!=null)
				{
					model.check10value=row["check10value"].ToString();
				}
				if(row["check10result"]!=null)
				{
					model.check10result=row["check10result"].ToString();
				}
				if(row["check11name"]!=null)
				{
					model.check11name=row["check11name"].ToString();
				}
				if(row["check11value"]!=null)
				{
					model.check11value=row["check11value"].ToString();
				}
				if(row["check11result"]!=null)
				{
					model.check11result=row["check11result"].ToString();
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
			strSql.Append("select id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,wlbm,ggxhbc,pcsl,cjybl,other,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,check1name,check1value,check1result,check2name,check2value,check2result,check3name,check3value,check3result,check4name,check4value,check4result,check5name,check5value,check5result,check6name,check6value,check6result,check7name,check7value,check7result,check8name,check8value,check8result,check9name,check9value,check9result,check10name,check10value,check10result,check11name,check11value,check11result,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_jkzjl ");
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
			strSql.Append(" id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,wlbm,ggxhbc,pcsl,cjybl,other,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,check1name,check1value,check1result,check2name,check2value,check2result,check3name,check3value,check3result,check4name,check4value,check4result,check5name,check5value,check5result,check6name,check6value,check6result,check7name,check7value,check7result,check8name,check8value,check8result,check9name,check9value,check9result,check10name,check10value,check10result,check11name,check11value,check11result,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_jkzjl ");
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
			strSql.Append("select count(1) FROM tsuhan_scgl_iqc_jkzjl ");
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
			strSql.Append(")AS Row, T.*  from tsuhan_scgl_iqc_jkzjl T ");
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
			parameters[0].Value = "tsuhan_scgl_iqc_jkzjl";
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
