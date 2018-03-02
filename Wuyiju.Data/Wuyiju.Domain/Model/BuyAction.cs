using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_buy_action
		public class BuyAction
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
		/// buy_id
        /// </summary>		
		private int _buy_id;
        public int Buy_Id
        {
            get{ return _buy_id; }
            set{ _buy_id = value; }
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
		/// admin_name
        /// </summary>		
		private string _admin_name;
        public string Admin_Name
        {
            get{ return _admin_name; }
            set{ _admin_name = value; }
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
		/// v_status
        /// </summary>		
		private int _v_status;
        public int V_Status
        {
            get{ return _v_status; }
            set{ _v_status = value; }
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
		/// content
        /// </summary>		
		private string _content;
        public string Content
        {
            get{ return _content; }
            set{ _content = value; }
        }        
				
		public class Query
        {

        }
   
	}
}