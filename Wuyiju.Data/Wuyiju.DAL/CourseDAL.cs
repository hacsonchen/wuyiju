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
	 	//ec_course
		public class CourseDAL: BaseDAL,ICourseDAL
	{
   		public CourseDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Course model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_course(");			
            sql.Append("c_name,t_name,t_content,c_time,add_time,status,jz_time,url,t_process,seo_title,seo_keys,seo_desc");
			sql.Append(") values (");
            sql.Append("@c_name,@t_name,@t_content,@c_time,@add_time,@status,@jz_time,@url,@t_process,@seo_title,@seo_keys,@seo_desc");            
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
		public void Update(Wuyiju.Model.Course model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Course set ");
			                                                
            sql.Append(" c_name = @c_name , ");                                    
            sql.Append(" t_name = @t_name , ");                                    
            sql.Append(" t_content = @t_content , ");                                    
            sql.Append(" c_time = @c_time , ");                                    
            sql.Append(" add_time = @add_time , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" jz_time = @jz_time , ");                                    
            sql.Append(" url = @url , ");                                    
            sql.Append(" t_process = @t_process , ");                                    
            sql.Append(" seo_title = @seo_title , ");                                    
            sql.Append(" seo_keys = @seo_keys , ");                                    
            sql.Append(" seo_desc = @seo_desc  ");            			
			sql.Append(" where cid=@cid ");
			
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
		public void Delete(int cid)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_course ");
			sql.Append(" where cid=@cid");
			DynamicParameters param = new DynamicParameters();
            param.Add("cid", cid);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.Course Get(int cid)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select cid, c_name, t_name, t_content, c_time, add_time, status, jz_time, url, t_process, seo_title, seo_keys, seo_desc  ");			
			sql.Append("  from ec_course ");
			sql.Append(" where cid=@cid");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("cid", cid);
			
			return db.Get<Wuyiju.Model.Course>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Course> GetList(Wuyiju.Model.Course.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_course where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Course>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Course> GetList(Wuyiju.Model.Course.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_course where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Course>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Course> GetPaged(PagedQuery<Wuyiju.Model.Course.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_course where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Course>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}