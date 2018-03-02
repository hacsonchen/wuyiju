using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层AccessCopy
	/// </summary>
	public interface IAccessCopyDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.AccessCopy model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.AccessCopy model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(Wuyiju.Model.AccessCopy model);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.AccessCopy Get(Wuyiju.Model.AccessCopy model);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.AccessCopy> GetList(Wuyiju.Model.AccessCopy.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.AccessCopy> GetList(Wuyiju.Model.AccessCopy.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.AccessCopy> GetPaged(PagedQuery<Wuyiju.Model.AccessCopy.Query> filter);
		#endregion  成员方法
	} 
}