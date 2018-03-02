using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_user_rank
		public class UserRank
	{
   		     
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private int _rank_id;
        public int Rank_Id
        {
            get{ return _rank_id; }
            set{ _rank_id = value; }
        }        
		/// <summary>
		/// rank_name
        /// </summary>		
		private string _rank_name;
        public string Rank_Name
        {
            get{ return _rank_name; }
            set{ _rank_name = value; }
        }        
		/// <summary>
		/// min_points
        /// </summary>		
		private int _min_points;
        public int Min_Points
        {
            get{ return _min_points; }
            set{ _min_points = value; }
        }        
		/// <summary>
		/// max_points
        /// </summary>		
		private int _max_points;
        public int Max_Points
        {
            get{ return _max_points; }
            set{ _max_points = value; }
        }        
		/// <summary>
		/// discount
        /// </summary>		
		private int _discount;
        public int Discount
        {
            get{ return _discount; }
            set{ _discount = value; }
        }        
		/// <summary>
		/// show_price
        /// </summary>		
		private int _show_price;
        public int Show_Price
        {
            get{ return _show_price; }
            set{ _show_price = value; }
        }        
		/// <summary>
		/// special_rank
        /// </summary>		
		private int _special_rank;
        public int Special_Rank
        {
            get{ return _special_rank; }
            set{ _special_rank = value; }
        }        
		/// <summary>
		/// extension_code
        /// </summary>		
		private string _extension_code;
        public string Extension_Code
        {
            get{ return _extension_code; }
            set{ _extension_code = value; }
        }        
				
		public class Query
        {

        }
   
	}
}