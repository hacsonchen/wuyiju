using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_user_consignee
		public class UserConsignee
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
		/// user_id
        /// </summary>		
		private int _user_id;
        public int User_Id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// region_lv1
        /// </summary>		
		private int _region_lv1;
        public int Region_Lv1
        {
            get{ return _region_lv1; }
            set{ _region_lv1 = value; }
        }        
		/// <summary>
		/// region_lv2
        /// </summary>		
		private int _region_lv2;
        public int Region_Lv2
        {
            get{ return _region_lv2; }
            set{ _region_lv2 = value; }
        }        
		/// <summary>
		/// region_lv3
        /// </summary>		
		private int _region_lv3;
        public int Region_Lv3
        {
            get{ return _region_lv3; }
            set{ _region_lv3 = value; }
        }        
		/// <summary>
		/// region_lv4
        /// </summary>		
		private int _region_lv4;
        public int Region_Lv4
        {
            get{ return _region_lv4; }
            set{ _region_lv4 = value; }
        }        
		/// <summary>
		/// address
        /// </summary>		
		private string _address;
        public string Address
        {
            get{ return _address; }
            set{ _address = value; }
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
		/// phone
        /// </summary>		
		private string _phone;
        public string Phone
        {
            get{ return _phone; }
            set{ _phone = value; }
        }        
		/// <summary>
		/// consignee
        /// </summary>		
		private string _consignee;
        public string Consignee
        {
            get{ return _consignee; }
            set{ _consignee = value; }
        }        
		/// <summary>
		/// zip
        /// </summary>		
		private string _zip;
        public string Zip
        {
            get{ return _zip; }
            set{ _zip = value; }
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
		/// email
        /// </summary>		
		private string _email;
        public string Email
        {
            get{ return _email; }
            set{ _email = value; }
        }        
		/// <summary>
		/// create_time
        /// </summary>		
		private int _create_time;
        public int Create_Time
        {
            get{ return _create_time; }
            set{ _create_time = value; }
        }        
		/// <summary>
		/// fax
        /// </summary>		
		private string _fax;
        public string Fax
        {
            get{ return _fax; }
            set{ _fax = value; }
        }        
		/// <summary>
		/// is_def
        /// </summary>		
		private int _is_def;
        public int Is_Def
        {
            get{ return _is_def; }
            set{ _is_def = value; }
        }        
		/// <summary>
		/// region_values
        /// </summary>		
		private string _region_values;
        public string Region_Values
        {
            get{ return _region_values; }
            set{ _region_values = value; }
        }        
				
		public class Query
        {

        }
   
	}
}