using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using Maticsoft.Model;

namespace BLL
{
    /// <summary>
    /// 对tsuhan_spec表的操作
    /// </summary>
    public class SpecBLL
    {
        SpecDAL specdal = new SpecDAL();

        /// <summary>
        /// 查询绑定规格书
        /// </summary>
        /// <returns></returns>
        public DataTable GetSpecsTable()
        {
            return specdal.GetSpecsTable();
        }

        /// <summary>
        /// 根据规格书编号查询相关信息
        /// </summary>
        /// <param name="ghs"></param>
        /// <returns></returns>
        public tsuhan_spec GetModel(string ghs)
        {
            return specdal.GetModel(ghs);
        }

        /// <summary>
        /// 新增规格书
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public bool Add(tsuhan_spec spec)
        {
            return specdal.Add(spec);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="sgs"></param>
        /// <returns></returns>
        public bool Exists(string sgs)
        {
            return specdal.Exists(sgs);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="spec"></param>
        /// <returns></returns>
        public bool Update(tsuhan_spec spec)
        {
            return specdal.Update(spec);
        }


        public DataSet Query()
        {
            return specdal.Query();
        }
    }
}
