using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;
namespace Wuyiju.IService {
	/// <summary>
	/// 接口层UserRank
	/// </summary>
	public interface IUserRankService
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Add(Wuyiju.Model.UserRank obj);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Modify(Wuyiju.Model.UserRank obj);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Remove(Wuyiju.Model.UserRank obj);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.UserRank GetUserRank(int rank_id);

        /// <summary>
		/// 更新会员等级
		/// </summary>
		void UpdateUserRank(string username,decimal money);

        /// <summary>
        /// 获得数据列表
        /// </summary>
        IList<Wuyiju.Model.UserRank> GetList(Wuyiju.Model.UserRank.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.UserRank> GetList(Wuyiju.Model.UserRank.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.UserRank> GetPaged(PagedQuery<Wuyiju.Model.UserRank.Query> filter);
		#endregion  成员方法
	} 
}