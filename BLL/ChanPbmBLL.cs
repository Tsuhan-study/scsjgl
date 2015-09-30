using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using Maticsoft.Model;

namespace BLL
{
    public class ChanPbmBLL
    {
        ChanPbmDAL dal = new ChanPbmDAL();

        #region 成品编码
        /// <summary>
        /// 查询所有的成品编码
        /// </summary>
        /// <returns></returns>
        public DataSet GetChanPTable()
        {
            return dal.GetChanPTable();
        }

        /// <summary>
        /// 判断是否存在记录
        /// </summary>
        /// <param name="cpbm"></param>
        /// <returns></returns>
        public bool Exist(string cpbm)
        {
            return dal.Exist(cpbm);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="cpbm"></param>
        /// <returns></returns>
        public bool Add(tsuhan_gt_cpbm cpbm)
        {
            return dal.Add(cpbm);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="cp"></param>
        /// <returns></returns>
        public bool Delete(string cp)
        {
            return dal.Delete(cp);
        }

        #endregion

        #region 产品名称
        /// <summary>
        /// 查询所有的产品名称，图号
        /// </summary>
        /// <returns></returns>
        public DataTable GetChanMTable()
        {
            return dal.GetChanMTable();
        }

        /// <summary>
        /// 查询所有的产品名称，图号
        /// </summary>
        /// <returns></returns>
        public DataSet GetChanMAll()
        {
            return dal.GetChanMAll();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="cpmc"></param>
        /// <returns></returns>
        public bool Add(tsuhan_gt_cpmc cpmc)
        {
            return dal.Add(cpmc);
        }

        public bool DeleteP(string cp)
        {
            return dal.DeleteP(cp);
        }
        #endregion



    }
}
