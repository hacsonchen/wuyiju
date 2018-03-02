using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_article_comments
		public class ArticleComments
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
		/// article_id
        /// </summary>		
		private int _article_id;
        public int Article_Id
        {
            get{ return _article_id; }
            set{ _article_id = value; }
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
		/// user_name
        /// </summary>		
		private string _user_name;
        public string User_Name
        {
            get{ return _user_name; }
            set{ _user_name = value; }
        }        
		/// <summary>
		/// image
        /// </summary>		
		private string _image;
        public string Image
        {
            get{ return _image; }
            set{ _image = value; }
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
		/// useful
        /// </summary>		
		private int _useful;
        public int Useful
        {
            get{ return _useful; }
            set{ _useful = value; }
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
		/// top
        /// </summary>		
		private int _top;
        public int Top
        {
            get{ return _top; }
            set{ _top = value; }
        }        
		/// <summary>
		/// reply
        /// </summary>		
		private string _reply;
        public string Reply
        {
            get{ return _reply; }
            set{ _reply = value; }
        }        
		/// <summary>
		/// reply_time
        /// </summary>		
		private int _reply_time;
        public int Reply_Time
        {
            get{ return _reply_time; }
            set{ _reply_time = value; }
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