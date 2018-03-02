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
    //ec_favorites
    public class FavoritesDAL : BaseDAL, IFavoritesDAL
    {
        public FavoritesDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Favorites model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_favorites(");
            sql.Append("user_id,product_id,add_time,type");
            sql.Append(") values (");
            sql.Append("@user_id,@product_id,@add_time,@type");
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
        public void Update(Wuyiju.Model.Favorites model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update Favorites set ");

            sql.Append(" user_id = @user_id , ");
            sql.Append(" product_id = @product_id , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" type = @type  ");
            sql.Append(" where rec_id=@rec_id ");

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
        public void Delete(int rec_id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ec_favorites ");
            sql.Append(" where rec_id=@rec_id");
            DynamicParameters param = new DynamicParameters();
            param.Add("rec_id", rec_id);

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Wuyiju.Model.Favorites Get(int rec_id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select rec_id, user_id, product_id, add_time, type  ");
            sql.Append("  from ec_favorites ");
            sql.Append(" where rec_id=@rec_id");

            DynamicParameters param = new DynamicParameters();
            param.Add("rec_id", rec_id);

            return db.Get<Wuyiju.Model.Favorites>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Favorites> GetList(Wuyiju.Model.Favorites.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_favorites where 1 = 1 ");

            sql.AndEquals("type").AndEquals("product_id").AndEquals("user_id");

            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Favorites>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Favorites> GetList(Wuyiju.Model.Favorites.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_favorites where 1 = 1 ");

            sql.AndEquals("type").AndEquals("product_id").AndEquals("user_id");

            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Favorites>(sql, param);
        }

        public Paged<Wuyiju.Model.Favorites> GetPaged(PagedQuery<Wuyiju.Model.Favorites.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_favorites where 1 = 1 ");

            sql.AndEquals("type").AndEquals("product_id").AndEquals("user_id");

            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Favorites>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}