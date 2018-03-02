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
    //ec_question_type
    public class QuestionTypeDAL : BaseDAL, IQuestionTypeDAL
    {
        public QuestionTypeDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.QuestionType model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_question_type(");
            sql.Append("type_name,amount");
            sql.Append(") values (");
            sql.Append("@type_name,@amount");
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
        public void Update(Wuyiju.Model.QuestionType model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update QuestionType set ");

            sql.Append(" type_name = @type_name , ");
            sql.Append(" amount = @amount  ");
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

            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ec_question_type ");
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
        public Wuyiju.Model.QuestionType Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, type_name, amount  ");
            sql.Append("  from ec_question_type ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.QuestionType>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.QuestionType> GetList(Wuyiju.Model.QuestionType.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_question_type where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.QuestionType>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.QuestionType> GetList(Wuyiju.Model.QuestionType.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_question_type where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.QuestionType>(sql, param);
        }

        public Paged<Wuyiju.Model.QuestionType> GetPaged(PagedQuery<Wuyiju.Model.QuestionType.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_question_type where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.QuestionType>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


    }
}