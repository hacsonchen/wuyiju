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
    //ec_category
    public class CategoryDAL : BaseDAL, ICategoryDAL
    {
        public CategoryDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Category model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_category(");
            sql.Append("type,parent_id,name,brief,seo_title,seo_keys,seo_desc,img,sort,status,is_hot,is_recommend,show_in_nav,bank_id,is_extend,filter_attr,add_time,admin_id,is_del,css_cla");
            sql.Append(") values (");
            sql.Append("@type,@parent_id,@name,@brief,@seo_title,@seo_keys,@seo_desc,@img,@sort,@status,@is_hot,@is_recommend,@show_in_nav,@bank_id,@is_extend,@filter_attr,@add_time,@admin_id,@is_del,@css_cla");
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
        public void Update(Wuyiju.Model.Category model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_category set ");

            sql.Append(" type = @type , ");
            sql.Append(" parent_id = @parent_id , ");
            sql.Append(" name = @name , ");
            sql.Append(" brief = @brief , ");
            sql.Append(" seo_title = @seo_title , ");
            sql.Append(" seo_keys = @seo_keys , ");
            sql.Append(" seo_desc = @seo_desc , ");
            sql.Append(" img = @img , ");
            sql.Append(" sort = @sort , ");
            sql.Append(" status = @status , ");
            sql.Append(" is_hot = @is_hot , ");
            sql.Append(" is_recommend = @is_recommend , ");
            sql.Append(" show_in_nav = @show_in_nav , ");
            sql.Append(" bank_id = @bank_id , ");
            sql.Append(" is_extend = @is_extend , ");
            sql.Append(" filter_attr = @filter_attr , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" admin_id = @admin_id , ");
            sql.Append(" is_del = @is_del , ");
            sql.Append(" css_cla = @css_cla  ");
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
            sql.Append("delete from ec_category ");
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
        public Wuyiju.Model.Category Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, type, parent_id, name, brief, seo_title, seo_keys, seo_desc, img, sort, status, is_hot, is_recommend, show_in_nav, bank_id, is_extend, filter_attr, add_time, admin_id, is_del, css_cla  ");
            sql.Append("  from ec_category ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Category>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Category> GetList(Wuyiju.Model.Category.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_category where 1 = 1 ");

            sql.AndEquals("status").AndEquals("parent_id");

            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Category>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Category> GetList(Wuyiju.Model.Category.Query filter, int[] limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_category where 1 = 1 ");

            sql.AndEquals("status").AndEquals("parent_id").AndEquals("is_recommend", "recommend");


            if (limit != null)
            {
                if (limit.Length == 1)
                    sql.Append(" limit @rows ");

                if (limit.Length == 2)
                    sql.Append(" limit @start,@rows ");
            }

            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }

            if (limit != null)
            {
                if (limit.Length == 1)
                    param.Add("rows", limit[0]);

                if (limit.Length == 2)
                {
                    param.Add("start", limit[0]);
                    param.Add("rows", limit[1]);
                }
            }

            return db.GetList<Wuyiju.Model.Category>(sql, param);
        }

        public Paged<Wuyiju.Model.Category> GetPaged(PagedQuery<Wuyiju.Model.Category.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_category where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Category>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}