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
    //ec_attribute
    public class AttributeDAL : BaseDAL, IAttributeDAL
    {
        public AttributeDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Attribute model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_attribute(");
            sql.Append("name,pid,level,sort,status,input,type,recommend,extend1,extend2");
            sql.Append(") values (");
            sql.Append("@name,@pid,@level,@sort,@status,@input,@type,@recommend,@extend1,@extend2");
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
        public void Update(Wuyiju.Model.Attribute model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_attribute set ");

            sql.Append(" name = @name , ");
            sql.Append(" pid = @pid , ");
            sql.Append(" level = @level , ");
            sql.Append(" sort = @sort , ");
            sql.Append(" status = @status , ");
            sql.Append(" input = @input , ");
            sql.Append(" type = @type , ");
            sql.Append(" recommend = @recommend , ");
            sql.Append(" extend1 = @extend1 , ");
            sql.Append(" extend2 = @extend2  ");
            sql.Append(" where id=@id ");

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
        public void Delete(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ec_attribute ");
            sql.Append(" where id=@id");
            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Wuyiju.Model.Attribute Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, name, pid, level, sort, status, input, type, recommend, extend1, extend2  ");
            sql.Append("  from ec_attribute ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Attribute>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Attribute> GetList(Wuyiju.Model.Attribute.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_attribute where (1 = 1)");
            DynamicParameters param = new DynamicParameters();
            sql.AndEquals("pid")
               .AndEquals("level")
               .AndEquals("recommend")
               .AndEquals("status");
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Attribute>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Attribute> GetList(Wuyiju.Model.Attribute.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_attribute where 1 = 1 ");

            sql.AndEquals("pid")
                .AndEquals("level")
                .AndEquals("status")
                .AndEquals("recommend")
                .AndEquals("input");

            sql.Append(" order by sort ");

            if (limit != null) sql.Append(" limit  @rows ");

            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Attribute>(sql, param);
        }

        public Paged<Wuyiju.Model.Attribute> GetPaged(PagedQuery<Wuyiju.Model.Attribute.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_attribute where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Attribute>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}