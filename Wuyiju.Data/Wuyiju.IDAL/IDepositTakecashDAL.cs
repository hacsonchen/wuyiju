using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层DepositTakecash
	/// </summary>
	public interface IDepositTakecashDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.DepositTakecash model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.DepositTakecash model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.DepositTakecash Get(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.DepositTakecash> GetList(Wuyiju.Model.DepositTakecash.Query filter);


        /// <summary>
		/// 获得提现列表
		/// </summary>
		IList<Wuyiju.Model.DepositTakecash> GetXList();

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        IList<Wuyiju.Model.DepositTakecash> GetList(Wuyiju.Model.DepositTakecash.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.DepositTakecashWithBank> GetPaged(PagedQuery<Wuyiju.Model.DepositTakecash.Query> filter);
        #endregion  成员方法

        int GetMaxId();

    } 
}