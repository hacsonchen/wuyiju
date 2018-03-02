using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_order_user
		public class OrderUser
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
		/// order_id
        /// </summary>		
		private int _order_id;
        public int Order_Id
        {
            get{ return _order_id; }
            set{ _order_id = value; }
        }        
		/// <summary>
		/// name
        /// </summary>		
		private string _name;
        public string Name
        {
            get{ return _name; }
            set{ _name = value; }
        }        
		/// <summary>
		/// phone
        /// </summary>		
		private string _phone;
        public string Phone
        {
            get{ return _phone; }
            set{ _phone = value; }
        }        
		/// <summary>
		/// email
        /// </summary>		
		private string _email;
        public string Email
        {
            get{ return _email; }
            set{ _email = value; }
        }        
				
		public class Query
        {

        }
   
	}
}