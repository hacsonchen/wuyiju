using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_condition
		public class Condition
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
		/// product_id
        /// </summary>		
		private int _product_id;
        public int Product_Id
        {
            get{ return _product_id; }
            set{ _product_id = value; }
        }        
		/// <summary>
		/// clicks
        /// </summary>		
		private int _clicks;
        public int Clicks
        {
            get{ return _clicks; }
            set{ _clicks = value; }
        }        
		/// <summary>
		/// visitors
        /// </summary>		
		private int _visitors;
        public int Visitors
        {
            get{ return _visitors; }
            set{ _visitors = value; }
        }        
		/// <summary>
		/// payed_num
        /// </summary>		
		private int _payed_num;
        public int Payed_Num
        {
            get{ return _payed_num; }
            set{ _payed_num = value; }
        }        
		/// <summary>
		/// buyer_num
        /// </summary>		
		private int _buyer_num;
        public int Buyer_Num
        {
            get{ return _buyer_num; }
            set{ _buyer_num = value; }
        }        
		/// <summary>
		/// kedan
        /// </summary>		
		private decimal _kedan;
        public decimal Kedan
        {
            get{ return _kedan; }
            set{ _kedan = value; }
        }        
		/// <summary>
		/// change
        /// </summary>		
		private string _change;
        public string Change
        {
            get{ return _change; }
            set{ _change = value; }
        }        
		/// <summary>
		/// total_amount
        /// </summary>		
		private decimal _total_amount;
        public decimal Total_Amount
        {
            get{ return _total_amount; }
            set{ _total_amount = value; }
        }        
		/// <summary>
		/// start_time
        /// </summary>		
		private DateTime _start_time;
        public DateTime Start_Time
        {
            get{ return _start_time; }
            set{ _start_time = value; }
        }        
		/// <summary>
		/// end_time
        /// </summary>		
		private DateTime _end_time;
        public DateTime End_Time
        {
            get{ return _end_time; }
            set{ _end_time = value; }
        }        
				
		public class Query
        {

        }
   
	}
}