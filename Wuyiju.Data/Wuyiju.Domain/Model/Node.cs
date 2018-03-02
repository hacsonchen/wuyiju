using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_node
		public class Node
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
		/// name
        /// </summary>		
		private string _name;
        public string Name
        {
            get{ return _name; }
            set{ _name = value; }
        }        
		/// <summary>
		/// title
        /// </summary>		
		private string _title;
        public string Title
        {
            get{ return _title; }
            set{ _title = value; }
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
		/// remark
        /// </summary>		
		private string _remark;
        public string Remark
        {
            get{ return _remark; }
            set{ _remark = value; }
        }        
		/// <summary>
		/// sort
        /// </summary>		
		private int _sort;
        public int Sort
        {
            get{ return _sort; }
            set{ _sort = value; }
        }        
		/// <summary>
		/// pid
        /// </summary>		
		private int _pid;
        public int Pid
        {
            get{ return _pid; }
            set{ _pid = value; }
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
        /// Controler
        /// </summary>		
        private string _controler;
        public string Controler
        {
            get { return _controler; }
            set { _controler = value; }
        }

        /// <summary>
        /// action
        /// </summary>		
        private string _action;
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }


        /// <summary>
		/// isallowednoneroles
        /// </summary>		
		private int _isallowednoneroles;
        public int Isallowednoneroles
        {
            get { return _isallowednoneroles; }
            set { _isallowednoneroles = value; }
        }

        /// <summary>
		/// iscontroler
        /// </summary>		
		private int _iscontroler;
        public int Iscontroler
        {
            get { return _iscontroler; }
            set { _iscontroler = value; }
        }

        public class Query
        {

        }
   
	}
}