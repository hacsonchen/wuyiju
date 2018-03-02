using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_auth_item
		public class AuthItem
	{
   		     
      	/// <summary>
		/// auth_code
        /// </summary>		
		private string _auth_code;
        public string Auth_Code
        {
            get{ return _auth_code; }
            set{ _auth_code = value; }
        }        
		/// <summary>
		/// auth_title
        /// </summary>		
		private string _auth_title;
        public string Auth_Title
        {
            get{ return _auth_title; }
            set{ _auth_title = value; }
        }        
		/// <summary>
		/// auth_day
        /// </summary>		
		private string _auth_day;
        public string Auth_Day
        {
            get{ return _auth_day; }
            set{ _auth_day = value; }
        }        
		/// <summary>
		/// auth_small_ico
        /// </summary>		
		private string _auth_small_ico;
        public string Auth_Small_Ico
        {
            get{ return _auth_small_ico; }
            set{ _auth_small_ico = value; }
        }        
		/// <summary>
		/// auth_small_n_ico
        /// </summary>		
		private string _auth_small_n_ico;
        public string Auth_Small_N_Ico
        {
            get{ return _auth_small_n_ico; }
            set{ _auth_small_n_ico = value; }
        }        
		/// <summary>
		/// auth_big_ico
        /// </summary>		
		private string _auth_big_ico;
        public string Auth_Big_Ico
        {
            get{ return _auth_big_ico; }
            set{ _auth_big_ico = value; }
        }        
		/// <summary>
		/// auth_desc
        /// </summary>		
		private string _auth_desc;
        public string Auth_Desc
        {
            get{ return _auth_desc; }
            set{ _auth_desc = value; }
        }        
		/// <summary>
		/// auth_cash
        /// </summary>		
		private decimal _auth_cash;
        public decimal Auth_Cash
        {
            get{ return _auth_cash; }
            set{ _auth_cash = value; }
        }        
		/// <summary>
		/// auth_expir
        /// </summary>		
		private int _auth_expir;
        public int Auth_Expir
        {
            get{ return _auth_expir; }
            set{ _auth_expir = value; }
        }        
		/// <summary>
		/// auth_open
        /// </summary>		
		private int _auth_open;
        public int Auth_Open
        {
            get{ return _auth_open; }
            set{ _auth_open = value; }
        }        
		/// <summary>
		/// auth_show
        /// </summary>		
		private int _auth_show;
        public int Auth_Show
        {
            get{ return _auth_show; }
            set{ _auth_show = value; }
        }        
		/// <summary>
		/// muti_auth
        /// </summary>		
		private int _muti_auth;
        public int Muti_Auth
        {
            get{ return _muti_auth; }
            set{ _muti_auth = value; }
        }        
		/// <summary>
		/// update_time
        /// </summary>		
		private int _update_time;
        public int Update_Time
        {
            get{ return _update_time; }
            set{ _update_time = value; }
        }        
		/// <summary>
		/// auth_dir
        /// </summary>		
		private string _auth_dir;
        public string Auth_Dir
        {
            get{ return _auth_dir; }
            set{ _auth_dir = value; }
        }        
		/// <summary>
		/// listorder
        /// </summary>		
		private int _listorder;
        public int Listorder
        {
            get{ return _listorder; }
            set{ _listorder = value; }
        }        
		/// <summary>
		/// config
        /// </summary>		
		private string _config;
        public string Config
        {
            get{ return _config; }
            set{ _config = value; }
        }        
				
		public class Query
        {

        }
   
	}
}