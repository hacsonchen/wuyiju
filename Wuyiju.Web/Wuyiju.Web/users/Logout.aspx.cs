﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class Logout : UserPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoggedState.Clear();
            Response.Redirect("/Users/Login.aspx");
        }
    }
}