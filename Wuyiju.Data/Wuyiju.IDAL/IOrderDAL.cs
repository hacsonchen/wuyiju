using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL
{
    /// <summary>
    /// 接口层Order
    /// </summary>
    public interface IOrderDAL
    {
        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        void Insert(Wuyiju.Model.Order model);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        void Update(Wuyiju.Model.Order model);

        /// <summary>
        /// 删除数据
        /// </summary>
        void Delete(int id);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Wuyiju.Model.Order Get(int id);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        IList<Wuyiju.Model.Order> GetList(Wuyiju.Model.Order.Query filter);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        IList<Wuyiju.Model.Order> GetList(Wuyiju.Model.Order.Query filter, int? limit = null);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        Paged<Wuyiju.Model.Order> GetPaged(PagedQuery<Wuyiju.Model.Order.Query> filter);
        #endregion  成员方法

        Paged<Wuyiju.Model.ProductBought> GetBoughtPaged(PagedQuery<Wuyiju.Model.Order.Query> query);

        Paged<Wuyiju.Model.Order> GetOrieridPage(PagedQuery<Wuyiju.Model.Order.Query> query);

        IList<Wuyiju.Model.YejiModel> GetYejiTongji(Wuyiju.Model.YejiModel.Query filter);
        int GetCount(Wuyiju.Model.Order.Query query);

        IList<Wuyiju.View.LineChartJS> GetCount(Wuyiju.View.LineChartJS.Query query);

        Wuyiju.Model.Order Get(string sn);

    }
}