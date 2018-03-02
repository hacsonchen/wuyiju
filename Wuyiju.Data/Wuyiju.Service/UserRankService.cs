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
    //ec_user_rank
    public class UserRankService : BaseService<IUserRankDAL>, IUserRankService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.UserRank obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(obj);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.UserRank obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Rank_Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Update(obj);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove(Wuyiju.Model.UserRank obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Rank_Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Delete(obj.Rank_Id);

        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UserRank GetUserRank(int rank_id)
        {
            if (rank_id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(rank_id);
        }

        public void UpdateUserRank(string username,decimal money) {
            try
            {
                Wuyiju.Model.UserRank.Query query = new Wuyiju.Model.UserRank.Query();
                var svr = unity.GetInstance<IUserDAL>();
                var ranklist = dao.GetList(query);
                if (ranklist != null)
                {
                    foreach (var rank in ranklist)
                    {
                        if (rank.Min_Points <= money && money < rank.Max_Points)
                        {
                            var user = svr.GetByUsername(username);
                            user.Rank_Id = rank.Rank_Id;
                            svr.Update(user);
                        }
                    }
                }
            }
            catch {
                throw new ApplicationException("更新错误");
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.UserRank> GetList(Wuyiju.Model.UserRank.Query query)
        {
            return dao.GetList(query);
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.UserRank> GetList(Wuyiju.Model.UserRank.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.UserRank> GetPaged(PagedQuery<Wuyiju.Model.UserRank.Query> query)
        {
            return dao.GetPaged(query);
        }

        #endregion

    }
}