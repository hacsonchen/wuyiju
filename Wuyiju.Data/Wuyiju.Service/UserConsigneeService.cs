﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.DAL;
using Wuyiju.IDAL;
using Wuyiju.IService;
using Wuyiju.Model;
namespace Wuyiju.Service {
	 	//ec_user_consignee
		public class UserConsigneeService: BaseService<IUserConsigneeDAL>, IUserConsigneeService
	{
		
		#region  Method
		

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Wuyiju.Model.UserConsignee obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(obj);
        }

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Modify(Wuyiju.Model.UserConsignee obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Update(obj);
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Remove(Wuyiju.Model.UserConsignee obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Delete(obj.Id);

        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UserConsignee GetUserConsignee(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(id);
        }


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public IList<Wuyiju.Model.UserConsignee> GetList(Wuyiju.Model.UserConsignee.Query query)
        {
            return dao.GetList(query);
        }

        
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.UserConsignee> GetList(Wuyiju.Model.UserConsignee.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public Paged<Wuyiju.Model.UserConsignee> GetPaged(PagedQuery<Wuyiju.Model.UserConsignee.Query> query)
        {
            return dao.GetPaged(query);
        }

#endregion
   
	}
}