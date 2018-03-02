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
namespace Wuyiju.Service
{
    //ec_access
    public class AccessService : BaseService<IAccessDAL>, IAccessService
    {

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.Access obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(obj);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.Access obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Role_Id,0);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Update(obj);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove(Wuyiju.Model.Access obj)
        {
            if (obj == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Delete(obj);

        }

        public IList<Wuyiju.Model.Access> GetAccess(int id,int status)
        {
            return dao.Get(id,status);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.Access> GetList(Wuyiju.Model.Access.Query query)
        {
            return dao.GetList(query);
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Access> GetList(Wuyiju.Model.Access.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.Access> GetPaged(PagedQuery<Wuyiju.Model.Access.Query> query)
        {
            return dao.GetPaged(query);
        }
    }
}