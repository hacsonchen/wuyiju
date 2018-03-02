using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.DAL;
using Wuyiju.IDAL;
using Wuyiju.IService;
using Wuyiju.Model;
namespace Wuyiju.Service
{
    //ec_product
    public partial class ProductService : BaseService<IProductDAL>, IProductService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Wuyiju.Model.Product obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                return this.GetDao(db).Insert(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.Product obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                var productDao = this.GetDao(db);
                var old = productDao.Get(obj.Id);

                if (old == null)
                    throw new ApplicationException("非法操作记录不存在");

                productDao.Update(obj);
            }

           
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove(Wuyiju.Model.Product obj)
        {

            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                var old = _dao.Get(obj.Id);

                if (old == null)
                    throw new ApplicationException("非法操作记录不存在");

                _dao.Delete(obj.Id);
            }

        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Product GetProduct(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                return this.GetDao(db).Get(id);
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ProductFrontend GetProductWithAttr(int id)
        {
            if (id == 0)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                var obj = this.GetDao(db).Get(id);

                ProductFrontend product;

                if (obj != null)
                {
                    product = new ProductFrontend(obj);
                    var attrDao = unity.GetInstance<IProductAttrDAL>(db);
                    product.Attrs = attrDao.GetList(new ProductAttr.Query { Product_Id = obj.Id, Type = 0 });

                    return product;
                }

                return null;

            }


            
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.Product> GetList(Wuyiju.Model.Product.Query query)
        {

            using (var db = new DataContext())
            {
                return this.GetDao(db).GetList(query);
            }
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Product> GetList(Wuyiju.Model.Product.Query query, int? limit = null)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetList(query, limit);
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.Product> GetPaged(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetPaged(query);
            }
        }

        public Paged<Wuyiju.Model.Product> GetPagedAdmin(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetPagedAdmin(query);
            }
        }

        public Paged<Wuyiju.Model.Product> GetPagedOrder(PagedQuery<Wuyiju.Model.Product.Query> query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetPagedOrder(query);
            }
        }

        #endregion

    }
}