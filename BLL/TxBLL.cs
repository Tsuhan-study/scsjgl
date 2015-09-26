using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Maticsoft.Model;

namespace BLL
{
    /// <summary>
    /// 随工单记录详情操作类
    /// </summary>
    public class TxBLL
    {
        TxDAL dal = new TxDAL();

        /// <summary>
        /// 根据随工单号查询
        /// </summary>
        /// <param name="随工单号"></param>
        /// <returns></returns>
        public tsuhan_sg_tx QueryByXuhao(string 随工单号)
        {
            return dal.QueryByXuhao(随工单号);
        }

        /// <summary>
        /// 新增随工单
        /// </summary>
        /// <param name="bhd"></param>
        /// <returns></returns>
        public bool Add(tsuhan_sg_tx model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 判断是否存在该条记录
        /// </summary>
        /// <param name="随工单号"></param>
        /// <returns></returns>
        public bool Exists(string 随工单号)
        {
            return dal.Exists(随工单号);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="bhd"></param>
        /// <returns></returns>
        public bool Update(tsuhan_sg_tx bhd)
        {
            return dal.Update(bhd);
        }

        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns></returns>
        public tsuhan_sg_tx GetAllTx()
        {
            return dal.GetAllTx();
        }
    }
}
