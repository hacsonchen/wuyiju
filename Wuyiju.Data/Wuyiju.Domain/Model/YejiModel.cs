using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Model
{
    public class YejiModel
    {
        /// <summary>
        /// 排名
        /// </summary>
        public int sort { get; set; }

        /// <summary>
        /// 组别
        /// </summary>
        public string zubie { get; set; }

        /// <summary>
        /// 业务员
        /// </summary>
        public string yewuyuan { get; set; }
        /// <summary>
        /// 总业绩
        /// </summary>
        public decimal totalyeji { get; set; }
        /// <summary>
        /// 销售订单数
        /// </summary>
        public int xiaoshounum { get; set; }
        /// <summary>
        /// 销售业绩
        /// </summary>
        public decimal totalxiaoshou { get; set; }
        /// <summary>
        /// 关联订单数
        /// </summary>
        public int guanliannum { get; set; }
        /// <summary>
        /// 关联业绩
        /// </summary>
        public decimal totalguanlian { get; set; }
        /// <summary>
        /// 找店数
        /// </summary>
        public int storenum { get; set; }

        /// <summary>
        /// 推荐人数
        /// </summary>
        public int tuijiannum { get; set; }


        public class Query
        {
            public int? startdate { get; set; }

            public int? enddate { get; set; }

            public int? parent_id { get; set; }

            public string sortmodel { get; set; }

            public int? status { get; set; }

            public string yejistyle { get; set; }

        }
    }
}
