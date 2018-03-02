using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_links
		public class Links
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
		/// company
        /// </summary>		
		private string _company;
        public string Company
        {
            get{ return _company; }
            set{ _company = value; }
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
		/// url
        /// </summary>		
		private string _url;
        public string Url
        {
            get{ return _url; }
            set{ _url = value; }
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
		/// status
        /// </summary>		
		private int _status;
        public int Status
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// start_time
        /// </summary>		
		private string _start_time;
        public string Start_Time
        {
            get{ return _start_time; }
            set{ _start_time = value; }
        }        
		/// <summary>
		/// end_time
        /// </summary>		
		private string _end_time;
        public string End_Time
        {
            get{ return _end_time; }
            set{ _end_time = value; }
        }        
		/// <summary>
		/// keyword
        /// </summary>		
		private string _keyword;
        public string Keyword
        {
            get{ return _keyword; }
            set{ _keyword = value; }
        }        
		/// <summary>
		/// brief
        /// </summary>		
		private string _brief;
        public string Brief
        {
            get{ return _brief; }
            set{ _brief = value; }
        }        
		/// <summary>
		/// contact
        /// </summary>		
		private string _contact;
        public string Contact
        {
            get{ return _contact; }
            set{ _contact = value; }
        }        
		/// <summary>
		/// phone
        /// </summary>		
		private int _phone;
        public int Phone
        {
            get{ return _phone; }
            set{ _phone = value; }
        }        
		/// <summary>
		/// qq
        /// </summary>		
		private int _qq;
        public int Qq
        {
            get{ return _qq; }
            set{ _qq = value; }
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
		/// category
        /// </summary>		
		private int _category;
        public int Category
        {
            get{ return _category; }
            set{ _category = value; }
        }        
		/// <summary>
		/// img
        /// </summary>		
		private string _img;
        public string Img
        {
            get{ return _img; }
            set{ _img = value; }
        }

        /// <summary>
        /// recommend
        /// </summary>		
        private int _linkstyle;
        public int Linkstyle
        {
            get { return _linkstyle; }
            set { _linkstyle = value; }
        }

        /// <summary>
        /// recommend
        /// </summary>		
        private int _recommend;
        public int Recommend
        {
            get{ return _recommend; }
            set{ _recommend = value; }
        }        
				
		public class Query
        {
            public int? Recommend { get; set; }

            public int? Status { get; set; }

        }
   
	}
}