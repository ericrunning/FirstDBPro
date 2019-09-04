using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinDAL;

namespace BinBLL
{
    public class bllTest
    {
        public int rev;
        private DALServer htServers;
        public bllTest()
        {
            htServers = new DALServer();
            rev = 0;
        }
        /// <summary>
        /// BLL层的测试调用DAL层的一个接口
        /// </summary>
        /// <returns>返回一个整型</returns>
        public int GetValueFromDB(string sql)
        {
            return this.htServers.GetValue(sql);
        }
    }
}
