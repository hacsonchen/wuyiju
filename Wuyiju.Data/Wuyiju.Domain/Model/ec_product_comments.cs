using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_product_comments:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_product_comments
	{
		public ec_product_comments()
		{}
		#region Model
		private int _id;
		private int _product_id=0;
		private int _user_id=0;
		private string _user_name;
		private string _content;
		private int _useful=0;
		private int _status=1;
		private int _top=0;
		private int _star01=0;
		private int _star02=0;
		private int _star03=0;
		private string _reply;
		private int _add_time=0;
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
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
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
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int useful
		{
			set{ _useful=value;}
			get{return _useful;}
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
		public int top
		{
			set{ _top=value;}
			get{return _top;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int star01
		{
			set{ _star01=value;}
			get{return _star01;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int star02
		{
			set{ _star02=value;}
			get{return _star02;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int star03
		{
			set{ _star03=value;}
			get{return _star03;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reply
		{
			set{ _reply=value;}
			get{return _reply;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		#endregion Model

	}
}

