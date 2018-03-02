using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.Model
{
    //ec_deposit_recharge
    public class DepositRecharge
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
        /// pay_type
        /// </summary>		
        private RechargeType _pay_type;
        public RechargeType Pay_Type
        {
            get { return _pay_type; }
            set { _pay_type = value; }
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
        /// user_id
        /// </summary>		
        private int _user_id;
        public int User_Id
        {
            get { return _user_id; }
            set { _user_id = value; }
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

        public DateTime? AddTime
        {
            get
            {
                return _add_time.ToDateTime2();
            }
        }
        /// <summary>
        /// pay_time
        /// </summary>		
        private int _pay_time;
        public int Pay_Time
        {
            get { return _pay_time; }
            set { _pay_time = value; }
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
        private string _user_name;
        public string User_Name
        {
            get { return _user_name; }
            set { _user_name = value; }
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
        /// txt
        /// </summary>		
        private string _txt;
        public string Txt
        {
            get { return _txt; }
            set { _txt = value; }
        }
        /// <summary>
        /// shoukCard
        /// </summary>		
        private string _shoukcard;
        public string Shoukcard
        {
            get { return _shoukcard; }
            set { _shoukcard = value; }
        }
        /// <summary>
        /// huiBank
        /// </summary>		
        private string _huibank;
        public string Huibank
        {
            get { return _huibank; }
            set { _huibank = value; }
        }
        /// <summary>
        /// huiMoney
        /// </summary>		
        private decimal _huimoney;
        public decimal Huimoney
        {
            get { return _huimoney; }
            set { _huimoney = value; }
        }
        /// <summary>
        /// huiTime
        /// </summary>		
        private long _huitime;
        public long Huitime
        {
            get { return _huitime; }
            set { _huitime = value; }
        }

        public string Huidate
        {
            get
            {

                if (this._huitime == 0) return null;
                return this._huitime.ToDateTime2().ToString("yyyy/MM/dd");
            }
        }
        /// <summary>
        /// huiUser
        /// </summary>		
        private string _huiuser;
        public string Huiuser
        {
            get { return _huiuser; }
            set { _huiuser = value; }
        }
        /// <summary>
        /// huiFile
        /// </summary>		
        private string _huifile;
        public string Huifile
        {
            get { return _huifile; }
            set { _huifile = value; }
        }
        /// <summary>
        /// huiRemark
        /// </summary>		
        private string _huiremark;
        public string Huiremark
        {
            get { return _huiremark; }
            set { _huiremark = value; }
        }


        public string StatusText
        {
            get
            {

                switch (_status)
                {
                    case 0: return PropertyType.Lang("processing");
                    case 1: return PropertyType.Lang("cz_succeed");
                    case 2: return PropertyType.Lang("cz_failed");
                    case 9: return PropertyType.Lang("unlimit");
                    default: return string.Empty;
                }


            }
        }


        public class Query
        {
            public int? User_Id { get; set; }

            public int? Status { get; set; }

            public DateTime? StartDate { get; set; }

            public DateTime? EndDate { get; set; }
        }

    }

    public enum RechargeType : int
    {
        BankHui = 3,
        AlipayHui = 4
    }
}