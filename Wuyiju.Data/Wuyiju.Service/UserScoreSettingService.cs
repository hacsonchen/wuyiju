using System;
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
	 	//ec_user_score_setting
		public class UserScoreSettingService: BaseService<IUserScoreSettingDAL>, IUserScoreSettingService
	{
		
		#region  Method
		

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Wuyiju.Model.UserScoreSetting obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(obj);
        }

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Modify(Wuyiju.Model.UserScoreSetting obj)
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
		public void Remove(Wuyiju.Model.UserScoreSetting obj)
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
		public UserScoreSetting GetUserScoreSetting(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(id);
        }


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public IList<Wuyiju.Model.UserScoreSetting> GetList(Wuyiju.Model.UserScoreSetting.Query query)
        {
            return dao.GetList(query);
        }

        
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.UserScoreSetting> GetList(Wuyiju.Model.UserScoreSetting.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public Paged<Wuyiju.Model.UserScoreSetting> GetPaged(PagedQuery<Wuyiju.Model.UserScoreSetting.Query> query)
        {
            return dao.GetPaged(query);
        }

#endregion
   
	}
}