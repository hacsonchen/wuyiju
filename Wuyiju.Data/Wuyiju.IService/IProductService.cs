using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;
namespace Wuyiju.IService
{
    /// <summary>
    /// 接口层Product
    /// </summary>
    public interface IProductService
    {
        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(Wuyiju.Model.Product obj);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        void Modify(Wuyiju.Model.Product obj);

        /// <summary>
        /// 删除数据
        /// </summary>
        void Remove(Wuyiju.Model.Product obj);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Wuyiju.Model.Product GetProduct(int id);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        IList<Wuyiju.Model.Product> GetList(Wuyiju.Model.Product.Query filter);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        IList<Wuyiju.Model.Product> GetList(Wuyiju.Model.Product.Query filter, int? limit = null);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        Paged<Wuyiju.Model.Product> GetPaged(PagedQuery<Wuyiju.Model.Product.Query> filter);


        Paged<Wuyiju.Model.Product> GetPagedAdmin(PagedQuery<Wuyiju.Model.Product.Query> filter);

        Paged<Wuyiju.Model.Product> GetPagedOrder(PagedQuery<Wuyiju.Model.Product.Query> filter);
        #endregion  成员方法

        void Add(Wuyiju.Model.ProductFrontend obj);

        Paged<ProductFrontend> GetPagedWithAttr(PagedQuery<Wuyiju.Model.Product.Query> query);

        ProductFrontend GetProductWithAttr(int id);

        Paged<Wuyiju.Model.ProductFavorited> GetFavoritedPaged(PagedQuery<Wuyiju.Model.Product.Query> query);

        IList<Wuyiju.Model.ProductFrontend> GetListWithAttr(Wuyiju.Model.Product.Query query, int? limit = null);

        int TodayNewCount();

        int GetCount(Wuyiju.Model.Product.Query query);
    }
}