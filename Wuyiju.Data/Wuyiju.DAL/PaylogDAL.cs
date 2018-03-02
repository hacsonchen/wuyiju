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
	 	//ec_paylog
		public class PaylogDAL: BaseDAL,IPaylogDAL
	{
   		public PaylogDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Paylog model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_paylog(");			
            sql.Append("order_id,amount,order_type,is_paid");
			sql.Append(") values (");
            sql.Append("@order_id,@amount,@order_type,@is_paid");            
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
		public void Update(Wuyiju.Model.Paylog model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Paylog set ");
			                                                
            sql.Append(" order_id = @order_id , ");                                    
            sql.Append(" amount = @amount , ");                                    
            sql.Append(" order_type = @order_type , ");                                    
            sql.Append(" is_paid = @is_paid  ");            			
			sql.Append(" where log_id=@log_id ");
			
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
		public void Delete(int log_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_paylog ");
			sql.Append(" where log_id=@log_id");
			DynamicParameters param = new DynamicParameters();
            param.Add("log_id", log_id);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.Paylog Get(int log_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select log_id, order_id, amount, order_type, is_paid  ");			
			sql.Append("  from ec_paylog ");
			sql.Append(" where log_id=@log_id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("log_id", log_id);
			
			return db.Get<Wuyiju.Model.Paylog>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Paylog> GetList(Wuyiju.Model.Paylog.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_paylog where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Paylog>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Paylog> GetList(Wuyiju.Model.Paylog.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_paylog where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Paylog>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Paylog> GetPaged(PagedQuery<Wuyiju.Model.Paylog.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_paylog where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Paylog>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}