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
	 	//ec_article_comments
		public class ArticleCommentsDAL: BaseDAL,IArticleCommentsDAL
	{
   		public ArticleCommentsDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.ArticleComments model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_article_comments(");			
            sql.Append("article_id,user_id,user_name,image,content,useful,status,top,reply,reply_time,add_time");
			sql.Append(") values (");
            sql.Append("@article_id,@user_id,@user_name,@image,@content,@useful,@status,@top,@reply,@reply_time,@add_time");            
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
		public void Update(Wuyiju.Model.ArticleComments model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ArticleComments set ");
			                                                
            sql.Append(" article_id = @article_id , ");                                    
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" user_name = @user_name , ");                                    
            sql.Append(" image = @image , ");                                    
            sql.Append(" content = @content , ");                                    
            sql.Append(" useful = @useful , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" top = @top , ");                                    
            sql.Append(" reply = @reply , ");                                    
            sql.Append(" reply_time = @reply_time , ");                                    
            sql.Append(" add_time = @add_time  ");            			
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
			sql.Append("delete from ec_article_comments ");
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
		public Wuyiju.Model.ArticleComments Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, article_id, user_id, user_name, image, content, useful, status, top, reply, reply_time, add_time  ");			
			sql.Append("  from ec_article_comments ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.ArticleComments>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.ArticleComments> GetList(Wuyiju.Model.ArticleComments.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article_comments where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.ArticleComments>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.ArticleComments> GetList(Wuyiju.Model.ArticleComments.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article_comments where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.ArticleComments>(sql, param);
        }
        
        public Paged<Wuyiju.Model.ArticleComments> GetPaged(PagedQuery<Wuyiju.Model.ArticleComments.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article_comments where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.ArticleComments>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}