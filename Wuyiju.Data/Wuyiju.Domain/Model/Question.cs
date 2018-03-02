using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Wuyiju.Domain.View;
using Wuyiju.Core;
namespace Wuyiju.Model
{
    //ec_question
    public class Question
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
        /// type_id
        /// </summary>		
        private int _type_id;
        public int Type_Id
        {
            get { return _type_id; }
            set { _type_id = value; }
        }
        /// <summary>
        /// title
        /// </summary>		
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        /// <summary>
        /// from
        /// </summary>		
        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
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
        /// url
        /// </summary>		
        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        /// <summary>
        /// resp
        /// </summary>		
        private string _resp;
        public string Resp
        {
            get { return _resp; }
            set { _resp = value; }
        }
        /// <summary>
        /// info
        /// </summary>		
        private string _info;
        public string Info
        {
            get { return _info; }
            set { _info = value; }
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

        public string AddDate
        {
            get
            {
                Time time = new Time();
                return time.GetTime(_add_time.ToString()).ToString();
            }
        }

        /// <summary>
        /// sort_order
        /// </summary>		
        private int _sort_order;
        public int Sort_Order
        {
            get { return _sort_order; }
            set { _sort_order = value; }
        }
        /// <summary>
        /// resp_time
        /// </summary>		
        private int _resp_time;
        public int Resp_Time
        {
            get { return _resp_time; }
            set { _resp_time = value; }
        }

        public DateTime? RespTime
        {
            get
            {
                if (_resp_time == 0) return null;
                return ((long)_resp_time).ToDateTime2();
            }
        }

        public DateTime? AddTime
        {
            get
            {
                if (_add_time == 0) return null;
                return _add_time.ToDateTime2();
            }
        }
        /// <summary>
        /// is_best
        /// </summary>		
        private int _is_best;
        public int Is_Best
        {
            get { return _is_best; }
            set { _is_best = value; }
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
        /// filename
        /// </summary>		
        private string _filename;
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        /// <summary>
        /// click
        /// </summary>		
        private int _click;
        public int Click
        {
            get { return _click; }
            set { _click = value; }
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

        public string Username { get; set; }

        /// <summary>
        /// type_id
        /// </summary>		
        private string _type_name;
        public string Type_Name
        {
            get { return _type_name; }
            set { _type_name = value; }
        }

        public string StatusText
        {
            get
            {
                if (_status == 1) return "已回答";
                if (_status == 0) return "提问中";
                return "";
            }
        }

        public class Query
        {
            public int? Type_Id { get; set; }

            public int? User_Id { get; set; }

            public int? Status { get; set; }

            public int? Is_Best { get; set; }



        }

    }
}