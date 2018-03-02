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
    //ec_title
    public class TitleDAL : BaseDAL, ITitleDAL
    {
        public TitleDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Title model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_title(");
            sql.Append("name,scname,img,parent_id,sort,status,recommend,color,seo_title,seo_keys,seo_desc,brief,content,style_file,show_in_nav,filter_attr,folder,filename,type,is_hots,url_type");
            sql.Append(") values (");
            sql.Append("@name,@scname,@img,@parent_id,@sort,@status,@recommend,@color,@seo_title,@seo_keys,@seo_desc,@brief,@content,@style_file,@show_in_nav,@filter_attr,@folder,@filename,@type,@is_hots,@url_type");
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
        public void Update(Wuyiju.Model.Title model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_title set ");

            sql.Append(" name = @name , ");
            sql.Append(" scname = @scname , ");
            sql.Append(" img = @img , ");
            sql.Append(" parent_id = @parent_id , ");
            sql.Append(" sort = @sort , ");
            sql.Append(" status = @status , ");
            sql.Append(" recommend = @recommend , ");
            sql.Append(" color = @color , ");
            sql.Append(" seo_title = @seo_title , ");
            sql.Append(" seo_keys = @seo_keys , ");
            sql.Append(" seo_desc = @seo_desc , ");
            sql.Append(" brief = @brief , ");
            sql.Append(" content = @content , ");
            sql.Append(" style_file = @style_file , ");
            sql.Append(" show_in_nav = @show_in_nav , ");
            sql.Append(" filter_attr = @filter_attr , ");
            sql.Append(" folder = @folder , ");
            sql.Append(" filename = @filename , ");
            sql.Append(" type = @type , ");
            sql.Append(" is_hots = @is_hots , ");
            sql.Append(" url_type = @url_type  ");
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
            sql.Append("delete from ec_title ");
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
        public Wuyiju.Model.Title Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, name, scname, img, parent_id, sort, status, recommend, color, seo_title, seo_keys, seo_desc, brief, content, style_file, show_in_nav, filter_attr, folder, filename, type, is_hots, url_type  ");
            sql.Append("  from ec_title ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Title>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Title> GetList(Wuyiju.Model.Title.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_title where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("parent_id")
                .AndEquals("status")
                .AndEquals("recommend")
                .AndEquals("show_in_nav")
                .AndEquals("type")
                .AndEquals("is_hots")
                .AndEquals("url_type");

            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Title>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Title> GetList(Wuyiju.Model.Title.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_title where 1 = 1 ");

            sql.AndEquals("parent_id")
                .AndEquals("status")
                .AndEquals("recommend")
                .AndEquals("show_in_nav")
                .AndEquals("type")
                .AndEquals("is_hots")
                .AndEquals("url_type");

            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Title>(sql, param);
        }

        public Paged<Wuyiju.Model.Title> GetPaged(PagedQuery<Wuyiju.Model.Title.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_title where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Title>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}