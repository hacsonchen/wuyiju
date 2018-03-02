using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Model
{
    public class PropertyType
    {
        public static string MallType(int type)
        {
            switch (type)
            {

                case 1: return "旗舰店";
                case 2: return "专营店";
                case 3: return "专卖店";
                default: return "-";
            }
        }

        public static string TrademarkType(int type)
        {
            switch (type)
            {

                case 1: return "R";
                case 2: return "TM";
                default: return "-";
            }

        }

        public static string TaxQualifiactionType(int type)
        {
            switch (type)
            {

                case 1: return "一般纳税人";
                case 2: return "小规模纳税人";
                default: return "-";
            }
        }

        public static string BoolType(int type)
        {
            switch (type)
            {

                case 1: return "是";
                default: return "否";
            }
        }

        public static string FormatPrice(decimal price)
        {
            return  string.Format("{0:##.##}万", price / 10000m);
        }

        

        public static string Lang(string key)
        {
            switch (key)
            {
                case "sitename": return "聚店网";
                case "home": return "首页";
                case "hot_line": return "客服热线";
                case "secect": return "请选择";
                case "location": return "您现在的位置：";
                case "conditions_disclaimer": return "细则及免责条款";
                case "no_empty": return "电邮不能为空";
                case "no_login": return "没有登录，请先登录";
                case "error_mail": return "电邮格式不正确";
                case "success": return "操作成功";
                case "failed": return "操作失败";
                case "send_success": return "传送成功";
                case "send_failed": return "传送失败";

                //操作
                case "delete": return "删除";
                case "modify": return "修改";

                //销售状态
                case "sale0": return "销售中";
                case "sale1": return "已售完";

                //审核状态
                case "check0": return "未审核";
                case "check1": return "已审核";
                case "check2": return "审核不通过";

                //交易状态
                case "unlimit": return "不限";
                case "unpaid": return "等待付款";
                case "payed": return "已付定金";
                case "complete": return "已付全款";
                case "refund": return "已退款";
                case "closed": return "交易关闭";

                //充值状态
                case "processing": return "处理中";
                case "cz_succeed": return "成功";
                case "cz_failed": return "失败";

                //提现状态
                case "uartype_0": return "其它";
                case "uartype_1": return "提现";
                case "uartype_2": return "支付";
                case "uartype_3": return "充值";
                case "uartype_4": return "冻结";

                case "order_status_1": return "未支付";
                case "order_status_2": return "成功";
                case "order_status_3": return "无效";

                //店铺月报
                case "con_date": return "统计日期";
                case "clicks": return "浏览量";
                case "visitors": return "访客数";
                case "payed_num": return "支付商品件数";
                case "buyer_num": return "支付买家数";
                case "kedanjia": return "客单价";
                case "change": return "支付转化率";
                case "total_amount": return "支付总金额";

                default: return null;
            }
        }
    }
}
