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
    //ec_product
    public class ProductDAL : BaseDAL, IProductDAL
    {
        public ProductDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Insert(Wuyiju.Model.Product model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_product(");
            sql.Append("admin_id,name,subname,sn,category_id,market_price,price,member_price,promote_price,intro,integration,integration_buy,promote,promote_start,promote_end,recommend,click,stock,pay_status,warn_nums,sales,status,hot,new,best,sort,keywords,seo_title,seo_keys,seo_desc,brief,content,url,address_id,buyer_id,add_time,start_time,picture,log,del_time,filename,seller_id,user_return,type,video,praise_rate,collection_popularity,seller_credit,annual_turnover,protection_deposit,tech_fee,whether_goods,buyer_protection,virtual_proportion,old_customer_number,area,mall_type,trademark_type,trademark_no,tax_qualification,score,smallarea,company_level,guanlian_id,reason,weiscore");
            sql.Append(") values (");
            sql.Append("@admin_id,@name,@subname,@sn,@category_id,@market_price,@price,@member_price,@promote_price,@intro,@integration,@integration_buy,@promote,@promote_start,@promote_end,@recommend,@click,@stock,@pay_status,@warn_nums,@sales,@status,@hot,@new,@best,@sort,@keywords,@seo_title,@seo_keys,@seo_desc,@brief,@content,@url,@address_id,@buyer_id,@add_time,@start_time,@picture,@log,@del_time,@filename,@seller_id,@user_return,@type,@video,@praise_rate,@collection_popularity,@seller_credit,@annual_turnover,@protection_deposit,@tech_fee,@whether_goods,@buyer_protection,@virtual_proportion,@old_customer_number,@area,@mall_type,@trademark_type,@trademark_no,@tax_qualification,@score,@smallarea,@company_level,@guanlian_id,@reason,@weiscore");
            sql.Append(") ");

            DynamicParameters param = new DynamicParameters();
            if (model != null)
            {
                param.AddDynamicParams(model);
            }

            var rows = db.Execute(sql, param);


            if (rows < 1)
                throw new ApplicationException("插入数据无效");

            return db.ExecuteScalar<int>("SELECT LAST_INSERT_ID() from ec_product");
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Wuyiju.Model.Product model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_product set ");

            sql.Append(" admin_id = @admin_id , ");
            sql.Append(" name = @name , ");
            sql.Append(" subname = @subname , ");
            sql.Append(" sn = @sn , ");
            sql.Append(" category_id = @category_id , ");
            sql.Append(" market_price = @market_price , ");
            sql.Append(" price = @price , ");
            sql.Append(" member_price = @member_price , ");
            sql.Append(" promote_price = @promote_price , ");
            sql.Append(" intro = @intro , ");
            sql.Append(" integration = @integration , ");
            sql.Append(" integration_buy = @integration_buy , ");
            sql.Append(" promote = @promote , ");
            sql.Append(" promote_start = @promote_start , ");
            sql.Append(" promote_end = @promote_end , ");
            sql.Append(" recommend = @recommend , ");
            sql.Append(" click = @click , ");
            sql.Append(" stock = @stock , ");
            sql.Append(" pay_status = @pay_status , ");
            sql.Append(" warn_nums = @warn_nums , ");
            sql.Append(" sales = @sales , ");
            sql.Append(" status = @status , ");
            sql.Append(" hot = @hot , ");
            sql.Append(" new = @new , ");
            sql.Append(" best = @best , ");
            sql.Append(" sort = @sort , ");
            sql.Append(" keywords = @keywords , ");
            sql.Append(" seo_title = @seo_title , ");
            sql.Append(" seo_keys = @seo_keys , ");
            sql.Append(" seo_desc = @seo_desc , ");
            sql.Append(" brief = @brief , ");
            sql.Append(" content = @content , ");
            sql.Append(" url = @url , ");
            sql.Append(" address_id = @address_id , ");
            sql.Append(" buyer_id = @buyer_id , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" start_time = @start_time , ");
            sql.Append(" picture = @picture , ");
            sql.Append(" log = @log , ");
            sql.Append(" del_time = @del_time , ");
            sql.Append(" filename = @filename , ");
            sql.Append(" seller_id = @seller_id , ");
            sql.Append(" user_return = @user_return , ");
            sql.Append(" type = @type , ");
            sql.Append(" video = @video , ");
            sql.Append(" praise_rate = @praise_rate , ");
            sql.Append(" collection_popularity = @collection_popularity , ");
            sql.Append(" seller_credit = @seller_credit , ");
            sql.Append(" annual_turnover = @annual_turnover , ");
            sql.Append(" protection_deposit = @protection_deposit , ");
            sql.Append(" tech_fee = @tech_fee , ");
            sql.Append(" whether_goods = @whether_goods , ");
            sql.Append(" buyer_protection = @buyer_protection , ");
            sql.Append(" virtual_proportion = @virtual_proportion , ");
            sql.Append(" old_customer_number = @old_customer_number , ");
            sql.Append(" area = @area , ");
            sql.Append(" mall_type = @mall_type , ");
            sql.Append(" trademark_type = @trademark_type , ");
            sql.Append(" trademark_no = @trademark_no , ");
            sql.Append(" tax_qualification = @tax_qualification , ");
            sql.Append(" score = @score , ");
            sql.Append(" smallarea = @smallarea , ");
            sql.Append(" company_level = @company_level , ");
            sql.Append(" guanlian_id = @guanlian_id,  ");
            sql.Append(" reason = @reason,  ");
            sql.Append(" weiscore = @weiscore  ");
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
            sql.Append("delete from ec_product ");
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
        public Wuyiju.Model.Product Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, admin_id, name, subname, sn, category_id, market_price, price, member_price, promote_price, intro, integration, integration_buy, promote, promote_start, promote_end, recommend, click, stock, pay_status, warn_nums, sales, status, hot, new, best, sort, keywords, seo_title, seo_keys, seo_desc, brief, content, url, address_id, buyer_id, add_time, start_time, picture, log, del_time, filename, seller_id, user_return, type, video, praise_rate, collection_popularity, seller_credit, annual_turnover, protection_deposit, tech_fee, whether_goods, buyer_protection, virtual_proportion, old_customer_number, area, mall_type, trademark_type, trademark_no, tax_qualification,score,smallarea,company_level,guanlian_id,weiscore  ");
            sql.Append("  from ec_product ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Product>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Product> GetList(Wuyiju.Model.Product.Query query)
        {

            StringBuilder sql = new StringBuilder(@"SELECT t.id,t.brief,t.admin_id,t.name,t.subname,t.sn,t.category_id,t.market_price,t.price,t.member_price,t.promote_price,t.intro,t.integration,t.integration_buy,t.promote,t.promote_start,t.promote_end,t.recommend,t.click,t.stock,t.pay_status,t.warn_nums,t.sales,t.status,t.hot,t.new,t.best,t.sort,t.keywords,t.seo_title,t.seo_keys,t.seo_desc,t.url,t.address_id,t.buyer_id,t.add_time,t.start_time,t.log,t.del_time,t.filename,t.seller_id,t.user_return,t.type,t.praise_rate,t.collection_popularity,t.seller_credit,t.annual_turnover,t.protection_deposit,t.tech_fee,t.whether_goods,t.buyer_protection,t.virtual_proportion,t.old_customer_number,t.area,t.mall_type,t.trademark_type,t.trademark_no,t.tax_qualification,t.score,t.smallarea,t.company_level,t.guanlian_id,t.weiscore,t.reason,n.name category_name FROM ec_product t 
                        INNER JOIN ec_category n INNER JOIN ec_admin m on t.category_id = n.id and t.guanlian_id=m.id and t.status!=-2
                    where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("t.category_id", "cat_id")
                .AndEquals("t.status", "status")
                .AndEquals("t.type", "type")
                .AndEquals("t.pay_status", "pay_status")
                .AndEquals("t.hot", "hot")
                .AndEquals("t.best", "best")
                .AndEquals("m.parent_id", "parent_id")
                .AndEquals("t.trademark_type", "trademark_type")
                .AndEquals("t.mall_type", "malltype")
                .AndEquals("t.seller_id", "seller_id")
                .AndEquals("t.smallarea", "smallarea")
                .AndEquals("t.area", "area")
                .AndEquals("t.sales", "sales")
                .AndEquals("t.guanlian_id", "guanlian_id")
                .AndEquals("t.company_level", "company_level")
                .AndEquals("t.subname", "subname")
                .AndEquals("t.admin_id", "admin_id")
                .AndEquals("t.recommend", "recommend")
                .AndBetween("t.price", "StartPrice", "EndPrice")
                .AndBetween("t.start_time", "starttime1", "starttime2")
                .AndLike("t.name", "keyword");

            if (query != null)
            {
                param.AddDynamicParams(query);
                sql.Append(AttributeQuery(query, ref param));
            }

            return db.GetList<Wuyiju.Model.Product>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Product> GetList(Wuyiju.Model.Product.Query query, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"SELECT t.id,t.brief,t.admin_id,t.name,t.subname,t.sn,t.category_id,t.market_price,t.price,t.member_price,t.promote_price,t.intro,t.integration,t.integration_buy,t.promote,t.promote_start,t.promote_end,t.recommend,t.click,t.stock,t.pay_status,t.warn_nums,t.sales,t.status,t.hot,t.new,t.best,t.sort,t.keywords,t.seo_title,t.seo_keys,t.seo_desc,t.url,t.address_id,t.buyer_id,t.add_time,t.start_time,t.log,t.del_time,t.filename,t.seller_id,t.user_return,t.type,t.praise_rate,t.collection_popularity,t.seller_credit,t.annual_turnover,t.protection_deposit,t.tech_fee,t.whether_goods,t.buyer_protection,t.virtual_proportion,t.old_customer_number,t.area,t.mall_type,t.trademark_type,t.trademark_no,t.tax_qualification,t.score,t.smallarea,t.company_level,t.guanlian_id,t.weiscore,t.reason,n.name category_name,attr101.attr_value as categories,attr290.attr_value as trademark  FROM ec_product t 
                        INNER JOIN ec_category n on t.category_id = n.id
                        LEFT JOIN (select * from ec_product_attr where attr_id = 101) attr101 on attr101.product_id = t.id
                        LEFT JOIN (select * from ec_product_attr where attr_id = 290) attr290 on attr290.product_id = t.id
                    where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("t.category_id", "cat_id")
                .AndEquals("t.status", "status")
                .AndEquals("t.type", "type")
                .AndEquals("t.pay_status", "pay_status")
                .AndEquals("t.hot", "hot")
                .AndEquals("t.best", "best")
                .AndEquals("t.new", "new")
                .AndEquals("t.trademark_type", "trademark_type")
                .AndEquals("t.mall_type", "malltype")
                .AndEquals("t.seller_id", "seller_id")
                .AndEquals("t.sales", "sales")
                .AndEquals("t.recommend", "recommend")
                .AndBetween("t.price", "StartPrice", "EndPrice")
                .AndLike("t.name", "keyword");


            

            if (query != null)
            {
                param.AddDynamicParams(query);
                sql.Append(AttributeQuery(query, ref param));
            }

           // sql.Append(" order by t.add_time desc , t.sort desc ");

            if (limit != null) sql.Append(" limit  @rows ");
            if (limit != null) param.Add("rows", limit);

            return db.GetList<Wuyiju.Model.Product>(sql, param);
        }

        /// <summary>
        /// 构造属性筛选条件
        /// </summary>
        /// <param name="query"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        private string AttributeQuery(Wuyiju.Model.Product.Query Filter, ref DynamicParameters param)
        {
            var sql = new StringBuilder();

            if (Filter != null && Filter.Attrs != null && Filter.Attrs.Count > 0)
            {
                sql.Append(" and t.id in (select a.product_id from ec_product_attr a where ");

                int i = 0;

                foreach (var attr in Filter.Attrs)
                {
                    if (attr.Key > 0)
                    {
                        if (attr.Key == 101)
                        {
                            sql.AppendFormat(" {0} (a.attr_id = @attr_key{1} ", i > 0 ? "and" : "", i);

                            param.Add(string.Format("attr_key{0}", i), attr.Key);

                            if (!string.IsNullOrWhiteSpace(attr.Value))
                            {
                                sql.AppendFormat(" and a.attr_value like CONCAT('%',@attr_val{0},'%') ", i);
                                param.Add(string.Format("attr_val{0}", i), attr.Value);
                            }

                            sql.Append(" ) ");
                        }
                        else
                        {
                            sql.AppendFormat(" {0} (a.attr_id = @attr_key{1} ", i > 0 ? "and" : "", i);

                            param.Add(string.Format("attr_key{0}", i), attr.Key);

                            if (!string.IsNullOrWhiteSpace(attr.Value))
                            {
                                sql.AppendFormat(" and a.attr_value = @attr_val{0} ", i);
                                param.Add(string.Format("attr_val{0}", i), attr.Value);
                            }

                            sql.Append(" ) ");
                        }
                    }

                    i++;
                }

                sql.Append(" ) ");

            }

            return sql.ToString();
        }

        public Paged<Wuyiju.Model.Product> GetPaged(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"SELECT t.id,t.brief,t.admin_id,t.name,t.subname,t.sn,t.category_id,t.market_price,t.price,t.member_price,t.promote_price,t.intro,t.integration,t.integration_buy,t.promote,t.promote_start,t.promote_end,t.recommend,t.click,t.stock,t.pay_status,t.warn_nums,t.sales,t.status,t.hot,t.new,t.best,t.sort,t.keywords,t.seo_title,t.seo_keys,t.seo_desc,t.url,t.address_id,t.buyer_id,t.add_time,t.start_time,t.log,t.del_time,t.filename,t.seller_id,t.user_return,t.type,t.praise_rate,t.collection_popularity,t.seller_credit,t.annual_turnover,t.protection_deposit,t.tech_fee,t.whether_goods,t.buyer_protection,t.virtual_proportion,t.old_customer_number,t.area,t.mall_type,t.trademark_type,t.trademark_no,t.tax_qualification,t.score,t.smallarea,t.company_level,t.guanlian_id,t.weiscore,t.reason,n.name category_name,a.qq FROM ec_product t 
                        INNER JOIN ec_category n on t.category_id = n.id
                        LEFT JOIN ec_admin a on t.admin_id = a.id
                    where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("t.category_id", "cat_id")
                .AndEquals("t.status", "status")
                .AndEquals("t.type", "type")
                .AndEquals("t.pay_status", "pay_status")
                .AndEquals("t.hot", "hot")
                .AndEquals("t.best", "best")
                .AndEquals("t.new", "new")
                .AndEquals("a.parent_id", "parent_id")
                .AndEquals("t.sales", "sales")
                .AndEquals("t.trademark_type", "trademark_type")
                .AndEquals("t.mall_type", "malltype")
                .AndEquals("t.seller_id", "seller_id")
                .AndEquals("t.recommend", "recommend")
                .AndEquals("t.Whether_Goods", "Whether_Goods")
                .AndEquals("t.admin_id","admin_id")
                .AndBetween("t.price", "StartPrice", "EndPrice")
                .AndLike("t.area", "area");


            sql.Append(" and (t.start_time >= unix_timestamp(@StartDate) or @StartDate is null) ");

            sql.Append(" and (t.start_time <= unix_timestamp(@EndDate) or @EndDate is null) ");

            sql.Append(" and ( t.id in (select attr.product_id from ec_product_attr attr where attr.attr_value like CONCAT('%',@Keyword,'%') and attr.product_id = t.id ) OR t.name like  CONCAT('%',@Keyword,'%') or n.name like  CONCAT('%',@Keyword,'%') or t.keywords like  CONCAT('%',@Keyword,'%') or t.sn = @Keyword  or @Keyword is null ) ");

            //.Append(" and ( t.id in (select attr.product_id from ec_product_attr attr where MATCH(attr.attr_value) AGAINST(@Keyword) and attr.product_id = t.id ) OR MATCH(t.name) AGAINST(@Keyword) or MATCH(n.name) AGAINST(@Keyword) or MATCH(t.keywords) AGAINST(@Keyword) or t.sn = @Keyword  or @Keyword is null ) ");

            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }

            sql.Append(AttributeQuery(query.Filter, ref param));


            return db.GetPaged<Wuyiju.Model.Product>(sql, param, query.PageStart, query.PageSize, query.Draw, query.Order);
        }


        public Paged<Wuyiju.Model.Product> GetPagedAdmin(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"SELECT t.id,t.brief,t.admin_id,t.name,t.subname,t.sn,t.category_id,t.market_price,t.price,t.member_price,t.promote_price,t.intro,t.integration,t.integration_buy,t.promote,t.promote_start,t.promote_end,t.recommend,t.click,t.stock,t.pay_status,t.warn_nums,t.sales,t.status,t.hot,t.new,t.best,t.sort,t.keywords,t.seo_title,t.seo_keys,t.seo_desc,t.url,t.address_id,t.buyer_id,t.add_time,t.start_time,t.log,t.del_time,t.filename,t.seller_id,t.user_return,t.type,t.praise_rate,t.collection_popularity,t.seller_credit,t.annual_turnover,t.protection_deposit,t.tech_fee,t.whether_goods,t.buyer_protection,t.virtual_proportion,t.old_customer_number,t.area,t.mall_type,t.trademark_type,t.trademark_no,t.tax_qualification,t.score,t.smallarea,t.company_level,t.guanlian_id,t.weiscore,t.reason,n.name category_name,a.qq,a.username guan_name,m.mobile seller_phone,m.realname seller_name,left(q.position,4) zubie_name FROM ec_product t 
                        INNER JOIN ec_category n on t.category_id = n.id
                        LEFT JOIN ec_admin a on t.guanlian_id = a.id LEFT JOIN ec_user m on t.seller_id=m.id LEFT JOIN ec_admin q on a.parent_id=q.id
                    where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("t.category_id", "cat_id") 
                .AndEquals("t.status", "status")
                .AndEquals("t.type", "type")
                .AndEquals("t.pay_status", "pay_status")
                .AndEquals("t.hot", "hot")
                .AndEquals("t.best", "best")
                .AndEquals("t.new", "new")
                .AndEquals("t.sn", "sn")
                .AndLike("t.name", "name")
                .AndLike("t.subname", "subname")
                .AndEquals("a.parent_id", "parent_id")
                .AndEquals("t.sales", "sales")
                .AndEquals("t.trademark_type", "trademark_type")
                .AndEquals("t.mall_type", "malltype")
                .AndEquals("t.smallarea", "smallarea")
                .AndEquals("t.seller_id", "seller_id")
                .AndEquals("t.recommend", "recommend")
                .AndEquals("t.company_level", "company_level")
                .AndEquals("t.Whether_Goods", "Whether_Goods")
                .AndEquals("t.admin_id", "admin_id")
                .AndEquals("t.guanlian_id", "guanlian_id")
                .AndBetween("t.price", "StartPrice", "EndPrice")
                .AndBetween("t.start_time", "starttime1", "starttime2")
                .AndLike("t.area", "area");


            //sql.Append(" and (1 = 1 ");
            //sql.OrLike("t.name", "Keyword");
            //sql.OrLike("n.name", "Keyword");
            //sql.OrLike("t.sn", "Keyword");
            //sql.OrLike("t.Keywords", "Keyword");
            //sql.Append(" or @Keyword is null) ");

            sql.Append(" and (t.start_time >= unix_timestamp(@StartDate) or @StartDate is null) ");

            sql.Append(" and (t.start_time <= unix_timestamp(@EndDate) or @EndDate is null) ");

            sql.Append(" and ( t.id in (select attr.product_id from ec_product_attr attr where attr.attr_value like CONCAT('%',@Keyword,'%') and attr.product_id = t.id ) OR t.name like  CONCAT('%',@Keyword,'%') or n.name like  CONCAT('%',@Keyword,'%') or t.keywords like  CONCAT('%',@Keyword,'%') or t.sn = @Keyword  or @Keyword is null ) ");

            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }

            sql.Append(AttributeQuery(query.Filter, ref param));


            return db.GetPaged<Wuyiju.Model.Product>(sql, param, query.PageStart, query.PageSize, query.Draw, query.Order);
        }


        public Paged<Wuyiju.Model.Product> GetPagedOrder(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"SELECT t.id,t.brief,t.admin_id,t.name,t.subname,t.sn,t.category_id,t.market_price,t.price,t.member_price,t.promote_price,t.intro,t.integration,t.integration_buy,t.promote,t.promote_start,t.promote_end,t.recommend,t.click,t.stock,t.pay_status,t.warn_nums,t.sales,t.status,t.hot,t.new,t.best,t.sort,t.keywords,t.seo_title,t.seo_keys,t.seo_desc,t.url,t.address_id,t.buyer_id,t.add_time,t.start_time,t.log,t.del_time,t.filename,t.seller_id,t.user_return,t.type,t.praise_rate,t.collection_popularity,t.seller_credit,t.annual_turnover,t.protection_deposit,t.tech_fee,t.whether_goods,t.buyer_protection,t.virtual_proportion,t.old_customer_number,t.area,t.mall_type,t.trademark_type,t.trademark_no,t.tax_qualification,t.score,t.smallarea,t.company_level,t.guanlian_id,t.weiscore,t.reason,n.name category_name,a.qq,a.username guan_name,m.pay_statu pay_status,left(q.position,4) zubie_name FROM ec_product t 
                        INNER JOIN ec_category n on t.category_id = n.id
                        LEFT JOIN ec_admin a on t.guanlian_id = a.id LEFT JOIN ec_order m on t.id=m.product_id LEFT JOIN ec_admin q on a.parent_id=q.id
                    where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("t.category_id", "cat_id")
                .AndEquals("t.status", "status")
                .AndEquals("t.type", "type")
                .AndEquals("t.pay_status", "pay_status")
                .AndEquals("t.hot", "hot")
                .AndEquals("t.best", "best")
                .AndEquals("t.new", "new")
                .AndEquals("a.parent_id", "parent_id")
                .AndEquals("t.sales", "sales")
                .AndEquals("t.trademark_type", "trademark_type")
                .AndEquals("t.company_level", "company_level")
                .AndEquals("t.mall_type", "malltype")
                .AndEquals("t.seller_id", "seller_id")
                .AndEquals("t.recommend", "recommend")
                .AndEquals("t.Whether_Goods", "Whether_Goods")
                .AndEquals("t.admin_id", "admin_id")
                .AndEquals("t.guanlian_id", "guanlian_id")
                .AndBetween("t.price", "StartPrice", "EndPrice")
                .AndLike("t.area", "area");


            //sql.Append(" and (1 = 1 ");
            //sql.OrLike("t.name", "Keyword");
            //sql.OrLike("n.name", "Keyword");
            //sql.OrLike("t.sn", "Keyword");
            //sql.OrLike("t.Keywords", "Keyword");
            //sql.Append(" or @Keyword is null) ");

            sql.Append(" and (t.start_time >= unix_timestamp(@StartDate) or @StartDate is null) ");

            sql.Append(" and (t.start_time <= unix_timestamp(@EndDate) or @EndDate is null) ");

            sql.Append(" and ( t.id in (select attr.product_id from ec_product_attr attr where attr.attr_value like CONCAT('%',@Keyword,'%') and attr.product_id = t.id ) OR t.name like  CONCAT('%',@Keyword,'%') or n.name like  CONCAT('%',@Keyword,'%') or t.keywords like  CONCAT('%',@Keyword,'%') or t.sn = @Keyword  or @Keyword is null ) ");

            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }

            sql.Append(AttributeQuery(query.Filter, ref param));


            return db.GetPaged<Wuyiju.Model.Product>(sql, param, query.PageStart, query.PageSize, query.Draw, query.Order);
        }

        public Paged<Wuyiju.Model.ProductFavorited> GetFavoritedPaged(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"SELECT f.*,p.name AS pname,p.sn,p.add_time as p_add_time,p.price,p.sales,p.type as ptype,p.start_time,p.seller_credit,c.name category_name FROM ec_product p INNER JOIN ec_category c on p.category_id = c.id INNER JOIN ec_favorites f ON f.product_id = p.id where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("p.category_id", "cat_id")
                .AndEquals("p.status", "status")
                .AndEquals("p.pay_status", "pay_status")
                .AndEquals("p.hot", "hot")
                .AndEquals("p.best", "best")
                .AndEquals("f.user_id", "user_id")
                .AndEquals("p.seller_id", "seller_id")
                .AndLike("p.name", "keyword");

            //sql.Append(" and ( t.name like '%PC%' ) ");
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }

            IList<OrderRule> order = new List<OrderRule>();

            order.Add(new OrderRule { Column = "v.add_time", dir = "desc" });


            return db.GetPaged<Wuyiju.Model.ProductFavorited>(sql, param, query.PageStart, query.PageSize, query.Draw, order);
        }

        public int GetCount(Wuyiju.Model.Product.Query query)
        {
            StringBuilder sql = new StringBuilder(@"SELECT count(*) FROM ec_product t 
                        INNER JOIN ec_category n on t.category_id = n.id
                    where 1 = 1 ");

            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("t.category_id", "cat_id")
                .AndEquals("t.status", "status")
                .AndEquals("t.type", "type")
                .AndEquals("t.pay_status", "pay_status")
                .AndEquals("t.hot", "hot")
                .AndEquals("t.best", "best")
                .AndEquals("t.new", "new")
                .AndEquals("t.trademark_type", "trademark_type")
                .AndEquals("t.mall_type", "malltype")
                .AndEquals("t.seller_id", "seller_id")
                .AndBetween("t.price", "StartPrice", "EndPrice")
                .AndLike("t.name", "keyword");

            sql.AndDateBetween("t.add_time", "startdate", "enddate");


            if (query != null)
            {
                param.AddDynamicParams(query);
            }

            return db.ExecuteScalar<int>(sql.ToString(), param);
        }

        public int GetMaxId()
        {
            StringBuilder sql = new StringBuilder(@"select max(id) from ec_product ");
            return db.ExecuteScalar<int>(sql.ToString());
        }



    }
}