using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using Maticsoft.Model;

namespace BLL
{
    public class KeHdmBLL
    {
        KeHdmDAL dal = new KeHdmDAL();

        /// <summary>
        /// 查询所有的客户代码
        /// </summary>
        /// <returns></returns>
        public DataSet GetKeHTable()
        {
            return dal.GetKeHTable();
        }

        /// <summary>
        /// 判断客户代码是否存在
        /// </summary>
        /// <param name="dm"></param>
        /// <returns></returns>
        public bool Exist(string dm)
        {
            return dal.Exist(dm) ;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="khdms"></param>
        /// <returns></returns>
        public bool Add(tsuhan_scgl_khdm khdms)
        {
            return dal.Add(khdms); ;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="kh"></param>
        /// <returns></returns>
        public bool Delete(string kh)
        {
            return dal.Delete(kh); ;
        }
    }
}
