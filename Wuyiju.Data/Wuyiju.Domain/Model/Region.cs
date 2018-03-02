using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_region
		public class Region
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _region_id;
        public int Region_Id
        {
            get{ return _region_id; }
            set{ _region_id = value; }
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
		/// region_name
        /// </summary>		
		private string _region_name;
        public string Region_Name
        {
            get{ return _region_name; }
            set{ _region_name = value; }
        }        
		/// <summary>
		/// region_type
        /// </summary>		
		private int _region_type;
        public int Region_Type
        {
            get{ return _region_type; }
            set{ _region_type = value; }
        }        
		/// <summary>
		/// agency_id
        /// </summary>		
		private int _agency_id;
        public int Agency_Id
        {
            get{ return _agency_id; }
            set{ _agency_id = value; }
        }        
				
		public class Query
        {
            public int? Parent_Id { get; set; }
        }
   
	}
}