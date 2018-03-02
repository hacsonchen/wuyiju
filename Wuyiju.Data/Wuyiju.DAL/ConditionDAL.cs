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
	 	//ec_condition
		public class ConditionDAL: BaseDAL,IConditionDAL
	{
   		public ConditionDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Condition model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_condition(");			
            sql.Append("product_id,clicks,visitors,payed_num,buyer_num,kedan,change,total_amount,start_time,end_time");
			sql.Append(") values (");
            sql.Append("@product_id,@clicks,@visitors,@payed_num,@buyer_num,@kedan,@change,@total_amount,@start_time,@end_time");            
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
		public void Update(Wuyiju.Model.Condition model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Condition set ");
			                                                
            sql.Append(" product_id = @product_id , ");                                    
            sql.Append(" clicks = @clicks , ");                                    
            sql.Append(" visitors = @visitors , ");                                    
            sql.Append(" payed_num = @payed_num , ");                                    
            sql.Append(" buyer_num = @buyer_num , ");                                    
            sql.Append(" kedan = @kedan , ");                                    
            sql.Append(" change = @change , ");                                    
            sql.Append(" total_amount = @total_amount , ");                                    
            sql.Append(" start_time = @start_time , ");                                    
            sql.Append(" end_time = @end_time  ");            			
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
			sql.Append("delete from ec_condition ");
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
		public Wuyiju.Model.Condition Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, product_id, clicks, visitors, payed_num, buyer_num, kedan, change, total_amount, start_time, end_time  ");			
			sql.Append("  from ec_condition ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.Condition>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Condition> GetList(Wuyiju.Model.Condition.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_condition where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Condition>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Condition> GetList(Wuyiju.Model.Condition.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_condition where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Condition>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Condition> GetPaged(PagedQuery<Wuyiju.Model.Condition.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_condition where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Condition>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}