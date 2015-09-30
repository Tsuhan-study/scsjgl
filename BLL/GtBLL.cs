using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using Maticsoft.Model;

namespace BLL
{
   
    public class GtBLL
    {
        GtDAL gtdal = new GtDAL();

        /// <summary>
        /// 根据备货单号查询信息
        /// </summary>
        /// <param name="tbs"></param>
        /// <returns></returns>
        public bool Exists(string 备货单号)
        {
            return gtdal.Exists(备货单号);
        }

        /// <summary>
        /// 查询详细信息
        /// </summary>
        /// <param name="tbs"></param>
        /// <returns></returns>
        public tsuhan_sg_gt GetModel(string 备货单号)
        {
            return gtdal.GetModel(备货单号);
        }

        /// <summary>
        /// 修改tsuhan_sg_gt表信息
        /// </summary>
        /// <param name="mogt"></param>
        /// <returns></returns>
        public bool Update(tsuhan_sg_gt mogt)
        {
            return gtdal.Update(mogt);
        }

        /// <summary>
        /// 新增tsuhan_sg_gt表信息
        /// </summary>
        /// <param name="mogt"></param>
        /// <returns></returns>
        public bool Add(tsuhan_sg_gt mogt)
        {
           return gtdal.Add(mogt);
        }

        /// <summary>
        /// 绑定备货单号
        /// </summary>
        /// <returns></returns>
        public DataTable GetGts()
        {
            return gtdal.GetGts();
        }
    }
}
