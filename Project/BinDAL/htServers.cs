using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BinDAL
{
    public class htServers
    {
        // 在此声明一个接收数据库结果集的变量
        public int rev;
        private SqlConnection connection;
        private SqlCommand command;
        private DALServer dal;

        public htServers()
        {
            //todo 在 构造函数中创建接收数据库结果集的变量
            rev = 0;
        }
    }
}
