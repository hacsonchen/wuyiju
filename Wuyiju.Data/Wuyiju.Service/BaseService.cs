using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;

namespace Wuyiju.Service
{
    public class BaseService<T>
    {
        protected UnityContext unity;

        protected T dao;

        protected DataContext context;

        public BaseService()
        {
            if (unity == null)
            {
                unity = new UnityContext();
                
            }

            if (dao == null)
            {
                using (context = new DataContext())
                {
                    dao = unity.GetInstance<T>(context);
                }
            }
        }

        public T GetDao(DataContext db)
        {
            return unity.GetInstance<T>(db);
        }
    }
}
