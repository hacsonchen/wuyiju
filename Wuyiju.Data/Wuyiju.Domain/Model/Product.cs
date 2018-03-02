using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
using Wuyiju.Domain;
using Wuyiju.Domain.View;
using System.Web.Script.Serialization;
using Wuyiju.Domain.Model;

namespace Wuyiju.Model
{
    //ec_product
    public class Product
    {

        /// <summary>
        /// auto_increment
        /// </summary>		
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// admin_id
        /// </summary>		
        private int _admin_id;
        public int Admin_Id
        {
            get { return _admin_id; }
            set { _admin_id = value; }
        }

        /// <summary>
        /// guanlian_id
        /// </summary>		
        private int _guanlian_id;
        public int Guanlian_Id
        {
            get { return _guanlian_id; }
            set { _guanlian_id = value; }
        }
        ///

        /// <summary>
        /// name
        /// </summary>		
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// subname
        /// </summary>		
        private string _subname;
        public string Subname
        {
            get { return _subname; }
            set { _subname = value; }
        }
        /// <summary>
        /// sn
        /// </summary>		
        private string _sn;
        public string Sn
        {
            get { return _sn; }
            set { _sn = value; }
        }
        /// <summary>
        /// category_id
        /// </summary>		
        private int _category_id;
        public int Category_Id
        {
            get { return _category_id; }
            set { _category_id = value; }
        }

        /// <summary>
        /// category_name
        /// </summary>		
        private string _category_name;
        public string Category_Name
        {
            get { return _category_name; }
            set { _category_name = value; }
        }
        /// <summary>
        /// market_price
        /// </summary>		
        private decimal _market_price;
        public decimal Market_Price
        {
            get { return _market_price; }
            set { _market_price = value; }
        }
        /// <summary>
        /// price
        /// </summary>		
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        /// <summary>
        /// member_price
        /// </summary>		
        private decimal _member_price;
        public decimal Member_Price
        {
            get { return _member_price; }
            set { _member_price = value; }
        }
        /// <summary>
        /// promote_price
        /// </summary>		
        private decimal _promote_price;
        public decimal Promote_Price
        {
            get { return _promote_price; }
            set { _promote_price = value; }
        }
        /// <summary>
        /// intro
        /// </summary>		
        private string _intro;
        public string Intro
        {
            get { return _intro; }
            set { _intro = value; }
        }
        /// <summary>
        /// integration
        /// </summary>		
        private int _integration;
        public int Integration
        {
            get { return _integration; }
            set { _integration = value; }
        }
        /// <summary>
        /// integration_buy
        /// </summary>		
        private int _integration_buy;
        public int Integration_Buy
        {
            get { return _integration_buy; }
            set { _integration_buy = value; }
        }
        /// <summary>
        /// promote
        /// </summary>		
        private int _promote;
        public int Promote
        {
            get { return _promote; }
            set { _promote = value; }
        }
        /// <summary>
        /// promote_start
        /// </summary>		
        private int _promote_start;
        public int Promote_Start
        {
            get { return _promote_start; }
            set { _promote_start = value; }
        }

        /// <summary>
        /// promote_end
        /// </summary>		
        private int _promote_end;
        public int Promote_End
        {
            get { return _promote_end; }
            set { _promote_end = value; }
        }
        /// <summary>
        /// recommend
        /// </summary>		
        private int _recommend;
        public int Recommend
        {
            get { return _recommend; }
            set { _recommend = value; }
        }
        /// <summary>
        /// click
        /// </summary>		
        private int _click;
        public int Click
        {
            get { return _click; }
            set { _click = value; }
        }
        /// <summary>
        /// stock
        /// </summary>		
        private int _stock;
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        /// <summary>
        /// pay_status
        /// </summary>		
        private int _pay_status;
        public int Pay_Status
        {
            get { return _pay_status; }
            set { _pay_status = value; }
        }
        /// <summary>
        /// warn_nums
        /// </summary>		
        private int _warn_nums;
        public int Warn_Nums
        {
            get { return _warn_nums; }
            set { _warn_nums = value; }
        }
        /// <summary>
        /// sales
        /// </summary>		
        private int _sales;
        public int Sales
        {
            get { return _sales; }
            set { _sales = value; }
        }

        public string Categories
        {
            get;
            set;
        }

        public string Trademark
        {
            get;
            set;
        }

        public string SalesText
        {
            get
            {

                switch (_sales)
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

                switch (_status)
                {
                    case 0: return PropertyType.Lang("check0");
                    case 1: return PropertyType.Lang("check1");
                    case 2: return PropertyType.Lang("check2");
                    default: return string.Empty;
                }
            }
        }

        public string PayStatusText
        {
            get
            {

                switch (_pay_status)
                {
                    case 0: return PropertyType.Lang("unpaid");
                    case 1: return PropertyType.Lang("payed");
                    case 2: return PropertyType.Lang("receiving");
                    case 3: return PropertyType.Lang("complete");
                    case 4: return PropertyType.Lang("refund");
                    case 5: return PropertyType.Lang("closed");
                    case 9: return PropertyType.Lang("unlimit");
                    default: return string.Empty;
                }
            }
        }

        public string CompanyLevel
        {
            get
            {

                switch (_company_level)
                {
                    case "0": return "一般纳税";
                    case "1": return "小规模纳税";
                    default: return string.Empty;
                }
            }
        }


        /// <summary>
        /// status
        /// </summary>		
        private int _status;
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        /// <summary>
        /// hot
        /// </summary>		
        private int _hot;
        public int Hot
        {
            get { return _hot; }
            set { _hot = value; }
        }
        /// <summary>
        /// new
        /// </summary>		
        private int _new;
        public int New
        {
            get { return _new; }
            set { _new = value; }
        }
        /// <summary>
        /// best
        /// </summary>		
        private int _best;
        public int Best
        {
            get { return _best; }
            set { _best = value; }
        }
        /// <summary>
        /// sort
        /// </summary>		
        private int _sort;
        public int Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
        /// <summary>
        /// keywords
        /// </summary>		
        private string _keywords;
        public string Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        /// <summary>
        /// seo_title
        /// </summary>		
        private string _seo_title;
        public string Seo_Title
        {
            get { return _seo_title; }
            set { _seo_title = value; }
        }
        /// <summary>
        /// seo_keys
        /// </summary>		
        private string _seo_keys;
        public string Seo_Keys
        {
            get { return _seo_keys; }
            set { _seo_keys = value; }
        }
        /// <summary>
        /// seo_desc
        /// </summary>		
        private string _seo_desc;
        public string Seo_Desc
        {
            get { return _seo_desc; }
            set { _seo_desc = value; }
        }
        /// <summary>
        /// brief
        /// </summary>		
        private string _brief;
        public string Brief
        {
            get { return _brief; }
            set { _brief = value; }
        }
        /// <summary>
        /// content
        /// </summary>		
        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        /// <summary>
        /// url
        /// </summary>		
        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// url
        /// </summary>		
        private string _weiscore;
        public string Weiscore
        {
            get { return _weiscore; }
            set { _weiscore = value; }
        }

        /// <summary>
        /// address_id
        /// </summary>		
        private int _address_id;
        public int Address_Id
        {
            get { return _address_id; }
            set { _address_id = value; }
        }
        /// <summary>
        /// buyer_id
        /// </summary>		
        private int _buyer_id;
        public int Buyer_Id
        {
            get { return _buyer_id; }
            set { _buyer_id = value; }
        }
        /// <summary>
        /// add_time
        /// </summary>		
        private long _add_time;
        public long Add_Time
        {
            get { return _add_time; }
            set { _add_time = value; }
        }
        /// <summary>
        /// start_time
        /// </summary>		
        private long _start_time;
        public long Start_Time
        {
            get { return _start_time; }
            set { _start_time = value; }
        }
        /// <summary>
        /// picture
        /// </summary>		
        private string _picture;
        public string Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        /// <summary>
        /// picture
        /// </summary>		
        private string _smallarea;
        public string Smallarea
        {
            get { return _smallarea; }
            set { _smallarea = value; }
        }

        /// <summary>
        /// picture
        /// </summary>		
        private string _company_level;
        public string Company_Level
        {
            get { return _company_level; }
            set { _company_level = value; }
        }

        /// <summary>
        /// score
        /// </summary>		
        private string _score;
        public string Score
        {
            get { return _score; }
            set { _score = value; }
        }

        /// <summary>
        /// log
        /// </summary>		
        private string _log;
        public string Log
        {
            get { return _log; }
            set { _log = value; }
        }
        /// <summary>
        /// del_time
        /// </summary>		
        private int _del_time;
        public int Del_Time
        {
            get { return _del_time; }
            set { _del_time = value; }
        }
        /// <summary>
        /// filename
        /// </summary>		
        private string _filename;
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        /// <summary>
        /// seller_id
        /// </summary>		
        private int _seller_id;
        public int Seller_Id
        {
            get { return _seller_id; }
            set { _seller_id = value; }
        }

        /// <summary>
        /// reason
        /// </summary>		
        private string _reason;
        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }


        /// <summary>
        /// seller_name
        /// </summary>		
        private string _seller_name;
        public string Seller_Name
        {
            get { return _seller_name; }
            set { _seller_name = value; }
        }

        /// <summary>
        /// seller_phone
        /// </summary>		
        private string _seller_phone;
        public string Seller_Phone
        {
            get { return _seller_phone; }
            set { _seller_phone = value; }
        }

        /// <summary>
        /// seller_phone
        /// </summary>		
        private string _seller_qq;
        public string Seller_Qq
        {
            get { return _seller_qq; }
            set { _seller_qq = value; }
        }


        /// <summary>
        /// seller_phone
        /// </summary>		
        private int _guan_role;
        public int Guan_Role
        {
            get { return _guan_role; }
            set { _guan_role = value; }
        }

        /// <summary>
        /// zubie_name
        /// </summary>		
        private string _zubie_name;
        public string Zubie_Name
        {
            get { return _zubie_name; }
            set { _zubie_name = value; }
        }

        /// <summary>
        /// user_return
        /// </summary>		
        private decimal _user_return;
        public decimal User_Return
        {
            get { return _user_return; }
            set { _user_return = value; }
        }
        /// <summary>
        /// type
        /// </summary>		
        private int _type;
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// video
        /// </summary>		
        private string _video;
        public string Video
        {
            get { return _video; }
            set { _video = value; }
        }
        /// <summary>
        /// praise_rate
        /// </summary>		
        private decimal _praise_rate;
        public decimal Praise_Rate
        {
            get { return _praise_rate; }
            set { _praise_rate = value; }
        }
        /// <summary>
        /// collection_popularity
        /// </summary>		
        private int _collection_popularity;
        public int Collection_Popularity
        {
            get { return _collection_popularity; }
            set { _collection_popularity = value; }
        }
        /// <summary>
        /// seller_credit
        /// </summary>		
        private int _seller_credit;
        public int Seller_Credit
        {
            get { return _seller_credit; }
            set { _seller_credit = value; }
        }
        /// <summary>
        /// annual_turnover
        /// </summary>		
        private decimal _annual_turnover;
        public decimal Annual_Turnover
        {
            get { return _annual_turnover; }
            set { _annual_turnover = value; }
        }
        /// <summary>
        /// protection_deposit
        /// </summary>		
        private decimal _protection_deposit;
        public decimal Protection_Deposit
        {
            get { return _protection_deposit; }
            set { _protection_deposit = value; }
        }
        /// <summary>
        /// tech_fee
        /// </summary>		
        private decimal _tech_fee;
        public decimal Tech_Fee
        {
            get { return _tech_fee; }
            set { _tech_fee = value; }
        }
        /// <summary>
        /// whether_goods
        /// </summary>		
        private int _whether_goods;
        public int Whether_Goods
        {
            get { return _whether_goods; }
            set { _whether_goods = value; }
        }
        /// <summary>
        /// buyer_protection
        /// </summary>		
        private string _buyer_protection;
        public string Buyer_Protection
        {
            get { return _buyer_protection; }
            set { _buyer_protection = value; }
        }
        /// <summary>
        /// virtual_proportion
        /// </summary>		
        private decimal _virtual_proportion;
        public decimal Virtual_Proportion
        {
            get { return _virtual_proportion; }
            set { _virtual_proportion = value; }
        }
        /// <summary>
        /// old_customer_number
        /// </summary>		
        private int _old_customer_number;
        public int Old_Customer_Number
        {
            get { return _old_customer_number; }
            set { _old_customer_number = value; }
        }
        /// <summary>
        /// area
        /// </summary>		
        private string _area;
        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        /// <summary>
        /// mobile
        /// </summary>		
        public string Mobile
        {
            get;
            set;
        }

        public string QQ { get; set; }

        /// <summary>
        /// mall_type
        /// </summary>		
        private int _mall_type;
        public int Mall_Type
        {
            get { return _mall_type; }
            set { _mall_type = value; }
        }
        /// <summary>
        /// trademark_type
        /// </summary>		
        private int _trademark_type;
        public int Trademark_Type
        {
            get { return _trademark_type; }
            set { _trademark_type = value; }
        }
        /// <summary>
        /// trademark_no
        /// </summary>		
        private int _trademark_no;
        public int Trademark_No
        {
            get { return _trademark_no; }
            set { _trademark_no = value; }
        }
        /// <summary>
        /// tax_qualification
        /// </summary>		
        private int _tax_qualification;
        public int Tax_Qualification
        {
            get { return _tax_qualification; }
            set { _tax_qualification = value; }
        }

        //public string WeiScore { get; set; }

        public DateTime? AddTime
        {
            get
            {
                if (this._add_time == 0) return null;
                return this._add_time.ToDateTime2();
            }
        }

        public string AddDate
        {
            get
            {
                Time time = new Time();
                return time.GetTime(_add_time.ToString()).ToString();
            }
        }

        public DateTime? StartTime
        {
            get
            {
                if (this._start_time == 0) return null;
                return this._start_time.ToDateTime2();
            }
        }

        public string MallType
        {
            get
            {
                return PropertyType.MallType(this._mall_type);
            }
        }

        public string Guan_Name { get; set; }

        public decimal SellerIncome
        {
            get
            {
                return (Price + Protection_Deposit + Tech_Fee) * (1 - ApplicationConfig.SysFee);
            }
        }

        public string TaxQualification
        {
            get
            {
                return PropertyType.TaxQualifiactionType(this._tax_qualification);
            }
        }

        public string TrademarkType
        {
            get
            {
                return PropertyType.TrademarkType(this._trademark_type);
            }
        }

        public string WhetherGoods
        {
            get
            {
                return PropertyType.BoolType(this._whether_goods);
            }
        }

        public string FormatPrice
        {
            get
            {
                return PropertyType.FormatPrice(this._price);
            }
        }

        public string FormatMarketPrice
        {
            get
            {
                return PropertyType.FormatPrice(this._market_price);
            }
        }

        public string ScoreValue
        {
            get
            {
                var jss = new JavaScriptSerializer();

                if (!this.Score.IsNullOrWhiteSpace())
                {
                    try
                    {
                        var map = jss.Deserialize<Dictionary<string, string>>(this.Score);
                        var scoreStr = map["score"];
                        if (!string.IsNullOrWhiteSpace(scoreStr))
                            return string.Join("-", scoreStr.Split(','));
                        else
                            return null;
                    }
                    catch
                    {
                        return null;
                    }
                }

                return null;
            }
        }

        public string ScoreLevel
        {
            get
            {
                var jss = new JavaScriptSerializer();

                if (!this.Score.IsNullOrWhiteSpace())
                {
                    try
                    {
                        var map = jss.Deserialize<Dictionary<string, string>>(this.Score);
                        var scoreStr = map["level"];
                        if (!string.IsNullOrWhiteSpace(scoreStr))
                            return string.Join("/", scoreStr.Split(','));
                        else
                            return null;
                    }
                    catch
                    {
                        return null;
                    }
                }

                return null;
            }
        }

        public class Query
        {
            public string Cat_Id { get; set; }

            public int? Status { get; set; }

            public int? Admin_Id { get; set; }

            public int? Guanlian_Id { get; set; }

            public int? Pay_Status { get; set; }

            public int? Hot { get; set; }

            public int? Best { get; set; }

            public int? New { get; set; }

            public int? Parent_Id { get; set; }

            public string Seller_Id { get; set; }

            public int? User_Id { get; set; }

            public string Keyword { get; set; }

            public string Smallarea { get; set; }

            public string Subname { get; set; }

            public string Sn { get; set; }

            public string Area { get; set; }

            public int? Company_Level { get; set; }

            public decimal? StartPrice { get; set; }

            public decimal? EndPrice { get; set; }

            public DateTime? StartDate { get; set; }

            public DateTime? EndDate { get; set; }

            public int? Sales { get; set; }

            public int? StartTime1 { get; set; }

            public int? StartTime2 { get; set; }

            public int? Type { get; set; }

            public int? MallType { get; set; }

            public int? TradeMark_Type { get; set; }

            public int? Recommend { get; set; }

            public int? Whether_Goods { get; set; }



            public IList<KeyValuePair<int, string>> Attrs { get; set; }
        }


    }

}