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
    //ec_ad
    public class AdService : BaseService<IAdDAL>, IAdService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.Ad obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(obj);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.Ad obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Update(obj);
        }

        public void Save(Wuyiju.Model.Ad obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Id);

            var adPosDao = unity.GetInstance<IAdPositionDAL>();

            if ("image".Equals(obj.Type))
            {
                obj.Code = obj.Thumb ?? "";
            }

            if (obj.Position_Id > 0)
            {
                var pos = adPosDao.Get(obj.Position_Id);
                if (pos != null)
                    obj.Ad_Type = pos.Type;
            }

            if (obj.StartTime != null)
                obj.Start_Time = obj.StartTime.Value.ToUnixTimestamp();

            if (obj.EndTime != null)
                obj.End_Time = obj.EndTime.Value.ToUnixTimestamp();

            if (old == null)
            {
                obj.Add_Time = DateTime.Now.ToUnixTimestamp();
                
                 
                dao.Insert(obj);
            }
            else
            {
                dao.Update(obj);
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove(Wuyiju.Model.Ad obj)
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
        public Ad GetAd(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(id);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.Ad> GetList(Wuyiju.Model.Ad.Query query)
        {
            return dao.GetList(query);
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Ad> GetList(Wuyiju.Model.Ad.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.Ad> GetPaged(PagedQuery<Wuyiju.Model.Ad.Query> query)
        {
            return dao.GetPaged(query);
        }

        #endregion

    }
}