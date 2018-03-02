using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_user
	{
		public ec_user()
		{}
		#region Model
		private int _id;
		private string _name= "0";
		private string _password= "0";
		private string _pay_password;
		private string _realname;
		private string _email;
		private string _mobile;
		private string _login_ip;
		private int _add_time=0;
		private int _status=1;
		private int _last_time=0;
		private string _last_ip= "0";
		private int _login_count=0;
		private string _salt= "0";
		private int _is_email_validated=0;
		private int _is_mobile_validated=0;
		private decimal? _money=0.00M;
		private decimal _frozen_money=0.00M;
		private int _money_status=1;
		private int? _rank_points=0;
		private int? _points=0;
		private int _rank_id=1;
		private int _sex=0;
		private string _brithday;
		private string _qq;
		private string _pwd_question;
		private string _pwd_answer;
		private string _introducer;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_password
		{
			set{ _pay_password=value;}
			get{return _pay_password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string realname
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string login_ip
		{
			set{ _login_ip=value;}
			get{return _login_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int last_time
		{
			set{ _last_time=value;}
			get{return _last_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string last_ip
		{
			set{ _last_ip=value;}
			get{return _last_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int login_count
		{
			set{ _login_count=value;}
			get{return _login_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string salt
		{
			set{ _salt=value;}
			get{return _salt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_email_validated
		{
			set{ _is_email_validated=value;}
			get{return _is_email_validated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_mobile_validated
		{
			set{ _is_mobile_validated=value;}
			get{return _is_mobile_validated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal frozen_money
		{
			set{ _frozen_money=value;}
			get{return _frozen_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int money_status
		{
			set{ _money_status=value;}
			get{return _money_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? rank_points
		{
			set{ _rank_points=value;}
			get{return _rank_points;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? points
		{
			set{ _points=value;}
			get{return _points;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int rank_id
		{
			set{ _rank_id=value;}
			get{return _rank_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string brithday
		{
			set{ _brithday=value;}
			get{return _brithday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pwd_question
		{
			set{ _pwd_question=value;}
			get{return _pwd_question;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pwd_answer
		{
			set{ _pwd_answer=value;}
			get{return _pwd_answer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string introducer
		{
			set{ _introducer=value;}
			get{return _introducer;}
		}
        #endregion Model

        public class query
        {

        }
	}
}

