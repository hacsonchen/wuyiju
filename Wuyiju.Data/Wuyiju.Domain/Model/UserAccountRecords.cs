using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Wuyiju.Core;
namespace Wuyiju.Model{
	 	//ec_user_account_records
		public class UserAccountRecords
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
		/// balance
        /// </summary>		
		private decimal _balance;
        public decimal Balance
        {
            get{ return _balance; }
            set{ _balance = value; }
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
        
        public DateTime? AddTime
        {
            get
            {
                return _add_time.ToDateTime2();
            }
        }        
		/// <summary>
		/// desc
        /// </summary>		
		private string _desc;
        public string Desc
        {
            get{ return _desc; }
            set{ _desc = value; }
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
        
        public string TypeText
        {
            get
            {
                switch (_type)
                {
                    case 0: return PropertyType.Lang("uartype_0");
                    case 1: return PropertyType.Lang("uartype_1");
                    case 2: return PropertyType.Lang("uartype_2");
                    case 3: return PropertyType.Lang("uartype_3");
                    case 4: return PropertyType.Lang("uartype_4");
                    default:return string.Empty;
                }
            }
        }        
		/// <summary>
		/// way
        /// </summary>		
		private int _way;
        public int Way
        {
            get{ return _way; }
            set{ _way = value; }
        }        
				
		public class Query
        {

            public int? User_Id { get; set; }

            public decimal? Smoney { get; set; }

            public decimal? Emoney { get; set; }

            public decimal? FrozenSmoney { get; set; }

            public decimal? FrozenEmoney { get; set; }

            public DateTime? StartDate {get;set;}

            public DateTime? EndDate { get; set; }

            //public DateTime? FrozenStartDate { get; set; }

            //public DateTime? FrozenEndDate { get; set; }

            public string Keyword { get; set; }

            public int? Way { get; set; }

            public int?[] Check {get;set;}
                
        }
   
	}
}