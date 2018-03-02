using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.DAL;
using Wuyiju.Domain.Model;
using Wuyiju.IDAL;
using Wuyiju.IService;
using Wuyiju.Model;
namespace Wuyiju.Service
{
    //ec_order
    public partial class OrderService
    {
        public decimal Discount = ApplicationConfig.SysFee;

        public Order MakeOrder(Product product, int userid)
        {
            var order = new Order();

            var productDao = unity.GetInstance<IProductDAL>();

            string prefix = "";
            string suffix = "";

            try
            {
                var configService = unity.GetInstance<IConfigService>();

                var config = configService.GetConfig("product_order");
                prefix = config.GetValue("order_prefix");
                suffix = config.GetValue("order_suffix");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Error(ex);
            }

            order.Sn = string.Format("{2}{0:yyMMddHHmm}{1}{3}", DateTime.Now, productDao.GetMaxId() + 1, prefix, suffix);

            order.Product_Id = product.Id;
            order.Status = 0;
            order.Add_Time = DateTime.Now.ToTimeStamp2();
            order.Rest_Time = order.Add_Time + 86400 * 3;
            order.Uid = userid;
            order.Price = product.Price;
            order.Num = 1;
            //order.Fee = 5000;
            order.Fee = (product.Price + product.Protection_Deposit + product.Tech_Fee) * Discount;
            order.Ensure = product.Protection_Deposit;
            order.Techfee = product.Tech_Fee;
            order.Total_Fee = product.Price + order.Fee + product.Protection_Deposit + product.Tech_Fee;
            order.Deposit = 5000;
            //order.Deposit = (product.Price + product.Protection_Deposit + product.Tech_Fee) * ApplicationConfig.Deposit;
            order.Txt = "";
            order.Seller_Id = product.Seller_Id;
            order.Sell_Name = product.Seller_Name;
            order.Sell_Phone = product.Seller_Phone;
            order.Sell_Qq = product.Seller_Qq;

            dao.Insert(order);

            return order;
        }

        public void PayOrder(Order order, int PayWay, string pay_pass)
        {
            using (var db = new DataContext())
            {

                var productDao = unity.GetInstance<IProductDAL>(db);
                var userDao = unity.GetInstance<IUserDAL>(db);
                var orderDao = unity.GetInstance<IOrderDAL>(db);

                var product = productDao.Get(order.Product_Id);

                if (pay_pass.IsNullOrWhiteSpace())
                    throw new ApplicationException("请输入支付密码");

                if (product == null || (product.Sales == 1 && order.Pay_Statu == 0))
                {
                    throw new ApplicationException("您购买的网店已售完");
                }
                else if (product.Status != 1 && order.Pay_Statu == 0)
                {
                    throw new ApplicationException("您购买的网店还没通过审核");
                }
                else if (product.Sales != 0 && order.Pay_Statu == 0)
                {
                    throw new ApplicationException("您购买的网店已售完");
                }


                var user = userDao.Get(order.Uid);

                if (user == null)
                    throw new ApplicationException("用户不存在");

                //if (order.Pay_Statu != 0)
                //    throw new ApplicationException("非法操作，此订单已经" + Order.PayStatusText(order.Pay_Statu));

                if (user.Pay_Password.IsNullOrWhiteSpace())
                    throw new ApplicationException("请设置支付密码才可以付款");

                if (!user.Pay_Password.Equals(pay_pass.ToMD5()))
                    throw new ApplicationException("支付密码不正确");

                if (order.Pay_Statu == 0)
                {
                    if (PayWay == 7)//定金
                    {
                        order.Pay_Fee = order.Deposit;
                        order.Pay_Statu = 1;
                        product.Sales = 1;
                        user.Money = (user.Money - order.Pay_Fee);
                    }
                    else if (PayWay == 0)//全额
                    {

                        order.Pay_Fee = order.Total_Fee;
                        order.Pay_Statu = 2;
                        user.Money = (user.Money - order.Pay_Fee);

                    }
                    else
                    {
                        throw new ApplicationException("暂时不支持此分期支付方式");
                    }
                }
                else if (order.Pay_Statu == 1)
                {//已交定金以下是计算余款

                    order.Pay_Statu = 2;
                    user.Money = (user.Money - order.Total_Fee - order.Pay_Fee);
                    order.Pay_Fee = order.Total_Fee;
                }
                else if (order.Pay_Statu == 2)
                {
                    throw new ApplicationException("已付全款无需再次付款");
                }
                else {
                    throw new ApplicationException("交易已经关闭请重新下单");
                }

                if ((user.Money - order.Pay_Fee) < 0)
                    throw new ApplicationException("余额不足请充值");


                try
                {
                    //开启事务
                    db.BeginTransaction();

                    //修改订单信息
                    order.Pay_Time = DateTime.Now.ToUnixTimestamp();
                    order.Seller_Id = product.Seller_Id;
                    // order.Pay_Statu = 1;//修改为已付款状态
                    orderDao.Update(order);

                    //修改网店状态
                    product.Sales = 1; //1为已售完
                    product.Status = -1;//-1为已停售
                    productDao.Update(product);

                    //更新用户余额
                    userDao.Update(user);

                    //提交事务
                    db.Commit();

                }
                catch (ApplicationException ex)
                {
                    db.Rollback();
                    throw ex;
                }
                catch (Exception ex)
                {
                    db.Rollback();
                    log4net.LogManager.GetLogger("Error").Error("付款逻辑发生异常", ex);
                    throw ex;
                }
            }
        }

        public Paged<Wuyiju.Model.ProductBought> GetBoughtPaged(PagedQuery<Wuyiju.Model.Order.Query> query)
        {
            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                return _dao.GetBoughtPaged(query);
            }
        }

        public IList<Wuyiju.View.LineChartJS> GetCount(Wuyiju.View.LineChartJS.Query query)
        {
            int subday = query.EndDate.Subtract(query.StartDate).Days;
            if (subday > 1000 || subday < 1)
                throw new ApplicationException("统计间隔不能超过1000天或少于1天");

            query.StartDate = new DateTime(query.StartDate.Year, query.StartDate.Month, query.StartDate.Day, 0, 0, 0);

            query.EndDate = new DateTime(query.EndDate.Year, query.EndDate.Month, query.EndDate.Day, 23, 59, 59);
            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);

                var lst = _dao.GetCount(query);



                var results = new List<Wuyiju.View.LineChartJS>();

                for (int i = 0; i < subday; i++)
                {
                    var tmp = query.StartDate.AddDays(i).Date;
                    if (lst != null)
                    {
                        var items = lst.Where(d => d.Add_Time.HasValue && d.Add_Time.Value.Date.Equals(tmp)).ToList();
                        if (items != null && items.Count > 0)
                        {
                            results.Add(items[0]);
                            continue;
                        }
                    }

                    var item = new Wuyiju.View.LineChartJS { Count = 0, Add_Time = tmp };
                    results.Add(item);
                }

                return results;
            }

        }

        public IList<Wuyiju.View.LineChartJS> GetCountOfLastDays(int days)
        {
            var now = DateTime.Now;
            return GetCount(new View.LineChartJS.Query { StartDate = now.AddDays(-days).Date, EndDate = now.Date });
        }
    }
}