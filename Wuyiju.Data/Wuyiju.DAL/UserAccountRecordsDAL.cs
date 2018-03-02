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
    //ec_user_account_records
    public class UserAccountRecordsDAL : BaseDAL, IUserAccountRecordsDAL
    {
        public UserAccountRecordsDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.UserAccountRecords model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_user_account_records(");
            sql.Append("user_id,username,money,frozen_money,balance,rank_points,points,add_time,desc,type,way");
            sql.Append(") values (");
            sql.Append("@user_id,@username,@money,@frozen_money,@balance,@rank_points,@points,@add_time,@desc,@type,@way");
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
        public void Update(Wuyiju.Model.UserAccountRecords model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update UserAccountRecords set ");

            sql.Append(" user_id = @user_id , ");
            sql.Append(" username = @username , ");
            sql.Append(" money = @money , ");
            sql.Append(" frozen_money = @frozen_money , ");
            sql.Append(" balance = @balance , ");
            sql.Append(" rank_points = @rank_points , ");
            sql.Append(" points = @points , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" desc = @desc , ");
            sql.Append(" type = @type , ");
            sql.Append(" way = @way  ");
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
            sql.Append("delete from ec_user_account_records ");
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
        public Wuyiju.Model.UserAccountRecords Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, user_id, username, money, frozen_money, balance, rank_points, points, add_time, desc, type, way  ");
            sql.Append("  from ec_user_account_records ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.UserAccountRecords>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.UserAccountRecords> GetList(Wuyiju.Model.UserAccountRecords.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_account_records where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.UserAccountRecords>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.UserAccountRecords> GetList(Wuyiju.Model.UserAccountRecords.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_account_records where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.UserAccountRecords>(sql, param);
        }

        public Paged<Wuyiju.Model.UserAccountRecords> GetPaged(PagedQuery<Wuyiju.Model.UserAccountRecords.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_account_records where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("way")
                .AndEquals("user_id")
                .AndBetween("money","Smoney","Emoney")
                .AndBetween("frozen_money", "FrozenSmoney", "FrozenEmoney")
                .AndDateBetween("add_time","StartDate","EndDate")
                .AndLike("`desc`","keyword");

            if (query.Filter.Check != null && query.Filter.Check.Length > 0)
            {
                sql.Append(" and `type` in @check ");
            }

            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.UserAccountRecords>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}