using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_role_user
		public class RoleUser
	{
   		     
      	/// <summary>
		/// role_id
        /// </summary>		
		private int _role_id;
        public int Role_Id
        {
            get{ return _role_id; }
            set{ _role_id = value; }
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
				
		public class Query
        {

        }
   
	}
}