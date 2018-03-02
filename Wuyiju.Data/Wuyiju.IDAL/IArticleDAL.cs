using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Article
	/// </summary>
	public interface IArticleDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Article model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Article model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Article Get(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Article> GetList(Wuyiju.Model.Article.Query filter);

        /// <summary>
		/// 获得所有数据列表
		/// </summary>
		IList<Wuyiju.View._Article> GetAllList();
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        IList<Wuyiju.Model.Article> GetList(Wuyiju.Model.Article.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Article> GetPaged(PagedQuery<Wuyiju.Model.Article.Query> filter);
        #endregion  成员方法

        int GetCount(Wuyiju.Model.Article.Query query);

    } 
}