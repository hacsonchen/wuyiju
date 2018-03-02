using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_buy
		public class Buy
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _id;
        public int Id
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// title
        /// </summary>		
		private string _title;
        public string Title
        {
            get{ return _title; }
            set{ _title = value; }
        }        
		/// <summary>
		/// sn
        /// </summary>		
		private string _sn;
        public string Sn
        {
            get{ return _sn; }
            set{ _sn = value; }
        }        
		/// <summary>
		/// brief
        /// </summary>		
		private string _brief;
        public string Brief
        {
            get{ return _brief; }
            set{ _brief = value; }
        }        
		/// <summary>
		/// cate_id
        /// </summary>		
		private int _cate_id;
        public int Cate_Id
        {
            get{ return _cate_id; }
            set{ _cate_id = value; }
        }        
		/// <summary>
		/// type
        /// </summary>		
		private int _type;
        public int Type
        {
            get{ return _type; }
            set{ _type = value; }
        }        
		/// <summary>
		/// level
        /// </summary>		
		private int _level;
        public int Level
        {
            get{ return _level; }
            set{ _level = value; }
        }        
		/// <summary>
		/// level_child
        /// </summary>		
		private int _level_child;
        public int Level_Child
        {
            get{ return _level_child; }
            set{ _level_child = value; }
        }        
		/// <summary>
		/// detail
        /// </summary>		
		private string _detail;
        public string Detail
        {
            get{ return _detail; }
            set{ _detail = value; }
        }        
		/// <summary>
		/// start_price
        /// </summary>		
		private decimal _start_price;
        public decimal Start_Price
        {
            get{ return _start_price; }
            set{ _start_price = value; }
        }        
		/// <summary>
		/// end_price
        /// </summary>		
		private decimal _end_price;
        public decimal End_Price
        {
            get{ return _end_price; }
            set{ _end_price = value; }
        }        
		/// <summary>
		/// validDay
        /// </summary>		
		private int _validday;
        public int Validday
        {
            get{ return _validday; }
            set{ _validday = value; }
        }        
		/// <summary>
		/// stocks
        /// </summary>		
		private int _stocks;
        public int Stocks
        {
            get{ return _stocks; }
            set{ _stocks = value; }
        }        
		/// <summary>
		/// status
        /// </summary>		
		private int _status;
        public int Status
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// v_status
        /// </summary>		
		private int _v_status;
        public int V_Status
        {
            get{ return _v_status; }
            set{ _v_status = value; }
        }        
		/// <summary>
		/// p_status
        /// </summary>		
		private int _p_status;
        public int P_Status
        {
            get{ return _p_status; }
            set{ _p_status = value; }
        }        
		/// <summary>
		/// remark
        /// </summary>		
		private string _remark;
        public string Remark
        {
            get{ return _remark; }
            set{ _remark = value; }
        }        
		/// <summary>
		/// qq
        /// </summary>		
		private string _qq;
        public string Qq
        {
            get{ return _qq; }
            set{ _qq = value; }
        }        
		/// <summary>
		/// user_name
        /// </summary>		
		private string _user_name;
        public string User_Name
        {
            get{ return _user_name; }
            set{ _user_name = value; }
        }        
		/// <summary>
		/// mobile
        /// </summary>		
		private string _mobile;
        public string Mobile
        {
            get{ return _mobile; }
            set{ _mobile = value; }
        }        
		/// <summary>
		/// good_rating
        /// </summary>		
		private decimal _good_rating;
        public decimal Good_Rating
        {
            get{ return _good_rating; }
            set{ _good_rating = value; }
        }        
		/// <summary>
		/// user_id
        /// </summary>		
		private int _user_id;
        public int User_Id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// rating
        /// </summary>		
		private decimal _rating;
        public decimal Rating
        {
            get{ return _rating; }
            set{ _rating = value; }
        }        
		/// <summary>
		/// add_time
        /// </summary>		
		private long _add_time;
        public long Add_Time
        {
            get{ return _add_time; }
            set{ _add_time = value; }
        }        
		/// <summary>
		/// created
        /// </summary>		
		private int _created;
        public int Created
        {
            get{ return _created; }
            set{ _created = value; }
        }        
		/// <summary>
		/// credentials
        /// </summary>		
		private string _credentials;
        public string Credentials
        {
            get{ return _credentials; }
            set{ _credentials = value; }
        }        
		/// <summary>
		/// click
        /// </summary>		
		private int _click;
        public int Click
        {
            get{ return _click; }
            set{ _click = value; }
        }        
		/// <summary>
		/// role_id
        /// </summary>		
		private int _role_id;
        public int Role_Id
        {
            get{ return _role_id; }
            set{ _role_id = value; }
        }        
		/// <summary>
		/// admin_id
        /// </summary>		
		private int _admin_id;
        public int Admin_Id
        {
            get{ return _admin_id; }
            set{ _admin_id = value; }
        }        
				
		public class Query
        {

        }
   
	}
}