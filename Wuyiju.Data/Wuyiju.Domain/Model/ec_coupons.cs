using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_coupons:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_coupons
	{
		public ec_coupons()
		{}
		#region Model
		private int _coupon_id;
		private int _coupon_type_id=0;
		private long _coupon_sn=0;
		private int _user_id;
		private int _used_time=0;
		private int _order_id;
		private int _emailed=0;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int coupon_id
		{
			set{ _coupon_id=value;}
			get{return _coupon_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int coupon_type_id
		{
			set{ _coupon_type_id=value;}
			get{return _coupon_type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long coupon_sn
		{
			set{ _coupon_sn=value;}
			get{return _coupon_sn;}
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
		public int used_time
		{
			set{ _used_time=value;}
			get{return _used_time;}
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
		public int emailed
		{
			set{ _emailed=value;}
			get{return _emailed;}
		}
		#endregion Model

	}
}

