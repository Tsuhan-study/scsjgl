using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Maticsoft.Model;
using System.Data;

namespace BLL
{
    public class YhBLL
    {
        YhDAL yhdal = new YhDAL();
       
		
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string name,string pwd)
		{
            return yhdal.Exists(name, pwd);
		}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exist(string 工号)
        {
            return yhdal.Exist(工号);
        }


        /// <summary>
        /// 根据工号查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public tsuhan_scgl_yh GetModel(string 工号)
        {
            return yhdal.GetModel(工号);
        }

        ///// <summary>
        ///// 根据姓名查询
        ///// </summary>
        ///// <param name="name"></param>
        ///// <returns></returns>
        //public tsuhan_scgl_yh GetModelName(string 姓名)
        //{
        //    return yhdal.GetModelName(姓名);
        //}

        /// <summary>
        /// 查询所有的用户信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return yhdal.getAll();
        }

        /// <summary>
        /// 查询在职员工信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll1()
        {
            return yhdal.getAll1();
        }

        /// <summary>
        /// 查询离职员工信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll2()
        {
            return yhdal.getAll2();
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="yh"></param>
        /// <returns></returns>
        public bool Add(tsuhan_scgl_yh yh)
        {
            return yhdal.Add(yh);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="yh"></param>
        /// <returns></returns>
        public bool Update(tsuhan_scgl_yh yh)
        {
            return yhdal.Update(yh);
        }

        //public bool Exists(string 姓名)
        //{
        //    return yhdal.Exists(姓名); ;
        //}
    }
}


