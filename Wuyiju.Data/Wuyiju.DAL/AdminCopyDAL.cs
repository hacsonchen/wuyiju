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
	 	//ec_admin_copy
		public class AdminCopyDAL: BaseDAL,IAdminCopyDAL
	{
   		public AdminCopyDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.AdminCopy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_admin_copy(");			
            sql.Append("username,name,password,sex,status,email,valicode,pre_login_time,login_time,pre_login_ip,login_ip,login_nums,uid,position,parent_id,photo_img,job_number,qq,phone,mobile,score");
			sql.Append(") values (");
            sql.Append("@username,@name,@password,@sex,@status,@email,@valicode,@pre_login_time,@login_time,@pre_login_ip,@login_ip,@login_nums,@uid,@position,@parent_id,@photo_img,@job_number,@qq,@phone,@mobile,@score");            
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
		public void Update(Wuyiju.Model.AdminCopy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update AdminCopy set ");
			                                                
            sql.Append(" username = @username , ");                                    
            sql.Append(" name = @name , ");                                    
            sql.Append(" password = @password , ");                                    
            sql.Append(" sex = @sex , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" email = @email , ");                                    
            sql.Append(" valicode = @valicode , ");                                    
            sql.Append(" pre_login_time = @pre_login_time , ");                                    
            sql.Append(" login_time = @login_time , ");                                    
            sql.Append(" pre_login_ip = @pre_login_ip , ");                                    
            sql.Append(" login_ip = @login_ip , ");                                    
            sql.Append(" login_nums = @login_nums , ");                                    
            sql.Append(" uid = @uid , ");                                    
            sql.Append(" position = @position , ");                                    
            sql.Append(" parent_id = @parent_id , ");                                    
            sql.Append(" photo_img = @photo_img , ");                                    
            sql.Append(" job_number = @job_number , ");                                    
            sql.Append(" qq = @qq , ");                                    
            sql.Append(" phone = @phone , ");                                    
            sql.Append(" mobile = @mobile , ");                                    
            sql.Append(" score = @score  ");            			
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
			sql.Append("delete from ec_admin_copy ");
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
		public Wuyiju.Model.AdminCopy Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, username, name, password, sex, status, email, valicode, pre_login_time, login_time, pre_login_ip, login_ip, login_nums, uid, position, parent_id, photo_img, job_number, qq, phone, mobile, score  ");			
			sql.Append("  from ec_admin_copy ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.AdminCopy>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.AdminCopy> GetList(Wuyiju.Model.AdminCopy.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_admin_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.AdminCopy>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.AdminCopy> GetList(Wuyiju.Model.AdminCopy.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_admin_copy where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.AdminCopy>(sql, param);
        }
        
        public Paged<Wuyiju.Model.AdminCopy> GetPaged(PagedQuery<Wuyiju.Model.AdminCopy.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_admin_copy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.AdminCopy>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}