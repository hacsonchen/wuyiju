using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_course
		public class Course
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _cid;
        public int Cid
        {
            get{ return _cid; }
            set{ _cid = value; }
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
		/// t_content
        /// </summary>		
		private string _t_content;
        public string T_Content
        {
            get{ return _t_content; }
            set{ _t_content = value; }
        }        
		/// <summary>
		/// c_time
        /// </summary>		
		private DateTime _c_time;
        public DateTime C_Time
        {
            get{ return _c_time; }
            set{ _c_time = value; }
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
		/// status
        /// </summary>		
		private int _status;
        public int Status
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// jz_time
        /// </summary>		
		private DateTime _jz_time;
        public DateTime Jz_Time
        {
            get{ return _jz_time; }
            set{ _jz_time = value; }
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
		/// t_process
        /// </summary>		
		private string _t_process;
        public string T_Process
        {
            get{ return _t_process; }
            set{ _t_process = value; }
        }        
		/// <summary>
		/// seo_title
        /// </summary>		
		private string _seo_title;
        public string Seo_Title
        {
            get{ return _seo_title; }
            set{ _seo_title = value; }
        }        
		/// <summary>
		/// seo_keys
        /// </summary>		
		private string _seo_keys;
        public string Seo_Keys
        {
            get{ return _seo_keys; }
            set{ _seo_keys = value; }
        }        
		/// <summary>
		/// seo_desc
        /// </summary>		
		private string _seo_desc;
        public string Seo_Desc
        {
            get{ return _seo_desc; }
            set{ _seo_desc = value; }
        }        
				
		public class Query
        {

        }
   
	}
}