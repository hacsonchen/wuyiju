using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_paylog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_paylog
	{
		public ec_paylog()
		{}
		#region Model
		private int _log_id;
		private int _order_id;
		private decimal _amount=0.00M;
		private int _order_type=0;
		private int _is_paid=0;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int log_id
		{
			set{ _log_id=value;}
			get{return _log_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int order_id
		{
			set{ _order_id=value;}
			get{return _order_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int order_type
		{
			set{ _order_type=value;}
			get{return _order_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_paid
		{
			set{ _is_paid=value;}
			get{return _is_paid;}
		}
		#endregion Model

	}
}

