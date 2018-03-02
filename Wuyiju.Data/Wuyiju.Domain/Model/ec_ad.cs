using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_ad:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_ad
	{
		public ec_ad()
		{}
		#region Model
		private int _id;
		private int _position_id;
		private string _type;
		private string _name;
		private string _url;
		private string _thumb;
		private string _code;
		private string _summary;
		private string _discription;
		private int _start_time;
		private int _end_time;
		private int _clicks=0;
		private int _add_time;
		private int _sort_order;
		private int _status=1;
		private string _ad_type;
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
		public int position_id
		{
			set{ _position_id=value;}
			get{return _position_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
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
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string thumb
		{
			set{ _thumb=value;}
			get{return _thumb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string summary
		{
			set{ _summary=value;}
			get{return _summary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string discription
		{
			set{ _discription=value;}
			get{return _discription;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int start_time
		{
			set{ _start_time=value;}
			get{return _start_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int end_time
		{
			set{ _end_time=value;}
			get{return _end_time;}
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
		public int add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sort_order
		{
			set{ _sort_order=value;}
			get{return _sort_order;}
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
		public string ad_type
		{
			set{ _ad_type=value;}
			get{return _ad_type;}
		}
		#endregion Model

	}
}

