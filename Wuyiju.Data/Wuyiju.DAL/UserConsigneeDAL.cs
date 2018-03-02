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
	 	//ec_user_consignee
		public class UserConsigneeDAL: BaseDAL,IUserConsigneeDAL
	{
   		public UserConsigneeDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.UserConsignee model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_user_consignee(");			
            sql.Append("user_id,region_lv1,region_lv2,region_lv3,region_lv4,address,mobile,phone,consignee,zip,qq,email,create_time,fax,is_def,region_values");
			sql.Append(") values (");
            sql.Append("@user_id,@region_lv1,@region_lv2,@region_lv3,@region_lv4,@address,@mobile,@phone,@consignee,@zip,@qq,@email,@create_time,@fax,@is_def,@region_values");            
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
		public void Update(Wuyiju.Model.UserConsignee model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update UserConsignee set ");
			                                                
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" region_lv1 = @region_lv1 , ");                                    
            sql.Append(" region_lv2 = @region_lv2 , ");                                    
            sql.Append(" region_lv3 = @region_lv3 , ");                                    
            sql.Append(" region_lv4 = @region_lv4 , ");                                    
            sql.Append(" address = @address , ");                                    
            sql.Append(" mobile = @mobile , ");                                    
            sql.Append(" phone = @phone , ");                                    
            sql.Append(" consignee = @consignee , ");                                    
            sql.Append(" zip = @zip , ");                                    
            sql.Append(" qq = @qq , ");                                    
            sql.Append(" email = @email , ");                                    
            sql.Append(" create_time = @create_time , ");                                    
            sql.Append(" fax = @fax , ");                                    
            sql.Append(" is_def = @is_def , ");                                    
            sql.Append(" region_values = @region_values  ");            			
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
			sql.Append("delete from ec_user_consignee ");
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
		public Wuyiju.Model.UserConsignee Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, user_id, region_lv1, region_lv2, region_lv3, region_lv4, address, mobile, phone, consignee, zip, qq, email, create_time, fax, is_def, region_values  ");			
			sql.Append("  from ec_user_consignee ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.UserConsignee>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.UserConsignee> GetList(Wuyiju.Model.UserConsignee.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_consignee where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.UserConsignee>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.UserConsignee> GetList(Wuyiju.Model.UserConsignee.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_consignee where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.UserConsignee>(sql, param);
        }
        
        public Paged<Wuyiju.Model.UserConsignee> GetPaged(PagedQuery<Wuyiju.Model.UserConsignee.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_consignee where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.UserConsignee>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}