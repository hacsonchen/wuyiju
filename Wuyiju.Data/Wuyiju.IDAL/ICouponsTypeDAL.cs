using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层CouponsType
	/// </summary>
	public interface ICouponsTypeDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.CouponsType model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.CouponsType model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int type_id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.CouponsType Get(int type_id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.CouponsType> GetList(Wuyiju.Model.CouponsType.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.CouponsType> GetList(Wuyiju.Model.CouponsType.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.CouponsType> GetPaged(PagedQuery<Wuyiju.Model.CouponsType.Query> filter);
		#endregion  成员方法
	} 
}