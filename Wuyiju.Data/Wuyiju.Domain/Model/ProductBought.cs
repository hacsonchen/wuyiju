using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;

namespace Wuyiju.Model
{
    public class ProductBought : Order
    {
        public string Pname { get; set; }
        public decimal PPrice { get; set; }
        public int Sales { get; set; }
        public int Pay_Status { get; set; }
        public int Type { get; set; }

        public string SalesText
        {
            get
            {

                switch (Sales)
                {
                    case 0: return PropertyType.Lang("sale0");
                    case 1: return PropertyType.Lang("sale1");
                    default: return string.Empty;
                }
            }
        }

        public string StatusText
        {
            get
            {

                switch (Status)
                {
                    case 0: return PropertyType.Lang("check0");
                    case 1: return PropertyType.Lang("check1");
                    case 2: return PropertyType.Lang("check2");
                    default: return string.Empty;
                }
            }
        }

        public DateTime? RestTime
        {
            get
            {
                return this.Add_Time.ToDateTime2().AddDays(7);
            }
        }

        public string PayStatusText
        {
            get
            {

                switch (Pay_Statu)
                {
                    case 0: return PropertyType.Lang("unpaid");
                    case 1: return PropertyType.Lang("payed");
                    case 2: return PropertyType.Lang("complete");
                    case 4: return PropertyType.Lang("refund");
                    case 3: return PropertyType.Lang("closed");
                    case -1: return PropertyType.Lang("unlimit");
                    default: return string.Empty;
                }
            }
        }

    }
}
