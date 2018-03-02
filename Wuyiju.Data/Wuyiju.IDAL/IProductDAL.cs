using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL
{
    /// <summary>
    /// 接口层Product
    /// </summary>
    public interface IProductDAL
    {
        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Insert(Wuyiju.Model.Product model);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        void Update(Wuyiju.Model.Product model);

        /// <summary>
        /// 删除数据
        /// </summary>
        void Delete(int id);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Wuyiju.Model.Product Get(int id);
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

        /// <summary>
        /// 取最大ID
        /// </summary>
        /// <returns></returns>
        int GetMaxId();

        Paged<Wuyiju.Model.ProductFavorited> GetFavoritedPaged(PagedQuery<Wuyiju.Model.Product.Query> query);

        int GetCount(Wuyiju.Model.Product.Query query);

    }
}