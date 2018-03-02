using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_attribute:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_attribute
	{
		public ec_attribute()
		{}
		#region Model
		private int _id;
		private string _name;
		private int _pid=0;
		private int _level=1;
		private int _sort=1;
		private int _status=1;
		private int _input=0;
		private int _type=0;
		private int _recommend=0;
		private string _extend1;
		private string _extend2;
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
		public int pid
		{
			set{ _pid=value;}
			get{return _pid;}
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
		public int sort
		{
			set{ _sort=value;}
			get{return _sort;}
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
		public int input
		{
			set{ _input=value;}
			get{return _input;}
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
		public int recommend
		{
			set{ _recommend=value;}
			get{return _recommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string extend1
		{
			set{ _extend1=value;}
			get{return _extend1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string extend2
		{
			set{ _extend2=value;}
			get{return _extend2;}
		}
		#endregion Model

	}
}

