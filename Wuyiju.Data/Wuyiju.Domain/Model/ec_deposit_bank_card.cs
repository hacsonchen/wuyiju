using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_deposit_bank_card:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_deposit_bank_card
	{
		public ec_deposit_bank_card()
		{}
		#region Model
		private int _id;
		private int _user_id;
		private string _real_name;
		private int _region_lv1;
		private int _region_lv2;
		private int _region_lv3;
		private string _bank_name;
		private string _bank_subname;
		private string _card_number;
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
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string real_name
		{
			set{ _real_name=value;}
			get{return _real_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int region_lv1
		{
			set{ _region_lv1=value;}
			get{return _region_lv1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int region_lv2
		{
			set{ _region_lv2=value;}
			get{return _region_lv2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int region_lv3
		{
			set{ _region_lv3=value;}
			get{return _region_lv3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bank_name
		{
			set{ _bank_name=value;}
			get{return _bank_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bank_subname
		{
			set{ _bank_subname=value;}
			get{return _bank_subname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card_number
		{
			set{ _card_number=value;}
			get{return _card_number;}
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

