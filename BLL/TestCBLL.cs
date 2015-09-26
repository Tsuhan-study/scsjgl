using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Maticsoft.Model;

namespace BLL
{
    public class TestCBLL
    {
        private readonly Maticsoft.DAL.tsuhan_test_c dal=new Maticsoft.DAL.tsuhan_test_c();



        public tsuhan_test_c GetModel(string xlh)
        {
            return dal.GetModel(xlh); ;
        }

        public tsuhan_test_c SelectC(string xlh)
        {
           return dal.SelectC(xlh);
        }

        public bool Exists(string xlh)
        {
            return dal.Exists(xlh); ;
        }
    }
}
