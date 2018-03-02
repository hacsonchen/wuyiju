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
    //ec_buy
    public class BuyService : BaseService<IBuyDAL>, IBuyService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.Buy obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            if (obj.Title.IsNullOrWhiteSpace())
                throw new ApplicationException("标题不能为空！");

            if (obj.Brief.IsNullOrWhiteSpace())
                throw new ApplicationException("求购描述不能为空！");

            if (obj.Stocks.IsNull() || obj.Stocks == 0)
                throw new ApplicationException("求购数量不能为空！");

            if (obj.Cate_Id == 0)
                throw new ApplicationException("请选择网店类型！");

            if (obj.User_Name.IsNullOrWhiteSpace())
                throw new ApplicationException("请填写您的姓名！");

            if (obj.Mobile.IsNullOrWhiteSpace())
                throw new ApplicationException("请填写您的手机！");

            obj.Sn = string.Format("{0:yyMMddmmss}{1}", DateTime.Now, dao.GetMaxId() + 1);

            dao.Insert(obj);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.Buy obj)
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
        public void Remove(Wuyiju.Model.Buy obj)
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
        public Buy GetBuy(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(id);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.Buy> GetList(Wuyiju.Model.Buy.Query query)
        {
            return dao.GetList(query);
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Buy> GetList(Wuyiju.Model.Buy.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.Buy> GetPaged(PagedQuery<Wuyiju.Model.Buy.Query> query)
        {
            return dao.GetPaged(query);
        }


        #endregion

    }
}