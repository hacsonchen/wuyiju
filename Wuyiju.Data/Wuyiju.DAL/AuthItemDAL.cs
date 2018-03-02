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
	 	//ec_auth_item
		public class AuthItemDAL: BaseDAL,IAuthItemDAL
	{
   		public AuthItemDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.AuthItem model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_auth_item(");			
            sql.Append("auth_code,auth_title,auth_day,auth_small_ico,auth_small_n_ico,auth_big_ico,auth_desc,auth_cash,auth_expir,auth_open,auth_show,muti_auth,update_time,auth_dir,listorder,config");
			sql.Append(") values (");
            sql.Append("@auth_code,@auth_title,@auth_day,@auth_small_ico,@auth_small_n_ico,@auth_big_ico,@auth_desc,@auth_cash,@auth_expir,@auth_open,@auth_show,@muti_auth,@update_time,@auth_dir,@listorder,@config");            
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
		public void Update(Wuyiju.Model.AuthItem model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update AuthItem set ");
			                        
            sql.Append(" auth_code = @auth_code , ");                                    
            sql.Append(" auth_title = @auth_title , ");                                    
            sql.Append(" auth_day = @auth_day , ");                                    
            sql.Append(" auth_small_ico = @auth_small_ico , ");                                    
            sql.Append(" auth_small_n_ico = @auth_small_n_ico , ");                                    
            sql.Append(" auth_big_ico = @auth_big_ico , ");                                    
            sql.Append(" auth_desc = @auth_desc , ");                                    
            sql.Append(" auth_cash = @auth_cash , ");                                    
            sql.Append(" auth_expir = @auth_expir , ");                                    
            sql.Append(" auth_open = @auth_open , ");                                    
            sql.Append(" auth_show = @auth_show , ");                                    
            sql.Append(" muti_auth = @muti_auth , ");                                    
            sql.Append(" update_time = @update_time , ");                                    
            sql.Append(" auth_dir = @auth_dir , ");                                    
            sql.Append(" listorder = @listorder , ");                                    
            sql.Append(" config = @config  ");            			
			sql.Append(" where auth_code=@auth_code  ");
			
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
		public void Delete(string auth_code)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("delete from ec_auth_item ");
			sql.Append(" where auth_code=@auth_code ");
			DynamicParameters param = new DynamicParameters();
            param.Add("auth_code", auth_code);

			var rows = db.Execute(sql, param);
            if (rows < 1)
                throw new ApplicationException("删除数据无效");
		}
		
		
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Wuyiju.Model.AuthItem Get(string auth_code)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select auth_code, auth_title, auth_day, auth_small_ico, auth_small_n_ico, auth_big_ico, auth_desc, auth_cash, auth_expir, auth_open, auth_show, muti_auth, update_time, auth_dir, listorder, config  ");			
			sql.Append("  from ec_auth_item ");
			sql.Append(" where auth_code=@auth_code ");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("auth_code", auth_code);
			
			return db.Get<Wuyiju.Model.AuthItem>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.AuthItem> GetList(Wuyiju.Model.AuthItem.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_auth_item where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.AuthItem>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.AuthItem> GetList(Wuyiju.Model.AuthItem.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_auth_item where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.AuthItem>(sql, param);
        }
        
        public Paged<Wuyiju.Model.AuthItem> GetPaged(PagedQuery<Wuyiju.Model.AuthItem.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_auth_item where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.AuthItem>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}