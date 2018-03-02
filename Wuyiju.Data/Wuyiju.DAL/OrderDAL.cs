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
    //ec_order
    public class OrderDAL : BaseDAL, IOrderDAL
    {
        public OrderDAL(DataContext db) : base(db) { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Insert(Wuyiju.Model.Order model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ec_order(");
            sql.Append("sn,product_id,status,pay_statu,username,name,uid,seller_id,tel,mobile,email,add_time,rest_time,countdown,pay_time,pay_id,discount,coupon,price,num,total_fee,pay_fee,trade_no,txt,del,del_time,send_mail,fee,ensure,techfee,deposit");
            sql.Append(") values (");
            sql.Append("@sn,@product_id,@status,@pay_statu,@username,@name,@uid,@seller_id,@tel,@mobile,@email,@add_time,@rest_time,@countdown,@pay_time,@pay_id,@discount,@coupon,@price,@num,@total_fee,@pay_fee,@trade_no,@txt,@del,@del_time,@send_mail,@fee,@ensure,@techfee,@deposit");
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
        public void Update(Wuyiju.Model.Order model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ec_Order set ");

            sql.Append(" sn = @sn , ");
            sql.Append(" product_id = @product_id , ");
            sql.Append(" status = @status , ");
            sql.Append(" pay_statu = @pay_statu , ");
            sql.Append(" username = @username , ");
            sql.Append(" name = @name , ");
            sql.Append(" uid = @uid , ");
            sql.Append(" seller_id = @seller_id , ");
            sql.Append(" tel = @tel , ");
            sql.Append(" mobile = @mobile , ");
            sql.Append(" email = @email , ");
            sql.Append(" add_time = @add_time , ");
            sql.Append(" rest_time = @rest_time , ");
            sql.Append(" countdown = @countdown , ");
            sql.Append(" pay_time = @pay_time , ");
            sql.Append(" pay_id = @pay_id , ");
            sql.Append(" discount = @discount , ");
            sql.Append(" coupon = @coupon , ");
            sql.Append(" price = @price , ");
            sql.Append(" num = @num , ");
            sql.Append(" total_fee = @total_fee , ");
            sql.Append(" pay_fee = @pay_fee , ");
            sql.Append(" trade_no = @trade_no , ");
            sql.Append(" txt = @txt , ");
            sql.Append(" del = @del , ");
            sql.Append(" del_time = @del_time , ");
            sql.Append(" send_mail = @send_mail , ");
            sql.Append(" fee = @fee , ");
            sql.Append(" ensure = @ensure , ");
            sql.Append(" techfee = @techfee , ");
            sql.Append(" deposit = @deposit  ");
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
            sql.Append("delete from ec_order ");
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
        public Wuyiju.Model.Order Get(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, sn, product_id, status, pay_statu, username, name, uid, seller_id, tel, mobile, email, add_time, rest_time, countdown, pay_time, pay_id, discount, coupon, price, num, total_fee, pay_fee, trade_no, txt, del, del_time, send_mail, fee, ensure, techfee, deposit  ");
            sql.Append("  from ec_order ");
            sql.Append(" where id=@id");

            DynamicParameters param = new DynamicParameters();
            param.Add("id", id);

            return db.Get<Wuyiju.Model.Order>(sql, param);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Wuyiju.Model.Order Get(string sn)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select id, sn, product_id, status, pay_statu, username, name, uid, seller_id, tel, mobile, email, add_time, rest_time, countdown, pay_time, pay_id, discount, coupon, price, num, total_fee, pay_fee, trade_no, txt, del, del_time, send_mail, fee, ensure, techfee, deposit  ");
            sql.Append("  from ec_order ");
            sql.Append(" where sn=@sn");

            DynamicParameters param = new DynamicParameters();
            param.Add("sn", sn);

            return db.Get<Wuyiju.Model.Order>(sql, param);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>		
        public IList<Wuyiju.Model.Order> GetList(Wuyiju.Model.Order.Query filter)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_order where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            sql.AndBetween("add_time", "StartTime", "EndTime")
               .AndEquals("status")
               .AndEquals("pay_statu", "pay_status")
               .AndEquals("add_time")
               .AndEquals("Uid")
               .AndEquals("del")
               .AndEquals("product_id");
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.Order>(sql, param);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Order> GetList(Wuyiju.Model.Order.Query filter, int? limit = null)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_order where 1 = 1 ");
            if (limit != null) sql.Append(" limit  @rows ");
            DynamicParameters param = new DynamicParameters();
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            if (limit != null) param.Add("rows", limit);
            return db.GetList<Wuyiju.Model.Order>(sql, param);
        }

        public Paged<Wuyiju.Model.Order> GetPaged(PagedQuery<Wuyiju.Model.Order.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"select * from ec_order where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }


            return db.GetPaged<Wuyiju.Model.Order>(sql, param, query.PageStart, query.PageSize, query.Draw);
        }


        public Paged<Wuyiju.Model.ProductBought> GetBoughtPaged(PagedQuery<Wuyiju.Model.Order.Query> query)
        {
            StringBuilder sql = new StringBuilder(@"SELECT o.*,p.name AS pname,p.price as ppricce,p.sales,p.pay_status,p.type FROM ec_order o INNER JOIN ec_product AS p ON o.product_id=p.id where 1 = 1 ");
            DynamicParameters param = new DynamicParameters();

            sql.AndEquals("o.uid", "uid");
            sql.AndEquals("o.pay_statu", "pay_status");
            //sql.Append(" and ( t.name like '%PC%' ) ");
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }

            IList<OrderRule> order = new List<OrderRule>();

            order.Add(new OrderRule { Column = "v.add_time", dir = "desc" });

            return db.GetPaged<Wuyiju.Model.ProductBought>(sql, param, query.PageStart, query.PageSize, query.Draw, order);
        }


        public Paged<Wuyiju.Model.Order> GetOrieridPage(PagedQuery<Wuyiju.Model.Order.Query> query)
        {
            StringBuilder sql = new StringBuilder(@" SELECT o.*,p.name AS product_name,p.subname as sub_name,p.url,
            m.name As buy_name,m.mobile As buy_phone,m.realname As buy_realname,n.name As sell_name,n.mobile As sell_phone,n.realname As sell_realname
            FROM ec_order o INNER JOIN ec_product AS p ON o.product_id=p.id inner join
            ec_user As m on o.uid=m.id left join ec_user As n on p.seller_id =n.id inner join ec_admin z on z.id=p.admin_id or z.id=p.guanlian_id
            where 1 = 1");
            DynamicParameters param = new DynamicParameters();

            //sql.AndEquals("p.admin_id", "admin_id");
            //sql.AndEquals("z.guanlian_id", "guanlian_id");
            sql.AndBetween("o.add_time", "StartTime", "EndTime");
            sql.AndEquals("o.status", "status");
            sql.AndEquals("o.pay_statu", "pay_status");
            sql.AndEquals("z.parent_id", "parent_id");
            sql.AndEquals("o.del", "del");
            if (query.Filter.Guanlian_Id != null)
            {
                sql.Append(" and (p.admin_id = @guanlian_id or p.guanlian_id = @guanlian_id) group by o.id");
            }
            else {
                sql.Append("  group by o.id");
            }
            if (query.Filter != null)
            {
                param.AddDynamicParams(query.Filter);
            }

            IList<OrderRule> order = new List<OrderRule>();

            order.Add(new OrderRule { Column = "v.add_time", dir = "desc" });

            return db.GetPaged<Wuyiju.Model.Order>(sql, param, query.PageStart, query.PageSize, query.Draw, order);
        }

        public IList<Wuyiju.Model.YejiModel> GetYejiTongji(Wuyiju.Model.YejiModel.Query filter)
        {        
            StringBuilder newsql = new StringBuilder();
            StringBuilder sql = new StringBuilder(@"select hj.*,ye.storenum,left(zu.position,4) as zubie,zd.tuijiannum from (select t.parent_id, t.`name` as yewuyuan, COUNT(case when z.id is not null and z.guanlian_id=t.id then 1 end) as guanliannum,
              COUNT(case when z.id is not null and z.admin_id=t.id then 1 end) as xiaoshounum,
             COUNT(case when z.id is not null and z.guanlian_id=t.id or z.admin_id=t.id then 1 end) as total_num,
             SUM(case when z.id is not null and z.guanlian_id=t.id then z.price*2/3 end) as totalguanlian,
             SUM(case when z.id is not null and z.admin_id=t.id then z.price*1/3 end) as totalxiaoshou,
             SUM(case when z.id is not null and z.guanlian_id=t.id then z.price*2/3 end)+
              SUM(case when z.id is not null and z.admin_id=t.id then z.price*1/3 end) as totalyeji
            from ec_admin t LEFT JOIN
             (select n.price,n.id,n.guanlian_id,n.admin_id from ec_order m LEFT JOIN ec_product n on n.id=m.product_id where
             m.add_time>=@startdate and m.add_time<=@enddate and m.status!=2 and m.status!=3 and (m.pay_statu=1 or m.pay_statu=2 ) and m.del=0 ");

            if (filter.status != null)
            {
                sql.Append(" and m.status=@status ");
            }

            if (filter.parent_id != null)
            {
               newsql = new StringBuilder(@") as z on  t.id=z.admin_id or t.id=z.guanlian_id  where t.role_id=8 and t.parent_id=@parent_id group by yewuyuan) as hj left join (select h.`name` as yeyuyuan,  
           COUNT(case when y.id is not null then 1 end) as storenum from ec_admin h left join ec_product y on y.guanlian_id=h.id where h.role_id=8
           and y.add_time>=@startdate and y.add_time<=@enddate GROUP BY yeyuyuan)
           as ye on hj.yewuyuan=ye.yeyuyuan LEFT JOIN (select sd.`name` as yeyuyuan,  
           COUNT(case when sz.id is not null then 1 end) as tuijiannum from ec_admin sd left join
           ec_user sz on sd.username=sz.introducer where sd.role_id=8 and sz.add_time>=@startdate and sz.add_time<=@enddate  GROUP BY yeyuyuan) as zd on ye.yeyuyuan=zd.yeyuyuan left join
          ec_admin as zu on zu.id=hj.parent_id");
            }
            else
            {
                newsql = new StringBuilder(@") as z on  t.id=z.admin_id or t.id=z.guanlian_id   where t.role_id=8 group by yewuyuan) as hj left join (select h.`name` as yeyuyuan,  
           COUNT(case when y.id is not null then 1 end) as storenum from ec_admin h left join ec_product y on y.guanlian_id=h.id where h.role_id=8
           and y.add_time>=@startdate and y.add_time<=@enddate GROUP BY yeyuyuan)
           as ye on hj.yewuyuan=ye.yeyuyuan LEFT JOIN (select sd.`name` as yeyuyuan,  
           COUNT(case when sz.id is not null then 1 end) as tuijiannum from ec_admin sd left join
           ec_user sz on sd.username=sz.introducer where sd.role_id=8 and sz.add_time>=@startdate and sz.add_time<=@enddate  GROUP BY yeyuyuan) as zd on ye.yeyuyuan=zd.yeyuyuan left join
          ec_admin as zu on zu.id=hj.parent_id");
            }

            newsql.Append(" order by " + filter.yejistyle + " desc;");
            sql.Append(newsql.ToString());
            DynamicParameters param = new DynamicParameters();

            //sql.AndEquals("p.admin_id", "admin_id");
            //sql.AndEquals("z.guanlian_id", "guanlian_id");
            //sql.AndBetween("o.add_time", "startdate", "enddate");
            //sql.AndEquals("o.status", "status");
            //sql.AndEquals("z.parent_id", "parent_id");
            if (filter != null)
            {
                param.AddDynamicParams(filter);
            }
            return db.GetList<Wuyiju.Model.YejiModel>(sql, param);
        }

        public int GetCount(Wuyiju.Model.Order.Query query)
        {
            StringBuilder sql = new StringBuilder(@"select count(*) from ec_order where 1=1 ");

            sql.AndDateBetween("add_time", "startdate", "enddate")
               .AndEquals("status")
               .AndEquals("pay_statu", "pay_status")
               .AndEquals("add_time")
               .AndEquals("del")
               .AndEquals("uid")
               .AndEquals("product_id");


            DynamicParameters param = new DynamicParameters();


            if (query != null)
            {
                param.AddDynamicParams(query);
            }

            return db.ExecuteScalar<int>(sql.ToString(), param);
        }

        public IList<Wuyiju.View.LineChartJS> GetCount(Wuyiju.View.LineChartJS.Query query)
        {
            StringBuilder sql = new StringBuilder(@"select count(*) as count, FROM_UNIXTIME(add_time) as add_time from ec_order where 1=1 ");

            sql.AndDateBetween("add_time", "startdate", "enddate");

            sql.AppendFormat(" group by FROM_UNIXTIME(add_time,'%Y%m%d') ");

            DynamicParameters param = new DynamicParameters();


            if (query != null)
            {
                param.AddDynamicParams(query);
            }

            return db.GetList<Wuyiju.View.LineChartJS>(sql, param);
        }



    }
}