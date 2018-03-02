using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层Sms
	/// </summary>
	public interface ISmsDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.Sms model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.Sms model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.Sms Get(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.Sms> GetList(Wuyiju.Model.Sms.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.Sms> GetList(Wuyiju.Model.Sms.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.Sms> GetPaged(PagedQuery<Wuyiju.Model.Sms.Query> filter);
        #endregion  成员方法

        Wuyiju.Model.Sms Get(string mobile);

    } 
}