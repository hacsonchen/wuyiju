using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Wuyiju.Domain.View;
namespace Wuyiju.Model{
	 	//ec_finance_account
		public class FinanceAccount
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
		/// user_id
        /// </summary>		
		private int _user_id;
        public int User_Id
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// username
        /// </summary>		
		private string _username;
        public string Username
        {
            get{ return _username; }
            set{ _username = value; }
        }        
		/// <summary>
		/// money
        /// </summary>		
		private decimal _money;
        public decimal Money
        {
            get{ return _money; }
            set{ _money = value; }
        }        
		/// <summary>
		/// frozen_money
        /// </summary>		
		private decimal _frozen_money;
        public decimal Frozen_Money
        {
            get{ return _frozen_money; }
            set{ _frozen_money = value; }
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
		/// points
        /// </summary>		
		private int _points;
        public int Points
        {
            get{ return _points; }
            set{ _points = value; }
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

        public string AddDate
        {
            get
            {
                Time time = new Time();
                return time.GetTime(_add_time.ToString()).ToString();
            }
        }

        /// <summary>
        /// desc
        /// </summary>		
        private string _descm;
        public string Descm
        {
            get{ return _descm; }
            set{ _descm = value; }
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

        }
   
	}
}