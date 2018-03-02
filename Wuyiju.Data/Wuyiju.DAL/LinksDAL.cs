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
    //ec_links
    public class LinksDAL : BaseDAL, ILinksDAL
    {
        public LinksDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Links model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_links(");
            sql.Append("company,name,url,sort,status,start_time,end_time,keyword,brief,contact,phone,qq,add_time,category,img,recommend");
            sql.Append(") values (");
            sql.Append("@company,@name,@url,@sort,@status,@start_time,@end_time,@keyword,@brief,@contact,@phone,@qq,@add_time,@category,@img,@recommend");
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
        public void Update(Wuyiju.Model.Links model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_links set ");

            sql.Append(" company = @company , ");
            sql.Append(" name = @name , ");
            sql.Append(" url = @url , ");
            sql.Append(" sort = @sort , ");
            sql.Append(" status = @status , ");
            sql.Append(" start_time = @start_time , ");
            sql.Append(" end_time = @end_time , ");
            sql.Append(" keyword = @keyword , ");
            sql.Append(" brief = @brief , ");
            sql.Append(" contact = @contact , ");
            sql.Append(" phone = @phone , ");
            sql.Append(" qq = @qq , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" category = @category , ");
            sql.Append(" img = @img , ");
            sql.Append(" recommend = @recommend  ");
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
            sql.Append("delete from ec_links ");
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
        public Wuyiju.Model.Links Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, company, name, url, sort, status, start_time, end_time, keyword, brief, contact, phone, qq, add_time, category, img, recommend  ");
            sql.Append("  from ec_links ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Links>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Links> GetList(Wuyiju.Model.Links.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_links where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("status").AndEquals("recommend");

            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Links>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Links> GetList(Wuyiju.Model.Links.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_links where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Links>(sql, param);
        }

        public Paged<Wuyiju.Model.Links> GetPaged(PagedQuery<Wuyiju.Model.Links.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_links where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Links>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}