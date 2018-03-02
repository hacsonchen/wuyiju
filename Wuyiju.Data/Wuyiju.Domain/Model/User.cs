using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Domain.View;
namespace Wuyiju.Model
{
    //ec_user
    public class User
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
        /// name
        /// </summary>		
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// password
        /// </summary>		
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// pay_password
        /// </summary>		
        private string _pay_password;
        public string Pay_Password
        {
            get { return _pay_password; }
            set { _pay_password = value; }
        }
        /// <summary>
        /// realname
        /// </summary>		
        private string _realname;
        public string Realname
        {
            get { return _realname; }
            set { _realname = value; }
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
        /// mobile
        /// </summary>		
        private string _mobile;
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        /// <summary>
        /// login_ip
        /// </summary>		
        private string _login_ip;
        public string Login_Ip
        {
            get { return _login_ip; }
            set { _login_ip = value; }
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
                Time time = new Time();
                return time.GetTime(_add_time.ToString()).ToString();
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
        /// last_time
        /// </summary>		
        private int _last_time;
        public int Last_Time
        {
            get { return _last_time; }
            set { _last_time = value; }
        }

        public string LastTime
        {
            get
            {
                Time time = new Time();
                return time.GetTime(_last_time.ToString()).ToString();
            }
        }
        /// <summary>
        /// last_ip
        /// </summary>		
        private string _last_ip;
        public string Last_Ip
        {
            get { return _last_ip; }
            set { _last_ip = value; }
        }
        /// <summary>
        /// login_count
        /// </summary>		
        private int _login_count;
        public int Login_Count
        {
            get { return _login_count; }
            set { _login_count = value; }
        }
        /// <summary>
        /// salt
        /// </summary>		
        private string _salt;
        public string Salt
        {
            get { return _salt; }
            set { _salt = value; }
        }
        /// <summary>
        /// is_email_validated
        /// </summary>		
        private int _is_email_validated;
        public int Is_Email_Validated
        {
            get { return _is_email_validated; }
            set { _is_email_validated = value; }
        }
        /// <summary>
        /// is_mobile_validated
        /// </summary>		
        private int _is_mobile_validated;
        public int Is_Mobile_Validated
        {
            get { return _is_mobile_validated; }
            set { _is_mobile_validated = value; }
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
        /// frozen_money
        /// </summary>		
        private decimal _frozen_money;
        public decimal Frozen_Money
        {
            get { return _frozen_money; }
            set { _frozen_money = value; }
        }
        /// <summary>
        /// money_status
        /// </summary>		
        private int _money_status;
        public int Money_Status
        {
            get { return _money_status; }
            set { _money_status = value; }
        }
        /// <summary>
        /// rank_points
        /// </summary>		
        private int _rank_points;
        public int Rank_Points
        {
            get { return _rank_points; }
            set { _rank_points = value; }
        }
        /// <summary>
        /// points
        /// </summary>		
        private int _points;
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }
        /// <summary>
        /// rank_id
        /// </summary>		
        private int _rank_id;
        public int Rank_Id
        {
            get { return _rank_id; }
            set { _rank_id = value; }
        }
        /// <summary>
        /// sex
        /// </summary>		
        private int _sex;
        public int Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        /// <summary>
        /// brithday
        /// </summary>		
        private string _brithday;
        public string Brithday
        {
            get { return _brithday; }
            set { _brithday = value; }
        }


        /// <summary>
        /// qq
        /// </summary>		
        private string _qq;
        public string Qq
        {
            get { return _qq; }
            set { _qq = value; }
        }
        /// <summary>
        /// pwd_question
        /// </summary>		
        private string _pwd_question;
        public string Pwd_Question
        {
            get { return _pwd_question; }
            set { _pwd_question = value; }
        }
        /// <summary>
        /// pwd_answer
        /// </summary>		
        private string _pwd_answer;
        public string Pwd_Answer
        {
            get { return _pwd_answer; }
            set { _pwd_answer = value; }
        }
        /// <summary>
        /// introducer
        /// </summary>		
        private string _introducer;
        public string Introducer
        {
            get { return _introducer; }
            set { _introducer = value; }
        }

        public class Query
        {
            public string Mobile { get; set; }
            public string Status { get; set; }

            public int? Id { get; set; }

            public DateTime? StartDate { get; set; }

            public DateTime? EndDate { get; set; }

            public string Introducer { get; set; }
        }

    }
}