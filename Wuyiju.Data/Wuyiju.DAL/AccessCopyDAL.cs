using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Model;
using Wuyiju.Core;
using Wuyiju.IDAL;
using Dapper;
namespace Wuyiju.DAL
{
    //ec_access_copy
    public class AccessCopyDAL : BaseDAL, IAccessCopyDAL
    {
        public AccessCopyDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.AccessCopy model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_access_copy(");
            sql.Append("role_id,node_id,level,module");
            sql.Append(") values (");
            sql.Append("@role_id,@node_id,@level,@module");
            sql.Append(") ");

            DynamicParameters param = new DynamicParameters();
            if (model != null)
            {
                param.AddDynamicParams(model);
            }

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("插入数据无效");
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Wuyiju.Model.AccessCopy model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_accesscopy set ");

            sql.Append(" role_id = @role_id , ");
            sql.Append(" node_id = @node_id , ");
            sql.Append(" level = @level , ");
            sql.Append(" module = @module  ");
            sql.Append(" where  role_id = @role_id, node_id = @node_id");

            DynamicParameters param = new DynamicParameters();
            if (model != null)
            {
                param.AddDynamicParams(model);
            }

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("更新数据无效");

        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(Wuyiju.Model.AccessCopy model)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ec_access_copy ");
            sql.Append(" where  role_id = @role_id, node_id = @node_id");
            DynamicParameters param = new DynamicParameters();
            //param.Add("id", id);
            if (model != null)
            {
                param.AddDynamicParams(model);
            }

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Wuyiju.Model.AccessCopy Get(Wuyiju.Model.AccessCopy model)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select role_id, node_id, level, module  ");
            sql.Append("  from ec_access_copy ");
            sql.Append(" where  role_id = @role_id, node_id = @node_id");

            DynamicParameters param = new DynamicParameters();
            //param.Add("id", id);
            if (model != null)
            {
                param.AddDynamicParams(model);
            }

            return db.Get<Wuyiju.Model.AccessCopy>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.AccessCopy> GetList(Wuyiju.Model.AccessCopy.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_access_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.AccessCopy>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.AccessCopy> GetList(Wuyiju.Model.AccessCopy.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_access_copy where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.AccessCopy>(sql, param);
        }

        public Paged<Wuyiju.Model.AccessCopy> GetPaged(PagedQuery<Wuyiju.Model.AccessCopy.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_access_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.AccessCopy>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}