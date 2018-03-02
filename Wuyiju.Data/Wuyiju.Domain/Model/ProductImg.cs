using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_product_img
		public class ProductImg
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
		/// product_id
        /// </summary>		
		private int _product_id;
        public int Product_Id
        {
            get{ return _product_id; }
            set{ _product_id = value; }
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
		/// thumb
        /// </summary>		
		private string _thumb;
        public string Thumb
        {
            get{ return _thumb; }
            set{ _thumb = value; }
        }        
		/// <summary>
		/// picture
        /// </summary>		
		private string _picture;
        public string Picture
        {
            get{ return _picture; }
            set{ _picture = value; }
        }        
				
		public class Query
        {

        }
   
	}
}