using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_admin_copy
		public class AdminCopy
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
		/// username
        /// </summary>		
		private string _username;
        public string Username
        {
            get{ return _username; }
            set{ _username = value; }
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
		/// password
        /// </summary>		
		private string _password;
        public string Password
        {
            get{ return _password; }
            set{ _password = value; }
        }        
		/// <summary>
		/// sex
        /// </summary>		
		private int _sex;
        public int Sex
        {
            get{ return _sex; }
            set{ _sex = value; }
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
		/// email
        /// </summary>		
		private string _email;
        public string Email
        {
            get{ return _email; }
            set{ _email = value; }
        }        
		/// <summary>
		/// valicode
        /// </summary>		
		private string _valicode;
        public string Valicode
        {
            get{ return _valicode; }
            set{ _valicode = value; }
        }        
		/// <summary>
		/// pre_login_time
        /// </summary>		
		private int _pre_login_time;
        public int Pre_Login_Time
        {
            get{ return _pre_login_time; }
            set{ _pre_login_time = value; }
        }        
		/// <summary>
		/// login_time
        /// </summary>		
		private int _login_time;
        public int Login_Time
        {
            get{ return _login_time; }
            set{ _login_time = value; }
        }        
		/// <summary>
		/// pre_login_ip
        /// </summary>		
		private int _pre_login_ip;
        public int Pre_Login_Ip
        {
            get{ return _pre_login_ip; }
            set{ _pre_login_ip = value; }
        }        
		/// <summary>
		/// login_ip
        /// </summary>		
		private int _login_ip;
        public int Login_Ip
        {
            get{ return _login_ip; }
            set{ _login_ip = value; }
        }        
		/// <summary>
		/// login_nums
        /// </summary>		
		private int _login_nums;
        public int Login_Nums
        {
            get{ return _login_nums; }
            set{ _login_nums = value; }
        }        
		/// <summary>
		/// uid
        /// </summary>		
		private int _uid;
        public int Uid
        {
            get{ return _uid; }
            set{ _uid = value; }
        }        
		/// <summary>
		/// position
        /// </summary>		
		private string _position;
        public string Position
        {
            get{ return _position; }
            set{ _position = value; }
        }        
		/// <summary>
		/// parent_id
        /// </summary>		
		private int _parent_id;
        public int Parent_Id
        {
            get{ return _parent_id; }
            set{ _parent_id = value; }
        }        
		/// <summary>
		/// photo_img
        /// </summary>		
		private string _photo_img;
        public string Photo_Img
        {
            get{ return _photo_img; }
            set{ _photo_img = value; }
        }        
		/// <summary>
		/// job_number
        /// </summary>		
		private string _job_number;
        public string Job_Number
        {
            get{ return _job_number; }
            set{ _job_number = value; }
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
		/// phone
        /// </summary>		
		private string _phone;
        public string Phone
        {
            get{ return _phone; }
            set{ _phone = value; }
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
		/// score
        /// </summary>		
		private decimal _score;
        public decimal Score
        {
            get{ return _score; }
            set{ _score = value; }
        }        
				
		public class Query
        {

        }
   
	}
}