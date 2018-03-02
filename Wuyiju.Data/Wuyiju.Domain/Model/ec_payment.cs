using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_payment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_payment
	{
		public ec_payment()
		{}
		#region Model
		private int _pay_id;
		private string _pay_name;
		private string _pay_code;
		private string _pay_desc;
		private string _pay_logo;
		private int _enabled=1;
		private int _pay_order=99;
		private string _pay_content;
		private decimal _pay_fee=0.00M;
		private string _partner_id;
		private string _partner_key;
		private int _is_online=1;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int pay_id
		{
			set{ _pay_id=value;}
			get{return _pay_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_name
		{
			set{ _pay_name=value;}
			get{return _pay_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_code
		{
			set{ _pay_code=value;}
			get{return _pay_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_desc
		{
			set{ _pay_desc=value;}
			get{return _pay_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_logo
		{
			set{ _pay_logo=value;}
			get{return _pay_logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int enabled
		{
			set{ _enabled=value;}
			get{return _enabled;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pay_order
		{
			set{ _pay_order=value;}
			get{return _pay_order;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_content
		{
			set{ _pay_content=value;}
			get{return _pay_content;}
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
		public string partner_id
		{
			set{ _partner_id=value;}
			get{return _partner_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string partner_key
		{
			set{ _partner_key=value;}
			get{return _partner_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_online
		{
			set{ _is_online=value;}
			get{return _is_online;}
		}
		#endregion Model

	}
}

