using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Message
	/// </summary>
	public interface IMessageDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Message model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Message model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Message Get(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Message> GetList(Wuyiju.Model.Message.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Message> GetList(Wuyiju.Model.Message.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Message> GetPaged(PagedQuery<Wuyiju.Model.Message.Query> filter);
		#endregion  成员方法
	} 
}