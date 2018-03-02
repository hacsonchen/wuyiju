using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_title
		public class Title
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
		/// scname
        /// </summary>		
		private string _scname;
        public string Scname
        {
            get{ return _scname; }
            set{ _scname = value; }
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
		/// parent_id
        /// </summary>		
		private int _parent_id;
        public int Parent_Id
        {
            get{ return _parent_id; }
            set{ _parent_id = value; }
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
		/// recommend
        /// </summary>		
		private int _recommend;
        public int Recommend
        {
            get{ return _recommend; }
            set{ _recommend = value; }
        }        
		/// <summary>
		/// color
        /// </summary>		
		private string _color;
        public string Color
        {
            get{ return _color; }
            set{ _color = value; }
        }        
		/// <summary>
		/// seo_title
        /// </summary>		
		private string _seo_title;
        public string Seo_Title
        {
            get{ return _seo_title; }
            set{ _seo_title = value; }
        }        
		/// <summary>
		/// seo_keys
        /// </summary>		
		private string _seo_keys;
        public string Seo_Keys
        {
            get{ return _seo_keys; }
            set{ _seo_keys = value; }
        }        
		/// <summary>
		/// seo_desc
        /// </summary>		
		private string _seo_desc;
        public string Seo_Desc
        {
            get{ return _seo_desc; }
            set{ _seo_desc = value; }
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
		/// content
        /// </summary>		
		private string _content;
        public string Content
        {
            get{ return _content; }
            set{ _content = value; }
        }        
		/// <summary>
		/// style_file
        /// </summary>		
		private string _style_file;
        public string Style_File
        {
            get{ return _style_file; }
            set{ _style_file = value; }
        }        
		/// <summary>
		/// show_in_nav
        /// </summary>		
		private string _show_in_nav;
        public string Show_In_Nav
        {
            get{ return _show_in_nav; }
            set{ _show_in_nav = value; }
        }        
		/// <summary>
		/// filter_attr
        /// </summary>		
		private string _filter_attr;
        public string Filter_Attr
        {
            get{ return _filter_attr; }
            set{ _filter_attr = value; }
        }        
		/// <summary>
		/// folder
        /// </summary>		
		private string _folder;
        public string Folder
        {
            get{ return _folder; }
            set{ _folder = value; }
        }        
		/// <summary>
		/// filename
        /// </summary>		
		private string _filename;
        public string Filename
        {
            get{ return _filename; }
            set{ _filename = value; }
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
		/// is_hots
        /// </summary>		
		private int _is_hots;
        public int Is_Hots
        {
            get{ return _is_hots; }
            set{ _is_hots = value; }
        }        
		/// <summary>
		/// url_type
        /// </summary>		
		private int _url_type;
        public int Url_Type
        {
            get{ return _url_type; }
            set{ _url_type = value; }
        }

        /// <summary>
        /// Levle
        /// </summary>		
        private int _level;
        public int Levle
        {
            get { return _level; }
            set { _level = value; }
        }

        public class Query
        {
            public int? Parent_Id { get; set; }
            public int? Status { get; set; }
            public int? Recommend { get; set; }
            public int? Show_In_Nav { get; set; }
            public int? Type { get; set; }
            public int? Is_Hots { get; set; }
            public int? Url_Type { get; set; }

        }
   
	}
}