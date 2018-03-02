using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_course:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_course
	{
		public ec_course()
		{}
		#region Model
		private int _cid;
		private string _c_name;
		private string _t_name;
		private string _t_content;
		private DateTime _c_time;
		private int _add_time;
		private int _status=1;
		private DateTime _jz_time;
		private string _url= "0";
		private string _t_process;
		private string _seo_title;
		private string _seo_keys;
		private string _seo_desc;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int cid
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string c_name
		{
			set{ _c_name=value;}
			get{return _c_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string t_name
		{
			set{ _t_name=value;}
			get{return _t_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string t_content
		{
			set{ _t_content=value;}
			get{return _t_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime c_time
		{
			set{ _c_time=value;}
			get{return _c_time;}
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
		public DateTime jz_time
		{
			set{ _jz_time=value;}
			get{return _jz_time;}
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
		public string t_process
		{
			set{ _t_process=value;}
			get{return _t_process;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seo_title
		{
			set{ _seo_title=value;}
			get{return _seo_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seo_keys
		{
			set{ _seo_keys=value;}
			get{return _seo_keys;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seo_desc
		{
			set{ _seo_desc=value;}
			get{return _seo_desc;}
		}
		#endregion Model

	}
}

