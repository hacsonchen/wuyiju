using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Paylog
	/// </summary>
	public interface IPaylogDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Paylog model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Paylog model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int log_id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Paylog Get(int log_id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Paylog> GetList(Wuyiju.Model.Paylog.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Paylog> GetList(Wuyiju.Model.Paylog.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Paylog> GetPaged(PagedQuery<Wuyiju.Model.Paylog.Query> filter);
		#endregion  成员方法
	} 
}