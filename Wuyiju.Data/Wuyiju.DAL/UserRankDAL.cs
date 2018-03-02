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
	 	//ec_user_rank
		public class UserRankDAL: BaseDAL,IUserRankDAL
	{
   		public UserRankDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.UserRank model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_user_rank(");			
            sql.Append("rank_name,min_points,max_points,discount,show_price,special_rank,extension_code");
			sql.Append(") values (");
            sql.Append("@rank_name,@min_points,@max_points,@discount,@show_price,@special_rank,@extension_code");            
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
		public void Update(Wuyiju.Model.UserRank model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ec_user_rank set ");
			                                                
            sql.Append(" rank_name = @rank_name , ");                                    
            sql.Append(" min_points = @min_points , ");                                    
            sql.Append(" max_points = @max_points , ");                                    
            sql.Append(" discount = @discount , ");                                    
            sql.Append(" show_price = @show_price , ");                                    
            sql.Append(" special_rank = @special_rank , ");                                    
            sql.Append(" extension_code = @extension_code  ");            			
			sql.Append(" where rank_id=@rank_id ");
			
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
		public void Delete(int rank_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_user_rank ");
			sql.Append(" where rank_id=@rank_id");
			DynamicParameters param = new DynamicParameters();
            param.Add("rank_id", rank_id);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.UserRank Get(int rank_id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select rank_id, rank_name, min_points, max_points, discount, show_price, special_rank, extension_code  ");			
			sql.Append("  from ec_user_rank ");
			sql.Append(" where rank_id=@rank_id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("rank_id", rank_id);
			
			return db.Get<Wuyiju.Model.UserRank>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.UserRank> GetList(Wuyiju.Model.UserRank.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_rank where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.UserRank>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.UserRank> GetList(Wuyiju.Model.UserRank.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_rank where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.UserRank>(sql, param);
        }
        
        public Paged<Wuyiju.Model.UserRank> GetPaged(PagedQuery<Wuyiju.Model.UserRank.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_rank where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.UserRank>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}