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
    //ec_sms
    public class SmsService : BaseService<ISmsDAL>, ISmsService
    {

        #region  Method


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Wuyiju.Model.Sms obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(obj);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Modify(Wuyiju.Model.Sms obj)
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
        public void Remove(Wuyiju.Model.Sms obj)
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
        public Sms GetSms(int id)
        {
            if (id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(id);
        }


        public Sms GetSms(string mobile)
        {
            if (mobile == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(mobile);
        }

        public bool CheckCode(string mobile, string code)
        {
            var sms = dao.Get(mobile);
            var valid = sms.Add_Time.ToDateTime2();
            var now  = DateTime.Now;
            var span = now.Subtract(valid);
            return (sms != null) 
                && (!sms.Validatecode.IsNullOrWhiteSpace())
                && (sms.Validatecode.Equals(code)) 
                && (span.Minutes <= 30);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Wuyiju.Model.Sms> GetList(Wuyiju.Model.Sms.Query query)
        {
            return dao.GetList(query);
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public IList<Wuyiju.Model.Sms> GetList(Wuyiju.Model.Sms.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public Paged<Wuyiju.Model.Sms> GetPaged(PagedQuery<Wuyiju.Model.Sms.Query> query)
        {
            return dao.GetPaged(query);
        }

        #endregion

    }
}