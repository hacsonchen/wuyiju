using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_product_attr:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_product_attr
	{
		public ec_product_attr()
		{}
		#region Model
		private int _id;
		private int _product_id=0;
		private int _attr_pid=0;
		private int? _attr_id;
		private string _attr_value;
		private int _input=0;
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
		public int attr_pid
		{
			set{ _attr_pid=value;}
			get{return _attr_pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? attr_id
		{
			set{ _attr_id=value;}
			get{return _attr_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string attr_value
		{
			set{ _attr_value=value;}
			get{return _attr_value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int input
		{
			set{ _input=value;}
			get{return _input;}
		}
		#endregion Model

	}
}

