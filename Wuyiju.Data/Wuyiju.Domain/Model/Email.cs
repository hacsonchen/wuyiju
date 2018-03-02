using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_email
		public class Email
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
		/// email
        /// </summary>		
		private string _email;
        public string email
        {
            get{ return _email; }
            set{ _email = value; }
        }        
		/// <summary>
		/// code
        /// </summary>		
		private string _code;
        public string Code
        {
            get{ return _code; }
            set{ _code = value; }
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
		/// user_id
        /// </summary>		
		private int _user_id;
        public int User_Id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// is_used
        /// </summary>		
		private int _is_used;
        public int Is_Used
        {
            get{ return _is_used; }
            set{ _is_used = value; }
        }        
				
		public class Query
        {

        }
   
	}
}