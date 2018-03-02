using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_sms
		public class Sms
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
		/// mobile
        /// </summary>		
		private string _mobile;
        public string Mobile
        {
            get{ return _mobile; }
            set{ _mobile = value; }
        }        
		/// <summary>
		/// validateCode
        /// </summary>		
		private string _validatecode;
        public string Validatecode
        {
            get{ return _validatecode; }
            set{ _validatecode = value; }
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