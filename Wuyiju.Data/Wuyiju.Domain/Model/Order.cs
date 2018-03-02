using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Domain.View;
using Wuyiju.Core;
namespace Wuyiju.Model
{
    //ec_order
    public class Order
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
        /// sn
        /// </summary>		
        private string _sn;
        public string Sn
        {
            get { return _sn; }
            set { _sn = value; }
        }
        /// <summary>
        /// product_id
        /// </summary>		
        private int _product_id;
        public int Product_Id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        /// <summary>
        /// product_name
        /// </summary>		
        private string _product_name;
        public string Product_Name
        {
            get { return _product_name; }
            set { _product_name = value; }
        }

        /// <summary>
        /// product_name
        /// </summary>		
        private int _role_id;
        public int Role_Id
        {
            get { return _role_id; }
            set { _role_id = value; }
        }

        /// <summary>
        /// product_name
        /// </summary>		
        private string _sub_name;
        public string Sub_Name
        {
            get { return _sub_name; }
            set { _sub_name = value; }
        }

        /// <summary>
        /// product_name
        /// </summary>		
        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
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
        /// pay_statu
        /// </summary>		
        private int _pay_statu;
        public int Pay_Statu
        {
            get { return _pay_statu; }
            set { _pay_statu = value; }
        }
        /// <summary>
        /// username
        /// </summary>		
        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
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
        /// uid
        /// </summary>		
        private int _uid;
        public int Uid
        {
            get { return _uid; }
            set { _uid = value; }
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
        /// tel
        /// </summary>		
        private string _tel;
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        /// <summary>
        /// mobile
        /// </summary>		
        private string _mobile;
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        /// <summary>
        /// email
        /// </summary>		
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
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

        


        public string AddDate
        {
            get
            {

                if (this._add_time == 0) return null;
                return this._add_time.ToDateTime2().ToString("yyyy/MM/dd HH:mm:ss");
            }
        }

        /// <summary>
        /// rest_time
        /// </summary>		
		private long _rest_time;
        public long Rest_Time
        {
            get { return _rest_time; }
            set { _rest_time = value; }
        }
        /// <summary>
        /// countdown
        /// </summary>		
        private int _countdown;
        public int Countdown
        {
            get { return _countdown; }
            set { _countdown = value; }
        }
        /// <summary>
        /// pay_time
        /// </summary>		
        private long _pay_time;
        public long Pay_Time
        {
            get { return _pay_time; }
            set { _pay_time = value; }
        }

        public string PayTime
        {
            get
            {
                Time time = new Time();
                return time.GetTime(_pay_time.ToString()).ToString();
            }
        }

        /// <summary>
        /// pay_id
        /// </summary>		
        private int _pay_id;
        public int Pay_Id
        {
            get { return _pay_id; }
            set { _pay_id = value; }
        }
        /// <summary>
        /// discount
        /// </summary>		
        private decimal _discount;
        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        /// <summary>
        /// coupon
        /// </summary>		
        private string _coupon;
        public string Coupon
        {
            get { return _coupon; }
            set { _coupon = value; }
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
        /// num
        /// </summary>		
        private int _num;
        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }
        /// <summary>
        /// total_fee
        /// </summary>		
        private decimal _total_fee;
        public decimal Total_Fee
        {
            get { return _total_fee; }
            set { _total_fee = value; }
        }
        /// <summary>
        /// pay_fee
        /// </summary>		
        private decimal _pay_fee;
        public decimal Pay_Fee
        {
            get { return _pay_fee; }
            set { _pay_fee = value; }
        }
        /// <summary>
        /// trade_no
        /// </summary>		
        private string _trade_no;
        public string Trade_No
        {
            get { return _trade_no; }
            set { _trade_no = value; }
        }

        /// <summary>
        /// trade_no
        /// </summary>		
        private string _buy_name;
        public string Buy_Name
        {
            get { return _buy_name; }
            set { _buy_name = value; }
        }

        /// <summary>
        /// trade_no
        /// </summary>		
        private string _buy_phone;
        public string Buy_Phone
        {
            get { return _buy_phone; }
            set { _buy_phone = value; }
        }

        /// <summary>
        /// trade_no
        /// </summary>		
        private string _buy_realname;
        public string Buy_Realname
        {
            get { return _buy_realname; }
            set { _buy_realname = value; }
        }

        /// <summary>
        /// trade_no
        /// </summary>		
        private string _buy_qq;
        public string Buy_Qq
        {
            get { return _buy_qq; }
            set { _buy_qq = value; }
        }

        /// <summary>
        /// trade_no
        /// </summary>		
        private string _sell_name;
        public string Sell_Name
        {
            get { return _sell_name; }
            set { _sell_name = value; }
        }

        /// <summary>
        /// trade_no
        /// </summary>		
        private string _sell_phone;
        public string Sell_Phone
        {
            get { return _sell_phone; }
            set { _sell_phone = value; }
        }

        

        /// <summary>
        /// trade_no
        /// </summary>		
        private string _sell_realname;
        public string Sell_Realname
        {
            get { return _sell_realname; }
            set { _sell_realname = value; }
        }

        /// <summary>
        /// trade_no
        /// </summary>		
        private string _sell_qq;
        public string Sell_Qq
        {
            get { return _sell_qq; }
            set { _sell_qq = value; }
        }

        /// <summary>
        /// txt
        /// </summary>		
        private string _txt;
        public string Txt
        {
            get { return _txt; }
            set { _txt = value; }
        }
        /// <summary>
        /// del
        /// </summary>		
        private int _del;
        public int Del
        {
            get { return _del; }
            set { _del = value; }
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

        public string DelTime
        {
            get
            {
                Time time = new Time();
                return time.GetTime(_del_time.ToString()).ToString();
            }
        }

        /// <summary>
        /// send_mail
        /// </summary>		
        private int _send_mail;
        public int Send_Mail
        {
            get { return _send_mail; }
            set { _send_mail = value; }
        }
        /// <summary>
        /// fee
        /// </summary>		
        private decimal _fee;
        public decimal Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }
        /// <summary>
        /// ensure
        /// </summary>		
        private decimal _ensure;
        public decimal Ensure
        {
            get { return _ensure; }
            set { _ensure = value; }
        }
        /// <summary>
        /// techfee
        /// </summary>		
        private decimal _techfee;
        public decimal Techfee
        {
            get { return _techfee; }
            set { _techfee = value; }
        }
        /// <summary>
        /// deposit
        /// </summary>		
        private decimal _deposit;
        public decimal Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }

        public static string PayStatusText(int? payStatus)
        {
            switch (payStatus)
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

        public class Query
        {
            public int? Add_Time { get; set; }

            public int? Status { get; set; }

            public int? Pay_Status { get; set; }

            public int? Product_Id { get; set; }

            public int? Del { get; set; }

            public int? Uid { get; set; }

            public int? Guanlian_Id { get; set; }

            public int? Admin_Id { get; set; }

            public int? Parent_Id { get; set; }

            public DateTime? StartDate { get; set; }

            public DateTime? EndDate { get; set; }

            public int? StartTime { get; set; }

            public int? EndTime { get; set; }
           
        }

    }
}