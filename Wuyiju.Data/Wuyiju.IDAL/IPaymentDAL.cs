using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Payment
	/// </summary>
	public interface IPaymentDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Payment model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Payment model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int pay_id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Payment Get(int pay_id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Payment> GetList(Wuyiju.Model.Payment.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Payment> GetList(Wuyiju.Model.Payment.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Payment> GetPaged(PagedQuery<Wuyiju.Model.Payment.Query> filter);
		#endregion  成员方法
	} 
}