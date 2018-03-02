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
	 	//ec_product_attr
		public class ProductAttrDAL: BaseDAL,IProductAttrDAL
	{
   		public ProductAttrDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.ProductAttr model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_product_attr(");			
            sql.Append("product_id,attr_pid,attr_id,attr_value,input");
			sql.Append(") values (");
            sql.Append("@product_id,@attr_pid,@attr_id,@attr_value,@input");            
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
		public void Update(Wuyiju.Model.ProductAttr model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ProductAttr set ");
			                                                
            sql.Append(" product_id = @product_id , ");                                    
            sql.Append(" attr_pid = @attr_pid , ");                                    
            sql.Append(" attr_id = @attr_id , ");                                    
            sql.Append(" attr_value = @attr_value , ");                                    
            sql.Append(" input = @input  ");            			
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
			sql.Append("delete from ec_product_attr ");
			sql.Append(" where id=@id");
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}

        /// <summary>
        /// 删除根据产品Id
        /// </summary>
        public void DeletebyP(int product_id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ec_product_attr ");
            sql.Append(" where product_id=@product_id");
            DynamicParameters param = new DynamicParameters();
            param.Add("product_id", product_id);

            var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Wuyiju.Model.ProductAttr Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, product_id, attr_pid, attr_id, attr_value, input  ");			
			sql.Append("  from ec_product_attr ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.ProductAttr>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.ProductAttr> GetList(Wuyiju.Model.ProductAttr.Query filter)
        {

            StringBuilder sql = new StringBuilder(@"select p.*,a.name as attr_name from ec_product_attr p left join ec_attribute a on a.id = p.attr_id  where 1 = 1 ");

            sql.AndEquals("a.type","Type");

            sql.AndEquals("a.recommend", "recommend");

            sql.AndEquals("p.product_id","product_id");

            sql.AndEquals("p.attr_id", "attr_id");

            sql.Append(" order by a.sort asc ");

            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.ProductAttr>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.ProductAttr> GetList(Wuyiju.Model.ProductAttr.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_product_attr where 1 = 1 ");

            sql.AndEquals("product_id");

            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.ProductAttr>(sql, param);
        }
        
        public Paged<Wuyiju.Model.ProductAttr> GetPaged(PagedQuery<Wuyiju.Model.ProductAttr.Query> query)
        {

            StringBuilder sql = new StringBuilder(@"select * from ec_product_attr where 1 = 1 ");

            sql.AndEquals("product_id");

            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.ProductAttr>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}