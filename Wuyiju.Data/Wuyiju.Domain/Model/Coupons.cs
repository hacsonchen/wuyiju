using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_coupons
		public class Coupons
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _coupon_id;
        public int Coupon_Id
        {
            get{ return _coupon_id; }
            set{ _coupon_id = value; }
        }        
		/// <summary>
		/// coupon_type_id
        /// </summary>		
		private int _coupon_type_id;
        public int Coupon_Type_Id
        {
            get{ return _coupon_type_id; }
            set{ _coupon_type_id = value; }
        }        
		/// <summary>
		/// coupon_sn
        /// </summary>		
		private long _coupon_sn;
        public long Coupon_Sn
        {
            get{ return _coupon_sn; }
            set{ _coupon_sn = value; }
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
		/// used_time
        /// </summary>		
		private int _used_time;
        public int Used_Time
        {
            get{ return _used_time; }
            set{ _used_time = value; }
        }        
		/// <summary>
		/// order_id
        /// </summary>		
		private int _order_id;
        public int Order_Id
        {
            get{ return _order_id; }
            set{ _order_id = value; }
        }        
		/// <summary>
		/// emailed
        /// </summary>		
		private int _emailed;
        public int Emailed
        {
            get{ return _emailed; }
            set{ _emailed = value; }
        }        
				
		public class Query
        {

        }
   
	}
}