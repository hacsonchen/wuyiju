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
	 	//ec_visitor
		public class VisitorDAL: BaseDAL,IVisitorDAL
	{
   		public VisitorDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Visitor model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_visitor(");			
            sql.Append("in_time,ip,country,province,city,isp,platform,browser,version,entrance,http_referer");
			sql.Append(") values (");
            sql.Append("@in_time,@ip,@country,@province,@city,@isp,@platform,@browser,@version,@entrance,@http_referer");            
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
		public void Update(Wuyiju.Model.Visitor model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Visitor set ");
			                                                
            sql.Append(" in_time = @in_time , ");                                    
            sql.Append(" ip = @ip , ");                                    
            sql.Append(" country = @country , ");                                    
            sql.Append(" province = @province , ");                                    
            sql.Append(" city = @city , ");                                    
            sql.Append(" isp = @isp , ");                                    
            sql.Append(" platform = @platform , ");                                    
            sql.Append(" browser = @browser , ");                                    
            sql.Append(" version = @version , ");                                    
            sql.Append(" entrance = @entrance , ");                                    
            sql.Append(" http_referer = @http_referer  ");            			
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
			sql.Append("delete from ec_visitor ");
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
		public Wuyiju.Model.Visitor Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, in_time, ip, country, province, city, isp, platform, browser, version, entrance, http_referer  ");			
			sql.Append("  from ec_visitor ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.Visitor>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Visitor> GetList(Wuyiju.Model.Visitor.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_visitor where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Visitor>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Visitor> GetList(Wuyiju.Model.Visitor.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_visitor where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Visitor>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Visitor> GetPaged(PagedQuery<Wuyiju.Model.Visitor.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_visitor where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Visitor>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}