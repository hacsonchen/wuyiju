using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_payment
		public class Payment
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _pay_id;
        public int Pay_Id
        {
            get{ return _pay_id; }
            set{ _pay_id = value; }
        }        
		/// <summary>
		/// pay_name
        /// </summary>		
		private string _pay_name;
        public string Pay_Name
        {
            get{ return _pay_name; }
            set{ _pay_name = value; }
        }        
		/// <summary>
		/// pay_code
        /// </summary>		
		private string _pay_code;
        public string Pay_Code
        {
            get{ return _pay_code; }
            set{ _pay_code = value; }
        }        
		/// <summary>
		/// pay_desc
        /// </summary>		
		private string _pay_desc;
        public string Pay_Desc
        {
            get{ return _pay_desc; }
            set{ _pay_desc = value; }
        }        
		/// <summary>
		/// pay_logo
        /// </summary>		
		private string _pay_logo;
        public string Pay_Logo
        {
            get{ return _pay_logo; }
            set{ _pay_logo = value; }
        }        
		/// <summary>
		/// enabled
        /// </summary>		
		private int _enabled;
        public int Enabled
        {
            get{ return _enabled; }
            set{ _enabled = value; }
        }        
		/// <summary>
		/// pay_order
        /// </summary>		
		private int _pay_order;
        public int Pay_Order
        {
            get{ return _pay_order; }
            set{ _pay_order = value; }
        }        
		/// <summary>
		/// pay_content
        /// </summary>		
		private string _pay_content;
        public string Pay_Content
        {
            get{ return _pay_content; }
            set{ _pay_content = value; }
        }        
		/// <summary>
		/// pay_fee
        /// </summary>		
		private decimal _pay_fee;
        public decimal Pay_Fee
        {
            get{ return _pay_fee; }
            set{ _pay_fee = value; }
        }        
		/// <summary>
		/// partner_id
        /// </summary>		
		private string _partner_id;
        public string Partner_Id
        {
            get{ return _partner_id; }
            set{ _partner_id = value; }
        }        
		/// <summary>
		/// partner_key
        /// </summary>		
		private string _partner_key;
        public string Partner_Key
        {
            get{ return _partner_key; }
            set{ _partner_key = value; }
        }        
		/// <summary>
		/// is_online
        /// </summary>		
		private int _is_online;
        public int Is_Online
        {
            get{ return _is_online; }
            set{ _is_online = value; }
        }        
				
		public class Query
        {

        }
   
	}
}