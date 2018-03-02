using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.View
{
    public class LineChartJS
    {
        public int Count { get; set; }

        public DateTime? Add_Time { get; set; }

        public class Query
        {
            public DateTime StartDate { get; set; }

            public DateTime EndDate { get; set; }

        }

    }
}
