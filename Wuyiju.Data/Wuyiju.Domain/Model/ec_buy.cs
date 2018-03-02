using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_buy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_buy
	{
		public ec_buy()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _sn;
		private string _brief;
		private int _cate_id=0;
		private int _type=0;
		private int _level=0;
		private int _level_child=0;
		private string _detail;
		private decimal _start_price=0.00M;
		private decimal _end_price=0.00M;
		private int _validday=0;
		private int _stocks=0;
		private int _status=0;
		private int _v_status=0;
		private int _p_status=0;
		private string _remark;
		private string _qq;
		private string _user_name;
		private string _mobile;
		private decimal _good_rating=0.0M;
		private int _user_id=0;
		private decimal _rating=0.0M;
		private int _add_time=0;
		private int _created=0;
		private string _credentials= "0";
		private int _click=0;
		private int _role_id=0;
		private int _admin_id=0;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
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
		public string brief
		{
			set{ _brief=value;}
			get{return _brief;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int cate_id
		{
			set{ _cate_id=value;}
			get{return _cate_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int level_child
		{
			set{ _level_child=value;}
			get{return _level_child;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string detail
		{
			set{ _detail=value;}
			get{return _detail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal start_price
		{
			set{ _start_price=value;}
			get{return _start_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal end_price
		{
			set{ _end_price=value;}
			get{return _end_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int validDay
		{
			set{ _validday=value;}
			get{return _validday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int stocks
		{
			set{ _stocks=value;}
			get{return _stocks;}
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
		public int v_status
		{
			set{ _v_status=value;}
			get{return _v_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int p_status
		{
			set{ _p_status=value;}
			get{return _p_status;}
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
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
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
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal good_rating
		{
			set{ _good_rating=value;}
			get{return _good_rating;}
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
		public decimal rating
		{
			set{ _rating=value;}
			get{return _rating;}
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
		public int created
		{
			set{ _created=value;}
			get{return _created;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string credentials
		{
			set{ _credentials=value;}
			get{return _credentials;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int click
		{
			set{ _click=value;}
			get{return _click;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int role_id
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int admin_id
		{
			set{ _admin_id=value;}
			get{return _admin_id;}
		}
		#endregion Model

	}
}

