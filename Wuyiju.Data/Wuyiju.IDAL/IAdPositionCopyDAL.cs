﻿using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层AdPositionCopy
	/// </summary>
	public interface IAdPositionCopyDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.AdPositionCopy model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.AdPositionCopy model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.AdPositionCopy Get(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.AdPositionCopy> GetList(Wuyiju.Model.AdPositionCopy.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.AdPositionCopy> GetList(Wuyiju.Model.AdPositionCopy.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.AdPositionCopy> GetPaged(PagedQuery<Wuyiju.Model.AdPositionCopy.Query> filter);
		#endregion  成员方法
	} 
}