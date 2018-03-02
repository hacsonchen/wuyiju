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
	 	//ec_user_info
		public class UserInfoDAL: BaseDAL,IUserInfoDAL
	{
   		public UserInfoDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.UserInfo model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_user_info(");			
            sql.Append("user_id,region_lv1,region_lv2,region_lv3,region_lv4,region_values,sex,brithday,blog,info,share_num,like_num,follow_num,fans_num,constellation,job,qq,realname,alipay,rank,money,frozen_money,points,rank_points,forum,salt,is_validated");
			sql.Append(") values (");
            sql.Append("@user_id,@region_lv1,@region_lv2,@region_lv3,@region_lv4,@region_values,@sex,@brithday,@blog,@info,@share_num,@like_num,@follow_num,@fans_num,@constellation,@job,@qq,@realname,@alipay,@rank,@money,@frozen_money,@points,@rank_points,@forum,@salt,@is_validated");            
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
		public void Update(Wuyiju.Model.UserInfo model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update UserInfo set ");
			                                                
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" region_lv1 = @region_lv1 , ");                                    
            sql.Append(" region_lv2 = @region_lv2 , ");                                    
            sql.Append(" region_lv3 = @region_lv3 , ");                                    
            sql.Append(" region_lv4 = @region_lv4 , ");                                    
            sql.Append(" region_values = @region_values , ");                                    
            sql.Append(" sex = @sex , ");                                    
            sql.Append(" brithday = @brithday , ");                                    
            sql.Append(" blog = @blog , ");                                    
            sql.Append(" info = @info , ");                                    
            sql.Append(" share_num = @share_num , ");                                    
            sql.Append(" like_num = @like_num , ");                                    
            sql.Append(" follow_num = @follow_num , ");                                    
            sql.Append(" fans_num = @fans_num , ");                                    
            sql.Append(" constellation = @constellation , ");                                    
            sql.Append(" job = @job , ");                                    
            sql.Append(" qq = @qq , ");                                    
            sql.Append(" realname = @realname , ");                                    
            sql.Append(" alipay = @alipay , ");                                    
            sql.Append(" rank = @rank , ");                                    
            sql.Append(" money = @money , ");                                    
            sql.Append(" frozen_money = @frozen_money , ");                                    
            sql.Append(" points = @points , ");                                    
            sql.Append(" rank_points = @rank_points , ");                                    
            sql.Append(" forum = @forum , ");                                    
            sql.Append(" salt = @salt , ");                                    
            sql.Append(" is_validated = @is_validated  ");            			
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
			sql.Append("delete from ec_user_info ");
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
		public Wuyiju.Model.UserInfo Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, user_id, region_lv1, region_lv2, region_lv3, region_lv4, region_values, sex, brithday, blog, info, share_num, like_num, follow_num, fans_num, constellation, job, qq, realname, alipay, rank, money, frozen_money, points, rank_points, forum, salt, is_validated  ");			
			sql.Append("  from ec_user_info ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.UserInfo>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.UserInfo> GetList(Wuyiju.Model.UserInfo.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_info where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.UserInfo>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.UserInfo> GetList(Wuyiju.Model.UserInfo.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_info where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.UserInfo>(sql, param);
        }
        
        public Paged<Wuyiju.Model.UserInfo> GetPaged(PagedQuery<Wuyiju.Model.UserInfo.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_user_info where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.UserInfo>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}