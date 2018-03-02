using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Coupons
	/// </summary>
	public interface ICouponsDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Coupons model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Coupons model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int coupon_id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Coupons Get(int coupon_id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Coupons> GetList(Wuyiju.Model.Coupons.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Coupons> GetList(Wuyiju.Model.Coupons.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Coupons> GetPaged(PagedQuery<Wuyiju.Model.Coupons.Query> filter);
		#endregion  成员方法
	} 
}