using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_ask_reply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_ask_reply
	{
		public ec_ask_reply()
		{}
		#region Model
		private int _id;
		private string _content;
		private int _user_id=0;
		private int _ask_id=0;
		private string _reply_time= "1294245957";
		private int _enable=1;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
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
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ask_id
		{
			set{ _ask_id=value;}
			get{return _ask_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reply_time
		{
			set{ _reply_time=value;}
			get{return _reply_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int enable
		{
			set{ _enable=value;}
			get{return _enable;}
		}
		#endregion Model

	}
}

