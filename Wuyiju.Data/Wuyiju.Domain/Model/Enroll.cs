using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_enroll
		public class Enroll
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
		/// cid
        /// </summary>		
		private int _cid;
        public int Cid
        {
            get{ return _cid; }
            set{ _cid = value; }
        }        
		/// <summary>
		/// c_time
        /// </summary>		
		private string _c_time;
        public string C_Time
        {
            get{ return _c_time; }
            set{ _c_time = value; }
        }        
		/// <summary>
		/// c_name
        /// </summary>		
		private string _c_name;
        public string C_Name
        {
            get{ return _c_name; }
            set{ _c_name = value; }
        }        
		/// <summary>
		/// t_name
        /// </summary>		
		private string _t_name;
        public string T_Name
        {
            get{ return _t_name; }
            set{ _t_name = value; }
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