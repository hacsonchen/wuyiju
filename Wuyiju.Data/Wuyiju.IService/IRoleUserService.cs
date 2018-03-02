using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;
namespace Wuyiju.IService {
	/// <summary>
	/// 接口层RoleUser
	/// </summary>
	public interface IRoleUserService
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Add(Wuyiju.Model.RoleUser obj);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Modify(Wuyiju.Model.RoleUser obj);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Remove(Wuyiju.Model.RoleUser obj);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.RoleUser GetRoleUser();
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.RoleUser> GetList(Wuyiju.Model.RoleUser.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.RoleUser> GetList(Wuyiju.Model.RoleUser.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.RoleUser> GetPaged(PagedQuery<Wuyiju.Model.RoleUser.Query> filter);
		#endregion  成员方法
	} 
}