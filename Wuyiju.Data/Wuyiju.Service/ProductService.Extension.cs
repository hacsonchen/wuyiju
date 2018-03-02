using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.IDAL;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Service
{
    public partial class ProductService
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.ProductFrontend obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {

                var productDao = unity.GetInstance<IProductDAL>(db);
                var attrDao = unity.GetInstance<IProductAttrDAL>(db);
                var userDao = unity.GetInstance<IUserConsigneeDAL>(db);

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

                obj.Sn = string.Format("{2}{0:yyMMddHHmm}{1}{3}", DateTime.Now, productDao.GetMaxId() + 1, prefix, suffix);

                try
                {
                    db.BeginTransaction();

                    //obj.Seller_Id = 1;

                    obj.Id = productDao.Insert(obj);

                    if (obj.Attrs != null)
                    {
                        foreach (var attr in obj.Attrs)
                        {
                            attr.Product_Id = obj.Id;

                            attrDao.Insert(attr);
                        }
                    }

                    if (obj.UserConsignee != null)
                    {

                        userDao.Insert(obj.UserConsignee);
                    }

                    db.Commit();

                }
                catch (Exception ex)
                {
                    db.Rollback();
                    Logger.GetLogger().Error("保存网店失败,事务回滚\n", ex);
                    throw ex;
                    throw new ApplicationException("保存网店失败");
                }

            }


        }

        public Paged<Wuyiju.Model.ProductFavorited> GetFavoritedPaged(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetFavoritedPaged(query);
            }
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.ProductFrontend> GetListWithAttr(Wuyiju.Model.Product.Query query, int? limit = null)
        {
            using (var db = new DataContext())
            {


                var records = GetDao(db).GetList(query, limit);

                var attrDao = unity.GetInstance<IProductAttrDAL>(db);

                var lst = new List<ProductFrontend>();

                foreach (var record in records)
                {

                    var product = new ProductFrontend(record);
                    var attrDict = new Dictionary<int, string>();
                    product.Attrs = attrDao.GetList(new ProductAttr.Query { Product_Id = product.Id });


                    lst.Add(product);
                }

                return lst;
            }
        }

        public Paged<ProductFrontend> GetPagedWithAttr(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            using (var db = new DataContext())
            {



                var paged = this.GetDao(db).GetPaged(query);

                var attrDao = unity.GetInstance<IProductAttrDAL>(db);

                var lst = new List<ProductFrontend>();

                foreach (var record in paged.Records)
                {

                    var product = new ProductFrontend(record);
                    var attrDict = new Dictionary<int, string>();
                    product.Attrs = attrDao.GetList(new ProductAttr.Query { Product_Id = product.Id });


                    lst.Add(product);
                }

                return new Paged<ProductFrontend>(lst, paged.RecordsTotal, paged.PageStart, paged.PageSize);
            }
        }


        public int TodayNewCount()
        {
            var today = DateTime.Now;
            var query = new Wuyiju.Model.Product.Query
            {
                StartDate = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0),
                EndDate = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59)
            };

            using (var db = new DataContext())
            {
                return this.GetDao(db).GetCount(query);
            }

        }

        public int GetCount(Wuyiju.Model.Product.Query query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetCount(query);
            }
        }

    }
}
