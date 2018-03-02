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
    public partial class UserService : BaseService<IUserDAL>, IUserService
    {
        public User GetUser(string username)
        {
            if (username == null)
                throw new ApplicationException("参数不能为空");

            return dao.GetByUsername(username);
        }

        public User GetUser(int id)
        {
            return dao.Get(id);
        }

        public bool ExistsMobile(string mobile)
        {
            if (mobile.IsNullOrWhiteSpace())
                throw new ApplicationException("手机号不能为空");

            var lst = dao.GetList(new User.Query { Mobile = mobile });

            return (lst != null && lst.Count > 0);
        }

        public IList<User> GetList(User.Query query)
        {
            return dao.GetList(query);
        }

        public IList<User> GetList(User.Query query, int? limit = null)
        {

            return dao.GetList(query, limit);
        }

        public Paged<User> GetPaged(PagedQuery<User.Query> query)
        {
            return dao.GetPaged(query);
        }

        public void Add(User user)
        {
            if (user == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(user);
        }

        public void Modify(User user)
        {
            if (user == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(user.Id);



            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Update(user);
        }

        public void Remove(User user)
        {
            if (user == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(user.Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Delete(user.Id);

        }

        public IList<Wuyiju.View.LineChartJS> GetCount(Wuyiju.View.LineChartJS.Query query)
        {
            int subday = query.EndDate.Subtract(query.StartDate).Days;
            if (subday > 1000 || subday < 1)
                throw new ApplicationException("统计间隔不能超过1000天或少于1天");

            query.StartDate = new DateTime(query.StartDate.Year, query.StartDate.Month, query.StartDate.Day, 0, 0, 0);

            query.EndDate = new DateTime(query.EndDate.Year, query.EndDate.Month, query.EndDate.Day, 23, 59, 59);


            var lst = dao.GetCount(query);


            var results = new List<Wuyiju.View.LineChartJS>();

            for (int i = 0; i < subday; i++)
            {
                var tmp = query.StartDate.AddDays(i).Date;
                if (lst != null)
                {
                    var items = lst.Where(d => d.Add_Time.HasValue && d.Add_Time.Value.Date.Equals(tmp)).ToList();
                    if (items != null && items.Count > 0)
                    {
                        results.Add(items[0]);
                        continue;
                    }
                }

                var item = new Wuyiju.View.LineChartJS { Count = 0, Add_Time = tmp };
                results.Add(item);
            }

            return results;

        }


        public IList<Wuyiju.View.LineChartJS> GetCountOfLastDays(int days)
        {
            var now = DateTime.Now;
            return GetCount(new View.LineChartJS.Query { StartDate = now.AddDays(-days).Date, EndDate = now.Date });
        }


    }
}
