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
	 	//ec_ask
		public class AskDAL: BaseDAL,IAskDAL
	{
   		public AskDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Ask model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_ask(");			
            sql.Append("product_id,user_id,username,ip,time,update_time,content,status,replay,pid,is_user");
			sql.Append(") values (");
            sql.Append("@product_id,@user_id,@username,@ip,@time,@update_time,@content,@status,@replay,@pid,@is_user");            
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
		public void Update(Wuyiju.Model.Ask model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Ask set ");
			                                                
            sql.Append(" product_id = @product_id , ");                                    
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" username = @username , ");                                    
            sql.Append(" ip = @ip , ");                                    
            sql.Append(" time = @time , ");                                    
            sql.Append(" update_time = @update_time , ");                                    
            sql.Append(" content = @content , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" replay = @replay , ");                                    
            sql.Append(" pid = @pid , ");                                    
            sql.Append(" is_user = @is_user  ");            			
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
			sql.Append("delete from ec_ask ");
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
		public Wuyiju.Model.Ask Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, product_id, user_id, username, ip, time, update_time, content, status, replay, pid, is_user  ");			
			sql.Append("  from ec_ask ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.Ask>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Ask> GetList(Wuyiju.Model.Ask.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ask where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Ask>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Ask> GetList(Wuyiju.Model.Ask.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ask where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Ask>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Ask> GetPaged(PagedQuery<Wuyiju.Model.Ask.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ask where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Ask>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}