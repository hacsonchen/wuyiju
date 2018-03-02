using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.Model;

namespace Wuyiju.Web.Utils
{
    public class BasePage : System.Web.UI.Page
    {
        private Logger log = Logger.GetLogger();
        private LoggedState loggedState;
        private ApplicationAuthorizationInfo authorizationInfo;
        protected UnityContext unity;

        public BasePage()
        {
            if (unity == null)
            {
                unity = new UnityContext();
            }

        }
        
        protected PropertyInfo[] GetPropertyInfoArray(Type type)
        {
            PropertyInfo[] props = null;
            try
            {
                object obj = Activator.CreateInstance(type);
                props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            }
            catch { }

            return props;
        }

        protected T ModelBind<T>(NameValueCollection valueCollection)
        {
            PropertyInfo[] propertyInfoList = GetPropertyInfoArray(typeof(T));
            object obj = Activator.CreateInstance(typeof(T), null);
            foreach (string key in valueCollection.Keys)
            {
                if (string.IsNullOrEmpty(valueCollection[key]))
                {
                    continue;
                }

                foreach (var PropertyInfo in propertyInfoList)
                {
                    if (key.ToLower() == PropertyInfo.Name.ToLower())
                    {
                        if (PropertyInfo.PropertyType == typeof(Int32))
                        {
                            PropertyInfo.SetValue(obj, Convert.ToInt32(valueCollection[key]), null);

                        }
                        else if (PropertyInfo.PropertyType == typeof(Int16))
                        {
                            PropertyInfo.SetValue(obj, Convert.ToInt16(valueCollection[key]), null);
                        }
                        else if (PropertyInfo.PropertyType == typeof(Int64))
                        {
                            PropertyInfo.SetValue(obj, Convert.ToInt64(valueCollection[key]), null);
                        }
                        else if (PropertyInfo.PropertyType == typeof(DateTime))
                        {
                            PropertyInfo.SetValue(obj, Convert.ToDateTime(valueCollection[key]), null);
                        }
                        else
                        {
                            var val = valueCollection[key];
                            PropertyInfo.SetValue(obj, val , null);
                        }
                    }
                }
            }
            return (T)obj;
        }

        protected ApplicationAuthorizationInfo AuthorizationInfo
        {
            get
            {
                if (authorizationInfo == null)
                    authorizationInfo = ApplicationAuthorize.GetAuthorizationInfo();
                return authorizationInfo;
            }
        }

        protected LoggedState LoggedState
        {
            get
            {
                if (loggedState == null)
                    loggedState = new LoggedState(this.Context);
                return loggedState;
            }
        }

        protected User LoggedUser
        {
            get { return this.LoggedState.Entry; }
        }

        protected override void OnPreInit(EventArgs e)
        {
            log.Debug("-------------------------------------");
            log.Debug("请求页面：{0}", this.Request.Url);

            base.OnPreInit(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);

            log.Debug("请求结束");
            log.Debug("-------------------------------------");
        }

        protected override void OnPreLoad(EventArgs e)
        {
            if (!this.LoggedState.IsLogged)
                Response.Redirect("/", true);

            OnAuthorityValidation(this.LoggedUser);
        }

        protected virtual void OnAuthorityValidation(User loggedUser)
        {
        }
    }

}
