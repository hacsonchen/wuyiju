using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_ask_reply
		public class AskReply
	{
   		     
      	/// <summary>
		/// id
        /// </summary>		
		private int _id;
        public int Id
        {
            get{ return _id; }
            set{ _id = value; }
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
		/// user_id
        /// </summary>		
		private int _user_id;
        public int User_Id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// ask_id
        /// </summary>		
		private int _ask_id;
        public int Ask_Id
        {
            get{ return _ask_id; }
            set{ _ask_id = value; }
        }        
		/// <summary>
		/// reply_time
        /// </summary>		
		private string _reply_time;
        public string Reply_Time
        {
            get{ return _reply_time; }
            set{ _reply_time = value; }
        }        
		/// <summary>
		/// enable
        /// </summary>		
		private int _enable;
        public int Enable
        {
            get{ return _enable; }
            set{ _enable = value; }
        }        
				
		public class Query
        {

        }
   
	}
}