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
    //ec_deposit_bank_card
    public class DepositBankCardDAL : BaseDAL, IDepositBankCardDAL
    {
        public DepositBankCardDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.DepositBankCard model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_deposit_bank_card(");
            sql.Append("user_id,real_name,region_lv1,region_lv2,region_lv3,bank_name,bank_subname,card_number,add_time");
            sql.Append(") values (");
            sql.Append("@user_id,@real_name,@region_lv1,@region_lv2,@region_lv3,@bank_name,@bank_subname,@card_number,@add_time");
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
        public void Update(Wuyiju.Model.DepositBankCard model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update DepositBankCard set ");

            sql.Append(" user_id = @user_id , ");
            sql.Append(" real_name = @real_name , ");
            sql.Append(" region_lv1 = @region_lv1 , ");
            sql.Append(" region_lv2 = @region_lv2 , ");
            sql.Append(" region_lv3 = @region_lv3 , ");
            sql.Append(" bank_name = @bank_name , ");
            sql.Append(" bank_subname = @bank_subname , ");
            sql.Append(" card_number = @card_number , ");
            sql.Append(" add_time = @add_time  ");
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
            sql.Append("delete from ec_deposit_bank_card ");
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
        public Wuyiju.Model.DepositBankCard Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, user_id, real_name, region_lv1, region_lv2, region_lv3, bank_name, bank_subname, card_number, add_time  ");
            sql.Append("  from ec_deposit_bank_card ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.DepositBankCard>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.DepositBankCard> GetList(Wuyiju.Model.DepositBankCard.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_bank_card where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("user_id");

            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.DepositBankCard>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.DepositBankCard> GetList(Wuyiju.Model.DepositBankCard.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_bank_card where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.DepositBankCard>(sql, param);
        }

        public Paged<Wuyiju.Model.DepositBankCard> GetPaged(PagedQuery<Wuyiju.Model.DepositBankCard.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_deposit_bank_card where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.DepositBankCard>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}