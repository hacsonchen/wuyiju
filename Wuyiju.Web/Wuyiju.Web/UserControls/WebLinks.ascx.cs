using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wuyiju.Web.UserControls
{
    public partial class WebLinks : System.Web.UI.UserControl
    {

        /// <summary>
        /// 限制友情链接条数
        /// </summary>
        public virtual int? Limit
        {
            get
            {
                object val = this.ViewState["Limit"];
                if (val == null)
                    return null;
                return (int)val;

            }
            set
            {
                if (this.HasControls())
                {
                    this.Controls.Clear();
                }
                this.ViewState["Limit"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public override void RenderControl(HtmlTextWriter writer)
        {
            writer.WriteLine("Hello");
            base.RenderControl(writer);
        }
    }
}