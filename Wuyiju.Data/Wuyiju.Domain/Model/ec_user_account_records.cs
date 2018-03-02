using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_user_account_records:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_user_account_records
	{
		public ec_user_account_records()
		{}
		#region Model
		private int _id;
		private int _user_id;
		private string _username;
		private decimal _money;
		private decimal _frozen_money;
		private decimal _balance=0.00M;
		private int _rank_points;
		private int _points;
		private int _add_time;
		private string _desc;
		private int _type;
		private int _way=1;
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
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal frozen_money
		{
			set{ _frozen_money=value;}
			get{return _frozen_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int rank_points
		{
			set{ _rank_points=value;}
			get{return _rank_points;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int points
		{
			set{ _points=value;}
			get{return _points;}
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
		public string desc
		{
			set{ _desc=value;}
			get{return _desc;}
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
		public int way
		{
			set{ _way=value;}
			get{return _way;}
		}
		#endregion Model

	}
}

