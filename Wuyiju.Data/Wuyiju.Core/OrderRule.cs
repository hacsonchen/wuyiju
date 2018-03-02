using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Core
{

	public class OrderRule
	{
		public string Column { get; set; }
		public string dir { get; set; }
		public bool IfNullsFirst { get; set; }
	}

}
