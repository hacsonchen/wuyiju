using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_deposit_recharge:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_deposit_recharge
	{
		public ec_deposit_recharge()
		{}
		#region Model
		private int _id;
		private string _sn;
		private int _pay_type=1;
		private int _status=0;
		private int _user_id;
		private int _add_time=0;
		private int _pay_time=0;
		private decimal _total_fee=0.00M;
		private decimal _pay_fee=0.00M;
		private string _trade_no;
		private string _txt;
		private string _shoukcard;
		private string _huibank;
		private decimal _huimoney;
		private int _huitime;
		private string _huiuser;
		private string _huifile;
		private string _huiremark;
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
		public int pay_type
		{
			set{ _pay_type=value;}
			get{return _pay_type;}
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
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
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
		public int pay_time
		{
			set{ _pay_time=value;}
			get{return _pay_time;}
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
		public string shoukCard
		{
			set{ _shoukcard=value;}
			get{return _shoukcard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string huiBank
		{
			set{ _huibank=value;}
			get{return _huibank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal huiMoney
		{
			set{ _huimoney=value;}
			get{return _huimoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int huiTime
		{
			set{ _huitime=value;}
			get{return _huitime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string huiUser
		{
			set{ _huiuser=value;}
			get{return _huiuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string huiFile
		{
			set{ _huifile=value;}
			get{return _huifile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string huiRemark
		{
			set{ _huiremark=value;}
			get{return _huiremark;}
		}
		#endregion Model

	}
}

