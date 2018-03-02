using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_complaint:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_complaint
	{
		public ec_complaint()
		{}
		#region Model
		private int _id;
		private int _uid;
		private string _tszname;
		private string _tszmobile;
		private string _tszqq;
		private string _ywname;
		private string _body;
		private string _tspic1;
		private int _add_time=0;
		private int _resp_time=0;
		private int _click=0;
		private int _anonmity=0;
		private string _savepath;
		private string _resp;
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
		public int uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tszname
		{
			set{ _tszname=value;}
			get{return _tszname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tszmobile
		{
			set{ _tszmobile=value;}
			get{return _tszmobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tszqq
		{
			set{ _tszqq=value;}
			get{return _tszqq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ywname
		{
			set{ _ywname=value;}
			get{return _ywname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string body
		{
			set{ _body=value;}
			get{return _body;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tspic1
		{
			set{ _tspic1=value;}
			get{return _tspic1;}
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
		public int resp_time
		{
			set{ _resp_time=value;}
			get{return _resp_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int click
		{
			set{ _click=value;}
			get{return _click;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int anonmity
		{
			set{ _anonmity=value;}
			get{return _anonmity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string savepath
		{
			set{ _savepath=value;}
			get{return _savepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string resp
		{
			set{ _resp=value;}
			get{return _resp;}
		}
		#endregion Model

	}
}

