using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using Maticsoft.Model;
using System.Data;

namespace BLL
{
    public class FanXiuBLL
    {
        FanXiuDAL dal = new FanXiuDAL();

        public DataSet GetFXtable()
        {
            return dal.GetFXtable();
        }
        
        /// <summary>
        /// 判断序列号是否存在
        /// </summary>
        /// <param name="xlh"></param>
        /// <returns></returns>
        public bool Exists(string xlh)
        {
            return dal.Exists(xlh); ;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="fxmodel"></param>
        /// <returns></returns>
        public bool Add(tsuhan_scgl_fx fxmodel)
        {
            return dal.Add(fxmodel);
        }

        public tsuhan_scgl_fx SelectAllXlh(string xlh)
        {
            return dal.SelectAllXlh(xlh);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="fx"></param>
        /// <returns></returns>
        public bool Update(tsuhan_scgl_fx fx)
        {
           return dal.Update(fx);
        }

        /// <summary>
        /// 判断是否有关联码
        /// </summary>
        /// <param name="gl"></param>
        /// <returns></returns>
        public bool Exist(string gl)
        {
            return dal.Exist(gl);
        }

        /// <summary>
        /// 根据关联码查询信息
        /// </summary>
        /// <param name="gl"></param>
        /// <returns></returns>
        public tsuhan_scgl_fx SelectGLM(string gl)
        {
            return dal.SelectGLM(gl);
        }

        /// <summary>
        /// 根据出时间查询
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public DataSet GetSelectTime(string time1,string time2)
        {
            return dal.GetSelectTime(time1,time2);
        }
    }
}
