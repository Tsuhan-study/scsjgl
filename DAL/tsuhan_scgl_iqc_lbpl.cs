using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_scgl_iqc_lbpl
	/// </summary>
	public partial class tsuhan_scgl_iqc_lbpl
	{
		public tsuhan_scgl_iqc_lbpl()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string pch)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tsuhan_scgl_iqc_lbpl");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.Char,30)			};
			parameters[0].Value = pch;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_scgl_iqc_lbpl model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tsuhan_scgl_iqc_lbpl(");
			strSql.Append("id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,thbc,xh,chic,wlbm,cjybl,fsmfz,other,cstj,cstjxpxh,cstjgwpl,cstjxpbc,cstjsulv,cstjdl,cstjgl,cstjjju,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,pch2,model1bc,model2bc,model3bc,p1,tgp1,fsp1,xl1,p2,tgp2,fsp2,xl2,p3,tgp3,fsp3,xl3,recorder,recordtime)");
			strSql.Append(" values (");
			strSql.Append("@id,@pch,@jylx,@gysdm,@rkdh,@dhrq,@sl,@wlmc,@thbc,@xh,@chic,@wlbm,@cjybl,@fsmfz,@other,@cstj,@cstjxpxh,@cstjgwpl,@cstjxpbc,@cstjsulv,@cstjdl,@cstjgl,@cstjjju,@cybz,@aql,@qjyn,@okrate,@wg_jyyjbz,@wg_cjybsl,@wg_okng,@wg_sign,@wg_ngindex,@bs_okng,@bs_sign,@bs_ngindex,@bz_okng,@bz_sign,@bz_ngindex,@report,@report_sign,@ngdescription,@checkjg,@checker,@checkertime,@groupleader,@grouptime,@remarks,@ggsbh,@pch2,@model1bc,@model2bc,@model3bc,@p1,@tgp1,@fsp1,@xl1,@p2,@tgp2,@fsp2,@xl2,@p3,@tgp3,@fsp3,@xl3,@recorder,@recordtime)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pch", SqlDbType.Char,30),
					new SqlParameter("@jylx", SqlDbType.Char,30),
					new SqlParameter("@gysdm", SqlDbType.Char,30),
					new SqlParameter("@rkdh", SqlDbType.Char,30),
					new SqlParameter("@dhrq", SqlDbType.Char,30),
					new SqlParameter("@sl", SqlDbType.Int,4),
					new SqlParameter("@wlmc", SqlDbType.Char,30),
					new SqlParameter("@thbc", SqlDbType.Char,30),
					new SqlParameter("@xh", SqlDbType.Char,30),
					new SqlParameter("@chic", SqlDbType.Char,10),
					new SqlParameter("@wlbm", SqlDbType.Char,30),
					new SqlParameter("@cjybl", SqlDbType.Int,4),
					new SqlParameter("@fsmfz", SqlDbType.Char,100),
					new SqlParameter("@other", SqlDbType.Char,30),
					new SqlParameter("@cstj", SqlDbType.Char,50),
					new SqlParameter("@cstjxpxh", SqlDbType.Char,30),
					new SqlParameter("@cstjgwpl", SqlDbType.Char,10),
					new SqlParameter("@cstjxpbc", SqlDbType.Char,10),
					new SqlParameter("@cstjsulv", SqlDbType.Char,10),
					new SqlParameter("@cstjdl", SqlDbType.Char,10),
					new SqlParameter("@cstjgl", SqlDbType.Char,10),
					new SqlParameter("@cstjjju", SqlDbType.Char,10),
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
					new SqlParameter("@pch2", SqlDbType.NChar,10),
					new SqlParameter("@model1bc", SqlDbType.NChar,10),
					new SqlParameter("@model2bc", SqlDbType.NChar,10),
					new SqlParameter("@model3bc", SqlDbType.NChar,10),
					new SqlParameter("@p1", SqlDbType.Float,8),
					new SqlParameter("@tgp1", SqlDbType.Float,8),
					new SqlParameter("@fsp1", SqlDbType.Float,8),
					new SqlParameter("@xl1", SqlDbType.Float,8),
					new SqlParameter("@p2", SqlDbType.Float,8),
					new SqlParameter("@tgp2", SqlDbType.Float,8),
					new SqlParameter("@fsp2", SqlDbType.Float,8),
					new SqlParameter("@xl2", SqlDbType.Float,8),
					new SqlParameter("@p3", SqlDbType.Float,8),
					new SqlParameter("@tgp3", SqlDbType.Float,8),
					new SqlParameter("@fsp3", SqlDbType.Float,8),
					new SqlParameter("@xl3", SqlDbType.Float,8),
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
			parameters[8].Value = model.thbc;
			parameters[9].Value = model.xh;
			parameters[10].Value = model.chic;
			parameters[11].Value = model.wlbm;
			parameters[12].Value = model.cjybl;
			parameters[13].Value = model.fsmfz;
			parameters[14].Value = model.other;
			parameters[15].Value = model.cstj;
			parameters[16].Value = model.cstjxpxh;
			parameters[17].Value = model.cstjgwpl;
			parameters[18].Value = model.cstjxpbc;
			parameters[19].Value = model.cstjsulv;
			parameters[20].Value = model.cstjdl;
			parameters[21].Value = model.cstjgl;
			parameters[22].Value = model.cstjjju;
			parameters[23].Value = model.cybz;
			parameters[24].Value = model.aql;
			parameters[25].Value = model.qjyn;
			parameters[26].Value = model.okrate;
			parameters[27].Value = model.wg_jyyjbz;
			parameters[28].Value = model.wg_cjybsl;
			parameters[29].Value = model.wg_okng;
			parameters[30].Value = model.wg_sign;
			parameters[31].Value = model.wg_ngindex;
			parameters[32].Value = model.bs_okng;
			parameters[33].Value = model.bs_sign;
			parameters[34].Value = model.bs_ngindex;
			parameters[35].Value = model.bz_okng;
			parameters[36].Value = model.bz_sign;
			parameters[37].Value = model.bz_ngindex;
			parameters[38].Value = model.report;
			parameters[39].Value = model.report_sign;
			parameters[40].Value = model.ngdescription;
			parameters[41].Value = model.checkjg;
			parameters[42].Value = model.checker;
			parameters[43].Value = model.checkertime;
			parameters[44].Value = model.groupleader;
			parameters[45].Value = model.grouptime;
			parameters[46].Value = model.remarks;
			parameters[47].Value = model.ggsbh;
			parameters[48].Value = model.pch2;
			parameters[49].Value = model.model1bc;
			parameters[50].Value = model.model2bc;
			parameters[51].Value = model.model3bc;
			parameters[52].Value = model.p1;
			parameters[53].Value = model.tgp1;
			parameters[54].Value = model.fsp1;
			parameters[55].Value = model.xl1;
			parameters[56].Value = model.p2;
			parameters[57].Value = model.tgp2;
			parameters[58].Value = model.fsp2;
			parameters[59].Value = model.xl2;
			parameters[60].Value = model.p3;
			parameters[61].Value = model.tgp3;
			parameters[62].Value = model.fsp3;
			parameters[63].Value = model.xl3;
			parameters[64].Value = model.recorder;
			parameters[65].Value = model.recordtime;

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
		public bool Update(Maticsoft.Model.tsuhan_scgl_iqc_lbpl model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_scgl_iqc_lbpl set ");
			strSql.Append("id=@id,");
			strSql.Append("jylx=@jylx,");
			strSql.Append("gysdm=@gysdm,");
			strSql.Append("rkdh=@rkdh,");
			strSql.Append("dhrq=@dhrq,");
			strSql.Append("sl=@sl,");
			strSql.Append("wlmc=@wlmc,");
			strSql.Append("thbc=@thbc,");
			strSql.Append("xh=@xh,");
			strSql.Append("chic=@chic,");
			strSql.Append("wlbm=@wlbm,");
			strSql.Append("cjybl=@cjybl,");
			strSql.Append("fsmfz=@fsmfz,");
			strSql.Append("other=@other,");
			strSql.Append("cstj=@cstj,");
			strSql.Append("cstjxpxh=@cstjxpxh,");
			strSql.Append("cstjgwpl=@cstjgwpl,");
			strSql.Append("cstjxpbc=@cstjxpbc,");
			strSql.Append("cstjsulv=@cstjsulv,");
			strSql.Append("cstjdl=@cstjdl,");
			strSql.Append("cstjgl=@cstjgl,");
			strSql.Append("cstjjju=@cstjjju,");
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
			strSql.Append("pch2=@pch2,");
			strSql.Append("model1bc=@model1bc,");
			strSql.Append("model2bc=@model2bc,");
			strSql.Append("model3bc=@model3bc,");
			strSql.Append("p1=@p1,");
			strSql.Append("tgp1=@tgp1,");
			strSql.Append("fsp1=@fsp1,");
			strSql.Append("xl1=@xl1,");
			strSql.Append("p2=@p2,");
			strSql.Append("tgp2=@tgp2,");
			strSql.Append("fsp2=@fsp2,");
			strSql.Append("xl2=@xl2,");
			strSql.Append("p3=@p3,");
			strSql.Append("tgp3=@tgp3,");
			strSql.Append("fsp3=@fsp3,");
			strSql.Append("xl3=@xl3,");
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
					new SqlParameter("@thbc", SqlDbType.Char,30),
					new SqlParameter("@xh", SqlDbType.Char,30),
					new SqlParameter("@chic", SqlDbType.Char,10),
					new SqlParameter("@wlbm", SqlDbType.Char,30),
					new SqlParameter("@cjybl", SqlDbType.Int,4),
					new SqlParameter("@fsmfz", SqlDbType.Char,100),
					new SqlParameter("@other", SqlDbType.Char,30),
					new SqlParameter("@cstj", SqlDbType.Char,50),
					new SqlParameter("@cstjxpxh", SqlDbType.Char,30),
					new SqlParameter("@cstjgwpl", SqlDbType.Char,10),
					new SqlParameter("@cstjxpbc", SqlDbType.Char,10),
					new SqlParameter("@cstjsulv", SqlDbType.Char,10),
					new SqlParameter("@cstjdl", SqlDbType.Char,10),
					new SqlParameter("@cstjgl", SqlDbType.Char,10),
					new SqlParameter("@cstjjju", SqlDbType.Char,10),
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
					new SqlParameter("@pch2", SqlDbType.NChar,10),
					new SqlParameter("@model1bc", SqlDbType.NChar,10),
					new SqlParameter("@model2bc", SqlDbType.NChar,10),
					new SqlParameter("@model3bc", SqlDbType.NChar,10),
					new SqlParameter("@p1", SqlDbType.Float,8),
					new SqlParameter("@tgp1", SqlDbType.Float,8),
					new SqlParameter("@fsp1", SqlDbType.Float,8),
					new SqlParameter("@xl1", SqlDbType.Float,8),
					new SqlParameter("@p2", SqlDbType.Float,8),
					new SqlParameter("@tgp2", SqlDbType.Float,8),
					new SqlParameter("@fsp2", SqlDbType.Float,8),
					new SqlParameter("@xl2", SqlDbType.Float,8),
					new SqlParameter("@p3", SqlDbType.Float,8),
					new SqlParameter("@tgp3", SqlDbType.Float,8),
					new SqlParameter("@fsp3", SqlDbType.Float,8),
					new SqlParameter("@xl3", SqlDbType.Float,8),
					new SqlParameter("@recorder", SqlDbType.NChar,10),
					new SqlParameter("@pch", SqlDbType.Char,30)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.jylx;
			parameters[2].Value = model.gysdm;
			parameters[3].Value = model.rkdh;
			parameters[4].Value = model.dhrq;
			parameters[5].Value = model.sl;
			parameters[6].Value = model.wlmc;
			parameters[7].Value = model.thbc;
			parameters[8].Value = model.xh;
			parameters[9].Value = model.chic;
			parameters[10].Value = model.wlbm;
			parameters[11].Value = model.cjybl;
			parameters[12].Value = model.fsmfz;
			parameters[13].Value = model.other;
			parameters[14].Value = model.cstj;
			parameters[15].Value = model.cstjxpxh;
			parameters[16].Value = model.cstjgwpl;
			parameters[17].Value = model.cstjxpbc;
			parameters[18].Value = model.cstjsulv;
			parameters[19].Value = model.cstjdl;
			parameters[20].Value = model.cstjgl;
			parameters[21].Value = model.cstjjju;
			parameters[22].Value = model.cybz;
			parameters[23].Value = model.aql;
			parameters[24].Value = model.qjyn;
			parameters[25].Value = model.okrate;
			parameters[26].Value = model.wg_jyyjbz;
			parameters[27].Value = model.wg_cjybsl;
			parameters[28].Value = model.wg_okng;
			parameters[29].Value = model.wg_sign;
			parameters[30].Value = model.wg_ngindex;
			parameters[31].Value = model.bs_okng;
			parameters[32].Value = model.bs_sign;
			parameters[33].Value = model.bs_ngindex;
			parameters[34].Value = model.bz_okng;
			parameters[35].Value = model.bz_sign;
			parameters[36].Value = model.bz_ngindex;
			parameters[37].Value = model.report;
			parameters[38].Value = model.report_sign;
			parameters[39].Value = model.ngdescription;
			parameters[40].Value = model.checkjg;
			parameters[41].Value = model.checker;
			parameters[42].Value = model.checkertime;
			parameters[43].Value = model.groupleader;
			parameters[44].Value = model.grouptime;
			parameters[45].Value = model.remarks;
			parameters[46].Value = model.ggsbh;
			parameters[47].Value = model.pch2;
			parameters[48].Value = model.model1bc;
			parameters[49].Value = model.model2bc;
			parameters[50].Value = model.model3bc;
			parameters[51].Value = model.p1;
			parameters[52].Value = model.tgp1;
			parameters[53].Value = model.fsp1;
			parameters[54].Value = model.xl1;
			parameters[55].Value = model.p2;
			parameters[56].Value = model.tgp2;
			parameters[57].Value = model.fsp2;
			parameters[58].Value = model.xl2;
			parameters[59].Value = model.p3;
			parameters[60].Value = model.tgp3;
			parameters[61].Value = model.fsp3;
			parameters[62].Value = model.xl3;
			parameters[63].Value = model.recorder;
			parameters[64].Value = model.pch;

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
			strSql.Append("delete from tsuhan_scgl_iqc_lbpl ");
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
			strSql.Append("delete from tsuhan_scgl_iqc_lbpl ");
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
		public Maticsoft.Model.tsuhan_scgl_iqc_lbpl GetModel(string pch)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,thbc,xh,chic,wlbm,cjybl,fsmfz,other,cstj,cstjxpxh,cstjgwpl,cstjxpbc,cstjsulv,cstjdl,cstjgl,cstjjju,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,pch2,model1bc,model2bc,model3bc,p1,tgp1,fsp1,xl1,p2,tgp2,fsp2,xl2,p3,tgp3,fsp3,xl3,recorder,recordtime from tsuhan_scgl_iqc_lbpl ");
			strSql.Append(" where pch=@pch ");
			SqlParameter[] parameters = {
					new SqlParameter("@pch", SqlDbType.Char,30)			};
			parameters[0].Value = pch;

			Maticsoft.Model.tsuhan_scgl_iqc_lbpl model=new Maticsoft.Model.tsuhan_scgl_iqc_lbpl();
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
		public Maticsoft.Model.tsuhan_scgl_iqc_lbpl DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_scgl_iqc_lbpl model=new Maticsoft.Model.tsuhan_scgl_iqc_lbpl();
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
				if(row["thbc"]!=null)
				{
					model.thbc=row["thbc"].ToString();
				}
				if(row["xh"]!=null)
				{
					model.xh=row["xh"].ToString();
				}
				if(row["chic"]!=null)
				{
					model.chic=row["chic"].ToString();
				}
				if(row["wlbm"]!=null)
				{
					model.wlbm=row["wlbm"].ToString();
				}
				if(row["cjybl"]!=null && row["cjybl"].ToString()!="")
				{
					model.cjybl=int.Parse(row["cjybl"].ToString());
				}
				if(row["fsmfz"]!=null)
				{
					model.fsmfz=row["fsmfz"].ToString();
				}
				if(row["other"]!=null)
				{
					model.other=row["other"].ToString();
				}
				if(row["cstj"]!=null)
				{
					model.cstj=row["cstj"].ToString();
				}
				if(row["cstjxpxh"]!=null)
				{
					model.cstjxpxh=row["cstjxpxh"].ToString();
				}
				if(row["cstjgwpl"]!=null)
				{
					model.cstjgwpl=row["cstjgwpl"].ToString();
				}
				if(row["cstjxpbc"]!=null)
				{
					model.cstjxpbc=row["cstjxpbc"].ToString();
				}
				if(row["cstjsulv"]!=null)
				{
					model.cstjsulv=row["cstjsulv"].ToString();
				}
				if(row["cstjdl"]!=null)
				{
					model.cstjdl=row["cstjdl"].ToString();
				}
				if(row["cstjgl"]!=null)
				{
					model.cstjgl=row["cstjgl"].ToString();
				}
				if(row["cstjjju"]!=null)
				{
					model.cstjjju=row["cstjjju"].ToString();
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
				if(row["pch2"]!=null)
				{
					model.pch2=row["pch2"].ToString();
				}
				if(row["model1bc"]!=null)
				{
					model.model1bc=row["model1bc"].ToString();
				}
				if(row["model2bc"]!=null)
				{
					model.model2bc=row["model2bc"].ToString();
				}
				if(row["model3bc"]!=null)
				{
					model.model3bc=row["model3bc"].ToString();
				}
				if(row["p1"]!=null && row["p1"].ToString()!="")
				{
					model.p1=decimal.Parse(row["p1"].ToString());
				}
				if(row["tgp1"]!=null && row["tgp1"].ToString()!="")
				{
					model.tgp1=decimal.Parse(row["tgp1"].ToString());
				}
				if(row["fsp1"]!=null && row["fsp1"].ToString()!="")
				{
					model.fsp1=decimal.Parse(row["fsp1"].ToString());
				}
				if(row["xl1"]!=null && row["xl1"].ToString()!="")
				{
					model.xl1=decimal.Parse(row["xl1"].ToString());
				}
				if(row["p2"]!=null && row["p2"].ToString()!="")
				{
					model.p2=decimal.Parse(row["p2"].ToString());
				}
				if(row["tgp2"]!=null && row["tgp2"].ToString()!="")
				{
					model.tgp2=decimal.Parse(row["tgp2"].ToString());
				}
				if(row["fsp2"]!=null && row["fsp2"].ToString()!="")
				{
					model.fsp2=decimal.Parse(row["fsp2"].ToString());
				}
				if(row["xl2"]!=null && row["xl2"].ToString()!="")
				{
					model.xl2=decimal.Parse(row["xl2"].ToString());
				}
				if(row["p3"]!=null && row["p3"].ToString()!="")
				{
					model.p3=decimal.Parse(row["p3"].ToString());
				}
				if(row["tgp3"]!=null && row["tgp3"].ToString()!="")
				{
					model.tgp3=decimal.Parse(row["tgp3"].ToString());
				}
				if(row["fsp3"]!=null && row["fsp3"].ToString()!="")
				{
					model.fsp3=decimal.Parse(row["fsp3"].ToString());
				}
				if(row["xl3"]!=null && row["xl3"].ToString()!="")
				{
					model.xl3=decimal.Parse(row["xl3"].ToString());
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
			strSql.Append("select id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,thbc,xh,chic,wlbm,cjybl,fsmfz,other,cstj,cstjxpxh,cstjgwpl,cstjxpbc,cstjsulv,cstjdl,cstjgl,cstjjju,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,pch2,model1bc,model2bc,model3bc,p1,tgp1,fsp1,xl1,p2,tgp2,fsp2,xl2,p3,tgp3,fsp3,xl3,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_lbpl ");
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
			strSql.Append(" id,pch,jylx,gysdm,rkdh,dhrq,sl,wlmc,thbc,xh,chic,wlbm,cjybl,fsmfz,other,cstj,cstjxpxh,cstjgwpl,cstjxpbc,cstjsulv,cstjdl,cstjgl,cstjjju,cybz,aql,qjyn,okrate,wg_jyyjbz,wg_cjybsl,wg_okng,wg_sign,wg_ngindex,bs_okng,bs_sign,bs_ngindex,bz_okng,bz_sign,bz_ngindex,report,report_sign,ngdescription,checkjg,checker,checkertime,groupleader,grouptime,remarks,ggsbh,pch2,model1bc,model2bc,model3bc,p1,tgp1,fsp1,xl1,p2,tgp2,fsp2,xl2,p3,tgp3,fsp3,xl3,recorder,recordtime ");
			strSql.Append(" FROM tsuhan_scgl_iqc_lbpl ");
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
			strSql.Append("select count(1) FROM tsuhan_scgl_iqc_lbpl ");
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
			strSql.Append(")AS Row, T.*  from tsuhan_scgl_iqc_lbpl T ");
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
			parameters[0].Value = "tsuhan_scgl_iqc_lbpl";
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

