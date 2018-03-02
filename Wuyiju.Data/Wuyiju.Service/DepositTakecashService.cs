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
    //ec_deposit_takecash
    public class DepositTakecashService : BaseService<IDepositTakecashDAL>, IDepositTakecashService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.DepositTakecash obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(obj);
        }

        
        /// <summary>
        /// 提现逻辑
        /// </summary>
        /// <param name="obj"></param>
        public void Takecash(Wuyiju.Model.DepositTakecash obj, string payPwd)
        {
            using (var db = new DataContext())
            {
                var cashSvr = unity.GetInstance<IDepositTakecashDAL>(db);
                var bankSvr = unity.GetInstance<IDepositBankCardDAL>(db);
                var userSvr = unity.GetInstance<IUserDAL>(db);

                var user = userSvr.Get(obj.User_Id);

                if (user == null)
                    throw new ApplicationException("用户不存在");

                if (obj.Money <= 0)
                    throw new ApplicationException("提现的金额有误");

                if (user.Money < 0.01m && (user.Money - obj.Money) < 0)
                    throw new ApplicationException("没有足够的余额");

                if (obj.Bank_Card_Id < 1)
                    throw new ApplicationException("没有选择银行卡");


                var card = bankSvr.Get(obj.Bank_Card_Id);

                if (card == null || (card != null && card.User_Id != obj.User_Id))
                    throw new ApplicationException("错误的银行卡");

                if (payPwd.IsNullOrWhiteSpace())
                    throw new ApplicationException("未设置支付密码");

                if (!payPwd.ToMD5().Equals(user.Pay_Password))
                    throw new ApplicationException("支付密码错误");

                var now = DateTime.Now;
                obj.Sn = string.Format("{0:yyMMdd}{1:d10}", now, cashSvr.GetMaxId() + 1);

                obj.Add_Time = now.ToUnixTimestamp();

                obj.Status = 0;

                try
                {
                    db.BeginTransaction();
                    cashSvr.Insert(obj);
                    user.Money = user.Money - obj.Money;
                    user.Frozen_Money += obj.Money;
                    userSvr.Update(user);
                    db.Commit();

                }
                catch (Exception ex)
                {
                    db.Rollback();
                    Logger.GetLogger().Error("提现逻辑出现异常\n", ex);
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.DepositTakecash obj)
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
        public void Remove(Wuyiju.Model.DepositTakecash obj)
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
        public DepositTakecash GetDepositTakecash(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(id);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.DepositTakecash> GetList(Wuyiju.Model.DepositTakecash.Query query)
        {
            return dao.GetList(query);
        }

        /// <summary>
		/// 获得提现列表
		/// </summary>
		public IList<Wuyiju.Model.DepositTakecash> GetXList()
        {
            return dao.GetXList();
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.DepositTakecash> GetList(Wuyiju.Model.DepositTakecash.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.DepositTakecashWithBank> GetPaged(PagedQuery<Wuyiju.Model.DepositTakecash.Query> query)
        {
            return dao.GetPaged(query);
        }

        #endregion

    }
}