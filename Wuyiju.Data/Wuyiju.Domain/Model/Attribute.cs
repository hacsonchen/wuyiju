using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Wuyiju.Model
{
    //ec_attribute
    public class Attribute
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
        /// name
        /// </summary>		
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// name
        /// </summary>		
        private string _parent_name;
        public string Parent_Name
        {
            get { return _parent_name; }
            set { _parent_name = value; }
        }
        /// <summary>
        /// pid
        /// </summary>		
        private int _pid;
        public int Pid
        {
            get { return _pid; }
            set { _pid = value; }
        }
        /// <summary>
        /// level
        /// </summary>		
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
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
        /// input
        /// </summary>		
        private int _input;
        public int Input
        {
            get { return _input; }
            set { _input = value; }
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
        /// recommend
        /// </summary>		
        private int _recommend;
        public int Recommend
        {
            get { return _recommend; }
            set { _recommend = value; }
        }
        /// <summary>
        /// extend1
        /// </summary>		
        private string _extend1;
        public string Extend1
        {
            get { return _extend1; }
            set { _extend1 = value; }
        }
        /// <summary>
        /// extend2
        /// </summary>		
        private string _extend2;
        public string Extend2
        {
            get { return _extend2; }
            set { _extend2 = value; }
        }

        public class Query
        {
            public int? Pid { get; set; }

            public int? Level { get; set; }

            public int? Status { get; set; }

            public int? Recommend { get; set; }

            public int? Input { get; set; }


        }

    }
}