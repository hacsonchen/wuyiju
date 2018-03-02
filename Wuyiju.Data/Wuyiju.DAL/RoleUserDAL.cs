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
	 	//ec_role_user
		public class RoleUserDAL: BaseDAL,IRoleUserDAL
	{
   		public RoleUserDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.RoleUser model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_role_user(");			
            sql.Append("role_id,user_id");
			sql.Append(") values (");
            sql.Append("@role_id,@user_id");            
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
		public void Update(Wuyiju.Model.RoleUser model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update RoleUser set ");
			                        
            sql.Append(" role_id = @role_id , ");                                    
            sql.Append(" user_id = @user_id  ");            			
			sql.Append(" where  ");
			
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
		public void Delete()
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_role_user ");
			sql.Append(" where ");
			DynamicParameters param = new DynamicParameters();
            //param.Add("id", id);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.RoleUser Get()
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select role_id, user_id  ");			
			sql.Append("  from ec_role_user ");
			sql.Append(" where ");
			
			DynamicParameters param = new DynamicParameters();
            //param.Add("id", id);
			
			return db.Get<Wuyiju.Model.RoleUser>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.RoleUser> GetList(Wuyiju.Model.RoleUser.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_role_user where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.RoleUser>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.RoleUser> GetList(Wuyiju.Model.RoleUser.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_role_user where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.RoleUser>(sql, param);
        }
        
        public Paged<Wuyiju.Model.RoleUser> GetPaged(PagedQuery<Wuyiju.Model.RoleUser.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_role_user where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.RoleUser>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}