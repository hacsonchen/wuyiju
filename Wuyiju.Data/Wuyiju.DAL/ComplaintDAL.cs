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
	 	//ec_complaint
		public class ComplaintDAL: BaseDAL,IComplaintDAL
	{
   		public ComplaintDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Complaint model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_complaint(");			
            sql.Append("uid,tszname,tszmobile,tszqq,ywname,body,tspic1,add_time,resp_time,click,anonmity,savepath,resp");
			sql.Append(") values (");
            sql.Append("@uid,@tszname,@tszmobile,@tszqq,@ywname,@body,@tspic1,@add_time,@resp_time,@click,@anonmity,@savepath,@resp");            
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
		public void Update(Wuyiju.Model.Complaint model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Complaint set ");
			                                                
            sql.Append(" uid = @uid , ");                                    
            sql.Append(" tszname = @tszname , ");                                    
            sql.Append(" tszmobile = @tszmobile , ");                                    
            sql.Append(" tszqq = @tszqq , ");                                    
            sql.Append(" ywname = @ywname , ");                                    
            sql.Append(" body = @body , ");                                    
            sql.Append(" tspic1 = @tspic1 , ");                                    
            sql.Append(" add_time = @add_time , ");                                    
            sql.Append(" resp_time = @resp_time , ");                                    
            sql.Append(" click = @click , ");                                    
            sql.Append(" anonmity = @anonmity , ");                                    
            sql.Append(" savepath = @savepath , ");                                    
            sql.Append(" resp = @resp  ");            			
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
			sql.Append("delete from ec_complaint ");
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
		public Wuyiju.Model.Complaint Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, uid, tszname, tszmobile, tszqq, ywname, body, tspic1, add_time, resp_time, click, anonmity, savepath, resp  ");			
			sql.Append("  from ec_complaint ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.Complaint>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Complaint> GetList(Wuyiju.Model.Complaint.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_complaint where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Complaint>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Complaint> GetList(Wuyiju.Model.Complaint.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_complaint where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Complaint>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Complaint> GetPaged(PagedQuery<Wuyiju.Model.Complaint.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_complaint where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Complaint>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}