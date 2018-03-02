using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;

namespace Wuyiju.Web.UserControls
{
    public partial class WebMenu : System.Web.UI.UserControl
    {
        public IList<Model.Attribute> attributes;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            var unity = new UnityContext();

            var svr = unity.GetInstance<IAttributeService>();
            attributes = svr.GetList(new Model.Attribute.Query {  Status = 1 });


        }
    }
}