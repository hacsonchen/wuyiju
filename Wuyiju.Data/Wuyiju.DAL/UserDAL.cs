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
    public class UserDAL : BaseDAL, IUserDAL
    {
        public UserDAL(DataContext db) : base(db) { }

        public void Insert(User user)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("insert into ec_user(");
            sql.Append("name,password,pay_password,realname,email,mobile,login_ip,add_time,status,last_time,last_ip,login_count,salt,is_email_validated,is_mobile_validated,money,frozen_money,money_status,rank_points,points,rank_id,sex,brithday,qq,pwd_question,pwd_answer,introducer)");
            sql.Append(" values (");
            sql.Append("@name,@password,@pay_password,@realname,@email,@mobile,@login_ip,@add_time,@status,@last_time,@last_ip,@login_count,@salt,@is_email_validated,@is_mobile_validated,@money,@frozen_money,@money_status,@rank_points,@points,@rank_id,@sex,@brithday,@qq,@pwd_question,@pwd_answer,@introducer)");

            DynamicParameters param = new DynamicParameters();
            if (user != null)
            {
                param.AddDynamicParams(user);
            }

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("插入数据无效");
        }

        public void Update(User user)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("update ec_user set ");
            sql.Append("name=@name,");
            sql.Append("password=@password,");
            sql.Append("pay_password=@pay_password,");
            sql.Append("realname=@realname,");
            sql.Append("email=@email,");
            sql.Append("mobile=@mobile,");
            sql.Append("login_ip=@login_ip,");
            sql.Append("add_time=@add_time,");
            sql.Append("status=@status,");
            sql.Append("last_time=@last_time,");
            sql.Append("last_ip=@last_ip,");
            sql.Append("login_count=@login_count,");
            sql.Append("salt=@salt,");
            sql.Append("is_email_validated=@is_email_validated,");
            sql.Append("is_mobile_validated=@is_mobile_validated,");
            sql.Append("money=@money,");
            sql.Append("frozen_money=@frozen_money,");
            sql.Append("money_status=@money_status,");
            sql.Append("rank_points=@rank_points,");
            sql.Append("points=@points,");
            sql.Append("rank_id=@rank_id,");
            sql.Append("sex=@sex,");
            sql.Append("brithday=@brithday,");
            sql.Append("qq=@qq,");
            sql.Append("pwd_question=@pwd_question,");
            sql.Append("pwd_answer=@pwd_answer,");
            sql.Append("introducer=@introducer");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            if (user != null)
            {
                param.AddDynamicParams(user);
            }

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("更新数据无效");
        }

        public void Delete(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ec_user ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
        }

        public User Get(int id)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user where 1 = 1 ");
            sql.Append("and id = @id ");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<User>(sql, param);
        }

        public IList<User> GetList(User.Query filter)
        {
            DynamicParameters param = new DynamicParameters();

            StringBuilder sql = new StringBuilder(@"select * from ec_user where 1 = 1 ");

            sql.AndEquals("mobile");
            sql.AndEquals("id");
            sql.AndDateBetween("add_time", "startdate", "enddate");
            sql.AndEquals("introducer");
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }

            //sql.AndIn("status","p_status");

            //sql.AndIn("status", filter.Status, ref param);






            return db.GetList<User>(sql, param);
        }

        public IList<User> GetList(User.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<User>(sql, param);
        }

        public Paged<User> GetPaged(PagedQuery<User.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<User>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }

        public User GetByUsername(string username)
        {
            return db.Get<User>("select * from ec_user where name = @name", new { name = username });
        }

        public User GetByMobile(string mobile)
        {
            return db.Get<User>("select * from ec_user where mobile = @mobile", new { mobile = mobile });
        }

        public int GetCount(Wuyiju.Model.User.Query query)
        {
            StringBuilder sql = new StringBuilder(@"select count(*) from ec_user where 1=1 ");

            sql.AndDateBetween("add_time", "startdate", "enddate");
            sql.AndEquals("introducer");
            DynamicParameters param = new DynamicParameters();


            if (query != null)
            {
                param.AddDynamicParams(query);
            }

            return db.ExecuteScalar<int>(sql.ToString(), param);
        }

        public IList<Wuyiju.View.LineChartJS> GetCount(Wuyiju.View.LineChartJS.Query query)
        {
            StringBuilder sql = new StringBuilder(@"select count(*) as count, FROM_UNIXTIME(add_time) as add_time from ec_user where 1=1 ");

            sql.AndDateBetween("add_time", "startdate", "enddate");

            sql.AppendFormat(" group by FROM_UNIXTIME(add_time,'%Y%m%d') ");

            DynamicParameters param = new DynamicParameters();


            if (query != null)
            {
                param.AddDynamicParams(query);
            }

            return db.GetList<Wuyiju.View.LineChartJS>(sql, param);
        }
    }
}
