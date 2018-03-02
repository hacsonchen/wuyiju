using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;

namespace Wuyiju.Model
{
    public class ProductFavorited : Favorites
    {
        public string Pname { get; set; }
        public string Sn { get; set; }
        public DateTime? AddTime
        {
            get
            {
                return Add_Time.ToDateTime2();
            }
        }
        public decimal Price { get; set; }
        public int Sales { get; set; }
        public int PType { get; set; }
        public long Start_Time { get; set; }

        public DateTime? StartTime
        {
            get
            {
                return Start_Time.ToDateTime2();
            }
        }

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

        public string Seller_Credit { get; set; }
    }
}
