using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SqlHelper
{
    public static class sqlHelper
    {
        //定义一个静态连接字符串
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["GinShopConnectionString"].ConnectionString;
        //1.执行增（insert）、删（delete）、改（update）的方法
        //ExecuteNonQuery()
        public static int ExecuteNoQuery(string sql,params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql,con))
                {
                    if(pms!=null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        //2.执行查询，返回单个值的方法
        //ExecuteScalar()
        public static object ExecuteScalar(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        //3.执行查询，返回多行，多列的方法
        //ExecuteReader()
        public static SqlDataReader ExecuteReader(string sql,params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(conStr);
            using (SqlCommand cmd = new SqlCommand(sql,con))
            {
                if(pms!=null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch
                {

                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }
    }
}
