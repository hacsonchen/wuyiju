using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_sms:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_sms
	{
		public ec_sms()
		{}
		#region Model
		private int _id;
		private string _mobile;
		private string _validatecode;
		private int _add_time;
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
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string validateCode
		{
			set{ _validatecode=value;}
			get{return _validatecode;}
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

