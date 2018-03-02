using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web.users
{
    public partial class GetRegion : BasePage
    {
        public IList<Region> regions;

        protected void Page_Load(object sender, EventArgs e)
        {

            var pid = Request.Form["region"].TryParseToInt32(-1);
            var svr = unity.GetInstance<IRegionService>();
            regions = svr.GetList(new Model.Region.Query { Parent_Id = pid  });
        }
    }
}