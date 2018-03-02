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
    //ec_deposit_recharge
    public class DepositRechargeService : BaseService<IDepositRechargeDAL>, IDepositRechargeService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.DepositRecharge obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                _dao.Insert(obj);
            }
        }


        public void Recharge(Wuyiju.Model.DepositRecharge obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            if (obj.Huimoney <= 0)
                throw new ApplicationException("充值金额有误");


            if (obj.Pay_Type == RechargeType.BankHui)
            {

            }

            using (var db = new DataContext())
            {


                var userSvr = unity.GetInstance<IUserDAL>(db);
                var rechargeSvr = unity.GetInstance<IDepositRechargeDAL>(db);

                var user = userSvr.Get(obj.User_Id);

                var now = DateTime.Now;
                obj.Sn = string.Format("{0:yyMMdd}{1:d10}", now, rechargeSvr.GetMaxId() + 1);
                obj.Add_Time = now.ToUnixTimestamp();
                obj.Total_Fee = obj.Huimoney;
                obj.Status = 0;

                db.BeginTransaction();
                try
                {
                    rechargeSvr.Insert(obj);
                    user.Frozen_Money += obj.Huimoney;
                    userSvr.Update(user);
                    db.Commit();
                }
                catch (Exception ex)
                {
                    db.Rollback();
                    throw new ApplicationException("充值出现异常：" + ex.Message);

                }
            }


        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.DepositRecharge obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                _dao.Update(obj);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Remove(Wuyiju.Model.DepositRecharge obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            using (var db = new DataContext())
            {
                var _dao = this.GetDao(db);
                var old = dao.Get(obj.Id);

                if (old == null)
                    throw new ApplicationException("非法操作记录不存在");

                dao.Delete(obj.Id);
            }

        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DepositRecharge GetDepositRecharge(int id)
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
        public IList<Wuyiju.Model.DepositRecharge> GetList(Wuyiju.Model.DepositRecharge.Query query)
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
        public IList<Wuyiju.Model.DepositRecharge> GetList(Wuyiju.Model.DepositRecharge.Query query, int? limit = null)
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
        public Paged<Wuyiju.Model.DepositRecharge> GetPaged(PagedQuery<Wuyiju.Model.DepositRecharge.Query> query)
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