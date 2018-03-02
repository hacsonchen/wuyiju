using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_config:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_config
	{
		public ec_config()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _config;
		private int _status=1;
		private int _site_id=1;
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
		public string config
		{
			set{ _config=value;}
			get{return _config;}
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
		public int site_id
		{
			set{ _site_id=value;}
			get{return _site_id;}
		}
		#endregion Model

	}
}

