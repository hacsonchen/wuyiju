using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Wuyiju.Model
{
    //ec_deposit_bank_card
    public class DepositBankCard
    {

        /// <summary>
        /// auto_increment
        /// </summary>		
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// user_id
        /// </summary>		
        private int _user_id;
        public int User_Id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        /// <summary>
        /// real_name
        /// </summary>		
        private string _real_name;
        public string Real_Name
        {
            get { return _real_name; }
            set { _real_name = value; }
        }
        /// <summary>
        /// region_lv1
        /// </summary>		
        private int _region_lv1;
        public int Region_Lv1
        {
            get { return _region_lv1; }
            set { _region_lv1 = value; }
        }
        /// <summary>
        /// region_lv2
        /// </summary>		
        private int _region_lv2;
        public int Region_Lv2
        {
            get { return _region_lv2; }
            set { _region_lv2 = value; }
        }
        /// <summary>
        /// region_lv3
        /// </summary>		
        private int _region_lv3;
        public int Region_Lv3
        {
            get { return _region_lv3; }
            set { _region_lv3 = value; }
        }
        /// <summary>
        /// bank_name
        /// </summary>		
        private string _bank_name;
        public string Bank_Name
        {
            get { return _bank_name; }
            set { _bank_name = value; }
        }
        /// <summary>
        /// bank_subname
        /// </summary>		
        private string _bank_subname;
        public string Bank_Subname
        {
            get { return _bank_subname; }
            set { _bank_subname = value; }
        }
        /// <summary>
        /// card_number
        /// </summary>		
        private string _card_number;
        public string Card_Number
        {
            get { return _card_number; }
            set { _card_number = value; }
        }
        /// <summary>
        /// add_time
        /// </summary>		
        private long _add_time;
        public long Add_Time
        {
            get { return _add_time; }
            set { _add_time = value; }
        }

        public class Query
        {
            public int? User_Id { get; set; }
        }

    }
}