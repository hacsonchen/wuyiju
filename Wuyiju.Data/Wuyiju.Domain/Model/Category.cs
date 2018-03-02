using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Wuyiju.Model
{
    //ec_category
    public class Category
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
        /// type
        /// </summary>		
        private int _type;
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// parent_id
        /// </summary>		
        private int _parent_id;
        public int Parent_Id
        {
            get { return _parent_id; }
            set { _parent_id = value; }
        }
        /// <summary>
        /// name
        /// </summary>		
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// brief
        /// </summary>		
        private string _brief;
        public string Brief
        {
            get { return _brief; }
            set { _brief = value; }
        }
        /// <summary>
        /// seo_title
        /// </summary>		
        private string _seo_title;
        public string Seo_Title
        {
            get { return _seo_title; }
            set { _seo_title = value; }
        }
        /// <summary>
        /// seo_keys
        /// </summary>		
        private string _seo_keys;
        public string Seo_Keys
        {
            get { return _seo_keys; }
            set { _seo_keys = value; }
        }
        /// <summary>
        /// seo_desc
        /// </summary>		
        private string _seo_desc;
        public string Seo_Desc
        {
            get { return _seo_desc; }
            set { _seo_desc = value; }
        }
        /// <summary>
        /// img
        /// </summary>		
        private string _img;
        public string Img
        {
            get { return _img; }
            set { _img = value; }
        }
        /// <summary>
        /// sort
        /// </summary>		
        private int _sort;
        public int Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
        /// <summary>
        /// status
        /// </summary>		
        private int _status;
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        /// <summary>
        /// is_hot
        /// </summary>		
        private int _is_hot;
        public int Is_Hot
        {
            get { return _is_hot; }
            set { _is_hot = value; }
        }
        /// <summary>
        /// is_recommend
        /// </summary>		
        private int _is_recommend;
        public int Is_Recommend
        {
            get { return _is_recommend; }
            set { _is_recommend = value; }
        }
        /// <summary>
        /// show_in_nav
        /// </summary>		
        private int _show_in_nav;
        public int Show_In_Nav
        {
            get { return _show_in_nav; }
            set { _show_in_nav = value; }
        }
        /// <summary>
        /// bank_id
        /// </summary>		
        private int _bank_id;
        public int Bank_Id
        {
            get { return _bank_id; }
            set { _bank_id = value; }
        }
        /// <summary>
        /// is_extend
        /// </summary>		
        private int _is_extend;
        public int Is_Extend
        {
            get { return _is_extend; }
            set { _is_extend = value; }
        }
        /// <summary>
        /// filter_attr
        /// </summary>		
        private string _filter_attr;
        public string Filter_Attr
        {
            get { return _filter_attr; }
            set { _filter_attr = value; }
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
        /// <summary>
        /// admin_id
        /// </summary>		
        private int _admin_id;
        public int Admin_Id
        {
            get { return _admin_id; }
            set { _admin_id = value; }
        }
        /// <summary>
        /// is_del
        /// </summary>		
        private int _is_del;
        public int Is_Del
        {
            get { return _is_del; }
            set { _is_del = value; }
        }
        /// <summary>
        /// css_cla
        /// </summary>		
        private string _css_cla;
        public string Css_Cla
        {
            get { return _css_cla; }
            set { _css_cla = value; }
        }

        /// <summary>
        /// Levle
        /// </summary>		
        private int _level;
        public int Levle
        {
            get { return _level; }
            set { _level = value; }
        }

        public class Query
        {
            public int? Status { get; set; }

            public int? Parent_Id { get; set; }

            public int? Recommend { get; set; }

        }

    }
}