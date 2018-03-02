using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_product_attr
		public class ProductAttr
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
		/// attr_pid
        /// </summary>		
		private int _attr_pid;
        public int Attr_Pid
        {
            get{ return _attr_pid; }
            set{ _attr_pid = value; }
        }        
		/// <summary>
		/// attr_id
        /// </summary>		
		private int _attr_id;
        public int Attr_Id
        {
            get{ return _attr_id; }
            set{ _attr_id = value; }
        }        
		/// <summary>
		/// attr_value
        /// </summary>		
		private string _attr_value;
        public string Attr_Value
        {
            get{ return _attr_value; }
            set{ _attr_value = value; }
        }        
		/// <summary>
		/// input
        /// </summary>		
		private int _input;
        public int Input
        {
            get{ return _input; }
            set{ _input = value; }
        }
        
        public string Attr_Name { get; set; }        
				
		public class Query
        {
            public int? Product_Id { get; set; }

            public int? Recommend { get; set; }

            public int? Type { get; set; }

            public int? Attr_Id { get; set; }
        }
   
	}
}