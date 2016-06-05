using CandyJun.Blog.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Dal
{
    public class DalBase<T> where T : ModelBase
    {
        public T GetById(long id)
        {
            using (IDbConnection conn = DapperHelper.GetSqlConnection())
            {
                string sqlCommandText = string.Format("SELECT * FROM {0} where id=@id", typeof(T).Name);
                var user = conn.Query<T>(sqlCommandText, new { id = id }, null, true, default(int?), default(CommandType?))
                    .SingleOrDefault();
                return user;
            }
        }
    }
}
