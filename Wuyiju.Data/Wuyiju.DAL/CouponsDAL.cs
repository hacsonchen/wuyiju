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
	 	//ec_coupons
		public class CouponsDAL: BaseDAL,ICouponsDAL
	{
   		public CouponsDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Coupons model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_coupons(");			
            sql.Append("coupon_type_id,coupon_sn,user_id,used_time,order_id,emailed");
			sql.Append(") values (");
            sql.Append("@coupon_type_id,@coupon_sn,@user_id,@used_time,@order_id,@emailed");            
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
		public void Update(Wuyiju.Model.Coupons model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Coupons set ");
			                                                
            sql.Append(" coupon_type_id = @coupon_type_id , ");                                    
            sql.Append(" coupon_sn = @coupon_sn , ");                                    
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" used_time = @used_time , ");                                    
            sql.Append(" order_id = @order_id , ");                                    
            sql.Append(" emailed = @emailed  ");            			
			sql.Append(" where coupon_id=@coupon_id ");
			
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
		public void Delete(int coupon_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_coupons ");
			sql.Append(" where coupon_id=@coupon_id");
			DynamicParameters param = new DynamicParameters();
            param.Add("coupon_id", coupon_id);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.Coupons Get(int coupon_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select coupon_id, coupon_type_id, coupon_sn, user_id, used_time, order_id, emailed  ");			
			sql.Append("  from ec_coupons ");
			sql.Append(" where coupon_id=@coupon_id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("coupon_id", coupon_id);
			
			return db.Get<Wuyiju.Model.Coupons>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Coupons> GetList(Wuyiju.Model.Coupons.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_coupons where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Coupons>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Coupons> GetList(Wuyiju.Model.Coupons.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_coupons where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Coupons>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Coupons> GetPaged(PagedQuery<Wuyiju.Model.Coupons.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_coupons where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Coupons>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}