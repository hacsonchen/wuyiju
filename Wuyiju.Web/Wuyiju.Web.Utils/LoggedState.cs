using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web.Utils
{
    public class LoggedState
    {
        private const string KEY = "__WYJ_BR__";
        private const string KEY_SESSION = "__WYJ_BR_SESN__";

        public LoggedState(HttpContext ctx)
        {
            this.Context = ctx;
            var cookie = Context.Request.Cookies[KEY];

            if (cookie == null)
                return;

            this.UserId = cookie.Values["ID"].UrlDecode();
            this.DisplayName = cookie.Values["Name"].UrlDecode();
            this.IsRemeberUserName = cookie.Values["IsRemeberUserName"].TryParseToBoolean(false);
            this.Expires = cookie.Expires;
        }

        public HttpContext Context { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsLogged { get { return !UserId.IsNullOrEmpty(); } }

        /// <summary>
        /// 用户id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string DisplayName { get; set; }


        public bool IsRemeberUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public User Entry
        {
            get
            {
                if (!this.IsLogged) return null;

                if ((Context.Session[KEY_SESSION] as User) == null)
                {
                    var unity = new UnityContext();
                    var svr = unity.GetInstance<IUserService>();
                    Context.Session[KEY_SESSION] = svr.GetUser(this.DisplayName);
                }

                return (User)Context.Session[KEY_SESSION];
            }
            set { Context.Session[KEY_SESSION] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        internal DateTime Expires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="days"></param>
        public void Save(int days = 0)
        {
            var cookie = new HttpCookie(KEY);

            cookie.Values.Add("ID", UserId.TryParseToString());
            cookie.Values.Add("Name", DisplayName.UrlEncode());
            cookie.Values.Add("IsRemeberUserName", IsRemeberUserName.TryParseToString());

            cookie.HttpOnly = true;


            cookie.Expires = DateTime.Now.AddMinutes(10);

            if (this.Expires > DateTime.Now)
                cookie.Expires = this.Expires;


            Context.Response.AppendCookie(cookie);
        }

        public void Refresh()
        {
            if (this.IsLogged)
            {
                var unity = new UnityContext();
                var svr = unity.GetInstance<IUserService>();
                Context.Session[KEY_SESSION] = svr.GetUser(this.DisplayName);
            }
        }

        public void Clear()
        {
            var cookie = new HttpCookie(KEY)
            {
                Expires = DateTime.Now.AddDays(-1),
            };

            this.Context.Response.AppendCookie(cookie);
            this.ClearPrivate();
        }

        private void ClearPrivate()
        {
            this.UserId = string.Empty;
            this.DisplayName = string.Empty;
            this.IsRemeberUserName = false;
            this.Expires = DateTime.Now.AddDays(-1);

            if (this.Context.Session != null)
            {
                this.Context.Session.Clear();
                this.Context.Session.Abandon();
            }
        }
    }
}
