using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Maticsoft.DBUtility;
using Maticsoft.Model;

namespace DAL
{
    public class YhDAL
    {
        DbHelperSQLP dbhelper3 = new DbHelperSQLP(PubConstant.GetConnectionString("connectionString"));
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string 工号, string 密码)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsuhan_scgl_yh2");
            strSql.Append(" where 工号=@工号 and 密码=@密码");
            SqlParameter[] parameters = {
					new SqlParameter("@工号", SqlDbType.NVarChar,20),
                    new SqlParameter("@密码",SqlDbType.NVarChar,20)
                                        };
            parameters[0].Value = 工号;
            parameters[1].Value = 密码;

            return dbhelper3.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exist(string 工号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsuhan_scgl_yh2");
            strSql.Append(" where 工号=@工号 ");
            SqlParameter[] parameters = {
					new SqlParameter("@工号", SqlDbType.NVarChar,20)			};
            parameters[0].Value = 工号;
            return dbhelper3.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 根据工号查询工序名称
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public tsuhan_scgl_yh GetModel(string 工号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 离职日期,离职原因,是否工资卡,批注,介绍人,指纹登记号码,工号,姓名,学历,专业,部门,机构,职务,新衣柜,衣柜,新鞋柜,鞋柜1,鞋柜2,性别,入职日期,身份证号,身份证地址,现住址,电话,紧急联系人,紧急联系人电话,婚姻状况,民族,籍贯,户籍,是否转正,转正时间,是否购买社保,购买社保时间,是否购买商保,人事资料情况,是否签订合同,合同年限,起始日期,终止日期,合同状态,合同状态备注,备注,在职状态,邮箱,内部小号,密码,AB班,other1,other2,other3,other4,other5,other6,other7,other8,other9,other10 from tsuhan_scgl_yh2");
            strSql.Append(" where 工号=@工号");
            SqlParameter[] parameters = {
					new SqlParameter("@工号", SqlDbType.NVarChar,20)		};
            parameters[0].Value = 工号;
            tsuhan_scgl_yh model = new tsuhan_scgl_yh();
            DataSet ds = dbhelper3.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            };
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tsuhan_scgl_yh DataRowToModel(DataRow row)
        {
            tsuhan_scgl_yh model = new tsuhan_scgl_yh();
            if (row != null)
			{
				if(row["离职日期"]!=null && row["离职日期"].ToString()!="")
				{
					model.离职日期=DateTime.Parse(row["离职日期"].ToString());
				}
				if(row["离职原因"]!=null)
				{
					model.离职原因=row["离职原因"].ToString();
				}
				if(row["是否工资卡"]!=null)
				{
					model.是否工资卡=row["是否工资卡"].ToString();
				}
				if(row["批注"]!=null)
				{
					model.批注=row["批注"].ToString();
				}
				if(row["介绍人"]!=null)
				{
					model.介绍人=row["介绍人"].ToString();
				}
				if(row["指纹登记号码"]!=null)
				{
					model.指纹登记号码=row["指纹登记号码"].ToString();
				}
				if(row["工号"]!=null)
				{
					model.工号=row["工号"].ToString();
				}
				if(row["姓名"]!=null)
				{
					model.姓名=row["姓名"].ToString();
				}
				if(row["学历"]!=null)
				{
					model.学历=row["学历"].ToString();
				}
				if(row["专业"]!=null)
				{
					model.专业=row["专业"].ToString();
				}
				if(row["部门"]!=null)
				{
					model.部门=row["部门"].ToString();
				}
				if(row["机构"]!=null)
				{
					model.机构=row["机构"].ToString();
				}
				if(row["职务"]!=null)
				{
					model.职务=row["职务"].ToString();
				}
				if(row["新衣柜"]!=null)
				{
					model.新衣柜=row["新衣柜"].ToString();
				}
				if(row["衣柜"]!=null)
				{
					model.衣柜=row["衣柜"].ToString();
				}
				if(row["新鞋柜"]!=null)
				{
					model.新鞋柜=row["新鞋柜"].ToString();
				}
				if(row["鞋柜1"]!=null)
				{
					model.鞋柜1=row["鞋柜1"].ToString();
				}
				if(row["鞋柜2"]!=null)
				{
					model.鞋柜2=row["鞋柜2"].ToString();
				}
				if(row["性别"]!=null)
				{
					model.性别=row["性别"].ToString();
				}
				if(row["入职日期"]!=null && row["入职日期"].ToString()!="")
				{
					model.入职日期=DateTime.Parse(row["入职日期"].ToString());
				}
				if(row["身份证号"]!=null)
				{
					model.身份证号=row["身份证号"].ToString();
				}
				if(row["身份证地址"]!=null)
				{
					model.身份证地址=row["身份证地址"].ToString();
				}
				if(row["现住址"]!=null)
				{
					model.现住址=row["现住址"].ToString();
				}
				if(row["电话"]!=null && row["电话"].ToString()!="")
				{
					model.电话=decimal.Parse(row["电话"].ToString());
				}
				if(row["紧急联系人"]!=null)
				{
					model.紧急联系人=row["紧急联系人"].ToString();
				}
				if(row["紧急联系人电话"]!=null && row["紧急联系人电话"].ToString()!="")
				{
					model.紧急联系人电话=decimal.Parse(row["紧急联系人电话"].ToString());
				}
				if(row["婚姻状况"]!=null)
				{
					model.婚姻状况=row["婚姻状况"].ToString();
				}
				if(row["民族"]!=null)
				{
					model.民族=row["民族"].ToString();
				}
				if(row["籍贯"]!=null)
				{
					model.籍贯=row["籍贯"].ToString();
				}
				if(row["户籍"]!=null)
				{
					model.户籍=row["户籍"].ToString();
				}
				if(row["是否转正"]!=null)
				{
					model.是否转正=row["是否转正"].ToString();
				}
				if(row["转正时间"]!=null && row["转正时间"].ToString()!="")
				{
					model.转正时间=DateTime.Parse(row["转正时间"].ToString());
				}
				if(row["是否购买社保"]!=null)
				{
					model.是否购买社保=row["是否购买社保"].ToString();
				}
				if(row["购买社保时间"]!=null)
				{
					model.购买社保时间=row["购买社保时间"].ToString();
				}
				if(row["是否购买商保"]!=null)
				{
					model.是否购买商保=row["是否购买商保"].ToString();
				}
				if(row["人事资料情况"]!=null)
				{
					model.人事资料情况=row["人事资料情况"].ToString();
				}
				if(row["是否签订合同"]!=null)
				{
					model.是否签订合同=row["是否签订合同"].ToString();
				}
				if(row["合同年限"]!=null)
				{
					model.合同年限=row["合同年限"].ToString();
				}
				if(row["起始日期"]!=null && row["起始日期"].ToString()!="")
				{
					model.起始日期=DateTime.Parse(row["起始日期"].ToString());
				}
				if(row["终止日期"]!=null)
				{
					model.终止日期=row["终止日期"].ToString();
				}
				if(row["合同状态"]!=null)
				{
					model.合同状态=row["合同状态"].ToString();
				}
				if(row["合同状态备注"]!=null)
				{
					model.合同状态备注=row["合同状态备注"].ToString();
				}
				if(row["备注"]!=null)
				{
					model.备注=row["备注"].ToString();
				}
				if(row["在职状态"]!=null)
				{
					model.在职状态=row["在职状态"].ToString();
				}
				if(row["邮箱"]!=null)
				{
					model.邮箱=row["邮箱"].ToString();
				}
				if(row["内部小号"]!=null)
				{
					model.内部小号=row["内部小号"].ToString();
				}
				if(row["密码"]!=null)
				{
					model.密码=row["密码"].ToString();
				}
				if(row["AB班"]!=null)
				{
					model.AB班=row["AB班"].ToString();
				}
				if(row["other1"]!=null)
				{
					model.other1=row["other1"].ToString();
				}
				if(row["other2"]!=null)
				{
					model.other2=row["other2"].ToString();
				}
				if(row["other3"]!=null)
				{
					model.other3=row["other3"].ToString();
				}
				if(row["other4"]!=null)
				{
					model.other4=row["other4"].ToString();
				}
				if(row["other5"]!=null)
				{
					model.other5=row["other5"].ToString();
				}
				if(row["other6"]!=null)
				{
					model.other6=row["other6"].ToString();
				}
				if(row["other7"]!=null)
				{
					model.other7=row["other7"].ToString();
				}
				if(row["other8"]!=null)
				{
					model.other8=row["other8"].ToString();
				}
				if(row["other9"]!=null)
				{
					model.other9=row["other9"].ToString();
				}
				if(row["other10"]!=null)
				{
					model.other10=row["other10"].ToString();
				}
			}
            return model;
        }

        /// <summary>
        /// 查询所有的用户信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 离职日期,离职原因,是否工资卡,批注,介绍人,指纹登记号码,工号,姓名,学历,专业,部门,机构,职务,新衣柜,衣柜,新鞋柜,鞋柜1,鞋柜2,性别,入职日期,身份证号,身份证地址,现住址,电话,紧急联系人,紧急联系人电话,婚姻状况,民族,籍贯,户籍,是否转正,转正时间,是否购买社保,购买社保时间,是否购买商保,人事资料情况,是否签订合同,合同年限,起始日期,终止日期,合同状态,合同状态备注,备注,在职状态,邮箱,内部小号,密码,AB班 from tsuhan_scgl_yh2");
            return dbhelper3.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询在职员工信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll1()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 批注,介绍人,指纹登记号码,工号,姓名,学历,专业,部门,机构,职务,新衣柜,衣柜,新鞋柜,鞋柜1,鞋柜2,性别,入职日期,身份证号,身份证地址,现住址,电话,紧急联系人,紧急联系人电话,婚姻状况,民族,籍贯,户籍,是否转正,转正时间,是否购买社保,购买社保时间,是否购买商保,人事资料情况,是否签订合同,合同年限,起始日期,终止日期,合同状态,备注,在职状态,邮箱,内部小号,密码,AB班 from tsuhan_scgl_yh2");
            strSql.Append(" where 在职状态='在职'");
            return dbhelper3.Query(strSql.ToString());

        }

        /// <summary>
        /// 查询离职员工信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll2()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 离职日期,离职原因,是否工资卡,批注,介绍人,指纹登记号码,工号,姓名,学历,专业,部门,机构,职务,新衣柜,衣柜,新鞋柜,鞋柜1,鞋柜2,性别,入职日期,身份证号,身份证地址,现住址,电话,紧急联系人,紧急联系人电话,婚姻状况,民族,籍贯,户籍,是否转正,转正时间,是否购买社保,购买社保时间,是否购买商保,人事资料情况,是否签订合同,合同年限,起始日期,终止日期,合同状态,合同状态备注,备注,在职状态,邮箱,内部小号,密码,AB班 from tsuhan_scgl_yh2");
            strSql.Append(" where 在职状态='离职'");
            return dbhelper3.Query(strSql.ToString());
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="yh"></param>
        /// <returns></returns>
        public bool Add(tsuhan_scgl_yh model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_scgl_yh2(");
            strSql.Append("离职日期,离职原因,是否工资卡,批注,介绍人,指纹登记号码,工号,姓名,学历,专业,部门,机构,职务,新衣柜,衣柜,新鞋柜,鞋柜1,鞋柜2,性别,入职日期,身份证号,身份证地址,现住址,电话,紧急联系人,紧急联系人电话,婚姻状况,民族,籍贯,户籍,是否转正,转正时间,是否购买社保,购买社保时间,是否购买商保,人事资料情况,是否签订合同,合同年限,起始日期,终止日期,合同状态,合同状态备注,备注,在职状态,邮箱,内部小号,密码,AB班,other1,other2,other3,other4,other5,other6,other7,other8,other9,other10)");
            strSql.Append(" values (");
            strSql.Append("@离职日期,@离职原因,@是否工资卡,@批注,@介绍人,@指纹登记号码,@工号,@姓名,@学历,@专业,@部门,@机构,@职务,@新衣柜,@衣柜,@新鞋柜,@鞋柜1,@鞋柜2,@性别,@入职日期,@身份证号,@身份证地址,@现住址,@电话,@紧急联系人,@紧急联系人电话,@婚姻状况,@民族,@籍贯,@户籍,@是否转正,@转正时间,@是否购买社保,@购买社保时间,@是否购买商保,@人事资料情况,@是否签订合同,@合同年限,@起始日期,@终止日期,@合同状态,@合同状态备注,@备注,@在职状态,@邮箱,@内部小号,@密码,@AB班,@other1,@other2,@other3,@other4,@other5,@other6,@other7,@other8,@other9,@other10)");
            SqlParameter[] parameters = {
					new SqlParameter("@离职日期", SqlDbType.SmallDateTime),
					new SqlParameter("@离职原因", SqlDbType.NVarChar,255),
					new SqlParameter("@是否工资卡", SqlDbType.NVarChar,255),
					new SqlParameter("@批注", SqlDbType.NVarChar,255),
					new SqlParameter("@介绍人", SqlDbType.NVarChar,255),
					new SqlParameter("@指纹登记号码", SqlDbType.NVarChar,255),
					new SqlParameter("@工号", SqlDbType.NVarChar,20),
					new SqlParameter("@姓名", SqlDbType.NVarChar,255),
					new SqlParameter("@学历", SqlDbType.NVarChar,255),
					new SqlParameter("@专业", SqlDbType.NVarChar,255),
					new SqlParameter("@部门", SqlDbType.NVarChar,255),
					new SqlParameter("@机构", SqlDbType.NVarChar,255),
					new SqlParameter("@职务", SqlDbType.NVarChar,255),
					new SqlParameter("@新衣柜", SqlDbType.NVarChar,255),
					new SqlParameter("@衣柜", SqlDbType.NVarChar,255),
					new SqlParameter("@新鞋柜", SqlDbType.NVarChar,255),
					new SqlParameter("@鞋柜1", SqlDbType.NVarChar,255),
					new SqlParameter("@鞋柜2", SqlDbType.NVarChar,255),
					new SqlParameter("@性别", SqlDbType.NVarChar,255),
					new SqlParameter("@入职日期", SqlDbType.SmallDateTime),
					new SqlParameter("@身份证号", SqlDbType.NVarChar,255),
					new SqlParameter("@身份证地址", SqlDbType.NVarChar,255),
					new SqlParameter("@现住址", SqlDbType.NVarChar,255),
					new SqlParameter("@电话", SqlDbType.Float,8),
					new SqlParameter("@紧急联系人", SqlDbType.NVarChar,255),
					new SqlParameter("@紧急联系人电话", SqlDbType.Float,8),
					new SqlParameter("@婚姻状况", SqlDbType.NVarChar,255),
					new SqlParameter("@民族", SqlDbType.NVarChar,255),
					new SqlParameter("@籍贯", SqlDbType.NVarChar,255),
					new SqlParameter("@户籍", SqlDbType.NVarChar,255),
					new SqlParameter("@是否转正", SqlDbType.NVarChar,255),
					new SqlParameter("@转正时间", SqlDbType.SmallDateTime),
					new SqlParameter("@是否购买社保", SqlDbType.NVarChar,255),
					new SqlParameter("@购买社保时间", SqlDbType.NVarChar,255),
					new SqlParameter("@是否购买商保", SqlDbType.NVarChar,255),
					new SqlParameter("@人事资料情况", SqlDbType.NVarChar,255),
					new SqlParameter("@是否签订合同", SqlDbType.NVarChar,255),
					new SqlParameter("@合同年限", SqlDbType.NVarChar,255),
					new SqlParameter("@起始日期", SqlDbType.SmallDateTime),
					new SqlParameter("@终止日期", SqlDbType.NVarChar,255),
					new SqlParameter("@合同状态", SqlDbType.NVarChar,255),
					new SqlParameter("@合同状态备注", SqlDbType.NVarChar,255),
					new SqlParameter("@备注", SqlDbType.NVarChar,255),
					new SqlParameter("@在职状态", SqlDbType.NVarChar,50),
					new SqlParameter("@邮箱", SqlDbType.NVarChar,50),
					new SqlParameter("@内部小号", SqlDbType.NVarChar,20),
					new SqlParameter("@密码", SqlDbType.NVarChar,20),
					new SqlParameter("@AB班", SqlDbType.NVarChar,10),
					new SqlParameter("@other1", SqlDbType.NVarChar,50),
					new SqlParameter("@other2", SqlDbType.NVarChar,50),
					new SqlParameter("@other3", SqlDbType.NVarChar,50),
					new SqlParameter("@other4", SqlDbType.NVarChar,50),
					new SqlParameter("@other5", SqlDbType.NVarChar,50),
					new SqlParameter("@other6", SqlDbType.NVarChar,50),
					new SqlParameter("@other7", SqlDbType.NVarChar,50),
					new SqlParameter("@other8", SqlDbType.NVarChar,50),
					new SqlParameter("@other9", SqlDbType.NVarChar,50),
					new SqlParameter("@other10", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.离职日期;
            parameters[1].Value = model.离职原因;
            parameters[2].Value = model.是否工资卡;
            parameters[3].Value = model.批注;
            parameters[4].Value = model.介绍人;
            parameters[5].Value = model.指纹登记号码;
            parameters[6].Value = model.工号;
            parameters[7].Value = model.姓名;
            parameters[8].Value = model.学历;
            parameters[9].Value = model.专业;
            parameters[10].Value = model.部门;
            parameters[11].Value = model.机构;
            parameters[12].Value = model.职务;
            parameters[13].Value = model.新衣柜;
            parameters[14].Value = model.衣柜;
            parameters[15].Value = model.新鞋柜;
            parameters[16].Value = model.鞋柜1;
            parameters[17].Value = model.鞋柜2;
            parameters[18].Value = model.性别;
            parameters[19].Value = model.入职日期;
            parameters[20].Value = model.身份证号;
            parameters[21].Value = model.身份证地址;
            parameters[22].Value = model.现住址;
            parameters[23].Value = model.电话;
            parameters[24].Value = model.紧急联系人;
            parameters[25].Value = model.紧急联系人电话;
            parameters[26].Value = model.婚姻状况;
            parameters[27].Value = model.民族;
            parameters[28].Value = model.籍贯;
            parameters[29].Value = model.户籍;
            parameters[30].Value = model.是否转正;
            parameters[31].Value = model.转正时间;
            parameters[32].Value = model.是否购买社保;
            parameters[33].Value = model.购买社保时间;
            parameters[34].Value = model.是否购买商保;
            parameters[35].Value = model.人事资料情况;
            parameters[36].Value = model.是否签订合同;
            parameters[37].Value = model.合同年限;
            parameters[38].Value = model.起始日期;
            parameters[39].Value = model.终止日期;
            parameters[40].Value = model.合同状态;
            parameters[41].Value = model.合同状态备注;
            parameters[42].Value = model.备注;
            parameters[43].Value = model.在职状态;
            parameters[44].Value = model.邮箱;
            parameters[45].Value = model.内部小号;
            parameters[46].Value = model.密码;
            parameters[47].Value = model.AB班;
            parameters[48].Value = model.other1;
            parameters[49].Value = model.other2;
            parameters[50].Value = model.other3;
            parameters[51].Value = model.other4;
            parameters[52].Value = model.other5;
            parameters[53].Value = model.other6;
            parameters[54].Value = model.other7;
            parameters[55].Value = model.other8;
            parameters[56].Value = model.other9;
            parameters[57].Value = model.other10;

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
        /// 修改用户信息
        /// </summary>
        /// <param name="yh"></param>
        /// <returns></returns>
        public bool Update(tsuhan_scgl_yh model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsuhan_scgl_yh2 set ");
            strSql.Append("离职日期=@离职日期,");
            strSql.Append("离职原因=@离职原因,");
            strSql.Append("是否工资卡=@是否工资卡,");
            strSql.Append("批注=@批注,");
            strSql.Append("介绍人=@介绍人,");
            strSql.Append("指纹登记号码=@指纹登记号码,");
            strSql.Append("姓名=@姓名,");
            strSql.Append("学历=@学历,");
            strSql.Append("专业=@专业,");
            strSql.Append("部门=@部门,");
            strSql.Append("机构=@机构,");
            strSql.Append("职务=@职务,");
            strSql.Append("新衣柜=@新衣柜,");
            strSql.Append("衣柜=@衣柜,");
            strSql.Append("新鞋柜=@新鞋柜,");
            strSql.Append("鞋柜1=@鞋柜1,");
            strSql.Append("鞋柜2=@鞋柜2,");
            strSql.Append("性别=@性别,");
            strSql.Append("入职日期=@入职日期,");
            strSql.Append("身份证号=@身份证号,");
            strSql.Append("身份证地址=@身份证地址,");
            strSql.Append("现住址=@现住址,");
            strSql.Append("电话=@电话,");
            strSql.Append("紧急联系人=@紧急联系人,");
            strSql.Append("紧急联系人电话=@紧急联系人电话,");
            strSql.Append("婚姻状况=@婚姻状况,");
            strSql.Append("民族=@民族,");
            strSql.Append("籍贯=@籍贯,");
            strSql.Append("户籍=@户籍,");
            strSql.Append("是否转正=@是否转正,");
            strSql.Append("转正时间=@转正时间,");
            strSql.Append("是否购买社保=@是否购买社保,");
            strSql.Append("购买社保时间=@购买社保时间,");
            strSql.Append("是否购买商保=@是否购买商保,");
            strSql.Append("人事资料情况=@人事资料情况,");
            strSql.Append("是否签订合同=@是否签订合同,");
            strSql.Append("合同年限=@合同年限,");
            strSql.Append("起始日期=@起始日期,");
            strSql.Append("终止日期=@终止日期,");
            strSql.Append("合同状态=@合同状态,");
            strSql.Append("合同状态备注=@合同状态备注,");
            strSql.Append("备注=@备注,");
            strSql.Append("在职状态=@在职状态,");
            strSql.Append("邮箱=@邮箱,");
            strSql.Append("内部小号=@内部小号,");
            strSql.Append("密码=@密码,");
            strSql.Append("AB班=@AB班,");
            strSql.Append("other1=@other1,");
            strSql.Append("other2=@other2,");
            strSql.Append("other3=@other3,");
            strSql.Append("other4=@other4,");
            strSql.Append("other5=@other5,");
            strSql.Append("other6=@other6,");
            strSql.Append("other7=@other7,");
            strSql.Append("other8=@other8,");
            strSql.Append("other9=@other9,");
            strSql.Append("other10=@other10");
            strSql.Append(" where 工号=@工号 ");
            SqlParameter[] parameters = {
					new SqlParameter("@离职日期", SqlDbType.SmallDateTime),
					new SqlParameter("@离职原因", SqlDbType.NVarChar,255),
					new SqlParameter("@是否工资卡", SqlDbType.NVarChar,255),
					new SqlParameter("@批注", SqlDbType.NVarChar,255),
					new SqlParameter("@介绍人", SqlDbType.NVarChar,255),
					new SqlParameter("@指纹登记号码", SqlDbType.NVarChar,255),
					new SqlParameter("@姓名", SqlDbType.NVarChar,255),
					new SqlParameter("@学历", SqlDbType.NVarChar,255),
					new SqlParameter("@专业", SqlDbType.NVarChar,255),
					new SqlParameter("@部门", SqlDbType.NVarChar,255),
					new SqlParameter("@机构", SqlDbType.NVarChar,255),
					new SqlParameter("@职务", SqlDbType.NVarChar,255),
					new SqlParameter("@新衣柜", SqlDbType.NVarChar,255),
					new SqlParameter("@衣柜", SqlDbType.NVarChar,255),
					new SqlParameter("@新鞋柜", SqlDbType.NVarChar,255),
					new SqlParameter("@鞋柜1", SqlDbType.NVarChar,255),
					new SqlParameter("@鞋柜2", SqlDbType.NVarChar,255),
					new SqlParameter("@性别", SqlDbType.NVarChar,255),
					new SqlParameter("@入职日期", SqlDbType.SmallDateTime),
					new SqlParameter("@身份证号", SqlDbType.NVarChar,255),
					new SqlParameter("@身份证地址", SqlDbType.NVarChar,255),
					new SqlParameter("@现住址", SqlDbType.NVarChar,255),
					new SqlParameter("@电话", SqlDbType.Float,8),
					new SqlParameter("@紧急联系人", SqlDbType.NVarChar,255),
					new SqlParameter("@紧急联系人电话", SqlDbType.Float,8),
					new SqlParameter("@婚姻状况", SqlDbType.NVarChar,255),
					new SqlParameter("@民族", SqlDbType.NVarChar,255),
					new SqlParameter("@籍贯", SqlDbType.NVarChar,255),
					new SqlParameter("@户籍", SqlDbType.NVarChar,255),
					new SqlParameter("@是否转正", SqlDbType.NVarChar,255),
					new SqlParameter("@转正时间", SqlDbType.SmallDateTime),
					new SqlParameter("@是否购买社保", SqlDbType.NVarChar,255),
					new SqlParameter("@购买社保时间", SqlDbType.NVarChar,255),
					new SqlParameter("@是否购买商保", SqlDbType.NVarChar,255),
					new SqlParameter("@人事资料情况", SqlDbType.NVarChar,255),
					new SqlParameter("@是否签订合同", SqlDbType.NVarChar,255),
					new SqlParameter("@合同年限", SqlDbType.NVarChar,255),
					new SqlParameter("@起始日期", SqlDbType.SmallDateTime),
					new SqlParameter("@终止日期", SqlDbType.NVarChar,255),
					new SqlParameter("@合同状态", SqlDbType.NVarChar,255),
					new SqlParameter("@合同状态备注", SqlDbType.NVarChar,255),
					new SqlParameter("@备注", SqlDbType.NVarChar,255),
					new SqlParameter("@在职状态", SqlDbType.NVarChar,50),
					new SqlParameter("@邮箱", SqlDbType.NVarChar,50),
					new SqlParameter("@内部小号", SqlDbType.NVarChar,20),
					new SqlParameter("@密码", SqlDbType.NVarChar,20),
					new SqlParameter("@AB班", SqlDbType.NVarChar,10),
					new SqlParameter("@other1", SqlDbType.NVarChar,50),
					new SqlParameter("@other2", SqlDbType.NVarChar,50),
					new SqlParameter("@other3", SqlDbType.NVarChar,50),
					new SqlParameter("@other4", SqlDbType.NVarChar,50),
					new SqlParameter("@other5", SqlDbType.NVarChar,50),
					new SqlParameter("@other6", SqlDbType.NVarChar,50),
					new SqlParameter("@other7", SqlDbType.NVarChar,50),
					new SqlParameter("@other8", SqlDbType.NVarChar,50),
					new SqlParameter("@other9", SqlDbType.NVarChar,50),
					new SqlParameter("@other10", SqlDbType.NVarChar,50),
					new SqlParameter("@工号", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.离职日期;
            parameters[1].Value = model.离职原因;
            parameters[2].Value = model.是否工资卡;
            parameters[3].Value = model.批注;
            parameters[4].Value = model.介绍人;
            parameters[5].Value = model.指纹登记号码;
            parameters[6].Value = model.姓名;
            parameters[7].Value = model.学历;
            parameters[8].Value = model.专业;
            parameters[9].Value = model.部门;
            parameters[10].Value = model.机构;
            parameters[11].Value = model.职务;
            parameters[12].Value = model.新衣柜;
            parameters[13].Value = model.衣柜;
            parameters[14].Value = model.新鞋柜;
            parameters[15].Value = model.鞋柜1;
            parameters[16].Value = model.鞋柜2;
            parameters[17].Value = model.性别;
            parameters[18].Value = model.入职日期;
            parameters[19].Value = model.身份证号;
            parameters[20].Value = model.身份证地址;
            parameters[21].Value = model.现住址;
            parameters[22].Value = model.电话;
            parameters[23].Value = model.紧急联系人;
            parameters[24].Value = model.紧急联系人电话;
            parameters[25].Value = model.婚姻状况;
            parameters[26].Value = model.民族;
            parameters[27].Value = model.籍贯;
            parameters[28].Value = model.户籍;
            parameters[29].Value = model.是否转正;
            parameters[30].Value = model.转正时间;
            parameters[31].Value = model.是否购买社保;
            parameters[32].Value = model.购买社保时间;
            parameters[33].Value = model.是否购买商保;
            parameters[34].Value = model.人事资料情况;
            parameters[35].Value = model.是否签订合同;
            parameters[36].Value = model.合同年限;
            parameters[37].Value = model.起始日期;
            parameters[38].Value = model.终止日期;
            parameters[39].Value = model.合同状态;
            parameters[40].Value = model.合同状态备注;
            parameters[41].Value = model.备注;
            parameters[42].Value = model.在职状态;
            parameters[43].Value = model.邮箱;
            parameters[44].Value = model.内部小号;
            parameters[45].Value = model.密码;
            parameters[46].Value = model.AB班;
            parameters[47].Value = model.other1;
            parameters[48].Value = model.other2;
            parameters[49].Value = model.other3;
            parameters[50].Value = model.other4;
            parameters[51].Value = model.other5;
            parameters[52].Value = model.other6;
            parameters[53].Value = model.other7;
            parameters[54].Value = model.other8;
            parameters[55].Value = model.other9;
            parameters[56].Value = model.other10;
            parameters[57].Value = model.工号;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string 工号)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsuhan_scgl_yh2");
            strSql.Append(" where 工号=@工号 ");
            SqlParameter[] parameters = {
					new SqlParameter("@工号", SqlDbType.NVarChar,20)			};
            parameters[0].Value = 工号;

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
    }
}
