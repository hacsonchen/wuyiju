using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_user_score_setting
		public class UserScoreSetting
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
		/// points
        /// </summary>		
		private int _points;
        public int Points
        {
            get{ return _points; }
            set{ _points = value; }
        }        
		/// <summary>
		/// rank_points
        /// </summary>		
		private int _rank_points;
        public int Rank_Points
        {
            get{ return _rank_points; }
            set{ _rank_points = value; }
        }        
		/// <summary>
		/// code
        /// </summary>		
		private string _code;
        public string Code
        {
            get{ return _code; }
            set{ _code = value; }
        }        
				
		public class Query
        {

        }
   
	}
}