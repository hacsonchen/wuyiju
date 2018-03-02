using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Core
{
    public class UnityContext
    {
        public static IUnityContainer container;

        public UnityContext()
        {
            if (container == null)
            {
                container = new UnityContainer();
            }
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            container.LoadConfiguration(section, "data");
            container.LoadConfiguration(section, "services");

        }

        public IUnityContainer GetUnityContainer()
        {
            if (container == null)
            {
                container = new UnityContainer();
            }
            return container;
        }

        public T GetInstance<T>()
        {
            return GetUnityContainer().Resolve<T>();
        }

        public T GetInstance<T>(string ConfigName)
        {
            return GetUnityContainer().Resolve<T>(ConfigName);
        }

        public T GetInstance<T>(DataContext db)
        {
            var list = new ParameterOverrides();
            list.Add("context", db);
            return GetUnityContainer().Resolve<T>(list);
        }

        public T GetInstance<T>(string key, DataContext db)
        {
            var list = new ParameterOverrides();
            list.Add(key, db);
            return GetUnityContainer().Resolve<T>(list);
        }

        public T GetInstance<T>(Dictionary<string, object> parameters)
        {
            var list = new ParameterOverrides();
            foreach (KeyValuePair<string, object> item in parameters)
            {
                list.Add(item.Key, item.Value);
            }
            return GetUnityContainer().Resolve<T>(list);
        }
    }
}
