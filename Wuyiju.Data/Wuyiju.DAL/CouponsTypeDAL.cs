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
	 	//ec_coupons_type
		public class CouponsTypeDAL: BaseDAL,ICouponsTypeDAL
	{
   		public CouponsTypeDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.CouponsType model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_coupons_type(");			
            sql.Append("type_name,type_money,send_type,min_amount,max_amount,send_start_date,send_end_date,use_start_date,use_end_date,min_product_amount,coupon_img,points_exchange");
			sql.Append(") values (");
            sql.Append("@type_name,@type_money,@send_type,@min_amount,@max_amount,@send_start_date,@send_end_date,@use_start_date,@use_end_date,@min_product_amount,@coupon_img,@points_exchange");            
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
		public void Update(Wuyiju.Model.CouponsType model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update CouponsType set ");
			                                                
            sql.Append(" type_name = @type_name , ");                                    
            sql.Append(" type_money = @type_money , ");                                    
            sql.Append(" send_type = @send_type , ");                                    
            sql.Append(" min_amount = @min_amount , ");                                    
            sql.Append(" max_amount = @max_amount , ");                                    
            sql.Append(" send_start_date = @send_start_date , ");                                    
            sql.Append(" send_end_date = @send_end_date , ");                                    
            sql.Append(" use_start_date = @use_start_date , ");                                    
            sql.Append(" use_end_date = @use_end_date , ");                                    
            sql.Append(" min_product_amount = @min_product_amount , ");                                    
            sql.Append(" coupon_img = @coupon_img , ");                                    
            sql.Append(" points_exchange = @points_exchange  ");            			
			sql.Append(" where type_id=@type_id ");
			
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
		public void Delete(int type_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_coupons_type ");
			sql.Append(" where type_id=@type_id");
			DynamicParameters param = new DynamicParameters();
            param.Add("type_id", type_id);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.CouponsType Get(int type_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select type_id, type_name, type_money, send_type, min_amount, max_amount, send_start_date, send_end_date, use_start_date, use_end_date, min_product_amount, coupon_img, points_exchange  ");			
			sql.Append("  from ec_coupons_type ");
			sql.Append(" where type_id=@type_id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("type_id", type_id);
			
			return db.Get<Wuyiju.Model.CouponsType>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.CouponsType> GetList(Wuyiju.Model.CouponsType.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_coupons_type where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.CouponsType>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.CouponsType> GetList(Wuyiju.Model.CouponsType.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_coupons_type where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.CouponsType>(sql, param);
        }
        
        public Paged<Wuyiju.Model.CouponsType> GetPaged(PagedQuery<Wuyiju.Model.CouponsType.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_coupons_type where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.CouponsType>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}