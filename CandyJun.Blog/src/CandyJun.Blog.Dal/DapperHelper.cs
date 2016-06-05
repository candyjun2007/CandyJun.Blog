using CandyJun.Blog.Model;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Dal
{
    /// <summary>
    /// dapper帮助类
    /// </summary>
    public class DapperHelper
    {
        //连接数据库字符串。
        public static string SqlConnectionString = "Data Source=RENFB;Initial Catalog=test;User Id=sa;Password=sa;";

        //获取MySql的连接数据库对象。MySqlConnection
        public static MySqlConnection GetSqlConnection()
        {
            MySqlConnection connection = new MySqlConnection(SqlConnectionString);
            connection.Open();
            return connection;
        }
        
    }
}
