using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Wuyiju.Core
{
    public class DataContext : IDisposable
    {
        private IDbConnection connection;
        private IDbTransaction transaction;
        private static object syncObj = new object();

        public DataContext()
        {
            GetConnection();
        }

        public IDbConnection GetConnection()
        {
            if (connection == null)
            {
                connection = ConnectionFactory.CreateConnection();
            }

            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }

        public void CloseConnection()
        {
            if (connection != null && this.transaction == null)
            {
                connection.Close();
                connection.Dispose();
                //connection = null;
            }
        }

        public void BeginTransaction()
        {
            if (this.transaction == null)
            {
                this.GetConnection();
                this.transaction = connection.BeginTransaction();

            }
        }

        public int Execute(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            lock (syncObj)
            {
                try
                {
                    this.GetConnection();
                    var result = connection.Execute(sql, param, transaction, commandTimeout, commandType);

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //finally
                //{
                //    this.CloseConnection();

                //}

            }
        }

        public int Execute(StringBuilder sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {

            return Execute(sql.ToString(), param, commandTimeout, commandType);

        }

        public IDataReader ExecuteReader(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var conn = this.GetConnection();

            IDataReader result;

            try
            {
                result = connection.ExecuteReader(sql, param, transaction, commandTimeout, commandType);
                this.CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;

            }


        }


        public object ExecuteScalar(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            this.GetConnection();

            try
            {
                var result = connection.ExecuteScalar(sql, param, transaction, commandTimeout, commandType);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public T ExecuteScalar<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            this.GetConnection();
            try
            {
                var result = connection.ExecuteScalar<T>(sql, param, transaction, commandTimeout, commandType);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //finally
            //{
            //    this.CloseConnection();
            //}
        }

        public IList<T> GetList<T>(StringBuilder sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return GetList<T>(sql.ToString(), param, commandTimeout, commandType);
        }

        public IList<T> GetList<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {

            lock (syncObj)
            {
                this.GetConnection();
                try
                {
                    var result = connection.Query<T>(sql, param, transaction, true, commandTimeout, commandType).ToList<T>();
                    this.CloseConnection();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //finally
                //{
                //    this.CloseConnection();
                //}
            }
        }

        public Paged<T> GetPaged<T>(StringBuilder sql, DynamicParameters param, int pageStart, int pageSize, int draw = 0, IEnumerable<OrderRule> order = null)
        {

            param.Add("pagestart", pageStart * pageSize - pageSize);
            param.Add("pagesize", pageSize);

            int total = 0;
            var list = new List<T>();

            lock (syncObj)
            {
                this.GetConnection();
                try
                {
                    list = connection.Query<T>(sql.ToPagedSQL(order), param, transaction, true).ToList<T>();
                    var res = connection.ExecuteScalar(sql.ToCountSQL(), param, transaction);

                    if (res != null)
                    {
                        total = Convert.ToInt32(res);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //finally
                //{
                //    this.CloseConnection();
                //}


            }


            Paged<T> result = new Paged<T>(list, total, pageStart, pageSize, draw);


            return result;
        }

        public int Count(StringBuilder sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            int total = 0;

            lock (syncObj)
            {

                this.GetConnection();

                try
                {
                    var res = connection.ExecuteScalar(sql.ToCountSQL(), param, transaction);
                    if (res != null)
                    {
                        total = Convert.ToInt32(res);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //finally
                //{
                //    CloseConnection();
                //}
            }

            return total;
        }

        public T Get<T>(StringBuilder sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Get<T>(sql.ToString(), param, commandTimeout, commandType);
        }

        public T Get<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            lock (syncObj)
            {
                this.GetConnection();
                try
                {
                    var result = connection.Query<T>(sql, param, transaction, true, commandTimeout, commandType).SingleOrDefault<T>();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //finally
                //{
                //    this.CloseConnection();
                //}


            }
        }

        public void Commit()
        {
            if (this.transaction != null)
            {
                this.transaction.Commit();

                this.transaction.Dispose();
                this.transaction = null;

                this.CloseConnection();
            }
        }

        public void Rollback()
        {
            if (this.transaction != null)
            {
                this.transaction.Rollback();

                this.transaction.Dispose();
                this.transaction = null;

                this.CloseConnection();
            }
        }

        public void Dispose()
        {
            this.CloseConnection();
        }
    }
}
