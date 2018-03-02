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
	 	//ec_buy_action
		public class BuyActionDAL: BaseDAL,IBuyActionDAL
	{
   		public BuyActionDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.BuyAction model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_buy_action(");			
            sql.Append("type,buy_id,admin_id,admin_name,status,v_status,add_time,content");
			sql.Append(") values (");
            sql.Append("@type,@buy_id,@admin_id,@admin_name,@status,@v_status,@add_time,@content");            
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
		public void Update(Wuyiju.Model.BuyAction model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update BuyAction set ");
			                                                
            sql.Append(" type = @type , ");                                    
            sql.Append(" buy_id = @buy_id , ");                                    
            sql.Append(" admin_id = @admin_id , ");                                    
            sql.Append(" admin_name = @admin_name , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" v_status = @v_status , ");                                    
            sql.Append(" add_time = @add_time , ");                                    
            sql.Append(" content = @content  ");            			
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
			sql.Append("delete from ec_buy_action ");
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
		public Wuyiju.Model.BuyAction Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, type, buy_id, admin_id, admin_name, status, v_status, add_time, content  ");			
			sql.Append("  from ec_buy_action ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.BuyAction>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.BuyAction> GetList(Wuyiju.Model.BuyAction.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_buy_action where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.BuyAction>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.BuyAction> GetList(Wuyiju.Model.BuyAction.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_buy_action where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.BuyAction>(sql, param);
        }
        
        public Paged<Wuyiju.Model.BuyAction> GetPaged(PagedQuery<Wuyiju.Model.BuyAction.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_buy_action where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.BuyAction>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}