using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_visitor
		public class Visitor
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
		/// in_time
        /// </summary>		
		private int _in_time;
        public int In_Time
        {
            get{ return _in_time; }
            set{ _in_time = value; }
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
		/// country
        /// </summary>		
		private string _country;
        public string Country
        {
            get{ return _country; }
            set{ _country = value; }
        }        
		/// <summary>
		/// province
        /// </summary>		
		private string _province;
        public string Province
        {
            get{ return _province; }
            set{ _province = value; }
        }        
		/// <summary>
		/// city
        /// </summary>		
		private string _city;
        public string City
        {
            get{ return _city; }
            set{ _city = value; }
        }        
		/// <summary>
		/// isp
        /// </summary>		
		private string _isp;
        public string Isp
        {
            get{ return _isp; }
            set{ _isp = value; }
        }        
		/// <summary>
		/// platform
        /// </summary>		
		private string _platform;
        public string Platform
        {
            get{ return _platform; }
            set{ _platform = value; }
        }        
		/// <summary>
		/// browser
        /// </summary>		
		private string _browser;
        public string Browser
        {
            get{ return _browser; }
            set{ _browser = value; }
        }        
		/// <summary>
		/// version
        /// </summary>		
		private string _version;
        public string Version
        {
            get{ return _version; }
            set{ _version = value; }
        }        
		/// <summary>
		/// entrance
        /// </summary>		
		private string _entrance;
        public string Entrance
        {
            get{ return _entrance; }
            set{ _entrance = value; }
        }        
		/// <summary>
		/// http_referer
        /// </summary>		
		private string _http_referer;
        public string Http_Referer
        {
            get{ return _http_referer; }
            set{ _http_referer = value; }
        }        
				
		public class Query
        {

        }
   
	}
}