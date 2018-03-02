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
	 	//ec_payment
		public class PaymentDAL: BaseDAL,IPaymentDAL
	{
   		public PaymentDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Payment model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_payment(");			
            sql.Append("pay_name,pay_code,pay_desc,pay_logo,enabled,pay_order,pay_content,pay_fee,partner_id,partner_key,is_online");
			sql.Append(") values (");
            sql.Append("@pay_name,@pay_code,@pay_desc,@pay_logo,@enabled,@pay_order,@pay_content,@pay_fee,@partner_id,@partner_key,@is_online");            
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
		public void Update(Wuyiju.Model.Payment model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Payment set ");
			                                                
            sql.Append(" pay_name = @pay_name , ");                                    
            sql.Append(" pay_code = @pay_code , ");                                    
            sql.Append(" pay_desc = @pay_desc , ");                                    
            sql.Append(" pay_logo = @pay_logo , ");                                    
            sql.Append(" enabled = @enabled , ");                                    
            sql.Append(" pay_order = @pay_order , ");                                    
            sql.Append(" pay_content = @pay_content , ");                                    
            sql.Append(" pay_fee = @pay_fee , ");                                    
            sql.Append(" partner_id = @partner_id , ");                                    
            sql.Append(" partner_key = @partner_key , ");                                    
            sql.Append(" is_online = @is_online  ");            			
			sql.Append(" where pay_id=@pay_id ");
			
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
		public void Delete(int pay_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_payment ");
			sql.Append(" where pay_id=@pay_id");
			DynamicParameters param = new DynamicParameters();
            param.Add("pay_id", pay_id);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.Payment Get(int pay_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select pay_id, pay_name, pay_code, pay_desc, pay_logo, enabled, pay_order, pay_content, pay_fee, partner_id, partner_key, is_online  ");			
			sql.Append("  from ec_payment ");
			sql.Append(" where pay_id=@pay_id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("pay_id", pay_id);
			
			return db.Get<Wuyiju.Model.Payment>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Payment> GetList(Wuyiju.Model.Payment.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_payment where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Payment>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Payment> GetList(Wuyiju.Model.Payment.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_payment where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Payment>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Payment> GetPaged(PagedQuery<Wuyiju.Model.Payment.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_payment where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Payment>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}