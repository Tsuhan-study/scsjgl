using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Maticsoft.Model;

namespace BLL
{
    /// <summary>
    /// 材料清单
    /// </summary>
    public class BhdBLL
    {
        BhdDAL dal = new BhdDAL();

        /// <summary>
        /// 根据备货单号查询材料清单
        /// </summary>
        /// <param name="beiHuo"></param>
        /// <returns></returns>
        public tsuhan_sg_bhd QueryByBei(string beiHuo)
        {
            return dal.QueryByBei(beiHuo);
        }

        /// <summary>
        /// 判断是否存在该记录
        /// </summary>
        /// <param name="备货单号"></param>
        /// <returns></returns>
        public bool Exists(string 备货单号)
        {
            return dal.Exists(备货单号);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="bh"></param>
        /// <returns></returns>
        public bool Add(tsuhan_sg_bhd bh)
        {
            return dal.Add(bh); ;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="bh"></param>
        /// <returns></returns>
        public bool Update(tsuhan_sg_bhd bh)
        {
            return dal.Update(bh);
        }
    }
}
