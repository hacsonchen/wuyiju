using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_favorites:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_favorites
	{
		public ec_favorites()
		{}
		#region Model
		private int _rec_id;
		private int _user_id;
		private int _product_id;
		private int _add_time=0;
		private int _type=0;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int rec_id
		{
			set{ _rec_id=value;}
			get{return _rec_id;}
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
		public int product_id
		{
			set{ _product_id=value;}
			get{return _product_id;}
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
		public int type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}

