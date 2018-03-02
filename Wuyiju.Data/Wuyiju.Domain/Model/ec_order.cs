using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_order
	{
		public ec_order()
		{}
		#region Model
		private int _id;
		private string _sn;
		private int _product_id;
		private int _status=1;
		private int _pay_statu;
		private string _username;
		private string _name;
		private int _uid=0;
		private int _seller_id;
		private string _tel;
		private string _mobile;
		private string _email;
		private int _add_time=0;
		private int _rest_time;
		private int _countdown;
		private int _pay_time=0;
		private int _pay_id=0;
		private decimal _discount=0.00M;
		private string _coupon;
		private decimal _price=1.00M;
		private int _num=1;
		private decimal _total_fee=0.00M;
		private decimal _pay_fee=0.00M;
		private string _trade_no;
		private string _txt;
		private int _del=0;
		private int _del_time=0;
		private int _send_mail=0;
		private decimal _fee=0.00M;
		private decimal _ensure=0.00M;
		private decimal _techfee=0.00M;
		private decimal _deposit=0.00M;
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
		public string sn
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int product_id
		{
			set{ _product_id=value;}
			get{return _product_id;}
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
		public int pay_statu
		{
			set{ _pay_statu=value;}
			get{return _pay_statu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
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
		public int uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int seller_id
		{
			set{ _seller_id=value;}
			get{return _seller_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
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
		public string email
		{
			set{ _email=value;}
			get{return _email;}
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
		public int rest_time
		{
			set{ _rest_time=value;}
			get{return _rest_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int countdown
		{
			set{ _countdown=value;}
			get{return _countdown;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pay_time
		{
			set{ _pay_time=value;}
			get{return _pay_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pay_id
		{
			set{ _pay_id=value;}
			get{return _pay_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string coupon
		{
			set{ _coupon=value;}
			get{return _coupon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal total_fee
		{
			set{ _total_fee=value;}
			get{return _total_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal pay_fee
		{
			set{ _pay_fee=value;}
			get{return _pay_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trade_no
		{
			set{ _trade_no=value;}
			get{return _trade_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string txt
		{
			set{ _txt=value;}
			get{return _txt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int del
		{
			set{ _del=value;}
			get{return _del;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int del_time
		{
			set{ _del_time=value;}
			get{return _del_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int send_mail
		{
			set{ _send_mail=value;}
			get{return _send_mail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal fee
		{
			set{ _fee=value;}
			get{return _fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ensure
		{
			set{ _ensure=value;}
			get{return _ensure;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal techfee
		{
			set{ _techfee=value;}
			get{return _techfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal deposit
		{
			set{ _deposit=value;}
			get{return _deposit;}
		}
		#endregion Model

	}
}

