using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using Maticsoft.Model;

namespace BLL
{
    public class RkBLL
    {
         RkDAL dal=new RkDAL();
		
		#region  BasicMethod

		
        public bool Exist(string 备货单号, DateTime 入库时间)
        {
            return dal.Exist(备货单号,入库时间);
        }

        public bool Update1(Maticsoft.Model.baozhuang_chuhuo model)
        {
            return dal.Update1(model);
        }

		

        /// <summary>
        /// 根据备货单号，入库时间查询
        /// </summary>
        /// <param name="备货单号"></param>
        /// <param name="入库时间"></param>
        /// <returns></returns>
        public baozhuang_chuhuo GetModels(string 备货单号, DateTime 入库时间)
        {
            return dal.GetModels(备货单号, 入库时间);
        }

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

        /// <summary>
        /// 多条件查询
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public DataSet QueryRks(string danhao, string time, string time1)
        {
            return dal.QueryRks(danhao, time, time1);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public baozhuang_chuhuo QueryByShul(string 备货单, string 出货日期)
        {
            return dal.QueryByShul(备货单, 出货日期);
        }
    }
}


