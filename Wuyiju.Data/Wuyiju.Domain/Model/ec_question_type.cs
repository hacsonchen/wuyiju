using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_question_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_question_type
	{
		public ec_question_type()
		{}
		#region Model
		private int _id;
		private string _type_name;
		private int _amount=0;
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
		public string type_name
		{
			set{ _type_name=value;}
			get{return _type_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		#endregion Model

	}
}

