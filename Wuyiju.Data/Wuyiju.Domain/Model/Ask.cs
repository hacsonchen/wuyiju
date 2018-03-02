using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_ask
		public class Ask
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
		/// user_id
        /// </summary>		
		private int _user_id;
        public int User_Id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// username
        /// </summary>		
		private string _username;
        public string Username
        {
            get{ return _username; }
            set{ _username = value; }
        }        
		/// <summary>
		/// ip
        /// </summary>		
		private int _ip;
        public int Ip
        {
            get{ return _ip; }
            set{ _ip = value; }
        }        
		/// <summary>
		/// time
        /// </summary>		
		private int _time;
        public int Time
        {
            get{ return _time; }
            set{ _time = value; }
        }        
		/// <summary>
		/// update_time
        /// </summary>		
		private int _update_time;
        public int Update_Time
        {
            get{ return _update_time; }
            set{ _update_time = value; }
        }        
		/// <summary>
		/// content
        /// </summary>		
		private string _content;
        public string Content
        {
            get{ return _content; }
            set{ _content = value; }
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
		/// replay
        /// </summary>		
		private int _replay;
        public int Replay
        {
            get{ return _replay; }
            set{ _replay = value; }
        }        
		/// <summary>
		/// pid
        /// </summary>		
		private int _pid;
        public int Pid
        {
            get{ return _pid; }
            set{ _pid = value; }
        }        
		/// <summary>
		/// is_user
        /// </summary>		
		private int _is_user;
        public int Is_User
        {
            get{ return _is_user; }
            set{ _is_user = value; }
        }        
				
		public class Query
        {

        }
   
	}
}