using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        private LoggedState loggedState;

        public LoggedState LoggedState
        {
            get
            {
                if (loggedState == null)
                    loggedState = new LoggedState(this.Context);
                return loggedState;
            }
        }

        public User LoggedUser
        {
            get { return this.LoggedState.Entry; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
    }
}