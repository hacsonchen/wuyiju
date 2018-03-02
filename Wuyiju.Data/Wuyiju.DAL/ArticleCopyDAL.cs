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
	 	//ec_article_copy
		public class ArticleCopyDAL: BaseDAL,IArticleCopyDAL
	{
   		public ArticleCopyDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.ArticleCopy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_article_copy(");			
            sql.Append("cate_id,title,from,img,url,brief,info,add_time,sort_order,is_hot,is_best,status,seo_title,seo_keys,seo_desc,filename,click");
			sql.Append(") values (");
            sql.Append("@cate_id,@title,@from,@img,@url,@brief,@info,@add_time,@sort_order,@is_hot,@is_best,@status,@seo_title,@seo_keys,@seo_desc,@filename,@click");            
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
		public void Update(Wuyiju.Model.ArticleCopy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ArticleCopy set ");
			                                                
            sql.Append(" cate_id = @cate_id , ");                                    
            sql.Append(" title = @title , ");                                    
            sql.Append(" from = @from , ");                                    
            sql.Append(" img = @img , ");                                    
            sql.Append(" url = @url , ");                                    
            sql.Append(" brief = @brief , ");                                    
            sql.Append(" info = @info , ");                                    
            sql.Append(" add_time = @add_time , ");                                    
            sql.Append(" sort_order = @sort_order , ");                                    
            sql.Append(" is_hot = @is_hot , ");                                    
            sql.Append(" is_best = @is_best , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" seo_title = @seo_title , ");                                    
            sql.Append(" seo_keys = @seo_keys , ");                                    
            sql.Append(" seo_desc = @seo_desc , ");                                    
            sql.Append(" filename = @filename , ");                                    
            sql.Append(" click = @click  ");            			
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
			sql.Append("delete from ec_article_copy ");
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
		public Wuyiju.Model.ArticleCopy Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, cate_id, title, from, img, url, brief, info, add_time, sort_order, is_hot, is_best, status, seo_title, seo_keys, seo_desc, filename, click  ");			
			sql.Append("  from ec_article_copy ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.ArticleCopy>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.ArticleCopy> GetList(Wuyiju.Model.ArticleCopy.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.ArticleCopy>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.ArticleCopy> GetList(Wuyiju.Model.ArticleCopy.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article_copy where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.ArticleCopy>(sql, param);
        }
        
        public Paged<Wuyiju.Model.ArticleCopy> GetPaged(PagedQuery<Wuyiju.Model.ArticleCopy.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_article_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.ArticleCopy>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}