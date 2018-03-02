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
	 	//ec_sms
		public class SmsDAL: BaseDAL,ISmsDAL
	{
   		public SmsDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Sms model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_sms(");			
            sql.Append("mobile,validateCode,add_time");
			sql.Append(") values (");
            sql.Append("@mobile,@validateCode,@add_time");            
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
		public void Update(Wuyiju.Model.Sms model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ec_sms set ");
			                                                
            sql.Append(" mobile = @mobile , ");                                    
            sql.Append(" validateCode = @validateCode , ");                                    
            sql.Append(" add_time = @add_time  ");            			
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
			sql.Append("delete from ec_sms ");
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
		public Wuyiju.Model.Sms Get(int id)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, mobile, validateCode, add_time  ");			
			sql.Append("  from ec_sms ");
			sql.Append(" where id=@id");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
			
			return db.Get<Wuyiju.Model.Sms>(sql, param);
		}

        public Wuyiju.Model.Sms Get(string mobile)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, mobile, validateCode, add_time  ");
            sql.Append("  from ec_sms ");
            sql.Append(" where mobile=@mobile");

            DynamicParameters param = new DynamicParameters();
            param.Add("mobile", mobile);

            return db.Get<Wuyiju.Model.Sms>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Sms> GetList(Wuyiju.Model.Sms.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_sms where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Sms>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Sms> GetList(Wuyiju.Model.Sms.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_sms where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Sms>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Sms> GetPaged(PagedQuery<Wuyiju.Model.Sms.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_sms where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Sms>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}