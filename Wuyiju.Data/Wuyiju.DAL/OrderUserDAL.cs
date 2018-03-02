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
	 	//ec_order_user
		public class OrderUserDAL: BaseDAL,IOrderUserDAL
	{
   		public OrderUserDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.OrderUser model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_order_user(");			
            sql.Append("order_id,name,phone,email");
			sql.Append(") values (");
            sql.Append("@order_id,@name,@phone,@email");            
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
		public void Update(Wuyiju.Model.OrderUser model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update OrderUser set ");
			                                                
            sql.Append(" order_id = @order_id , ");                                    
            sql.Append(" name = @name , ");                                    
            sql.Append(" phone = @phone , ");                                    
            sql.Append(" email = @email  ");            			
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
			sql.Append("delete from ec_order_user ");
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
		public Wuyiju.Model.OrderUser Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, order_id, name, phone, email  ");			
			sql.Append("  from ec_order_user ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.OrderUser>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.OrderUser> GetList(Wuyiju.Model.OrderUser.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_order_user where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.OrderUser>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.OrderUser> GetList(Wuyiju.Model.OrderUser.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_order_user where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.OrderUser>(sql, param);
        }
        
        public Paged<Wuyiju.Model.OrderUser> GetPaged(PagedQuery<Wuyiju.Model.OrderUser.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_order_user where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.OrderUser>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}