using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Model
{
    public class DepositTakecashWithBank : DepositTakecash
    {
        public string Bank_Name { get; set; }

        public string Card_Number { get; set; }

        public string CardNum
        {
            get
            {
                return Card_Number.Substring(Card_Number.Length - 5 ,4);
            }
        }
    }
}
