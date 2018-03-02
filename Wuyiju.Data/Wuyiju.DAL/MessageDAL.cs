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
	 	//ec_message
		public class MessageDAL: BaseDAL,IMessageDAL
	{
   		public MessageDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Message model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_message(");			
            sql.Append("userid,type,name,mail,message,ip,time,status,admin,mobile,qq,msgtitle");
			sql.Append(") values (");
            sql.Append("@userid,@type,@name,@mail,@message,@ip,@time,@status,@admin,@mobile,@qq,@msgtitle");            
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
		public void Update(Wuyiju.Model.Message model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ec_message set ");
			                                                
            sql.Append(" userid = @userid , ");                                    
            sql.Append(" type = @type , ");                                    
            sql.Append(" name = @name , ");                                    
            sql.Append(" mail = @mail , ");                                    
            sql.Append(" message = @message , ");                                    
            sql.Append(" ip = @ip , ");                                    
            sql.Append(" time = @time , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" admin = @admin , ");                                    
            sql.Append(" mobile = @mobile , ");                                    
            sql.Append(" qq = @qq , ");                                    
            sql.Append(" msgtitle = @msgtitle  ");            			
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
			sql.Append("delete from ec_message ");
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
		public Wuyiju.Model.Message Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, userid, type, name, mail, message, ip, time, status, admin, mobile, qq, msgtitle  ");			
			sql.Append("  from ec_message ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.Message>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Message> GetList(Wuyiju.Model.Message.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_message where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Message>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Message> GetList(Wuyiju.Model.Message.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_message where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Message>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Message> GetPaged(PagedQuery<Wuyiju.Model.Message.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_message where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Message>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}