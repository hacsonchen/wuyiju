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
	 	//ec_ad_position_copy
		public class AdPositionCopyDAL: BaseDAL,IAdPositionCopyDAL
	{
   		public AdPositionCopyDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.AdPositionCopy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_ad_position_copy(");			
            sql.Append("name,type,width,height,description,status");
			sql.Append(") values (");
            sql.Append("@name,@type,@width,@height,@description,@status");            
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
		public void Update(Wuyiju.Model.AdPositionCopy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update AdPositionCopy set ");
			                                                
            sql.Append(" name = @name , ");                                    
            sql.Append(" type = @type , ");                                    
            sql.Append(" width = @width , ");                                    
            sql.Append(" height = @height , ");                                    
            sql.Append(" description = @description , ");                                    
            sql.Append(" status = @status  ");            			
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
			sql.Append("delete from ec_ad_position_copy ");
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
		public Wuyiju.Model.AdPositionCopy Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, name, type, width, height, description, status  ");			
			sql.Append("  from ec_ad_position_copy ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.AdPositionCopy>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.AdPositionCopy> GetList(Wuyiju.Model.AdPositionCopy.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ad_position_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.AdPositionCopy>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.AdPositionCopy> GetList(Wuyiju.Model.AdPositionCopy.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ad_position_copy where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.AdPositionCopy>(sql, param);
        }
        
        public Paged<Wuyiju.Model.AdPositionCopy> GetPaged(PagedQuery<Wuyiju.Model.AdPositionCopy.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_ad_position_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.AdPositionCopy>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}