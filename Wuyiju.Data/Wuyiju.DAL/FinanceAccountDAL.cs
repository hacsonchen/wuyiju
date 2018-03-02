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
	 	//ec_finance_account
		public class FinanceAccountDAL: BaseDAL,IFinanceAccountDAL
	{
   		public FinanceAccountDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.FinanceAccount model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_finance_account(");			
            sql.Append("user_id,username,money,frozen_money,rank_points,points,add_time,descm,type");
			sql.Append(") values (");
            sql.Append("@user_id,@username,@money,@frozen_money,@rank_points,@points,@add_time,@descm,@type");            
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
		public void Update(Wuyiju.Model.FinanceAccount model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update FinanceAccount set ");
			                                                
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" username = @username , ");                                    
            sql.Append(" money = @money , ");                                    
            sql.Append(" frozen_money = @frozen_money , ");                                    
            sql.Append(" rank_points = @rank_points , ");                                    
            sql.Append(" points = @points , ");                                    
            sql.Append(" add_time = @add_time , ");                                    
            sql.Append(" descm = @descm , ");                                    
            sql.Append(" type = @type  ");            			
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
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_finance_account ");
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
		public Wuyiju.Model.FinanceAccount Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, user_id, username, money, frozen_money, rank_points, points, add_time, descm, type  ");			
			sql.Append("  from ec_finance_account ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.FinanceAccount>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.FinanceAccount> GetList(Wuyiju.Model.FinanceAccount.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_finance_account where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            sql.AndEquals("type");
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.FinanceAccount>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.FinanceAccount> GetList(Wuyiju.Model.FinanceAccount.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_finance_account where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.FinanceAccount>(sql, param);
        }
        
        public Paged<Wuyiju.Model.FinanceAccount> GetPaged(PagedQuery<Wuyiju.Model.FinanceAccount.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_finance_account where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.FinanceAccount>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}