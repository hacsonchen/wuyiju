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
	 	//ec_ask_reply
		public class AskReplyDAL: BaseDAL,IAskReplyDAL
	{
   		public AskReplyDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.AskReply model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_ask_reply(");			
            sql.Append("id,content,user_id,ask_id,reply_time,enable");
			sql.Append(") values (");
            sql.Append("@id,@content,@user_id,@ask_id,@reply_time,@enable");            
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
		public void Update(Wuyiju.Model.AskReply model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update AskReply set ");
			                        
            sql.Append(" id = @id , ");                                    
            sql.Append(" content = @content , ");                                    
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" ask_id = @ask_id , ");                                    
            sql.Append(" reply_time = @reply_time , ");                                    
            sql.Append(" enable = @enable  ");            			
			sql.Append(" where id=@id  ");
			
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
			sql.Append("delete from ec_ask_reply ");
			sql.Append(" where id=@id ");
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.AskReply Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, content, user_id, ask_id, reply_time, enable  ");			
			sql.Append("  from ec_ask_reply ");
			sql.Append(" where id=@id ");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.AskReply>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.AskReply> GetList(Wuyiju.Model.AskReply.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ask_reply where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.AskReply>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.AskReply> GetList(Wuyiju.Model.AskReply.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ask_reply where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.AskReply>(sql, param);
        }
        
        public Paged<Wuyiju.Model.AskReply> GetPaged(PagedQuery<Wuyiju.Model.AskReply.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ask_reply where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.AskReply>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}