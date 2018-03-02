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
    //ec_ad
    public class AdDAL : BaseDAL, IAdDAL
    {
        public AdDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Ad model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_ad(");
            sql.Append("position_id,type,name,url,thumb,code,summary,discription,start_time,end_time,clicks,add_time,sort_order,status,ad_type");
            sql.Append(") values (");
            sql.Append("@position_id,@type,@name,@url,@thumb,@code,@summary,@discription,@start_time,@end_time,@clicks,@add_time,@sort_order,@status,@ad_type");
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
        public void Update(Wuyiju.Model.Ad model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_Ad set ");

            sql.Append(" position_id = @position_id , ");
            sql.Append(" type = @type , ");
            sql.Append(" name = @name , ");
            sql.Append(" url = @url , ");
            sql.Append(" thumb = @thumb , ");
            sql.Append(" code = @code , ");
            sql.Append(" summary = @summary , ");
            sql.Append(" discription = @discription , ");
            sql.Append(" start_time = @start_time , ");
            sql.Append(" end_time = @end_time , ");
            sql.Append(" clicks = @clicks , ");
            sql.Append(" sort_order = @sort_order , ");
            sql.Append(" status = @status , ");
            sql.Append(" ad_type = @ad_type  ");
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
            sql.Append("delete from ec_ad ");
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
        public Wuyiju.Model.Ad Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, position_id, type, name, url, thumb, code, summary, discription, start_time, end_time, clicks, add_time, sort_order, status, ad_type  ");
            sql.Append("  from ec_ad ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Ad>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Ad> GetList(Wuyiju.Model.Ad.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ad where 1 = 1 ");

            sql.AndEquals("ad_type")
                .AndEquals("status")
                .AndEquals("type")
                .AndEquals("position_id");

            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Ad>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Ad> GetList(Wuyiju.Model.Ad.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ad where 1 = 1 ");

            sql.AndEquals("ad_type")
                .AndEquals("status")
                .AndEquals("type")
                .AndEquals("position_id");

            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Ad>(sql, param);
        }

        public Paged<Wuyiju.Model.Ad> GetPaged(PagedQuery<Wuyiju.Model.Ad.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ad where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Ad>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}