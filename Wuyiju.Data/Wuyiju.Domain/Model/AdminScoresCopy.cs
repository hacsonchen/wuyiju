using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_admin_scores_copy
		public class AdminScoresCopy
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
		/// type
        /// </summary>		
		private int _type;
        public int Type
        {
            get{ return _type; }
            set{ _type = value; }
        }        
		/// <summary>
		/// score
        /// </summary>		
		private int _score;
        public int Score
        {
            get{ return _score; }
            set{ _score = value; }
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
		/// admin_id
        /// </summary>		
		private int _admin_id;
        public int Admin_Id
        {
            get{ return _admin_id; }
            set{ _admin_id = value; }
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
		/// shop_id
        /// </summary>		
		private int _shop_id;
        public int Shop_Id
        {
            get{ return _shop_id; }
            set{ _shop_id = value; }
        }        
				
		public class Query
        {

        }
   
	}
}