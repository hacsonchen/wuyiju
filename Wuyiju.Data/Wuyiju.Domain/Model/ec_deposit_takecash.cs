using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_deposit_takecash:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_deposit_takecash
	{
		public ec_deposit_takecash()
		{}
		#region Model
		private int _id;
		private int _user_id;
		private string _user_name;
		private int _bank_card_id;
		private decimal _money;
		private int _add_time;
		private int _status=0;
		private string _sn;
		private decimal _pay_money=0.00M;
		private string _remark;
		private int _pay_time;
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
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int bank_card_id
		{
			set{ _bank_card_id=value;}
			get{return _bank_card_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal money
		{
			set{ _money=value;}
			get{return _money;}
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
		public string sn
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal pay_money
		{
			set{ _pay_money=value;}
			get{return _pay_money;}
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
		public int pay_time
		{
			set{ _pay_time=value;}
			get{return _pay_time;}
		}
		#endregion Model

	}
}

