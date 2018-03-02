using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Core
{
    public class SQL
    {
        private StringBuilder sqlBuilder;
        private DynamicParameters param;

        public SQL(string sql)
        {
            param = new DynamicParameters();
            sqlBuilder = new StringBuilder(sql);
        }

        public SQL(string sql, object values)
        {
            param = new DynamicParameters();

            if (values != null)
            {
                param.AddDynamicParams(values);
            }

            sqlBuilder = new StringBuilder(sql);
        }

        public void Append(string sql)
        {
            sqlBuilder.Append(sql);
        }

        public void AndEuqal(string columnName)
        {
            sqlBuilder.AppendFormat(" and ({0} = @{0} or @{0} is null) ", columnName);
        }

        public void AndEuqal(string columnName, object value)
        {
            sqlBuilder.AppendFormat(" and ({0} = @{0} or @{0} is null) ", columnName);
            param.Add(columnName, value);

        }

        public override string ToString()
        {
            return sqlBuilder.ToString();
        }
    }
}
