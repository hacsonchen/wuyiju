using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_buy_action:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_buy_action
	{
		public ec_buy_action()
		{}
		#region Model
		private int _id;
		private int _type=0;
		private int _buy_id=0;
		private int _admin_id=0;
		private string _admin_name;
		private int _status=0;
		private int _v_status=0;
		private int _add_time=0;
		private string _content;
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
		public int buy_id
		{
			set{ _buy_id=value;}
			get{return _buy_id;}
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
		public string admin_name
		{
			set{ _admin_name=value;}
			get{return _admin_name;}
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
		public int v_status
		{
			set{ _v_status=value;}
			get{return _v_status;}
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
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		#endregion Model

	}
}

