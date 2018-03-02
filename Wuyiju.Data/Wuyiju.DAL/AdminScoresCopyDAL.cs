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
	 	//ec_admin_scores_copy
		public class AdminScoresCopyDAL: BaseDAL,IAdminScoresCopyDAL
	{
   		public AdminScoresCopyDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.AdminScoresCopy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_admin_scores_copy(");			
            sql.Append("username,guanname,sell_price,sell_phone,buy_phone");
			sql.Append(") values (");
            sql.Append("@username,guanname,@sell_price,@sell_phone,@buy_phone");            
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
		public void Update(Wuyiju.Model.AdminScoresCopy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update AdminScoresCopy set ");
			                                                
            sql.Append(" type = @type , ");                                    
            sql.Append(" score = @score , ");                                    
            sql.Append(" content = @content , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" admin_id = @admin_id , ");                                    
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" shop_id = @shop_id  ");            			
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
			sql.Append("delete from ec_admin_scores_copy ");
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
		public Wuyiju.Model.AdminScoresCopy Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, type, score, content, status, admin_id, user_id, shop_id  ");			
			sql.Append("  from ec_admin_scores_copy ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.AdminScoresCopy>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.AdminScoresCopy> GetList(Wuyiju.Model.AdminScoresCopy.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_admin_scores_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.AdminScoresCopy>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.AdminScoresCopy> GetList(Wuyiju.Model.AdminScoresCopy.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_admin_scores_copy where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.AdminScoresCopy>(sql, param);
        }
        
        public Paged<Wuyiju.Model.AdminScoresCopy> GetPaged(PagedQuery<Wuyiju.Model.AdminScoresCopy.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_admin_scores_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.AdminScoresCopy>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}