using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;
namespace Wuyiju.IService {
	/// <summary>
	/// 接口层Article
	/// </summary>
	public interface IArticleService
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Add(Wuyiju.Model.Article obj);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Modify(Wuyiju.Model.Article obj);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Remove(Wuyiju.Model.Article obj);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Article GetArticle(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Article> GetList(Wuyiju.Model.Article.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Article> GetList(Wuyiju.Model.Article.Query filter, int? limit = null);

        /// <summary>
		/// 获得全部数据列表
		/// </summary>
		IList<Wuyiju.View._Article> GetAllList();
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        Paged<Wuyiju.Model.Article> GetPaged(PagedQuery<Wuyiju.Model.Article.Query> filter);
        #endregion  成员方法

        int TodayNewCount();

    } 
}