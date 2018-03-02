using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_title:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_title
	{
		public ec_title()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _scname;
		private string _img;
		private int _parent_id=0;
		private int _sort=0;
		private int _status=1;
		private int _recommend=0;
		private string _color;
		private string _seo_title;
		private string _seo_keys;
		private string _seo_desc;
		private string _brief;
		private string _content;
		private string _style_file;
		private string _show_in_nav= "0";
		private string _filter_attr;
		private string _folder;
		private string _filename;
		private int _type=0;
		private int _is_hots=0;
		private int _url_type=0;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scname
		{
			set{ _scname=value;}
			get{return _scname;}
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
		public int parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sort
		{
			set{ _sort=value;}
			get{return _sort;}
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
		public int recommend
		{
			set{ _recommend=value;}
			get{return _recommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string color
		{
			set{ _color=value;}
			get{return _color;}
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
		public string brief
		{
			set{ _brief=value;}
			get{return _brief;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string style_file
		{
			set{ _style_file=value;}
			get{return _style_file;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string show_in_nav
		{
			set{ _show_in_nav=value;}
			get{return _show_in_nav;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string filter_attr
		{
			set{ _filter_attr=value;}
			get{return _filter_attr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string folder
		{
			set{ _folder=value;}
			get{return _folder;}
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
		public int type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_hots
		{
			set{ _is_hots=value;}
			get{return _is_hots;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int url_type
		{
			set{ _url_type=value;}
			get{return _url_type;}
		}
		#endregion Model

	}
}

