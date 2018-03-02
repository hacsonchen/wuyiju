using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_product_comments
		public class ProductComments
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
		/// user_name
        /// </summary>		
		private string _user_name;
        public string User_Name
        {
            get{ return _user_name; }
            set{ _user_name = value; }
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
		/// star01
        /// </summary>		
		private int _star01;
        public int Star01
        {
            get{ return _star01; }
            set{ _star01 = value; }
        }        
		/// <summary>
		/// star02
        /// </summary>		
		private int _star02;
        public int Star02
        {
            get{ return _star02; }
            set{ _star02 = value; }
        }        
		/// <summary>
		/// star03
        /// </summary>		
		private int _star03;
        public int Star03
        {
            get{ return _star03; }
            set{ _star03 = value; }
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