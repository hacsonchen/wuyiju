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
	 	//ec_email
		public class EmailDAL: BaseDAL,IEmailDAL
	{
   		public EmailDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Email model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_email(");			
            sql.Append("email,code,add_time,user_id,is_used");
			sql.Append(") values (");
            sql.Append("@email,@code,@add_time,@user_id,@is_used");            
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
		public void Update(Wuyiju.Model.Email model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Email set ");
			                                                
            sql.Append(" email = @email , ");                                    
            sql.Append(" code = @code , ");                                    
            sql.Append(" add_time = @add_time , ");                                    
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" is_used = @is_used  ");            			
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
			sql.Append("delete from ec_email ");
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
		public Wuyiju.Model.Email Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, email, code, add_time, user_id, is_used  ");			
			sql.Append("  from ec_email ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.Email>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Email> GetList(Wuyiju.Model.Email.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_email where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Email>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Email> GetList(Wuyiju.Model.Email.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_email where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Email>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Email> GetPaged(PagedQuery<Wuyiju.Model.Email.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_email where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Email>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}