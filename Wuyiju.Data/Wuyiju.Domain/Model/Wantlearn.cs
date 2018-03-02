using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_wantlearn
		public class Wantlearn
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
		/// user_id
        /// </summary>		
		private int _user_id;
        public int User_Id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// wl_content
        /// </summary>		
		private string _wl_content;
        public string Wl_Content
        {
            get{ return _wl_content; }
            set{ _wl_content = value; }
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
				
		public class Query
        {

        }
   
	}
}