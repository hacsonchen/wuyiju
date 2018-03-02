using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Region
	/// </summary>
	public interface IRegionDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Region model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Region model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int region_id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Region Get(int region_id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Region> GetList(Wuyiju.Model.Region.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Region> GetList(Wuyiju.Model.Region.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Region> GetPaged(PagedQuery<Wuyiju.Model.Region.Query> filter);
		#endregion  成员方法
	} 
}