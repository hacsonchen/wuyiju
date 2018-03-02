using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;
namespace Wuyiju.IService {
	/// <summary>
	/// 接口层UserConsignee
	/// </summary>
	public interface IUserConsigneeService
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Add(Wuyiju.Model.UserConsignee obj);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Modify(Wuyiju.Model.UserConsignee obj);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Remove(Wuyiju.Model.UserConsignee obj);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.UserConsignee GetUserConsignee(int id);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		IList<Wuyiju.Model.UserConsignee> GetList(Wuyiju.Model.UserConsignee.Query filter);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		IList<Wuyiju.Model.UserConsignee> GetList(Wuyiju.Model.UserConsignee.Query filter, int? limit = null);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		Paged<Wuyiju.Model.UserConsignee> GetPaged(PagedQuery<Wuyiju.Model.UserConsignee.Query> filter);
		#endregion  成员方法
	} 
}