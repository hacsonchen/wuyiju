using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;
namespace Wuyiju.IService {
	/// <summary>
	/// 接口层ProductAttr
	/// </summary>
	public interface IProductAttrService
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Add(Wuyiju.Model.ProductAttr obj);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Modify(Wuyiju.Model.ProductAttr obj);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Remove(Wuyiju.Model.ProductAttr obj);

        /// <summary>
        /// 删除根据产品Id
        /// </summary>
        void DeletebyP(Wuyiju.Model.Product obj);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Wuyiju.Model.ProductAttr GetProductAttr(int id);
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