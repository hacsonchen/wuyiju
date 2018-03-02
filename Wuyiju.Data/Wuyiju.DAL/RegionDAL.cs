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
    //ec_region
    public class RegionDAL : BaseDAL, IRegionDAL
    {
        public RegionDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Region model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_region(");
            sql.Append("parent_id,region_name,region_type,agency_id");
            sql.Append(") values (");
            sql.Append("@parent_id,@region_name,@region_type,@agency_id");
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
        public void Update(Wuyiju.Model.Region model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update Region set ");

            sql.Append(" parent_id = @parent_id , ");
            sql.Append(" region_name = @region_name , ");
            sql.Append(" region_type = @region_type , ");
            sql.Append(" agency_id = @agency_id  ");
            sql.Append(" where region_id=@region_id ");

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
        public void Delete(int region_id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ec_region ");
            sql.Append(" where region_id=@region_id");
            DynamicParameters param = new DynamicParameters();
            param.Add("region_id", region_id);

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Wuyiju.Model.Region Get(int region_id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select region_id, parent_id, region_name, region_type, agency_id  ");
            sql.Append("  from ec_region ");
            sql.Append(" where region_id=@region_id");

            DynamicParameters param = new DynamicParameters();
            param.Add("region_id", region_id);

            return db.Get<Wuyiju.Model.Region>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Region> GetList(Wuyiju.Model.Region.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_region where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("parent_id");

            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Region>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Region> GetList(Wuyiju.Model.Region.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_region where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Region>(sql, param);
        }

        public Paged<Wuyiju.Model.Region> GetPaged(PagedQuery<Wuyiju.Model.Region.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_region where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Region>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}