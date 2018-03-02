using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_coupons_type
		public class CouponsType
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _type_id;
        public int Type_Id
        {
            get{ return _type_id; }
            set{ _type_id = value; }
        }        
		/// <summary>
		/// type_name
        /// </summary>		
		private string _type_name;
        public string Type_Name
        {
            get{ return _type_name; }
            set{ _type_name = value; }
        }        
		/// <summary>
		/// type_money
        /// </summary>		
		private decimal _type_money;
        public decimal Type_Money
        {
            get{ return _type_money; }
            set{ _type_money = value; }
        }        
		/// <summary>
		/// send_type
        /// </summary>		
		private int _send_type;
        public int Send_Type
        {
            get{ return _send_type; }
            set{ _send_type = value; }
        }        
		/// <summary>
		/// min_amount
        /// </summary>		
		private decimal _min_amount;
        public decimal Min_Amount
        {
            get{ return _min_amount; }
            set{ _min_amount = value; }
        }        
		/// <summary>
		/// max_amount
        /// </summary>		
		private decimal _max_amount;
        public decimal Max_Amount
        {
            get{ return _max_amount; }
            set{ _max_amount = value; }
        }        
		/// <summary>
		/// send_start_date
        /// </summary>		
		private int _send_start_date;
        public int Send_Start_Date
        {
            get{ return _send_start_date; }
            set{ _send_start_date = value; }
        }        
		/// <summary>
		/// send_end_date
        /// </summary>		
		private int _send_end_date;
        public int Send_End_Date
        {
            get{ return _send_end_date; }
            set{ _send_end_date = value; }
        }        
		/// <summary>
		/// use_start_date
        /// </summary>		
		private int _use_start_date;
        public int Use_Start_Date
        {
            get{ return _use_start_date; }
            set{ _use_start_date = value; }
        }        
		/// <summary>
		/// use_end_date
        /// </summary>		
		private int _use_end_date;
        public int Use_End_Date
        {
            get{ return _use_end_date; }
            set{ _use_end_date = value; }
        }        
		/// <summary>
		/// min_product_amount
        /// </summary>		
		private decimal _min_product_amount;
        public decimal Min_Product_Amount
        {
            get{ return _min_product_amount; }
            set{ _min_product_amount = value; }
        }        
		/// <summary>
		/// coupon_img
        /// </summary>		
		private string _coupon_img;
        public string Coupon_Img
        {
            get{ return _coupon_img; }
            set{ _coupon_img = value; }
        }        
		/// <summary>
		/// points_exchange
        /// </summary>		
		private int _points_exchange;
        public int Points_Exchange
        {
            get{ return _points_exchange; }
            set{ _points_exchange = value; }
        }        
				
		public class Query
        {

        }
   
	}
}