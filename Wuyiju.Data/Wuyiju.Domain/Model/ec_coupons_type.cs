using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_coupons_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_coupons_type
	{
		public ec_coupons_type()
		{}
		#region Model
		private int _type_id;
		private string _type_name;
		private decimal _type_money=0.00M;
		private int _send_type=0;
		private decimal _min_amount=0.00M;
		private decimal _max_amount=0.00M;
		private int _send_start_date=0;
		private int _send_end_date=0;
		private int _use_start_date=0;
		private int _use_end_date=0;
		private decimal _min_product_amount=0.00M;
		private string _coupon_img;
		private int _points_exchange=0;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int type_id
		{
			set{ _type_id=value;}
			get{return _type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type_name
		{
			set{ _type_name=value;}
			get{return _type_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal type_money
		{
			set{ _type_money=value;}
			get{return _type_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int send_type
		{
			set{ _send_type=value;}
			get{return _send_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal min_amount
		{
			set{ _min_amount=value;}
			get{return _min_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal max_amount
		{
			set{ _max_amount=value;}
			get{return _max_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int send_start_date
		{
			set{ _send_start_date=value;}
			get{return _send_start_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int send_end_date
		{
			set{ _send_end_date=value;}
			get{return _send_end_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int use_start_date
		{
			set{ _use_start_date=value;}
			get{return _use_start_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int use_end_date
		{
			set{ _use_end_date=value;}
			get{return _use_end_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal min_product_amount
		{
			set{ _min_product_amount=value;}
			get{return _min_product_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string coupon_img
		{
			set{ _coupon_img=value;}
			get{return _coupon_img;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int points_exchange
		{
			set{ _points_exchange=value;}
			get{return _points_exchange;}
		}
		#endregion Model

	}
}

