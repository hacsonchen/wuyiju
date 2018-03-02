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
	 	//ec_finance_cash
		public class FinanceCashDAL: BaseDAL,IFinanceCashDAL
	{
   		public FinanceCashDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.FinanceCash model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_finance_cash(");			
            sql.Append("user_id,uname,money,points,remark,add_time,ip,reply,status,realname,alipay,is_money");
			sql.Append(") values (");
            sql.Append("@user_id,@uname,@money,@points,@remark,@add_time,@ip,@reply,@status,@realname,@alipay,@is_money");            
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
		public void Update(Wuyiju.Model.FinanceCash model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update FinanceCash set ");
			                                                
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" uname = @uname , ");                                    
            sql.Append(" money = @money , ");                                    
            sql.Append(" points = @points , ");                                    
            sql.Append(" remark = @remark , ");                                    
            sql.Append(" add_time = @add_time , ");                                    
            sql.Append(" ip = @ip , ");                                    
            sql.Append(" reply = @reply , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" realname = @realname , ");                                    
            sql.Append(" alipay = @alipay , ");                                    
            sql.Append(" is_money = @is_money  ");            			
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
			sql.Append("delete from ec_finance_cash ");
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
		public Wuyiju.Model.FinanceCash Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, user_id, uname, money, points, remark, add_time, ip, reply, status, realname, alipay, is_money  ");			
			sql.Append("  from ec_finance_cash ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.FinanceCash>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.FinanceCash> GetList(Wuyiju.Model.FinanceCash.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_finance_cash where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.FinanceCash>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.FinanceCash> GetList(Wuyiju.Model.FinanceCash.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_finance_cash where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.FinanceCash>(sql, param);
        }
        
        public Paged<Wuyiju.Model.FinanceCash> GetPaged(PagedQuery<Wuyiju.Model.FinanceCash.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_finance_cash where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.FinanceCash>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}