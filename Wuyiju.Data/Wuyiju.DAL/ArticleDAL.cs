using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Model;
using Wuyiju.View;
using Wuyiju.Core;
using Wuyiju.IDAL;
using Dapper;
namespace Wuyiju.DAL
{
    //ec_article
    public class ArticleDAL : BaseDAL, IArticleDAL
    {
        public ArticleDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Article model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_article(");
            sql.Append("cate_id,title,`from`,img,url,brief,info,add_time,sort_order,is_hot,is_best,status,seo_title,seo_keys,seo_desc,filename,click");
            sql.Append(") values (");
            sql.Append("@cate_id,@title,@from,@img,@url,@brief,@info,@add_time,@sort_order,@is_hot,@is_best,@status,@seo_title,@seo_keys,@seo_desc,@filename,@click");
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
        public void Update(Wuyiju.Model.Article model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_article set ");
            sql.Append(" cate_id = @cate_id , ");
            sql.Append(" title = @title , ");
            sql.Append(" `from` = @from , ");
            sql.Append(" img = @img , ");
            sql.Append(" url = @url , ");
            sql.Append(" brief = @brief , ");
            sql.Append(" info = @info , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" sort_order = @sort_order , ");
            sql.Append(" is_hot = @is_hot , ");
            sql.Append(" is_best = @is_best , ");
            sql.Append(" status = @status , ");
            sql.Append(" seo_title = @seo_title , ");
            sql.Append(" seo_keys = @seo_keys , ");
            sql.Append(" seo_desc = @seo_desc , ");
            sql.Append(" filename = @filename , ");
            sql.Append(" click = @click  ");
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
            sql.Append("delete from ec_article ");
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
        public Wuyiju.Model.Article Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select a.id, a.cate_id, t.name as cate_name, a.title, a.`from`, a.img, a.url, a.brief, a.info, a.add_time, a.sort_order, a.is_hot, a.is_best, a.status, a.seo_title, a.seo_keys, a.seo_desc, a.filename, a.click  ");
            sql.Append("  from ec_article a");
            sql.Append("  left join ec_title t on a.cate_id = t.id ");
            sql.Append(" where a.id = @id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Article>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Article> GetList(Wuyiju.Model.Article.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("cate_id").AndEquals("status").AndEquals("is_hot").AndEquals("is_best");

            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Article>(sql, param);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.View._Article> GetAllList()
        {
            StringBuilder sql = new StringBuilder(@"SELECT t.*,n.name FROM ec_article t INNER JOIN ec_title n on t.cate_id = n.id");
            DynamicParameters param = new DynamicParameters();
            return db.GetList<Wuyiju.View._Article>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Article> GetList(Wuyiju.Model.Article.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article where 1 = 1 ");

            sql.AndEquals("cate_id").AndEquals("status").AndEquals("is_hot").AndEquals("is_best");

            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Article>(sql, param);
        }

        public Paged<Wuyiju.Model.Article> GetPaged(PagedQuery<Wuyiju.Model.Article.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article where 1 = 1 ");

            sql.AndEquals("cate_id").AndEquals("status").AndEquals("is_hot").AndEquals("is_best").AndLike("title");

            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Article>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }

        public int GetCount(Wuyiju.Model.Article.Query query)
        {
            StringBuilder sql = new StringBuilder(@"select count(*) from ec_article where 1=1 ");

            sql.AndDateBetween("add_time", "startdate", "enddate");

            DynamicParameters param = new DynamicParameters();


            if (query != null)
            {
                param.AddDynamicParams(query);
            }

            return db.ExecuteScalar<int>(sql.ToString(),param);
        }

    }
}