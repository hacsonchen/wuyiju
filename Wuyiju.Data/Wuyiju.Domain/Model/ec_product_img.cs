using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_product_img:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_product_img
	{
		public ec_product_img()
		{}
		#region Model
		private int _id;
		private int _product_id;
		private string _title;
		private string _thumb;
		private string _picture;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
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
		public string picture
		{
			set{ _picture=value;}
			get{return _picture;}
		}
		#endregion Model

	}
}

