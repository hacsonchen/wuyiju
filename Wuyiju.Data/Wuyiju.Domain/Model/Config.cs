using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Web.Script.Serialization;

namespace Wuyiju.Model
{
    //ec_config
    public class Config
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
        /// config
        /// </summary>		
        private string _config;
        public string config
        {
            get { return _config; }
            set { _config = value; }
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
        /// site_id
        /// </summary>		
        private int _site_id;
        public int Site_Id
        {
            get { return _site_id; }
            set { _site_id = value; }
        }


        public string GetValue(string key)
        {
            var jss = new JavaScriptSerializer();

            if (!_config.IsNullOrWhiteSpace())
            {
                try
                {
                    var map = jss.Deserialize<Dictionary<string, string>>(_config);
                    return map[key];
                }
                catch
                {
                    return null;
                }
            }

            return null;

        }

        public class Query
        {

        }

    }
}