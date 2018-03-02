using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_complaint
		public class Complaint
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
		/// uid
        /// </summary>		
		private int _uid;
        public int Uid
        {
            get{ return _uid; }
            set{ _uid = value; }
        }        
		/// <summary>
		/// tszname
        /// </summary>		
		private string _tszname;
        public string Tszname
        {
            get{ return _tszname; }
            set{ _tszname = value; }
        }        
		/// <summary>
		/// tszmobile
        /// </summary>		
		private string _tszmobile;
        public string Tszmobile
        {
            get{ return _tszmobile; }
            set{ _tszmobile = value; }
        }        
		/// <summary>
		/// tszqq
        /// </summary>		
		private string _tszqq;
        public string Tszqq
        {
            get{ return _tszqq; }
            set{ _tszqq = value; }
        }        
		/// <summary>
		/// ywname
        /// </summary>		
		private string _ywname;
        public string Ywname
        {
            get{ return _ywname; }
            set{ _ywname = value; }
        }        
		/// <summary>
		/// body
        /// </summary>		
		private string _body;
        public string Body
        {
            get{ return _body; }
            set{ _body = value; }
        }        
		/// <summary>
		/// tspic1
        /// </summary>		
		private string _tspic1;
        public string Tspic1
        {
            get{ return _tspic1; }
            set{ _tspic1 = value; }
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
		/// resp_time
        /// </summary>		
		private int _resp_time;
        public int Resp_Time
        {
            get{ return _resp_time; }
            set{ _resp_time = value; }
        }        
		/// <summary>
		/// click
        /// </summary>		
		private int _click;
        public int Click
        {
            get{ return _click; }
            set{ _click = value; }
        }        
		/// <summary>
		/// anonmity
        /// </summary>		
		private int _anonmity;
        public int Anonmity
        {
            get{ return _anonmity; }
            set{ _anonmity = value; }
        }        
		/// <summary>
		/// savepath
        /// </summary>		
		private string _savepath;
        public string Savepath
        {
            get{ return _savepath; }
            set{ _savepath = value; }
        }        
		/// <summary>
		/// resp
        /// </summary>		
		private string _resp;
        public string Resp
        {
            get{ return _resp; }
            set{ _resp = value; }
        }        
				
		public class Query
        {

        }
   
	}
}