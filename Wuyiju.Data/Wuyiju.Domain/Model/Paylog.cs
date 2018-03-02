using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_paylog
		public class Paylog
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _log_id;
        public int Log_Id
        {
            get{ return _log_id; }
            set{ _log_id = value; }
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
		/// amount
        /// </summary>		
		private decimal _amount;
        public decimal Amount
        {
            get{ return _amount; }
            set{ _amount = value; }
        }        
		/// <summary>
		/// order_type
        /// </summary>		
		private int _order_type;
        public int Order_Type
        {
            get{ return _order_type; }
            set{ _order_type = value; }
        }        
		/// <summary>
		/// is_paid
        /// </summary>		
		private int _is_paid;
        public int Is_Paid
        {
            get{ return _is_paid; }
            set{ _is_paid = value; }
        }        
				
		public class Query
        {

        }
   
	}
}