using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using Wuyiju.Core;

namespace Wuyiju.Web
{
    public class UnityHandlerFactory : IHttpHandlerFactory
    {
        private static readonly IUnityContainer unityContainer;

        static UnityHandlerFactory()
        {
            //初始化UnityContainer
            var unityContext = new UnityContext();
            unityContainer = unityContext.GetUnityContainer();
        }

        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            IHttpHandlerFactory pageFactory = CreatePageFactory();
            IHttpHandler handler = pageFactory.GetHandler(context, requestType, url, pathTranslated);
            handler = Build(handler);
            Page page = handler as Page;
            if (page != null)
            {
                page.Init += new EventHandler(Page_Init);
            }
            return page;
        }

        void Page_Init(object sender, EventArgs e)
        {
            //这里来验证访问用户的合法性
            //Session
            //需要排除登录页面
            var s = sender;
        }
        public void ReleaseHandler(IHttpHandler handler)
        {
            IHttpHandlerFactory pageFactory = CreatePageFactory();
            pageFactory.ReleaseHandler(handler);
        }

        private static IHttpHandlerFactory CreatePageFactory()
        {
            IHttpHandlerFactory pageFactory =
                Activator.CreateInstance(typeof(PageHandlerFactory), true) as IHttpHandlerFactory;
            if (pageFactory == null)
            {
                throw new ApplicationException(
                    "无法初始化PageHandlerFactory");
            }
            return pageFactory;
        }

        private static IHttpHandler Build(IHttpHandler page)
        {
            try
            {
                return unityContainer.BuildUp(page.GetType().BaseType, page) as IHttpHandler;
            }
            catch (Exception)
            {
                return page;
            }
        }
    }

    public class MyHandlerFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            PageHandlerFactory factory = (PageHandlerFactory)Activator.CreateInstance(typeof(PageHandlerFactory), true);
            IHttpHandler handler = factory.GetHandler(context, requestType, url, pathTranslated);

            //执行一些其它操作
            Execute(handler);

            return handler;
        }

        private void Execute(IHttpHandler handler)
        {
            if (handler is Page)
            {
                //可以直接对Page对象进行操作
                ((Page)handler).PreLoad += new EventHandler(MyHandlerFactory_PreLoad);
            }
        }

        void MyHandlerFactory_PreLoad(object sender, EventArgs e)
        {
            ((Page)sender).Response.Write("Copyright @Gspring<br/>");
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
        }
    }
}