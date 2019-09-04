using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using SqlHelper;

namespace BinDAL
{
    public class DALServer
    {
        public int GetValue(string sql)
        {
            return (int)sqlHelper.ExecuteScalar(sql);
        }
    }
}
