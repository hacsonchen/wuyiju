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
    //ec_suggest
    public class SuggestDAL : BaseDAL, ISuggestDAL
    {
        public SuggestDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Suggest model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_suggest(");
            sql.Append("title,`from`,img,url,resp,info,add_time,sort_order,resp_time,is_best,status,seo_title,seo_keys,seo_desc,filename,click,user_id");
            sql.Append(") values (");
            sql.Append("@title,@from,@img,@url,@resp,@info,@add_time,@sort_order,@resp_time,@is_best,@status,@seo_title,@seo_keys,@seo_desc,@filename,@click,@user_id");
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
        public void Update(Wuyiju.Model.Suggest model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_suggest set ");

            sql.Append(" title = @title , ");
            sql.Append(" `from` = @from , ");
            sql.Append(" img = @img , ");
            sql.Append(" url = @url , ");
            sql.Append(" resp = @resp , ");
            sql.Append(" info = @info , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" sort_order = @sort_order , ");
            sql.Append(" resp_time = @resp_time , ");
            sql.Append(" is_best = @is_best , ");
            sql.Append(" status = @status , ");
            sql.Append(" seo_title = @seo_title , ");
            sql.Append(" seo_keys = @seo_keys , ");
            sql.Append(" seo_desc = @seo_desc , ");
            sql.Append(" filename = @filename , ");
            sql.Append(" click = @click , ");
            sql.Append(" user_id = @user_id  ");
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
            sql.Append("delete from ec_suggest ");
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
        public Wuyiju.Model.Suggest Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, title, `from`, img, url, resp, info, add_time, sort_order, resp_time, is_best, status, seo_title, seo_keys, seo_desc, filename, click, user_id  ");
            sql.Append("  from ec_suggest ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Suggest>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Suggest> GetList(Wuyiju.Model.Suggest.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_suggest where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Suggest>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Suggest> GetList(Wuyiju.Model.Suggest.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_suggest where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Suggest>(sql, param);
        }

        public Paged<Wuyiju.Model.Suggest> GetPaged(PagedQuery<Wuyiju.Model.Suggest.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_suggest where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Suggest>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}