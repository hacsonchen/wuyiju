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
	 	//ec_node
		public class NodeDAL: BaseDAL,INodeDAL
	{
   		public NodeDAL(DataContext db) : base(db) { }     
					
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Insert(Wuyiju.Model.Node model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("insert into ec_node(");			
            sql.Append("name,title,status,remark,sort,pid,level,controler,action,isallowednoneroles,iscontroler");
			sql.Append(") values (");
            sql.Append("@name,@title,@status,@remark,@sort,@pid,@level,@controler,@action,@isallowednoneroles,@iscontroler");            
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
		public void Update(Wuyiju.Model.Node model)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("update ec_node set ");
			                                                
            sql.Append(" name = @name , ");                                    
            sql.Append(" title = @title , ");                                    
            sql.Append(" status = @status , ");                                    
            sql.Append(" remark = @remark , ");                                    
            sql.Append(" sort = @sort , ");                                    
            sql.Append(" pid = @pid , ");                                    
            sql.Append(" level = @level , ");

            sql.Append(" controler = @controler , ");
            sql.Append(" action = @action , ");
            sql.Append(" isallowednoneroles = @isallowednoneroles , ");
            sql.Append(" iscontroler = @iscontroler ");
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
			sql.Append("delete from ec_node ");
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
		public Wuyiju.Model.Node Get(Wuyiju.Model.Node obj)
		{
			
			StringBuilder sql=new StringBuilder();
			sql.Append("select id, name, title, status, remark, sort, pid, level,controler,action,isallowednoneroles,iscontroler");			
			sql.Append("  from ec_node ");
			sql.Append(" where action=@action and controler=@controler ");
			
			DynamicParameters param = new DynamicParameters();
            param.Add("action", obj.Action);
            param.Add("controler", obj.Controler);
            return db.Get<Wuyiju.Model.Node>(sql, param);
		}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Wuyiju.Model.Node Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, name, title, status, remark, sort, pid, level,controler,action,isallowednoneroles,iscontroler");
            sql.Append("  from ec_node ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);
            return db.Get<Wuyiju.Model.Node>(sql, param);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Node> GetList(Wuyiju.Model.Node.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_node where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Node>(sql, param);
        }
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Node> GetList(Wuyiju.Model.Node.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_node where 1 = 1 ");
            if ( limit != null ) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if ( limit != null ) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Node>(sql, param);
        }
        
        public Paged<Wuyiju.Model.Node> GetPaged(PagedQuery<Wuyiju.Model.Node.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_node where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }
            

            return db.GetPaged<Wuyiju.Model.Node>(sql, param, query.PageStart, query.PageSize,query.Draw);
        }

   
	}
}