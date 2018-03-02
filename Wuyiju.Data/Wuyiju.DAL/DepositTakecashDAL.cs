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
    //ec_deposit_takecash
    public class DepositTakecashDAL : BaseDAL, IDepositTakecashDAL
    {
        public DepositTakecashDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.DepositTakecash model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_deposit_takecash(");
            sql.Append("user_id,user_name,bank_card_id,money,add_time,status,sn,pay_money,remark,pay_time");
            sql.Append(") values (");
            sql.Append("@user_id,@user_name,@bank_card_id,@money,@add_time,@status,@sn,@pay_money,@remark,@pay_time");
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
        public void Update(Wuyiju.Model.DepositTakecash model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_deposit_takecash set ");

            sql.Append(" user_id = @user_id , ");
            sql.Append(" user_name = @user_name , ");
            sql.Append(" bank_card_id = @bank_card_id , ");
            sql.Append(" money = @money , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" status = @status , ");
            sql.Append(" sn = @sn , ");
            sql.Append(" pay_money = @pay_money , ");
            sql.Append(" remark = @remark , ");
            sql.Append(" pay_time = @pay_time  ");
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
            sql.Append("delete from ec_deposit_takecash ");
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
        public Wuyiju.Model.DepositTakecash Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, user_id, user_name, bank_card_id, money, add_time, status, sn, pay_money, remark, pay_time  ");
            sql.Append("  from ec_deposit_takecash ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.DepositTakecash>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.DepositTakecash> GetList(Wuyiju.Model.DepositTakecash.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_takecash where 1 = 1 ");
            sql.AndEquals("Status");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.DepositTakecash>(sql, param);
        }

        /// <summary>
        /// 获得提现列表
        /// </summary>		
        public IList<Wuyiju.Model.DepositTakecash> GetXList()
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_takecash where status != 1 ");
            DynamicParameters param = new DynamicParameters();
            return db.GetList<Wuyiju.Model.DepositTakecash>(sql, param);
        }



        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.DepositTakecash> GetList(Wuyiju.Model.DepositTakecash.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_takecash where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.DepositTakecash>(sql, param);
        }

        public Paged<Wuyiju.Model.DepositTakecashWithBank> GetPaged(PagedQuery<Wuyiju.Model.DepositTakecash.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select t.*,b.bank_name,b.card_number from ec_deposit_takecash t inner join ec_deposit_bank_card b on t.bank_card_id = b.id  where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("t.User_Id", "user_id")
                .AndEquals("t.Status","Status");
       

            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.DepositTakecashWithBank>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


        public int GetMaxId()
        {
            StringBuilder sql = new StringBuilder(@"select max(id) from ec_deposit_takecash ");
            return db.ExecuteScalar<int>(sql.ToString());
        }

    }
}