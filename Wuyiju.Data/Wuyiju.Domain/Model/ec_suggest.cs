using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_suggest:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_suggest
	{
		public ec_suggest()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _from;
		private string _img;
		private string _url;
		private string _resp;
		private string _info;
		private int _add_time=0;
		private int _sort_order;
		private int _resp_time=0;
		private int _is_best=0;
		private int _status=0;
		private string _seo_title;
		private string _seo_keys;
		private string _seo_desc;
		private string _filename;
		private int _click=10;
		private int _user_id;
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
		public string from
		{
			set{ _from=value;}
			get{return _from;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string img
		{
			set{ _img=value;}
			get{return _img;}
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
		public string resp
		{
			set{ _resp=value;}
			get{return _resp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string info
		{
			set{ _info=value;}
			get{return _info;}
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
		public int resp_time
		{
			set{ _resp_time=value;}
			get{return _resp_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_best
		{
			set{ _is_best=value;}
			get{return _is_best;}
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
		/// <summary>
		/// 
		/// </summary>
		public string filename
		{
			set{ _filename=value;}
			get{return _filename;}
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
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		#endregion Model

	}
}

