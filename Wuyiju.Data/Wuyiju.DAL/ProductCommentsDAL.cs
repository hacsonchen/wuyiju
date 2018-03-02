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
	 	//ec_product_comments
		public class ProductCommentsDAL: BaseDAL,IProductCommentsDAL
	{
   		public ProductCommentsDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.ProductComments model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_product_comments(");			
            sql.Append("product_id,user_id,user_name,content,useful,status,top,star01,star02,star03,reply,add_time");
			sql.Append(") values (");
            sql.Append("@product_id,@user_id,@user_name,@content,@useful,@status,@top,@star01,@star02,@star03,@reply,@add_time");            
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
		public void Update(Wuyiju.Model.ProductComments model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ProductComments set ");
			                                                
            sql.Append(" product_id = @product_id , ");                                    
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" user_name = @user_name , ");                                    
            sql.Append(" content = @content , ");                                    
            sql.Append(" useful = @useful , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" top = @top , ");                                    
            sql.Append(" star01 = @star01 , ");                                    
            sql.Append(" star02 = @star02 , ");                                    
            sql.Append(" star03 = @star03 , ");                                    
            sql.Append(" reply = @reply , ");                                    
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
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_product_comments ");
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
		public Wuyiju.Model.ProductComments Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, product_id, user_id, user_name, content, useful, status, top, star01, star02, star03, reply, add_time  ");			
			sql.Append("  from ec_product_comments ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.ProductComments>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.ProductComments> GetList(Wuyiju.Model.ProductComments.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_product_comments where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.ProductComments>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.ProductComments> GetList(Wuyiju.Model.ProductComments.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_product_comments where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.ProductComments>(sql, param);
        }
        
        public Paged<Wuyiju.Model.ProductComments> GetPaged(PagedQuery<Wuyiju.Model.ProductComments.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_product_comments where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.ProductComments>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}