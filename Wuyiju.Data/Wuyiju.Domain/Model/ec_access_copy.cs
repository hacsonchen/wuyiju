using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_access_copy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_access_copy
	{
		public ec_access_copy()
		{}
		#region Model
		private int _role_id;
		private int _node_id;
		private int _level;
		private string _module;
		/// <summary>
		/// 
		/// </summary>
		public int role_id
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int node_id
		{
			set{ _node_id=value;}
			get{return _node_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string module
		{
			set{ _module=value;}
			get{return _module;}
		}
		#endregion Model

	}
}

