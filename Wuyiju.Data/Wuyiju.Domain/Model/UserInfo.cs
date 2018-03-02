using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Wuyiju.Model{
	 	//ec_user_info
		public class UserInfo
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
		/// region_lv1
        /// </summary>		
		private int _region_lv1;
        public int Region_Lv1
        {
            get{ return _region_lv1; }
            set{ _region_lv1 = value; }
        }        
		/// <summary>
		/// region_lv2
        /// </summary>		
		private int _region_lv2;
        public int Region_Lv2
        {
            get{ return _region_lv2; }
            set{ _region_lv2 = value; }
        }        
		/// <summary>
		/// region_lv3
        /// </summary>		
		private int _region_lv3;
        public int Region_Lv3
        {
            get{ return _region_lv3; }
            set{ _region_lv3 = value; }
        }        
		/// <summary>
		/// region_lv4
        /// </summary>		
		private int _region_lv4;
        public int Region_Lv4
        {
            get{ return _region_lv4; }
            set{ _region_lv4 = value; }
        }        
		/// <summary>
		/// region_values
        /// </summary>		
		private string _region_values;
        public string Region_Values
        {
            get{ return _region_values; }
            set{ _region_values = value; }
        }        
		/// <summary>
		/// sex
        /// </summary>		
		private int _sex;
        public int Sex
        {
            get{ return _sex; }
            set{ _sex = value; }
        }        
		/// <summary>
		/// brithday
        /// </summary>		
		private string _brithday;
        public string Brithday
        {
            get{ return _brithday; }
            set{ _brithday = value; }
        }        
		/// <summary>
		/// blog
        /// </summary>		
		private string _blog;
        public string Blog
        {
            get{ return _blog; }
            set{ _blog = value; }
        }        
		/// <summary>
		/// info
        /// </summary>		
		private string _info;
        public string Info
        {
            get{ return _info; }
            set{ _info = value; }
        }        
		/// <summary>
		/// share_num
        /// </summary>		
		private int _share_num;
        public int Share_Num
        {
            get{ return _share_num; }
            set{ _share_num = value; }
        }        
		/// <summary>
		/// like_num
        /// </summary>		
		private int _like_num;
        public int Like_Num
        {
            get{ return _like_num; }
            set{ _like_num = value; }
        }        
		/// <summary>
		/// follow_num
        /// </summary>		
		private int _follow_num;
        public int Follow_Num
        {
            get{ return _follow_num; }
            set{ _follow_num = value; }
        }        
		/// <summary>
		/// fans_num
        /// </summary>		
		private int _fans_num;
        public int Fans_Num
        {
            get{ return _fans_num; }
            set{ _fans_num = value; }
        }        
		/// <summary>
		/// constellation
        /// </summary>		
		private int _constellation;
        public int Constellation
        {
            get{ return _constellation; }
            set{ _constellation = value; }
        }        
		/// <summary>
		/// job
        /// </summary>		
		private int _job;
        public int Job
        {
            get{ return _job; }
            set{ _job = value; }
        }        
		/// <summary>
		/// qq
        /// </summary>		
		private string _qq;
        public string Qq
        {
            get{ return _qq; }
            set{ _qq = value; }
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
		/// rank
        /// </summary>		
		private int _rank;
        public int Rank
        {
            get{ return _rank; }
            set{ _rank = value; }
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
		/// forum
        /// </summary>		
		private int _forum;
        public int Forum
        {
            get{ return _forum; }
            set{ _forum = value; }
        }        
		/// <summary>
		/// salt
        /// </summary>		
		private string _salt;
        public string Salt
        {
            get{ return _salt; }
            set{ _salt = value; }
        }        
		/// <summary>
		/// is_validated
        /// </summary>		
		private int _is_validated;
        public int Is_Validated
        {
            get{ return _is_validated; }
            set{ _is_validated = value; }
        }        
				
		public class Query
        {

        }
   
	}
}