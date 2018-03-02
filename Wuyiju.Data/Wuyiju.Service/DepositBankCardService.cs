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
    //ec_deposit_bank_card
    public class DepositBankCardService : BaseService<IDepositBankCardDAL>, IDepositBankCardService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.DepositBankCard obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            if (obj.Bank_Name.IsNullOrWhiteSpace() ||
                obj.Region_Lv2.IsNull() ||
                obj.Region_Lv3.IsNull() ||
                obj.Bank_Name.IsNullOrWhiteSpace() ||
                obj.Bank_Subname.IsNullOrWhiteSpace() ||
                obj.Card_Number.IsNullOrWhiteSpace())
            {
                throw new ApplicationException("必填内容不能为空");
            }

            var lst = dao.GetList(new DepositBankCard.Query { User_Id = obj.User_Id });

            

            if (lst != null && lst.Count > 5)
                throw new ApplicationException("绑定银行卡数不能超过5张");

            if (lst != null)
            {
               var exists = lst.Where(d => d.Card_Number == obj.Card_Number).ToList().Count;

                if (exists > 0)
                    throw new ApplicationException("已经存在此银行卡号");
            }


            dao.Insert(obj);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.DepositBankCard obj)
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
        public void Remove(Wuyiju.Model.DepositBankCard obj)
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
        public DepositBankCard GetDepositBankCard(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(id);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.DepositBankCard> GetList(Wuyiju.Model.DepositBankCard.Query query)
        {
            return dao.GetList(query);
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.DepositBankCard> GetList(Wuyiju.Model.DepositBankCard.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.DepositBankCard> GetPaged(PagedQuery<Wuyiju.Model.DepositBankCard.Query> query)
        {
            return dao.GetPaged(query);
        }

        #endregion

    }
}