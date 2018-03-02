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
    //ec_category
    public class CategoryService : BaseService<ICategoryDAL>, ICategoryService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.Category obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");
            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                _dao.Insert(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.Category obj)
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
        public void Remove(Wuyiju.Model.Category obj)
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
        public Category GetCategory(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");
            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                return _dao.Get(id);
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.Category> GetList(Wuyiju.Model.Category.Query query)
        {
            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                return _dao.GetList(query);
            }
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Category> GetList(Wuyiju.Model.Category.Query query, int[] limit = null)
        {
            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                return _dao.GetList(query, limit);
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.Category> GetPaged(PagedQuery<Wuyiju.Model.Category.Query> query)
        {
            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                return _dao.GetPaged(query);
            }
        }

        #endregion

    }
}