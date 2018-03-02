using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Core;
using Wuyiju.View;

namespace Wuyiju.Model
{
    //ec_deposit_takecash
    public class DepositTakecash
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
        /// user_id
        /// </summary>		
        private int _user_id;
        public int User_Id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        /// <summary>
        /// user_name
        /// </summary>		
        private string _user_name;
        public string User_Name
        {
            get { return _user_name; }
            set { _user_name = value; }
        }
        /// <summary>
        /// bank_card_id
        /// </summary>		
        private int _bank_card_id;
        public int Bank_Card_Id
        {
            get { return _bank_card_id; }
            set { _bank_card_id = value; }
        }

        /// <summary>
        /// bank_card_name
        /// </summary>		
        private string _bank_card_name;
        public string Bank_Card_Name
        {
            get { return _bank_card_name; }
            set { _bank_card_name = value; }
        }
        /// <summary>
        /// money
        /// </summary>		
        private decimal _money;
        public decimal Money
        {
            get { return _money; }
            set { _money = value; }
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
        /// status
        /// </summary>		
        private int _status;
        public int Status
        {
            get { return _status; }
            set { _status = value; }
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
        /// pay_money
        /// </summary>		
        private decimal _pay_money;
        public decimal Pay_Money
        {
            get { return _pay_money; }
            set { _pay_money = value; }
        }
        /// <summary>
        /// remark
        /// </summary>		
        private string _remark;
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
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


        public DateTime? AddTime
        {
            get
            {
                return _add_time.ToDateTime2();
            }
        }

        public string StatusText
        {
            get
            {

                switch (_status)
                {
                    case 0: return "请求中";
                    case 1: return "处理中";
                    case 2: return "成功";
                    case 3: return "失败";
                    default: return string.Empty;
                }


            }
        }
        public class Query
        {
            public int? Status { get; set; }

            public int? User_Id { get; set; }

            public DateTime? StartDate { get; set; }

            public DateTime? EndDate { get; set; }
        }

    }
}