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
	 	//ec_product_img
		public class ProductImgDAL: BaseDAL,IProductImgDAL
	{
   		public ProductImgDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.ProductImg model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_product_img(");			
            sql.Append("product_id,title,thumb,picture");
			sql.Append(") values (");
            sql.Append("@product_id,@title,@thumb,@picture");            
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
		public void Update(Wuyiju.Model.ProductImg model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ProductImg set ");
			                                                
            sql.Append(" product_id = @product_id , ");                                    
            sql.Append(" title = @title , ");                                    
            sql.Append(" thumb = @thumb , ");                                    
            sql.Append(" picture = @picture  ");            			
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
			sql.Append("delete from ec_product_img ");
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
		public Wuyiju.Model.ProductImg Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, product_id, title, thumb, picture  ");			
			sql.Append("  from ec_product_img ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.ProductImg>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.ProductImg> GetList(Wuyiju.Model.ProductImg.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_product_img where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.ProductImg>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.ProductImg> GetList(Wuyiju.Model.ProductImg.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_product_img where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.ProductImg>(sql, param);
        }
        
        public Paged<Wuyiju.Model.ProductImg> GetPaged(PagedQuery<Wuyiju.Model.ProductImg.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_product_img where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.ProductImg>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}