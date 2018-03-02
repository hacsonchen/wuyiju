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
    //ec_order
    public partial class OrderService : BaseService<IOrderDAL>, IOrderService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.Order obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                this.GetDao(db).Insert(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.Order obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);

                var old = _dao.Get(obj.Id);

                if (old == null)
                    throw new ApplicationException("非法操作记录不存在");

                _dao.Update(obj);
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove(Wuyiju.Model.Order obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                var old = _dao.Get(obj.Id);

                if (old == null)
                    throw new ApplicationException("非法操作记录不存在");

                _dao.Delete(obj.Id);
            }

        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Order GetOrder(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");
            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                return dao.Get(id);
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Order GetOrder(string sn)
        {
            if (sn == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                return this.GetDao(db).Get(sn);
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.Order> GetList(Wuyiju.Model.Order.Query query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetList(query);
            }
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Order> GetList(Wuyiju.Model.Order.Query query, int? limit = null)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetList(query, limit);
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.Order> GetPaged(PagedQuery<Wuyiju.Model.Order.Query> query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetPaged(query);
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.Order> GetOrieridPage(PagedQuery<Wuyiju.Model.Order.Query> query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetOrieridPage(query);
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.YejiModel> GetYejiTongji(Wuyiju.Model.YejiModel.Query filter)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetYejiTongji(filter);
            }
        }

        #endregion

        public int TodayNewCount()
        {
            var today = DateTime.Now;
            var query = new Wuyiju.Model.Order.Query
            {
                StartDate = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0),
                EndDate = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59)
            };

            using (var db = new DataContext())
            {
                return this.GetDao(db).GetCount(query);
            }
        }

        public int GetCount(Wuyiju.Model.Order.Query query)
        {
            using (var db = new DataContext())
            {
                return this.GetDao(db).GetCount(query);
            }
        }

    }
}