using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层ProductAttr
	/// </summary>
	public interface IProductAttrDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.ProductAttr model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.ProductAttr model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

        /// <summary>
        /// 删除根据产品Id
        /// </summary>
        void DeletebyP(int product_id);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Wuyiju.Model.ProductAttr Get(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.ProductAttr> GetList(Wuyiju.Model.ProductAttr.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.ProductAttr> GetList(Wuyiju.Model.ProductAttr.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.ProductAttr> GetPaged(PagedQuery<Wuyiju.Model.ProductAttr.Query> filter);
		#endregion  成员方法
	} 
}