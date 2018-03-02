using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;

namespace Wuyiju.IService
{
    public interface IUserService
    {
        void Add(User user);
        void Modify(User user);
        void Remove(User user);
        User GetUser(string username);

        User GetUser(int id);
        IList<User> GetList(User.Query query);
        IList<User> GetList(User.Query query, int? limit = null);
        Paged<User> GetPaged(PagedQuery<User.Query> query);

        User CheckUser(string username, string password);

        void ModifyInfo(User user);

        void Register(User user);
        void ChangePassword(string username, string old_pass, string new_pass);

        void SetPaymentPwd(string username, string old_pass, string new_pass,string comfirm_pass);

        bool ExistsMobile(string mobile);

        void SetPwdProtect(string username, string old_answer, string question, string answer, string con_answer);

        /// <summary>
        /// 通过手机初始化用户
        /// </summary>
        /// <param name="mobile">手机号</param>
        /// <returns>是否初始化成功</returns>
        int? InitUser(string mobile);

        /// <summary>
        /// 批量初化用户
        /// </summary>
        /// <param name="mobiles">手机号数组</param>
        /// <returns>返回成功初始化的手机号</returns>
        int[] InitUser(string[] mobiles);

        int TodayNewCount();

        IList<Wuyiju.View.LineChartJS> GetCount(Wuyiju.View.LineChartJS.Query query);

        IList<Wuyiju.View.LineChartJS> GetCountOfLastDays(int days);


        void ForgetPassword(string mobile, string new_pass);

        void ForgetPayPassword(string mobile, string new_pass);

    }
}
