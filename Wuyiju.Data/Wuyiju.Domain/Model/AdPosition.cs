using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_ad_position
		public class AdPosition
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
		/// type
        /// </summary>		
		private string _type;
        public string Type
        {
            get{ return _type; }
            set{ _type = value; }
        }        
		/// <summary>
		/// width
        /// </summary>		
		private int _width;
        public int Width
        {
            get{ return _width; }
            set{ _width = value; }
        }        
		/// <summary>
		/// height
        /// </summary>		
		private int _height;
        public int Height
        {
            get{ return _height; }
            set{ _height = value; }
        }        
		/// <summary>
		/// description
        /// </summary>		
		private string _description;
        public string Description
        {
            get{ return _description; }
            set{ _description = value; }
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
				
		public class Query
        {

        }
   
	}
}