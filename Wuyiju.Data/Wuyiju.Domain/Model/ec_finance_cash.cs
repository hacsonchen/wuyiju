using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_finance_cash:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_finance_cash
	{
		public ec_finance_cash()
		{}
		#region Model
		private int _id;
		private int _user_id;
		private string _uname;
		private decimal? _money=0.00M;
		private int _points;
		private string _remark;
		private int _add_time=0;
		private string _ip;
		private string _reply;
		private int _status=0;
		private string _realname;
		private string _alipay;
		private int? _is_money=1;
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
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uname
		{
			set{ _uname=value;}
			get{return _uname;}
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
		public int points
		{
			set{ _points=value;}
			get{return _points;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reply
		{
			set{ _reply=value;}
			get{return _reply;}
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
		public string realname
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string alipay
		{
			set{ _alipay=value;}
			get{return _alipay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_money
		{
			set{ _is_money=value;}
			get{return _is_money;}
		}
		#endregion Model

	}
}

