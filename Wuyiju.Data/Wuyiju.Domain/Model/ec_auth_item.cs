using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_auth_item:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_auth_item
	{
		public ec_auth_item()
		{}
		#region Model
		private string _auth_code;
		private string _auth_title;
		private string _auth_day;
		private string _auth_small_ico;
		private string _auth_small_n_ico;
		private string _auth_big_ico;
		private string _auth_desc;
		private decimal? _auth_cash=0.00M;
		private int? _auth_expir;
		private int? _auth_open;
		private int? _auth_show;
		private int? _muti_auth;
		private int? _update_time;
		private string _auth_dir;
		private int? _listorder;
		private string _config;
		/// <summary>
		/// 
		/// </summary>
		public string auth_code
		{
			set{ _auth_code=value;}
			get{return _auth_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string auth_title
		{
			set{ _auth_title=value;}
			get{return _auth_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string auth_day
		{
			set{ _auth_day=value;}
			get{return _auth_day;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string auth_small_ico
		{
			set{ _auth_small_ico=value;}
			get{return _auth_small_ico;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string auth_small_n_ico
		{
			set{ _auth_small_n_ico=value;}
			get{return _auth_small_n_ico;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string auth_big_ico
		{
			set{ _auth_big_ico=value;}
			get{return _auth_big_ico;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string auth_desc
		{
			set{ _auth_desc=value;}
			get{return _auth_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? auth_cash
		{
			set{ _auth_cash=value;}
			get{return _auth_cash;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? auth_expir
		{
			set{ _auth_expir=value;}
			get{return _auth_expir;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? auth_open
		{
			set{ _auth_open=value;}
			get{return _auth_open;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? auth_show
		{
			set{ _auth_show=value;}
			get{return _auth_show;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? muti_auth
		{
			set{ _muti_auth=value;}
			get{return _muti_auth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? update_time
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string auth_dir
		{
			set{ _auth_dir=value;}
			get{return _auth_dir;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? listorder
		{
			set{ _listorder=value;}
			get{return _listorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string config
		{
			set{ _config=value;}
			get{return _config;}
		}
		#endregion Model

	}
}

