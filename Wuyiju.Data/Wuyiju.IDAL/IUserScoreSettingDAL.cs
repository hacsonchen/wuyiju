using System;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.IDAL {
	/// <summary>
	/// 接口层UserScoreSetting
	/// </summary>
	public interface IUserScoreSettingDAL
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Insert(Wuyiju.Model.UserScoreSetting model);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(Wuyiju.Model.UserScoreSetting model);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Delete(int id);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.UserScoreSetting Get(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.UserScoreSetting> GetList(Wuyiju.Model.UserScoreSetting.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.UserScoreSetting> GetList(Wuyiju.Model.UserScoreSetting.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.UserScoreSetting> GetPaged(PagedQuery<Wuyiju.Model.UserScoreSetting.Query> filter);
		#endregion  成员方法
	} 
}