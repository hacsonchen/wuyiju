using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControl;
using Wuyiju.Core;
using Wuyiju.IService;

namespace Wuyiju.Web.UserControls
{
    public class ArticleRepeater : Repeater
    {
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

        public virtual int? CatID
        {
            get
            {
                object val = this.ViewState["CatID"];
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
                this.ViewState["CatID"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var unity = new UnityContext();
            var articleService = unity.GetInstance<IArticleService>();
            if (Limit == null)
            {
                this.DataSource = articleService.GetList(new Model.Article.Query { Cate_Id = CatID, Status = 1 });
                this.DataBind();
            }
            else
            {
                this.DataSource = articleService.GetList(new Model.Article.Query { Cate_Id = CatID, Status = 1 }, Limit.Value);
                this.DataBind();
            }
        }
    }
}