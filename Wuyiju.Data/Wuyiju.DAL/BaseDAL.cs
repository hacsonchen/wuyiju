using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;

namespace Wuyiju.DAL
{
    public class BaseDAL
    {
        protected DataContext db;

        public BaseDAL(DataContext ctx)
        {
            this.db = ctx;
        }
    }
}
