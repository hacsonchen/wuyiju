using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Core
{
    public class Paged<T>
    {
        public Paged() { }

        public Paged(IList<T> records, int recordsTotal, PagedQuery<T> query)
        {
            this.Records = records;
            this.RecordsTotal = recordsTotal;
            this.Draw = query.Draw;
            this.PageStart = query.PageStart;
            this.PageSize = query.PageSize;
        }

        public Paged(IList<T> records, int recordsTotal, int pageStart, int pageSize, int draw = 0)
        {
            this.Records = records;
            this.RecordsTotal = recordsTotal;
            this.Draw = draw;
            this.PageStart = pageStart;
            this.PageSize = pageSize;

        }

        public int Draw { get; set; }
        public int PageSize { get; set; }
        public int PageStart { get; set; }
        public IList<T> Records { get; private set; }

        public int RecordsTotal { get; private set; }
    }

    public class PagedQuery<T>
    {
        public PagedQuery() { }

        public int Draw { get; set; }
        public int PageSize { get; set; }
        public int PageStart { get; set; }

        public T Filter { get; set; }

        public IEnumerable<OrderRule> Order { get; set; }
    }
}
