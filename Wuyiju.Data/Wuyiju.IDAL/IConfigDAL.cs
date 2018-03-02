using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Config
	/// </summary>
	public interface IConfigDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Config model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Config model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Config Get(int id);

        Wuyiju.Model.Config Get(string name);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        IList<Wuyiju.Model.Config> GetList(Wuyiju.Model.Config.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Config> GetList(Wuyiju.Model.Config.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Config> GetPaged(PagedQuery<Wuyiju.Model.Config.Query> filter);
		#endregion  成员方法
	} 
}