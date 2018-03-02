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
    //ec_deposit_recharge
    public class DepositRechargeDAL : BaseDAL, IDepositRechargeDAL
    {
        public DepositRechargeDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.DepositRecharge model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_deposit_recharge(");
            sql.Append("sn,pay_type,status,user_id,add_time,pay_time,total_fee,pay_fee,trade_no,txt,shoukCard,huiBank,huiMoney,huiTime,huiUser,huiFile,huiRemark,user_name");
            sql.Append(") values (");
            sql.Append("@sn,@pay_type,@status,@user_id,@add_time,@pay_time,@total_fee,@pay_fee,@trade_no,@txt,@shoukCard,@huiBank,@huiMoney,@huiTime,@huiUser,@huiFile,@huiRemark,@user_name");
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
        public void Update(Wuyiju.Model.DepositRecharge model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_deposit_recharge set ");

            sql.Append(" sn = @sn , ");
            sql.Append(" pay_type = @pay_type , ");
            sql.Append(" status = @status , ");
            sql.Append(" user_id = @user_id , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" pay_time = @pay_time , ");
            sql.Append(" total_fee = @total_fee , ");
            sql.Append(" pay_fee = @pay_fee , ");
            sql.Append(" trade_no = @trade_no , ");
            sql.Append(" txt = @txt , ");
            sql.Append(" shoukCard = @shoukCard , ");
            sql.Append(" huiBank = @huiBank , ");
            sql.Append(" huiMoney = @huiMoney , ");
            sql.Append(" huiTime = @huiTime , ");
            sql.Append(" huiUser = @huiUser , ");
            sql.Append(" huiFile = @huiFile , ");
            sql.Append(" huiRemark = @huiRemark , ");
            sql.Append(" user_name = @user_name  ");
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
            sql.Append("delete from ec_deposit_recharge ");
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
        public Wuyiju.Model.DepositRecharge Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, sn, pay_type, status, user_id, add_time, pay_time, total_fee, pay_fee, trade_no, txt, shoukCard, huiBank, huiMoney, huiTime, huiUser, huiFile, huiRemark ,user_name ");
            sql.Append("  from ec_deposit_recharge ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.DepositRecharge>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.DepositRecharge> GetList(Wuyiju.Model.DepositRecharge.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_recharge where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            sql.AndEquals("status");

            sql.Append(" order by add_time desc ");
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.DepositRecharge>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.DepositRecharge> GetList(Wuyiju.Model.DepositRecharge.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_recharge where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.DepositRecharge>(sql, param);
        }

        public Paged<Wuyiju.Model.DepositRecharge> GetPaged(PagedQuery<Wuyiju.Model.DepositRecharge.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_recharge where 1 = 1 ");

            sql.AndEquals("User_Id").AndEquals("status");



            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }

            IList<OrderRule> order = new List<OrderRule>();

            order.Add(new OrderRule { Column = "add_time", dir = "desc" });

            return db.GetPaged<Wuyiju.Model.DepositRecharge>(sql, param, query.PageStart, query.PageSize, query.Draw, order);
        }

        public int GetMaxId()
        {
            StringBuilder sql = new StringBuilder(@"select max(id) from ec_deposit_recharge ");
            return db.ExecuteScalar<int>(sql.ToString());
        }


    }
}