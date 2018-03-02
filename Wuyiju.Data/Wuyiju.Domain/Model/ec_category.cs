using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_category:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_category
	{
		public ec_category()
		{}
		#region Model
		private int _id;
		private int _type=1;
		private int _parent_id;
		private string _name;
		private string _brief;
		private string _seo_title;
		private string _seo_keys;
		private string _seo_desc;
		private string _img;
		private int _sort=0;
		private int _status=1;
		private int _is_hot=0;
		private int _is_recommend=0;
		private int _show_in_nav=0;
		private int _bank_id=0;
		private int _is_extend=0;
		private string _filter_attr= "0";
		private int _add_time=0;
		private int _admin_id=0;
		private int _is_del=0;
		private string _css_cla;
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
		public int type
		{
			set{ _type=value;}
			get{return _type;}
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string img
		{
			set{ _img=value;}
			get{return _img;}
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
		public int is_hot
		{
			set{ _is_hot=value;}
			get{return _is_hot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_recommend
		{
			set{ _is_recommend=value;}
			get{return _is_recommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int show_in_nav
		{
			set{ _show_in_nav=value;}
			get{return _show_in_nav;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int bank_id
		{
			set{ _bank_id=value;}
			get{return _bank_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_extend
		{
			set{ _is_extend=value;}
			get{return _is_extend;}
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
		public int add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int admin_id
		{
			set{ _admin_id=value;}
			get{return _admin_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_del
		{
			set{ _is_del=value;}
			get{return _is_del;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string css_cla
		{
			set{ _css_cla=value;}
			get{return _css_cla;}
		}
		#endregion Model

	}
}

