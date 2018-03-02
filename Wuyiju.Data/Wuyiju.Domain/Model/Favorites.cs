using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_favorites
		public class Favorites
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _rec_id;
        public int Rec_Id
        {
            get{ return _rec_id; }
            set{ _rec_id = value; }
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
		/// add_time
        /// </summary>		
		private long _add_time;
        public long Add_Time
        {
            get{ return _add_time; }
            set{ _add_time = value; }
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
				
		public class Query
        {
            public int? Type { get; set; }

            public int? Product_Id { get; set; }

            public int? User_Id { get; set; }
        }
   
	}
}