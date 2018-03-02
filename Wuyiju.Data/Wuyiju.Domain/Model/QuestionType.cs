using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_question_type
		public class QuestionType
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
		/// type_name
        /// </summary>		
		private string _type_name;
        public string Type_Name
        {
            get{ return _type_name; }
            set{ _type_name = value; }
        }        
		/// <summary>
		/// amount
        /// </summary>		
		private int _amount;
        public int Amount
        {
            get{ return _amount; }
            set{ _amount = value; }
        }        
				
		public class Query
        {

        }
   
	}
}