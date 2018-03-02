using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Wuyiju.Domain.View;
namespace Wuyiju.Model{
	 	//ec_message
		public class Message
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
		/// userid
        /// </summary>		
		private int _userid;
        public int Userid
        {
            get{ return _userid; }
            set{ _userid = value; }
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
		/// name
        /// </summary>		
		private string _name;
        public string Name
        {
            get{ return _name; }
            set{ _name = value; }
        }        
		/// <summary>
		/// mail
        /// </summary>		
		private string _mail;
        public string Mail
        {
            get{ return _mail; }
            set{ _mail = value; }
        }        
		/// <summary>
		/// message
        /// </summary>		
		private string _message;
        public string message
        {
            get{ return _message; }
            set{ _message = value; }
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

        public string Ip_str
        {
            get {
                System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse(_ip.ToString());
                return ipaddress.ToString();
            }
        }
        /// <summary>
        /// time
        /// </summary>		
        private long _time;
        public long Time
        {
            get{ return _time; }
            set{ _time = value; }
        }

        public string Time_s
        {
            get
            {
                Time time = new Time();
                return time.GetTime(_time.ToString()).ToString();
            }
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
		/// admin
        /// </summary>		
		private int _admin;
        public int Admin
        {
            get{ return _admin; }
            set{ _admin = value; }
        }        
		/// <summary>
		/// mobile
        /// </summary>		
		private string _mobile;
        public string Mobile
        {
            get{ return _mobile; }
            set{ _mobile = value; }
        }        
		/// <summary>
		/// qq
        /// </summary>		
		private string _qq;
        public string Qq
        {
            get{ return _qq; }
            set{ _qq = value; }
        }        
		/// <summary>
		/// msgtitle
        /// </summary>		
		private string _msgtitle;
        public string Msgtitle
        {
            get{ return _msgtitle; }
            set{ _msgtitle = value; }
        }        
				
		public class Query
        {

        }
   
	}
}