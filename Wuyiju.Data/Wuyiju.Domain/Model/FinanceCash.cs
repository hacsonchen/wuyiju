using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_finance_cash
		public class FinanceCash
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
		/// uname
        /// </summary>		
		private string _uname;
        public string Uname
        {
            get{ return _uname; }
            set{ _uname = value; }
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
		/// points
        /// </summary>		
		private int _points;
        public int Points
        {
            get{ return _points; }
            set{ _points = value; }
        }        
		/// <summary>
		/// remark
        /// </summary>		
		private string _remark;
        public string Remark
        {
            get{ return _remark; }
            set{ _remark = value; }
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
		/// ip
        /// </summary>		
		private string _ip;
        public string Ip
        {
            get{ return _ip; }
            set{ _ip = value; }
        }        
		/// <summary>
		/// reply
        /// </summary>		
		private string _reply;
        public string Reply
        {
            get{ return _reply; }
            set{ _reply = value; }
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
		/// <summary>
		/// realname
        /// </summary>		
		private string _realname;
        public string Realname
        {
            get{ return _realname; }
            set{ _realname = value; }
        }        
		/// <summary>
		/// alipay
        /// </summary>		
		private string _alipay;
        public string Alipay
        {
            get{ return _alipay; }
            set{ _alipay = value; }
        }        
		/// <summary>
		/// is_money
        /// </summary>		
		private int _is_money;
        public int Is_Money
        {
            get{ return _is_money; }
            set{ _is_money = value; }
        }        
				
		public class Query
        {

        }
   
	}
}