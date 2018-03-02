using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL
{
    /// <summary>
    /// 接口层User
    /// </summary>
    public interface IUserDAL
    {
        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        void Insert(Wuyiju.Model.User model);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        void Update(Wuyiju.Model.User model);

        /// <summary>
        /// 删除数据
        /// </summary>
        void Delete(int id);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Wuyiju.Model.User Get(int id);

        Wuyiju.Model.User GetByUsername(string username);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        IList<Wuyiju.Model.User> GetList(Wuyiju.Model.User.Query filter);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        IList<Wuyiju.Model.User> GetList(Wuyiju.Model.User.Query filter, int? limit = null);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        Paged<Wuyiju.Model.User> GetPaged(PagedQuery<Wuyiju.Model.User.Query> filter);
        #endregion  成员方法

        int GetCount(Wuyiju.Model.User.Query query);

        Model.User GetByMobile(string mobile);

        IList<Wuyiju.View.LineChartJS> GetCount(Wuyiju.View.LineChartJS.Query query);
    }
}