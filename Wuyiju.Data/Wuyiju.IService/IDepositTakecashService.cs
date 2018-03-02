using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;
namespace Wuyiju.IService {
	/// <summary>
	/// 接口层DepositTakecash
	/// </summary>
	public interface IDepositTakecashService
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Add(Wuyiju.Model.DepositTakecash obj);
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Modify(Wuyiju.Model.DepositTakecash obj);
		
		/// <summary>
		/// 删除数据
		/// </summary>
		void Remove(Wuyiju.Model.DepositTakecash obj);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Wuyiju.Model.DepositTakecash GetDepositTakecash(int id);
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

        void Takecash(Wuyiju.Model.DepositTakecash obj, string payPwd);

    } 
}