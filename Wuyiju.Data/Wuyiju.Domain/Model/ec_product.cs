using System;
namespace wuyiju.Model
{
	/// <summary>
	/// ec_product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ec_product
	{
		public ec_product()
		{}
		#region Model
		private int _id;
		private int _admin_id=0;
		private string _name;
		private string _subname;
		private string _sn;
		private int _category_id=0;
		private decimal _market_price=0.00M;
		private decimal _price=0.00M;
		private decimal _member_price=0.00M;
		private decimal _promote_price=0.00M;
		private string _intro;
		private int _integration=0;
		private int _integration_buy=0;
		private int _promote=0;
		private int _promote_start=0;
		private int _promote_end=0;
		private int _recommend=0;
		private int _click=0;
		private int _stock=0;
		private int _pay_status=0;
		private int _warn_nums=-1;
		private int _sales=0;
		private int _status=1;
		private int _hot=0;
		private int _new=1;
		private int _best=0;
		private int _sort=1;
		private string _keywords;
		private string _seo_title;
		private string _seo_keys;
		private string _seo_desc;
		private string _brief;
		private string _content;
		private string _url;
		private int _address_id=0;
		private int _buyer_id=0;
		private int _add_time=0;
		private int _start_time=0;
		private string _picture;
		private string _log;
		private int _del_time=0;
		private string _filename;
		private int _seller_id=0;
		private decimal _user_return=0.00M;
		private int _type=0;
		private string _video;
		private decimal _praise_rate=0.00M;
		private int _collection_popularity=0;
		private int _seller_credit=0;
		private decimal _annual_turnover=0.00M;
		private decimal _protection_deposit=0.00M;
		private decimal _tech_fee=20000.00M;
		private int _whether_goods=0;
		private string _buyer_protection;
		private decimal _virtual_proportion=0.00M;
		private int _old_customer_number=0;
		private string _area;
		private int _mall_type;
		private int _trademark_type;
		private int _trademark_no;
		private int _tax_qualification;
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
		public int admin_id
		{
			set{ _admin_id=value;}
			get{return _admin_id;}
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
		public string subname
		{
			set{ _subname=value;}
			get{return _subname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sn
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int category_id
		{
			set{ _category_id=value;}
			get{return _category_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal market_price
		{
			set{ _market_price=value;}
			get{return _market_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal member_price
		{
			set{ _member_price=value;}
			get{return _member_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal promote_price
		{
			set{ _promote_price=value;}
			get{return _promote_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string intro
		{
			set{ _intro=value;}
			get{return _intro;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int integration
		{
			set{ _integration=value;}
			get{return _integration;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int integration_buy
		{
			set{ _integration_buy=value;}
			get{return _integration_buy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int promote
		{
			set{ _promote=value;}
			get{return _promote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int promote_start
		{
			set{ _promote_start=value;}
			get{return _promote_start;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int promote_end
		{
			set{ _promote_end=value;}
			get{return _promote_end;}
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
		public int click
		{
			set{ _click=value;}
			get{return _click;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pay_status
		{
			set{ _pay_status=value;}
			get{return _pay_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int warn_nums
		{
			set{ _warn_nums=value;}
			get{return _warn_nums;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sales
		{
			set{ _sales=value;}
			get{return _sales;}
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
		public int hot
		{
			set{ _hot=value;}
			get{return _hot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int New
		{
			set{ _new=value;}
			get{return _new;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int best
		{
			set{ _best=value;}
			get{return _best;}
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
		public string keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seo_title
		{
			set{ _seo_title=value;}
			get{return _seo_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seo_keys
		{
			set{ _seo_keys=value;}
			get{return _seo_keys;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seo_desc
		{
			set{ _seo_desc=value;}
			get{return _seo_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string brief
		{
			set{ _brief=value;}
			get{return _brief;}
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
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int address_id
		{
			set{ _address_id=value;}
			get{return _address_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int buyer_id
		{
			set{ _buyer_id=value;}
			get{return _buyer_id;}
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
		public int start_time
		{
			set{ _start_time=value;}
			get{return _start_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picture
		{
			set{ _picture=value;}
			get{return _picture;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string log
		{
			set{ _log=value;}
			get{return _log;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int del_time
		{
			set{ _del_time=value;}
			get{return _del_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string filename
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int seller_id
		{
			set{ _seller_id=value;}
			get{return _seller_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal user_return
		{
			set{ _user_return=value;}
			get{return _user_return;}
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
		public string video
		{
			set{ _video=value;}
			get{return _video;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal praise_rate
		{
			set{ _praise_rate=value;}
			get{return _praise_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int collection_popularity
		{
			set{ _collection_popularity=value;}
			get{return _collection_popularity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int seller_credit
		{
			set{ _seller_credit=value;}
			get{return _seller_credit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal annual_turnover
		{
			set{ _annual_turnover=value;}
			get{return _annual_turnover;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal protection_deposit
		{
			set{ _protection_deposit=value;}
			get{return _protection_deposit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal tech_fee
		{
			set{ _tech_fee=value;}
			get{return _tech_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int whether_goods
		{
			set{ _whether_goods=value;}
			get{return _whether_goods;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string buyer_protection
		{
			set{ _buyer_protection=value;}
			get{return _buyer_protection;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal virtual_proportion
		{
			set{ _virtual_proportion=value;}
			get{return _virtual_proportion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int old_customer_number
		{
			set{ _old_customer_number=value;}
			get{return _old_customer_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mall_type
		{
			set{ _mall_type=value;}
			get{return _mall_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int trademark_type
		{
			set{ _trademark_type=value;}
			get{return _trademark_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int trademark_no
		{
			set{ _trademark_no=value;}
			get{return _trademark_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tax_qualification
		{
			set{ _tax_qualification=value;}
			get{return _tax_qualification;}
		}
		#endregion Model

	}
}

