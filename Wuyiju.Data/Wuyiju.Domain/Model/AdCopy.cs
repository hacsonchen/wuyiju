using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_ad_copy
		public class AdCopy
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
		/// position_id
        /// </summary>		
		private int _position_id;
        public int Position_Id
        {
            get{ return _position_id; }
            set{ _position_id = value; }
        }        
		/// <summary>
		/// type
        /// </summary>		
		private string _type;
        public string Type
        {
            get{ return _type; }
            set{ _type = value; }
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
		/// url
        /// </summary>		
		private string _url;
        public string Url
        {
            get{ return _url; }
            set{ _url = value; }
        }        
		/// <summary>
		/// thumb
        /// </summary>		
		private string _thumb;
        public string Thumb
        {
            get{ return _thumb; }
            set{ _thumb = value; }
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
		/// summary
        /// </summary>		
		private string _summary;
        public string Summary
        {
            get{ return _summary; }
            set{ _summary = value; }
        }        
		/// <summary>
		/// discription
        /// </summary>		
		private string _discription;
        public string Discription
        {
            get{ return _discription; }
            set{ _discription = value; }
        }        
		/// <summary>
		/// start_time
        /// </summary>		
		private int _start_time;
        public int Start_Time
        {
            get{ return _start_time; }
            set{ _start_time = value; }
        }        
		/// <summary>
		/// end_time
        /// </summary>		
		private int _end_time;
        public int End_Time
        {
            get{ return _end_time; }
            set{ _end_time = value; }
        }        
		/// <summary>
		/// clicks
        /// </summary>		
		private int _clicks;
        public int Clicks
        {
            get{ return _clicks; }
            set{ _clicks = value; }
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
		/// sort_order
        /// </summary>		
		private int _sort_order;
        public int Sort_Order
        {
            get{ return _sort_order; }
            set{ _sort_order = value; }
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
		/// ad_type
        /// </summary>		
		private string _ad_type;
        public string Ad_Type
        {
            get{ return _ad_type; }
            set{ _ad_type = value; }
        }        
				
		public class Query
        {

        }
   
	}
}