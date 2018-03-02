using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_condition:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_condition
	{
		public ec_condition()
		{}
		#region Model
		private int _id;
		private int _product_id;
		private int _clicks;
		private int _visitors;
		private int _payed_num;
		private int _buyer_num;
		private decimal _kedan;
		private string _change;
		private decimal _total_amount;
		private DateTime _start_time;
		private DateTime _end_time;
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
		public int product_id
		{
			set{ _product_id=value;}
			get{return _product_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int clicks
		{
			set{ _clicks=value;}
			get{return _clicks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int visitors
		{
			set{ _visitors=value;}
			get{return _visitors;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int payed_num
		{
			set{ _payed_num=value;}
			get{return _payed_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int buyer_num
		{
			set{ _buyer_num=value;}
			get{return _buyer_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal kedan
		{
			set{ _kedan=value;}
			get{return _kedan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string change
		{
			set{ _change=value;}
			get{return _change;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal total_amount
		{
			set{ _total_amount=value;}
			get{return _total_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime start_time
		{
			set{ _start_time=value;}
			get{return _start_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime end_time
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		#endregion Model

	}
}

