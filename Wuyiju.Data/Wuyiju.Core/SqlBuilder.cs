using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wuyiju.Core
{



    public static class SqlBuilder
    {


        public static string ToPagedSQL(this StringBuilder sql,IEnumerable<OrderRule> order = null)
        {
            var pagedSql = new StringBuilder();
            pagedSql.AppendFormat(@"select * from (
                                    {0}
                                    ) v ", sql.ToString());

            pagedSql.AppendOrderRules(order);

            pagedSql.AppendFormat(" limit @pagestart,@pagesize ");

            return pagedSql.ToString();
        }

        public static string ToCountSQL(this StringBuilder sql)
        {
            var pagedSql = new StringBuilder();
            pagedSql.AppendFormat(@"select count(*) from (
                                    {0}
                                    ) v ", sql.ToString());
            return pagedSql.ToString();
        }

        public static int ReadRecordsCount(this IDataReader reader, string totalFieldName = "Rercords_Total")
        {
            return reader.GetInt32(reader.GetOrdinal(totalFieldName));
        }

        public static StringBuilder AndDateBetween(this StringBuilder sql, string columnName, string paramName1,string paramName2)
        {
            return sql.AppendFormat(" and ({0} >=  UNIX_TIMESTAMP(@{1}) or @{1} is null) and ({0} <=  UNIX_TIMESTAMP(@{2}) or @{2} is null) ", columnName, paramName1,paramName2);
        }

        public static StringBuilder AndBetween(this StringBuilder sql, string columnName, string paramName1, string paramName2)
        {
            return sql.AppendFormat(" and ({0} >=  @{1} or @{1} is null) and ({0} <=  @{2} or @{2} is null) ", columnName, paramName1, paramName2);
        }

        public static StringBuilder AndEquals(this StringBuilder sql, string columnName, string paramName)
        {
            return sql.AppendFormat(" and ({0} = @{1} or @{1} is null) ", columnName, paramName);
        }

        public static StringBuilder AndEquals(this StringBuilder sql, string columnName)
        {
            return sql.AppendFormat(" and ({0} = @{1} or @{1} is null) ", columnName, columnName);
        }

        public static StringBuilder AndIn(this StringBuilder sql, string columnName, string paramName)
        {
            return sql.AppendFormat(" and ({0} in @{1} or @{1} is null) ", columnName, paramName);
        }

        //public static StringBuilder AndIn(this StringBuilder sql, string columnName, string value, ref DynamicParameters param)
        //{
        //    var paramName = "p_" + columnName;
        //    if (!string.IsNullOrWhiteSpace(value) && param != null)
        //    {

        //        param.Add(paramName, value.Split(','));
        //        return sql.AppendFormat(" and (({0} in @{1} or @{1} is null) and @{0} is not null) /*@{0}*/", columnName, paramName);
        //    }
        //    else
        //    {
        //        return sql.AppendFormat(" and ({0} in @{1} or @{1} is null) ", columnName, columnName);
        //    }


        //}

        public static StringBuilder AndNotIn(this StringBuilder sql, string columnName, string paramName)
        {
            return sql.AppendFormat(" and ({0} not in @{1} or @{1} is null) ", columnName, paramName);
        }

        public static StringBuilder AndLike(this StringBuilder sql, string columnName)
        {
            return sql.AppendFormat(" and ({0} like CONCAT('%',@{1},'%') or @{1} is null) ", columnName, columnName);
        }

        public static StringBuilder AndLike(this StringBuilder sql, string columnName, string paramName)
        {
            return sql.AppendFormat(" and  ({0} like CONCAT('%',@{1},'%') or @{1} is null) ", columnName, paramName);
        }

        public static StringBuilder OrLike(this StringBuilder sql, string columnName)
        {
            return sql.AppendFormat(" OR ( {0} like CONCAT('%',@{1},'%')) ", columnName, columnName);
        }

        public static StringBuilder OrLike(this StringBuilder sql, string columnName, string paramName)
        {
            return sql.AppendFormat(" OR ( {0} like CONCAT('%',@{1},'%')) ", columnName, paramName);
        }


        public static StringBuilder AppendOrderRules(this StringBuilder builder, IEnumerable<OrderRule> orderRules, bool orderbyExists = false)
        {
            if (orderRules != null)
            {

                List<string> list = new List<string>();
                foreach (OrderRule rule in orderRules)
                {
                    if (!String.IsNullOrWhiteSpace(rule.Column))
                    {
                        string mapped = rule.Column;
                        string dir = rule.dir ?? "asc";
                        dir = dir.Trim().ToLower() == "asc" ? "asc" : "desc";
                        string nullfirst = rule.IfNullsFirst ? "nulls first" : " nulls last";
                       
                        //mapped.Replace("'", String.Empty); // 简单避免SQL注入
                        list.Add(String.Format(" {0} {1} ", mapped, dir)); // 不能加 （），否则报错
      
                    }
                }
                if (!orderbyExists && list.Count > 0)
                {
                    builder.Append(" order by ");
                }
                builder.Append(String.Join(",", list));
            }

            return builder;
        }
    }
}
