using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Favorites
	/// </summary>
	public interface IFavoritesDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Favorites model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Favorites model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int rec_id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Favorites Get(int rec_id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Favorites> GetList(Wuyiju.Model.Favorites.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Favorites> GetList(Wuyiju.Model.Favorites.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Favorites> GetPaged(PagedQuery<Wuyiju.Model.Favorites.Query> filter);
		#endregion  成员方法
	} 
}