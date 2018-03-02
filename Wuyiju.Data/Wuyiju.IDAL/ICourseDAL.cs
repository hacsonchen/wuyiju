using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Course
	/// </summary>
	public interface ICourseDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Course model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Course model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int cid);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Course Get(int cid);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Course> GetList(Wuyiju.Model.Course.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Course> GetList(Wuyiju.Model.Course.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Course> GetPaged(PagedQuery<Wuyiju.Model.Course.Query> filter);
		#endregion  成员方法
	} 
}