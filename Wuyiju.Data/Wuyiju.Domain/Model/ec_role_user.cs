using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_role_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_role_user
	{
		public ec_role_user()
		{}
		#region Model
		private int _role_id;
		private int _user_id;
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
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		#endregion Model

	}
}

