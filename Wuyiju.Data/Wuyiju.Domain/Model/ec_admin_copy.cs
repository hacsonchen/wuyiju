using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_admin_copy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_admin_copy
	{
		public ec_admin_copy()
		{}
		#region Model
		private int _id;
		private string _username= "0";
		private string _name= "0";
		private string _password= "void";
		private int _sex=1;
		private int _status=1;
		private string _email= "void";
		private string _valicode= "void";
		private int _pre_login_time=1377677435;
		private int _login_time=1377677435;
		private int _pre_login_ip=2130706433;
		private int _login_ip=2130706433;
		private int _login_nums=0;
		private int _uid=0;
		private string _position;
		private int _parent_id=0;
		private string _photo_img;
		private string _job_number;
		private string _qq;
		private string _phone;
		private string _mobile;
		private decimal _score=0.0M;
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
		public string username
		{
			set{ _username=value;}
			get{return _username;}
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
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sex
		{
			set{ _sex=value;}
			get{return _sex;}
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
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string valicode
		{
			set{ _valicode=value;}
			get{return _valicode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pre_login_time
		{
			set{ _pre_login_time=value;}
			get{return _pre_login_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int login_time
		{
			set{ _login_time=value;}
			get{return _login_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pre_login_ip
		{
			set{ _pre_login_ip=value;}
			get{return _pre_login_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int login_ip
		{
			set{ _login_ip=value;}
			get{return _login_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int login_nums
		{
			set{ _login_nums=value;}
			get{return _login_nums;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string position
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string photo_img
		{
			set{ _photo_img=value;}
			get{return _photo_img;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string job_number
		{
			set{ _job_number=value;}
			get{return _job_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		public decimal score
		{
			set{ _score=value;}
			get{return _score;}
		}
		#endregion Model

	}
}

