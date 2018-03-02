using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Access
	/// </summary>
	public interface IAccessDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Access model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Access model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(Wuyiju.Model.Access model);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        IList<Wuyiju.Model.Access> Get(int id,int status);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        IList<Wuyiju.Model.Access> GetList(Wuyiju.Model.Access.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Access> GetList(Wuyiju.Model.Access.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Access> GetPaged(PagedQuery<Wuyiju.Model.Access.Query> filter);
		#endregion  成员方法
	} 
}