using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class ChanPxhBLL
    {
        ChanPxhDAL dal = new ChanPxhDAL();

        /// <summary>
        /// 查询所有产品类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetChanPTable()
        {
            return dal.GetChanPTable();
        }
    }
}
