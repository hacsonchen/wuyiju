using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Domain.Model
{
    public class ApplicationConfig
    {
        public static decimal SysFee { get; set; }

        public static decimal Deposit
        {
            get { return SysFee * 2m; }
        }

        public static string SysFeeLabel
        {
            get
            {
                return string.Format("{0}%", SysFee * 100);
            }

        }

        public static string DepositLabel
        {
            get
            {
                return string.Format("{0}%", Deposit * 100);
            }

        }
    }
}
