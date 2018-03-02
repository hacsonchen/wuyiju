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
	 	//ec_buy
		public class BuyDAL: BaseDAL,IBuyDAL
	{
   		public BuyDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Buy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_buy(");			
            sql.Append("title,sn,brief,cate_id,type,level,level_child,detail,start_price,end_price,validDay,stocks,status,v_status,p_status,remark,qq,user_name,mobile,good_rating,user_id,rating,add_time,created,credentials,click,role_id,admin_id");
			sql.Append(") values (");
            sql.Append("@title,@sn,@brief,@cate_id,@type,@level,@level_child,@detail,@start_price,@end_price,@validDay,@stocks,@status,@v_status,@p_status,@remark,@qq,@user_name,@mobile,@good_rating,@user_id,@rating,@add_time,@created,@credentials,@click,@role_id,@admin_id");            
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
		public void Update(Wuyiju.Model.Buy model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update Buy set ");
			                                                
            sql.Append(" title = @title , ");                                    
            sql.Append(" sn = @sn , ");                                    
            sql.Append(" brief = @brief , ");                                    
            sql.Append(" cate_id = @cate_id , ");                                    
            sql.Append(" type = @type , ");                                    
            sql.Append(" level = @level , ");                                    
            sql.Append(" level_child = @level_child , ");                                    
            sql.Append(" detail = @detail , ");                                    
            sql.Append(" start_price = @start_price , ");                                    
            sql.Append(" end_price = @end_price , ");                                    
            sql.Append(" validDay = @validDay , ");                                    
            sql.Append(" stocks = @stocks , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" v_status = @v_status , ");                                    
            sql.Append(" p_status = @p_status , ");                                    
            sql.Append(" remark = @remark , ");                                    
            sql.Append(" qq = @qq , ");                                    
            sql.Append(" user_name = @user_name , ");                                    
            sql.Append(" mobile = @mobile , ");                                    
            sql.Append(" good_rating = @good_rating , ");                                    
            sql.Append(" user_id = @user_id , ");                                    
            sql.Append(" rating = @rating , ");                                    
            sql.Append(" add_time = @add_time , ");                                    
            sql.Append(" created = @created , ");                                    
            sql.Append(" credentials = @credentials , ");                                    
            sql.Append(" click = @click , ");                                    
            sql.Append(" role_id = @role_id , ");                                    
            sql.Append(" admin_id = @admin_id  ");            			
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
			sql.Append("delete from ec_buy ");
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
		public Wuyiju.Model.Buy Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, title, sn, brief, cate_id, type, level, level_child, detail, start_price, end_price, validDay, stocks, status, v_status, p_status, remark, qq, user_name, mobile, good_rating, user_id, rating, add_time, created, credentials, click, role_id, admin_id  ");			
			sql.Append("  from ec_buy ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.Buy>(sql, param);
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>		
		public IList<Wuyiju.Model.Buy> GetList(Wuyiju.Model.Buy.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_buy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Buy>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Buy> GetList(Wuyiju.Model.Buy.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_buy where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Buy>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Buy> GetPaged(PagedQuery<Wuyiju.Model.Buy.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_buy where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Buy>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

        public int GetMaxId()
        {
            StringBuilder sql = new StringBuilder(@"select max(id) from ec_buy ");
            return db.ExecuteScalar<int>(sql.ToString());
        }


    }
}