using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层UserAccountRecords
	/// </summary>
	public interface IUserAccountRecordsDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.UserAccountRecords model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.UserAccountRecords model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.UserAccountRecords Get(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.UserAccountRecords> GetList(Wuyiju.Model.UserAccountRecords.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.UserAccountRecords> GetList(Wuyiju.Model.UserAccountRecords.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.UserAccountRecords> GetPaged(PagedQuery<Wuyiju.Model.UserAccountRecords.Query> filter);
		#endregion  成员方法
	} 
}