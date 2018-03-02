using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_access
		public class Access
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
		/// node_id
        /// </summary>		
		private int _node_id;
        public int Node_Id
        {
            get{ return _node_id; }
            set{ _node_id = value; }
        }        
		/// <summary>
		/// level
        /// </summary>		
		private int _level;
        public int Level
        {
            get{ return _level; }
            set{ _level = value; }
        }        
		/// <summary>
		/// module
        /// </summary>		
		private string _module;
        public string Module
        {
            get{ return _module; }
            set{ _module = value; }
        }        
				
		public class Query
        {

        }
   
	}
}